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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF8153A4DE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DD39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153A4EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F8D740],0
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
       mov       rdx,19B9FDB52E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,19B9FDA0008
       call      qword ptr [7FF815007C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,19B9FDB5300
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,19B9FDB5320
       mov       [rbp-38],rax
       call      qword ptr [7FF814CD4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DCC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814BA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF8149A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF8150656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814BAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,19B9FDA0008
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81538B0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A4EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF8153A5398]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DD39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153A5458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F8D740],0
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
       mov       rdx,28262C752E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,28262C60008
       call      qword ptr [7FF814FDC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,28262C75300
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,28262C75320
       mov       [rbp-38],rax
       call      qword ptr [7FF814CD4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DCC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814BA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF8149A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815065EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814BAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,28262C60008
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81538B0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A54A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF815374DE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DA39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815374EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F5D740],0
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
       mov       rdx,1FC47BE52E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1FC47BD0008
       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,1FC47BE5300
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,1FC47BE5320
       mov       [rbp-38],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814D9C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814974000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815035EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1FC47BD0008
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81535B0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815374EE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF8153AC018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153AC0D8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
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
       mov       rdx,2DC24AA5308
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2DC24A90008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,2DC24AA5328
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,2DC24AA5348
       mov       [rbp-38],rax
       call      qword ptr [7FF814CB4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2DC24A90008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815388C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153AC120]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF815487288]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815487348]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
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
       mov       rdx,2091B245330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2091B230008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,2091B245350
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,2091B245370
       mov       [rbp-38],rax
       call      qword ptr [7FF814CC4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A7D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2091B230008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815479BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815487390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF815497288]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815497348]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
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
       mov       rdx,18AFC295330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,18AFC280008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,18AFC295350
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,18AFC295370
       mov       [rbp-38],rax
       call      qword ptr [7FF814CC4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A7D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,18AFC280008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154882D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815497390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF8154975E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154976A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
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
       mov       rdx,1E940CB5330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1E940CA0008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,1E940CB5350
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,1E940CB5370
       mov       [rbp-38],rax
       call      qword ptr [7FF814CB4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1E940CA0008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815479C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154976F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,[rbx+198]
       mov       rcx,rsi
       call      qword ptr [7FF8154975E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154976A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
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
       mov       rdx,2F3EC025330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2F3EC010008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rdx,2F3EC025350
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rax,2F3EC025370
       mov       [rbp-38],rax
       call      qword ptr [7FF814CB4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF814A6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2F3EC010008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815478348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154976F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,240040290D8
       call      qword ptr [7FF8153953E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815395458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815395488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,240040352E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,24004020008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815395380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153914A0
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153954D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,24004020008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81537B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153955A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,25072E890D8
       call      qword ptr [7FF8153A4E28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DD39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8153A4EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F8D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8153A4ED0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,25072E952E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,25072E80008
       call      qword ptr [7FF815007C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8153A4DC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153A0EE8
       call      qword ptr [7FF814AF4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153A4F18]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814BA5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF8149A4000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF8150656F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814BAD470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,25072E80008
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
       cmp       dword ptr [7FF814E3F380],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81538B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A4FF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2B7272090D8
       call      qword ptr [7FF8153653E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815365458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815365488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2B7272152E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2B727200008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815365380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153614A0
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153654D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2B727200008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81534B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153655A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,161527F90D8
       call      qword ptr [7FF815394E28]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815394EA0]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815394ED0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,161528052E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,161527F0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815394DC8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF815390EE8
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815394F18]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,161527F0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81537B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815394FF0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2A68A9B90D8
       call      qword ptr [7FF8154672D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DA39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815467348]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F5D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815467378]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2A68A9C5330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2A68A9B0008
       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815467270]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF815463390
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8154673C0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814974000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815035EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2A68A9B0008
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815458AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815467498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,1D13C8F90D8
       call      qword ptr [7FF81549C1F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF81549C270]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF81549C2A0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,1D13C905330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1D13C8F0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF81549C198]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154982B8
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF81549C2E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D13C8F0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815488B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81549C3C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,273083D90D8
       call      qword ptr [7FF8154A7540]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154A75B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154A75E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,273083E5330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,273083D0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154A74E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154A3600
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8154A7630]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,273083D0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81548A530
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A7708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2AD4A3690D8
       call      qword ptr [7FF815487540]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rsi
       call      qword ptr [7FF814DA39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154875B8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F5D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154875E8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2AD4A375330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2AD4A360008
       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154874E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF815483600
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815487630]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814974000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815035EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2AD4A360008
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81546A4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815487708]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,251230D90D8
       call      qword ptr [7FF8153653C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815365458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815365488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,251230E52E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,251230D0008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815365380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153614A0
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153654D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,251230D0008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81534B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153655A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,30AC60590D8
       call      qword ptr [7FF8153653C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815365458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815365488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,30AC60652E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,30AC6050008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815365380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153614A0
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153654D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,30AC6050008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81534B840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153655A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,218FBD090D8
       call      qword ptr [7FF8153853C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815385458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815385488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,218FBD152E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,218FBD00008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815385380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153814A0
       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153854D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,218FBD00008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81536B840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153855A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,21A652D90D8
       call      qword ptr [7FF8153953C8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815395458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF815395488]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,21A652E52E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,21A652D0008
       call      qword ptr [7FF814FF7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF815395380]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8153914A0
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF8153954D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF8150556F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,21A652D0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81537B8B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153955A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,1D6DB1F90D8
       call      qword ptr [7FF8154971F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815497288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154972B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,1D6DB205330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1D6DB1F0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154971B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154932D0
       call      qword ptr [7FF814AE4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815497300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1D6DB1F0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815478AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154973D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,2D91E9F90D8
       call      qword ptr [7FF815477618]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF8154776A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154776D8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,2D91EA05330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2D91E9F0008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154775D0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154736F0
       call      qword ptr [7FF814AB4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815477720]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D91E9F0008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815459958
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154777F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,31923E290D8
       call      qword ptr [7FF8154771F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814DA39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815477288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F5D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154772B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,31923E35330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,31923E20008
       call      qword ptr [7FF814FAC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154771B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154732D0
       call      qword ptr [7FF814AC4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815477300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814974000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815035EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,31923E20008
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815468B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154773D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rdx,22664E590D8
       call      qword ptr [7FF8154871F8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF815487288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       call      qword ptr [7FF8154872B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-20],rdx
       mov       rdx,22664E65330
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,22664E50008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
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
       call      qword ptr [7FF8154871B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
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
       mov       r8,7FF8154832D0
       call      qword ptr [7FF814AD4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF815487300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,22664E50008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815478E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154873D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF8153A5380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8153A5428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E60B30],0
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
       mov       rcx,28734990008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E612B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,246A2C0AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,287349A52E0
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,287349A5300
       mov       [rbp-48],rax
       call      qword ptr [7FF814CD4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E612B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,246A2C0AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81538B070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153A5458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF815374198]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815374240]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E30B30],0
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
       mov       rcx,23F15A60008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE83C0AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,23F15A752C0
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,23F15A752E0
       mov       [rbp-48],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE83C0AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815357650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815374270]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF8153751D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815375278]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E30B30],0
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
       mov       rcx,27ACDE80008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A3C00AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,27ACDE952B8
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,27ACDE952D8
       mov       [rbp-48],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23A3C00AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815359210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153752A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF815385380]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815385428]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E40B30],0
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
       mov       rcx,1E1B3880008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E412B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A12580AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,1E1B38952E0
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1E1B3895300
       mov       [rbp-48],rax
       call      qword ptr [7FF814CB4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E412B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A12580AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81536B070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815385458]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF81544FE10]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF81544FEB8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E40B30],0
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
       mov       rcx,3260FCA0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E412B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E57E00AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,3260FCB5330
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,3260FCB5350
       mov       [rbp-48],rax
       call      qword ptr [7FF814CB4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A6D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E412B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E57E00AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815459550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF81544FEE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF8154775D0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815477678]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E30B30],0
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
       mov       rcx,28E48950008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24DB6C0AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,28E48965330
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,28E48965350
       mov       [rbp-48],rax
       call      qword ptr [7FF814CA4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A5D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814D9C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E312B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24DB6C0AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E1F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E54A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154682E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154776A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF8154B74E0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF8154B7588]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E60B30],0
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
       mov       rcx,26699EC0008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E612B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2260800AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,26699ED5330
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,26699ED5350
       mov       [rbp-48],rax
       call      qword ptr [7FF814CD4270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A8D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814DCC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E612B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2260800AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E4F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E84A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815499700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154B75B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,[rbx+198]
       call      qword ptr [7FF8154670C0]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF815467168]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
; Total bytes of code 48
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF814E20B30],0
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
       mov       rcx,2144A150008
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF814E212B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D3B840AF50
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       mov       rdx,2144A165308
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       ecx,[rbp-1C]
       cmp       ecx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       edx,ecx
       lea       rax,[rax+rdx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,2144A165328
       mov       [rbp-48],rax
       call      qword ptr [7FF814C94270]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF814A4D398]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       mov       rcx,[rbp+10]
       cmp       eax,[rcx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF814E212B0
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D3B840AF50
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 547
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154583D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M02_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815467198]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8153953B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815395458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,255AE8152E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,255AE800008
       call      qword ptr [7FF814FF7C60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,255AE809D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,255AE800008
       call      qword ptr [7FF814FF7A68]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F7DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2151C80BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,255AE8090D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF8150556F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,255AE800008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74528]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81537B298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153954A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF815365200]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8153652A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2149C5052B8
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2149C4F0008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,2149C4F9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2149C4F0008
       call      qword ptr [7FF814F9C2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F4DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D40A80BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AB7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814D8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AB69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AB69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814D8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,2149C4F90D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2149C4F0008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8153493C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153652F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8153953B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815395458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,233E4D452E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,233E4D30008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,233E4D39D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,233E4D30008
       call      qword ptr [7FF814FCC2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F7DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1F353009B60
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,233E4D390D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,233E4D30008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81537B298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153954A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8153653B0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814D939E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815365458]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F4D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,1FCBA8552E0
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,1FCBA840008
       call      qword ptr [7FF814F9C4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,1FCBA849D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1FCBA840008
       call      qword ptr [7FF814F9C2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F4DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1BC2880BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AB7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814D8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AB69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AB69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814D8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814D8C3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,1FCBA8490D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814D8C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814964000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815025EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,1FCBA840008
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
       cmp       dword ptr [7FF814E0F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E44A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF81534B220
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8153654A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF815484DE0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DB39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815484E88]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F6D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2414B5C5330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2414B5B0008
       call      qword ptr [7FF814FBC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,2414B5B9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2414B5B0008
       call      qword ptr [7FF814FBC2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F6DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,200B980BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AD7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AD69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AD69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DAC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DAC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,2414B5B90D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DAC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814984000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815045EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B8D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2414B5B0008
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
       cmp       dword ptr [7FF814E2F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E64A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815459700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815484ED0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8154971E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815497288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2D6B7215330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2D6B7200008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,2D6B7209D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2D6B7200008
       call      qword ptr [7FF814FCC2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F7DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2962540BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,2D6B72090D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2D6B7200008
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
       cmp       dword ptr [7FF814E2F818],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815488490
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154972D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF8154A71E0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF8154A7288]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,2DD40D05330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,2DD40CF0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,2DD40CF9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2DD40CF0008
       call      qword ptr [7FF814FCC2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F7DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,29CB300BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,2DD40CF90D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,2DD40CF0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF8154893A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8154A72D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF815497E40]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, Boolean, Boolean)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF814DC39E8]; System.Text.StringBuilder.ToString()
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,offset MD_DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.String, System.Private.CoreLib]](System.String)
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF815497EE8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon)
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
       cmp       dword ptr [7FF814F7D740],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rdx,172232C5330
       mov       [rsp+20],rdx
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       mov       r9,172232B0008
       call      qword ptr [7FF814FCC4B0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,172232B9D28
       mov       [rsp+20],rcx
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,172232B0008
       call      qword ptr [7FF814FCC2B8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-38],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L09
M01_L03:
       nop
       mov       rcx,7FF814F7DC28
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1319140BB58
       mov       rdx,[rdx]
       mov       [rbp-0B8],rdx
       mov       rdx,[rbp-0B8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE7528]; System.String.IndexOfAny(Char[], Int32)
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF814AE69D0]; System.String.get_Chars(Int32)
       mov       [rbp-0A4],eax
       mov       rcx,[rbp-0A0]
       mov       edx,[rbp-0A4]
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814AE69E8]; System.String.get_Length()
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
       call      qword ptr [7FF814DBC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FF814DBC3D8]; System.Text.StringBuilder.Append(Char)
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
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       mov       rdx,172232B90D8
       cmp       [rcx],ecx
       call      qword ptr [7FF814DBC2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FF814B95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF814994000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF815055EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF814B9D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rax,172232B0008
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
       cmp       dword ptr [7FF814E3F390],0
       je        short M03_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M03_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FF814E74A38]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
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
       mov       rdx,7FF815488518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-20],rax
M03_L02:
       lea       r8,[rbp+20]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF815497F30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       nop
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 146
```

