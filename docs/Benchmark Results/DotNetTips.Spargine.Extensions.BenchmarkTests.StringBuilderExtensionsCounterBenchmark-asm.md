## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE28A05C08]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,2697A1875AC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,228E8000428
       mov       r8,[r8]
       mov       rdx,2697A1875C0
       call      qword ptr [7FFE28434810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE28774C60]
       mov       ecx,946
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28585108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28774A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2697A170008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE28A35C08]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,207E3E975AC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,1C752000428
       mov       r8,[r8]
       mov       rdx,207E3E975C0
       call      qword ptr [7FFE28464810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE287A4C60]
       mov       ecx,946
       mov       rdx,7FFE28727B90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE285B4C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE28727B90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE287A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE284B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE2852C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,207E3E80008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE28A15C08]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,1D8011475AC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,19773400428
       mov       r8,[r8]
       mov       rdx,1D8011475C0
       call      qword ptr [7FFE28444810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE28784C60]
       mov       ecx,946
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28595108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28784A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D801130008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE289F5C08]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,1D0EFF075AC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,1905E000428
       mov       r8,[r8]
       mov       rdx,1D0EFF075C0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D0EFEF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE289F59F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,1C0AE6475CC
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
       test      ebp,ebp
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,18020800428
       mov       r8,[r8]
       mov       rdx,1C0AE6475E0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L04
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       [rbx+18],r14d
       jmp       short M01_L04
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1C0AE630008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE289F59F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,20CFC8B75CC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,1CC6A800428
       mov       r8,[r8]
       mov       rdx,20CFC8B75E0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,20CFC8A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE28A15278]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,1D3F10775CC
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
       test      ebp,ebp
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,19367000428
       mov       r8,[r8]
       mov       rdx,1D3F10775E0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L04
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L04
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       [rbx+18],r14d
       jmp       short M01_L04
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE2870F4F8]
       mov       ecx,946
       mov       rdx,7FFE286E8718
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28574D28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE286E8718
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE2870F2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287ADEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D3F1060008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+278]
       mov       rcx,rsi
       call      qword ptr [7FFE28A35B00]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
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
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L09
       test      rbx,rbx
       je        near ptr M01_L10
       mov       rdx,14D452075CC
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L03
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
       jle       near ptr M01_L07
M01_L01:
       mov       ecx,edi
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,10CB3400428
       mov       r8,[r8]
       mov       rdx,14D452075E0
       call      qword ptr [7FFE28464810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L05
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L05
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L04
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L06
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L02
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L02:
       mov       [rbx+18],r14d
       jmp       short M01_L05
M01_L03:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L07:
       mov       eax,[rbx+18]
       mov       ecx,eax
       mov       rdx,[rbx+8]
       mov       r8d,[rdx+8]
       cmp       r8d,ecx
       jbe       near ptr M01_L11
       mov       word ptr [rdx+rcx*2+10],27
       inc       eax
       mov       [rbx+18],eax
M01_L08:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFE287A4C60]
       mov       ecx,946
       mov       rdx,7FFE28728C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE285B5108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE28728C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE287A4A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE284B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE2852C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L08
; Total bytes of code 494
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,14D451F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CE5FC8]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CE5FC8]
       test      eax,eax
       jne       near ptr M00_L20
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
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28C8F468]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L18:
       call      qword ptr [7FFE2871F5A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE2871F2E8]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1FC80EB9CB0
       mov       r8,rbx
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 722
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       mov       rdi,rdx
       mov       esi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,esi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,esi
       jl        near ptr M02_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M02_L01
       mov       r8,[rbx+8]
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
       mov       rdx,rdi
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
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
       mov       ecx,186D1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE287BDFC8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2845E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2845E9E8]
       int       3
; Total bytes of code 319
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BDEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1FC80EB0008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L15
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
       je        near ptr M00_L19
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       jne       near ptr M00_L21
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L23
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       jne       near ptr M00_L21
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        near ptr M00_L12
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        near ptr M00_L12
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L11
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L12
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L14
       mov       r15,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r15+8]
       ja        short M00_L13
       jmp       near ptr M00_L16
M00_L11:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M00_L10
M00_L13:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L14:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L15:
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CAFFA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L16:
       movsxd    r8,r12d
       lea       rcx,[r15+r8*2+10]
       cmp       r13d,2
       jle       short M00_L18
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L17:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L14
M00_L18:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L17
M00_L19:
       call      qword ptr [7FFE287A4D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L20
       call      qword ptr [7FFE287A4A50]
       mov       rbx,rax
M00_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C4F5149CB0
       mov       r8,rbx
       call      qword ptr [7FFE284B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE282273F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2852C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282D5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       mov       rdi,rdx
       mov       esi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,esi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,esi
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
       mov       rdx,rdi
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE2852CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
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
       mov       ecx,186D1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE287DF6C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2848E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2848E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1C4F5140008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CDDC68]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CDDC68]
       test      eax,eax
       jne       near ptr M00_L20
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
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
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
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28C6FFA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L18:
       call      qword ptr [7FFE28764D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE28764A50]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28714DB9CB0
       mov       r8,rbx
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE28295B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE284ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2844E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2844E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,28714DB0008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D0DFB0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D0DFB0]
       test      eax,eax
       jne       near ptr M00_L20
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
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CD44B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L18:
       call      qword ptr [7FFE28794D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE28794A50]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25A27EB9CB0
       mov       r8,rbx
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE282173F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282C5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2847E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2847E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,25A27EB0008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CE75A0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CE75A0]
       test      eax,eax
       jne       near ptr M00_L20
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
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CB5920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L18:
       call      qword ptr [7FFE28774D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE28774A50]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,214896E9CB0
       mov       r8,rbx
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 718
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       mov       rdi,rdx
       mov       esi,r8d
       mov       r8d,[rbx+1C]
       mov       eax,[rbx+18]
       add       r8d,eax
       add       r8d,esi
       cmp       r8d,[rbx+20]
       jg        near ptr M02_L03
       cmp       r8d,esi
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
       mov       rdx,rdi
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M02_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M02_L07
M02_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
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
       mov       ecx,186D1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE287AF6C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2845E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2845E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,214896E0008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L15
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
       je        near ptr M00_L19
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D17348]
       test      eax,eax
       jne       near ptr M00_L21
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L23
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D17348]
       test      eax,eax
       jne       near ptr M00_L21
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        near ptr M00_L12
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        near ptr M00_L12
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L11
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L12
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L14
       mov       r15,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r15+8]
       ja        short M00_L13
       jmp       near ptr M00_L16
M00_L11:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M00_L10
M00_L13:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L14:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L15:
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CE5218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L16:
       movsxd    r8,r12d
       lea       rcx,[r15+r8*2+10]
       cmp       r13d,2
       jle       short M00_L18
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L17:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L14
M00_L18:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L17
M00_L19:
       call      qword ptr [7FFE287A4D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L20
       call      qword ptr [7FFE287A4A50]
       mov       rbx,rax
M00_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2E5A1569CB0
       mov       r8,rbx
       call      qword ptr [7FFE284B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE282273F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2852C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 733
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282D5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2852CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2848E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2848E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2E5A1560008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L17
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D07348]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D07348]
       test      eax,eax
       jne       near ptr M00_L20
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
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L21
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L12:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L16
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L15
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L14
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CD5548]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L18:
       call      qword ptr [7FFE28794D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE28794A50]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,19CB2B19CB0
       mov       r8,rbx
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE282173F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282C5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2847E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2847E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,19CB2B10008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue2()
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L15
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
       je        near ptr M00_L19
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D175A0]
       test      eax,eax
       jne       near ptr M00_L21
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L23
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D175A0]
       test      eax,eax
       jne       near ptr M00_L21
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        near ptr M00_L12
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        near ptr M00_L12
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L11
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L12
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L08
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L08
M00_L10:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L14
       mov       r15,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r15+8]
       ja        short M00_L13
       jmp       near ptr M00_L16
M00_L11:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L12:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       r8,[rsi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [r8+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
       jmp       short M00_L10
M00_L13:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE2852CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L14:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L15:
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CE5920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L16:
       movsxd    r8,r12d
       lea       rcx,[r15+r8*2+10]
       cmp       r13d,2
       jle       short M00_L18
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L17:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L14
M00_L18:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L17
M00_L19:
       call      qword ptr [7FFE287A4D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L20
       call      qword ptr [7FFE287A4A50]
       mov       rbx,rax
M00_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F82D6B9CB0
       mov       r8,rbx
       call      qword ptr [7FFE284B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE282273F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2852C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L10
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282D5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2852CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2848E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2848E9E8]
       int       3
; Total bytes of code 315
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
       call      System.String.FastAllocateString(Int32)
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1F82D6B0008
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
       call      qword ptr [7FFE65B7A5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FFE65B63D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; BenchmarkDotNet.Autogenerated.Runnable_1366.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+2C0],0B
       jne       short M00_L00
;                 AppendKeyValue1();
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE285B5458]
M00_L00:
       nop
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 44
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CEDEC0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CEDEC0]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1EB18C0EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DB7960]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,22BAAAA9084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CB44B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28774D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28774A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22BAAAA9CB0
       mov       r8,rbx
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2845ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE284FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE284FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2845E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2845E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2857DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D49F28]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE284FCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285BF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E55308]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2863D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DBE928]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E55B78]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E564D8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2861CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CB68F8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CB68F8]
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284866E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,22BAAAA0008
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
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D0CAF8]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D0CAF8]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,20EB740EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DD6778]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2851C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,24F491A9084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CAF468]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE2873F5A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE2873F2E8]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24F491A9CB0
       mov       r8,rbx
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2847ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE282173F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2851C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE2851C3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2851C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282C5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DDFC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2847E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2847E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE28537C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D6BAE8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE2851CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285DE610]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E2FB28]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2865C2A0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DDD2A8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E74708]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E75068]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE28637A38]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CD58C0]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CD58C0]
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284A66E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DDEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DDEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,24F491A0008
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
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CFDFB0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CFDFB0]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,1E51940EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DC7960]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2850C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,225AB409084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CC44B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28784D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28784A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,225AB409CB0
       mov       r8,rbx
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2846ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE282073F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2850C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE2850C3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2850C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2850CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2846E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2846E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2858DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D5BD98]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE2850CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285CF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E65308]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2864D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DCE928]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E65B78]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E664D8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2862CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CC68F8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CC68F8]
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284966E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,225AB400008
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
       call      qword ptr [7FFE2850CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28D0E220]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28D0E220]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,11E3280CC28
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DDC078]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2851C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,15EC4739084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CD5218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28794D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28794A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,15EC4739CB0
       mov       r8,rbx
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2847ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE282173F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2851C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE2851C3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2851C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282C5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2847E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2847E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2859DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D6C3F8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE2851CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285DF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E75308]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2865D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DDE9B8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E75B78]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E764D8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2863CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CD7990]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CD7990]
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284A66E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,15EC4730008
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
       call      qword ptr [7FFE2851CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CF7348]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CF7348]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,21E1D00EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DCC408]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2850C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,25EAF019084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CC5218]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28784D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28784A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25EAF019CB0
       mov       r8,rbx
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2846ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE282073F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE2850C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE2850C3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE2850C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282B5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE2850CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2846E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2846E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2858DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D5C4D8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE2850CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285CF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E65BF0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2864D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DCED48]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E66460]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E66DC0]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2862CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE2850CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CC7990]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CC7990]
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284966E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,25EAF010008
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
       call      qword ptr [7FFE2850CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE2850C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CE75A0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CE75A0]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,24AAE80EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DBC408]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,28B40919084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CB5920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28774D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28774A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28B40919CB0
       mov       r8,rbx
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2845ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE284FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE284FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE282A5B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2845E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2845E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2857DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D49108]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE284FCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285BF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E55BF0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2863D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DBED48]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E56460]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E56DC0]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2861CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       ja        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CB7D68]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CB7D68]
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284866E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,28B40910008
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
       call      qword ptr [7FFE284FCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
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
       mov       rdi,[rbx+280]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L18
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE28CD75A0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE28CD75A0]
       test      eax,eax
       jne       near ptr M00_L27
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,21AE000EC20
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L25
       movsxd    rax,r13d
       lea       rax,[r14+rax*2+0C]
       add       rcx,10
       mov       r8d,2
       mov       [rsp+30],rax
       mov       [rsp+38],edx
       mov       [rsp+20],rcx
       mov       [rsp+28],r8d
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       call      qword ptr [7FFE28DAC408]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L15:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284EC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,25B71D79084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L17:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE28CA5920]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE28764D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE28764A50]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25B71D79CB0
       mov       r8,rbx
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE2844ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L15
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE284EC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE284EC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE284EC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1030
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
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M01_L00:
       ret
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L00
M01_L02:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       r8,40
       ja        short M01_L07
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L11
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L00
M01_L10:
       jmp       qword ptr [7FFE28295B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 254
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE284ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE2844E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE2844E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M03_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M03_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M03_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M03_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE2856DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M03_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M03_L02:
       cmp       ebx,5
       ja        near ptr M03_L08
       mov       edx,ebx
       lea       r8,[7FFE28D37EA8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M03_L00]
       add       r8,r10
       jmp       r8
       mov       eax,0FFFFFFFF
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
       movsx     rdx,word ptr [rax]
       mov       r8d,r9d
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       short M03_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE284ECBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE285AF1B0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE28E45BF0]
       jmp       short M03_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M03_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE2862D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE28DAED48]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E46460]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE28E46DC0]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE2860CBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       ja        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M04_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE28CA7D68]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE28CA7D68]
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE284766E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       je        near ptr M05_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L02
       cmp       [rdx+8],r8d
       jb        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,25B71D70008
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
       call      qword ptr [7FFE284ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M07_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jbe       short M08_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M08_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,1E9A41E9078
       call      qword ptr [7FFE289F5A40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CD6FE8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CD6FE8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CD6FE8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CD6FE8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CD6FE8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1E9A41E0008
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
       call      qword ptr [7FFE28CA44E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,1E9A41E9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E9A41E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,162FC809078
       call      qword ptr [7FFE28A35A40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28537A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L06
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L09
       mov       rax,7FFE65112E50
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L08:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
       jmp       short M01_L13
M01_L09:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L10:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L08
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFE65112E50
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE28D1DC80]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L12
M01_L17:
       mov       r13,162FC800008
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
       call      qword ptr [7FFE28CAFFD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE287A4C60]
       mov       ecx,946
       mov       rdx,7FFE28728C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE285B5108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE28728C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE28226B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE287A4A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE284B6670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L20:
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
M01_L21:
       mov       r13,rbx
       jmp       near ptr M01_L14
M01_L22:
       mov       rbx,162FC809078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 770
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
       call      qword ptr [7FFE282D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280D4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287DF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,162FC800008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,2D0E34E9078
       call      qword ptr [7FFE28A25C50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28D0DC68]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28D0DC68]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28D0DC68]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28D0DC68]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28D0DC68]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2D0E34E0008
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
       call      qword ptr [7FFE28C9FFD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28794C60]
       mov       ecx,946
       mov       rdx,7FFE28717B90
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE285A4C28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28717B90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28794A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,2D0E34E9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D0E34E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,2727B779078
       call      qword ptr [7FFE28A15A40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CFDC68]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CFDC68]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CFDC68]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CFDC68]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CFDC68]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE28C8FFD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       mov       rdi,2727B770008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFE28784C60]
       mov       ecx,946
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28595108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28784A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,2727B779078
       jmp       near ptr M01_L17
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 767
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2727B770008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,22E65E09078
       call      qword ptr [7FFE28A25C50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28D0E8F8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28D0E8F8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28D0E8F8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28D0E8F8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28D0E8F8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,22E65E00008
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
       call      qword ptr [7FFE28CD5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28794C60]
       mov       ecx,946
       mov       rdx,7FFE28718C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE285A5108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28718C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28794A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,22E65E09078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22E65E00008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,205FE299078
       call      qword ptr [7FFE28A15B48]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CF79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CF79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,205FE290008
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
       call      qword ptr [7FFE28CC5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28784C60]
       mov       ecx,946
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28595108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28784A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,205FE299078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 762
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,205FE290008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,2C449559078
       call      qword ptr [7FFE289F5C50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CD79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CD79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2C449550008
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
       call      qword ptr [7FFE28CA5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,2C449559078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2C449550008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+280]
       mov       rcx,rsi
       mov       rdx,1DFB37A9078
       call      qword ptr [7FFE28A05C50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CE79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CE79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1DFB37A0008
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
       call      qword ptr [7FFE28CB5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28774C60]
       mov       ecx,946
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28585108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28774A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,1DFB37A9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1DFB37A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,25F646F9078
       call      qword ptr [7FFE28A15C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CF6FE8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CF6FE8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CF6FE8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CF6FE8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CF6FE8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,25F646F0008
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
       call      qword ptr [7FFE28CC44E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28784C60]
       mov       ecx,946
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28595108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28784A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,25F646F9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 766
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25F646F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,300B38F9078
       call      qword ptr [7FFE28A25A28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28D0DEC0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28D0DEC0]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28D0DEC0]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28D0DEC0]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28D0DEC0]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE28CD44E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       mov       rdi,300B38F0008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFE28794C60]
       mov       ecx,946
       mov       rdx,7FFE28718C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE285A5108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28718C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28216B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28794A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE284A6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,300B38F9078
       jmp       near ptr M01_L17
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 769
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
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287CF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282CD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,300B38F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,23792E19078
       call      qword ptr [7FFE289F5C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CDDC68]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CDDC68]
       test      eax,eax
       je        near ptr M01_L21
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CDDC68]
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
       jae       short M01_L10
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L10:
       call      qword ptr [7FFE28CDDC68]
       test      eax,eax
       je        short M01_L14
       jmp       short M01_L09
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CDDC68]
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
       jg        short M01_L18
       jmp       near ptr M01_L22
M01_L16:
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       r13,23792E10008
       jmp       short M01_L15
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
       call      qword ptr [7FFE28C6FFD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE28476670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L20:
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
M01_L21:
       mov       r13,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,23792E19078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 770
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,23792E10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,2F225359078
       call      qword ptr [7FFE28A05C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CEDFB0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CEDFB0]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CEDFB0]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CEDFB0]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CEDFB0]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2F225350008
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
       call      qword ptr [7FFE28CB44E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28774C60]
       mov       ecx,946
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28585108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28774A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,2F225359078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2F225350008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,281EDE09078
       call      qword ptr [7FFE28A05B30]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CEECE8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CEECE8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CEECE8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CEECE8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CEECE8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,281EDE00008
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
       call      qword ptr [7FFE28CB5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28774C60]
       mov       ecx,946
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28585108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28774A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,281EDE09078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,281EDE00008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,280D65A9078
       call      qword ptr [7FFE28A05C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CE79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CE79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CE79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,280D65A0008
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
       call      qword ptr [7FFE28CB5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28774C60]
       mov       ecx,946
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28585108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286F8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28774A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28486670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,280D65A9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287AF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282AD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,280D65A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,1F993349078
       call      qword ptr [7FFE28A15C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE28517A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CF79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CF79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CF79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1F993340008
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
       call      qword ptr [7FFE28CC5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28784C60]
       mov       ecx,946
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28595108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE28708C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE28206B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28784A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28496670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,1F993349078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 762
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
       call      qword ptr [7FFE282B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE280B4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE287BF5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE282BD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F993340008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,1CC46A39078
       call      qword ptr [7FFE289F5C38]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       je        near ptr M01_L21
M01_L03:
       xor       r15d,r15d
       test      edi,edi
       jle       short M01_L07
M01_L04:
       mov       ecx,r15d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L05
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE28CD79D8]
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
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE28CD79D8]
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1CC46A30008
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
       call      qword ptr [7FFE28CA5950]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE28764C60]
       mov       ecx,946
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FFE28575108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE286E8C20
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE281E6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE28764A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE28476670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L21:
       mov       rdi,rbx
       jmp       near ptr M01_L15
M01_L22:
       mov       rbx,1CC46A39078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 760
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
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE2879F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE2829D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1CC46A30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CB4480]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,1CD1B40DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289DD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r15
       mov       [rbp-38],rdx
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,esi
       call      qword ptr [7FFE284FC150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       r8d,[rdx+8]
       mov       r8,20DAD3875AC
       mov       eax,[rcx+18]
       lea       r10d,[rax+3]
       cmp       [rdx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       rdx,[rdx+r10*2+10]
       mov       r9d,[r8]
       mov       r10d,[r8+2]
       mov       [rdx],r9d
       mov       [rdx+2],r10d
       add       eax,3
       mov       [rcx+18],eax
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       near ptr M01_L12
M01_L06:
       mov       r8d,r14d
       movzx     r8d,byte ptr [rdi+r8+10]
       mov       rdx,1CD1B400428
       mov       rdx,[rdx]
       mov       ecx,r8d
       mov       r8,rdx
       mov       rdx,20DAD3875C0
       call      qword ptr [7FFE28434810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rbp-38]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       ebx,[r10+r8]
       cmp       ebx,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rdx,r8
       mov       r8d,3
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rcx,[rbp-38]
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       r15d,r14d
       jg        near ptr M01_L06
       mov       rcx,[rbp-38]
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-38]
       mov       [rcx+18],ebx
       jmp       short M01_L09
M01_L12:
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       ja        short M01_L14
       mov       edx,27
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],27
       inc       dword ptr [rcx+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28CE6FE8]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28CE6FE8]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,20DAD370008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289DD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CB6A48]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CB6A48]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,1CD1B40DA38
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rbx+8]
       cmp       edx,[rax+0C]
       jg        short M01_L37
       xor       edx,edx
       call      qword ptr [7FFE284FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-38]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE289DD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1203
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CA4480]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,2111580DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r15
       mov       [rbp-38],rdx
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,esi
       call      qword ptr [7FFE284EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-38]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       r8,251A75675AC
       mov       eax,[rdx+18]
       lea       r10d,[rax+3]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[r8]
       mov       r10d,[r8+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [rdx+18],eax
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx+10]
       mov       r8,21115800428
       mov       r8,[r8]
       mov       rdx,251A75675C0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rbp-38]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       ebx,[r10+r8]
       cmp       ebx,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rdx,[rbp-38]
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       r15d,r14d
       jg        near ptr M01_L06
       mov       rdx,[rbp-38]
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-38]
       mov       [rcx+18],ebx
       jmp       short M01_L09
M01_L12:
       mov       ecx,[rdx+18]
       mov       rax,[rdx+8]
       cmp       [rax+8],ecx
       ja        short M01_L14
       mov       rcx,rdx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],27
       inc       dword ptr [rdx+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28CDDFC8]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28CDDFC8]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,251A7550008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289CD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CA6A48]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CA6A48]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,2111580DA38
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rbx+8]
       cmp       edx,[rax+0C]
       jg        short M01_L37
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-38]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1202
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CA4000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,190E4C0DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r15
       mov       [rbp-38],rdx
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,esi
       call      qword ptr [7FFE284EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-38]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       r8,1D176A575AC
       mov       eax,[rdx+18]
       lea       r10d,[rax+3]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[r8]
       mov       r10d,[r8+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [rdx+18],eax
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx+10]
       mov       r8,190E4C00428
       mov       r8,[r8]
       mov       rdx,1D176A575C0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rbp-38]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       ebx,[r10+r8]
       cmp       ebx,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rdx,[rbp-38]
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       r15d,r14d
       jg        near ptr M01_L06
       mov       rdx,[rbp-38]
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-38]
       mov       [rcx+18],ebx
       jmp       short M01_L09
M01_L12:
       mov       ecx,[rdx+18]
       mov       rax,[rdx+8]
       cmp       [rax+8],ecx
       ja        short M01_L14
       mov       rcx,rdx
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],27
       inc       dword ptr [rdx+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28CDDFB0]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28CDDFB0]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,1D176A40008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289CD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CA68F8]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CA68F8]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,190E4C0DA38
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rbx+8]
       cmp       edx,[rax+0C]
       jg        short M01_L37
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-38]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1202
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28C7ED18]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,22DBD00DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CC8D0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-38],r15
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FFE284EC150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[r15+8]
       mov       edx,[rcx+8]
       mov       rdx,26E4F1475AC
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx+10]
       mov       r8,22DBD000428
       mov       r8,[r8]
       mov       rdx,26E4F1475C0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       ebx,r14d
       jg        near ptr M01_L06
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [r15+18],esi
       jmp       short M01_L09
M01_L12:
       mov       ecx,[r15+18]
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       ja        short M01_L14
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [r15+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28CDC750]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28CDC750]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,26E4F130008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289CC3F0]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CA52F0]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CA52F0]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,22DBD00DA38
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CC3A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1174
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CD51E8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,24A4240DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289FD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2851C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-38],r15
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FFE2851C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[r15+8]
       mov       edx,[rcx+8]
       mov       rdx,28AD01D75CC
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx+10]
       mov       r8,24A42400428
       mov       r8,[r8]
       mov       rdx,28AD01D75E0
       call      qword ptr [7FFE28454810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       ebx,r14d
       jg        near ptr M01_L06
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [r15+18],esi
       jmp       short M01_L09
M01_L12:
       mov       ecx,[r15+18]
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       ja        short M01_L14
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [r15+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28D07348]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28D07348]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE282173F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,28AD01C0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289FD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CD7AE0]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CD7AE0]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,24A4240DA38
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2851C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE289FD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1174
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CB51E8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,1F89A40BA40
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-30]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289DD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r15
       mov       [rbp-38],rdx
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,esi
       call      qword ptr [7FFE284FC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-38]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       r8,2392C2475CC
       mov       eax,[rdx+18]
       lea       r10d,[rax+3]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[r8]
       mov       r10d,[r8+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       eax,3
       mov       [rdx+18],eax
M01_L05:
       mov       rdi,[rbx]
       xor       r14d,r14d
       mov       r15d,[rdi+8]
       test      r15d,r15d
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r14d
       movzx     ecx,byte ptr [rdi+rcx+10]
       mov       r8,1F89E400428
       mov       r8,[r8]
       mov       rdx,2392C2475E0
       call      qword ptr [7FFE28434810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rbp-38]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       ebx,[r10+r8]
       cmp       ebx,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8d,3
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rdx,[rbp-38]
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE284FCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r14d
       cmp       r15d,r14d
       jg        near ptr M01_L06
       mov       rdx,[rbp-38]
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE282A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-38]
       mov       [rcx+18],ebx
       jmp       short M01_L09
M01_L12:
       mov       ecx,[rdx+18]
       mov       rax,[rdx+8]
       cmp       [rax+8],ecx
       ja        short M01_L14
       mov       rcx,rdx
       mov       edx,27
       call      qword ptr [7FFE284FC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE28507A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],27
       inc       dword ptr [rdx+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE28CE7348]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE28CE7348]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE281F73F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,2392C230008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE289DD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CB7AE0]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE280A4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CB7AE0]
       int       3
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L32:
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
       mov       rcx,1F89A40BA40
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rbx+8]
       cmp       edx,[rax+0C]
       jg        short M01_L37
       xor       edx,edx
       call      qword ptr [7FFE284FC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-38]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L35
       lea       rcx,[rsi+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L36
       mov       rcx,[rsi+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE289DD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L37:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1202
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CD58F0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,1E233C0DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-40],rdx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289FD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2851C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-48],r15
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,r15
       mov       edx,esi
       call      qword ptr [7FFE2851C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[r15+8]
       mov       r8d,[rcx+8]
       mov       rdx,222C5B375CC
       mov       r8d,[r15+18]
       lea       eax,[r8+3]
       cmp       [rcx+8],eax
       jb        near ptr M01_L07
       movsxd    rax,r8d
       lea       rcx,[rcx+rax*2+10]
       mov       eax,[rdx]
       mov       r10d,[rdx+2]
       mov       [rcx],eax
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [r15+18],r8d
M01_L05:
       mov       r13,[rbx]
       xor       r12d,r12d
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,r12d
       movzx     ecx,byte ptr [r13+rcx+10]
       mov       r8,1E233C00428
       mov       r8,[r8]
       mov       rdx,222C5B375E0
       call      qword ptr [7FFE28454810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       edi,[rax+r8]
       cmp       edi,[rcx+8]
       ja        short M01_L08
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,r15
       mov       r8d,3
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFE2851CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE282173F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE282C5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [r15+18],edi
M01_L12:
       inc       r12d
       cmp       esi,r12d
       jg        near ptr M01_L06
M01_L13:
       mov       ecx,[r15+18]
       mov       rdx,[r15+8]
       cmp       [rdx+8],ecx
       ja        short M01_L15
       mov       rcx,r15
       mov       edx,27
       call      qword ptr [7FFE2851C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFE28527A60]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L19
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L09
       jmp       short M01_L17
M01_L15:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [r15+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE28D079D8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE28D079D8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,rdi
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,222C5B20008
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
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFE289FD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CD7EB8]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-40]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE280C4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CD7EB8]
       int       3
M01_L31:
       mov       rax,[rbp-50]
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
M01_L32:
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
       mov       rcx,1E233C0DA38
       mov       r14,[rcx]
       mov       rbx,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE2851C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [r14+20],0
       jne       short M01_L35
       lea       rcx,[r14+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L36
       mov       rcx,[r14+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE289FD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L37:
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+278]
       call      qword ptr [7FFE28CA58F0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rbx,rcx
       cmp       qword ptr [rbx],0
       je        near ptr M01_L22
       mov       rdx,2070200DA38
       mov       rsi,[rdx]
       mov       rdx,[rsi+20]
       mov       [rbp-40],rdx
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L23
M01_L00:
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       lea       rdx,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       near ptr M01_L25
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L24
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L01:
       mov       r14,[rsi+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L28
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jl        near ptr M01_L26
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L27
       mov       edx,r14d
       mov       rcx,offset MT_System.Char[]
       mov       r8d,10
       call      System.GC.AllocateNewArray(IntPtr, Int32, GC_ALLOC_FLAGS)
M01_L02:
       lea       rcx,[r15+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       rcx,[rbx]
       imul      esi,[rcx+8],2
       jo        near ptr M01_L21
       add       esi,3
       jo        near ptr M01_L21
       test      esi,esi
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,esi
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,esi
       call      qword ptr [7FFE284EC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-48]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       rax,24793DD75CC
       mov       r8d,[rdx+18]
       lea       r10d,[r8+3]
       cmp       [rcx+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,r8d
       lea       rcx,[rcx+r10*2+10]
       mov       r9d,[rax]
       mov       r10d,[rax+2]
       mov       [rcx],r9d
       mov       [rcx+2],r10d
       add       r8d,3
       mov       [rdx+18],r8d
M01_L05:
       mov       r13,[rbx]
       xor       r12d,r12d
       mov       esi,[r13+8]
       test      esi,esi
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,r12d
       movzx     ecx,byte ptr [r13+rcx+10]
       mov       r8,20702000428
       mov       r8,[r8]
       mov       rdx,24793DD75E0
       call      qword ptr [7FFE28424810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L12
       mov       rcx,[rbp-48]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       edi,[r10+r8]
       cmp       edi,[rax+8]
       ja        short M01_L08
       movsxd    r10,r10d
       lea       rax,[rax+r10*2+10]
       cmp       r8d,2
       jg        short M01_L10
       movzx     r10d,word ptr [rdx]
       mov       [rax],r10w
       cmp       r8d,2
       jne       short M01_L11
       movzx     r8d,word ptr [rdx+2]
       mov       [rax+2],r8w
       jmp       short M01_L11
M01_L07:
       mov       rcx,rdx
       mov       rdx,rax
       mov       r8d,3
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE284ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE281E73F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE28295B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-48]
       mov       [rcx+18],edi
M01_L12:
       inc       r12d
       cmp       esi,r12d
       jg        near ptr M01_L06
M01_L13:
       mov       rcx,[rbp-48]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       ja        short M01_L15
       mov       edx,27
       call      qword ptr [7FFE284EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE284F7A60]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L19
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L17
M01_L15:
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],27
       inc       dword ptr [rcx+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFE65112E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE28CD79D8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,rdi
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,24793DC0008
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
M01_L23:
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       je        short M01_L29
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [7FFE289CD4B8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE28CA7EB8]
       int       3
M01_L27:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
       mov       r15,[rbp-40]
       jmp       near ptr M01_L03
M01_L30:
       mov       ecx,13C20
       mov       rdx,7FFE28094000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFE28CA7EB8]
       int       3
M01_L31:
       mov       rax,[rbp-50]
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
M01_L32:
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
       mov       rcx,2070200DA38
       mov       r14,[rcx]
       mov       r15,[r14+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L33
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[r15+8]
       cmp       edx,[rax+0C]
       jg        short M01_L37
       xor       edx,edx
       call      qword ptr [7FFE284EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-48]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M01_L37
M01_L34:
       cmp       qword ptr [r14+20],0
       jne       short M01_L35
       lea       rcx,[r14+20]
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L35:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L36
       mov       rcx,[r14+18]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE289CD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       r14,2C
       lock dec  dword ptr [r14]
M01_L37:
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
; Total bytes of code 1256
```

