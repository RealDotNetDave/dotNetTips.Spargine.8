## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C776F58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1807E01591C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,13FEC000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1807E015930
       call      qword ptr [7FF80C0C4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,1807E0158F0
       mov       rdx,1807E000210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1807E000008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1807E000008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C756B68]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1B29C8B591C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,1720EC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1B29C8B5930
       call      qword ptr [7FF80C0A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,1B29C8B58F0
       mov       rdx,1B29C8A0210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1B29C8A0008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1B29C8A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C766B68]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1F79EB5591C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,1B70CC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1F79EB55930
       call      qword ptr [7FF80C0B4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C38CB28]
       mov       rcx,1F79EB558F0
       mov       rdx,1F79EB40210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F79EB40008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F79EB40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C756F58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,3016650591C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,2C0D4800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,30166505930
       call      qword ptr [7FF80C0A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C37CB28]
       mov       rcx,301665058F0
       mov       rdx,301664F0210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,301664F0008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,301664F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C75C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,23746B9593C
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L02
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L07
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,1F6B8C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,23746B95950
       call      qword ptr [7FF80C0A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L04
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L03
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
M01_L02:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       add       edi,1
       jo        short M01_L09
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       [rbx+18],r15d
       jmp       short M01_L04
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L15
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L11:
       call      qword ptr [7FF80C3AC348]
       mov       rcx,23746B95910
       mov       rdx,23746B80210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23746B80008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L12
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L13
M01_L12:
       mov       ecx,1
M01_L13:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L14
       call      qword ptr [7FF80C3AC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L14:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 676
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4056F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,23746B80008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C77C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,2B42ECF593C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,2739D000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2B42ECF5950
       call      qword ptr [7FF80C0C4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C39CB28]
       mov       rcx,2B42ECF5910
       mov       rdx,2B42ECE0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2B42ECE0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B42ECE0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C797E28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1B39E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1DCAEFA593C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,19C21000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1DCAEFA5950
       call      qword ptr [7FF80C0E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,1DCAEFA5910
       mov       rdx,1DCAEF90210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1DCAEF90008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C445EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1DCAEF90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+190]
       mov       rcx,rsi
       call      qword ptr [7FF80C7AF1C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L11
       test      rbx,rbx
       je        near ptr M01_L12
       mov       rdx,1B0709F598C
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
       mov       r14d,ebp
       test      r14,r14
       jle       near ptr M01_L04
M01_L01:
       cmp       edi,ebp
       jae       near ptr M01_L16
       mov       ecx,edi
       lea       rcx,[rsi+rcx+10]
       mov       r8,16FDEC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1B0709F59A0
       call      qword ptr [7FF80C0D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L03
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L03
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
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
       mov       [rbx+18],r15d
M01_L03:
       add       edi,1
       jo        short M01_L10
       movsxd    rax,edi
       cmp       r14,rax
       jg        near ptr M01_L01
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
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C3DC348]
       mov       rcx,1B0709F5960
       mov       rdx,1B0709E0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1B0709E0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 668
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4356F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1B0709E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,290AA7290D8
       call      qword ptr [7FF80C756FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C85E538]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C85E538]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C85E538]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C85E538]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C85E538]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,290AA720008
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
       call      qword ptr [7FF80C757090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3AC348]
       mov       rcx,290AA7358F0
       mov       rdx,290AA720210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,290AA720008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3AC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rbx,290AA7290D8
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4056F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,290AA720008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,1AC41FF90D8
       call      qword ptr [7FF80C786FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C88E820]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C88E820]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C88E820]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C88E820]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C88E820]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1AC41FF0008
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
       call      qword ptr [7FF80C787090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,1AC420058F0
       mov       rdx,1AC41FF0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1AC41FF0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rbx,1AC41FF90D8
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1AC41FF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,199248A90D8
       call      qword ptr [7FF80C796FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1B39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C89D170]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C89D170]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C89D170]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C89D170]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C89D170]
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,199248A0008
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
       call      qword ptr [7FF80C797090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3BCB28]
       mov       rcx,199248B58F0
       mov       rdx,199248A0210
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,199248A0008
       call      qword ptr [7FF80BED6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3BCC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C240928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3BC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3BC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3BCDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C136670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BED7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3BC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C136670]
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
       mov       rbx,199248A90D8
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C445EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,199248A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,2EF153A90D8
       call      qword ptr [7FF80C77C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C87D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C87D158]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2EF153A0008
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
       call      qword ptr [7FF80C77C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C39CB28]
       mov       rcx,2EF153B5910
       mov       rdx,2EF153A0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2EF153A0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       mov       rbx,2EF153A90D8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2EF153A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,186AD9190D8
       call      qword ptr [7FF80C776FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C87C930]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C87C930]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C87C930]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C87C930]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C87C930]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,186AD910008
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
       call      qword ptr [7FF80C777090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3CC348]
       mov       rcx,186AD9258F0
       mov       rdx,186AD910210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,186AD910008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3CC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3CC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       mov       rbx,186AD9190D8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,186AD910008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,27CD92990D8
       call      qword ptr [7FF80C78C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C88D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C88D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C88D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C88D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C88D158]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,27CD9290008
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
       call      qword ptr [7FF80C78C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3DC348]
       mov       rcx,27CD92A5910
       mov       rdx,27CD9290210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27CD9290008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rbx,27CD92990D8
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4356F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27CD9290008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,27C252D90D8
       call      qword ptr [7FF80C76C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C86D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C86D158]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,27C252D0008
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
       call      qword ptr [7FF80C76C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C38CB28]
       mov       rcx,27C252E5910
       mov       rdx,27C252D0210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,27C252D0008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C38CC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       mov       rbx,27C252D90D8
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27C252D0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+198]
       mov       rcx,rsi
       mov       rdx,2135EDA90D8
       call      qword ptr [7FF80C79F210]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C86D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L13
M01_L10:
       call      qword ptr [7FF80C86D158]
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
       mov       rax,7FF855822C00
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FF80C86D158]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L12
M01_L17:
       mov       r13,2135EDA0008
       jmp       short M01_L14
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r15
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF80C79F300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C39CB28]
       mov       rcx,2135EDB5960
       mov       rdx,2135EDA0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2135EDA0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C116670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       mov       rbx,2135EDA90D8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2135EDA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,2567EDA90D8
       call      qword ptr [7FF80C77C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C87EC40]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C87EC40]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C87EC40]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C87EC40]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C87EC40]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2567EDA0008
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
       call      qword ptr [7FF80C77C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3CC348]
       mov       rcx,2567EDB5910
       mov       rdx,2567EDA0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2567EDA0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3CC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3C7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3CC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       mov       rbx,2567EDA90D8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4256F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2567EDA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,20D67EF90D8
       call      qword ptr [7FF80C786F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C88EB08]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C88EB08]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C88EB08]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C88EB08]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C88EB08]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,20D67EF0008
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
       call      qword ptr [7FF80C787090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3DC348]
       mov       rcx,20D67F058F0
       mov       rdx,20D67EF0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20D67EF0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3DC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3D7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3DC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3DC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3DC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rbx,20D67EF90D8
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4356F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,20D67EF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,20BC86590D8
       call      qword ptr [7FF80C776F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C87CC30]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C87CC30]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C87CC30]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C87CC30]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C87CC30]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,20BC8650008
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
       call      qword ptr [7FF80C777090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C39CB28]
       mov       rcx,20BC86658F0
       mov       rdx,20BC8650210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20BC8650008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C39CC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       mov       rbx,20BC86590D8
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,20BC8650008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,2C6929990D8
       call      qword ptr [7FF80C756F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C85CC18]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C85CC18]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C85CC18]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C85CC18]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C85CC18]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2C692990008
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
       call      qword ptr [7FF80C757090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,2C6929A58F0
       mov       rdx,2C692990210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C692990008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rbx,2C6929990D8
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2C692990008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,1B3C97490D8
       call      qword ptr [7FF80C75C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C85D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C85D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C85D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C85D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C85D158]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1B3C9740008
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
       call      qword ptr [7FF80C75C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3AC348]
       mov       rcx,1B3C9755910
       mov       rdx,1B3C9740210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1B3C9740008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3AC468]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC060]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3AC5E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rbx,1B3C97490D8
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C4056F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1B3C9740008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,245904890D8
       call      qword ptr [7FF80C787528]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C88C138]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C88C138]
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
       jae       short M01_L08
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L06
M01_L05:
       inc       r15d
       cmp       edi,r15d
       jg        short M01_L04
M01_L06:
       lea       r14d,[rdi-1]
       cmp       r14d,r15d
       jl        near ptr M01_L14
       mov       ecx,r14d
       or        ecx,r15d
       jl        short M01_L11
       cmp       edi,r14d
       jle       short M01_L11
M01_L07:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L08:
       call      qword ptr [7FF80C88C138]
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FF80C88C138]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L26
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C88C138]
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
       mov       r13,rbx
M01_L15:
       cmp       dword ptr [r13+8],0
       jg        short M01_L17
       jmp       near ptr M01_L25
M01_L16:
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
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
       call      qword ptr [7FF80C787630]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
M01_L18:
       mov       r13,24590480008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,24590495910
       mov       rdx,24590480210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24590480008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF80C126670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       jmp       near ptr M01_L15
M01_L25:
       mov       rbx,245904890D8
       jmp       near ptr M01_L17
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 917
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,24590480008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,265D2DA90D8
       call      qword ptr [7FF80C75C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C85D248]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C85D248]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C85D248]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C85D248]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C85D248]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,265D2DA0008
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
       call      qword ptr [7FF80C75C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C37CB28]
       mov       rcx,265D2DB5910
       mov       rdx,265D2DA0210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,265D2DA0008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C37CC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C2011B8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C2011B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37C840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
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
       mov       rbx,265D2DA90D8
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,265D2DA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       r8,[rbx+1A0]
       mov       rcx,rsi
       mov       rdx,21F0FD790D8
       call      qword ptr [7FF80C7AF108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C87D158]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L24
M01_L02:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF80C87D158]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF80C87D158]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,21F0FD70008
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
       call      qword ptr [7FF80C7AF210]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF80C3ACB28]
       mov       rcx,21F0FD85938
       mov       rdx,21F0FD70210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21F0FD70008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3ACC48]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
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
       mov       rbx,21F0FD790D8
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21F0FD70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C766D90]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,1727F00B160
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
       call      qword ptr [7FF80C17C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,1B310F358D4
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1727F000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1B310F358E8
       call      qword ptr [7FF80C0B4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,1B310F20008
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
       call      qword ptr [7FF80C594D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1727F00B160
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
       call      qword ptr [7FF80C17C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C594D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C79C198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,166D180B160
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
       call      qword ptr [7FF80C1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,1A76367591C
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
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,166D1800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1A763675930
       call      qword ptr [7FF80C0E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1B39E8]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,1A763660008
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
       call      qword ptr [7FF80C5C4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,166D180B160
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
       call      qword ptr [7FF80C1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C5C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C766B50]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,1DAD8C09168
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
       call      qword ptr [7FF80C17C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,21B6A9958FC
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,1DADCC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,21B6A995910
       call      qword ptr [7FF80C0B4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,21B6A980008
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
       call      qword ptr [7FF80C594D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1DAD8C09168
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
       call      qword ptr [7FF80C17C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C594D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C756F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,1305C409168
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
       call      qword ptr [7FF80C16C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,170EA2858FC
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
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,13058400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,170EA285910
       call      qword ptr [7FF80C0A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,170EA270008
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
       call      qword ptr [7FF80C584D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,1305C409168
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
       call      qword ptr [7FF80C16C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C584D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C79C198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,24AB480B160
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
       call      qword ptr [7FF80C1AC150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,28B4676591C
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
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,24AB4800428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,28B46765930
       call      qword ptr [7FF80C0E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1B39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rax,[rbp-38]
       mov       rcx,rax
       call      qword ptr [7FF80C1ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C1AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,28B46750008
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
       call      qword ptr [7FF80C5C4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,24AB480B160
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
       call      qword ptr [7FF80C1AC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C5C4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C78C000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,299D6409168
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
       call      qword ptr [7FF80C19C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,2DA683C58F4
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,299DE400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2DA683C5908
       call      qword ptr [7FF80C0D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,2DA683B0008
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
       call      qword ptr [7FF80C5B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,299D6409168
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
       call      qword ptr [7FF80C19C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C5B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C787E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       mov       rcx,25B8300B160
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
       call      qword ptr [7FF80C19C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,29C14FE591C
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,edi
       cmp       r14d,r8d
       jae       near ptr M01_L11
       mov       r8d,r14d
       add       rcx,r8
       mov       r8,25B83000428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,29C14FE5930
       call      qword ptr [7FF80C0D4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L07
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-38]
       jmp       short M01_L09
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,29C14FD0008
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
       call      qword ptr [7FF80C5B4D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,25B8300B160
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
       call      qword ptr [7FF80C19C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF80C5B4D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FF80C77F1B0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L16
       mov       rcx,24123409168
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-28],rcx
       cmp       qword ptr [rbp-28],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-28]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-28]
       jne       near ptr M01_L17
M01_L00:
       mov       rcx,[rbp-28]
M01_L01:
       xor       edx,edx
       mov       [rbp-28],rdx
       mov       [rbp-30],rcx
       mov       esi,[rbx+8]
       imul      edx,esi,2
       jo        near ptr M01_L15
       cmp       [rcx],ecx
       call      qword ptr [7FF80C16C150]; System.Text.StringBuilder.set_Capacity(Int32)
       nop
       mov       rdx,281AD23596C
       mov       rax,[rbp-30]
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
       jmp       near ptr M01_L10
M01_L03:
       mov       rcx,rax
       mov       r8d,3
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rax,[rbp-30]
       jmp       short M01_L02
M01_L04:
       lea       rcx,[rbx+10]
       mov       r8d,esi
       cmp       edi,r8d
       jae       short M01_L05
       mov       r8d,edi
       add       rcx,r8
       mov       r8,2411B400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,281AD235980
       call      qword ptr [7FF80C0A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rax,[rbp-30]
       mov       rcx,[rax+8]
       mov       r10d,[rax+18]
       lea       r14d,[r10+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     r10d,word ptr [rdx]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       short M01_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L07
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       mov       rax,[rbp-30]
       mov       [rax+18],r14d
       jmp       short M01_L09
M01_L08:
       mov       rax,[rbp-30]
       mov       rcx,rax
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       add       edi,1
       jo        short M01_L12
       mov       rax,[rbp-30]
M01_L10:
       mov       ecx,esi
       cmp       edi,ecx
       jl        near ptr M01_L04
       mov       ecx,[rax+18]
       mov       edx,ecx
       mov       r8,[rax+8]
       mov       r10d,[r8+8]
       cmp       r10d,edx
       jbe       short M01_L13
       mov       word ptr [r8+rdx*2+10],27
       inc       ecx
       mov       [rax+18],ecx
M01_L11:
       mov       rcx,rax
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-38],rax
       jmp       short M01_L14
M01_L12:
       call      CORINFO_HELP_OVERFLOW
M01_L13:
       mov       rcx,rax
       mov       edx,27
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rax,[rbp-30]
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsp
       call      M01_L20
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rax,281AD220008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L17:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C584D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rax,[rbp-38]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L20:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,24123409168
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L21
       mov       rcx,[rbp-30]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rdi+8]
       cmp       edx,[rax+0C]
       jg        short M01_L25
       xor       edx,edx
       call      qword ptr [7FF80C16C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L22
M01_L21:
       mov       rdx,[rbp-30]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L25
M01_L22:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L23
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-30]
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
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C584D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L25
M01_L24:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L25:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 773
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C87E538]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C87E538]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,144F080BD68
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEB7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C18C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,185826C90E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C18CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C777F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C34D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C18C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C18C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C18C3D8]; System.Text.StringBuilder.Append(Char)
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
       ja        near ptr M01_L07
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L04
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       ret
M01_L03:
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
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
       jmp       qword ptr [7FF80BF65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 263
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C18CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0EE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0EE9B8]
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
       lea       r10,[7FF80C7FC288]
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
       call      qword ptr [7FF80C9452A8]
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
       call      qword ptr [7FF80C945C08]
       jmp       short M03_L01
M03_L02:
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
       call      qword ptr [7FF80C1FDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       jmp       short M03_L02
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C297288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C18CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2B7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C24DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C8FF828]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C944A38]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0EECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0EED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0EED18]
       int       3
       mov       eax,0FFFFFFFF
       jmp       near ptr M03_L01
; Total bytes of code 517
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C7B51A0]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C7B51A0]
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,185826C0008
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
       call      qword ptr [7FF80C18CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C87E538]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       ecx,ecx
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C87E538]
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
       call      qword ptr [7FF80C39CC48]
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
       call      qword ptr [7FF80C39CC48]
       mov       rcx,rax
       mov       rdx,185826D5C18
       call      qword ptr [7FF80C39CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C86E940]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C86E940]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       xor       r13d,r13d
       mov       r9,187F940BD68
       mov       r12,[r9]
M00_L14:
       mov       rdx,r12
       mov       r9d,r15d
       sub       r9d,r13d
       mov       rcx,r14
       mov       r8d,r13d
       call      qword ptr [7FF80BEB7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+34],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r15d,r13d
       jo        near ptr M00_L21
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FF80C18C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,1C88B4190E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C18CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1939E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C777060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C39CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C34D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r13d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FF80C18C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C18C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,[rsp+34]
       cmp       r13d,r15d
       jae       short M00_L24
       mov       edx,r13d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C18C3D8]; System.Text.StringBuilder.Append(Char)
       add       r13d,1
       jo        short M00_L21
       jmp       near ptr M00_L14
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 980
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
       jmp       qword ptr [7FF80BF65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C18CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0EE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0EE9B8]
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
       lea       r10,[7FF80C7EC988]
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
       call      qword ptr [7FF80C945110]
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
       call      qword ptr [7FF80C945A70]
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
       call      qword ptr [7FF80C1FDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C297288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C18CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2B7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C24DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C8FF690]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C9448A0]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0EECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0EED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0EED18]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C8344C8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C8344C8]
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C18CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C425EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1C88B410008
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
       call      qword ptr [7FF80C18CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C86E940]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C86E940]
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
       call      qword ptr [7FF80C39CC48]
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
       call      qword ptr [7FF80C39CC48]
       mov       rcx,rax
       mov       rdx,1C88B425BF8
       call      qword ptr [7FF80C39CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C39CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C18C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C88D158]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C88D158]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,23C4780BD68
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEC7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C19C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,27CD98F90E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C19CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C78C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C35D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C19C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C19C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C19C3D8]; System.Text.StringBuilder.Append(Char)
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
       jmp       qword ptr [7FF80BF75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C19CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0FE9B8]
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
       lea       r10,[7FF80C80EFE8]
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
       call      qword ptr [7FF80C955920]
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
       call      qword ptr [7FF80C956280]
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
       call      qword ptr [7FF80C20DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C2A7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C19CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2C7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C25DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C90FED0]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C9550B0]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0FECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0FED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0FED18]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C7C54E8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C7C54E8]
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1266E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,27CD98F0008
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
       call      qword ptr [7FF80C19CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C88D158]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C88D158]
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
       call      qword ptr [7FF80C3ACC48]
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
       call      qword ptr [7FF80C3ACC48]
       mov       rcx,rax
       mov       rdx,27CD9905C18
       call      qword ptr [7FF80C3ACE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
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
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C86C930]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C86C930]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,1BAAB80BD68
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEA7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,1FB398C90E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C17CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C767F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C33DF58
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C2111B8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C2111B8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
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
       jmp       qword ptr [7FF80BF55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0DE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0DE9B8]
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
       lea       r10,[7FF80C7ECFA8]
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
       call      qword ptr [7FF80C9358D8]
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
       call      qword ptr [7FF80C936238]
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
       call      qword ptr [7FF80C19C258]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C287288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C17CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2A7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C23DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C8EFE88]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C935068]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0DECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0DED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0DED18]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C7A51A0]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C7A51A0]
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1FB398C0008
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
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C86C930]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C86C930]
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
       call      qword ptr [7FF80C38CC48]
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
       call      qword ptr [7FF80C38CC48]
       mov       rcx,rax
       mov       rdx,1FB398D5C18
       call      qword ptr [7FF80C38CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
M00_L03:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FF80C85CC18]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FF80C85CC18]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,22EFB00BD68
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BE97540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C16C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,26F8D1290E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C16CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1739E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C756EB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C37CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C32D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C16C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C16C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C16C3D8]; System.Text.StringBuilder.Append(Char)
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
       jmp       qword ptr [7FF80BF45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C16CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0CE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0CE9B8]
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
       lea       r10,[7FF80C7DEA68]
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
       call      qword ptr [7FF80C925488]
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
       call      qword ptr [7FF80C925DE8]
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
       call      qword ptr [7FF80C1DDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C277288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C16CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C297A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C22DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C8DFA38]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C924C18]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0CECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0CED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0CED18]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C7944C8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C7944C8]
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C16CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C405EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,26F8D120008
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
       call      qword ptr [7FF80C16CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C85CC18]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C85CC18]
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
       call      qword ptr [7FF80C37CC48]
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
       call      qword ptr [7FF80C37CC48]
       mov       rcx,rax
       mov       rdx,26F8D135BF8
       call      qword ptr [7FF80C37CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C37CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
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
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C16C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C88D248]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C88D248]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,1D5B7C0BD68
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEC7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C19C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,21649D590E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C19CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1A39E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C78C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C3ACC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C35D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C19C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C19C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C19C3D8]; System.Text.StringBuilder.Append(Char)
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
       ja        short M01_L07
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
       je        short M01_L06
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L06:
       test      r8b,4
       je        short M01_L09
       jmp       short M01_L08
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
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
       jmp       qword ptr [7FF80BF75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 273
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C19CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0FE9B8]
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
       lea       r10,[7FF80C80E3A8]
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
       call      qword ptr [7FF80C956238]
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
       call      qword ptr [7FF80C956B98]
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
       call      qword ptr [7FF80C20DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C2A7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C19CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2C7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C25DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C9547F8]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C9559C8]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0FECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0FED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0FED18]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF80C7C54E8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF80C7C54E8]
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1266E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C19CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C435EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,21649D50008
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
       call      qword ptr [7FF80C19CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C88D248]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C88D248]
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
       call      qword ptr [7FF80C3ACC48]
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
       call      qword ptr [7FF80C3ACC48]
       mov       rcx,rax
       mov       rdx,21649D65C18
       call      qword ptr [7FF80C3ACE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3ACDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
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
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C19C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C86D248]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C86D248]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       r9,1ECED409D70
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEA7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,22D7F1A90E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C17CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C76C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r12d,[rsi+18]
       mov       eax,r12d
       mov       r8,[rsi+8]
       cmp       [r8+8],eax
       ja        near ptr M00_L12
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L19:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L20:
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C33D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
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
       jmp       qword ptr [7FF80BF55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0DE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0DE9B8]
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
       lea       r10,[7FF80C7ED4E8]
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
       call      qword ptr [7FF80C936238]
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
       call      qword ptr [7FF80C936B98]
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
       call      qword ptr [7FF80C1EDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C287288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C17CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2A7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C23DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C9347F8]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C9359C8]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0DECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0DED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0DED18]
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
       mov       rdx,22D7F1A43D0
       call      qword ptr [7FF80C2840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,22D7F1A43B0
       call      qword ptr [7FF80C2840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       test      rbp,rbp
       je        short M04_L04
       test      ebx,ebx
       je        short M04_L03
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
       ja        short M04_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L01
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,22D7F1A0008
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
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C86D248]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C86D248]
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
       call      qword ptr [7FF80C38CC48]
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
       call      qword ptr [7FF80C38CC48]
       mov       rcx,rax
       mov       rdx,22D7F1B5C18
       call      qword ptr [7FF80C38CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF80C86CA50]
       test      eax,eax
       jne       near ptr M00_L22
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L22
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF80C86CA50]
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L19
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L17
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r12d,r12d
       mov       r9,1F8F4C09D70
       mov       rax,[r9]
       mov       [rsp+30],rax
M00_L14:
       mov       rdx,rax
       mov       r9d,r13d
       sub       r9d,r12d
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80BEA7540]; System.String.IndexOfAny(Char[], Int32, Int32)
       mov       [rsp+44],eax
       test      eax,eax
       jge       near ptr M00_L23
       sub       r13d,r12d
       jo        near ptr M00_L21
       mov       r9d,r13d
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       mov       rdx,23986A790E4
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80C17CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rsp+38],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C767F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L18:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       call      qword ptr [7FF80C38CC48]
       mov       rbx,rax
       mov       ecx,219
       mov       rdx,7FF80C33D560
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       call      CORINFO_HELP_OVERFLOW
M00_L22:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L23:
       mov       r9d,eax
       sub       r9d,r12d
       jo        short M00_L21
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,r12d
       call      qword ptr [7FF80C17C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r12d,[rsp+44]
       cmp       r12d,r13d
       jae       short M00_L24
       mov       edx,r12d
       movzx     edx,word ptr [r15+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FF80C17C3D8]; System.Text.StringBuilder.Append(Char)
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
       je        short M01_L07
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
       jmp       short M01_L02
M01_L07:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M01_L02
M01_L08:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80BF55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415FC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF80C0DE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF80C0DE9B8]
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
       lea       r10,[7FF80C7EB368]
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
       call      qword ptr [7FF80C935C80]
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
       call      qword ptr [7FF80C9365E0]
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
       call      qword ptr [7FF80C1ECB28]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L02:
       jmp       near ptr M03_L01
M03_L03:
       mov       edx,r8d
       mov       r8,rax
       call      qword ptr [7FF80C287288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L06
       movsx     rdx,si
       call      qword ptr [7FF80C17CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF80C2A7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
M03_L05:
       jmp       near ptr M03_L01
M03_L06:
       call      qword ptr [7FF80C23DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L07:
       mov       r8d,r9d
       mov       r9d,r10d
       call      qword ptr [7FF80C934240]
       jmp       near ptr M03_L02
M03_L08:
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9d,eax
       call      qword ptr [7FF80C935410]
       jmp       short M03_L05
M03_L09:
       mov       ecx,60
       call      qword ptr [7FF80C0DECD0]
       int       3
M03_L10:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF80C0DED18]
       int       3
M03_L11:
       mov       ecx,1B
       mov       edx,4
       call      qword ptr [7FF80C0DED18]
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
       mov       rdx,23986A743D0
       call      qword ptr [7FF80C2840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,23986A743B0
       call      qword ptr [7FF80C2840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
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
       ja        short M05_L02
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M05_L01
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L02:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M05_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 111
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
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C415EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,23986A70008
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
       call      qword ptr [7FF80C17CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C86CA50]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       ecx,ecx
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C86CA50]
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
       call      qword ptr [7FF80C38CC48]
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
       call      qword ptr [7FF80C38CC48]
       mov       rcx,rax
       mov       rdx,23986A85C18
       call      qword ptr [7FF80C38CE58]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38C840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C38CDC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       mov       rax,[7FF85629E6E0]
       test      byte ptr [rax+rcx],80
       je        short M10_L03
       jmp       short M10_L02
M10_L01:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FF856285318]
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
       mov       rsi,[7FF85629E6E0]
       test      byte ptr [rsi+rcx],80
       je        short M10_L10
       jmp       short M10_L09
M10_L08:
       call      qword ptr [7FF856285318]
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
       call      qword ptr [7FF856281468]
       jmp       short M10_L11
M10_L13:
       mov       rax,[7FF85629E858]
       mov       rax,[rax]
       jmp       short M10_L11
M10_L14:
       call      qword ptr [7FF856271D20]; CORINFO_HELP_RNGCHKFAIL
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
       call      qword ptr [7FF80C17C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M11_L00
; Total bytes of code 62
```
