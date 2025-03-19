## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F65D70C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,23144967664
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
       mov       r8,1F0B6C00428
       mov       r8,[r8]
       mov       rdx,23144967678
       call      qword ptr [7FF9F5FF4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,23144950008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F65F70C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,2613C057664
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
       mov       r8,220AA000428
       mov       r8,[r8]
       mov       rdx,2613C057678
       call      qword ptr [7FF9F6014810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2613C040008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F65E6FD0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,1A412ED7664
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
       mov       r8,16385000428
       mov       r8,[r8]
       mov       rdx,1A412ED7678
       call      qword ptr [7FF9F6004810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1A412EC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F6605440]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,22314FD7664
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
       mov       r8,1E287000428
       mov       r8,[r8]
       mov       rdx,22314FD7678
       call      qword ptr [7FF9F6014810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F62FF990]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F61659D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F62FF780]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639DEF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22314FC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F65D70C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,2047C4B7684
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
       mov       r8,1C3EA400428
       mov       r8,[r8]
       mov       rdx,2047C4B7698
       call      qword ptr [7FF9F5FF4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2047C4A0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F65E6EE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,22B83287684
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
       mov       r8,1EAF5400428
       mov       r8,[r8]
       mov       rdx,22B83287698
       call      qword ptr [7FF9F6004810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L05:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L06:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22B83270008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F66070C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,22748FD7684
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
       mov       r8,1E6B7000428
       mov       r8,[r8]
       mov       rdx,22748FD7698
       call      qword ptr [7FF9F6024810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L03
M01_L07:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L09:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22748FC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdx,[rbx+280]
       mov       rcx,rsi
       call      qword ptr [7FF9F66070C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
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
       mov       rdx,1F830BA7684
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
       mov       r8,1B7A2C00428
       mov       r8,[r8]
       mov       rdx,1F830BA7698
       call      qword ptr [7FF9F6024810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L01
       jmp       short M01_L07
M01_L05:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rbx
       mov       edx,27
       call      qword ptr [7FF9F60EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F830B90008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F68DDC80]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F68DDC80]
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F68A6AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6364D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6364AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E6837F9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DE73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jmp       qword ptr [7FF9F5E95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF9F60ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FF9F639F6C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF9F604E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF9F604E9E8]
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,1E6837F0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F68BD578]
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F68BD578]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6886AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6354D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6354AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22ADA9E9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       jmp       qword ptr [7FF9F5E85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FF9F638F6C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF9F603E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF9F603E9E8]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L03:
       mov       rax,22ADA9E0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6876AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,263188A9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DB73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F601E9E8]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,263188A0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M00_L18
M00_L00:
       mov       ecx,ebp
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L02
       mov       r13d,[r15+8]
       xor       ecx,ecx
       test      r13d,r13d
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       je        near ptr M00_L19
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L07
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L04
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L05
M00_L02:
       xor       ecx,ecx
       jmp       short M00_L01
M00_L03:
       test      r12,r12
       je        near ptr M00_L12
       jmp       short M00_L08
M00_L04:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L21
M00_L05:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L23
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L06
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L21
       jmp       short M00_L07
M00_L06:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L21
M00_L07:
       mov       r12,r15
       jmp       short M00_L03
M00_L08:
       lea       rdx,[r12+0C]
       mov       r12d,[r12+8]
       test      r12d,r12d
       je        short M00_L12
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L11
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L10
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L12
M00_L10:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M00_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L09
M00_L11:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L12:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jbe       near ptr M00_L22
       mov       ecx,ecx
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L13:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L17
       mov       r8,[rsi+8]
       mov       r12d,[rsi+18]
       lea       ecx,[r12+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L16
       movsxd    rcx,r12d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L15
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L14:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L17
M00_L15:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L14
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L14
M00_L16:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L17:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L18:
       mov       rcx,rsi
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F68A6AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
M00_L19:
       call      qword ptr [7FF9F6364D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L20
       call      qword ptr [7FF9F6364AE0]
       mov       rbx,rax
M00_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F9609D9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L21:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DE73F0]
       mov       r12,rax
       jmp       near ptr M00_L03
M00_L22:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 729
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E95B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60ECB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F604E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F604E9E8]
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,2F9609D0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6887A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6344D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6344AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22FBBDE9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DC73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       jg        near ptr M03_L03
       cmp       r8d,esi
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
       mov       rdx,rdi
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       esi,ebp
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF9F60CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       esi,r14d
       ja        near ptr M03_L07
M03_L02:
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FF9F637F6C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F602E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       esi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F602E9E8]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,22FBBDE0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6877A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22214ED9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DB73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F601E9E8]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,22214ED0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L16:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6897A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F6354D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6354AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1932EC09CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 716
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F603E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F603E9E8]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,1932EC00008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       je        near ptr M00_L18
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        short M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M00_L03
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L04:
       lea       ecx,[r13-1]
       cmp       ecx,r13d
       jae       near ptr M00_L22
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L20
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L20
M00_L06:
       mov       r8,r15
M00_L07:
       test      r8,r8
       je        near ptr M00_L13
       lea       rdx,[r8+0C]
       mov       r12d,[r8+8]
       test      r12d,r12d
       je        short M00_L13
       mov       r8,[rsi+8]
       mov       eax,[rsi+18]
       mov       [rsp+34],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        short M00_L12
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M00_L09
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L08:
       add       r12d,[rsp+34]
       mov       [rsi+18],r12d
       jmp       short M00_L13
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
       mov       r8d,r13d
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L11:
       inc       ebp
       cmp       r14d,ebp
       jg        near ptr M00_L00
       jmp       short M00_L16
M00_L12:
       mov       rcx,rsi
       mov       r8d,r12d
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M00_L13:
       mov       r8d,[rsi+18]
       mov       ecx,r8d
       mov       rdx,[rsi+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M00_L21
       mov       word ptr [rdx+rcx*2+10],3D
       inc       r8d
       mov       [rsi+18],r8d
M00_L14:
       lea       rdx,[r15+0C]
       test      r13d,r13d
       je        short M00_L11
       mov       r8,[rsi+8]
       mov       r15d,[rsi+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L10
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M00_L17
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L15:
       add       r13d,r15d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L16:
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6877A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L15
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L15
M00_L18:
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L19
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,265CCDB9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L20:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F5DB73F0]
       mov       r8,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,rsi
       mov       edx,3D
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L14
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 722
```
```assembly
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F601E9E8]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L03:
       mov       rax,265CCDB0008
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
       call      qword ptr [7FFA534AA5E8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M06_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA53493D20]; CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 56
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F68BD578]
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F68BD578]
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
       jg        short M00_L08
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L09
M00_L08:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       jbe       near ptr M00_L20
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L13:
       xor       r13d,r13d
M00_L14:
       mov       rcx,2A85E00EF28
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
       call      qword ptr [7FF9F69774F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       ecx,[rsi+18]
       mov       edx,ecx
       mov       rax,[rsi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L21
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],22
       inc       ecx
       mov       [rsi+18],ecx
M00_L16:
       mov       rdx,2E8EBEC9084
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        near ptr M00_L22
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
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6886AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L22:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L17
M00_L23:
       call      qword ptr [7FF9F6344D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6344AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2E8EBEC9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F602ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DC73F0]
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
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L26
       jmp       near ptr M00_L14
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1037
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
       jmp       qword ptr [7FF9F5E75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M02_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L04:
       test      eax,eax
       jne       short M02_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M02_L00
M02_L05:
       call      qword ptr [7FF9F602E9D0]
       int       3
M02_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M02_L02
M02_L07:
       call      qword ptr [7FF9F602E9E8]
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
       call      qword ptr [7FF9F614DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F6919CB8]
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
       call      qword ptr [7FF9F60CCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FF9F618F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M03_L04:
       jmp       short M03_L01
M03_L05:
       call      qword ptr [7FF9F6A15308]
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
       call      qword ptr [7FF9F620D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M03_L07
M03_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F697CCD8]
M03_L07:
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A15B78]
       jmp       near ptr M03_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A164D8]
       jmp       near ptr M03_L01
M03_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61ECBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M04_L01
M04_L04:
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F688D1E8]
       int       3
M04_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F688D1E8]
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M04_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L03:
       mov       rax,2E8EBEC0008
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
       call      qword ptr [7FF9F60CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F68CD578]
       test      eax,eax
       jne       near ptr M00_L29
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F68CD578]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,29BDC229084
       mov       r14,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r13+2]
       cmp       [r14+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,25B4A40EF28
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
       call      qword ptr [7FF9F69874F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6896AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FF9F6354D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FF9F6354AE0]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29BDC229CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F603ED48]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
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
       jb        near ptr M01_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L03
       test      r8b,18
       jne       short M01_L01
       test      r8b,4
       je        short M01_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L02
M01_L00:
       test      r8,r8
       je        short M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L02
M01_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L02:
       ret
M01_L03:
       cmp       r8,40
       ja        short M01_L06
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L10
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L02
M01_L06:
       cmp       r8,800
       ja        short M01_L09
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
       ja        short M01_L04
       jmp       short M01_L05
M01_L08:
       cmp       rcx,rdx
       je        short M01_L02
M01_L09:
       jmp       qword ptr [7FF9F5E85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L05
; Total bytes of code 248
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
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F603E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F603E9E8]
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
       call      qword ptr [7FF9F615DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F692AAE8]
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
       call      qword ptr [7FF9F60DCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F619F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F6A27588]
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
       call      qword ptr [7FF9F621D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F698CCD8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A27DF8]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A2C7F8]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61FCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F689CEB8]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F689CEB8]
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60666E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,29BDC220008
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M08_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
M00_L03:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L04:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
       jmp       short M00_L03
M00_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1C10A40CF30
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
       call      qword ptr [7FF9F69774F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,2019C309084
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
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6876AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2019C309CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F601ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DB73F0]
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
       call      qword ptr [7FF9F60BC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60BC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60BC3D8]; System.Text.StringBuilder.Append(Char)
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F601E9E8]
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
       call      qword ptr [7FF9F613DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F690CE88]
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
       call      qword ptr [7FF9F60BCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F617F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F6A07570]
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
       call      qword ptr [7FF9F61FD1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F697CCD8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A07DE0]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A0C7F8]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61DCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F687D1E8]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F687D1E8]
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60466E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2019C300008
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
       call      qword ptr [7FF9F60BCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60BC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,295E6C0CF30
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
       call      qword ptr [7FF9F69674F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,2D678B89084
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
       call      qword ptr [7FF9F60B8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6866AF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FF9F6324D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6324AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D678B89CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F600ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DA73F0]
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
       call      qword ptr [7FF9F60AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60AC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60AC3D8]; System.Text.StringBuilder.Append(Char)
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F600E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F600E9E8]
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
       call      qword ptr [7FF9F612DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F68FC7E8]
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
       call      qword ptr [7FF9F60ACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F616F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F69F7648]
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
       call      qword ptr [7FF9F61ED1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F696CCD8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F69F7EB8]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F69FC840]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61CCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F686CEB8]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F686CEB8]
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60366E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2D678B80008
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
       call      qword ptr [7FF9F60ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       jg        short M00_L08
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M00_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M00_L09
M00_L08:
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       add       r13d,r12d
       mov       [rsi+18],r13d
       jmp       short M00_L11
M00_L10:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1E11A40EF28
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
       call      qword ptr [7FF9F69674F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,221AC149084
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
       call      qword ptr [7FF9F60B8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6867A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FF9F6324D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6324AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,221AC149CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F600ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DA73F0]
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
       call      qword ptr [7FF9F60AC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60AC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60AC3D8]; System.Text.StringBuilder.Append(Char)
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F600E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F600E9E8]
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
       call      qword ptr [7FF9F612DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F68FC908]
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
       call      qword ptr [7FF9F60ACBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F616F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F69F78D0]
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
       call      qword ptr [7FF9F61ED1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F696CCD8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F69FC150]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F69FCAB0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61CCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       ja        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FF9F60ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L04:
       mov       ecx,172D
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F686DEC0]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F686DEC0]
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60366E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,221AC140008
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
       call      qword ptr [7FF9F60ACB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,1664C80CF30
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
       call      qword ptr [7FF9F69974F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,1A6DE759084
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
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6897A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FF9F6354D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6354AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1A6DE759CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F603ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
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
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M02_L02
M02_L00:
       test      r8,r8
       je        short M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M02_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M02_L02
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M02_L02:
       ret
M02_L03:
       cmp       r8,40
       ja        short M02_L06
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L10
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L02
M02_L06:
       cmp       r8,800
       ja        short M02_L09
       mov       r9,r8
       shr       r9,6
M02_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L07
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L08:
       cmp       rcx,rdx
       je        short M02_L02
M02_L09:
       jmp       qword ptr [7FF9F5E85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
; Total bytes of code 248
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F603E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F603E9E8]
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
       call      qword ptr [7FF9F6157900]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F692CCF8]
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
       call      qword ptr [7FF9F60DCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F619F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F6A278D0]
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
       call      qword ptr [7FF9F621D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F699CCD8]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A2C150]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A2CAB0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61FCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F689DEC0]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F689DEC0]
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60666E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,1A6DE750008
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
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L27
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L30
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L27
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,2B6A540CF30
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
       call      qword ptr [7FF9F6987630]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       mov       rdx,2F7372C9084
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
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6887A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L17
M00_L21:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L22:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L23:
       call      qword ptr [7FF9F6344D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L24
       call      qword ptr [7FF9F6344AE0]
       mov       rbx,rax
M00_L24:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F7372C9CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L25:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F602ED48]
       int       3
M00_L26:
       call      CORINFO_HELP_OVERFLOW
M00_L27:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DC73F0]
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
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       short M00_L30
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC3D8]; System.Text.StringBuilder.Append(Char)
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M03_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186D1
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L04:
       test      eax,eax
       jne       short M03_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M03_L00
M03_L05:
       call      qword ptr [7FF9F602E9D0]
       int       3
M03_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M03_L02
M03_L07:
       call      qword ptr [7FF9F602E9E8]
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
       call      qword ptr [7FF9F614DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
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
       lea       r8,[7FF9F691A208]
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
       call      qword ptr [7FF9F60CCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M04_L04
M04_L03:
       call      qword ptr [7FF9F618F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M04_L04:
       jmp       short M04_L01
M04_L05:
       call      qword ptr [7FF9F6A178D0]
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
       call      qword ptr [7FF9F620D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M04_L07
M04_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F698CE28]
M04_L07:
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A1C150]
       jmp       near ptr M04_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A1CAB0]
       jmp       near ptr M04_L01
M04_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61ECBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
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
       ja        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M05_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M05_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L01
M05_L04:
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F688E268]
       int       3
M05_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F688E268]
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M05_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       ecx,186A1
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L03:
       mov       rax,2F7372C0008
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
       call      qword ptr [7FF9F60CCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
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
; System.Text.StringBuilder.Append(Char)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+18]
       mov       eax,ecx
       mov       r8,[rbx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rdi,[rbx+288]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L04
M00_L03:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M00_L29
M00_L04:
       lea       ecx,[r15-1]
       cmp       ecx,r15d
       jae       near ptr M00_L31
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M00_L05
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M00_L29
       jmp       short M00_L06
M00_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
M00_L11:
       mov       rdx,29BA5509084
       mov       r14,[rsi+8]
       mov       r13d,[rsi+18]
       lea       ecx,[r13+2]
       cmp       [r14+8],ecx
       jb        near ptr M00_L22
       jmp       near ptr M00_L19
M00_L12:
       mov       rcx,rsi
       mov       r8d,r13d
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       mov       rcx,25B1340EF28
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
       call      qword ptr [7FF9F69974F8]; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rsp+40],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+40]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6897A98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L20
M00_L23:
       mov       rcx,rsi
       mov       edx,22
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L15
M00_L24:
       mov       r9d,r12d
       sub       r9d,r13d
       jo        near ptr M00_L28
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8d,r13d
       call      qword ptr [7FF9F60DC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rax
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
       mov       rcx,rax
       cmp       r12d,r15d
       jae       near ptr M00_L31
       mov       edx,r12d
       movzx     edx,word ptr [r14+rdx*2+0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60DC3D8]; System.Text.StringBuilder.Append(Char)
       mov       r13d,r12d
       add       r13d,1
       jo        short M00_L28
       jmp       near ptr M00_L16
M00_L25:
       call      qword ptr [7FF9F6354D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L26
       call      qword ptr [7FF9F6354AE0]
       mov       rbx,rax
M00_L26:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29BA5509CB0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L27:
       mov       ecx,8
       xor       edx,edx
       call      qword ptr [7FF9F603ED48]
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
M00_L29:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
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
; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       sub       rsp,28
       movzx     ecx,cx
       call      qword ptr [7FFA534A7370]; Precode of System.Globalization.CharUnicodeInfo.GetCategoryCasingTableOffsetNoBoundsChecks(UInt32)
       mov       rcx,[7FFA534C0750]
       cmp       byte ptr [rcx+rax],0
       setl      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 35
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M02_L03
       test      r8b,18
       jne       short M02_L01
       test      r8b,4
       je        short M02_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M02_L00:
       ret
M02_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M02_L00
M02_L02:
       test      r8,r8
       je        short M02_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M02_L06
       jmp       short M02_L00
M02_L03:
       cmp       r8,40
       ja        short M02_L07
M02_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M02_L11
M02_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M02_L00
M02_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M02_L00
M02_L07:
       cmp       r8,800
       ja        short M02_L10
       mov       r9,r8
       shr       r9,6
M02_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L08
       and       r8,3F
       cmp       r8,10
       ja        short M02_L04
       jmp       short M02_L05
M02_L09:
       cmp       rcx,rdx
       je        near ptr M02_L00
M02_L10:
       jmp       qword ptr [7FF9F5E85B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L05
; Total bytes of code 254
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
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M03_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
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
       jg        near ptr M04_L03
       cmp       r8d,edi
       jl        near ptr M04_L03
       mov       r8,[rbx+8]
       mov       ebp,[r8+8]
       sub       ebp,eax
       test      ebp,ebp
       jle       short M04_L01
       test      r8,r8
       je        near ptr M04_L04
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jb        near ptr M04_L05
       mov       ecx,eax
       lea       rcx,[r8+rcx*2+10]
       sub       r10d,eax
M04_L00:
       cmp       ebp,r10d
       ja        near ptr M04_L07
       mov       r8d,ebp
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M04_L01:
       sub       edi,ebp
       mov       rcx,rbx
       mov       edx,edi
       call      qword ptr [7FF9F60DCB58]; System.Text.StringBuilder.ExpandByABlock(Int32)
       movsxd    r8,ebp
       lea       rdx,[rsi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L06
       lea       rcx,[r8+10]
       mov       r14d,[r8+8]
       cmp       edi,r14d
       ja        near ptr M04_L07
M04_L02:
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],edi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186D1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F6C0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L04:
       test      eax,eax
       jne       short M04_L05
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M04_L00
M04_L05:
       call      qword ptr [7FF9F603E9D0]
       int       3
M04_L06:
       xor       ecx,ecx
       xor       r14d,r14d
       cmp       edi,r14d
       jbe       short M04_L02
M04_L07:
       call      qword ptr [7FF9F603E9E8]
       int       3
; Total bytes of code 315
```
```assembly
; System.MemoryExtensions.IndexOfAny[[System.Char, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      rsi
       push      rbx
       sub       rsp,48
M05_L00:
       mov       r8,[rcx]
       mov       eax,[rcx+8]
       mov       r9d,eax
       mov       [rsp+44],r9d
       mov       rcx,r8
       mov       rax,[rdx]
       mov       ebx,[rdx+8]
       cmp       ebx,2
       jne       short M05_L02
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movzx     esi,dx
       lea       eax,[rsi-1]
       cmp       eax,0FE
       jae       near ptr M05_L05
       movzx     eax,r8w
       dec       eax
       cmp       eax,0FE
       jae       short M05_L05
       movzx     r8d,r8w
       movsx     r8,r8w
       movsx     rdx,si
       call      qword ptr [7FF9F615DAE8]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
M05_L01:
       nop
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M05_L02:
       cmp       ebx,5
       ja        near ptr M05_L08
       mov       edx,ebx
       lea       r8,[7FF9F6928B28]
       mov       r8d,[r8+rdx*4]
       lea       r10,[M05_L00]
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
       jae       short M05_L03
       mov       edx,esi
       movsx     rdx,dx
       call      qword ptr [7FF9F60DCBE8]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       short M05_L04
M05_L03:
       call      qword ptr [7FF9F619F2D0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M05_L04:
       jmp       short M05_L01
M05_L05:
       call      qword ptr [7FF9F6A275D0]
       jmp       short M05_L01
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     rax,word ptr [rax+4]
       mov       r10d,r9d
       movzx     esi,dx
       lea       r9d,[rsi-1]
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,r8w
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       movzx     r9d,ax
       dec       r9d
       cmp       r9d,0FE
       jae       short M05_L06
       mov       edx,esi
       movzx     r8d,r8w
       movzx     r9d,ax
       mov       [rsp+20],r10d
       movsx     r9,r9w
       movsx     rdx,dx
       movsx     r8,r8w
       call      qword ptr [7FF9F621D1D0]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M05_L07
M05_L06:
       mov       [rsp+20],r10d
       mov       r9d,eax
       call      qword ptr [7FF9F699CCD8]
M05_L07:
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A27E40]
       jmp       near ptr M05_L01
       movsx     rdx,word ptr [rax+6]
       mov       [rsp+20],edx
       movsx     rdx,word ptr [rax+8]
       mov       [rsp+28],edx
       mov       [rsp+30],r9d
       movsx     rdx,word ptr [rax]
       movsx     r8,word ptr [rax+2]
       movsx     r9,word ptr [rax+4]
       call      qword ptr [7FF9F6A2C7F8]
       jmp       near ptr M05_L01
M05_L08:
       mov       r9d,[rdx+8]
       mov       edx,[rsp+44]
       mov       r8,rax
       call      qword ptr [7FF9F61FCBA0]; System.Buffers.ProbabilisticMap.IndexOfAny(Char ByRef, Int32, Char ByRef, Int32)
       jmp       near ptr M05_L01
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
       jl        near ptr M06_L04
       test      ebx,ebx
       jl        near ptr M06_L05
       test      rdx,rdx
       je        near ptr M06_L06
       test      ebx,ebx
       je        short M06_L01
       mov       r8d,[rdx+8]
       sub       r8d,ebx
       cmp       r8d,edi
       jl        near ptr M06_L08
       movsxd    r8,edi
       lea       rdx,[rdx+r8*2+0C]
       mov       r8,[rsi+8]
       mov       ecx,[rsi+18]
       lea       edi,[rcx+rbx]
       cmp       edi,[r8+8]
       ja        short M06_L03
       movsxd    rcx,ecx
       lea       rcx,[r8+rcx*2+10]
       cmp       ebx,2
       jle       short M06_L02
       movsxd    r8,ebx
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L00:
       mov       [rsi+18],edi
M06_L01:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       ebx,2
       jne       short M06_L00
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       mov       r8d,ebx
       call      qword ptr [7FF9F60DCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M06_L01
M06_L04:
       mov       ecx,172D
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F689DEC0]
       int       3
M06_L05:
       mov       ecx,1C7
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F689DEC0]
       int       3
M06_L06:
       or        ebx,edi
       jne       short M06_L07
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L07:
       mov       ecx,2E5
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60666E8]
       int       3
M06_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
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
       je        near ptr M07_L03
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
M07_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M07_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M07_L02
       cmp       [rdx+8],r8d
       jb        short M07_L02
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M07_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,186A1
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L03:
       mov       rax,29BA5500008
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
       jbe       short M09_L01
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [rbx+18],ecx
M09_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       movzx     edx,dx
       mov       rcx,rbx
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M09_L00
; Total bytes of code 62
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,2D1B5289078
       call      qword ptr [7FF9F65F7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F68CD578]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F68CD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F68CD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F68CD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F68CD578]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2D1B5280008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6896B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,2D1B5289078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 776
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D1B5280008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,2CE95999078
       call      qword ptr [7FF9F65F7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F68CD590]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F68CD590]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F68CD590]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F68CD590]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F68CD590]
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2CE95990008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6896B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,2CE95999078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 774
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2CE95990008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,2A814D19078
       call      qword ptr [7FF9F65F7018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2A814D10008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6896E50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,2A814D19078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 774
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2A814D10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,265E1DD9078
       call      qword ptr [7FF9F65F7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,265E1DD0008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6896B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,265E1DD9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 776
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,265E1DD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,1F26A8B9078
       call      qword ptr [7FF9F65C7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60B8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F66EE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1F26A8B0008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6867AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62A5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62A5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,1F26A8B9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 774
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F26A8B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,1F442D19078
       call      qword ptr [7FF9F6606F28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F672E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1F442D10008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F68A7AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62E5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,1F442D19078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 776
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F639F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F442D10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,2580CFD9078
       call      qword ptr [7FF9F65D7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
       xor       eax,eax
       mov       [rsp+28],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
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
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L08:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       r13,2580CFD0008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+28],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+28]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6877AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF9F6046670]
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
       mov       rbx,2580CFD9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 786
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2580CFD0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       r8,[rbx+288]
       mov       rcx,rsi
       mov       rdx,1C33A7F9078
       call      qword ptr [7FF9F65F6F28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1C33A7F0008
       jmp       short M01_L15
M01_L18:
       mov       rdi,[rbp+8]
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       mov       [rsi+18],r9
       mov       [rsp+20],rsi
       lea       r9,[rsp+30]
       mov       rdx,rdi
       mov       r8,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6897AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L19:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       nop
       add       rsp,38
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
       mov       rbx,1C33A7F9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 782
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1C33A7F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,27EFD979078
       call      qword ptr [7FF9F65C70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60B8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F689D578]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F689D578]
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
       mov       rax,7FFA52A42E50
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L08:
       call      qword ptr [7FF9F689D578]
       test      eax,eax
       je        short M01_L06
       jmp       short M01_L05
M01_L09:
       call      qword ptr [7FF9F689D578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F689D578]
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       r13,27EFD970008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6866B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62A5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FF9F62A5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF9F6036670]
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
       mov       rbx,27EFD979078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 771
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F635F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E5D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27EFD970008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,1F74B339078
       call      qword ptr [7FF9F65D70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F68AD578]
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F68AD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F68AD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F68AD578]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F68AD578]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,1F74B330008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6876B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
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
       mov       rbx,1F74B339078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 761
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1F74B330008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,2B38FEA9078
       call      qword ptr [7FF9F65F70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F671E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,2B38FEA0008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6896B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62D5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       mov       rbx,2B38FEA9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 763
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F638F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B38FEA0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,203C9C49078
       call      qword ptr [7FF9F65E70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,203C9C40008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6886B20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       mov       rbx,203C9C49078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 765
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,203C9C40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,237CBF69078
       call      qword ptr [7FF9F65D7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,237CBF60008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6877AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
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
       mov       rbx,237CBF69078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 763
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,237CBF60008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,258520C9078
       call      qword ptr [7FF9F65D70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
M01_L09:
       dec       r14d
       cmp       r14d,r15d
       jge       short M01_L08
       jmp       short M01_L14
M01_L10:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       r13,258520C0008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6877AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF9F6046670]
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
       mov       rbx,258520C9078
       jmp       near ptr M01_L18
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,258520C0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,24615BC9078
       call      qword ptr [7FF9F65D6F10]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F66FE028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,24615BC0008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6877AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62B5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
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
       mov       rbx,24615BC9078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 761
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F636F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,24615BC0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       cmp       [rbx],bl
       lea       r8,[rbx+290]
       mov       rcx,rsi
       mov       rdx,26649D89078
       call      qword ptr [7FF9F65E70F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
       mov       rcx,rsi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef)
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
       cmp       qword ptr [rsi],0
       je        near ptr M01_L20
       test      rbx,rbx
       je        near ptr M01_L22
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L21
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M01_L03
M01_L01:
       lea       r14d,[rdi-1]
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       near ptr M01_L21
M01_L02:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L07
       jmp       short M01_L06
M01_L05:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L10
M01_L09:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L14
       jmp       short M01_L13
M01_L12:
       call      qword ptr [7FF9F670E028]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L17:
       mov       rdi,26649D80008
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
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String> ByRef, System.Action`1<System.String>)
       call      qword ptr [7FF9F6887AC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon> ByRef, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,1
       mov       rdx,7FF9F62C5880
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       mov       rbx,26649D89078
       jmp       near ptr M01_L18
M01_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 761
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F637F5E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,26649D80008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 190
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6886AD8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,30CAAD00008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,2CC1900BD50
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,2CC1D000428
       mov       r13,[rcx]
       mov       r12,30CAAD17658
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60CC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,30CAAD00008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F688EAA8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,2CC1900BD50
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6876AD8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,2B208830008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,2717680BD50
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,2717A800428
       mov       r13,[rcx]
       mov       r12,2B208847658
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60BC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,2B208830008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F687EAA8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,2717680BD50
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6886AD8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,22764DF0008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,1E6D300DD48
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,1E6D3000428
       mov       r13,[rcx]
       mov       r12,22764E07658
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60CC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,22764DF0008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F688EAA8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,1E6D300DD48
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6876AD8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,20A9C2D0008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,1CA0E40DD48
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,1CA0E400428
       mov       r13,[rcx]
       mov       r12,20A9C2E7658
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60BC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,20A9C2D0008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EF88]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F687EAA8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,1CA0E40DD48
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EF58]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6877A80]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,21C0DCC0008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,1DB7BC0DD48
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,1DB7BC00428
       mov       r13,[rcx]
       mov       r12,21C0DCD7678
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60BC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60C8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,21C0DCC0008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F687EBF8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60BC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,1DB7BC0DD48
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F659EEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6897A80]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,266553F0008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,225C340DD48
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,225C3400428
       mov       r13,[rcx]
       mov       r12,26655407678
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60DC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,266553F0008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BEF88]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F689EBF8]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,225C340DD48
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BEF58]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6887A80]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,2A92AB80008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,26898C0DD48
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,26898C00428
       mov       r13,[rcx]
       mov       r12,2A92AB97678
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60CC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,2A92AB80008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F688EF28]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60CC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,26898C0DD48
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+280]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       lea       rax,[rcx+10]
       mov       ecx,[rcx+8]
       mov       [rsp+30],rax
       mov       [rsp+38],ecx
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F6895908]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
M00_L00:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,1D77A5A0008
       jmp       short M00_L00
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L06
       mov       rcx,196E880BD50
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L07
       lea       rcx,[rsi+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L07
M01_L00:
       mov       rdi,[rbp-48]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-68],rdi
       imul      r14d,[rbx+8],2
       jo        near ptr M01_L05
       add       r14d,2
       jo        near ptr M01_L05
       test      r14d,r14d
       jl        near ptr M01_L09
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M01_L10
M01_L02:
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       mov       rsi,[rbx]
       mov       ebx,[rbx+8]
       xor       r14d,r14d
       test      ebx,ebx
       jle       short M01_L04
       mov       r15,offset MT_System.Byte
       mov       rcx,196EC800428
       mov       r13,[rcx]
       mov       r12,1D77A5B7678
M01_L03:
       mov       ecx,r14d
       movzx     eax,byte ptr [rsi+rcx]
       mov       [rbp-3C],eax
       mov       rcx,r15
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,r13
       mov       ecx,[rbp-3C]
       mov       [rax+8],cl
       mov       [rbp-50],rax
       lea       rcx,[rbp-50]
       mov       r9,rdi
       mov       [rbp-60],rcx
       mov       dword ptr [rbp-58],1
       mov       rcx,r9
       lea       r9,[rbp-60]
       mov       r8,r12
       call      qword ptr [7FF9F60DC930]; System.Text.StringBuilder.AppendFormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       inc       r14d
       cmp       r14d,ebx
       jl        short M01_L03
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-70],rax
       mov       rcx,rsp
       call      M01_L12
       jmp       near ptr M01_L11
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rax,1D77A5A0008
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
M01_L07:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BD4A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L08
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L09:
       mov       ecx,13C20
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF9F689CD20]
       int       3
M01_L10:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF9F60DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M01_L02
M01_L11:
       mov       rax,[rbp-70]
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
M01_L12:
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
       lea       rbp,[rbp+0A0]
       mov       rcx,196E880BD50
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L13
       mov       rdi,[rbp-68]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L17
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L14
M01_L13:
       mov       rdi,[rbp-68]
       mov       rdx,rdi
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L17
M01_L14:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L15
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L17
M01_L15:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L16
       mov       rcx,[rbx+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BD470]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L17
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L17:
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
; Total bytes of code 707
```

