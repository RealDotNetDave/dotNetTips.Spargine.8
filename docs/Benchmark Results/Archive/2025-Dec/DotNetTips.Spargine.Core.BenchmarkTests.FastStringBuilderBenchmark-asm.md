## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.FormatComparison()
       push      rsi
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
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
       mov       rcx,[rbx+128]
       test      rcx,rcx
       je        short M00_L00
       lea       r9,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+20],r9
       mov       [rsp+28],ecx
       mov       rcx,rsi
       lea       r9,[rsp+20]
       xor       edx,edx
       mov       r8,2BCCCE14768
       call      qword ptr [7FF9001DD830]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,1767
       mov       rdx,7FF8FFEB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
; Total bytes of code 203
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
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       rbp,[r9]
       mov       r14d,[r9+8]
       test      rsi,rsi
       je        near ptr M01_L35
       test      rdi,rdi
       jne       near ptr M01_L36
       xor       edx,edx
M01_L00:
       mov       rcx,offset MT_System.ICustomFormatter
       call      qword ptr [7FF9000043C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       r15,rax
       xor       r13d,r13d
M01_L01:
       mov       r12d,[rsi+8]
       cmp       r12d,r13d
       jbe       near ptr M01_L22
       mov       r8d,r13d
       mov       edx,r8d
       lea       rax,[rsi+rdx*2+0C]
       mov       r10d,r12d
       sub       r10d,r8d
       mov       [rsp+30],rax
       mov       eax,r10d
       mov       [rsp+70],eax
       mov       r8d,7D
       mov       edx,7B
       mov       rcx,[rsp+30]
       mov       r9d,eax
       call      qword ptr [7FF90030D380]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       mov       [rsp+8C],eax
       test      eax,eax
       jl        near ptr M01_L26
       cmp       eax,[rsp+70]
       ja        near ptr M01_L33
       mov       rdx,[rsp+30]
       mov       r8d,eax
       test      r8d,r8d
       je        near ptr M01_L07
       mov       r8,[rbx+8]
       mov       r10d,[rbx+18]
       mov       [rsp+7C],r10d
       lea       ecx,[r10+rax]
       cmp       ecx,[r8+8]
       ja        short M01_L06
       movsxd    rcx,r10d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       short M01_L03
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L02:
       mov       eax,[rsp+8C]
       mov       ecx,eax
       add       ecx,[rsp+7C]
       mov       [rbx+18],ecx
       jmp       short M01_L07
M01_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       jne       short M01_L04
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L02
M01_L04:
       jmp       short M01_L02
M01_L05:
       cmp       [r12+8],r8d
       jl        near ptr M01_L24
       jmp       near ptr M01_L16
M01_L06:
       mov       rcx,rbx
       mov       r8d,eax
       call      qword ptr [7FF9001DD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       eax,[rsp+8C]
M01_L07:
       add       r13d,eax
       cmp       r13d,r12d
       jae       near ptr M01_L63
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       ecx,r13d
       movzx     eax,word ptr [rsi+rcx*2+0C]
       cmp       edx,eax
       je        near ptr M01_L37
       cmp       edx,7B
       jne       near ptr M01_L27
       xor       r8d,r8d
       xor       r10d,r10d
       xor       r9d,r9d
       mov       [rsp+38],r9
       xor       r11d,r11d
       mov       [rsp+74],r11d
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M01_L28
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       jne       near ptr M01_L39
M01_L08:
       inc       r13d
       xor       r12d,r12d
       xor       ecx,ecx
       mov       [rsp+48],rcx
       cmp       eax,r14d
       jae       near ptr M01_L32
       mov       edx,eax
       mov       rdx,[rbp+rdx*8]
       mov       [rsp+40],rdx
       test      r15,r15
       jne       near ptr M01_L52
M01_L09:
       test      r12,r12
       jne       near ptr M01_L05
       mov       [rsp+90],r10d
       test      r10d,r10d
       jne       near ptr M01_L14
       mov       [rsp+94],r8d
       test      r8d,r8d
       jne       short M01_L13
M01_L10:
       mov       rcx,offset MT_System.ISpanFormattable
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L55
M01_L11:
       mov       rdx,[rsp+40]
       mov       rcx,offset MT_System.IFormattable
       call      qword ptr [7FF900004348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M01_L17
       mov       r12,[rsp+40]
       test      r12,r12
       je        short M01_L15
       mov       rax,offset MT_System.String
       cmp       [r12],rax
       jne       near ptr M01_L60
M01_L12:
       test      r12,r12
       je        near ptr M01_L61
       mov       r8d,[rsp+94]
       mov       r10d,[rsp+90]
       jmp       near ptr M01_L05
M01_L13:
       jmp       short M01_L11
M01_L14:
       mov       [rsp+94],r8d
       jmp       near ptr M01_L10
M01_L15:
       xor       r12d,r12d
       jmp       short M01_L12
M01_L16:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        near ptr M01_L01
       mov       rax,[rbx+8]
       mov       r9d,[rbx+18]
       mov       [rsp+78],r9d
       lea       ecx,[r9+r12]
       cmp       ecx,[rax+8]
       ja        short M01_L21
       jmp       short M01_L19
M01_L17:
       mov       eax,[rsp+74]
       test      eax,eax
       jne       near ptr M01_L62
M01_L18:
       mov       rcx,r12
       mov       r8,rdi
       mov       rdx,[rsp+48]
       mov       r11,7FF8FFEC09F0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M01_L12
M01_L19:
       movsxd    r8,r9d
       lea       rcx,[rax+r8*2+10]
       cmp       r12d,2
       jle       short M01_L23
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF9000B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L20:
       add       r12d,[rsp+78]
       mov       [rbx+18],r12d
       jmp       near ptr M01_L01
M01_L21:
       mov       rcx,rbx
       mov       r8d,r12d
       call      qword ptr [7FF9001DD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L01
M01_L22:
       mov       rax,rbx
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
M01_L23:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M01_L20
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L20
M01_L24:
       test      r10d,r10d
       je        short M01_L25
       mov       [rsp+94],r8d
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF9001DD1A0]; System.Text.StringBuilder.Append(System.String)
       mov       eax,[rsp+94]
       mov       r8d,eax
       sub       r8d,[r12+8]
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF9001DD158]
       jmp       near ptr M01_L01
M01_L25:
       sub       r8d,[r12+8]
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF9001DD158]
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF9001DD1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L01
M01_L26:
       mov       r13,[rsp+30]
       mov       [rsp+60],r13
       mov       esi,[rsp+70]
       mov       [rsp+68],esi
       mov       rcx,rbx
       lea       rdx,[rsp+60]
       call      qword ptr [7FF9001DD458]
       mov       rax,rbx
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
M01_L27:
       mov       ecx,r13d
       mov       edx,4B
       call      qword ptr [7FF900305F98]
       int       3
M01_L28:
       mov       ecx,r13d
       mov       edx,4D
       call      qword ptr [7FF900305F98]
       int       3
M01_L29:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF900305F98]
       int       3
M01_L30:
       mov       ecx,r13d
       mov       edx,4C
       call      qword ptr [7FF900305F98]
       int       3
M01_L31:
       mov       ecx,21
       call      qword ptr [7FF900305B48]
       int       3
M01_L32:
       call      qword ptr [7FF900305FB0]
       int       3
M01_L33:
       call      qword ptr [7FF9003057E8]
       int       3
M01_L34:
       call      qword ptr [7FF900305F80]
       int       3
M01_L35:
       mov       ecx,2F1
       mov       rdx,7FF8FFEB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF900196790]
       int       3
M01_L36:
       mov       rcx,rdi
       mov       r11,7FF8FFEC09E8
       mov       rdx,2BCCCE14820
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M01_L00
M01_L37:
       mov       rcx,rbx
       mov       edx,eax
       call      qword ptr [7FF9001DD2D8]; System.Text.StringBuilder.Append(Char)
       inc       r13d
       jmp       near ptr M01_L01
M01_L38:
       lea       eax,[rax+rax*4]
       lea       eax,[rdx+rax*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L39:
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L41
       cmp       eax,0F4240
       jl        short M01_L38
       cmp       edx,20
       jne       short M01_L42
M01_L40:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L41:
       cmp       edx,20
       je        short M01_L40
M01_L42:
       cmp       edx,2C
       jne       near ptr M01_L49
M01_L43:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,20
       je        short M01_L43
       cmp       edx,2D
       jne       short M01_L44
       mov       r10d,1
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L44:
       lea       r8d,[rdx-30]
       cmp       r8d,0A
       jae       near ptr M01_L28
       inc       r13d
       cmp       r12d,r13d
       ja        short M01_L46
       jmp       near ptr M01_L29
M01_L45:
       lea       r8d,[r8+r8*4]
       lea       r8d,[rdx+r8*2-30]
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
M01_L46:
       cmp       r13d,r12d
       jae       near ptr M01_L63
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       lea       ecx,[rdx-30]
       cmp       ecx,9
       ja        short M01_L48
       cmp       r8d,0F4240
       jl        short M01_L45
       cmp       edx,20
       jne       short M01_L49
M01_L47:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
M01_L48:
       cmp       edx,20
       je        short M01_L47
M01_L49:
       cmp       edx,7D
       je        near ptr M01_L08
       cmp       edx,3A
       jne       near ptr M01_L30
       mov       r9d,r13d
M01_L50:
       inc       r13d
       cmp       r12d,r13d
       jbe       near ptr M01_L29
       mov       edx,r13d
       movzx     edx,word ptr [rsi+rdx*2+0C]
       cmp       edx,7D
       je        short M01_L51
       cmp       edx,7B
       jne       short M01_L50
       jmp       near ptr M01_L30
M01_L51:
       inc       r9d
       mov       r11d,r13d
       sub       r11d,r9d
       mov       ecx,r9d
       mov       edx,r11d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M01_L31
       mov       ecx,r9d
       lea       r9,[rsi+rcx*2+0C]
       mov       r12,r9
       mov       edx,r11d
       mov       [rsp+74],edx
       mov       [rsp+38],r12
       jmp       near ptr M01_L08
M01_L52:
       mov       r11d,[rsp+74]
       test      r11d,r11d
       mov       [rsp+94],r8d
       mov       [rsp+90],r10d
       je        short M01_L54
       mov       r9,[rsp+38]
       mov       [rsp+60],r9
       mov       [rsp+74],r11d
       mov       [rsp+68],r11d
       lea       rcx,[rsp+60]
       call      00007FF900002520
       mov       [rsp+48],rax
M01_L53:
       mov       rcx,r15
       mov       r9,rdi
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r11,7FF8FFEC0A00
       call      qword ptr [r11]
       mov       r12,rax
       mov       rdx,[rsp+40]
       mov       r8d,[rsp+94]
       mov       r10d,[rsp+90]
       jmp       near ptr M01_L09
M01_L54:
       mov       [rsp+74],r11d
       jmp       short M01_L53
M01_L55:
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+18]
       mov       r8,[rbx+8]
       mov       r8d,[r8+8]
       sub       r8d,[rbx+18]
       test      rdx,rdx
       jne       short M01_L56
       or        r9d,r8d
       jne       near ptr M01_L33
       xor       r9d,r9d
       xor       r11d,r11d
       jmp       short M01_L57
M01_L56:
       mov       r11d,r9d
       mov       eax,r8d
       add       r11,rax
       mov       eax,[rdx+8]
       cmp       r11,rax
       ja        near ptr M01_L33
       mov       r9d,r9d
       lea       r9,[rdx+r9*2+10]
       mov       r11d,r8d
M01_L57:
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
       mov       r11,7FF8FFEC09F8
       call      qword ptr [r11]
       test      eax,eax
       mov       [rsp+38],r12
       je        near ptr M01_L11
       mov       r8d,[rsp+80]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       sub       eax,[rbx+18]
       test      rcx,rcx
       jne       short M01_L58
       or        edx,eax
       jne       near ptr M01_L33
       xor       edx,edx
       jmp       short M01_L59
M01_L58:
       mov       edx,edx
       mov       r10d,eax
       add       rdx,r10
       mov       ecx,[rcx+8]
       cmp       rdx,rcx
       ja        near ptr M01_L33
       mov       edx,eax
M01_L59:
       cmp       r8d,edx
       ja        near ptr M01_L34
       mov       r8d,[rsp+80]
       add       [rbx+18],r8d
       cmp       dword ptr [rsp+90],0
       je        near ptr M01_L01
       mov       r12d,[rsp+94]
       cmp       r12d,[rsp+80]
       jle       near ptr M01_L01
       mov       r8d,r12d
       sub       r8d,[rsp+80]
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF9001DD158]
       jmp       near ptr M01_L01
M01_L60:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r12,rax
       jmp       near ptr M01_L12
M01_L61:
       mov       r12,2BCCCE00008
       mov       r8d,[rsp+94]
       mov       r10d,[rsp+90]
       jmp       near ptr M01_L05
M01_L62:
       mov       rdx,[rsp+48]
       test      rdx,rdx
       mov       [rsp+48],rdx
       jne       near ptr M01_L18
       mov       rcx,[rsp+38]
       mov       [rsp+60],rcx
       mov       [rsp+68],eax
       lea       rcx,[rsp+60]
       call      00007FF900002520
       mov       rcx,rax
       mov       [rsp+48],rcx
       jmp       near ptr M01_L18
M01_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2094
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.RemoveComparison()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+38]
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L01
       mov       r9d,[rdx+8]
M00_L00:
       mov       dword ptr [rsp+20],10
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF9001FCFD8]; System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       rdx,1D0ED8B4768
       mov       r8,1D0ED8A0008
       xor       r9d,r9d
       call      qword ptr [7FF9001FD920]; System.Text.StringBuilder.Replace(System.String, System.String, Int32, Int32)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF900209B30]; System.Text.StringBuilder.ToString()
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
M00_L01:
       xor       edx,edx
       xor       r9d,r9d
       jmp       short M00_L00
; Total bytes of code 166
```
```assembly
; System.Text.StringBuilder..ctor(System.String, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbp,rcx
       mov       rsi,rdx
       mov       r14d,r8d
       mov       ebx,r9d
       mov       edi,[rsp+80]
       test      edi,edi
       jl        near ptr M01_L02
       test      ebx,ebx
       jl        near ptr M01_L03
       test      r14d,r14d
       jl        near ptr M01_L04
       mov       rdx,1D0ED8A0008
       test      rsi,rsi
       cmove     rsi,rdx
       mov       r15d,[rsi+8]
       mov       edx,r15d
       sub       edx,ebx
       cmp       edx,r14d
       jl        near ptr M01_L05
       mov       dword ptr [rbp+20],7FFFFFFF
       mov       edx,10
       test      edi,edi
       cmove     edi,edx
       cmp       edi,ebx
       cmovl     edi,ebx
       cmp       edi,400
       jl        near ptr M01_L06
       mov       edx,edi
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+18],ebx
       mov       r8d,r14d
       mov       ecx,ebx
       add       rcx,r8
       mov       edx,r15d
       cmp       rcx,rdx
       ja        near ptr M01_L07
       lea       rdx,[rsi+r8*2+0C]
       mov       r8,[rbp+8]
       test      r8,r8
       je        near ptr M01_L08
       lea       rcx,[r8+10]
       mov       r13d,[r8+8]
       cmp       ebx,r13d
       ja        near ptr M01_L09
M01_L01:
       mov       r8d,ebx
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       ecx,13C20
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF900914738]
       int       3
M01_L03:
       mov       ecx,57
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF900914738]
       int       3
M01_L04:
       mov       ecx,172D
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF900914738]
       int       3
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,57
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FF9005A5740]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9000DD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L06:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L00
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900325B48]
       int       3
M01_L08:
       xor       ecx,ecx
       xor       r13d,r13d
       cmp       ebx,r13d
       jbe       near ptr M01_L01
M01_L09:
       call      qword ptr [7FF900325800]
       int       3
; Total bytes of code 471
```
```assembly
; System.Text.StringBuilder.Replace(System.String, System.String, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       xor       eax,eax
       mov       [rbp+50],rax
       mov       rax,9CBDD85ADEC4
       mov       [rbp+8],rax
       mov       rdi,rcx
       mov       rbx,rdx
       mov       r14,r8
       mov       esi,[rbp+0C0]
       mov       ecx,[rdi+1C]
       mov       edx,ecx
       add       edx,[rdi+18]
       cmp       r9d,edx
       ja        near ptr M02_L26
       test      esi,esi
       jl        near ptr M02_L27
       sub       edx,esi
       cmp       edx,r9d
       jl        near ptr M02_L27
       test      rbx,rbx
       je        near ptr M02_L29
       mov       r15d,[rbx+8]
       test      r15d,r15d
       je        near ptr M02_L29
       mov       rdx,1D0ED8A0008
       test      r14,r14
       cmove     r14,rdx
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+30]
       mov       [rbp+48],rdx
       mov       dword ptr [rbp+50],80
       xor       edx,edx
       mov       [rbp+38],rdx
       mov       [rbp+40],edx
       mov       r13,rdi
       cmp       ecx,r9d
       jle       short M02_L01
M02_L00:
       mov       r13,[r13+10]
       cmp       [r13+1C],r9d
       jg        short M02_L00
M02_L01:
       mov       r12d,r9d
       sub       r12d,[r13+1C]
       test      esi,esi
       jle       near ptr M02_L13
M02_L02:
       mov       rax,[r13+8]
       mov       r15d,[r13+18]
       sub       r15d,r12d
       cmp       r15d,esi
       jg        near ptr M02_L28
M02_L03:
       test      rax,rax
       je        near ptr M02_L30
       mov       ecx,r12d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,[rax+8]
       cmp       rcx,rdx
       ja        near ptr M02_L25
       mov       ecx,r12d
       lea       rax,[rax+rcx*2+10]
M02_L04:
       mov       ecx,[rbx+8]
       mov       r10d,ecx
       cmp       r10d,r15d
       jg        near ptr M02_L08
M02_L05:
       mov       [rbp+10],rax
       mov       rcx,rax
       mov       edx,r15d
       lea       r8,[rbx+0C]
       mov       [rbp+1C],r10d
       mov       r9d,r10d
       call      qword ptr [7FF9000D51A0]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       mov       [rbp+34],eax
       test      eax,eax
       jl        near ptr M02_L19
       add       r12d,eax
       mov       ecx,[rbp+40]
       mov       rdx,[rbp+48]
       mov       r8d,[rbp+50]
       cmp       ecx,r8d
       jae       short M02_L07
       mov       r8d,ecx
       mov       [rdx+r8*4],r12d
       inc       ecx
       mov       [rbp+40],ecx
M02_L06:
       mov       ecx,[rbp+1C]
       mov       eax,[rbp+34]
       add       eax,ecx
       mov       edx,eax
       cmp       edx,r15d
       ja        near ptr M02_L25
       mov       r9d,edx
       mov       r10,[rbp+10]
       lea       r10,[r10+r9*2]
       sub       r15d,edx
       add       r12d,ecx
       sub       esi,eax
       je        short M02_L08
       cmp       ecx,r15d
       jg        short M02_L08
       mov       rax,r10
       mov       r10d,ecx
       jmp       short M02_L05
M02_L07:
       lea       rcx,[rbp+38]
       mov       edx,r12d
       call      qword ptr [7FF9007ADB18]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
       jmp       short M02_L06
M02_L08:
       cmp       r12d,[r13+18]
       jge       short M02_L09
       test      esi,esi
       jg        near ptr M02_L16
M02_L09:
       add       r12d,[r13+1C]
       cmp       dword ptr [rbp+40],0
       je        short M02_L10
       mov       ecx,[rbp+40]
       cmp       ecx,[rbp+50]
       ja        near ptr M02_L25
       mov       rdx,[rbp+48]
       mov       [rbp+20],rdx
       mov       [rbp+28],ecx
       mov       [rsp+20],r14
       mov       rcx,rdi
       lea       rdx,[rbp+20]
       mov       eax,[rbx+8]
       mov       [rbp+1C],eax
       mov       r9d,eax
       mov       r8,r13
       call      qword ptr [7FF9001FD9C8]; System.Text.StringBuilder.ReplaceAllInChunk(System.ReadOnlySpan`1<Int32>, System.Text.StringBuilder, Int32, System.String)
       mov       ecx,[r14+8]
       sub       ecx,[rbp+1C]
       imul      ecx,[rbp+40]
       add       r12d,ecx
       xor       ecx,ecx
       mov       [rbp+40],ecx
M02_L10:
       mov       r13,rdi
       cmp       [rdi+1C],r12d
       jle       short M02_L12
M02_L11:
       mov       r13,[r13+10]
       cmp       [r13+1C],r12d
       jg        short M02_L11
M02_L12:
       sub       r12d,[r13+1C]
       test      esi,esi
       jg        near ptr M02_L02
M02_L13:
       mov       rdx,[rbp+38]
       test      rdx,rdx
       je        short M02_L14
       xor       ecx,ecx
       mov       [rbp+38],rcx
       mov       rcx,1905BC01F28
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9007BC440]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M02_L14:
       mov       rax,rdi
       mov       rcx,9CBDD85ADEC4
       cmp       [rbp+8],rcx
       je        short M02_L15
       call      CORINFO_HELP_FAIL_FAST
M02_L15:
       nop
       lea       rsp,[rbp+58]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L16:
       mov       rdx,r13
       mov       ecx,r12d
       mov       r15d,esi
       xor       r9d,r9d
       mov       r8d,[rbx+8]
       mov       eax,r8d
       test      eax,eax
       jle       short M02_L21
M02_L17:
       test      r15d,r15d
       je        near ptr M02_L24
       cmp       ecx,[rdx+18]
       jge       short M02_L20
M02_L18:
       mov       r8d,r9d
       movzx     r8d,word ptr [rbx+r8*2+0C]
       mov       r10,[rdx+8]
       cmp       ecx,[r10+8]
       jae       near ptr M02_L31
       mov       r11d,ecx
       cmp       r8w,[r10+r11*2+10]
       jne       near ptr M02_L24
       inc       ecx
       dec       r15d
       inc       r9d
       cmp       eax,r9d
       jle       short M02_L21
       jmp       short M02_L17
M02_L19:
       mov       ecx,[rbp+1C]
       dec       ecx
       mov       edx,r15d
       sub       edx,ecx
       add       r12d,edx
       sub       esi,edx
       jmp       near ptr M02_L08
M02_L20:
       mov       [rbp+1C],eax
       mov       [rbp+30],r9d
       mov       rcx,rdi
       call      qword ptr [7FF9001FDA40]
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L24
       xor       ecx,ecx
       mov       eax,[rbp+1C]
       mov       r9d,[rbp+30]
       jmp       short M02_L18
M02_L21:
       mov       ecx,[rbp+40]
       mov       rdx,[rbp+48]
       mov       r8d,[rbp+50]
       cmp       ecx,r8d
       jae       short M02_L22
       mov       r8d,ecx
       mov       [rdx+r8*4],r12d
       inc       ecx
       mov       [rbp+40],ecx
       jmp       short M02_L23
M02_L22:
       mov       [rbp+1C],eax
       lea       rcx,[rbp+38]
       mov       edx,r12d
       call      qword ptr [7FF9007ADB18]; System.Collections.Generic.ValueListBuilder`1[[System.Int32, System.Private.CoreLib]].AddWithResize(Int32)
       mov       eax,[rbp+1C]
M02_L23:
       add       r12d,eax
       sub       esi,eax
       jmp       near ptr M02_L08
M02_L24:
       inc       r12d
       dec       esi
       jmp       near ptr M02_L08
M02_L25:
       call      qword ptr [7FF9003257E8]
       int       3
M02_L26:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9005A56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9000DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L27:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,1C7
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FF9005A56F8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r12
       call      qword ptr [7FF9000DD470]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M02_L28:
       mov       r15d,esi
       jmp       near ptr M02_L03
M02_L29:
       mov       ecx,1795
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF90002F810]
       int       3
M02_L30:
       mov       ecx,r12d
       or        ecx,r15d
       jne       near ptr M02_L25
       xor       eax,eax
       xor       r15d,r15d
       jmp       near ptr M02_L04
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1067
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M03_L03
       call      00007FF900021E60
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L02
       cmp       [rdx+8],r8d
       jb        short M03_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9000D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18761
       mov       rdx,7FF8FFED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9005A56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9000DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1D0ED8A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Format()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,1C9F86C4768
       call      qword ptr [7FF9008DEEC8]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
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
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; 		if (args.CheckItemsExists() is false || format.CheckIsNotNull() is false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return ControlChars.EmptyString;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.AppendFormat(CultureInfo.CurrentCulture, format, args).ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-60],rsp
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ecx,[rbx+8]
       test      ecx,ecx
       jl        near ptr M01_L11
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
M01_L00:
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L12
       xor       ecx,ecx
       test      rsi,rsi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L12
       mov       rcx,1896680AB58
       mov       rdi,[rcx]
       mov       rcx,[rdi+20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L13
       lea       rcx,[rdi+20]
       mov       r8,[rbp-28]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-28]
       jne       near ptr M01_L13
M01_L01:
       mov       r14,[rbp-28]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-28],rcx
       cmp       [r14],r14b
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9001ED0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r14
       mov       [rbp-40],rdx
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       jmp       short M01_L00
M01_L04:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],2
       jl        short M01_L09
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L09
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L06
       mov       rcx,18966800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L06
       mov       rcx,18966800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M01_L08
M01_L06:
       test      rbx,rbx
       je        short M01_L07
       lea       r8,[rbx+10]
       mov       r9d,[rbx+8]
       jmp       short M01_L10
M01_L07:
       mov       rcx,1C9F86C47E8
       call      qword ptr [7FF9001A6790]
       int       3
M01_L08:
       call      qword ptr [7FF90018E070]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       rdx,[rbp-40]
       jmp       short M01_L06
M01_L09:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,[rbp-40]
       jmp       short M01_L05
M01_L10:
       mov       rax,rdx
       mov       [rbp-50],rcx
       mov       [rbp-38],r8
       mov       [rbp-30],r9d
       mov       rcx,rax
       mov       rdx,[rbp-50]
       mov       r8,rsi
       lea       r9,[rbp-38]
       call      qword ptr [7FF9001ED830]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9001F9B30]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M01_L16
       jmp       short M01_L15
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       mov       rax,1C9F86B0008
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L13:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF90079F1C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L14
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L01
M01_L14:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L15:
       mov       rax,[rbp-48]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L16:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1896680AB58
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L17
       mov       rdx,[rbp-40]
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       mov       rax,[rsi+8]
       cmp       ecx,[rax+0C]
       jg        short M01_L21
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9001ED0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L18
M01_L17:
       mov       rdx,[rbp-40]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L21
M01_L18:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L19
       lea       rcx,[rbx+20]
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L21
M01_L19:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L20
       mov       rcx,[rbx+18]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF90079F198]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L21
M01_L20:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L21:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 696
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderBenchmark.Remove()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,294B93F4768
       call      qword ptr [7FF9008BEF28]; DotNetTips.Spargine.Core.FastStringBuilder.Remove(System.String, System.String)
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
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.Remove(System.String, System.String)
; 		if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(toRemove))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return input ?? ControlChars.EmptyString;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var startIndex = 0;
; 			^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(input, startIndex, index - startIndex);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				startIndex = index + toRemove.Length;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			while ((index = input.IndexOf(toRemove, startIndex, StringComparison.Ordinal)) != -1)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (startIndex < input.Length)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(input, startIndex, input.Length - startIndex);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L27
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L27
       test      rsi,rsi
       je        near ptr M01_L27
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M01_L27
       mov       rcx,2542740AB58
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L26
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L26
M01_L00:
       mov       r13,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       [r13],r13b
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9001CD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-50],r13
       jmp       short M01_L03
M01_L02:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       short M01_L01
M01_L03:
       xor       r12d,r12d
       jmp       near ptr M01_L07
M01_L04:
       mov       eax,r15d
       sub       eax,r12d
       jo        near ptr M01_L13
       mov       [rbp-44],eax
       test      r12d,r12d
       jl        near ptr M01_L11
       test      eax,eax
       jl        near ptr M01_L14
       test      eax,eax
       je        short M01_L06
       mov       r8d,edi
       sub       r8d,eax
       cmp       r8d,r12d
       jl        near ptr M01_L15
       movsxd    r8,r12d
       lea       rdx,[rbx+r8*2+0C]
       mov       r8,[r13+8]
       mov       r12d,[r13+18]
       lea       ecx,[r12+rax]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L24
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       eax,2
       jle       near ptr M01_L21
       movsxd    r8,eax
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       mov       ecx,[rbp-44]
       add       ecx,r12d
       mov       [r13+18],ecx
M01_L06:
       mov       r12d,r14d
       add       r12d,r15d
       jo        near ptr M01_L13
M01_L07:
       mov       edx,edi
       sub       edx,r12d
       mov       ecx,r12d
       mov       r8d,edx
       add       rcx,r8
       mov       r8d,edi
       cmp       rcx,r8
       ja        near ptr M01_L16
       mov       ecx,r12d
       lea       rcx,[rbx+rcx*2+0C]
       lea       r8,[rsi+0C]
       mov       r9d,r14d
       call      qword ptr [7FF9000A51A0]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       jge       near ptr M01_L12
       mov       r15d,eax
M01_L08:
       cmp       r15d,0FFFFFFFF
       jne       near ptr M01_L04
       cmp       edi,r12d
       jle       short M01_L10
       mov       esi,edi
       sub       esi,r12d
       jo        near ptr M01_L13
       test      r12d,r12d
       jl        short M01_L11
       test      esi,esi
       jl        near ptr M01_L18
       test      esi,esi
       je        short M01_L10
       sub       edi,esi
       cmp       edi,r12d
       jl        near ptr M01_L19
       movsxd    r8,r12d
       lea       rdx,[rbx+r8*2+0C]
       mov       r8,[r13+8]
       mov       r14d,[r13+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L20
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       near ptr M01_L22
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9000A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L09:
       add       esi,r14d
       mov       [r13+18],esi
M01_L10:
       mov       rcx,r13
       call      qword ptr [7FF9001D9B30]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M01_L25
M01_L11:
       mov       ecx,172D
       mov       rdx,7FF8FFEA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FF9008E4978]
       int       3
M01_L12:
       lea       r15d,[rax+r12]
       jmp       near ptr M01_L08
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       ecx,1C7
       mov       rdx,7FF8FFEA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rbp-44]
       call      qword ptr [7FF9008E4978]
       int       3
M01_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,172D
       mov       rdx,7FF8FFEA4000
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       call      qword ptr [7FF9005756F8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rdi
       call      qword ptr [7FF9000AD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L16:
       cmp       edi,r12d
       jae       short M01_L17
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9002F5B60]
       int       3
M01_L17:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF9002F5B60]
       int       3
M01_L18:
       mov       ecx,1C7
       mov       rdx,7FF8FFEA4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9008E4978]
       int       3
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF8FFEA4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9005756F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9000AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,r13
       mov       r8d,esi
       call      qword ptr [7FF9001CD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L10
M01_L21:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       eax,2
       jne       near ptr M01_L05
       jmp       short M01_L23
M01_L22:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       near ptr M01_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L09
M01_L23:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L05
M01_L24:
       mov       rcx,r13
       mov       r8d,eax
       call      qword ptr [7FF9001CD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L06
M01_L25:
       mov       rcx,rsp
       call      M01_L28
       nop
       mov       rax,[rbp-58]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L26:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF90077F1C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L02
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L00
M01_L27:
       mov       rax,294B93E0008
       test      rbx,rbx
       cmove     rbx,rax
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L28:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,2542740AB58
       mov       rdi,[rcx]
       mov       r14,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r14+18],rcx
       jne       short M01_L29
       mov       rcx,[rbp-50]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r14+8]
       cmp       edx,[rax+0C]
       jg        short M01_L33
       xor       edx,edx
       call      qword ptr [7FF9001CD0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L30
M01_L29:
       mov       r13,[rbp-50]
       mov       rdx,r13
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M01_L33
M01_L30:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L31
       lea       rcx,[rdi+20]
       mov       rdx,[rbp-50]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L33
M01_L31:
       mov       r13,[rbp-50]
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L32
       mov       rcx,[rdi+18]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF90077F198]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L33
M01_L32:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L33:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1226
```

