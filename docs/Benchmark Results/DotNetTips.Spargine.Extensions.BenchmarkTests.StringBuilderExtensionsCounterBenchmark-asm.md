## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C6BD1E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,3292233D9EC
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
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,2E894400428
       mov       r8,[r8]
       mov       rdx,3292233DA00
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       inc       edi
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
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 478
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,32922320008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C6A6418]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,25D08A4DA14
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
       mov       r8,21C76C00428
       mov       r8,[r8]
       mov       rdx,25D08A4DA28
       call      qword ptr [7FFE8BEB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8C27DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C14F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C14F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25D08A30008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C61C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,2712FC6DA34
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
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,230A1C00428
       mov       r8,[r8]
       mov       rdx,2712FC6DA48
       call      qword ptr [7FFE8BEA4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       inc       edi
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
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 478
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2712FC50008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C64C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,202DD4CDA34
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
       mov       r8,1C24F400428
       mov       r8,[r8]
       mov       rdx,202DD4CDA48
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,202DD4B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C64C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,2B468DBDA34
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
       mov       r8,273DB000428
       mov       r8,[r8]
       mov       rdx,2B468DBDA48
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B468DA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C637E28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,21F001FDA34
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
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,1DE6E400428
       mov       r8,[r8]
       mov       rdx,21F001FDA48
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       inc       edi
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
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 478
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21F001E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C63C1B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       je        near ptr M01_L10
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,27B4F23DA34
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
       movzx     ecx,byte ptr [rsi+rcx+10]
       mov       r8,23ABD400428
       mov       r8,[r8]
       mov       rdx,27B4F23DA48
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       inc       edi
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
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L10:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L11:
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 478
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27B4F220008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C6BFE28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,188A1ABDA34
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
       mov       r8,14813C00428
       mov       r8,[r8]
       mov       rdx,188A1ABDA48
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,188A1AA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C73E430]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C73E430]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C647060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C29DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C29DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2DCC88F9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BCA73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jbe       short M01_L03
       cmp       r8,40
       ja        short M01_L07
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
       jne       short M01_L05
       test      r8b,4
       jne       short M01_L06
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
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
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L06:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       eax,[rax-4]
       mov       [r10-4],eax
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
       jmp       qword ptr [7FFE8BD55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE8BF9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,18605
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE8C24EFB8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEFE9B8]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2DCC88F0008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C71E1C0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C71E1C0]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6A6940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,3073FA59CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 730
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
       ja        short M01_L06
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
       jne       near ptr M01_L08
       test      r8b,4
       je        short M01_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
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
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L02
M01_L06:
       cmp       r8,800
       ja        short M01_L10
       mov       r9,r8
       shr       r9,6
M01_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L07
       and       r8,3F
       cmp       r8,10
       jbe       near ptr M01_L01
       jmp       near ptr M01_L00
M01_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 266
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,3073FA50008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C72C0F0]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6B6940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C28DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C28DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2417D919CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 730
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
       jne       short M01_L07
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
       jmp       short M01_L08
M01_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L02
M01_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
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
       jmp       qword ptr [7FFE8BD45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEEE9B8]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2417D910008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C74C678]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C74C678]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFB5FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C65C120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C2ADEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C2ADC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21839009CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BCB73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jbe       short M01_L05
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M01_L08
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
       je        short M01_L07
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L02
M01_L07:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M01_L02
M01_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFE8BD65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 268
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BFACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BF0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BF0E9B8]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,21839000008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C70CEA0]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C70CEA0]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C69F060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C26DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C26DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BE3EBE9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BC773F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 732
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
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
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
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       qword ptr [7FFE8BD25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE8BF6CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,18605
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE8C21EFB8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BECE9B8]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2BE3EBE0008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C73C798]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C73C798]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C64C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C29DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C29DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A2DFD19CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BCA73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 730
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
       ja        near ptr M01_L08
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
       jne       short M01_L07
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
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M01_L02
M01_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       jmp       qword ptr [7FFE8BD55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 268
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF9CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEFE9B8]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,2A2DFD10008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C71C798]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C71C798]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C627F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26CA1EE9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 734
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
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
       ja        near ptr M01_L11
M01_L01:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M01_L02:
       pop       rbx
       pop       rsi
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L10
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
       jne       short M01_L06
       test      r8b,4
       je        short M01_L07
       jmp       short M01_L08
M01_L06:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rbx-8]
       mov       [rsi-8],rcx
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
       jmp       short M01_L02
M01_L08:
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L10:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,26CA1EE0008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C71C678]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L24
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C71C678]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L11
M00_L09:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       je        near ptr M00_L21
       jmp       short M00_L08
M00_L10:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L22
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L16
M00_L14:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       je        near ptr M00_L23
       jmp       short M00_L13
M00_L15:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C627F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29C2A1B9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L08
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L23:
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L13
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 734
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
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,29C2A1B0008
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
       call      qword ptr [7FFEEA8B95A0]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFEEA8A2D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C74E1C0]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C74E1C0]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,23D494052C8
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
       call      qword ptr [7FFE8C1ECB28]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BFAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,27DDB209084
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
       call      qword ptr [7FFE8BFB5FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6DD4A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE8C2ADEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE8C2ADC20]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27DDB209CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BF0ED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BCB73F0]
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
       call      qword ptr [7FFE8BFAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BFAC3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BFAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
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
       jmp       qword ptr [7FFE8BD65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BFACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BF0E9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BF0E9B8]
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
       call      qword ptr [7FFE8C01DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C680168]
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
       call      qword ptr [7FFE8BFACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C06DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7DDFF8]
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
       call      qword ptr [7FFE8C0E7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7DF1C8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7DFA38]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C8143A8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C0B7288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C6DFD38]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C6DFD38]
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF366E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,27DDB200008
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
       call      qword ptr [7FFE8BFACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       jae       short M00_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFE8C71E1C0]
       test      eax,eax
       jne       near ptr M00_L27
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFE8C71E1C0]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1FB0BC0DE70
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
       call      qword ptr [7FFE8C1BC780]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,23B9DD59084
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
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C6A6940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23B9DD59CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BEDED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
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
       ja        short M01_L04
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
       test      r8b,18
       je        short M01_L06
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M01_L02
M01_L04:
       cmp       r8,800
       ja        near ptr M01_L10
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        short M01_L00
       jmp       short M01_L01
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
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BF97C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C66D8E8]
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
       call      qword ptr [7FFE8BF7CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C03D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7ADFF8]
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
       call      qword ptr [7FFE8C0B7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7AF1C8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7AFA38]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7E43A8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C086C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C6AF7B0]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C6AF7B0]
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,23B9DD50008
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
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L21
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
       je        near ptr M00_L25
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFE8C72EA60]
       test      eax,eax
       jne       near ptr M00_L29
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFE8C72EA60]
       test      eax,eax
       jne       near ptr M00_L29
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M00_L13
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L13
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
       mov       edx,22
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,2157CB79084
       mov       r13,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+2]
       cmp       [r13+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L14:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L23
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       xor       r13d,r13d
M00_L16:
       mov       rcx,1D4EAC0DE70
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L27
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
       call      qword ptr [7FFE8C1CCB28]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L30
       mov       r12d,eax
M00_L17:
       test      r12d,r12d
       jge       near ptr M00_L24
       sub       r15d,r13d
       jo        near ptr M00_L28
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BF8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L10
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M00_L11
M00_L18:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L19:
       movsxd    rcx,r12d
       lea       rcx,[r13+rcx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r12d,2
       mov       [rsi+18],r12d
M00_L20:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L21:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C63C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L22:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BF8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF8C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FFE8C28DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FFE8C28DC20]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2157CB79CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BEEED18]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L30:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1053
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
       jmp       qword ptr [7FFE8BD45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
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
       call      qword ptr [7FFE8BF8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M02_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE8BEEE9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE8BFFDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFE8C69E118]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
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
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE8BF8CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFE8C04DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFE8C7BE790]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE8C0C7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7BF960]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7F41E0]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7F4B40]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C097288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
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
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
M05_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C6E5278]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C6E5278]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2157CB70008
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
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
       xor       ebp,ebp
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L21
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
       je        near ptr M00_L25
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C70C678]
       test      eax,eax
       jne       near ptr M00_L29
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C70C678]
       test      eax,eax
       jne       near ptr M00_L29
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M00_L13
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L13
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
       mov       edx,22
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,1EAADD69084
       mov       r14,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r13+2]
       cmp       [r14+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L18
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L14:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L23
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L15:
       xor       r13d,r13d
M00_L16:
       mov       rcx,1AA1C00DE70
       mov       rcx,[rcx]
       mov       edx,r15d
       sub       edx,r13d
       cmp       r15d,r13d
       jb        near ptr M00_L27
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
       call      qword ptr [7FFE8C1AC780]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L30
       mov       r12d,eax
M00_L17:
       test      r12d,r12d
       jge       near ptr M00_L24
       sub       r15d,r13d
       jo        near ptr M00_L28
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BF6C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L10
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M00_L11
M00_L18:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L19:
       movsxd    rcx,r13d
       lea       rcx,[r14+rcx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r13d,2
       mov       [rsi+18],r13d
M00_L20:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L21:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C61C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L22:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BF6C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF6C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF6C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FFE8C26DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FFE8C26DC20]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EAADD69CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BECED18]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC773F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L30:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1056
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
       jmp       qword ptr [7FFE8BD25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 270
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
       call      qword ptr [7FFE8BF6CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M02_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       jg        near ptr M03_L03
       cmp       r8d,edi
       jl        near ptr M03_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M03_L01
       test      r8,r8
       je        near ptr M03_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M03_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M03_L00:
       cmp       ebp,r10d
       ja        near ptr M03_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF6CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FFE8BECE9B8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M04_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M04_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M04_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M04_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FFE8BF87C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M04_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M04_L02:
       cmp       ebx,5
       ja        near ptr M04_L08
       mov       edx,ebx
       lea       r8,[7FFE8C67DEE8]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M04_L00]
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
       jae       short M04_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FFE8BF6CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FFE8C02D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FFE8C79E7D8]
       jmp       short M04_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M04_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FFE8C0A7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C79F9A8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7D4228]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7D4B88]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C076C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M04_L01
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
       jl        near ptr M05_L04
       test      ebx,ebx
       jl        near ptr M05_L05
       test      rdx,rdx
       je        near ptr M05_L06
       test      ebx,ebx
       je        short M05_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M05_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M05_L02
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L03
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L00:
       mov       [rsi+18],edi
M05_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L03:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L04:
       mov       ecx,172D
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C6C5278]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C6C5278]
       int       3
M05_L06:
       or        ebx,edi
       jne       short M05_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L07:
       mov       ecx,2E5
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BEF66E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1EAADD60008
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
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       je        near ptr M00_L23
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FFE8C74C960]
       test      eax,eax
       jne       near ptr M00_L27
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FFE8C74C960]
       test      eax,eax
       jne       near ptr M00_L27
M00_L06:
       mov       r8,r14
M00_L07:
       test      r8,r8
       je        near ptr M00_L18
       lea       rdx,[r8+0C]
       mov       r13d,[r8+8]
       test      r13d,r13d
       je        near ptr M00_L18
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L17
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L09
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       near ptr M00_L18
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
       mov       edx,22
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       xor       r13d,r13d
M00_L12:
       mov       rcx,1D06FC0DE70
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
       call      qword ptr [7FFE8C1EC780]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jge       near ptr M00_L28
       mov       r12d,eax
M00_L13:
       test      r12d,r12d
       jge       near ptr M00_L29
       sub       r15d,r13d
       jo        near ptr M00_L26
       mov       r9d,r15d
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BFAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L14:
       mov       rdx,21101C89084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M00_L20
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],2C
       mov       word ptr [rcx+2],20
       add       r8d,2
       mov       [rsi+18],r8d
M00_L15:
       inc       ebp
       cmp       [rdi+8],ebp
       jg        near ptr M00_L00
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFB5FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C657F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       r8d,r13d
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L18:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       short M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],3D
       inc       ecx
       mov       [rsi+18],ecx
M00_L19:
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L10
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
       jmp       near ptr M00_L11
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L15
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L19
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L23:
       call      qword ptr [7FFE8C2ADEC0]
       mov       r13,rax
       test      r13,r13
       jne       short M00_L24
       call      qword ptr [7FFE8C2ADC20]
       mov       r13,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,21101C89CB0
       mov       r8,r13
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BF0ED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BCB73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L28:
       lea       r12d,[rax+r13]
       jmp       near ptr M00_L13
M00_L29:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        short M00_L26
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FFE8BFAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BFAC3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BFAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L12
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1041
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
       jmp       qword ptr [7FFE8BD65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 272
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
       call      qword ptr [7FFE8BFACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M02_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 55
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
       call      qword ptr [7FFE8BFC7C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C6BDF88]
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
       call      qword ptr [7FFE8BFACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C06D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7DECD0]
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
       call      qword ptr [7FFE8C0E7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7DFEA0]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C814720]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C815080]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C0B6C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C714F30]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C714F30]
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF366E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,21101C80008
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
       jg        near ptr M07_L03
       cmp       r8d,edi
       jl        near ptr M07_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M07_L01
       test      r8,r8
       je        near ptr M07_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M07_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M07_L00:
       cmp       ebp,r10d
       ja        near ptr M07_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M07_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BFACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M07_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M07_L07
M07_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,18605
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L04:
       test      eax,eax
       jne       short M07_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M07_L00
M07_L05:
       call      qword ptr [7FFE8BF0E9A0]
       int       3
M07_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M07_L02
M07_L07:
       call      qword ptr [7FFE8BF0E9B8]
       int       3
; Total bytes of code 315
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
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C72C798]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C72C798]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,241A2C032D0
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
       call      qword ptr [7FFE8C1CCB28]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BF8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,28234AA9084
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
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C63C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE8C28DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE8C28DC20]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28234AA9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BEEED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
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
       call      qword ptr [7FFE8BF8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF8C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
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
       je        short M01_L08
       jmp       short M01_L09
M01_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L01
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
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
M01_L11:
       jmp       qword ptr [7FFE8BD45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEEE9B8]
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
       call      qword ptr [7FFE8BFFDAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C69DDB8]
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
       call      qword ptr [7FFE8BF8CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C04DF68]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7BED18]
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
       call      qword ptr [7FFE8C0C7A80]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7BFEE8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7F47B0]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7F5110]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C097288]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L04:
       mov       ecx,172D
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C6E5278]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFE8C6E5278]
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,28234AA0008
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
       call      qword ptr [7FFE8BF8CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C71C798]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C71C798]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,26FDA00DE70
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
       call      qword ptr [7FFE8C1BC780]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,2B06BEE9084
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
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C62C2B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2B06BEE9CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BEDED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
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
       ja        near ptr M01_L08
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
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rbx-4]
       mov       [rsi-4],ecx
       jmp       near ptr M01_L02
M01_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L09:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       cmp       rcx,rdx
       je        near ptr M01_L02
       jmp       short M01_L09
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BF9E628]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C68AB48]
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
       call      qword ptr [7FFE8BF7CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C03D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7AED18]
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
       call      qword ptr [7FFE8C0B7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7AFEE8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7E47B0]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7E5110]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C086C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       mov       rdx,2B06BEE4388
       call      qword ptr [7FFE8C03FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,2B06BEE4368
       call      qword ptr [7FFE8C03FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2B06BEE0008
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
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+198]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FFE8C71C678]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FFE8C71C678]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,13A2DC0DE70
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
       call      qword ptr [7FFE8C1BC780]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,17ABFD79084
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
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C62C120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FFE8C27DEC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FFE8C27DC20]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,17ABFD79CB0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FFE8BEDED18]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
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
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF7C3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1026
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L07
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L07
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
       ja        short M01_L08
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
       je        short M01_L09
       mov       eax,[rdx]
       mov       [rcx],eax
       mov       eax,[rbx-4]
       mov       [rsi-4],eax
       jmp       short M01_L02
M01_L07:
       cmp       rcx,rdx
       je        short M01_L02
M01_L08:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L09:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     r8,word ptr [rbx-2]
       mov       [rsi-2],r8w
       jmp       near ptr M01_L02
M01_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
; Total bytes of code 268
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EFB8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FFE8BEDE9B8]
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
       call      qword ptr [7FFE8BF97C78]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FFE8C68ABC8]
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
       call      qword ptr [7FFE8BF7CBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE8C03D980]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FFE8C7AE790]
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
       call      qword ptr [7FFE8C0B7288]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FFE8C7AF960]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7E41E0]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FFE8C7E4B40]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FFE8C086C70]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M03_L01
; Total bytes of code 424
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
       mov       rdx,17ABFD74388
       call      qword ptr [7FFE8C03FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,ebx
       mov       rdx,17ABFD74368
       call      qword ptr [7FFE8C03FA98]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,185D5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,17ABFD70008
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
       call      qword ptr [7FFE8BF7CB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2B1F5159078
       call      qword ptr [7FFE8C6B6880]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72E1C0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72E1C0]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2B1F5150008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6B2940
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6B6970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,2B1F5159078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B1F5150008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2065D3B9078
       call      qword ptr [7FFE8C6C6880]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C73E1C0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C73E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C73E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C73E1C0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C73E1C0]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2065D3B0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6C2940
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6C6970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
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
       mov       rbx,2065D3B9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 764
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2065D3B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,25572AC9078
       call      qword ptr [7FFE8C6B6880]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72C0F0]
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
       jae       short M01_L08
       mov       rax,7FFEE9E52C20
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L08:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       je        short M01_L14
M01_L10:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L07
       jmp       short M01_L14
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72C0F0]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       r13,25572AC0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6B2940
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r15
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6B6970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,25572AC9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 768
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25572AC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,22C627E9078
       call      qword ptr [7FFE8C61C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C70C798]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C70C798]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C70C798]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L13
M01_L10:
       call      qword ptr [7FFE8C70C798]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L09
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C70C798]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L12
M01_L17:
       mov       r13,22C627E0008
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
       call      qword ptr [7FFE8C61C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE8BEF6670]
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
       mov       rbx,22C627E9078
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22C627E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,288762F9078
       call      qword ptr [7FFE8C63C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72CA20]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72CA20]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72CA20]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72CA20]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72CA20]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,288762F0008
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
       call      qword ptr [7FFE8C63C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,288762F9078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,288762F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,25892199078
       call      qword ptr [7FFE8C65C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BFB5FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C74C960]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C74C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C74C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C74C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C74C960]
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,25892190008
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
       call      qword ptr [7FFE8C65C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C2ADE30]
       mov       ecx,98C
       mov       rdx,7FFE8C17F610
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C17F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2ADC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
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
       mov       rbx,25892199078
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C25EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25892190008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,28AE71B9078
       call      qword ptr [7FFE8C63C060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72CEA0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72CEA0]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,28AE71B0008
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
       call      qword ptr [7FFE8C63C150]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,28AE71B9078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,28AE71B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2769E9F9078
       call      qword ptr [7FFE8C6BCE10]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72C678]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72C678]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72C678]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72C678]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72C678]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2769E9F0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6B8ED0
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6BCF00]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,2769E9F9078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2769E9F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2D6FBB79078
       call      qword ptr [7FFE8C6A6448]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C71D9E0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C71D9E0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C71D9E0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C71D9E0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C71D9E0]
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2D6FBB70008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6A2520
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6A6550]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C27DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C14F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C14F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       mov       rbx,2D6FBB79078
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C22EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD3D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D6FBB70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,1E1F0DF9078
       call      qword ptr [7FFE8C64C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C73EFA0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C73EFA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C73EFA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L13
M01_L10:
       call      qword ptr [7FFE8C73EFA0]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L09
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L17
       mov       rax,7FFEE9E52C20
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
       jmp       near ptr M01_L22
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
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
       call      qword ptr [7FFE8C64C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C73EFA0]
       test      eax,eax
       je        near ptr M01_L13
       jmp       near ptr M01_L12
M01_L18:
       mov       r13,1E1F0DF0008
       jmp       near ptr M01_L14
M01_L19:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F610
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE8BF26670]
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
       mov       rbx,1E1F0DF9078
       jmp       near ptr M01_L16
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 784
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E1F0DF0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,22430E49078
       call      qword ptr [7FFE8C6B66B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72C0F0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72C0F0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L13
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L13
M01_L10:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L09
M01_L11:
       cmp       r14d,edi
       jae       near ptr M01_L23
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C72C0F0]
       test      eax,eax
       je        short M01_L13
       jmp       short M01_L12
M01_L17:
       mov       r13,22430E40008
       jmp       short M01_L14
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r15,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6B2790
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r15
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6B67C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,22430E49078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 764
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22430E40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,31A420C9078
       call      qword ptr [7FFE8C6C6868]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C73C0F0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C73C0F0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C73C0F0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C73C0F0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C73C0F0]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,31A420C0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6C2940
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6C6970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F610
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
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
       mov       rbx,31A420C9078
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,31A420C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,264B14B9078
       call      qword ptr [7FFE8C6BD800]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72C798]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72C798]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72C798]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72C798]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72C798]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,264B14B0008
       jmp       short M01_L15
M01_L18:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6B98D8
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6BD908]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,264B14B9078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,264B14B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2DC434E9078
       call      qword ptr [7FFE8C63C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C72CEA0]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C72CEA0]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C72CEA0]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2DC434E0008
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
       call      qword ptr [7FFE8C63C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C28DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C15F610
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
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
       mov       rbx,2DC434E9078
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C23EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2DC434E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2123B2E9078
       call      qword ptr [7FFE8C61C1E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C70C960]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C70C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C70C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C70C960]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C70C960]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2123B2E0008
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
       call      qword ptr [7FFE8C61C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FFE8C26DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C13F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
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
       mov       rbx,2123B2E9078
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C21EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2123B2E0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rdx,2212A3F9078
       call      qword ptr [7FFE8C6CF1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C73CF90]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FFE8C73CF90]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FFE8C73CF90]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FFE8C73CF90]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FFE8C73CF90]
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       r14,[rbp+8]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,7FFE8C6CB2D0
       mov       [rdi+18],rdx
       mov       [rsp+20],rdi
       mov       rdx,r14
       mov       r8,rbx
       mov       r9,rsi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE8C6CF300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       mov       rdi,2212A3F0008
       jmp       near ptr M01_L15
M01_L19:
       call      qword ptr [7FFE8C29DE30]
       mov       ecx,98C
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FFE8C16F3E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29DC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
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
       mov       rbx,2212A3F9078
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C24EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2212A3F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C6D6820]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,1B32640D1E0
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
       call      qword ptr [7FFE8C28EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       esi,[rbx+8]
       imul      r13d,esi,2
       jo        near ptr M01_L21
       add       r13d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r13d,r13d
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,r13d
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,r13d
       call      qword ptr [7FFE8BFAC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-48]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       rax,1F3B80DD9F4
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
       xor       r12d,r12d
       test      esi,esi
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,r12d
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,1B326400428
       mov       r8,[r8]
       mov       rdx,1F3B80DDA08
       call      qword ptr [7FFE8BEE4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE8BFACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE8BCB73F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BFAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE8BFB5FA8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L19
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L17
M01_L15:
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],27
       inc       dword ptr [rcx+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C74E1C0]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C74E1C0]
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
       mov       rax,1F3B80C0008
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
       call      qword ptr [7FFE8C28E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C6DF810]
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFE8C6DF810]
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
       mov       rcx,1B32640D1E0
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
       call      qword ptr [7FFE8BFAC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE8C28E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1241
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C637E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,2285E40D1E0
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
       call      qword ptr [7FFE8C26EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,r15
       mov       [rbp-48],rsi
       mov       r13d,[rbx+8]
       imul      r12d,r13d,2
       jo        near ptr M01_L21
       add       r12d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r12d,r12d
       jl        near ptr M01_L30
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       cmp       ecx,r12d
       jge       short M01_L04
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFE8BF8C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rsi+8]
       mov       r8d,[rcx+8]
       mov       rdx,268F041DA14
       mov       r8d,[rsi+18]
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
       mov       [rsi+18],r8d
M01_L05:
       xor       edi,edi
       test      r13d,r13d
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,edi
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,2285E400428
       mov       r8,[r8]
       mov       rdx,268F041DA28
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rsi+18],r14d
M01_L12:
       inc       edi
       cmp       r13d,edi
       jg        near ptr M01_L06
M01_L13:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        short M01_L15
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE8BF8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M01_L19
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L09
       jmp       short M01_L17
M01_L15:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C72E778]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C72E778]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,r14
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,268F0400008
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
       call      qword ptr [7FFE8C26E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C6F4F30]
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
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FFE8C6F4F30]
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
       mov       rcx,2285E40D1E0
       mov       rsi,[rcx]
       mov       r12,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE8BF8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
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
       call      qword ptr [7FFE8C26E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 1215
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C627E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,1E7F380B1E8
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
       call      qword ptr [7FFE8C25EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,r15
       mov       [rbp-48],rdx
       mov       esi,[rbx+8]
       imul      r13d,esi,2
       jo        near ptr M01_L21
       add       r13d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r13d,r13d
       jl        near ptr M01_L30
       mov       rcx,[rdx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdx+1C]
       cmp       ecx,r13d
       jge       short M01_L04
       mov       rcx,rdx
       mov       edx,r13d
       call      qword ptr [7FFE8BF7C150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       rdx,[rbp-48]
M01_L04:
       mov       rcx,[rdx+8]
       mov       r8d,[rcx+8]
       mov       rax,2288555DA14
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
       xor       r12d,r12d
       test      esi,esi
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,r12d
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,1E7F7800428
       mov       r8,[r8]
       mov       rdx,2288555DA28
       call      qword ptr [7FFE8BEB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,[rbp-48]
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L19
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L17
M01_L15:
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],27
       inc       dword ptr [rcx+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C71C960]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C71C960]
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
       mov       rax,22885540008
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
       call      qword ptr [7FFE8C25E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C6E4F30]
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r13d
       call      qword ptr [7FFE8C6E4F30]
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
       mov       rcx,1E7F380B1E8
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
       call      qword ptr [7FFE8BF7C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE8C25E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1241
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C647E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,1B6AF00B1E8
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
       call      qword ptr [7FFE8C27EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,r15
       mov       [rbp-48],rsi
       mov       r13d,[rbx+8]
       imul      r12d,r13d,2
       jo        near ptr M01_L21
       add       r12d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r12d,r12d
       jl        near ptr M01_L30
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       cmp       ecx,r12d
       jge       short M01_L04
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFE8BF9C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rsi+8]
       mov       r8d,[rcx+8]
       mov       rdx,1F740EBDA14
       mov       r8d,[rsi+18]
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
       mov       [rsi+18],r8d
M01_L05:
       xor       edi,edi
       test      r13d,r13d
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,edi
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,1B6B3000428
       mov       r8,[r8]
       mov       rdx,1F740EBDA28
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BCA73F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rsi+18],r14d
M01_L12:
       inc       edi
       cmp       r13d,edi
       jg        near ptr M01_L06
M01_L13:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        short M01_L15
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M01_L19
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L09
       jmp       short M01_L17
M01_L15:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C73C960]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C73C960]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,r14
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,1F740EA0008
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
       call      qword ptr [7FFE8C27E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C704F30]
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FFE8C704F30]
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
       mov       rcx,1B6AF00B1E8
       mov       rsi,[rcx]
       mov       r12,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
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
       call      qword ptr [7FFE8C27E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 1215
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C647C60]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,26DF100B1E8
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
       call      qword ptr [7FFE8C27EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,r15
       mov       [rbp-48],rsi
       mov       r13d,[rbx+8]
       imul      r12d,r13d,2
       jo        near ptr M01_L21
       add       r12d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r12d,r12d
       jl        near ptr M01_L30
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       cmp       ecx,r12d
       jge       short M01_L04
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFE8BF9C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rsi+8]
       mov       r8d,[rcx+8]
       mov       rdx,2AE82D4D9EC
       mov       r8d,[rsi+18]
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
       mov       [rsi+18],r8d
M01_L05:
       xor       edi,edi
       test      r13d,r13d
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,edi
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,26DF5000428
       mov       r8,[r8]
       mov       rdx,2AE82D4DA00
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BCA73F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rsi+18],r14d
M01_L12:
       inc       edi
       cmp       r13d,edi
       jg        near ptr M01_L06
M01_L13:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        short M01_L15
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,rsi
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M01_L19
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L09
       jmp       short M01_L17
M01_L15:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C73C678]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C73C678]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,r14
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,2AE82D30008
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
       call      qword ptr [7FFE8C27E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C704F30]
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
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FFE8C704F30]
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
       mov       rcx,26DF100B1E8
       mov       rsi,[rcx]
       mov       r12,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
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
       call      qword ptr [7FFE8C27E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 1215
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C617E10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rdx,1C84700D1E0
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
       call      qword ptr [7FFE8C24EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rsi,r15
       mov       [rbp-48],rsi
       mov       r13d,[rbx+8]
       imul      r12d,r13d,2
       jo        near ptr M01_L21
       add       r12d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       test      r12d,r12d
       jl        near ptr M01_L30
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       cmp       ecx,r12d
       jge       short M01_L04
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FFE8BF6C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rsi+8]
       mov       r8d,[rcx+8]
       mov       rdx,208D908DA14
       mov       r8d,[rsi+18]
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
       mov       [rsi+18],r8d
M01_L05:
       xor       edi,edi
       test      r13d,r13d
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,edi
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,1C847000428
       mov       r8,[r8]
       mov       rdx,208D908DA28
       call      qword ptr [7FFE8BEA4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L12
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF6CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BC773F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rsi+18],r14d
M01_L12:
       inc       edi
       cmp       r13d,edi
       jg        near ptr M01_L06
M01_L13:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        short M01_L15
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE8BF6C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF75FA8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M01_L19
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L09
       jmp       short M01_L17
M01_L15:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C70C678]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C70C678]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,r14
M01_L20:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L32
       jmp       near ptr M01_L31
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,208D9070008
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
       call      qword ptr [7FFE8C24E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L29
M01_L26:
       mov       ecx,13C20
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFE8C6D4F30]
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FFE8C6D4F30]
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
       mov       rcx,1C84700D1E0
       mov       rsi,[rcx]
       mov       r12,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L33
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE8BF6C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
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
       call      qword ptr [7FFE8C24E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L36:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 1215
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C62C198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L22
       mov       rdx,20237C0D1E0
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
       call      qword ptr [7FFE8C25EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       jne       near ptr M01_L27
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,242C99E9C38
       call      qword ptr [7FFE8C0840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L26
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
       mov       rsi,r15
       mov       [rbp-38],rsi
       mov       edi,[rbx+8]
       imul      r14d,edi,2
       jo        near ptr M01_L21
       add       r14d,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       mov       ecx,r14d
       mov       rdx,242C99E9C38
       call      qword ptr [7FFE8C0840D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       cmp       ecx,r14d
       jge       short M01_L04
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFE8BF7C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rsi+8]
       mov       edx,[rcx+8]
       mov       rdx,242C99FDA14
       mov       r8d,[rsi+18]
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
       mov       [rsi+18],r8d
M01_L05:
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M01_L12
M01_L06:
       mov       ecx,r15d
       movzx     ecx,byte ptr [rbx+rcx+10]
       mov       r8,20237C00428
       mov       r8,[r8]
       mov       rdx,242C99FDA28
       call      qword ptr [7FFE8BEB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L09
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L09
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L09:
       inc       r15d
       cmp       edi,r15d
       jg        near ptr M01_L06
       jmp       short M01_L12
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       [rsi+18],r14d
       jmp       short M01_L09
M01_L12:
       mov       ecx,[rsi+18]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       ja        short M01_L14
       mov       rcx,rsi
       mov       edx,27
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M01_L18
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L16
M01_L14:
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rsi+18]
       jmp       short M01_L13
M01_L15:
       call      qword ptr [7FFE8C71C798]
       test      eax,eax
       jne       short M01_L19
M01_L16:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L19
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE8C71C798]
       test      eax,eax
       jne       short M01_L19
M01_L18:
       mov       rax,rbx
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L30
       jmp       near ptr M01_L29
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,242C99E0008
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
       je        short M01_L28
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE8C25E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L28
M01_L26:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L27:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L28:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L29:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
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
       mov       rcx,20237C0D1E0
       mov       rsi,[rcx]
       mov       rbx,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L31
       mov       rdi,[rbp-38]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rbx+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L35
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE8BF7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L32
M01_L31:
       mov       rdi,[rbp-38]
       mov       rdx,rdi
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L35
M01_L32:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L33
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L35
M01_L33:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L34
       mov       rcx,[rsi+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C25E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L35
M01_L34:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L35:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1115
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+190]
       call      qword ptr [7FFE8C64C198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
       je        near ptr M01_L22
       mov       rdx,2A6EA00D1E0
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
       call      qword ptr [7FFE8C27EAD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       jne       near ptr M01_L27
       mov       rsi,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14d,[rsi+8]
       mov       ecx,r14d
       mov       rdx,2E77BF09C38
       call      qword ptr [7FFE8C0A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       edx,10
       test      r14d,r14d
       cmove     r14d,edx
       mov       dword ptr [r15+20],7FFFFFFF
       cmp       r14d,400
       jl        near ptr M01_L26
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
       mov       [rbp-38],r15
       mov       esi,[rbx+8]
       imul      edi,esi,2
       jo        near ptr M01_L21
       add       edi,3
       jo        near ptr M01_L21
       cmp       [r15],r15b
       mov       ecx,edi
       mov       rdx,2E77BF09C38
       call      qword ptr [7FFE8C0A40D8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       cmp       ecx,edi
       jge       short M01_L04
       mov       rcx,[rbp-38]
       mov       edx,edi
       call      qword ptr [7FFE8BF9C150]; System.Text.StringBuilder.set_Capacity(Int32)
M01_L04:
       mov       rcx,[rbp-38]
       mov       r8,[rcx+8]
       mov       edx,[r8+8]
       mov       rdx,2E77BF1DA14
       mov       eax,[rcx+18]
       lea       r10d,[rax+3]
       cmp       [r8+8],r10d
       jb        near ptr M01_L07
       movsxd    r10,eax
       lea       r8,[r8+r10*2+10]
       mov       r9d,[rdx]
       mov       r10d,[rdx+2]
       mov       [r8],r9d
       mov       [r8+2],r10d
       add       eax,3
       mov       [rcx+18],eax
M01_L05:
       xor       edi,edi
       test      esi,esi
       jle       near ptr M01_L13
M01_L06:
       mov       r8d,edi
       movzx     r8d,byte ptr [rbx+r8+10]
       mov       rdx,2A6EA000428
       mov       rdx,[rdx]
       mov       ecx,r8d
       mov       r8,rdx
       mov       rdx,2E77BF1DA28
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L12
       mov       rcx,[rbp-38]
       mov       rax,[rcx+8]
       mov       r10d,[rcx+18]
       lea       r14d,[r10+r8]
       cmp       r14d,[rax+8]
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
       mov       r8d,3
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L05
M01_L08:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L12
M01_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE8BCA73F0]
       jmp       near ptr M01_L20
M01_L10:
       movsxd    r8,r8d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L11:
       mov       rcx,[rbp-38]
       mov       [rcx+18],r14d
M01_L12:
       inc       edi
       cmp       esi,edi
       jg        near ptr M01_L06
M01_L13:
       mov       rcx,[rbp-38]
       mov       edx,[rcx+18]
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       ja        short M01_L15
       mov       edx,27
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M01_L14:
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        short M01_L19
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L17
M01_L15:
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],27
       inc       dword ptr [rcx+18]
       jmp       short M01_L14
M01_L16:
       call      qword ptr [7FFE8C73CF90]
       test      eax,eax
       jne       near ptr M01_L09
M01_L17:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFE8C73CF90]
       test      eax,eax
       jne       near ptr M01_L09
M01_L19:
       mov       rax,r14
M01_L20:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L30
       jmp       near ptr M01_L29
M01_L21:
       call      CORINFO_HELP_OVERFLOW
M01_L22:
       mov       rax,2E77BF00008
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
       je        short M01_L28
       jmp       near ptr M01_L00
M01_L24:
       lea       rdx,[rbp-30]
       mov       rcx,rdi
       call      qword ptr [7FFE8C27E5F8]
       test      eax,eax
       je        near ptr M01_L01
M01_L25:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L28
M01_L26:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       near ptr M01_L02
M01_L27:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L28:
       mov       r15,[rbp-30]
       jmp       near ptr M01_L03
M01_L29:
       mov       rax,[rbp-40]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
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
       mov       rcx,2A6EA00D1E0
       mov       r15,[rcx]
       mov       rbx,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rbx+18],rcx
       jne       short M01_L31
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       add       edx,[rcx+1C]
       mov       rax,[rbx+8]
       cmp       edx,[rax+0C]
       jg        short M01_L35
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L32
M01_L31:
       mov       rdx,[rbp-38]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       test      eax,eax
       je        short M01_L35
M01_L32:
       cmp       qword ptr [r15+20],0
       jne       short M01_L33
       lea       rcx,[r15+20]
       mov       rdx,[rbp-38]
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L35
M01_L33:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L34
       mov       rcx,[r15+18]
       mov       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C27E5B0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L35
M01_L34:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L35:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1161
```
