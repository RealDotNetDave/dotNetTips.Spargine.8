## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82DB51E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827E39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,240388657CC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,1FFA6800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,240388657E0
       call      qword ptr [7FFF82714810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,240388657A0
       mov       rdx,24038850210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24038850008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF829ECC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A75EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,24038850008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82DB5398]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,16EFC3957F4
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,12E6A400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,16EFC395808
       call      qword ptr [7FFF82704810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF82A0C348]
       mov       rcx,16EFC3957C8
       mov       rdx,16EFC380210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16EFC380008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,16EFC380008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82DB4DE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1C4CD2957F4
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,1843B400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1C4CD295808
       call      qword ptr [7FFF82704810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1C4CD2957C8
       mov       rdx,1C4CD280210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C4CD280008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1C4CD280008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82DB4DE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1A632F857F4
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,165A1000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1A632F85808
       call      qword ptr [7FFF82704810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1A632F857C8
       mov       rdx,1A632F70210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A632F70008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1A632F70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82DB6B68]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,2F6584B5814
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,2B5C6800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2F6584B5828
       call      qword ptr [7FFF82704810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF82A0C348]
       mov       rcx,2F6584B57E8
       mov       rdx,2F6584A0210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2F6584A0008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A0C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2F6584A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82D969B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,2B9EA8C57EC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,27958800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2B9EA8C5800
       call      qword ptr [7FFF826E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2B9EA8C57C0
       mov       rdx,2B9EA8B0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2B9EA8B0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B9EA8B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82D86F58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827A39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1BAFFCC5814
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L08
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,17A6DC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1BAFFCC5828
       call      qword ptr [7FFF826D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L06
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L07
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L10
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       short M01_L09
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFF829ACB28]
       mov       rcx,1BAFFCC57E8
       mov       rdx,1BAFFCB0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1BAFFCB0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 632
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8257D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1BAFFCB0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       rdx,[rbx+180]
       mov       rcx,rsi
       call      qword ptr [7FFF82E657D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFF827A39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 134
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L07
       test      rbx,rbx
       je        near ptr M01_L08
       mov       rdx,32CB2F55864
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L12
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rbx+18],r8d
M01_L00:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       near ptr M01_L04
M01_L01:
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,2EC21000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,32CB2F55878
       call      qword ptr [7FFF826D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rax,[rbx+8]
       mov       ecx,[rbx+18]
       lea       r14d,[rcx+r8]
       cmp       r14d,[rax+8]
       ja        near ptr M01_L15
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2+10]
       cmp       r8d,2
       jg        near ptr M01_L14
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M01_L13
M01_L02:
       mov       [rbx+18],r14d
M01_L03:
       add       edi,1
       jo        short M01_L06
       cmp       ebp,edi
       jg        short M01_L01
M01_L04:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L16
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L05:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L08:
       call      qword ptr [7FFF829DC348]
       mov       rcx,32CB2F55838
       mov       rdx,32CB2F40210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,32CB2F40008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L09
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L10
M01_L09:
       mov       ecx,1
M01_L10:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L11
       call      qword ptr [7FFF829DC468]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC060]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF829DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF829DC060]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FFF82726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L13:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L02
M01_L14:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L02
M01_L15:
       mov       rcx,rbx
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L03
M01_L16:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L05
; Total bytes of code 666
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
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A356F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8257D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,32CB2F40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,31AA43C90D8
       call      qword ptr [7FFF82D953E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E8C828]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E8C828]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E8C828]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E8C828]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E8C828]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,31AA43C0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82D954D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829EC348]
       mov       rcx,31AA43D57C8
       mov       rdx,31AA43C0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,31AA43C0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829EC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829E7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,31AA43C90D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A456F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,31AA43C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,22E5E1390D8
       call      qword ptr [7FFF82DB4E28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EA7A38]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EA7A38]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EA7A38]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EA7A38]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EA7A38]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,22E5E130008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DB4F18]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,22E5E1457C8
       mov       rdx,22E5E130210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22E5E130008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829DCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,22E5E1390D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22E5E130008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,2429AE990D8
       call      qword ptr [7FFF82DA6FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E9C198]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E9C198]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E9C198]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E9C198]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E9C198]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2429AE90008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DA7090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,2429AEA57E8
       mov       rdx,2429AE90210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2429AE90008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829CCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,2429AE990D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2429AE90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,1A9B53190D8
       call      qword ptr [7FFF82D96FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1A9B5310008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82D97090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1A9B53257E8
       mov       rdx,1A9B5310210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A9B5310008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829BCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,1A9B53190D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 904
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1A9B5310008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,28595C490D8
       call      qword ptr [7FFF82DA6BB0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L17
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        near ptr M01_L18
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DA6CA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rdi,28595C40008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,28595C557E8
       mov       rdx,28595C40210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,28595C40008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829CCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,28595C490D8
       jmp       near ptr M01_L17
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 909
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,28595C40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,1F77C1A90D8
       call      qword ptr [7FFF82DB6FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EAC138]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EAC138]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EAC138]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EAC138]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EAC138]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1F77C1A0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DB7090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1F77C1B57E8
       mov       rdx,1F77C1A0210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F77C1A0008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829DCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,1F77C1A90D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 906
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F77C1A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,21F313890D8
       call      qword ptr [7FFF82DEE880]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827E39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EBC138]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EBC138]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EBC138]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EBC138]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EBC138]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,21F31380008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DEE970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,21F31395838
       mov       rdx,21F31380210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21F31380008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829ECC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,21F313890D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A75EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21F31380008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+188]
       mov       rcx,rsi
       mov       rdx,2B0566490D8
       call      qword ptr [7FFF82E95818]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E97A80]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E97A80]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E97A80]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E97A80]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E97A80]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L17
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        near ptr M01_L18
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF82E918D8
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82E95908]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rdi,2B056640008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,2B056655838
       mov       rdx,2B056640210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2B056640008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829CCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,2B0566490D8
       jmp       near ptr M01_L17
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 909
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B056640008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,2EDB5D390D8
       call      qword ptr [7FFF82DA53C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E9C828]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E9C828]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E9C828]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E9C828]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E9C828]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2EDB5D30008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DA54D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829CCB28]
       mov       rcx,2EDB5D457C8
       mov       rdx,2EDB5D30210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2EDB5D30008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829CCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,2EDB5D390D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2EDB5D30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,189B29490D8
       call      qword ptr [7FFF82DC53C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827E39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EBCDE0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EBCDE0]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EBCDE0]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EBCDE0]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EBCDE0]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,189B2940008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DC54D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829ECB28]
       mov       rcx,189B29557C8
       mov       rdx,189B2940210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,189B2940008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829ECC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829EC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829ECDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,189B29490D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A75EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,189B2940008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,1D4DF7990D8
       call      qword ptr [7FFF82DB4E10]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EA6958]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EA6958]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EA6958]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EA6958]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EA6958]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1D4DF790008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DB4F18]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,1D4DF7A57C8
       mov       rdx,1D4DF790210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1D4DF790008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829DCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,1D4DF7990D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D4DF790008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,283AA9390D8
       call      qword ptr [7FFF82DB6B98]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L17
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        near ptr M01_L18
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DB6CA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L18:
       mov       rdi,283AA930008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFF829DCB28]
       mov       rcx,283AA9457E8
       mov       rdx,283AA930210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,283AA930008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829DCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,283AA9390D8
       jmp       near ptr M01_L17
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 911
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,283AA930008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,282B90A90D8
       call      qword ptr [7FFF82D96F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,282B90A0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82D97090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,282B90B57E8
       mov       rdx,282B90A0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,282B90A0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829BCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,282B90A90D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,282B90A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,2AD317390D8
       call      qword ptr [7FFF82D96F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        short M01_L13
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L10
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L13
M01_L10:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L09
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L12:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L13:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L15
       mov       r13,rbx
M01_L14:
       cmp       dword ptr [r13+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L15:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       mov       r8d,r14d
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFF82E8C138]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L12
M01_L17:
       mov       r13,2AD31730008
       jmp       short M01_L14
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r15
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82D97090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,2AD317457E8
       mov       rdx,2AD31730210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2AD31730008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       r13,rbx
       jmp       near ptr M01_L14
M01_L25:
       mov       rbx,2AD317390D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 906
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2AD31730008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,1E75A0690D8
       call      qword ptr [7FFF82DBE868]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L07
M01_L06:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L07:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L08:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFF82E8C258]
       test      eax,eax
       je        short M01_L14
M01_L13:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L14:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L16
       mov       rdi,rbx
M01_L15:
       cmp       dword ptr [rdi+8],0
       jg        short M01_L18
       jmp       near ptr M01_L25
M01_L16:
       test      r14d,r14d
       je        short M01_L17
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1E75A060008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82DBE970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FFF829BCB28]
       mov       rcx,1E75A075838
       mov       rdx,1E75A060210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E75A060008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829BCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,1E75A0690D8
       jmp       near ptr M01_L18
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 902
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E75A060008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
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
       mov       r8,[rbx+190]
       mov       rcx,rsi
       mov       rdx,259A83090D8
       call      qword ptr [7FFF82E872B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFF827E39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+8]
       test      rdx,rdx
       je        near ptr M01_L19
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L23
       test      rbx,rbx
       je        near ptr M01_L25
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L24
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        near ptr M01_L24
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L06
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L06
M01_L05:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L06:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L13
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L07:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L10
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L08:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
       jmp       short M01_L13
M01_L09:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L10:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L08
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L17
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L12:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L11
M01_L13:
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M01_L15
       mov       r13,rbx
M01_L14:
       cmp       dword ptr [r13+8],0
       jg        short M01_L16
       jmp       near ptr M01_L25
M01_L15:
       test      r14d,r14d
       je        near ptr M01_L18
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       mov       r8d,r14d
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFF82E83390
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r15
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFF82E873C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L17:
       call      qword ptr [7FFF82EA7A20]
       test      eax,eax
       je        near ptr M01_L13
       jmp       near ptr M01_L12
M01_L18:
       mov       r13,259A8300008
       jmp       near ptr M01_L14
M01_L19:
       call      qword ptr [7FFF82A1C348]
       mov       rcx,259A8315838
       mov       rdx,259A8300210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,259A8300008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF82A1C468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A17A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF82A1C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A1C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFF82766670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF82A1C060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L24:
       mov       r13,rbx
       jmp       near ptr M01_L14
M01_L25:
       mov       rbx,259A83090D8
       jmp       near ptr M01_L16
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 930
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
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A756F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,259A8300008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82D85380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,2DABF00B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF8279C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,31B50DC57D4
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,2DABF000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,31B50DC57E8
       call      qword ptr [7FFF826D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r15d,[rax+8]
       test      r15d,r15d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       r8,[rax+8]
       mov       esi,[rax+18]
       lea       ecx,[rsi+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L12
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jg        short M01_L05
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       add       r15d,esi
       mov       rax,[rbp-38]
       mov       [rax+18],r15d
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827A39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       mov       r8d,r15d
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,31B50DB0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BB4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,2DABF00B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF8279C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BB4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 796
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82DA5380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,1BE1A80B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       rsi,rcx
       mov       [rbp-38],rsi
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,1FEAC6057D4
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        short M01_L03
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rsi+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1BE1A800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1FEAC6057E8
       call      qword ptr [7FFF826F4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L07
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M01_L12
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       [rsi+18],r15d
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       ecx,[rsi+18]
       mov       eax,ecx
       mov       rdx,[rsi+8]
       mov       r8d,[rdx+8]
       cmp       r8d,eax
       jbe       short M01_L13
       mov       word ptr [rdx+rax*2+10],27
       inc       ecx
       mov       [rsi+18],ecx
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,1FEAC5F0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1BE1A80B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rbx,[rbp-38]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L25
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFF827BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       rbx,[rbp-38]
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 767
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82D96F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,1E4EE0090D8
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827AC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,2257FE857F4
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1E4F2000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2257FE85808
       call      qword ptr [7FFF826E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r15d,[rax+8]
       test      r15d,r15d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       r8,[rax+8]
       mov       esi,[rax+18]
       lea       ecx,[rsi+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L12
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jg        short M01_L05
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       add       r15d,esi
       mov       rax,[rbp-38]
       mov       [rax+18],r15d
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       mov       r8d,r15d
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,2257FE70008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1E4EE0090D8
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF827AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 796
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82DA5380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,271F6C0B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,2B288AC57D4
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,271F6C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2B288AC57E8
       call      qword ptr [7FFF826F4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r10d,[rax+18]
       lea       esi,[r10+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M01_L12
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       rax,[rbp-38]
       mov       [rax+18],esi
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,2B288AB0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,271F6C0B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF827BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 789
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82DA69A0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,1A02140B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,1E0B33057CC
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1A021400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1E0B33057E0
       call      qword ptr [7FFF826F4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r10d,[rax+18]
       lea       esi,[r10+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M01_L12
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        short M01_L05
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       rax,[rbp-38]
       mov       [rax+18],esi
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,1E0B32F0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1A02140B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF827BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 789
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82D96F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,2155DC0B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827AC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,255EFA857F4
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,2155DC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,255EFA85808
       call      qword ptr [7FFF826E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r15d,[rax+8]
       test      r15d,r15d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       r8,[rax+8]
       mov       esi,[rax+18]
       lea       ecx,[rsi+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L12
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jg        short M01_L05
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       add       r15d,esi
       mov       rax,[rbp-38]
       mov       [rax+18],r15d
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       mov       r8d,r15d
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,255EFA70008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,2155DC0B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF827AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 796
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82DDE820]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-30],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,1E31DC0B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-30]
M01_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-38],rcx
       mov       edi,[rbx+8]
       imul      edx,edi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FFF827CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,223AF995844
       mov       rax,[rbp-38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       r14d,r14d
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1E31DC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,223AF995858
       call      qword ptr [7FFF82704810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L07
       lea       rdx,[rax+0C]
       mov       r15d,[rax+8]
       test      r15d,r15d
       je        short M01_L07
       mov       rax,[rbp-38]
       mov       r8,[rax+8]
       mov       esi,[rax+18]
       lea       ecx,[rsi+r15]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L12
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jg        short M01_L05
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M01_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L06
M01_L05:
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       add       r15d,esi
       mov       rax,[rbp-38]
       mov       [rax+18],r15d
M01_L07:
       add       r14d,1
       jo        short M01_L10
M01_L08:
       mov       ecx,edi
       cmp       r14d,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-38]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L09:
       mov       rcx,rax
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       mov       r8d,r15d
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,223AF980008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BE4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L18:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M01_L01
M01_L19:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1E31DC0B0D0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FFF827CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-38]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L25
M01_L23:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L24
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BE4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 796
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFF82E97E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 63
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       [rbp-50],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L21
       mov       rcx,2330A40B0D0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L16
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L16
M01_L00:
       mov       rcx,[rbp-38]
M01_L01:
       xor       edx,edx
       mov       [rbp-38],rdx
       mov       [rbp-40],rcx
       mov       esi,[rbx+8]
       imul      edx,esi,2
       jo        near ptr M01_L20
       cmp       [rcx],ecx
       call      qword ptr [7FFF827BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,2739C1E5844
       mov       rax,[rbp-40]
       mov       rcx,[rax+8]
       mov       r8d,[rax+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        short M01_L03
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rax+18],r8d
M01_L02:
       xor       edi,edi
       jmp       near ptr M01_L07
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,esi
       cmp       edi,r8d
       jae       near ptr M01_L10
       mov       r8d,edi
       add       rcx,r8
       mov       r8,2330A400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2739C1E5858
       call      qword ptr [7FFF826F4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L06
       lea       rdx,[rax+0C]
       mov       r14d,[rax+8]
       test      r14d,r14d
       je        short M01_L06
       mov       rax,[rbp-40]
       mov       rcx,[rax+8]
       mov       r15d,[rax+18]
       lea       r8d,[r15+r14]
       cmp       r8d,[rcx+8]
       ja        short M01_L11
       movsxd    r8,r15d
       lea       rcx,[rcx+r8*2+10]
       cmp       r14d,2
       jg        short M01_L13
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       je        short M01_L12
M01_L05:
       add       r14d,r15d
       mov       [rax+18],r14d
M01_L06:
       add       edi,1
       jo        short M01_L09
M01_L07:
       mov       ecx,esi
       cmp       edi,ecx
       jl        near ptr M01_L04
       mov       rax,[rbp-40]
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L14
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L08:
       mov       rcx,rax
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M01_L15
M01_L09:
       call      CORINFO_HELP_OVERFLOW
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       mov       rcx,rax
       mov       r8d,r14d
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L06
M01_L12:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L05
M01_L13:
       movsxd    r8,r14d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-40]
       jmp       short M01_L05
M01_L14:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-40]
       jmp       short M01_L08
M01_L15:
       mov       rcx,rsp
       call      M01_L22
       nop
       mov       rax,[rbp-48]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M01_L18
       mov       rsi,[rsi+8]
       mov       rcx,7FFF82BD1338
       cmp       [rsi+18],rcx
       je        short M01_L19
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,rax
M01_L17:
       jmp       near ptr M01_L01
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L19:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFF827BC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
       mov       rcx,rdi
       jmp       short M01_L17
M01_L20:
       call      CORINFO_HELP_OVERFLOW
M01_L21:
       mov       rax,2739C1D0008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
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
       mov       rcx,2330A40B0D0
       mov       r14,[rcx]
       mov       r13,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M01_L23
       mov       rcx,[rbp-40]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r13+8]
       cmp       edx,[rax+0C]
       jg        short M01_L27
       xor       edx,edx
       call      qword ptr [7FFF827BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       rdx,[rbp-40]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [r14+20],0
       jne       short M01_L25
       lea       rcx,[r14+20]
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L26
       mov       r15,[r14+18]
       mov       rcx,[r15+10]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L27
       mov       rcx,r15
       mov       rdx,[rbp-40]
       call      qword ptr [7FFF82BD4D80]
       jmp       short M01_L27
M01_L26:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L27:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 881
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82EAC0F0]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82EAC0F0]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF82826898]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,23B9A00BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824F7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF828260B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,27C2BF490E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF82826880]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF828362A0]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DB4EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF828261F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF828261F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF828261F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8298D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF827B9250
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF827B9250
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF82A07A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF828260B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF828261D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF828261D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 998
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L07
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L05
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L04
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       test      r8b,4
       je        short M01_L06
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
       jmp       short M01_L02
M01_L05:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L06:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L07:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF825A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 257
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF82826958]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A657D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8272E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8272E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E2B588]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F5E898]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F5F1F8]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8275D560]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828D6B98]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF82826CD0]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828F7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8287CD68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F5CE58]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F5E028]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF8272ECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8272ED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8272ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF82826898]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82DBE100]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82DBE100]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF82826898]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,27C2BF40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF82826958]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82EAC0F0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82EAC0F0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF82A0C468]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF82A0C468]
       mov       rcx,rax
       mov       rdx,27C2BF55AD0
       call      qword ptr [7FFF82A0C678]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF82A0C060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF82A0C5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 424
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF828261F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
M00_L03:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFF82E8C438]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFF82E8C438]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,29DD640BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824D7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,2DE645790E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827ACA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82D954A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8296D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 998
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L07:
       test      r8b,4
       je        short M01_L09
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M01_L02
M01_L09:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       qword ptr [7FFF82585B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8270E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8270E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E0C0E8]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F1F660]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F1FFC0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF827CDDA0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828B7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF827ACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828D7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8286DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F1DC20]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F1EDF0]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF8270ECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8270ED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8270ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82D9E670]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82D9E670]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2DE64570008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E8C438]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E8C438]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829BCC48]
       mov       rcx,rax
       mov       rdx,2DE64585AD0
       call      qword ptr [7FFF829BCE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82E97150]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82E97150]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,1B2DE00BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824E7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,1F36FEA90E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827BCA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DA54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829FC468]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8297D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829F7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829FC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829FC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827BC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827BC3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 998
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L08
       jmp       short M01_L07
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L08:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M01_L02
M01_L09:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       qword ptr [7FFF82595B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A557D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8271E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8271E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E1C4C8]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F2F660]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F2FFC0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF827D7C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828C6C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF827BCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828E7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8287D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F2DC20]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F2EDF0]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF8271ECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8271ED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8271ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82DAE670]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82DAE670]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A556F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A556F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1F36FEA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E97150]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E97150]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829FC468]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829FC468]
       mov       rcx,rax
       mov       rdx,1F36FEB5AD0
       call      qword ptr [7FFF829FC678]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829FC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829FC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82E97A20]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82E97A20]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,2B52500BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824D7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,2F5B6F090E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827ACA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82D96EB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8296D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1002
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L07
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L07:
       test      r8b,4
       je        short M01_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M01_L02
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF82585B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8270E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8270E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L07
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L08
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L09
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E0EDB0]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F74708]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F75068]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L10
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L10
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8281DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828B7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
M03_L04:
       call      qword ptr [7FFF8286DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L04
       movsx     rdx,si
       call      qword ptr [7FFF827ACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L05
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L11
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L11
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L11
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828D7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L06:
       jmp       near ptr M03_L01
M03_L07:
       mov       ecx,60
       call      qword ptr [7FFF8270ECD0]
       int       3
M03_L08:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8270ED18]
       int       3
M03_L09:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8270ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
M03_L10:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F1EA00]
       jmp       near ptr M03_L02
M03_L11:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F1FBD0]
       jmp       short M03_L06
; Total bytes of code 522
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L03
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
       jmp       short M04_L03
M04_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82E54240]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82E54240]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L02
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2F5B6F00008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E97A20]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E97A20]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829BCC48]
       mov       rcx,rax
       mov       rdx,2F5B6F15AF0
       call      qword ptr [7FFF829BCE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82E87930]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82E87930]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,1C0CC009CE0
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824D7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,2015E0290E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827ACA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82D97060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8296D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827AC3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 998
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L07
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L07:
       test      r8b,4
       je        short M01_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M01_L02
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF82585B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8270E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8270E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L07
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L08
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L09
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E0F3F0]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F1FDF8]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F747F8]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L10
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L10
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8281DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828B7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
M03_L04:
       call      qword ptr [7FFF8286DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L04
       movsx     rdx,si
       call      qword ptr [7FFF827ACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L05
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L11
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L11
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L11
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828D7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L06:
       jmp       near ptr M03_L01
M03_L07:
       mov       ecx,60
       call      qword ptr [7FFF8270ECD0]
       int       3
M03_L08:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8270ED18]
       int       3
M03_L09:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8270ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
M03_L10:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F1E3B8]
       jmp       near ptr M03_L02
M03_L11:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F1F588]
       jmp       short M03_L06
; Total bytes of code 522
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L03
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
       jmp       short M04_L03
M04_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82E54240]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82E54240]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A45EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8258D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2015E020008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E87930]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E87930]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829BCC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829BCC48]
       mov       rcx,rax
       mov       rdx,2015E035AF0
       call      qword ptr [7FFF829BCE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,266CE00BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824E7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,2A75FD190E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827BCA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DA6C70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8297D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF827BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827BC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827BC3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 998
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L07
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L08
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFF82595B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8271E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8271E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E1BA08]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F2FDF8]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F747F8]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8282D920]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828C7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF827BCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828E7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8287DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F2E3B8]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F2F588]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF8271ECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8271ED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8271ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       edi,r8d
       mov       ebx,r9d
       test      edi,edi
       jl        near ptr M04_L04
       test      ebx,ebx
       jl        near ptr M04_L05
       test      rdx,rdx
       je        near ptr M04_L06
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFF82DAFE40]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFF82DAFE40]
       int       3
M04_L06:
       or        ebx,edi
       jne       short M04_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L07:
       mov       ecx,2E5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L01
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A55EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2A75FD10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E97930]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829CCC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829CCC48]
       mov       rcx,rax
       mov       rdx,2A75FD25AF0
       call      qword ptr [7FFF829CCE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,[7FFFE1E9E6D0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        short M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       short M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rsi,[7FFFE1E9E6D0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFFE1E85308]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       r8d,r14d
       sub       r8d,r15d
       inc       r8d
       cmp       edi,r8d
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      r8d,r8d
       je        short M10_L13
       mov       rcx,rbx
       mov       edx,r15d
       call      qword ptr [7FFFE1E81458]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FFFE1E9E848]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FFFE1E71D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 295
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L01
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r13d,r13d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+40],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+40]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
       mov       r12d,[rsi+18]
       mov       eax,r12d
       mov       r8,[rsi+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L18
M00_L12:
       mov       ecx,eax
       mov       word ptr [r8+rcx*2+10],22
       inc       r12d
       mov       [rsi+18],r12d
M00_L13:
       xor       r12d,r12d
       mov       r9,224E840BCD8
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF824C7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF8279C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,2657A1390E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF8279CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827A39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82DAF060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r12d,[rsi+18]
       mov       eax,r12d
       mov       r8,[rsi+8]
       cmp       [r8+8],eax
       ja        near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8295D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFF824C73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FFF8279C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF8279C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF8279C3D8]; System.Text.StringBuilder.Append(Char)
       add       r12d,1
       jo        short M00_L21
       mov       rax,[rsp+30]
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1020
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L08
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M01_L10
M01_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M01_L02:
       pop       rbx
       pop       rsi
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L09
       mov       rax,r8
       shr       rax,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       jne       short M01_L07
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M01_L02
M01_L07:
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
       jmp       near ptr M01_L02
M01_L08:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF82575B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
; Total bytes of code 272
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF8279CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A35FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8257D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF826FE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF826FE9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E1DCA8]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F774B0]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82F77E10]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8280DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828A7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF8279CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828C7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8285DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82F75A70]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82F76C40]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF826FECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF826FED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF826FED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbp,rdx
       mov       edi,r8d
       mov       ebx,r9d
       mov       ecx,edi
       mov       rdx,2657A1343D0
       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,2657A1343B0
       call      qword ptr [7FFF828A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       test      rbp,rbp
       je        short M04_L04
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rbp+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L06
       movsxd    r8,edi
       lea       rdx,[rbp+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],edi
M04_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L00
M04_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L04:
       or        ebx,edi
       jne       short M04_L05
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       ecx,2E5
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827266E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8257D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       ebx,r8d
       test      ebx,ebx
       je        short M05_L03
       mov       r8,[rsi+8]
       mov       edi,[rsi+18]
       lea       ecx,[rdi+rbx]
       cmp       ecx,[r8+8]
       ja        short M05_L02
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       add       ebx,edi
       mov       [rsi+18],ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFF8279CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 123
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A35EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8257D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2657A130008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF8279CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829ACC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829ACC48]
       mov       rcx,rax
       mov       rdx,2657A145AF0
       call      qword ptr [7FFF829ACE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829ACDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824C73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L04
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M10_L06
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       je        short M10_L06
M10_L02:
       mov       rcx,7FFF82E845E0
       call      CORINFO_HELP_COUNTPROFILE32
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       mov       rcx,7FFF82E845E4
       call      CORINFO_HELP_COUNTPROFILE32
M10_L04:
       test      sil,2
       je        near ptr M10_L12
       mov       r14d,ebp
M10_L05:
       cmp       r14d,r15d
       jge       short M10_L07
       jmp       short M10_L11
M10_L06:
       mov       rcx,7FFF82E845E8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L04
M10_L07:
       cmp       r14d,edi
       jae       near ptr M10_L16
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M10_L09
       jmp       short M10_L10
M10_L08:
       call      qword ptr [7FFF82E7CC18]
       test      eax,eax
       jne       short M10_L10
M10_L09:
       mov       rcx,7FFF82E845F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L12
M10_L10:
       mov       rcx,7FFF82E845EC
       call      CORINFO_HELP_COUNTPROFILE32
       dec       r14d
       jmp       short M10_L05
M10_L11:
       mov       rcx,7FFF82E845F0
       call      CORINFO_HELP_COUNTPROFILE32
M10_L12:
       mov       rcx,7FFF82E845F4
       call      CORINFO_HELP_COUNTPROFILE32
       sub       r14d,r15d
       inc       r14d
       cmp       edi,r14d
       jne       short M10_L14
       mov       rax,rbx
M10_L13:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L14:
       test      r14d,r14d
       je        short M10_L15
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       jmp       short M10_L13
M10_L15:
       mov       rax,2657A130008
       jmp       short M10_L13
M10_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 374
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF8279C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
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
       mov       rdi,[rbx+188]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       mov       ecx,ebp
       mov       r14,[rdi+rcx*8+10]
       test      r14,r14
       je        short M00_L01
       mov       r15d,[r14+8]
       xor       ecx,ecx
       test      r15d,r15d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      r15d,r15d
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       ecx,ecx
M00_L02:
       test      ecx,ecx
       je        near ptr M00_L20
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L25
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       jne       near ptr M00_L22
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        short M00_L11
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
       mov       r13d,[rsi+18]
       mov       eax,r13d
       mov       r12,[rsi+8]
       cmp       [r12+8],eax
       jbe       near ptr M00_L18
M00_L12:
       mov       ecx,eax
       mov       word ptr [r12+rcx*2+10],22
       inc       r13d
       mov       [rsi+18],r13d
M00_L13:
       xor       r13d,r13d
       mov       r9,238B680BCD8
       mov       r12,[r9]
M00_L14:
       mov       rdx,r12
       mov       r9d,r15d
       sub       r9d,r13d
       mov       rcx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF824F7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+34],eax
       test      eax,eax
       jge       near ptr M00_L24
       sub       r15d,r13d
       jo        near ptr M00_L21
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF827CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,279447790E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFF827CCA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFF827D39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82EAD4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L17:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r13d,[rsi+18]
       mov       eax,r13d
       mov       r12,[rsi+8]
       cmp       [r12+8],eax
       ja        near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FFF8298D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       movzx     r9d,word ptr [rdx+2]
       mov       [rcx+2],r9w
       jmp       near ptr M00_L08
M00_L24:
       mov       r9d,eax
       sub       r9d,r13d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFF827CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFF827CC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,[rsp+34]
       cmp       r13d,r15d
       jae       short M00_L25
       mov       edx,r13d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFF827CC3D8]; System.Text.StringBuilder.Append(Char)
       add       r13d,1
       jo        short M00_L21
       jmp       near ptr M00_L14
M00_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1013
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M01_L07
M01_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M01_L02:
       pop       rbx
       pop       rsi
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       mov       rax,r8
       shr       rax,6
M01_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M01_L04
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
M01_L05:
       test      r8b,18
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       jne       short M01_L08
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       short M01_L02
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       jmp       short M01_L09
M01_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       near ptr M01_L02
M01_L09:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF825A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 274
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,edi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,edi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       test      r8,r8
       je        near ptr M02_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M02_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M02_L00:
       cmp       ebp,r10d
       ja        near ptr M02_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFF827CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFF8272E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFF8272E9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.String.IndexOfAny(Char[], Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       ebx,r8d
M03_L00:
       test      rdx,rdx
       je        near ptr M03_L09
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M03_L10
       sub       r8d,ebx
       cmp       r8d,r9d
       jb        near ptr M03_L11
       movsxd    r8,ebx
       lea       rcx,[rcx+r8*2+0C]
       lea       rax,[rdx+10]
       mov       edx,[rdx+8]
       mov       r8d,r9d
       mov       r9d,edx
       cmp       r9d,5
       ja        near ptr M03_L03
       mov       edx,r9d
       lea       r10,[7FFF82E39D68]
       mov       r10d,[r10+rdx*4]
       lea       r9,[M03_L00]
       add       r10,r9
       jmp       r10
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82FA6D18]
M03_L01:
       add       ebx,eax
       test      eax,eax
       cmovge    eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFF82FA7678]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       near ptr M03_L07
       mov       edx,esi
       movsx     r8,di
       movsx     rdx,dx
       mov       r9d,r10d
       call      qword ptr [7FFF8283DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FFF828D7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FFF827CCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r9,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r8d
       movzx     esi,dx
       lea       r8d,[rsi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     edi,r9w
       lea       r8d,[rdi-1]
       cmp       r8d,0FE
       jae       short M03_L08
       movzx     r8d,ax
       lea       r11d,[r8-1]
       cmp       r11d,0FE
       jae       short M03_L08
       mov       edx,esi
       mov       eax,edi
       mov       [rsp+20],r10d
       movsx     r9,r8w
       movsx     rdx,dx
       movsx     r8,ax
       call      qword ptr [7FFF828F7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FFF8288DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FFF82FA52D8]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FFF82FA64A8]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FFF8272ECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFF8272ED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FFF8272ED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 518
```
```assembly
; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbp,rdx
       mov       edi,r8d
       mov       ebx,r9d
       mov       ecx,edi
       mov       rdx,279447743D0
       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,279447743B0
       call      qword ptr [7FFF828D40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       test      rbp,rbp
       je        short M04_L04
       test      ebx,ebx
       je        short M04_L01
       mov       r8d,[rbp+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M04_L06
       movsxd    r8,edi
       lea       rdx,[rbp+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       ebp,[rcx+rbx]
       cmp       ebp,[r8+8]
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rsi+18],ebp
M04_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M04_L00
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M04_L00
M04_L04:
       or        ebx,edi
       jne       short M04_L05
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L05:
       mov       ecx,2E5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827566E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,172D
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFF825AD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 299
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M05_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M05_L01
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M05_L02
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFF827CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M05_L00
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M05_L00
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 109
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M06_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M06_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M06_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M06_L02
       cmp       [rdx+8],r8d
       jb        short M06_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,185D5
       mov       rdx,7FFF823A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF82A65EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF825AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,27944770008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
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
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF827CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FFF829DCC48]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FFF829DCC48]
       mov       rcx,rax
       mov       rdx,27944785870
       call      qword ptr [7FFF829DCE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       mov       r14d,ebp
       xor       r15d,r15d
       test      sil,1
       je        short M10_L03
       xor       r15d,r15d
       test      edi,edi
       jle       short M10_L03
M10_L00:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L01
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       je        short M10_L03
M10_L02:
       inc       r15d
       cmp       edi,r15d
       jg        short M10_L00
M10_L03:
       test      sil,2
       je        near ptr M10_L10
       mov       r14d,ebp
       cmp       r14d,r15d
       jl        near ptr M10_L10
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M10_L07
       cmp       edi,r14d
       jle       short M10_L07
M10_L04:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       je        short M10_L10
M10_L06:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L04
       jmp       short M10_L10
M10_L07:
       cmp       r14d,edi
       jae       near ptr M10_L14
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L08
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FFF82CC41B0]
       test      eax,eax
       je        short M10_L10
M10_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M10_L07
M10_L10:
       mov       esi,r14d
       sub       esi,r15d
       inc       esi
       cmp       edi,esi
       jne       short M10_L12
       mov       rax,rbx
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       test      esi,esi
       je        short M10_L13
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,esi
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r15d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       jmp       short M10_L11
M10_L13:
       mov       rax,27944770008
       jmp       short M10_L11
M10_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 336
```
```assembly
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M11_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M11_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFF827CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

