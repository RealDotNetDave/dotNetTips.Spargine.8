## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388E5398]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,1E1BEFA57F0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1E1BEF90008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,1E1BEFA5810
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1E1BEFA5830
       mov       [rbp-38],rax
       call      qword ptr [7FFE38214270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FCD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E1BEF90008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CAC80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388D6F58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388D7018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,18DFEFA5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,18DFEF90008
       call      qword ptr [7FFE38537C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,18DFEFA5830
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,18DFEFA5850
       mov       [rbp-38],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385956F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,18DFEF90008
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
       cmp       dword ptr [7FFE3837F408],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388AC9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D7060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388F71C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388F7288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,19DD3585860
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,19DD3570008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,19DD3585880
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,19DD35858A0
       mov       [rbp-38],rax
       call      qword ptr [7FFE38224270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FDD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,19DD3570008
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CC5D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F72D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388F5398]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388F5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,2451B2657F0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2451B250008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,2451B265810
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,2451B265830
       mov       [rbp-38],rax
       call      qword ptr [7FFE38224270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FDD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2451B250008
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388DAC80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388E6B68]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,223F4C05810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,223F4BF0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,223F4C05830
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,223F4C05850
       mov       [rbp-38],rax
       call      qword ptr [7FFE38214270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FCD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,223F4BF0008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388BC9D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E6C70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE388D6F58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388D7018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,2438C015810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2438C000008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,2438C015830
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,2438C015850
       mov       [rbp-38],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2438C000008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388AC9D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D7060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE3899E838]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE3899E8F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,252291D5860
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,252291C0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,252291D5880
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,252291D58A0
       mov       [rbp-38],rax
       call      qword ptr [7FFE38214270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FCD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,252291C0008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388FC560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3899E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       call      qword ptr [7FFE38A0CDC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38A0CE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       edx,edx
       cmp       qword ptr [rbp+18],0
       sete      dl
       mov       [rbp-4],edx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       nop
       jmp       near ptr M01_L06
M01_L01:
       mov       rdx,298673E5860
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,298673D0008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,298673E5880
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-8],eax
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rax,[rbp+18]
       mov       ecx,[rbp-8]
       cmp       ecx,[rax+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,298673E58A0
       mov       [rbp-38],rax
       call      qword ptr [7FFE38224270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FFE37FDD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-8]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-8],ecx
M01_L05:
       mov       eax,[rbp-8]
       mov       rcx,[rbp+18]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],0
       jne       near ptr M01_L02
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
M01_L06:
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 376
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,298673D0008
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
       cmp       dword ptr [7FFE3838F438],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE389E9B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0CED0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,252C25E90D8
       call      qword ptr [7FFE38906FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38907018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE38907048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,252C25F5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,252C25E0008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE38906F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38903060
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE38907090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,252C25E0008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388DD1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,2484F2490D8
       call      qword ptr [7FFE388E6BB0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383887B0]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388E6C58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2484F255810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2484F240008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388E6B50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388E2C70
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388E6CA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2484F240008
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
       cmp       dword ptr [7FFE382F07E0],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE38327AF8]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E6D78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,2975A3990D8
       call      qword ptr [7FFE388E6DF0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E6E68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388E6E98]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2975A3A57E8
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2975A390008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388E6D90]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388E2EB0
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388E6EE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2975A390008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388BCFB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E6FB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,1CD08AB90D8
       call      qword ptr [7FFE388F6FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388F7018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388F7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,1CD08AC5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1CD08AB0008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388F6F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388F3060
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388F7090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1CD08AB0008
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F7168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,27AB3C790D8
       call      qword ptr [7FFE38906FA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38907018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE38907048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,27AB3C85810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,27AB3C70008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE38906F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38903060
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE38907090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27AB3C70008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388DD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,1D6315890D8
       call      qword ptr [7FFE388F6BB0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388F6C58]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,1D631595810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1D631580008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388F6B50]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388F2C70
       call      qword ptr [7FFE38044210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388F6CA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D631580008
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F6D78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,239AAD090D8
       call      qword ptr [7FFE389BE880]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE389BE8F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE389BE928]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,239AAD15860
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,239AAD00008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE389BE820]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE389BA940
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE389BE970]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,239AAD00008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE3891CD40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389BEA48]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,21D767D90D8
       call      qword ptr [7FFE38A0C060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38A0C0D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE38A0C108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,21D767E5838
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21D767D0008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE38A0C000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38A08120
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE38A0C150]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21D767D0008
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
       cmp       dword ptr [7FFE3839F438],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE389EA178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A0C228]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,208F23690D8
       call      qword ptr [7FFE388E53C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CE1E0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388E5488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,208F23757F0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,208F2360008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388E5380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388E14A0
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388E54D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,208F2360008
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
       cmp       dword ptr [7FFE3837FA70],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CB460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E55A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,22387FC90D8
       call      qword ptr [7FFE388E4C60]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388E4CF0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388E4D20]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,22387FD57C8
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,22387FC0008
       call      qword ptr [7FFE38547C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388E4C18]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388E0D38
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388E4D68]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22387FC0008
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
       cmp       dword ptr [7FFE3838F388],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CB258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E4E40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,2AA663D90D8
       call      qword ptr [7FFE388D6F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388D7018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388D7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2AA663E5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2AA663D0008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388D6F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388D3060
       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388D7090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2AA663D0008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388AD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D7168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,25A9D8490D8
       call      qword ptr [7FFE38906F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38907018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE38907048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,25A9D855810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,25A9D840008
       call      qword ptr [7FFE38567C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE38906F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38903060
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE38907090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25A9D840008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388DD1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,21973D090D8
       call      qword ptr [7FFE38906F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE38907018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE38907048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,21973D15810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21973D00008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE38906F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE38903060
       call      qword ptr [7FFE38054210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE38907090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21973D00008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388DD1B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38907168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,231F55A90D8
       call      qword ptr [7FFE388D6F88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE388D7018]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE388D7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,231F55B5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,231F55A0008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE388D6F40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE388D3060
       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE388D7090]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,231F55A0008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388AD1D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D7168]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,2D903BD90D8
       call      qword ptr [7FFE3890D218]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE3890D2A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE3890D2D8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2D903BE5838
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2D903BD0008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE3890D1D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE389092F0
       call      qword ptr [7FFE38024210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE3890D320]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D903BD0008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388EAD18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3890D3F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rsi
       push      rbx
       sub       rsp,28
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
       mov       rdx,2039E0390D8
       call      qword ptr [7FFE389FD3C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE389FD458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 129
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FFE389FD488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2039E045860
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2039E030008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L01
       nop
       nop
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+18]
       call      qword ptr [7FFE389FD380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FFE389F94A0
       call      qword ptr [7FFE38034210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FFE389FD4D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
M01_L02:
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 341
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2039E030008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE389DA260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389FD5A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE388D4DC8]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388D4E70]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,21A82EC0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B0C008F58
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,21A82ED57F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE388D4EA0]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,21A82ED5810
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21B0C008F58
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388BACD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D4EB8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE388D5380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388D5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,241FA420008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2016840AF50
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,241FA4357F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE388D5458]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,241FA435810
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2016840AF50
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388BACD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D5470]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE388D6F40]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388D6FE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2005C780008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BFCE80AF50
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,2005C795810
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE388D7018]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,2005C795830
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BFCE80AF50
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388ACA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D7030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE388D6B50]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388D6BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1740C1C0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1337E40AF50
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1740C1D5810
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE388D6C28]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1740C1D5830
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1337E40AF50
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388ACA48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE388D6B50]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE388D6BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1FF0DE90008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BE7C008F58
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1FF0DEA5810
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE388D6C28]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1FF0DEA5830
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BE7C008F58
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388ACA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D6C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE38906B50]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE38906BF8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383C0B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,26644B70008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383C12A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,225B2C08F58
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,26644B85810
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE38906C28]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3823EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,26644B85830
       mov       [rbp-78],rax
       call      qword ptr [7FFE38234270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FED398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3823EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383C12A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,225B2C08F58
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE388DCA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38906C40]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE3892E400]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE3892E4A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE383B0B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2E0BBA40008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383B12A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A02DC08F58
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,2E0BBA55860
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE3877EB98]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3822EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,2E0BBA55880
       mov       [rbp-78],rax
       call      qword ptr [7FFE38224270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FDD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3822EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383B12A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A02DC08F58
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE3890C5A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3892E4D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE389ECDB0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE389ECE58]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0E0
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-0C0],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFE38390B30],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1C5B3060008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L05
M01_L02:
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18521008F58
       mov       rcx,[rcx]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp-0A8]
       mov       rax,[rbp-0A8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1C5B3075860
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-40],rax
       nop
       nop
       lea       rcx,[rbp-50]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFE3875E490]; System.MemoryExtensions.AsSpan[[System.Byte, System.Private.CoreLib]](Byte[])
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-28],xmm0
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       nop
       jmp       near ptr M01_L04
M01_L03:
       lea       rcx,[rbp-28]
       mov       edx,[rbp-2C]
       call      qword ptr [7FFE3820EA00]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Item(Int32)
       mov       [rbp-60],rax
       mov       rax,[rbp-60]
       movzx     eax,byte ptr [rax]
       mov       [rbp-30],eax
       nop
       mov       rax,[rbp-8]
       mov       [rbp-68],rax
       lea       rax,[rbp-30]
       mov       [rbp-70],rax
       mov       rax,1C5B3075880
       mov       [rbp-78],rax
       call      qword ptr [7FFE38204270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-80],rax
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-78]
       mov       r8,[rbp-80]
       call      qword ptr [7FFE37FBD398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-88],rax
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-88]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-90],rax
       nop
       nop
       mov       ecx,[rbp-2C]
       inc       ecx
       mov       [rbp-2C],ecx
M01_L04:
       mov       ecx,[rbp-2C]
       mov       [rbp-54],ecx
       lea       rcx,[rbp-28]
       call      qword ptr [7FFE3820EA18]; System.Span`1[[System.Byte, System.Private.CoreLib]].get_Length()
       mov       [rbp-58],eax
       mov       ecx,[rbp-54]
       cmp       ecx,[rbp-58]
       jl        near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-0A0],rax
       mov       rcx,[rbp-0A0]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L06
       nop
M01_L05:
       mov       rax,[rbp-18]
       add       rsp,0E0
       pop       rbp
       ret
M01_L06:
       push      rbp
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0E0]
       nop
       mov       rcx,7FFE383912A8
       mov       edx,27
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18521008F58
       mov       rcx,[rcx]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp-0B0]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-0B0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 624
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-18],rax
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L01
       mov       r8,[rbp+18]
       mov       r8,[r8+10]
       mov       r8,[r8+10]
       mov       [rbp-20],r8
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+18]
       mov       rdx,7FFE389C9B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE389ECE88]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388D53B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388D5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,1E8E32057F0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1E8E31F0008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,1E8E31F9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1E8E31F0008
       call      qword ptr [7FFE3850C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384BDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1A85540BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38027528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,1E8E31F90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E8E31F0008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388BAE40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388E53B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388E5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,28CEAEA57F0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,28CEAE90008
       call      qword ptr [7FFE38547C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,28CEAE99D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,28CEAE90008
       call      qword ptr [7FFE38547A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384CDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,24C5900BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,28CEAE990D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,28CEAE90008
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
       cmp       dword ptr [7FFE3838F380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CAE40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388F6B80]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388F6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,3279E2E5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,3279E2D0008
       call      qword ptr [7FFE3852C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,3279E2D9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,3279E2D0008
       call      qword ptr [7FFE3852C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384DDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2E70C40BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38047528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380469D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380469E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,3279E2D90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,3279E2D0008
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
       cmp       dword ptr [7FFE3839F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CCB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F6C70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388E6DC0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388E6E68]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,205B40857E8
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,205B4070008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,205B4079D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,205B4070008
       call      qword ptr [7FFE3851C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384CDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1C52200BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,205B40790D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,205B4070008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388BC990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388E6EB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388F6850]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383239E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388F68F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384DD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,27A0FB05810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,27A0FAF0008
       call      qword ptr [7FFE38557C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,27A0FAF9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,27A0FAF0008
       call      qword ptr [7FFE38557A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384DDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,23981C0BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38047528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380469D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380469E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,27A0FAF90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3831C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EF4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385B56F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380FD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,27A0FAF0008
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
       cmp       dword ptr [7FFE3838F438],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383D4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388CCBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388F6940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE388D6B80]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383039E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE388D6C28]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384BD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,26FBA9E5810
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,26FBA9D0008
       call      qword ptr [7FFE3850C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,26FBA9D9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,26FBA9D0008
       call      qword ptr [7FFE3850C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384BDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,22F28C0BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38027528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380269E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,26FBA9D90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE382FC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380D5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37ED4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE38595EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380DD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,26FBA9D0008
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
       cmp       dword ptr [7FFE3837F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383B4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388ACB98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE388D6C70]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE3899E850]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383139E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE3899E8F8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384CD7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2BDCBFD5860
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2BDCBFC0008
       call      qword ptr [7FFE3851C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,2BDCBFC9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2BDCBFC0008
       call      qword ptr [7FFE3851C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384CDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27D3A00BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38037528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380369E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,2BDCBFC90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3830C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE380E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37EE4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385A5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE380ED470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2BDCBFC0008
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
       cmp       dword ptr [7FFE3838F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383C4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE388FC720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3899E940]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
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
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rdi+rcx*8+10]
       mov       dword ptr [rsp+20],1
       mov       rcx,rsi
       mov       rdx,r8
       mov       r9d,1
       call      qword ptr [7FFE38A1CDE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE383339E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FFE38A1CE88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 169
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       vmovdqa   xmmword ptr [rbp-0A0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FFE384ED7E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,1AD558B5860
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1AD558A0008
       call      qword ptr [7FFE3853C648]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,1AD558A9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1AD558A0008
       call      qword ptr [7FFE3853C450]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       cmp       qword ptr [rbp+20],0
       sete      cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L02
       nop
       nop
       jmp       near ptr M01_L13
M01_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-40],rax
       nop
       mov       ecx,[rbp+28]
       movzx     ecx,cl
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L11
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FFE384EDCD0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,16CC780BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38057528]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-5C],eax
       mov       r9d,[rbp-5C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L06
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380569D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0B0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L08
M01_L06:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-68],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-70],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-74],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE380569E8]; System.String.get_Length()
       mov       [rbp-78],eax
       mov       r9d,[rbp-78]
       sub       r9d,[rbp-0C]
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-70]
       mov       r8d,[rbp-74]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-80],rax
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
M01_L09:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-88],rax
       nop
       nop
       nop
       jmp       short M01_L12
M01_L11:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       nop
M01_L12:
       mov       ecx,[rbp+30]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       rdx,1AD558A90D8
       cmp       [rcx],ecx
       call      qword ptr [7FFE3832C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
M01_L13:
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 797
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
       call      qword ptr [7FFE38105B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE37F04000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE385C5EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3810D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1AD558A0008
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
       cmp       dword ptr [7FFE383AF390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFE383E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FFE389F9C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE38A1CED0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```
