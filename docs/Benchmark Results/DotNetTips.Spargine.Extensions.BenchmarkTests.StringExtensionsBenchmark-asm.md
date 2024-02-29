## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,1D21F7D0008
       mov       rax,1D21F7E3278
       cmp       qword ptr [rcx+150],0
       cmove     rdx,rax
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 79
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,20034370008
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rsi
       push      rbx
       push      rax
       xor       eax,eax
       mov       [rsp],rax
       mov       rbx,[rcx+150]
       test      rbx,rbx
       jne       short M00_L02
M00_L00:
       mov       rsi,23A16083278
M00_L01:
       mov       [rsp],rsi
       mov       rbx,[rcx+18]
       mov       rdx,[rsp]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,8
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       test      eax,eax
       jne       short M00_L00
       mov       rsi,rbx
       jmp       short M00_L01
; Total bytes of code 83
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,221E42B3278
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,64
       call      qword ptr [7FFE70D4C1C8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       ebx,edx
       xor       ecx,ecx
       mov       [rsp+28],rcx
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L07
M01_L00:
       test      eax,eax
       je        near ptr M01_L08
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L06
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L05
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE7120F3A8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE7120F3A8]
       test      eax,eax
       jne       near ptr M01_L09
M01_L05:
       xor       eax,eax
       cmp       [rsi+8],ebx
       sete      al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        near ptr M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B047B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE70DE62F8]
       mov       rbx,rax
       mov       rcx,24FBE9375F8
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6040]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 327
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFE70D5C210]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdi,rcx
       mov       ebx,edx
       mov       esi,r8d
       xor       eax,eax
       mov       [rsp+28],rax
       test      ebx,ebx
       jl        short M01_L06
       xor       ecx,ecx
       cmp       ebx,esi
       setle     cl
       mov       edx,ecx
       test      ecx,ecx
       je        short M01_L07
M01_L00:
       test      edx,edx
       je        short M01_L08
M01_L01:
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
       cmp       esi,ebx
       setge     al
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L09
M01_L02:
       test      r8d,r8d
       je        near ptr M01_L10
M01_L03:
       test      rdi,rdi
       je        short M01_L05
       mov       eax,[rdi+8]
       cmp       eax,ebx
       jl        near ptr M01_L11
       cmp       eax,esi
       setle     al
       movzx     eax,al
M01_L04:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       xor       ecx,ecx
       mov       edx,ecx
       test      ecx,ecx
       jne       short M01_L00
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE70B147B0]
       mov       ebx,eax
       jmp       short M01_L01
M01_L08:
       call      qword ptr [7FFE70DF62F8]
       mov       rdi,rax
       mov       rcx,2CBA6DEA708
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A67318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DF6040]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70DF65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       byte ptr [rsp+20],0
       je        near ptr M01_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE70B147B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE70DF62F8]
       mov       rbx,rax
       mov       rcx,2CBA6DEA730
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A67318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DF6040]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DF65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70B1D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 363
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,1DB26E73278
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,1DB26E732B0
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,1DB26E60008
       mov       r8,1DB26E68890
       call      qword ptr [7FFE7112DEF0]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE70FD6EB0]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FFE70FD70A8]; System.Text.RegularExpressions.Regex.get_RightToLeft()
       test      eax,eax
       jne       short M00_L02
       mov       rcx,rdi
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1DB26E73278
       call      qword ptr [7FFE70FD7168]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE7114DCB0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rdi
       mov       esi,11
       jmp       short M00_L00
M00_L03:
       xor       ebp,ebp
       jmp       short M00_L01
; Total bytes of code 231
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,1DB26E73320
       cmp       [rcx],ecx
       call      qword ptr [7FFE7099A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFE70DE6148]
       mov       rbx,rax
       test      rsi,rsi
       je        short M01_L01
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rsi,rbx
M01_L02:
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L03
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       short M01_L04
M01_L03:
       mov       eax,1
M01_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      qword ptr [7FFE70DE6430]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6040]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 350
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,0FFFFFFFFFFFFD8F0
       call      qword ptr [7FFE70FD6EF8]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
       nop
       add       rsp,28
       ret
; Total bytes of code 34
```
```assembly
; System.Text.RegularExpressions.Regex.get_RightToLeft()
       xor       eax,eax
       test      byte ptr [rcx+40],40
       setne     al
       ret
; Total bytes of code 10
```
```assembly
; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       [rbp-48],rax
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rbx,r9
       mov       r14d,[rbp+30]
       mov       r15d,[rbp+38]
       mov       r13d,[rbp+40]
       mov       r12d,[rbx+8]
       cmp       r12d,r13d
       jb        near ptr M04_L13
       cmp       r12d,r15d
       jb        near ptr M04_L14
       cmp       [rcx],cl
       lea       rax,[rcx+38]
       xor       edx,edx
       xchg      rdx,[rax]
       test      rdx,rdx
       jne       short M04_L00
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,[rbp+10]
M04_L00:
       mov       [rbp-50],rdx
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FFE7114D2F0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M04_L07
       mov       ecx,r14d
       lea       r12,[rbx+rcx*2+0C]
       mov       rcx,[rbp-50]
       mov       rdx,rcx
       mov       rax,[rbp+10]
       mov       r8,rax
       mov       [rbp-48],r12
       mov       [rbp-40],r15d
       mov       [rsp+20],esi
       mov       rcx,rdx
       mov       rdx,r8
       lea       r8,[rbp-48]
       mov       r9d,r13d
       sub       r9d,r14d
       call      qword ptr [7FFE7114D2D8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      edi,edi
       je        near ptr M04_L05
M04_L01:
       mov       rcx,[rbp-50]
       mov       rax,rcx
       mov       [rbp-48],r12
       mov       [rbp-40],r15d
       mov       rcx,rax
       lea       rdx,[rbp-48]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,[rbp-50]
       mov       r12,[rcx+28]
       mov       rdx,[r12+50]
       cmp       dword ptr [rdx+8],0
       jbe       short M04_L03
       cmp       dword ptr [rdx+10],0
       jle       near ptr M04_L10
       test      esi,esi
       je        near ptr M04_L09
       lea       rcx,[r12+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       rcx,[rbp-50]
       mov       [rcx+28],rdx
       mov       edx,[rcx+4C]
       mov       rcx,r12
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FFE7114DBF0]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FFE70FE26F0
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M04_L11
M04_L05:
       mov       ecx,r15d
       mov       eax,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M04_L06
       xor       ecx,ecx
       mov       eax,0FFFFFFFF
M04_L06:
       mov       rdx,[rbp-50]
       cmp       [rdx+48],ecx
       jne       short M04_L08
       mov       rcx,7FFE70FE26F0
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19A9D000A10
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FFE70BEED00]
       int       3
M04_L08:
       mov       rdx,[rbp-50]
       add       [rdx+4C],eax
       jmp       near ptr M04_L01
M04_L09:
       xor       edx,edx
       mov       [r12+8],rdx
       xor       r12d,r12d
       jmp       near ptr M04_L02
M04_L10:
       xor       edx,edx
       mov       [r12+8],rdx
       test      byte ptr [7FFE70FE2741],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,19A9D000A10
       mov       r12,[rdx]
       jmp       near ptr M04_L02
M04_L12:
       xor       edx,edx
       mov       rcx,[rbp-50]
       mov       [rcx+8],rdx
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r12
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
M04_L13:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFE711DDB30]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE711DDB30]
       int       3
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
       lea       rbp,[rbp+80]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+8],rcx
       mov       r8,[rbp+10]
       lea       rcx,[r8+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
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
; Total bytes of code 684
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,rsi
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       cmp       dword ptr [rax+8],0
       jle       short M00_L02
       cmp       dword ptr [rsi+8],1
       jne       short M00_L00
       xor       eax,eax
       cmp       word ptr [rsi+0C],41
       sete      al
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       eax,eax
       jmp       short M00_L01
; Total bytes of code 71
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE7122F3A8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE7122F3A8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,26BFBC00970
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L02
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70B00180]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 292
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE71244468]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE71244468]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L03
       mov       rdi,[rsi]
       mov       rdx,offset MT_System.Text.ASCIIEncoding+ASCIIEncodingSealed
       cmp       rdi,rdx
       jne       near ptr M02_L06
       lea       rdx,[rbx+0C]
       mov       [rsp+30],rdx
       mov       rbp,[rsp+30]
       mov       r14d,[rbx+8]
       mov       rdx,[rsi+10]
       mov       ecx,r14d
       test      rdx,rdx
       je        near ptr M02_L04
       mov       rax,offset MT_System.Text.EncoderReplacementFallback
       cmp       [rdx],rax
       jne       near ptr M02_L04
       mov       rdx,[rdx+8]
       cmp       dword ptr [rdx+8],1
       jne       near ptr M02_L04
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M02_L07
       cmp       word ptr [rdx+0C],7F
       ja        short M02_L04
M02_L00:
       mov       r15d,ecx
       cmp       ecx,r14d
       jne       near ptr M02_L05
M02_L01:
       xor       edx,edx
       mov       [rsp+30],rdx
M02_L02:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       [rsp+20],r14
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,r14
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       ecx,1763
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C366E8]
       int       3
M02_L04:
       mov       edx,r14d
       mov       rcx,rbp
       call      qword ptr [7FFE70C0C4C8]
       mov       ecx,eax
       jmp       near ptr M02_L00
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,r15d
       call      qword ptr [7FFE70A7C8A0]
       add       eax,r15d
       mov       r15d,eax
       test      r15d,r15d
       jge       near ptr M02_L01
       call      qword ptr [7FFE70A7C7E0]
       int       3
M02_L06:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M02_L02
M02_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 345
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE71244468]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE71244468]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70E06430]
       mov       rcx,rax
       mov       rdx,2AC8DD032E0
       call      qword ptr [7FFE70E06640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,1FDD44009C8
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L02
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70B10180]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFE70E16430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70DA06D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D7C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E16028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E165B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 292
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE711863E8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE711863E8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A873F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L01
       mov       rdi,[rsi]
       mov       r8,offset MT_System.Text.UnicodeEncoding
       cmp       rdi,r8
       jne       near ptr M02_L02
       lea       r8,[rbx+0C]
       mov       [rsp+30],r8
       mov       rdx,[rsp+30]
       mov       r8d,[rbx+8]
       mov       rcx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE70E0B488]; System.Text.UnicodeEncoding.GetByteCount(Char*, Int32, System.Text.EncoderNLS)
       xor       edx,edx
       mov       [rsp+30],rdx
M02_L00:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,1763
       mov       rdx,7FFE70934000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C466E8]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       short M02_L00
; Total bytes of code 200
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE711863E8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE711863E8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70E16430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70E16430]
       mov       rcx,rax
       mov       rdx,23E66553290
       call      qword ptr [7FFE70E16640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E16028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70E165B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A873F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,1A15E4009A0
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L04
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       cmp       dword ptr [rdx+8],20
       jle       near ptr M00_L05
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE70AD0180]; System.Text.Encoding.GetBytes(System.String)
M00_L03:
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D606D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M00_L03
; Total bytes of code 320
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE712267A8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE712267A8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L02
       mov       rdi,[rsi]
       mov       r8,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       rdi,r8
       jne       near ptr M02_L05
       lea       r8,[rbx+0C]
       mov       [rsp+40],r8
       mov       rbp,[rsp+40]
       mov       r14d,[rbx+8]
       lea       r8,[rsp+38]
       lea       r9,[rsp+30]
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FFE70C5D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rbp
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rsp+38]
       cmp       r15,7FFFFFFF
       ja        near ptr M02_L04
       cmp       r9d,r14d
       jne       short M02_L03
M02_L00:
       xor       edx,edx
       mov       [rsp+40],rdx
M02_L01:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,1763
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C066E8]
       int       3
M02_L03:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE70A4C8A0]
       add       eax,r15d
       mov       r15d,eax
       test      r15d,r15d
       jge       near ptr M02_L00
M02_L04:
       call      qword ptr [7FFE70A4C7E0]
       int       3
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M02_L01
; Total bytes of code 303
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE712267A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE712267A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70DD6430]
       mov       rcx,rax
       mov       rdx,1E1F04332E0
       call      qword ptr [7FFE70DD6640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+40]
       mov       rax,[7FFED03F1CD8]
       mov       [rbp+8],rax
       mov       rbx,rcx
       test      [rsp],esp
       sub       rsp,60
       lea       rsi,[rsp+40]
       mov       edi,[rdx+8]
       add       rdx,0C
       mov       [rbp+20],rdx
       mov       r14,[rbp+20]
       cmp       [rbx],bl
       lea       rcx,[rbp+18]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+10]
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,60
       call      qword ptr [7FFED0408CD8]; Precode of System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rax,[rbp+18]
       sub       rax,r14
       mov       rcx,rax
       shr       rcx,3F
       add       rax,rcx
       sar       rax,1
       mov       r15,[rbp+10]
       sub       r15,rsi
       cmp       eax,edi
       jne       short M04_L04
M04_L00:
       xor       eax,eax
       mov       [rbp+20],rax
       test      r15d,r15d
       je        short M04_L03
       movsxd    rcx,r15d
       call      qword ptr [7FFED03FC9E8]
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,r15d
       mov       rdx,rsi
       call      qword ptr [7FFED03FFD10]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M04_L01:
       lea       rcx,[7FFED03F1CD8]
       mov       rcx,[rcx]
       cmp       [rbp+8],rcx
       je        short M04_L02
       call      qword ptr [7FFED03F1D28]; CORINFO_HELP_FAIL_FAST
M04_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L03:
       call      qword ptr [7FFED03F29B0]
       mov       rax,[rax]
       jmp       short M04_L01
M04_L04:
       mov       dword ptr [rsp+20],60
       mov       [rsp+28],eax
       mov       [rsp+30],r15d
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,edi
       mov       r9,rsi
       call      qword ptr [7FFED0408838]
       mov       r15d,eax
       jmp       near ptr M04_L00
; Total bytes of code 269
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,19A358009C0
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L02
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70B00180]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 292
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE71244DF8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE71244DF8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L02
       mov       rdi,[rsi]
       mov       rdx,offset MT_System.Text.Latin1Encoding+Latin1EncodingSealed
       cmp       rdi,rdx
       jne       near ptr M02_L04
       lea       rdx,[rbx+0C]
       mov       [rsp+30],rdx
       mov       rbp,[rsp+30]
       mov       r14d,[rbx+8]
       mov       edx,r14d
       mov       rcx,rbp
       call      qword ptr [7FFE711B53B0]; System.Text.Latin1Utility.GetIndexOfFirstNonLatin1Char_Sse2(Char*, UIntPtr)
       mov       r15d,eax
       cmp       eax,r14d
       je        short M02_L00
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,r15d
       call      qword ptr [7FFE70A7C8A0]; System.Text.Encoding.GetByteCountWithFallback(Char*, Int32, Int32)
       add       r15d,eax
       js        short M02_L03
M02_L00:
       mov       eax,r15d
       xor       edx,edx
       mov       [rsp+30],rdx
M02_L01:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,1763
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C366E8]
       int       3
M02_L03:
       call      qword ptr [7FFE70A7C7E0]
       int       3
M02_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       short M02_L01
; Total bytes of code 249
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE71244DF8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE71244DF8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70E06430]
       mov       rcx,rax
       mov       rdx,1DAC37532E0
       call      qword ptr [7FFE70E06640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,24BED4009D0
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L02
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70AD0180]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D606D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 292
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE711FF3A8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE711FF3A8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L01
       mov       rdi,[rsi]
       mov       r8,offset MT_System.Text.UnicodeEncoding
       cmp       rdi,r8
       jne       near ptr M02_L02
       lea       r8,[rbx+0C]
       mov       [rsp+30],r8
       mov       rdx,[rsp+30]
       mov       r8d,[rbx+8]
       mov       rcx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE70DCB488]; System.Text.UnicodeEncoding.GetByteCount(Char*, Int32, System.Text.EncoderNLS)
       xor       edx,edx
       mov       [rsp+30],rdx
M02_L00:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,1763
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C066E8]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       short M02_L00
; Total bytes of code 200
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE711FF3A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE711FF3A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70DD6430]
       mov       rcx,rax
       mov       rdx,28C7F1D32E0
       call      qword ptr [7FFE70DD6640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,1DD4C0009D8
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L02
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70AE0180]; System.Text.Encoding.GetBytes(System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D706D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 292
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE711FF198]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE711FF198]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L01
       mov       rdi,[rsi]
       mov       r8,offset MT_System.Text.UTF32Encoding
       cmp       rdi,r8
       jne       near ptr M02_L02
       lea       r8,[rbx+0C]
       mov       [rsp+30],r8
       mov       rdx,[rsp+30]
       mov       r8d,[rbx+8]
       mov       rcx,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE7116FBE0]; System.Text.UTF32Encoding.GetByteCount(Char*, Int32, System.Text.EncoderNLS)
       xor       edx,edx
       mov       [rsp+30],rdx
M02_L00:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,1763
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C166E8]
       int       3
M02_L02:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       jmp       short M02_L00
; Total bytes of code 200
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L04
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
M03_L03:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L04:
       call      qword ptr [7FFE711FF198]
       test      eax,eax
       jne       near ptr M03_L16
       jmp       short M03_L03
M03_L05:
       call      qword ptr [7FFE711FF198]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70DE6430]
       mov       rcx,rax
       mov       rdx,21DDDCC32E0
       call      qword ptr [7FFE70DE6640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       mov       rcx,2BAB7C009F0
       mov       rsi,[rcx]
       test      rdx,rdx
       je        short M00_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       eax,eax
M00_L01:
       test      eax,eax
       je        short M00_L04
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rdx,rax
       test      rdx,rdx
       je        short M00_L02
       cmp       dword ptr [rdx+8],20
       jle       near ptr M00_L05
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE70AE0180]; System.Text.Encoding.GetBytes(System.String)
M00_L03:
       mov       [rsp+28],rax
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D706D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L05:
       mov       rcx,rsi
       call      qword ptr [7FFE70C650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M00_L03
; Total bytes of code 320
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE712367A8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE712367A8]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Encoding.GetBytes(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L02
       mov       rdi,[rsi]
       mov       r8,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       rdi,r8
       jne       near ptr M02_L05
       lea       r8,[rbx+0C]
       mov       [rsp+40],r8
       mov       rbp,[rsp+40]
       mov       r14d,[rbx+8]
       lea       r8,[rsp+38]
       lea       r9,[rsp+30]
       mov       rcx,rbp
       mov       edx,r14d
       call      qword ptr [7FFE70C6D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rbp
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rsp+38]
       cmp       r15,7FFFFFFF
       ja        near ptr M02_L04
       cmp       r9d,r14d
       jne       short M02_L03
M02_L00:
       xor       edx,edx
       mov       [rsp+40],rdx
M02_L01:
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       [rsp+20],rbp
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       mov       rax,[rdi+58]
       call      qword ptr [rax+18]
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ecx,1763
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C166E8]
       int       3
M02_L03:
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FFE70A5C8A0]
       add       eax,r15d
       mov       r15d,eax
       test      r15d,r15d
       jge       near ptr M02_L00
M02_L04:
       call      qword ptr [7FFE70A5C7E0]
       int       3
M02_L05:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rdi+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       jmp       near ptr M02_L01
; Total bytes of code 303
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
       je        short M03_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M03_L01
       jmp       near ptr M03_L08
M03_L00:
       xor       edi,edi
       jmp       near ptr M03_L08
M03_L01:
       test      edi,edi
       je        near ptr M03_L09
M03_L02:
       test      dl,dl
       je        near ptr M03_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L03
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L04
M03_L03:
       call      qword ptr [7FFE712367A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L05
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M03_L16
       jmp       short M03_L06
M03_L05:
       call      qword ptr [7FFE712367A8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L06:
       mov       rax,rbx
M03_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L08:
       test      r8,r8
       je        near ptr M03_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M03_L01
       mov       rbx,r8
       jmp       near ptr M03_L02
M03_L09:
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M03_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rsi,rbx
M03_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M03_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M03_L13
M03_L12:
       mov       eax,1
M03_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M03_L14
       call      qword ptr [7FFE70DE6430]
       mov       rcx,rax
       mov       rdx,2FB499132E0
       call      qword ptr [7FFE70DE6640]
M03_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M03_L07
; Total bytes of code 424
```
```assembly
; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+40]
       mov       rax,[7FFED03F1CD8]
       mov       [rbp+8],rax
       mov       rbx,rcx
       test      [rsp],esp
       sub       rsp,60
       lea       rsi,[rsp+40]
       mov       edi,[rdx+8]
       add       rdx,0C
       mov       [rbp+20],rdx
       mov       r14,[rbp+20]
       cmp       [rbx],bl
       lea       rcx,[rbp+18]
       mov       [rsp+20],rcx
       lea       rcx,[rbp+10]
       mov       [rsp+28],rcx
       mov       rcx,r14
       mov       edx,edi
       mov       r8,rsi
       mov       r9d,60
       call      qword ptr [7FFED0408CD8]; Precode of System.Text.Unicode.Utf8Utility.TranscodeToUtf8(Char*, Int32, Byte*, Int32, Char* ByRef, Byte* ByRef)
       mov       rax,[rbp+18]
       sub       rax,r14
       mov       rcx,rax
       shr       rcx,3F
       add       rax,rcx
       sar       rax,1
       mov       r15,[rbp+10]
       sub       r15,rsi
       cmp       eax,edi
       jne       short M04_L04
M04_L00:
       xor       eax,eax
       mov       [rbp+20],rax
       test      r15d,r15d
       je        short M04_L03
       movsxd    rcx,r15d
       call      qword ptr [7FFED03FC9E8]
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       r8d,r15d
       mov       rdx,rsi
       call      qword ptr [7FFED03FFD10]; Precode of System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbx
M04_L01:
       lea       rcx,[7FFED03F1CD8]
       mov       rcx,[rcx]
       cmp       [rbp+8],rcx
       je        short M04_L02
       call      qword ptr [7FFED03F1D28]; CORINFO_HELP_FAIL_FAST
M04_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L03:
       call      qword ptr [7FFED03F29B0]
       mov       rax,[rax]
       jmp       short M04_L01
M04_L04:
       mov       dword ptr [rsp+20],60
       mov       [rsp+28],eax
       mov       [rsp+30],r15d
       mov       dword ptr [rsp+38],1
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,edi
       mov       r9,rsi
       call      qword ptr [7FFED0408838]
       mov       r15d,eax
       jmp       near ptr M04_L00
; Total bytes of code 269
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M00_L09
       call      qword ptr [7FFE70FFC8A0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L00
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        near ptr M00_L13
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,15FBF404A90
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       byte ptr [rdi+8D],0
       je        near ptr M00_L06
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L07
       mov       rdx,[rbp+0B8]
       mov       r8,1A0514F0020
       cmp       rdx,r8
       jne       near ptr M00_L07
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.String>)
       call      qword ptr [7FFE711A7990]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE70D45578]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70D4C6D8]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.String, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       short M00_L08
       jmp       near ptr M00_L04
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FFE70D4F348]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,1A0514F0020
       mov       r8d,1
       call      qword ptr [7FFE70D4ED30]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FFE70A543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L09:
       call      qword ptr [7FFE70DE6A60]
       mov       rcx,1A0514F2730
       mov       rdx,1A0514F0210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A0514F0008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L10
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L11
M00_L10:
       mov       ecx,1
M00_L11:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L12
       call      qword ptr [7FFE70DE6B80]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4CF60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6778]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FFE70DE6B80]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFE70D806D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4CF60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       ecx,3174
       mov       rdx,7FFE70D8A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F26AD8]
       int       3
; Total bytes of code 901
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,15FBF404FF0
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFE70D4F348]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE70D4ED90]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE71167918]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFE70DE6A60]
       mov       rcx,1A0514F2730
       mov       rdx,1A0514F0210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A0514F0008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FFE70DE6B80]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4CF60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6778]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFE70A543F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M02_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M02_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FFE711E5188]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFE711E5188]
       test      eax,eax
       jne       short M02_L04
M02_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M03_L03
       mov       rdx,15FBF401DE8
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE70E647A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M03_L01:
       test      rax,rax
       je        near ptr M03_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M03_L04
M03_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE70E04930]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M03_L01
M03_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE70E04948]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L05
       jmp       short M03_L08
M03_L05:
       mov       ecx,318C
       mov       rdx,7FFE70D8A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F26AF0]
       int       3
M03_L06:
       mov       ecx,318C
       mov       rdx,7FFE70D8A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F26B20]
       int       3
M03_L07:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M03_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE70F95D10]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE70F96DD8]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70E873F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       r13,rax
       mov       [rbp-228],r13
       mov       rcx,rsp
       call      M03_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L10:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M03_L32
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L12
       cmp       rdx,300
       ja        short M03_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L12
M03_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE70B05BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L12:
       mov       rcx,15FBF401DE8
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE70995120
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,r13
       call      qword ptr [7FFE70E57E70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L27
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE70E46AC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE70A5F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M03_L27
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE70E57DF8]
M03_L15:
       mov       rsi,[rax+8]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M03_L17
       call      qword ptr [7FFE710DF360]
       mov       r15d,eax
       jmp       short M03_L18
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L17:
       mov       r15d,r14d
       sar       r15d,10
M03_L18:
       mov       rcx,7FFE70995120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE70995C2C]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       near ptr M03_L25
M03_L19:
       cmp       r14d,[rsi+8]
       jae       short M03_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M03_L21
       test      r10d,r10d
       jne       short M03_L22
       xor       edx,edx
       mov       [rax+14],edx
M03_L20:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L21:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L23
       mov       ecx,1
       jmp       short M03_L26
M03_L22:
       jmp       short M03_L20
M03_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M03_L24
       xor       r14d,r14d
M03_L24:
       inc       r15d
M03_L25:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L19
       xor       ecx,ecx
M03_L26:
       mov       esi,ecx
M03_L27:
       mov       rax,15FBF4005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE70B07678]
       test      esi,ebx
       jne       short M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L28
       mov       ecx,0FFFFFFFF
       jmp       short M03_L29
M03_L28:
       mov       ecx,r12d
M03_L29:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L30
       mov       eax,1
       jmp       short M03_L31
M03_L30:
       xor       eax,eax
M03_L31:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE70D0F360]
M03_L32:
       nop
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
; Total bytes of code 1558
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       vzeroupper
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rax
       mov       [rbp-120],rsp
       mov       r14,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       esi,r9d
       mov       ecx,1
       test      ebx,ebx
       cmovg     ecx,ebx
       mov       ebx,ecx
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M04_L58
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,15FBF401DD8
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE70D114A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M04_L59
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M04_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L60
M04_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M04_L47
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L62
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M04_L05
       cmp       edi,64
       jb        short M04_L04
       mov       rdx,15FBF400290
       mov       r13,[rdx]
M04_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L03
M04_L04:
       cmp       eax,0A
       jb        short M04_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,15FBF400290
       mov       r13,[rdx]
       shl       eax,2
       mov       eax,[r13+rax+10]
       mov       [rcx],eax
       jmp       short M04_L06
M04_L05:
       add       eax,30
       mov       [rcx-2],ax
M04_L06:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
M04_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M04_L08:
       test      eax,eax
       je        near ptr M04_L61
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M04_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M04_L68
       mov       rcx,1A0514F0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M04_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L67
M04_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M04_L44
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L63
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M04_L14
       cmp       ebx,64
       jb        short M04_L13
       mov       rdx,15FBF400290
       mov       r13,[rdx]
M04_L12:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L12
M04_L13:
       cmp       eax,0A
       jb        short M04_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,15FBF400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M04_L15
M04_L14:
       add       eax,30
       mov       [rcx-2],ax
M04_L15:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       eax,1
M04_L16:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M04_L17:
       test      eax,eax
       je        near ptr M04_L69
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M04_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M04_L70
       mov       rcx,1A0514F0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M04_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L66
M04_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M04_L35
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L64
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M04_L23
       cmp       esi,64
       jb        short M04_L22
       mov       rdx,15FBF400290
       mov       r13,[rdx]
M04_L21:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L21
M04_L22:
       cmp       eax,0A
       jb        short M04_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,15FBF400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M04_L24
M04_L23:
       add       eax,30
       mov       [rcx-2],ax
M04_L24:
       xor       ecx,ecx
       mov       [rbp-90],rcx
       mov       eax,1
M04_L25:
       xor       ecx,ecx
       mov       [rbp-90],rcx
M04_L26:
       test      eax,eax
       je        near ptr M04_L71
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M04_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0D0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r12,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      r12,r12
       je        near ptr M04_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-94],eax
       mov       rcx,7FFE70995120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M04_L72
M04_L28:
       xor       eax,eax
       mov       dword ptr [rbp-9C],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-94]
       cmp       edx,r10d
       jbe       near ptr M04_L29
       mov       dword ptr [rbp-98],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M04_L73
       cmp       r10d,edx
       jae       near ptr M04_L93
       mov       [rbp-94],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-100],r9
       mov       r11,[r9]
       mov       [rbp-108],r11
       mov       rcx,r9
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-100]
       mov       [rdx+8],ecx
       mov       rax,[rbp-108]
       test      rax,rax
       mov       [rbp-108],rax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jne       near ptr M04_L74
M04_L29:
       mov       rcx,15FBF4005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M04_L87
M04_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE70A5EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M04_L34
M04_L31:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE70A5EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M04_L57
       mov       rax,[rax]
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L32:
       call      qword ptr [7FFE70B7F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M04_L38
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M04_L39
M04_L34:
       mov       r12,[r14+10]
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FFE70D4C690]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,[rdi+8]
       mov       r11,7FFE70910A00
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70D879E0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0E8],rax
       jmp       near ptr M04_L48
M04_L35:
       test      rcx,rcx
       jne       short M04_L37
       call      qword ptr [7FFE70B7F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L36:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M04_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M04_L46
M04_L37:
       call      qword ptr [7FFE70B7F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M04_L36
M04_L38:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M04_L39:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       ecx,edi
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE712C61D8]
       jmp       near ptr M04_L08
M04_L40:
       call      qword ptr [7FFE70B7F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M04_L43
       xor       r8d,r8d
       xor       r9d,r9d
M04_L42:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-78]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE712C61D8]
       jmp       near ptr M04_L17
M04_L43:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M04_L42
M04_L44:
       test      rcx,rcx
       je        short M04_L40
       call      qword ptr [7FFE70B7F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M04_L41
M04_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M04_L46:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE712C61D8]
       jmp       near ptr M04_L26
M04_L47:
       test      rcx,rcx
       je        near ptr M04_L32
       call      qword ptr [7FFE70B7F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M04_L33
M04_L48:
       jmp       short M04_L51
M04_L49:
       cmp       rdi,rsi
       jne       short M04_L53
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+10]
M04_L50:
       cmp       ebx,[r15+8]
       jae       short M04_L52
       mov       ecx,ebx
       lea       rcx,[r15+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebx
       mov       rax,[rbp-0E8]
M04_L51:
       mov       rdi,[rax]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M04_L54
       mov       rdx,rdi
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C3E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M04_L55
M04_L52:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L53:
       mov       rcx,[rbp-0E8]
       mov       r11,7FFE709109D8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M04_L50
M04_L54:
       mov       rcx,rax
       mov       r11,7FFE709109D0
       call      qword ptr [r11]
M04_L55:
       test      eax,eax
       jne       short M04_L49
       mov       rax,[rbp-0E8]
       test      rax,rax
       je        short M04_L56
       cmp       rdi,rsi
       jne       near ptr M04_L92
       movsx     rcx,byte ptr [rax+8]
M04_L56:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,r15
       mov       r9d,2
       call      qword ptr [7FFE70A5EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M04_L31
M04_L57:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE71325458]
       int       3
M04_L58:
       call      CORINFO_HELP_OVERFLOW
M04_L59:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M04_L01
M04_L60:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE71306058]
       jmp       near ptr M04_L09
M04_L61:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B75938]
       jmp       near ptr M04_L02
M04_L62:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M04_L07
M04_L63:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M04_L16
M04_L64:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M04_L25
M04_L65:
       call      qword ptr [7FFE70BEE9A0]
       int       3
M04_L66:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE71306058]
       jmp       near ptr M04_L27
M04_L67:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE71306058]
       jmp       near ptr M04_L18
M04_L68:
       lea       rcx,[rbp-60]
       mov       rdx,1A0514F0C30
       call      qword ptr [7FFE70B758F0]
       jmp       near ptr M04_L10
M04_L69:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B75938]
       jmp       near ptr M04_L11
M04_L70:
       lea       rcx,[rbp-60]
       mov       rdx,1A0514F0C30
       call      qword ptr [7FFE70B758F0]
       jmp       near ptr M04_L19
M04_L71:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B75938]
       jmp       near ptr M04_L20
M04_L72:
       mov       rcx,r15
       call      qword ptr [7FFE70D0E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M04_L28
M04_L73:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE70E46AC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE70A5F750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M04_L74:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M04_L93
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-98],eax
       jne       short M04_L76
       mov       rcx,r15
       mov       [rbp-94],r10d
       mov       edx,r10d
       call      qword ptr [7FFE70D0E898]
       mov       r9,rax
M04_L75:
       mov       rdx,[r9+8]
       mov       [rbp-110],rdx
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0B8],eax
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0B8]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M04_L77
       call      qword ptr [7FFE710DF360]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M04_L78
M04_L76:
       mov       [rbp-94],r10d
       jmp       short M04_L75
M04_L77:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0B4],edx
M04_L78:
       mov       rcx,7FFE70995120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FFE70995C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M04_L85
M04_L79:
       cmp       eax,[r8+8]
       jae       near ptr M04_L93
       mov       [rbp-0AC],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-118],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0BC],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-118]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-0C0],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L81
       test      r10d,r10d
       jne       short M04_L82
       xor       edx,edx
       mov       [rax+14],edx
M04_L80:
       movsxd    rdx,r10d
       mov       r8,[rbp-108]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M04_L81:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0BC]
       test      ecx,ecx
       je        short M04_L83
       mov       r8d,1
       jmp       short M04_L86
M04_L82:
       jmp       short M04_L80
M04_L83:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-110]
       cmp       [rcx+8],r8d
       jne       short M04_L84
       xor       r8d,r8d
M04_L84:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,r8d
M04_L85:
       mov       r8,[rbp-110]
       mov       [rbp-0B0],edx
       cmp       [r8+8],edx
       jg        near ptr M04_L79
       xor       r8d,r8d
M04_L86:
       mov       eax,r8d
       mov       [rbp-9C],eax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jmp       near ptr M04_L29
M04_L87:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-9C]
       cmp       dword ptr [r12+8],0
       mov       [rbp-94],edx
       mov       [rbp-98],r8d
       mov       [rbp-0F0],r10
       mov       [rbp-9C],eax
       je        near ptr M04_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A0],eax
       mov       edx,[r12+8]
       mov       [rbp-0A4],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-0F0]
       mov       r8d,[rbp-0A0]
       mov       r9d,[rbp-0A4]
       mov       edx,3
       call      qword ptr [7FFE70B07678]
       mov       eax,[rbp-98]
       test      [rbp-9C],eax
       mov       [rbp-98],eax
       jne       near ptr M04_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rbp-0F0]
       mov       [rbp-0F8],rdx
       mov       [rbp-0A8],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rbp-98]
       test      r15d,r15d
       jne       short M04_L88
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,0FFFFFFFF
       jmp       short M04_L89
M04_L88:
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,[rbp-94]
M04_L89:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M04_L90
       mov       eax,1
       jmp       short M04_L91
M04_L90:
       xor       eax,eax
M04_L91:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE70D0F360]
       jmp       near ptr M04_L30
M04_L92:
       mov       rcx,rax
       mov       r11,7FFE709109E0
       call      qword ptr [r11]
       jmp       near ptr M04_L56
M04_L93:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+150]
       cmp       qword ptr [rbp-0E8],0
       je        short M04_L95
       mov       rcx,[rbp-0E8]
       mov       rdi,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M04_L94
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M04_L95
M04_L94:
       mov       r11,7FFE709109E0
       call      qword ptr [r11]
M04_L95:
       nop
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
; Total bytes of code 3300
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       test      rdx,rdx
       je        near ptr M05_L01
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L05
       mov       rsi,rdx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE70B0DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rdi
       mov       r11,7FFE70910A08
       call      qword ptr [r11]
       xor       edx,edx
       test      eax,eax
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M05_L09
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrependIterator`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFE70A54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M05_L10
       mov       rcx,offset MT_System.Linq.Enumerable+AppendPrepend1Iterator`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+30],0
       mov       rdx,rsi
M05_L00:
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FFE70FF6610]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70B0E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       xor       ecx,ecx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE711A7A98]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
M05_L01:
       call      qword ptr [7FFE70DE6A60]
       mov       rcx,1A051504118
       mov       rdx,1A0514F0210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A0514F0008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M05_L02
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M05_L03
M05_L02:
       mov       ecx,1
M05_L03:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M05_L04
       call      qword ptr [7FFE70DE6B80]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4CF60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L04:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6778]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L05:
       call      qword ptr [7FFE70DE6A60]
       mov       rcx,1A0514F7D00
       mov       rdx,1A0514F0210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A0514F0008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M05_L06
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M05_L07
M05_L06:
       mov       ecx,1
M05_L07:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M05_L08
       call      qword ptr [7FFE70DE6B80]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4CF60]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L08:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6778]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L09:
       call      qword ptr [7FFE70DE69E8]
       mov       rbx,rax
       call      qword ptr [7FFE70DE6AC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE6D00]
       mov       rbx,rax
       mov       rcx,1A0514F7868
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FFE70A5F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M05_L10:
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
       jmp       near ptr M05_L00
; Total bytes of code 917
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFED0B45068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M06_L03
       call      qword ptr [7FFED0B49F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M06_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       call      qword ptr [7FFED0B469F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M06_L00
       call      qword ptr [7FFED0B45060]
       cmp       byte ptr [rax+18E],0
       je        short M06_L00
       mov       ecx,2
       call      qword ptr [7FFED0B46948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFED0B49FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M06_L00
       cmp       [rsi+10],rbx
       je        short M06_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M06_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B49198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M06_L00
M06_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFED0B44820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M06_L00
M06_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M06_L04
       call      qword ptr [7FFED0B46A08]
       test      rax,rax
       je        near ptr M06_L00
M06_L04:
       call      qword ptr [7FFED0B484A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M07_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        short M07_L05
M07_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFED0B491F8]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r15,rax
       cmp       byte ptr [rsp+88],0
       jne       near ptr M07_L09
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       near ptr M07_L10
M07_L01:
       mov       rbp,[r15+8]
M07_L02:
       test      dil,dil
       je        short M07_L03
       test      rbp,rbp
       je        short M07_L03
       cmp       byte ptr [rbp+105],2
       jne       short M07_L06
M07_L03:
       test      rbp,rbp
       je        near ptr M07_L11
M07_L04:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED0B49230]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L00
M07_L06:
       mov       rcx,rbp
       call      qword ptr [7FFED0B4A2A0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M07_L03
M07_L07:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FFED0B49208]
       mov       rbp,rax
       jmp       short M07_L02
M07_L08:
       cmp       byte ptr [rsp+80],0
       je        short M07_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFED0B491A8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M07_L03
M07_L09:
       cmp       byte ptr [r15+20],0
       je        short M07_L07
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        near ptr M07_L01
M07_L10:
       call      qword ptr [7FFED0B47188]
       jmp       near ptr M07_L01
M07_L11:
       movzx     edx,byte ptr [rsp+78]
       movzx     ecx,byte ptr [rsp+79]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M07_L04
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFED0B48660]
       int       3
; Total bytes of code 300
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M08_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M08_L02
M08_L01:
       mov       rax,rdx
       ret
M08_L02:
       test      rax,rax
       je        short M08_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L01
       test      rax,rax
       jne       short M08_L00
M08_L03:
       jmp       qword ptr [7FFE70A543A8]
; Total bytes of code 69
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        short M09_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L00
       test      rbx,rbx
       je        short M09_L01
       jmp       short M09_L02
M09_L00:
       test      rbx,rbx
       je        near ptr M09_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L03
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L02:
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L01
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M09_L04
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L03:
       mov       rax,1A0514F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       call      qword ptr [7FFE70BEEF10]
       int       3
; Total bytes of code 204
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
       je        short M10_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M10_L01
       jmp       near ptr M10_L08
M10_L00:
       xor       edi,edi
       jmp       near ptr M10_L08
M10_L01:
       test      edi,edi
       je        near ptr M10_L09
M10_L02:
       test      dl,dl
       je        near ptr M10_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M10_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M10_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M10_L16
       jmp       short M10_L04
M10_L03:
       call      qword ptr [7FFE711E5188]
       test      eax,eax
       jne       near ptr M10_L16
M10_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M10_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M10_L16
       jmp       short M10_L06
M10_L05:
       call      qword ptr [7FFE711E5188]
       test      eax,eax
       jne       near ptr M10_L16
M10_L06:
       mov       rax,rbx
M10_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L08:
       test      r8,r8
       je        near ptr M10_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M10_L01
       mov       rbx,r8
       jmp       near ptr M10_L02
M10_L09:
       call      qword ptr [7FFE70DE6B80]
       mov       rbx,rax
       test      rsi,rsi
       je        short M10_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M10_L10
       jmp       short M10_L11
M10_L10:
       mov       rsi,rbx
M10_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M10_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M10_L13
M10_L12:
       mov       eax,1
M10_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M10_L14
       call      qword ptr [7FFE70DE6B80]
       mov       rcx,rax
       mov       rdx,1A0515041C8
       call      qword ptr [7FFE70DE6D90]
M10_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6778]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70DE6D00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M10_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M10_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        near ptr M00_L07
       call      qword ptr [7FFE70FCECB8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L00
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        near ptr M00_L11
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,20E56804A90
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L12
       cmp       byte ptr [rdi+8D],0
       je        near ptr M00_L06
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L13
       mov       rdx,[rbp+0B8]
       mov       r8,24EE8850020
       cmp       rdx,r8
       jne       near ptr M00_L13
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       near ptr M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.String, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.String>)
       call      qword ptr [7FFE7116E6D0]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rsi,rax
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE70D64AB0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,24EE8850C60
       mov       r8d,1
       call      qword ptr [7FFE70D6C060]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.String, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M00_L14
       jmp       near ptr M00_L04
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FFE70D6EC88]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       call      qword ptr [7FFE70E06310]
       mov       rcx,24EE8852730
       mov       rdx,24EE8850210
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24EE8850008
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L08
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L09
M00_L08:
       mov       ecx,1
M00_L09:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L10
       call      qword ptr [7FFE70E06430]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L10:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L11:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       ecx,3174
       mov       rdx,7FFE70D9A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F36AD8]
       int       3
M00_L13:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,24EE8850020
       mov       r8d,1
       call      qword ptr [7FFE70D6E670]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L14:
       call      qword ptr [7FFE70A743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 925
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,20E56804FF0
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFE70D6EC88]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFE70D6E6D0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE7114EBC8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFE70E06310]
       mov       rcx,24EE8852730
       mov       rdx,24EE8850210
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24EE8850008
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFE70A743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M02_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M02_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FFE712D5A88]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFE712D5A88]
       test      eax,eax
       jne       short M02_L04
M02_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M03_L03
       mov       rdx,20E56801DE8
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFE70E747A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M03_L01:
       test      rax,rax
       je        near ptr M03_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M03_L04
M03_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFE70E244B0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M03_L01
M03_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFE70E244C8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L05
       jmp       short M03_L08
M03_L05:
       mov       ecx,318C
       mov       rdx,7FFE70D9A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F36AF0]
       int       3
M03_L06:
       mov       ecx,318C
       mov       rdx,7FFE70D9A150
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70F36B20]
       int       3
M03_L07:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M03_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FFE70FA5D10]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE70FA6DD8]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70E973F0]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       r13,rax
       mov       [rbp-228],r13
       mov       rcx,rsp
       call      M03_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L10:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M03_L32
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L12
       cmp       rdx,300
       ja        short M03_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L12
M03_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFE70B25BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L12:
       mov       rcx,20E56801DE8
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFE709B5120
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,r13
       call      qword ptr [7FFE70E67E70]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L27
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE70E56AC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFE70A7F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M03_L27
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFE70E67DF8]
M03_L15:
       mov       rsi,[rax+8]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M03_L17
       call      qword ptr [7FFE710D65B0]
       mov       r15d,eax
       jmp       short M03_L18
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L17:
       mov       r15d,r14d
       sar       r15d,10
M03_L18:
       mov       rcx,7FFE709B5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFE709B5C2C]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       near ptr M03_L25
M03_L19:
       cmp       r14d,[rsi+8]
       jae       short M03_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M03_L21
       test      r10d,r10d
       jne       short M03_L22
       xor       edx,edx
       mov       [rax+14],edx
M03_L20:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L21:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L23
       mov       ecx,1
       jmp       short M03_L26
M03_L22:
       jmp       short M03_L20
M03_L23:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M03_L24
       xor       r14d,r14d
M03_L24:
       inc       r15d
M03_L25:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L19
       xor       ecx,ecx
M03_L26:
       mov       esi,ecx
M03_L27:
       mov       rax,20E568005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FFE70B27678]
       test      esi,ebx
       jne       short M03_L32
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L28
       mov       ecx,0FFFFFFFF
       jmp       short M03_L29
M03_L28:
       mov       ecx,r12d
M03_L29:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L30
       mov       eax,1
       jmp       short M03_L31
M03_L30:
       xor       eax,eax
M03_L31:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FFE70D2F360]
M03_L32:
       nop
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
; Total bytes of code 1558
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       vzeroupper
       lea       rbp,[rsp+150]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rax
       mov       [rbp-120],rsp
       mov       r14,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       esi,r9d
       mov       ecx,1
       test      ebx,ebx
       cmovg     ecx,ebx
       mov       ebx,ecx
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M04_L58
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,20E56801DD8
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE70D314A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M04_L59
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M04_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L60
M04_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M04_L47
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L62
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M04_L05
       cmp       edi,64
       jb        short M04_L04
       mov       rdx,20E56800290
       mov       r13,[rdx]
M04_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L03
M04_L04:
       cmp       eax,0A
       jb        short M04_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,20E56800290
       mov       r13,[rdx]
       shl       eax,2
       mov       eax,[r13+rax+10]
       mov       [rcx],eax
       jmp       short M04_L06
M04_L05:
       add       eax,30
       mov       [rcx-2],ax
M04_L06:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
M04_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M04_L08:
       test      eax,eax
       je        near ptr M04_L61
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M04_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M04_L68
       mov       rcx,24EE8850C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M04_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L67
M04_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M04_L44
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L63
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M04_L14
       cmp       ebx,64
       jb        short M04_L13
       mov       rdx,20E56800290
       mov       r13,[rdx]
M04_L12:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L12
M04_L13:
       cmp       eax,0A
       jb        short M04_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,20E56800290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M04_L15
M04_L14:
       add       eax,30
       mov       [rcx-2],ax
M04_L15:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       eax,1
M04_L16:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M04_L17:
       test      eax,eax
       je        near ptr M04_L69
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M04_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M04_L70
       mov       rcx,24EE8850C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M04_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M04_L66
M04_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M04_L35
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFECF9A8578
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M04_L64
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M04_L23
       cmp       esi,64
       jb        short M04_L22
       mov       rdx,20E56800290
       mov       r13,[rdx]
M04_L21:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r13
       shl       eax,2
       mov       eax,[r8+rax+10]
       mov       [rcx],eax
       cmp       edx,64
       mov       eax,edx
       jae       short M04_L21
M04_L22:
       cmp       eax,0A
       jb        short M04_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,20E56800290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M04_L24
M04_L23:
       add       eax,30
       mov       [rcx-2],ax
M04_L24:
       xor       ecx,ecx
       mov       [rbp-90],rcx
       mov       eax,1
M04_L25:
       xor       ecx,ecx
       mov       [rbp-90],rcx
M04_L26:
       test      eax,eax
       je        near ptr M04_L71
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M04_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M04_L65
       mov       rax,[rbp-48]
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0D0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r12,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      r12,r12
       je        near ptr M04_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-94],eax
       mov       rcx,7FFE709B5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M04_L72
M04_L28:
       xor       eax,eax
       mov       dword ptr [rbp-9C],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-94]
       cmp       edx,r10d
       jbe       near ptr M04_L29
       mov       dword ptr [rbp-98],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M04_L73
       cmp       r10d,edx
       jae       near ptr M04_L93
       mov       [rbp-94],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-100],r9
       mov       r11,[r9]
       mov       [rbp-108],r11
       mov       rcx,r9
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-100]
       mov       [rdx+8],ecx
       mov       rax,[rbp-108]
       test      rax,rax
       mov       [rbp-108],rax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jne       near ptr M04_L74
M04_L29:
       mov       rcx,20E568005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M04_L87
M04_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE70A7EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M04_L34
M04_L31:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE70A7EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M04_L57
       mov       rax,[rax]
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L32:
       call      qword ptr [7FFE70B9F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M04_L38
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M04_L39
M04_L34:
       mov       r12,[r14+10]
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FFE70D67BA0]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,[rdi+8]
       mov       r11,7FFE70930910
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70D979E0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0E8],rax
       jmp       near ptr M04_L48
M04_L35:
       test      rcx,rcx
       jne       short M04_L37
       call      qword ptr [7FFE70B9F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L36:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M04_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M04_L46
M04_L37:
       call      qword ptr [7FFE70B9F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M04_L36
M04_L38:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M04_L39:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       ecx,edi
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE7126DAB8]
       jmp       near ptr M04_L08
M04_L40:
       call      qword ptr [7FFE70B9F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M04_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M04_L43
       xor       r8d,r8d
       xor       r9d,r9d
M04_L42:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-78]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE7126DAB8]
       jmp       near ptr M04_L17
M04_L43:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M04_L42
M04_L44:
       test      rcx,rcx
       je        short M04_L40
       call      qword ptr [7FFE70B9F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M04_L41
M04_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M04_L46:
       mov       [rbp-0D0],r8
       mov       [rbp-0C8],r9d
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12d
       lea       rcx,[rbp-88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0D0]
       lea       r9,[rbp-0E0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE7126DAB8]
       jmp       near ptr M04_L26
M04_L47:
       test      rcx,rcx
       je        near ptr M04_L32
       call      qword ptr [7FFE70B9F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M04_L33
M04_L48:
       jmp       short M04_L51
M04_L49:
       cmp       rdi,rsi
       jne       short M04_L53
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+10]
M04_L50:
       cmp       ebx,[r15+8]
       jae       short M04_L52
       mov       ecx,ebx
       lea       rcx,[r15+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebx
       mov       rax,[rbp-0E8]
M04_L51:
       mov       rdi,[rax]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M04_L54
       mov       rdx,rdi
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C5E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M04_L55
M04_L52:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L53:
       mov       rcx,[rbp-0E8]
       mov       r11,7FFE709308E8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M04_L50
M04_L54:
       mov       rcx,rax
       mov       r11,7FFE709308E0
       call      qword ptr [r11]
M04_L55:
       test      eax,eax
       jne       short M04_L49
       mov       rax,[rbp-0E8]
       test      rax,rax
       je        short M04_L56
       cmp       rdi,rsi
       jne       near ptr M04_L92
       movsx     rcx,byte ptr [rax+8]
M04_L56:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,r15
       mov       r9d,2
       call      qword ptr [7FFE70A7EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M04_L31
M04_L57:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE712DD590]
       int       3
M04_L58:
       call      CORINFO_HELP_OVERFLOW
M04_L59:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M04_L01
M04_L60:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE71266280]
       jmp       near ptr M04_L09
M04_L61:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B95938]
       jmp       near ptr M04_L02
M04_L62:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M04_L07
M04_L63:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M04_L16
M04_L64:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M04_L25
M04_L65:
       call      qword ptr [7FFE70C0E9A0]
       int       3
M04_L66:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE71266280]
       jmp       near ptr M04_L27
M04_L67:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE71266280]
       jmp       near ptr M04_L18
M04_L68:
       lea       rcx,[rbp-60]
       mov       rdx,24EE8850C30
       call      qword ptr [7FFE70B958F0]
       jmp       near ptr M04_L10
M04_L69:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B95938]
       jmp       near ptr M04_L11
M04_L70:
       lea       rcx,[rbp-60]
       mov       rdx,24EE8850C30
       call      qword ptr [7FFE70B958F0]
       jmp       near ptr M04_L19
M04_L71:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE70B95938]
       jmp       near ptr M04_L20
M04_L72:
       mov       rcx,r15
       call      qword ptr [7FFE70D2E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M04_L28
M04_L73:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE70E56AC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE70924000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE70A7F750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M04_L74:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M04_L93
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-98],eax
       jne       short M04_L76
       mov       rcx,r15
       mov       [rbp-94],r10d
       mov       edx,r10d
       call      qword ptr [7FFE70D2E898]
       mov       r9,rax
M04_L75:
       mov       rdx,[r9+8]
       mov       [rbp-110],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0B8],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0B8]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M04_L77
       call      qword ptr [7FFE710D65B0]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M04_L78
M04_L76:
       mov       [rbp-94],r10d
       jmp       short M04_L75
M04_L77:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0B4],edx
M04_L78:
       mov       rcx,7FFE709B5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FFE709B5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M04_L85
M04_L79:
       cmp       eax,[r8+8]
       jae       near ptr M04_L93
       mov       [rbp-0AC],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-118],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0BC],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-118]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-0C0],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L81
       test      r10d,r10d
       jne       short M04_L82
       xor       edx,edx
       mov       [rax+14],edx
M04_L80:
       movsxd    rdx,r10d
       mov       r8,[rbp-108]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M04_L81:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0BC]
       test      ecx,ecx
       je        short M04_L83
       mov       r8d,1
       jmp       short M04_L86
M04_L82:
       jmp       short M04_L80
M04_L83:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-110]
       cmp       [rcx+8],r8d
       jne       short M04_L84
       xor       r8d,r8d
M04_L84:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,r8d
M04_L85:
       mov       r8,[rbp-110]
       mov       [rbp-0B0],edx
       cmp       [r8+8],edx
       jg        near ptr M04_L79
       xor       r8d,r8d
M04_L86:
       mov       eax,r8d
       mov       [rbp-9C],eax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jmp       near ptr M04_L29
M04_L87:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-9C]
       cmp       dword ptr [r12+8],0
       mov       [rbp-94],edx
       mov       [rbp-98],r8d
       mov       [rbp-0F0],r10
       mov       [rbp-9C],eax
       je        near ptr M04_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A0],eax
       mov       edx,[r12+8]
       mov       [rbp-0A4],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-0F0]
       mov       r8d,[rbp-0A0]
       mov       r9d,[rbp-0A4]
       mov       edx,3
       call      qword ptr [7FFE70B27678]
       mov       eax,[rbp-98]
       test      [rbp-9C],eax
       mov       [rbp-98],eax
       jne       near ptr M04_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rbp-0F0]
       mov       [rbp-0F8],rdx
       mov       [rbp-0A8],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rbp-98]
       test      r15d,r15d
       jne       short M04_L88
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,0FFFFFFFF
       jmp       short M04_L89
M04_L88:
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,[rbp-94]
M04_L89:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M04_L90
       mov       eax,1
       jmp       short M04_L91
M04_L90:
       xor       eax,eax
M04_L91:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE70D2F360]
       jmp       near ptr M04_L30
M04_L92:
       mov       rcx,rax
       mov       r11,7FFE709308F0
       call      qword ptr [r11]
       jmp       near ptr M04_L56
M04_L93:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+150]
       cmp       qword ptr [rbp-0E8],0
       je        short M04_L95
       mov       rcx,[rbp-0E8]
       mov       rdi,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M04_L94
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M04_L95
M04_L94:
       mov       r11,7FFE709308F0
       call      qword ptr [r11]
M04_L95:
       nop
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
; Total bytes of code 3300
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
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
       mov       rdi,rcx
       mov       r14,rdx
       mov       esi,r8d
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M05_L26
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+10],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[r15+10]
       inc       r13d
       mov       ecx,r13d
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       ecx,eax
       jge       near ptr M05_L03
       mov       [r15+10],ecx
       test      r14,r14
       je        near ptr M05_L27
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+10],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       cmp       r13d,ecx
       jge       short M05_L04
       mov       [r15+10],r13d
M05_L00:
       test      rbx,rbx
       je        near ptr M05_L25
       mov       rcx,20E56805068
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M05_L28
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M05_L28
M05_L01:
       mov       r13,[rbp-40]
M05_L02:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-50],r13
       jmp       short M05_L05
M05_L03:
       mov       [r15+10],eax
       jmp       near ptr M05_L26
M05_L04:
       mov       [r15+10],ecx
       jmp       near ptr M05_L27
M05_L05:
       cmp       [r13],r13b
       lea       rdx,[rdi+0C]
       mov       r12d,[rdi+8]
       test      r12d,r12d
       je        near ptr M05_L18
       mov       r8,[r13+8]
       mov       edi,[r13+18]
       lea       ecx,[rdi+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L16
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M05_L07
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L06:
       add       r12d,edi
       mov       [r13+18],r12d
       jmp       near ptr M05_L18
M05_L07:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M05_L06
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M05_L06
M05_L08:
       add       r15d,1
       jo        near ptr M05_L17
M05_L09:
       mov       rcx,rdi
       mov       rdx,[rcx+10]
       inc       rdx
       mov       rcx,[rcx+8]
       mov       ecx,[rcx+8]
       cmp       rdx,rcx
       jae       short M05_L11
       mov       [rdi+10],rdx
       jmp       short M05_L08
M05_L10:
       add       edi,1
       jo        near ptr M05_L17
       cmp       r15d,edi
       jg        short M05_L12
       jmp       near ptr M05_L20
M05_L11:
       mov       [rdi+10],rcx
       test      r15d,r15d
       jle       near ptr M05_L20
       xor       edi,edi
       mov       r15d,[rbx+8]
       test      r15d,r15d
       jle       near ptr M05_L20
M05_L12:
       mov       ecx,edi
       mov       rcx,[rbx+rcx*8+10]
       test      sil,sil
       je        short M05_L13
       test      rcx,rcx
       je        near ptr M05_L19
       lea       rdx,[rcx+0C]
       mov       r12d,[rcx+8]
       test      r12d,r12d
       je        near ptr M05_L19
       mov       r8,[r13+8]
       mov       eax,[r13+18]
       mov       [rbp-44],eax
       lea       ecx,[rax+r12]
       cmp       ecx,[r8+8]
       ja        near ptr M05_L22
       movsxd    rcx,eax
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jg        short M05_L14
       jmp       near ptr M05_L21
M05_L13:
       mov       rdx,r14
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE70CAC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M05_L10
M05_L14:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L15:
       add       r12d,[rbp-44]
       mov       [r13+18],r12d
       jmp       short M05_L19
M05_L16:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L18
M05_L17:
       call      CORINFO_HELP_OVERFLOW
M05_L18:
       xor       r15d,r15d
       mov       rcx,offset MT_System.ArrayEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       qword ptr [rdi+10],0FFFFFFFFFFFFFFFF
       jmp       near ptr M05_L09
M05_L19:
       mov       rdx,24EE8851C14
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M05_L23
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r13+18],r8d
       jmp       near ptr M05_L10
M05_L20:
       mov       rcx,r13
       call      qword ptr [7FFE70CB8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       short M05_L24
M05_L21:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       near ptr M05_L15
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M05_L15
M05_L22:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M05_L19
M05_L23:
       mov       rcx,r13
       mov       r8d,2
       call      qword ptr [7FFE70CACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M05_L10
M05_L24:
       mov       rcx,rsp
       call      M05_L30
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
M05_L25:
       mov       rax,rdi
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
M05_L26:
       mov       rax,24EE8850008
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
M05_L27:
       mov       r14,24EE8850008
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70FCD770]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M05_L29
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M05_L01
M05_L29:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       near ptr M05_L02
M05_L30:
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
       mov       rcx,20E56805068
       mov       r13,[rcx]
       mov       r12,[r13+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M05_L31
       mov       rbx,[rbp-50]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        short M05_L35
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE70CAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M05_L32
M05_L31:
       mov       rdx,[rbp-50]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rbx,[rbp-50]
       je        short M05_L35
M05_L32:
       cmp       qword ptr [r13+20],0
       jne       short M05_L33
       lea       rcx,[r13+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M05_L35
M05_L33:
       lea       rcx,[r13+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r13+28]
       jg        short M05_L34
       mov       rcx,[r13+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70FCD740]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M05_L35
M05_L34:
       add       r13,2C
       lock dec  dword ptr [r13]
M05_L35:
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
; Total bytes of code 1172
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFED0B45068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M06_L03
       call      qword ptr [7FFED0B49F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M06_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
M06_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       call      qword ptr [7FFED0B469F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M06_L00
       call      qword ptr [7FFED0B45060]
       cmp       byte ptr [rax+18E],0
       je        short M06_L00
       mov       ecx,2
       call      qword ptr [7FFED0B46948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFED0B49FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M06_L00
       cmp       [rsi+10],rbx
       je        short M06_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M06_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFED0B49198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M06_L00
M06_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFED0B44820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M06_L00
M06_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M06_L04
       call      qword ptr [7FFED0B46A08]
       test      rax,rax
       je        near ptr M06_L00
M06_L04:
       call      qword ptr [7FFED0B484A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        short M07_L00
       cmp       dword ptr [rbx+8],0
       je        short M07_L00
       test      rsi,rsi
       je        near ptr M07_L03
       jmp       short M07_L02
M07_L00:
       test      rsi,rsi
       je        short M07_L01
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L01
       mov       rcx,7FFE713D2F0C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L01:
       mov       rcx,7FFE713D2F08
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,24EE8850008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L02:
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M07_L03
       mov       ebp,[rbx+8]
       lea       r14d,[rdi+rbp]
       test      r14d,r14d
       jl        short M07_L04
       mov       rcx,7FFE713D2F18
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,ebp
       lea       rcx,[r14+r8*2+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L03:
       mov       rcx,7FFE713D2F10
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L04:
       mov       rcx,7FFE713D2F14
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE70C0EF10]
       int       3
; Total bytes of code 273
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
       je        short M08_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M08_L01
       jmp       near ptr M08_L08
M08_L00:
       xor       edi,edi
       jmp       near ptr M08_L08
M08_L01:
       test      edi,edi
       je        near ptr M08_L09
M08_L02:
       test      dl,dl
       je        near ptr M08_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M08_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M08_L03
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M08_L16
       jmp       short M08_L04
M08_L03:
       call      qword ptr [7FFE712D5A88]
       test      eax,eax
       jne       near ptr M08_L16
M08_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M08_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M08_L16
       jmp       short M08_L06
M08_L05:
       call      qword ptr [7FFE712D5A88]
       test      eax,eax
       jne       near ptr M08_L16
M08_L06:
       mov       rax,rbx
M08_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L08:
       test      r8,r8
       je        near ptr M08_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M08_L01
       mov       rbx,r8
       jmp       near ptr M08_L02
M08_L09:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       test      rsi,rsi
       je        short M08_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M08_L10
       jmp       short M08_L11
M08_L10:
       mov       rsi,rbx
M08_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M08_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M08_L13
M08_L12:
       mov       eax,1
M08_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M08_L14
       call      qword ptr [7FFE70E06430]
       mov       rcx,rax
       mov       rdx,24EE886BF18
       call      qword ptr [7FFE70E06640]
M08_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M08_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M08_L07
; Total bytes of code 420
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+78],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M09_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        short M09_L05
M09_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FFED0B491F8]; Precode of System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       mov       r15,rax
       cmp       byte ptr [rsp+88],0
       jne       near ptr M09_L09
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       near ptr M09_L10
M09_L01:
       mov       rbp,[r15+8]
M09_L02:
       test      dil,dil
       je        short M09_L03
       test      rbp,rbp
       je        short M09_L03
       cmp       byte ptr [rbp+105],2
       jne       short M09_L06
M09_L03:
       test      rbp,rbp
       je        near ptr M09_L11
M09_L04:
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFED0B49230]; Precode of System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      qword ptr [7FFED0B44FC8]; CORINFO_HELP_ASSIGN_REF
       jmp       short M09_L00
M09_L06:
       mov       rcx,rbp
       call      qword ptr [7FFED0B4A2A0]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M09_L03
M09_L07:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,r15
       call      qword ptr [7FFED0B49208]
       mov       rbp,rax
       jmp       short M09_L02
M09_L08:
       cmp       byte ptr [rsp+80],0
       je        short M09_L03
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFED0B491A8]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       short M09_L03
M09_L09:
       cmp       byte ptr [r15+20],0
       je        short M09_L07
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        near ptr M09_L01
M09_L10:
       call      qword ptr [7FFED0B47188]
       jmp       near ptr M09_L01
M09_L11:
       movzx     edx,byte ptr [rsp+78]
       movzx     ecx,byte ptr [rsp+79]
       cmp       cl,1
       sete      cl
       movzx     ecx,cl
       test      edx,ecx
       je        near ptr M09_L04
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFED0B48660]
       int       3
; Total bytes of code 300
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M10_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M10_L02
M10_L01:
       mov       rax,rdx
       ret
M10_L02:
       test      rax,rax
       je        short M10_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L01
       test      rax,rax
       je        short M10_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L01
       test      rax,rax
       je        short M10_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M10_L01
       test      rax,rax
       jne       short M10_L00
M10_L03:
       lea       rax,[7FFED04098D0]
       jmp       qword ptr [rax]
; Total bytes of code 73
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,18A81763278
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,28C612F3278
       mov       [rsp+8],rdx
       mov       rbx,[rcx+18]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 50
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,291893132C8
       mov       r8,291893132E8
       call      qword ptr [7FFE70D6C120]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
; Total bytes of code 80
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       je        near ptr M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L02
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       edx,edx
M01_L03:
       test      edx,edx
       je        near ptr M01_L07
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L04
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L05
       jmp       short M01_L05
M01_L04:
       xor       edx,edx
M01_L05:
       test      edx,edx
       je        near ptr M01_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE70A775D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE70A775D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70A77240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,0A28
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,0A34
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 745
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromDeflateStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE7113E358]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__23 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE710CCC30]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE7113E040]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromDeflateStringAsync>d__23 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE70A6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE7113E220]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromDeflateStringAsync>d__23.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE710C63A0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE710C63A0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE70BF4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE70BF42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE7113E058]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE70BF4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromZLibStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE7111E358]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__24 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE710ACC30]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE7111E040]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24, DotNetTips.Spargine.Extensions.BenchmarkTests]](<FromZLibStringAsync>d__24 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE70A4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE7111E220]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<FromZLibStringAsync>d__24.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE710A63A0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE710A63A0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE70BD4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE70BD42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE7111E058]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE70BD4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       cmp       dword ptr [rax+8],0
       setg      al
       movzx     eax,al
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 50
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE71204108]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE71204108]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A473F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE70D4C228]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L00
       mov       esi,[rbx+8]
       xor       ecx,ecx
       test      esi,esi
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      esi,esi
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L11
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L05
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE71156370]
       test      eax,eax
       jne       near ptr M01_L12
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE71156370]
       test      eax,eax
       jne       near ptr M01_L12
M01_L05:
       xor       esi,esi
       cmp       dword ptr [rbx+8],0
       jle       near ptr M01_L13
M01_L06:
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L07
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE71156370]
       test      eax,eax
       je        short M01_L09
M01_L08:
       add       esi,1
       jo        short M01_L10
       cmp       [rbx+8],esi
       jle       near ptr M01_L13
       jmp       short M01_L06
M01_L09:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       mov       ecx,317
       mov       rdx,7FFE70D706D8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A573F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       xor       esi,esi
       cmp       dword ptr [rbx+8],0
       jg        near ptr M01_L06
M01_L13:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 460
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,0A
       mov       r8d,3E
       call      qword ptr [7FFE70D3C240]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
       mov       [rbp-48],rsp
       mov       rdi,rcx
       mov       ebx,edx
       mov       esi,r8d
       mov       rcx,1A834405068
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L20
M01_L00:
       mov       r15,[rbp-30]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-30],r8
       mov       [rbp-38],r15
       test      ebx,ebx
       je        short M01_L03
M01_L02:
       mov       r14d,1
       jmp       near ptr M01_L13
M01_L03:
       mov       rax,rdi
       test      rax,rax
       jne       near ptr M01_L08
       call      qword ptr [7FFE70DD6310]
       mov       rcx,1E8C6137D00
       mov       rdx,1E8C6130210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1E8C6130008
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L05
M01_L04:
       mov       ecx,1
M01_L05:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L06
       call      qword ptr [7FFE70DD6430]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rcx,r15
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C7C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L02
M01_L09:
       mov       eax,ebx
       neg       eax
       jns       short M01_L14
       call      qword ptr [7FFE70F34348]
       int       3
M01_L10:
       movzx     edx,si
       mov       rcx,r15
       call      qword ptr [7FFE70C7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L12
M01_L11:
       mov       r8d,[r15+18]
       mov       ecx,r8d
       mov       rdx,[r15+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       short M01_L10
       mov       eax,ecx
       mov       [rdx+rax*2+10],si
       inc       r8d
       mov       [r15+18],r8d
M01_L12:
       add       r14d,1
       jo        short M01_L07
M01_L13:
       mov       eax,ebx
       test      eax,eax
       jl        short M01_L09
M01_L14:
       cmp       r14d,eax
       jle       short M01_L11
       test      ebx,ebx
       jle       short M01_L16
       cmp       [r15],r15b
       test      rdi,rdi
       je        short M01_L16
       lea       rdx,[rdi+0C]
       mov       edi,[rdi+8]
       test      edi,edi
       je        short M01_L16
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       esi,ecx
       lea       ecx,[rsi+rdi]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M01_L18
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jg        short M01_L17
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M01_L15
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
M01_L15:
       add       edi,esi
       mov       [r15+18],edi
M01_L16:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C88140]; System.Text.StringBuilder.ToString()
       mov       [rbp-40],rax
       jmp       short M01_L19
M01_L17:
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L15
M01_L18:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFE70C7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L16
M01_L19:
       mov       rcx,rsp
       call      M01_L22
       nop
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
       mov       rcx,[r14+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70F9D770]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L22:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1A834405068
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,7FFE70F99D28
       cmp       [rdi+18],rcx
       jne       short M01_L23
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE70C7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L27
M01_L25:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L26
       mov       rcx,[rsi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE70F9D740]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L27
M01_L26:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L27:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 932
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       cmp       ecx,100
       jae       short M00_L01
       add       ecx,0FFFFFFD0
       xor       esi,esi
       cmp       ecx,9
       setbe     sil
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFE7122F510]
       xor       esi,esi
       cmp       eax,8
       sete      sil
       jmp       short M00_L00
; Total bytes of code 68
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       cmp       ecx,7F
       ja        short M00_L01
       cmp       ecx,100
       jae       short M00_L02
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       xor       esi,esi
       test      byte ptr [rcx+rax],60
       setne     sil
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFE71175F38]
       xor       esi,esi
       cmp       eax,4
       setbe     sil
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 89
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       cmp       ecx,100
       jae       short M00_L01
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       movzx     eax,byte ptr [rcx+rax]
       and       eax,1F
M00_L00:
       mov       ecx,1
       shlx      ecx,ecx,eax
       test      ecx,11F
       setne     cl
       movzx     ecx,cl
       mov       rax,[rbx+18]
       mov       [rax+4C],cl
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       call      qword ptr [7FFE71146430]
       jmp       short M00_L00
; Total bytes of code 85
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+178]
       cmp       ecx,100
       jae       short M00_L01
       mov       ecx,ecx
       mov       rax,7FFECF9A2BD0
       xor       esi,esi
       test      byte ptr [rcx+rax],80
       setne     sil
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],sil
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L01:
       call      qword ptr [7FFE711562C8]
       mov       esi,eax
       jmp       short M00_L00
; Total bytes of code 71
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFE70D3C2B8]; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,163E1805008
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FC73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70DD6310]
       mov       rcx,1A4736E7D00
       mov       rdx,1A4736E0210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1A4736E0008
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       mov       rcx,2B9B5003018
       mov       rcx,[rcx]
       test      rdx,rdx
       je        short M00_L00
       call      qword ptr [7FFE70FD73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE70DE6310]
       mov       rcx,2FA3EE57D00
       mov       rdx,2FA3EE50210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2FA3EE50008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 345
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFE70FD7168]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE711CE970]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rcx,7FFE712932F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,7FFE712932F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,edi
       lea       r15d,[r14+rbp]
       test      r15d,r15d
       jl        near ptr M02_L04
       mov       rcx,7FFE71293300
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,7FFE712932F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,2FA3EE50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,7FFE712932FC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE70BEEF10]
       int       3
; Total bytes of code 291
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFED0401470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,[rbx+130]
       mov       rcx,1ADA8005018
       mov       rcx,[rcx]
       test      rdx,rdx
       je        short M00_L00
       call      qword ptr [7FFE70FC73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE70DD6310]
       mov       rcx,1EE39E47D00
       mov       rdx,1EE39E40210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1EE39E40008
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 345
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFE70FC7168]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE71205CB0]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L00
       test      rbx,rbx
       je        short M02_L01
       jmp       short M02_L02
M02_L00:
       test      rbx,rbx
       je        near ptr M02_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M02_L03
       mov       rcx,7FFE71277584
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       mov       rcx,7FFE71277588
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L01
       mov       r14d,edi
       lea       r15d,[r14+rbp]
       test      r15d,r15d
       jl        near ptr M02_L04
       mov       rcx,7FFE71277590
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,r15d
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L03:
       mov       rcx,7FFE71277580
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,1EE39E40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rcx,7FFE7127758C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFE70BDEF10]
       int       3
; Total bytes of code 291
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFED0401470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFE70D6C300]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,1EF3FC05020
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FF73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70E06310]
       mov       rcx,22FD1A67D00
       mov       rdx,22FD1A60210
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,22FD1A60008
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+160]
       call      qword ptr [7FFE70D6C330]; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,1C28D005028
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FF73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70E06310]
       mov       rcx,2031ED97D00
       mov       rdx,2031ED90210
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2031ED90008
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+108]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,21131E91F10
       xor       r8d,r8d
       call      qword ptr [7FFE70AF7180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rcx,rax
       call      qword ptr [7FFE70D3C348]; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 71
```
```assembly
; System.Guid.ToString(System.String, System.IFormatProvider)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M01_L00
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M01_L00
       cmp       edi,1
       jne       near ptr M01_L04
       movzx     eax,word ptr [rbx+0C]
       or        eax,20
       cmp       eax,64
       jg        short M01_L05
       cmp       eax,62
       je        near ptr M01_L07
       cmp       eax,64
       jne       near ptr M01_L08
M01_L00:
       mov       ecx,24
M01_L01:
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       lea       rcx,[rbp+0C]
       mov       edx,[rbp+8]
       test      rbx,rbx
       jne       short M01_L03
       xor       r9d,r9d
       xor       r8d,r8d
M01_L02:
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       mov       [rsp+20],r9
       mov       [rsp+28],r8d
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       lea       r9,[rsp+20]
       lea       r8,[rsp+40]
       call      qword ptr [7FFE70C0CF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       lea       r9,[rbx+0C]
       mov       edi,[rbx+8]
       mov       r8d,edi
       jmp       short M01_L02
M01_L04:
       call      qword ptr [7FFE70AF7348]
       int       3
M01_L05:
       cmp       eax,6E
       je        short M01_L06
       cmp       eax,70
       je        short M01_L07
       cmp       eax,78
       jne       short M01_L08
       mov       ecx,44
       jmp       short M01_L01
M01_L06:
       mov       ecx,20
       jmp       near ptr M01_L01
M01_L07:
       mov       ecx,26
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE70AF7348]
       int       3
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,1D0A0005030
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FC73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M02_L00:
       call      qword ptr [7FFE70DD6310]
       mov       rcx,21131E97D00
       mov       rdx,21131E90210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21131E90008
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L02
M02_L01:
       mov       ecx,1
M02_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L03
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+148]
       call      qword ptr [7FFE70D7C360]; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,13DDCC05038
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE710073D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70E16310]
       mov       rcx,17E6ECA7D00
       mov       rdx,17E6ECA0210
       call      qword ptr [7FFE70A86B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,17E6ECA0008
       call      qword ptr [7FFE70A86B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70E16430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D7C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E16028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E165B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E16028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,239AFB03278
       call      qword ptr [7FFE70D6C378]; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,1F91DC03048
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE7100EE08]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70E06310]
       mov       rcx,239AFAF7D00
       mov       rdx,239AFAF0210
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,239AFAF0008
       call      qword ptr [7FFE70A76B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70E06430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A77318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,[rbx+158]
       mov       rcx,2A234405048
       mov       rcx,[rcx]
       test      rdx,rdx
       je        short M00_L00
       call      qword ptr [7FFE70FF73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FFE70DF6310]
       mov       rcx,2E2C62E7D00
       mov       rdx,2E2C62E0210
       call      qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2E2C62E0008
       call      qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FFE70DF6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D25848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D25848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D5C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DF6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DF65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C26670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A67318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DF6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 345
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M01_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M01_L02
       xor       ebx,ebx
M01_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFE70FF7168]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE711DF078]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE70B15B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE70BFEF10]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,2E2C62E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,[7FFED041E6D0]
       test      byte ptr [rax+rcx],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFED0405308]
       test      eax,eax
       jne       short M03_L04
M03_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFED0401470]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 127
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,248C52D3278
       call      qword ptr [7FFE70D5C3C0]; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,20833405058
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FE73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70DF6310]
       mov       rcx,248C52C7D00
       mov       rdx,248C52C0210
       call      qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,248C52C0008
       call      qword ptr [7FFE70A66B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70DF6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D25848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D25848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D5C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DF6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DF65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C26670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A67318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DF6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE70D4C3D8]; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,25431405070
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE710161A8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70DE6310]
       mov       rcx,294C3277D00
       mov       rdx,294C3270210
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,294C3270008
       call      qword ptr [7FFE70A56B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70DE6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D15848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D4C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DE6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DE65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A57318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DE6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FFE70D3C3F0]; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,2305F405060
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE70FC73D8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE70DD6310]
       mov       rcx,270F1347D00
       mov       rdx,270F1340210
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,270F1340008
       call      qword ptr [7FFE70A46B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70DD6430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D05848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D3C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 340
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE70D7C408]; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rdx,20D07805078
       mov       rdx,[rdx]
       mov       [rsp+28],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+28]
       call      qword ptr [7FFE71017480]; System.Text.RegularExpressions.Regex.Match(System.String)
       cmp       dword ptr [rax+30],0
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFE70E16310]
       mov       rcx,24D99547D00
       mov       rdx,24D99540210
       call      qword ptr [7FFE70A86B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24D99540008
       call      qword ptr [7FFE70A86B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L02
M01_L01:
       mov       ecx,1
M01_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFE70E16430]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D45848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D7C8A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70E16028]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70E165B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A87318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E16028]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 351
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+168]
       call      qword ptr [7FFE70D6C438]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L00
       mov       esi,[rbx+8]
       xor       ecx,ecx
       test      esi,esi
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      esi,esi
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L08
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L05
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE71176478]
       test      eax,eax
       jne       near ptr M01_L09
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L13
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE71176478]
       test      eax,eax
       jne       near ptr M01_L09
M01_L05:
       cmp       [rbx],bl
       mov       rdx,185F86675D8
       cmp       rbx,rdx
       je        short M01_L06
       mov       esi,[rbx+8]
       cmp       esi,3
       jl        short M01_L07
       add       esi,0FFFFFFFD
       movsxd    rcx,esi
       lea       rcx,[rbx+rcx*2+0C]
       add       rdx,0C
       mov       r8d,3
       call      qword ptr [7FFE7109E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       test      eax,eax
       je        short M01_L07
M01_L06:
       mov       esi,[rbx+8]
       lea       edi,[rsi-2]
       cmp       esi,edi
       jb        near ptr M01_L10
       test      edi,edi
       je        near ptr M01_L11
       cmp       esi,edi
       je        near ptr M01_L12
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,edi
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[rbx+0C]
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FFE70E06430]
       mov       rdi,rax
       mov       ecx,317
       mov       rdx,7FFE70D906D8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFE70D35848
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFE70D6C8A0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E06028]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE70E065B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70C36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L10:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE70A77258]
       int       3
M01_L11:
       mov       rbx,185F8660008
       jmp       near ptr M01_L07
M01_L12:
       jmp       near ptr M01_L07
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 522
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],4
       mov       rcx,2DB44583278
       xor       edx,edx
       mov       r8,2DB445832A8
       xor       r9d,r9d
       call      qword ptr [7FFE70A56088]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
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
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       mov       r15d,[rbp+30]
       mov       r13d,[rbp+38]
M01_L00:
       cmp       r13d,5
       ja        near ptr M01_L04
       test      rbx,rbx
       je        near ptr M01_L05
       test      rsi,rsi
       je        near ptr M01_L05
       test      r15d,r15d
       jl        near ptr M01_L06
       test      edi,edi
       jl        near ptr M01_L08
       test      r14d,r14d
       jl        near ptr M01_L07
       mov       r8d,[rbx+8]
       sub       r8d,edi
       js        near ptr M01_L11
       mov       ecx,[rsi+8]
       sub       ecx,r14d
       js        near ptr M01_L10
       test      r15d,r15d
       je        near ptr M01_L14
       cmp       rbx,rsi
       je        near ptr M01_L13
M01_L01:
       cmp       r15d,r8d
       mov       r12d,r8d
       cmovle    r12d,r15d
       cmp       r15d,ecx
       cmovg     r15d,ecx
       cmp       r13d,4
       jne       near ptr M01_L15
       mov       r8d,edi
       lea       rcx,[rbx+r8*2+0C]
       mov       r8d,r14d
       lea       r8,[rsi+r8*2+0C]
       mov       edx,r12d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFE70B051D0]; System.SpanHelpers.SequenceCompareTo(Char ByRef, Int32, Char ByRef, Int32)
M01_L02:
       movsxd    r8,edi
       lea       rcx,[rbx+r8*2+0C]
       movsxd    r8,r14d
       lea       r8,[rsi+r8*2+0C]
       mov       edx,r12d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFE7107E298]
M01_L03:
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
M01_L04:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE70BEEC88]
       int       3
M01_L05:
       cmp       rbx,rsi
       je        near ptr M01_L14
       mov       eax,0FFFFFFFF
       mov       ecx,1
       test      rbx,rbx
       cmovne    eax,ecx
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
M01_L06:
       mov       ecx,57
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE71156238]
       int       3
M01_L07:
       mov       rdi,2DB445832E0
       jmp       short M01_L09
M01_L08:
       mov       rdi,2DB44583308
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE70E36EE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE70B0D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rbx,2DB445832E0
       jmp       short M01_L12
M01_L11:
       mov       rbx,2DB44583308
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E36EE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       edi,r14d
       jne       near ptr M01_L01
M01_L14:
       xor       eax,eax
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
M01_L15:
       cmp       r13d,4
       ja        near ptr M01_L02
       mov       eax,r13d
       lea       rcx,[7FFE70AAAED0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE70B94180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       [rsp+20],rsi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       and       r13d,1
       mov       [rsp+38],r13d
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFE71016700]
       jmp       near ptr M01_L03
       mov       rcx,7FFE70995120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29AB24003D8
       mov       rcx,[rcx]
       mov       [rsp+20],rsi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       mov       edx,r13d
       and       edx,1
       mov       [rsp+38],edx
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFE71016700]
       jmp       near ptr M01_L03
; Total bytes of code 713
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],5
       mov       rcx,30C9A4F3278
       xor       edx,edx
       mov       r8,30C9A4F32A8
       xor       r9d,r9d
       call      qword ptr [7FFE70A46088]; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; System.String.Compare(System.String, Int32, System.String, Int32, Int32, System.StringComparison)
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
       mov       rbx,rcx
       mov       edi,edx
       mov       rsi,r8
       mov       r14d,r9d
       mov       r15d,[rbp+30]
       mov       r13d,[rbp+38]
M01_L00:
       cmp       r13d,5
       ja        near ptr M01_L04
       test      rbx,rbx
       je        near ptr M01_L05
       test      rsi,rsi
       je        near ptr M01_L05
       test      r15d,r15d
       jl        near ptr M01_L06
       test      edi,edi
       jl        near ptr M01_L08
       test      r14d,r14d
       jl        near ptr M01_L07
       mov       r8d,[rbx+8]
       sub       r8d,edi
       js        near ptr M01_L11
       mov       ecx,[rsi+8]
       sub       ecx,r14d
       js        near ptr M01_L10
       test      r15d,r15d
       je        near ptr M01_L14
       cmp       rbx,rsi
       je        near ptr M01_L13
M01_L01:
       cmp       r15d,r8d
       mov       r12d,r8d
       cmovle    r12d,r15d
       cmp       r15d,ecx
       cmovg     r15d,ecx
       cmp       r13d,4
       ja        short M01_L02
       mov       ecx,r13d
       lea       rdx,[7FFE70A9ABE0]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M01_L00]
       add       rdx,rax
       jmp       rdx
M01_L02:
       movsxd    r8,edi
       lea       rcx,[rbx+r8*2+0C]
       movsxd    r8,r14d
       lea       r8,[rsi+r8*2+0C]
       mov       edx,r12d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFE7106E298]; System.Globalization.Ordinal.CompareStringIgnoreCase(Char ByRef, Int32, Char ByRef, Int32)
M01_L03:
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
M01_L04:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE70BDEC88]
       int       3
M01_L05:
       cmp       rbx,rsi
       je        near ptr M01_L14
       mov       eax,0FFFFFFFF
       mov       ecx,1
       test      rbx,rbx
       cmovne    eax,ecx
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
M01_L06:
       mov       ecx,57
       mov       rdx,7FFE708F4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r15d
       call      qword ptr [7FFE711461D8]
       int       3
M01_L07:
       mov       rdi,30C9A4F32E0
       jmp       short M01_L09
M01_L08:
       mov       rdi,30C9A4F3308
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE70E26EE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE70AFD470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rbx,30C9A4F32E0
       jmp       short M01_L12
M01_L11:
       mov       rbx,30C9A4F3308
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70E26EE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       edi,r14d
       jne       near ptr M01_L01
M01_L14:
       xor       eax,eax
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
       call      qword ptr [7FFE70B84180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       [rsp+20],rsi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       and       r13d,1
       mov       [rsp+38],r13d
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFE71006700]
       jmp       near ptr M01_L03
       mov       rcx,7FFE70985120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2CC084003D8
       mov       rcx,[rcx]
       mov       [rsp+20],rsi
       mov       [rsp+28],r14d
       mov       [rsp+30],r15d
       mov       edx,r13d
       and       edx,1
       mov       [rsp+38],edx
       mov       rdx,rbx
       mov       r8d,edi
       mov       r9d,r12d
       cmp       [rcx],ecx
       call      qword ptr [7FFE71006700]
       jmp       near ptr M01_L03
       mov       r8d,edi
       lea       rcx,[rbx+r8*2+0C]
       mov       r8d,r14d
       lea       r8,[rsi+r8*2+0C]
       mov       edx,r12d
       mov       r9d,r15d
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7FFE70AF51D0]
; Total bytes of code 699
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_20
       cmp       [rbx],rcx
       jne       short M00_L01
       mov       rcx,[rbx+50]
M00_L00:
       mov       edx,19
       mov       r8d,19
       call      qword ptr [7FFE70D3C4F8]; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       short M00_L00
; Total bytes of code 104
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SubstringTrim(System.String, Int32, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       ebx,edx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M01_L08
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+10],0FFFFFFFF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+10]
       inc       ecx
       mov       rax,[rbp+8]
       mov       eax,[rax+8]
       cmp       ecx,eax
       jge       near ptr M01_L04
       mov       [rbp+10],ecx
       mov       eax,ebx
       neg       eax
       shr       eax,1F
       mov       ecx,ebx
       sar       ecx,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       je        near ptr M01_L09
       mov       ecx,edi
       neg       ecx
       shr       ecx,1F
       mov       eax,edi
       sar       eax,1F
       or        ecx,eax
       cmp       ecx,0FFFFFFFF
       je        near ptr M01_L10
       mov       ebp,[rsi+8]
       mov       ecx,ebp
       sub       ecx,edi
       jo        near ptr M01_L07
       cmp       ecx,ebx
       jle       near ptr M01_L11
       test      edi,edi
       je        near ptr M01_L12
       add       edi,ebx
       jo        near ptr M01_L07
       sub       edi,1
       jo        near ptr M01_L07
M01_L00:
       cmp       ebx,edi
       jg        short M01_L01
       cmp       ebx,ebp
       jae       near ptr M01_L18
       mov       ecx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L13
M01_L01:
       cmp       edi,ebx
       jl        short M01_L02
       cmp       edi,ebp
       jae       near ptr M01_L18
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L06
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L14
M01_L02:
       sub       edi,ebx
       jo        near ptr M01_L07
       add       edi,1
       jo        near ptr M01_L07
       cmp       ebp,edi
       je        near ptr M01_L17
       mov       ecx,ebx
       mov       eax,edi
       add       rcx,rax
       mov       eax,ebp
       cmp       rcx,rax
       ja        near ptr M01_L15
       test      edi,edi
       je        near ptr M01_L16
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       mov       r8d,edi
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       mov       edx,ebx
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFE70AF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r14
M01_L03:
       mov       rax,22A01810008
       test      edi,edi
       cmovne    rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       [rbp+10],eax
       jmp       short M01_L08
M01_L05:
       call      qword ptr [7FFE71146CA0]
       test      eax,eax
       jne       near ptr M01_L13
       jmp       near ptr M01_L01
M01_L06:
       call      qword ptr [7FFE71146CA0]
       test      eax,eax
       jne       near ptr M01_L14
       jmp       near ptr M01_L02
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       rax,22A01810008
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       rcx,22A018143D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6040]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,22A018175F8
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE70DD6040]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rsi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       call      qword ptr [7FFE70B84180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       call      qword ptr [7FFE7111E688]
       mov       rdx,rax
       mov       rcx,22A01823278
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       r8,22A018143D0
       mov       r9,22A018175F8
       call      qword ptr [7FFE70A46C58]
       mov       rbx,rax
       mov       rcx,22A018143D0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70A47318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE70DD6040]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE70DD65B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFE70AFD470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rax,22A01810008
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L13:
       add       ebx,1
       jo        near ptr M01_L07
       jmp       near ptr M01_L00
M01_L14:
       sub       edi,1
       jo        near ptr M01_L07
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFE70A47258]
       int       3
M01_L16:
       mov       rsi,22A01810008
       jmp       near ptr M01_L03
M01_L17:
       jmp       near ptr M01_L03
M01_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 838
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToDeflateStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE711A52A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__63 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE710FFDC8]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE711A4F90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToDeflateStringAsync>d__63 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE70A6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE711A5170]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToDeflateStringAsync>d__63.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE710FD638]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE710FD638]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE70BF4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE70BF42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE711A4FA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE70BF4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTitleCase()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       dword ptr [rcx+10],0FFFFFFFF
       mov       rax,22CFCAC32C8
       mov       [rcx+8],rax
       call      qword ptr [7FFE71008628]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
       call      qword ptr [7FFE70B94180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFE70B6D560]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,22CFCAC32C8
       cmp       [rcx],ecx
       call      qword ptr [7FFE70B9C378]; System.Globalization.TextInfo.ToTitleCase(System.String)
M00_L01:
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       ret
M00_L02:
       mov       rax,22CFCAC32C8
       jmp       short M00_L01
M00_L03:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       short M00_L00
; Total bytes of code 177
```
```assembly
; System.CharEnumerator.MoveNext()
       mov       eax,[rcx+10]
       inc       eax
       mov       rdx,[rcx+8]
       mov       edx,[rdx+8]
       cmp       eax,edx
       jge       short M01_L00
       mov       [rcx+10],eax
       mov       eax,1
       ret
M01_L00:
       mov       [rcx+10],edx
       xor       eax,eax
       ret
; Total bytes of code 31
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],3
       jl        short M02_L02
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L02
       mov       rdx,[rax]
       add       rdx,10
M02_L00:
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1EC6AC00438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1EC6AC00418
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L03
M02_L01:
       add       rsp,28
       ret
M02_L02:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       short M02_L00
M02_L03:
       add       rsp,28
       jmp       qword ptr [7FFE70B94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 124
```
```assembly
; System.Globalization.CultureInfo.get_TextInfo()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       qword ptr [rbx+10],0
       je        short M03_L01
M03_L00:
       mov       rax,[rbx+10]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L01:
       mov       rcx,offset MT_System.Globalization.TextInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FFE70B9C018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
       movzx     ecx,byte ptr [rbx+60]
       mov       [rsi+30],cl
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
; Total bytes of code 79
```
```assembly
; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       [rsp+98],rdx
       mov       rbx,rcx
       mov       rcx,[rsp+98]
       test      rcx,rcx
       je        near ptr M04_L25
       mov       rcx,[rsp+98]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L29
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
       mov       [rsp+40],rsi
       xor       esi,esi
       mov       r8,[rbx+20]
       cmp       dword ptr [r8+8],3
       jl        short M04_L00
       mov       edx,[r8+0C]
       or        edx,200020
       xor       edx,6C006E
       mov       r8d,[r8+0E]
       or        r8d,20
       xor       r8d,2D006C
       or        r8d,edx
       sete      dil
       movzx     edi,dil
       jmp       short M04_L01
M04_L00:
       xor       edi,edi
M04_L01:
       xor       ebp,ebp
       mov       r8,[rsp+98]
       cmp       dword ptr [r8+8],0
       jle       near ptr M04_L24
M04_L02:
       mov       r14,[rsp+98]
       mov       r15d,ebp
       xor       r13d,r13d
       cmp       [r14+8],r15d
       jbe       short M04_L03
       mov       r8d,r15d
       movzx     r13d,word ptr [r14+r8*2+0C]
       lea       r12d,[r13-0D800]
       cmp       r12d,3FF
       jbe       near ptr M04_L30
M04_L03:
       lea       r8,[rsp+38]
       cmp       r13d,10000
       jae       short M04_L04
       mov       edx,1
       jmp       short M04_L05
M04_L04:
       mov       edx,2
M04_L05:
       mov       [r8],edx
       mov       r8d,r13d
       shr       r8d,9
       mov       r12,7FFECF9B1A30
       movzx     r8d,byte ptr [r8+r12]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r14,7FFECF9AAA48
       movzx     r8d,word ptr [r8+r14]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFECF9AE570
       movzx     r8d,byte ptr [r8+r13]
       mov       r15,7FFECF9A2ED0
       movzx     eax,byte ptr [r8+r15]
       and       eax,1F
       mov       [rsp+3C],eax
       cmp       eax,4
       ja        near ptr M04_L46
       test      edi,edi
       jne       near ptr M04_L31
M04_L06:
       mov       r8d,[rsp+38]
       mov       [rsp+20],r8d
       lea       r8,[rsp+98]
       lea       rdx,[rsp+40]
       mov       rcx,rbx
       mov       r9d,ebp
       call      qword ptr [7FFE70B9C3A8]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       lea       ebp,[rax+1]
M04_L07:
       mov       eax,ebp
       xor       r8d,r8d
       cmp       dword ptr [rsp+3C],1
       sete      r8b
       mov       rcx,[rsp+98]
       cmp       [rcx+8],eax
       jle       near ptr M04_L14
M04_L08:
       mov       r10,[rsp+98]
       mov       r9d,ebp
       xor       ecx,ecx
       mov       r11d,[r10+8]
       cmp       r11d,r9d
       jbe       short M04_L09
       mov       ecx,r9d
       movzx     ecx,word ptr [r10+rcx*2+0C]
       lea       edx,[rcx-0D800]
       cmp       edx,3FF
       jbe       near ptr M04_L34
M04_L09:
       lea       rdx,[rsp+38]
       cmp       ecx,10000
       jae       short M04_L10
       mov       r10d,1
       jmp       short M04_L11
M04_L10:
       mov       r10d,2
M04_L11:
       mov       [rdx],r10d
       mov       edx,ecx
       shr       edx,9
       movzx     edx,byte ptr [rdx+r12]
       shl       edx,6
       mov       r10d,ecx
       shr       r10d,3
       and       r10d,3E
       add       edx,r10d
       movzx     edx,word ptr [rdx+r14]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       movzx     ecx,byte ptr [rcx+r13]
       movzx     ecx,byte ptr [rcx+r15]
       and       ecx,1F
       mov       r10d,ecx
       test      r10d,r10d
       je        short M04_L12
       cmp       r10d,1
       jne       short M04_L13
M04_L12:
       cmp       r10d,1
       jne       near ptr M04_L39
       mov       r8d,1
       jmp       near ptr M04_L39
M04_L13:
       cmp       r10d,2
       je        short M04_L12
       cmp       r10d,3
       je        short M04_L12
       cmp       r10d,4
       je        short M04_L12
       mov       rcx,[rsp+98]
       cmp       ebp,[rcx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],27
       je        near ptr M04_L35
       mov       ecx,1
       shlx      ecx,ecx,r10d
       test      ecx,1FFCF800
       je        near ptr M04_L39
M04_L14:
       mov       [rsp+34],eax
       mov       r14d,ebp
       sub       r14d,eax
       test      r14d,r14d
       jle       near ptr M04_L18
       test      r8d,r8d
       je        near ptr M04_L43
       test      rsi,rsi
       jne       short M04_L15
       mov       rdx,[rsp+98]
       test      rdx,rdx
       je        near ptr M04_L25
       mov       rcx,rbx
       call      qword ptr [7FFE711852D8]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
M04_L15:
       mov       r15,[rsp+40]
       cmp       [r15],r15b
       mov       eax,[rsp+34]
       test      eax,eax
       jl        near ptr M04_L26
       test      rsi,rsi
       je        near ptr M04_L41
       mov       r8d,[rsi+8]
       sub       r8d,r14d
       cmp       r8d,eax
       jl        near ptr M04_L28
       movsxd    r8,eax
       lea       rdx,[rsi+r8*2+0C]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[r14+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M04_L42
       cmp       [r8],r8b
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jg        short M04_L16
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       short M04_L17
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M04_L17
M04_L16:
       movsxd    r8,r14d
       add       r8,r8
       call      qword ptr [7FFE70B05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L17:
       add       r14d,r13d
       mov       [r15+18],r14d
M04_L18:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jle       near ptr M04_L23
       mov       ecx,[rsp+38]
       cmp       ecx,2
       jne       near ptr M04_L21
       lea       ecx,[rbp+1]
       mov       r14d,ecx
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       cmp       ebp,[rdx+8]
       jae       near ptr M04_L47
       mov       rdx,[rsp+98]
       mov       eax,ebp
       movzx     edx,word ptr [rdx+rax*2+0C]
       mov       r12d,[rcx+18]
       mov       eax,r12d
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M04_L44
       cmp       eax,[r8+8]
       jae       near ptr M04_L47
       mov       [r8+rax*2+10],dx
       inc       r12d
       mov       [rcx+18],r12d
M04_L19:
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       cmp       r14d,[rdx+8]
       jae       near ptr M04_L47
       mov       rdx,[rsp+98]
       mov       eax,r14d
       movzx     edx,word ptr [rdx+rax*2+0C]
       mov       eax,[rcx+18]
       mov       r8d,eax
       mov       r10,[rcx+8]
       cmp       [r10+8],r8d
       jbe       short M04_L20
       cmp       r8d,[r10+8]
       jae       near ptr M04_L47
       mov       [r10+r8*2+10],dx
       inc       eax
       mov       [rcx+18],eax
       jmp       short M04_L22
M04_L20:
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M04_L22
M04_L21:
       mov       rcx,[rsp+40]
       mov       rax,[rsp+98]
       cmp       ebp,[rax+8]
       jae       near ptr M04_L47
       mov       rax,[rsp+98]
       mov       edx,ebp
       movzx     edx,word ptr [rax+rdx*2+0C]
       mov       r12d,[rcx+18]
       mov       eax,r12d
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M04_L45
       cmp       eax,[r8+8]
       jae       near ptr M04_L47
       mov       [r8+rax*2+10],dx
       lea       eax,[r12+1]
       mov       [rcx+18],eax
       mov       r14d,ebp
M04_L22:
       mov       ebp,r14d
M04_L23:
       inc       ebp
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L02
M04_L24:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C98140]; System.Text.StringBuilder.ToString()
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
M04_L25:
       mov       ecx,16EB
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C166E8]
       int       3
M04_L26:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FFE7118D248]
       int       3
M04_L27:
       mov       ecx,2E5
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE70C166E8]
       int       3
M04_L28:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FFE70904000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE70E366E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE70B0D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L29:
       mov       rax,[rsp+98]
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
M04_L30:
       inc       r15d
       cmp       [r14+8],r15d
       jbe       near ptr M04_L03
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       add       ecx,0FFFF2400
       cmp       ecx,3FF
       ja        near ptr M04_L03
       shl       r12d,0A
       lea       r13d,[r12+rcx+10000]
       jmp       near ptr M04_L03
M04_L31:
       mov       rcx,[rsp+98]
       mov       ecx,[rcx+8]
       dec       ecx
       cmp       ecx,ebp
       jle       near ptr M04_L06
       mov       rcx,[rsp+98]
       cmp       ebp,[rcx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],69
       je        short M04_L32
       mov       rcx,[rsp+98]
       cmp       ebp,[rcx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],49
       jne       near ptr M04_L06
M04_L32:
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],6A
       je        short M04_L33
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],4A
       jne       near ptr M04_L06
M04_L33:
       mov       rcx,[rsp+40]
       mov       rdx,22CFCAC32F0
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C2A0]; System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       near ptr M04_L07
M04_L34:
       inc       r9d
       cmp       r11d,r9d
       jbe       near ptr M04_L09
       movzx     r10d,word ptr [r10+r9*2+0C]
       add       r10d,0FFFF2400
       cmp       r10d,3FF
       ja        near ptr M04_L09
       shl       edx,0A
       lea       ecx,[rdx+r10+10000]
       jmp       near ptr M04_L09
M04_L35:
       inc       ebp
       test      r8d,r8d
       je        short M04_L37
       test      rsi,rsi
       jne       short M04_L36
       mov       [rsp+34],eax
       mov       rcx,rbx
       mov       rdx,[rsp+98]
       call      qword ptr [7FFE70B9C1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L36:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L38
M04_L37:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
M04_L38:
       mov       eax,ebp
       mov       r8d,1
       jmp       short M04_L40
M04_L39:
       add       ebp,[rsp+38]
M04_L40:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L08
       jmp       near ptr M04_L14
M04_L41:
       test      eax,eax
       jne       near ptr M04_L27
       jmp       near ptr M04_L27
M04_L42:
       mov       rcx,r15
       mov       r8d,r14d
       call      qword ptr [7FFE70C8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M04_L18
M04_L43:
       mov       eax,[rsp+34]
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FFE70C8C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L18
M04_L44:
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L19
M04_L45:
       call      qword ptr [7FFE70C8C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r14d,ebp
       jmp       near ptr M04_L22
M04_L46:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FFE70B9C390]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L23
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2038
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_30
       cmp       [rbx],rcx
       jne       short M00_L02
       mov       rsi,[rbx+50]
       mov       rcx,rsi
       call      qword ptr [7FFE70D6E1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M00_L03
M00_L00:
       cmp       [rsi],sil
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       cmp       [rax],al
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFE70A773F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
M00_L01:
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE70D6E1C0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       test      eax,eax
       je        short M00_L00
M00_L03:
       mov       rax,rsi
       jmp       short M00_L01
; Total bytes of code 151
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.IsNullOrEmpty(System.Collections.IEnumerable)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L03
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       eax,[rcx+10]
       inc       eax
       mov       r11,[rcx+8]
       mov       r11d,[r11+8]
       cmp       eax,r11d
       jge       short M01_L00
       mov       [rcx+10],eax
       mov       edx,1
       jmp       short M01_L01
M01_L00:
       mov       [rcx+10],r11d
       xor       edx,edx
M01_L01:
       xor       eax,eax
       test      edx,edx
       sete      al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,rbx
       mov       r11,7FFE70930940
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE70930948
       call      qword ptr [r11]
       mov       edx,eax
       jmp       short M01_L01
; Total bytes of code 165
```
```assembly
; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,[rbx+8]
       lea       ebp,[rdi-1]
       xor       r14d,r14d
       test      sil,1
       je        short M02_L03
       xor       r14d,r14d
       test      edi,edi
       jle       short M02_L03
M02_L00:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L01
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M02_L03
       jmp       short M02_L02
M02_L01:
       call      qword ptr [7FFE7121F3A8]
       test      eax,eax
       je        short M02_L03
M02_L02:
       inc       r14d
       cmp       edi,r14d
       jg        short M02_L00
M02_L03:
       test      sil,2
       je        near ptr M02_L10
       lea       ebp,[rdi-1]
       cmp       ebp,r14d
       jl        short M02_L10
       mov       ecx,ebp
       or        ecx,r14d
       jl        short M02_L07
       cmp       edi,ebp
       jle       short M02_L07
M02_L04:
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L05
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L06
M02_L05:
       call      qword ptr [7FFE7121F3A8]
       test      eax,eax
       je        short M02_L10
M02_L06:
       dec       ebp
       cmp       ebp,r14d
       jge       short M02_L04
       jmp       short M02_L10
M02_L07:
       cmp       ebp,edi
       jae       near ptr M02_L14
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L08
       mov       rax,7FFECF9A2BD0
       test      byte ptr [rcx+rax],80
       je        short M02_L10
       jmp       short M02_L09
M02_L08:
       call      qword ptr [7FFE7121F3A8]
       test      eax,eax
       je        short M02_L10
M02_L09:
       dec       ebp
       cmp       ebp,r14d
       jge       short M02_L07
M02_L10:
       mov       esi,ebp
       sub       esi,r14d
       inc       esi
       cmp       edi,esi
       jne       short M02_L12
       mov       rax,rbx
M02_L11:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L12:
       test      esi,esi
       je        short M02_L13
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,esi
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       edx,r14d
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFE70B25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       jmp       short M02_L11
M02_L13:
       mov       rax,1C0A6C40008
       jmp       short M02_L11
M02_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 317
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToZLibStringAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE711641F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__66 ByRef)
       mov       rax,[rsp+30]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE710DE340]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFE7114FE88]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66, DotNetTips.Spargine.Extensions.BenchmarkTests]](<ToZLibStringAsync>d__66 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFE70A4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE711640C0]; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark+<ToZLibStringAsync>d__66.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFE710D78D0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFE710D78D0]
M03_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE70BD4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFE70BD42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFE7114FEA0]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE70BD4768]
       jmp       short M04_L02
; Total bytes of code 139
```

