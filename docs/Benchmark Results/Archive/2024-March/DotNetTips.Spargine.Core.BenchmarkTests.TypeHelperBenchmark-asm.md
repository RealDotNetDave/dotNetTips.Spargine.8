## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.CreateStringBuilder01()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
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
       mov       rcx,1BD2A000428
       mov       r13,[rcx]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFDF02FB758]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Email()
       mov       r12,rax
       mov       rcx,r15
       call      qword ptr [7FFDF02FB778]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       [rsp+38],r12
       mov       [rsp+40],rax
       lea       rcx,[rsp+38]
       mov       rdx,r13
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+30],2
       mov       rcx,rsi
       lea       r9,[rsp+28]
       mov       r8,1FDB8192EE0
       call      qword ptr [7FFDF014C930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       inc       r14d
       jmp       near ptr M00_L00
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFDF013B060]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFDF06066A0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
M00_L03:
       call      qword ptr [7FFDF009EFB8]
       int       3
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 321
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Email()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7358],0
       cmp       dword ptr [7FFDF01C7358],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].get_Id()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,28
       sub       rsp,28
       lea       rbp,[rsp+30]
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7358],0
       cmp       dword ptr [7FFDF01C7358],0
       je        short M02_L00
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rax,[rbp+10]
M02_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+30]
       mov       rax,[rax+30]
       add       rsp,28
       add       rsp,28
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 88
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
       je        near ptr M03_L63
       test      rdi,rdi
       je        near ptr M03_L24
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rdx
       jne       near ptr M03_L64
       xor       edx,edx
M03_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FFDEFEE43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M03_L01:
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jbe       near ptr M03_L19
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
       call      qword ptr [7FFDF01BDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+9C],eax
       test      eax,eax
       jl        near ptr M03_L54
       cmp       eax,[rsp+78]
       ja        near ptr M03_L61
       mov       rdx,[rsp+30]
       mov       r8d,eax
       test      r8d,r8d
       je        short M03_L05
       mov       r8,[rsi+8]
       mov       r10d,[rsi+18]
       mov       [rsp+8C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M03_L04
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jg        near ptr M03_L20
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       je        short M03_L03
M03_L02:
       mov       eax,[rsp+9C]
       mov       ecx,eax
       add       ecx,[rsp+8C]
       mov       [rsi+18],ecx
       jmp       short M03_L05
M03_L03:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M03_L02
M03_L04:
       mov       rcx,rsi
       mov       r8d,eax
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+9C]
M03_L05:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M03_L65
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       ecx,r13d
       movzx     eax,word ptr [rbx+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M03_L26
       cmp       edx,7B
       jne       near ptr M03_L55
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       mov       [rsp+38],r9
       xor       r11d,r11d
       mov       [rsp+7C],r11d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M03_L56
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M03_L28
M03_L06:
       inc       r13d
       xor       r12d,r12d
       xor       ecx,ecx
       mov       [rsp+50],rcx
       cmp       eax,r14d
       jae       near ptr M03_L60
       mov       edx,eax
       mov       rax,[rbp+rdx*8]
       mov       [rsp+48],rax
       test      r15,r15
       jne       near ptr M03_L41
M03_L07:
       test      r12,r12
       jne       near ptr M03_L14
       mov       [rsp+0A0],r10d
       test      r10d,r10d
       jne       short M03_L10
       mov       [rsp+0A4],r8d
       test      r8d,r8d
       jne       short M03_L09
M03_L08:
       mov       rdx,rax
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FFDEFEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       mov       rax,[rsp+48]
       jne       near ptr M03_L44
M03_L09:
       mov       rdx,rax
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FFDEFEE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M03_L11
       mov       r12,[rsp+48]
       test      r12,r12
       jne       near ptr M03_L18
       jmp       near ptr M03_L23
M03_L10:
       mov       [rsp+0A4],r8d
       jmp       short M03_L08
M03_L11:
       mov       eax,[rsp+7C]
       test      eax,eax
       jne       near ptr M03_L49
M03_L12:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+50]
       mov       r11,7FFDEFDA0878
       call      qword ptr [r11]
       mov       r12,rax
M03_L13:
       test      r12,r12
       mov       r8d,[rsp+0A4]
       mov       r10d,[rsp+0A0]
       je        near ptr M03_L51
M03_L14:
       cmp       [r12+8],r8d
       jl        near ptr M03_L52
M03_L15:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        near ptr M03_L01
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+84],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M03_L22
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jg        short M03_L21
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M03_L25
M03_L16:
       add       r12d,[rsp+84]
       mov       [rsi+18],r12d
       jmp       near ptr M03_L01
M03_L17:
       jmp       near ptr M03_L13
M03_L18:
       mov       r8,offset MT_System.String
       cmp       [r12],r8
       jne       near ptr M03_L50
       jmp       short M03_L17
M03_L19:
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
M03_L20:
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L02
M03_L21:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M03_L16
M03_L22:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFDF014CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M03_L01
M03_L23:
       xor       r12d,r12d
       jmp       short M03_L17
M03_L24:
       xor       edx,edx
       jmp       near ptr M03_L00
M03_L25:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M03_L16
M03_L26:
       mov       rcx,rsi
       mov       edx,eax
       call      qword ptr [7FFDF014C3D8]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M03_L01
M03_L27:
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M03_L28:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M03_L30
       cmp       eax,0F4240
       jl        short M03_L27
       cmp       edx,20
       jne       short M03_L31
M03_L29:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M03_L30:
       cmp       edx,20
       je        short M03_L29
M03_L31:
       cmp       edx,2C
       jne       near ptr M03_L38
M03_L32:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,20
       je        short M03_L32
       cmp       edx,2D
       jne       short M03_L33
       mov       r10d,1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M03_L33:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M03_L56
       inc       r13d
       cmp       r12d,r13d
       ja        short M03_L35
       jmp       near ptr M03_L57
M03_L34:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
M03_L35:
       cmp       r13d,r12d
       jae       near ptr M03_L65
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M03_L37
       cmp       r8d,0F4240
       jl        short M03_L34
       cmp       edx,20
       jne       short M03_L38
M03_L36:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
M03_L37:
       cmp       edx,20
       je        short M03_L36
M03_L38:
       cmp       edx,7D
       je        near ptr M03_L06
       cmp       edx,3A
       jne       near ptr M03_L58
       mov       r9d,r13d
M03_L39:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M03_L57
       mov       edx,r13d
       movzx     edx,word ptr [rbx+rdx*2+0C]
       cmp       edx,7D
       je        short M03_L40
       cmp       edx,7B
       jne       short M03_L39
       jmp       near ptr M03_L58
M03_L40:
       inc       r9d
       mov       r11d,r13d
       sub       r11d,r9d
       mov       ecx,r9d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M03_L59
       mov       ecx,r9d
       lea       r9,[rbx+rcx*2+0C]
       mov       r12,r9
       mov       edx,r11d
       mov       [rsp+7C],edx
       mov       [rsp+38],r12
       jmp       near ptr M03_L06
M03_L41:
       mov       r11d,[rsp+7C]
       test      r11d,r11d
       mov       [rsp+0A4],r8d
       mov       [rsp+0A0],r10d
       je        short M03_L43
       mov       r9,[rsp+38]
       mov       [rsp+68],r9
       mov       [rsp+7C],r11d
       mov       [rsp+70],r11d
       lea       rcx,[rsp+68]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       [rsp+50],rax
       mov       rax,[rsp+48]
M03_L42:
       mov       rcx,r15
       mov       r9,rdi
       mov       rdx,[rsp+50]
       mov       r8,rax
       mov       r11,7FFDEFDA0888
       call      qword ptr [r11]
       mov       r12,rax
       mov       rax,[rsp+48]
       mov       r8d,[rsp+0A4]
       mov       r10d,[rsp+0A0]
       jmp       near ptr M03_L07
M03_L43:
       mov       [rsp+7C],r11d
       jmp       short M03_L42
M03_L44:
       mov       rdx,rcx
       mov       r12,[rsi+8]
       mov       ebp,[rsi+18]
       mov       r14,[rsi+8]
       mov       r14d,[r14+8]
       sub       r14d,[rsi+18]
       mov       [rsp+88],r14d
       test      r12,r12
       jne       short M03_L45
       or        ebp,r14d
       jne       near ptr M03_L61
       xor       ebp,ebp
       xor       r12d,r12d
       jmp       short M03_L46
M03_L45:
       mov       r8d,ebp
       mov       r14d,r14d
       add       r8,r14
       mov       r14d,[r12+8]
       cmp       r8,r14
       ja        near ptr M03_L61
       mov       r8d,ebp
       lea       rbp,[r12+r8*2+10]
       mov       r14d,[rsp+88]
       mov       r12d,r14d
M03_L46:
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
       mov       r11,7FFDEFDA0880
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rsp+48]
       mov       rbp,[rsp+40]
       mov       r14d,[rsp+80]
       je        near ptr M03_L09
       mov       ecx,[rsp+90]
       mov       rdx,[rsi+8]
       mov       eax,[rsi+18]
       mov       r9,[rsi+8]
       mov       r9d,[r9+8]
       sub       r9d,[rsi+18]
       test      rdx,rdx
       jne       short M03_L47
       or        eax,r9d
       jne       near ptr M03_L61
       xor       eax,eax
       jmp       short M03_L48
M03_L47:
       mov       eax,eax
       mov       r11d,r9d
       add       rax,r11
       mov       edx,[rdx+8]
       cmp       rax,rdx
       ja        near ptr M03_L61
       mov       eax,r9d
M03_L48:
       cmp       ecx,eax
       ja        near ptr M03_L62
       mov       ecx,[rsp+90]
       add       [rsi+18],ecx
       cmp       dword ptr [rsp+0A0],0
       je        near ptr M03_L01
       mov       r8d,[rsp+0A4]
       cmp       r8d,[rsp+90]
       jle       near ptr M03_L01
       sub       r8d,[rsp+90]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDF014C258]
       jmp       near ptr M03_L01
M03_L49:
       mov       rdx,[rsp+50]
       test      rdx,rdx
       mov       [rsp+50],rdx
       jne       near ptr M03_L12
       mov       rcx,[rsp+38]
       mov       [rsp+68],rcx
       mov       [rsp+70],eax
       lea       rcx,[rsp+68]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rcx,rax
       mov       [rsp+50],rcx
       jmp       near ptr M03_L12
M03_L50:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M03_L17
M03_L51:
       mov       r12,1FDB8180008
       mov       [rsp+0A4],r8d
       cmp       [r12+8],r8d
       mov       r8d,[rsp+0A4]
       jge       near ptr M03_L15
M03_L52:
       test      r10d,r10d
       je        short M03_L53
       mov       [rsp+0A4],r8d
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+0A4]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDF014C258]
       jmp       near ptr M03_L01
M03_L53:
       sub       r8d,[r12+8]
       mov       rcx,rsi
       mov       edx,20
       call      qword ptr [7FFDF014C258]
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFDF014C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M03_L01
M03_L54:
       mov       r13,[rsp+30]
       mov       [rsp+68],r13
       mov       ebx,[rsp+78]
       mov       [rsp+70],ebx
       mov       rcx,rsi
       lea       rdx,[rsp+68]
       call      qword ptr [7FFDF014C558]
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
M03_L55:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FFDF009F150]
       int       3
M03_L56:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FFDF009F150]
       int       3
M03_L57:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDF009F150]
       int       3
M03_L58:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FFDF009F150]
       int       3
M03_L59:
       mov       ecx,21
       call      qword ptr [7FFDF009ED00]
       int       3
M03_L60:
       call      qword ptr [7FFDF009F168]
       int       3
M03_L61:
       call      qword ptr [7FFDF009E9A0]
       int       3
M03_L62:
       call      qword ptr [7FFDF009F138]
       int       3
M03_L63:
       mov       ecx,2F1
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF00C66E8]
       int       3
M03_L64:
       mov       rcx,rdi
       mov       rdx,1FDB8192F30
       mov       r11,7FFDEFDA0870
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M03_L00
M03_L65:
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
       je        near ptr M04_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L02
       cmp       [rdx+8],r8d
       jb        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFDEFF95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFDEFD94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFDF03D56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1FDB8180008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C6918],0
       je        short M05_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M05_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M05_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M05_L02
M05_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF05DDE98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M05_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0606700]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetPropertyValues01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]](Int32, Int32, Int32)
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FFDF03255D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>)
       call      qword ptr [7FFDF06168C8]; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.ObjectModel.ReadOnlyCollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFDF06168F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 87
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRef[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32)
       push      rbp
       sub       rsp,100
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0C0],xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFDF01D7358],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       lea       rcx,[rbp-30]
       mov       edx,2
       call      qword ptr [7FFDEFFA4780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-30]
       mov       [rsp+20],rcx
       mov       rcx,20828CF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+18]
       xor       edx,edx
       mov       r8,20828CFDFD8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FFDF0397870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+18],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,20828CF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+20]
       mov       edx,5
       mov       r8,20828CFE008
       mov       r9d,64
       call      qword ptr [7FFDF0397870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-38],eax
       mov       ecx,[rbp-38]
       mov       [rbp+20],ecx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rsp+20],rcx
       mov       rcx,20828CF0008
       mov       [rsp+28],rcx
       mov       ecx,[rbp+28]
       mov       edx,5
       mov       r8,20828CFE038
       mov       r9d,32
       call      qword ptr [7FFDF0397870]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-3C],eax
       mov       eax,[rbp-3C]
       mov       [rbp+28],eax
       call      qword ptr [7FFDF02EF4F8]; DotNetTips.Spargine.Tester.RandomData.GenerateRandomPersonData()
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-58],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF0564EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M01_L03:
       mov       rcx,[rbp-58]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFDF0324390]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0586580]; DotNetTips.Spargine.Tester.PersonData.get_Country()
       mov       [rbp-60],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-68],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05655E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M01_L05:
       mov       ecx,[rbp+28]
       mov       [rsp+20],ecx
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-60]
       mov       r8d,[rbp+18]
       mov       r9d,[rbp+20]
       call      qword ptr [7FFDF0586AD8]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressCollection[[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Data.Country, Int32, Int32, Int32)
       mov       [rbp-70],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B730]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Addresses(System.Collections.ObjectModel.Collection`1<System.__Canon>)
       nop
       lea       rdx,[rbp-80]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0586520]; DotNetTips.Spargine.Tester.PersonData.get_BornOn()
       mov       rcx,[rbp-50]
       mov       [rbp-0C8],rcx
       vmovups   xmm0,[rbp-80]
       vmovups   [rbp-0C0],xmm0
       mov       rcx,[rbp-0C8]
       lea       rdx,[rbp-0C0]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B740]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_BornOn(System.DateTimeOffset)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0586550]; DotNetTips.Spargine.Tester.PersonData.get_CellPhone()
       mov       [rbp-88],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B750]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_CellPhone(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF05865B0]; DotNetTips.Spargine.Tester.PersonData.get_Email()
       mov       [rbp-90],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-90]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B760]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Email(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF05865E0]; DotNetTips.Spargine.Tester.PersonData.get_FirstName()
       mov       [rbp-98],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-98]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B770]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_FirstName(System.String)
       nop
       call      qword ptr [7FFDF02EF390]; DotNetTips.Spargine.Tester.RandomData.GenerateKey()
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A0]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B780]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Id(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0586610]; DotNetTips.Spargine.Tester.PersonData.get_LastName()
       mov       [rbp-0A8],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0A8]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B790]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_LastName(System.String)
       nop
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0586640]; DotNetTips.Spargine.Tester.PersonData.get_Phone()
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-0B0]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF030B7A0]; DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[System.__Canon, System.Private.CoreLib]].set_Phone(System.String)
       nop
       mov       rax,[rbp-50]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,100
       pop       rbp
       ret
; Total bytes of code 875
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       sub       rsp,220
       vzeroupper
       lea       rbp,[rsp+220]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       mov       rcx,[rbp+18]
       mov       [rbp-68],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-70],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-70],rax
M02_L03:
       mov       rcx,20828CF81E0
       mov       [rsp+20],rcx
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-68]
       mov       r8,[rbp-20]
       mov       r9,20828CF0008
       call      qword ptr [7FFDF0397C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       call      qword ptr [7FFDEFEFEB80]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-80]
       mov       [rbp-10],rcx
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       call      qword ptr [7FFDF05863A0]; DotNetTips.Spargine.Core.Extensions.GetAllProperties(System.Type)
       mov       [rbp-90],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-98],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L05:
       mov       rcx,[rbp-98]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+8]
       mov       [rbp-0A0],r8
       mov       r8,[rbp-90]
       mov       [rbp-0A8],r8
       mov       r8,[rbp-0A0]
       mov       [rbp-0B0],r8
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M02_L10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-1A0],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1A0],rax
M02_L07:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-1A8],rax
       mov       rcx,[rbp-1A0]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-1B8],rdx
       mov       rdx,[rbp-1B8]
       mov       rcx,[rbp-1A8]
       mov       r8,7FFDF06129E8
       call      qword ptr [7FFDEFEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-1B0],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-1B0],rax
M02_L09:
       mov       rcx,[rbp-1B0]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,[rbp-1A8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1A8]
       mov       [rbp-0B0],rcx
M02_L10:
       mov       r8,[rbp-0B0]
       mov       rdx,[rbp-0A8]
       mov       rcx,offset MD_System.Linq.Enumerable.Where[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>)
       call      qword ptr [7FFDF02A6928]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       [rbp-0B8],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L11
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-0C0],rcx
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0C0],rax
M02_L12:
       mov       rcx,[rbp-0C0]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r8,[rax+10]
       mov       [rbp-0C8],r8
       mov       r8,[rbp-0B8]
       mov       [rbp-0D0],r8
       mov       r8,[rbp-0C8]
       mov       [rbp-0D8],r8
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M02_L17
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L13
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-188],rcx
       jmp       short M02_L14
M02_L13:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-188],rax
M02_L14:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-190],rax
       mov       rcx,[rbp-188]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       [rbp-1C0],rdx
       mov       rdx,[rbp-1C0]
       mov       rcx,[rbp-190]
       mov       r8,7FFDF0612A00
       call      qword ptr [7FFDEFEF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L15
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-198],rcx
       jmp       short M02_L16
M02_L15:
       mov       rcx,[rbp+10]
       mov       rdx,7FFDF05EE3A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-198],rax
M02_L16:
       mov       rcx,[rbp-198]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,[rbp-190]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-190]
       mov       [rbp-0D8],rax
M02_L17:
       mov       r8,[rbp-0D8]
       mov       rdx,[rbp-0D0]
       mov       rcx,offset MD_System.Linq.Enumerable.OrderBy[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,System.String>)
       call      qword ptr [7FFDF02AEF58]; System.Linq.Enumerable.OrderBy[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       [rbp-0E0],rax
       mov       rdx,[rbp-0E0]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>)
       call      qword ptr [7FFDF02E49F0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-0E8],rax
       mov       rcx,[rbp-0E8]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       near ptr M02_L27
M02_L18:
       nop
       mov       rcx,[rbp-18]
       mov       eax,[rbp-24]
       cmp       eax,[rcx+8]
       jb        short M02_L19
       call      CORINFO_HELP_RNGCHKFAIL
M02_L19:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-30],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       [rbp-0F0],rax
       mov       rcx,[rbp-0F0]
       mov       rax,[rbp-0F0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-0F8],rax
       mov       rcx,[rbp-0F8]
       mov       rdx,20828D02EE0
       mov       r8d,4
       call      qword ptr [7FFDEFEF61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       [rbp-0FC],eax
       mov       ecx,[rbp-0FC]
       movzx     ecx,cl
       mov       [rbp-34],ecx
       cmp       dword ptr [rbp-34],0
       je        near ptr M02_L23
       nop
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF012CAF8]; System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-140],rax
       mov       rdx,[rbp-140]
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FFDEFEF4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       jne       short M02_L20
       xor       ecx,ecx
       mov       [rbp-148],ecx
       jmp       short M02_L21
M02_L20:
       mov       rcx,[rbp-40]
       mov       r11,7FFDEFDB0780
       call      qword ptr [r11]
       mov       [rbp-144],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-144],0
       setg      cl
       mov       [rbp-148],ecx
M02_L21:
       mov       ecx,[rbp-148]
       movzx     ecx,cl
       mov       [rbp-44],ecx
       cmp       dword ptr [rbp-44],0
       je        near ptr M02_L22
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-150],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-158],rax
       mov       rcx,[rbp-40]
       mov       edx,2C
       call      qword ptr [7FFDF0586460]
       mov       [rbp-160],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-170],xmm0
       lea       rcx,[rbp-170]
       mov       r9,[rbp-160]
       mov       r8,[rbp-158]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFDEFEFF348]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-150]
       mov       [rbp-1D8],r8
       vmovdqu   xmm0,xmmword ptr [rbp-170]
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       lea       r8,[rbp-1D0]
       mov       rdx,[rbp-1D8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDF0616AA8]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-174],eax
       nop
       nop
M02_L22:
       nop
       nop
       jmp       near ptr M02_L25
M02_L23:
       nop
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF012CAF8]; System.Reflection.PropertyInfo.GetValue(System.Object)
       mov       [rbp-108],rax
       mov       rcx,[rbp-108]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp-50],0
       setne     cl
       mov       [rbp-54],ecx
       cmp       dword ptr [rbp-54],0
       je        near ptr M02_L24
       nop
       mov       rcx,[rbp-10]
       mov       [rbp-110],rcx
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-118],rax
       mov       rcx,[rbp-50]
       mov       rax,[rbp-50]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-120],rax
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-130],xmm0
       lea       rcx,[rbp-130]
       mov       r9,[rbp-120]
       mov       r8,[rbp-118]
       mov       rdx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFDEFEFF348]; System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.__Canon, System.__Canon)
       mov       r8,[rbp-110]
       mov       [rbp-1F0],r8
       vmovdqu   xmm0,xmmword ptr [rbp-130]
       vmovdqu   xmmword ptr [rbp-1E8],xmm0
       lea       r8,[rbp-1E8]
       mov       rdx,[rbp-1F0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFDF0616AA8]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rbp-134],eax
       nop
       nop
M02_L24:
       nop
M02_L25:
       nop
       mov       edx,[rbp-24]
       add       edx,1
       jno       short M02_L26
       call      CORINFO_HELP_OVERFLOW
M02_L26:
       mov       [rbp-24],edx
M02_L27:
       mov       ecx,[rbp-24]
       mov       rax,[rbp-18]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-58],ecx
       cmp       dword ptr [rbp-58],0
       jne       near ptr M02_L18
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.String,System.String>)
       call      qword ptr [7FFDF0616AD8]; DotNetTips.Spargine.Core.Extensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rbp-180],rax
       mov       rax,[rbp-180]
       mov       [rbp-60],rax
       nop
       mov       rax,[rbp-60]
       add       rsp,220
       pop       rbp
       ret
; Total bytes of code 1942
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-10],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D6918],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M03_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M03_L02
M03_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFDF063B908
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF064D9C8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

