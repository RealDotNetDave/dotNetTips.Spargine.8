## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,2364B4D0008
       mov       rax,2364B4EAED8
       cmp       qword ptr [rcx+158],0
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,2B35B610008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rsi
       push      rbx
       push      rax
       xor       eax,eax
       mov       [rsp],rax
       mov       rbx,[rcx+158]
       test      rbx,rbx
       jne       short M00_L02
M00_L00:
       mov       rsi,2480D90AED8
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,2865397AED8
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,64
       call      qword ptr [7FFE8C02C678]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5AD2D8]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE8C5AD2D8]
       test      eax,eax
       jne       near ptr M01_L10
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
       call      qword ptr [7FFE8BD247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE8C0C6508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE8C0C6328]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26B3EC17598
       mov       r8,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE8BC773F0]
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 309
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFE8C02C6C0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
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
       xor       ecx,ecx
       cmp       ebx,esi
       setle     cl
       test      ebx,ebx
       cmovge    eax,ecx
       mov       ecx,eax
       test      eax,eax
       je        short M01_L06
M01_L00:
       test      ecx,ecx
       je        short M01_L07
M01_L01:
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
       cmp       esi,ebx
       setge     al
       mov       edx,eax
       test      eax,eax
       je        near ptr M01_L09
M01_L02:
       test      edx,edx
       je        near ptr M01_L10
M01_L03:
       test      rdi,rdi
       je        short M01_L05
       mov       eax,[rdi+8]
       cmp       eax,ebx
       jl        near ptr M01_L12
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
       cmp       byte ptr [rsp+28],0
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BD247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       short M01_L01
M01_L07:
       call      qword ptr [7FFE8C0C6508]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L08
       call      qword ptr [7FFE8C0C6328]
       mov       rdi,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1A1D082A5D8
       mov       r8,rdi
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       byte ptr [rsp+20],0
       je        near ptr M01_L02
       lea       rcx,[rsp+20]
       call      qword ptr [7FFE8BD247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE8C0C6508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE8C0C6328]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1A1D082A600
       mov       r8,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 318
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,276DED3AED8
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,276DED3AF10
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,276DED20008
       mov       r8,276DED28818
       call      qword ptr [7FFE8C51F390]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE8C354870]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FFE8C354A68]; System.Text.RegularExpressions.Regex.get_RightToLeft()
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
       mov       r9,276DED3AED8
       call      qword ptr [7FFE8C354B28]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C535248]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       sub       rsp,20
       mov       ebx,ecx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_System.Text.RegularExpressions.RegexOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdx,rax
       mov       rcx,276DED3AF80
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BBDA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFE8C0E6448]
       test      rsi,rsi
       je        short M01_L01
       xor       ecx,ecx
       cmp       dword ptr [rsi+8],0
       sete      cl
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rsi,rax
M01_L02:
       test      rsi,rsi
       jne       short M01_L03
       call      qword ptr [7FFE8C0E63A0]
       mov       rsi,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 153
```
```assembly
; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       sub       rsp,28
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,0FFFFFFFFFFFFD8F0
       call      qword ptr [7FFE8C3548B8]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FFE8C40E430]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE8C40E418]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFE8C5351B8]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FFE8C343930
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
       mov       rcx,7FFE8C343930
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2364D00EF80
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FFE8BEEED00]
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
       test      byte ptr [7FFE8C343981],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,2364D00EF80
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
       call      qword ptr [7FFE8C69D560]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE8C69D560]
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C5DD890]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5DD890]
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
       call      qword ptr [7FFE8BCA73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split_WithCount()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,2
       mov       r8d,2
       mov       r9d,2C
       call      qword ptr [7FFE8C05C918]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
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
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
       mov       ebp,r9d
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
       je        near ptr M01_L05
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rdx,rax
       mov       rcx,1D65854AED8
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BBEA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L07
       xor       ecx,ecx
       mov       [rsp+30],rcx
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L09
M01_L02:
       test      eax,eax
       je        near ptr M01_L10
M01_L03:
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bp
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+20],rax
       mov       dword ptr [rsp+28],1
       lea       rdx,[rsp+20]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE8BCA70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L12
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L13
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M01_L04:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      qword ptr [7FFE8C0F65B0]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L06
       call      qword ptr [7FFE8C0F6310]
       mov       rdi,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,1D658537C88
       mov       r8,rdi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE8C0F63D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FFE8C0F6328]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D658538818
       mov       r8,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       byte ptr [rsp+30],0
       je        near ptr M01_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE8BD547B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE8C0F6508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE8C0F6328]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D658534368
       mov       r8,rbx
       call      qword ptr [7FFE8BD5D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE8BEFECD0]
       int       3
M01_L13:
       mov       rcx,7FFE8BBE5120
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,195CA801F50
       mov       rax,[rax]
       jmp       near ptr M01_L04
; Total bytes of code 582
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2950B000970
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C04C9F0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L03
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC97318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_System.Text.ASCIIEncoding+ASCIIEncodingSealed
       cmp       [rbx],rcx
       jne       short M01_L02
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD20180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE8C0E65B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE8C0E6310]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D59CEC7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C0E6520]
       mov       ecx,0AA6
       mov       rdx,7FFE8C01ED80
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
       mov       rdx,7FFE8C01ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,19F548009C8
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C03D050]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L03
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC87318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_System.Text.UnicodeEncoding
       cmp       [rbx],rcx
       jne       short M01_L02
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD10180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE8C0D6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE8C0D6388]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1DFE67B7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C0D6598]
       mov       ecx,0AA6
       mov       rdx,7FFE8C00EC58
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
       mov       rdx,7FFE8C00EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0D6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1C5F60009A0
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C02D050]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L04
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC77318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       [rbx],rcx
       jne       short M01_L03
       mov       rcx,rbx
       test      rdx,rdx
       je        short M01_L02
       cmp       dword ptr [rdx+8],20
       jle       near ptr M01_L07
M01_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD00180]; System.Text.Encoding.GetBytes(System.String)
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L04:
       call      qword ptr [7FFE8C0C6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE8C0C6388]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,20683E87C88
       mov       r8,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE8C0C6598]
       mov       ecx,0AA6
       mov       rdx,7FFE8BFFEC58
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
       mov       rdx,7FFE8BFFEC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0C6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BF450C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 365
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1D845C009C0
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C03C9F0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L03
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC87318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_System.Text.Latin1Encoding+Latin1EncodingSealed
       cmp       [rbx],rcx
       jne       short M01_L02
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD10180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE8C0D65B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE8C0D6310]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,218D7BA7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C0D6520]
       mov       ecx,0AA6
       mov       rdx,7FFE8C00ED80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C00ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0D6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,241300009D0
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C03D050]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L03
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC87318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_System.Text.UnicodeEncoding
       cmp       [rbx],rcx
       jne       short M01_L02
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD10180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE8C0D6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE8C0D6388]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,281BE1A7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C0D6598]
       mov       ecx,0AA6
       mov       rdx,7FFE8C00EC58
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
       mov       rdx,7FFE8C00EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0D6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,259DB8009D8
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C05D050]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rdx,rcx
       test      rdx,rdx
       je        short M01_L00
       mov       ecx,[rdx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      ecx,ecx
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        short M01_L03
       mov       rcx,rdx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
       mov       rdx,rax
       test      rbx,rbx
       je        short M01_L05
       mov       rcx,offset MT_System.Text.UTF32Encoding
       cmp       [rbx],rcx
       jne       short M01_L02
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD30180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29A696C7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C0F6598]
       mov       ecx,0AA6
       mov       rdx,7FFE8C02EC58
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
       mov       rdx,7FFE8C02EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,28287C009F0
       mov       rdx,[rdx]
       call      qword ptr [7FFE8C05D050]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
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
       je        short M01_L05
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
       mov       rcx,rax
       test      rbx,rbx
       je        near ptr M01_L07
       mov       rdx,offset MT_System.Text.UTF8Encoding+UTF8EncodingSealed
       cmp       [rbx],rdx
       jne       short M01_L04
       mov       rax,rbx
       test      rcx,rcx
       je        short M01_L03
       mov       [rsp+40],rcx
       cmp       dword ptr [rcx+8],20
       jle       near ptr M01_L08
M01_L02:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD30180]; System.Text.Encoding.GetBytes(System.String)
M01_L03:
       mov       [rsp+40],rcx
       jmp       short M01_L02
M01_L04:
       mov       [rsp+40],rcx
       mov       rcx,rbx
       mov       rdx,[rsp+40]
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L05:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C319A77C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE8C0F6598]
       mov       ecx,0AA6
       mov       rdx,7FFE8C02EC58
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
       mov       rdx,7FFE8C02EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BF750C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE8BFBC078]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8C047570]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
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
; Total bytes of code 94
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
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
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
       jo        near ptr M01_L58
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1A487401D68
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE8BF50EB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L59
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L60
M01_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M01_L47
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L62
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M01_L05
       cmp       edi,64
       jb        short M01_L04
       mov       rdx,1A487400290
       mov       r13,[rdx]
M01_L03:
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
       jae       short M01_L03
M01_L04:
       cmp       eax,0A
       jb        short M01_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1A487400290
       mov       r13,[rdx]
       shl       eax,2
       mov       eax,[r13+rax+10]
       mov       [rcx],eax
       jmp       short M01_L06
M01_L05:
       add       eax,30
       mov       [rcx-2],ax
M01_L06:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L61
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M01_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L68
       mov       rcx,1E515560C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L67
M01_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M01_L44
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L63
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,1A487400290
       mov       r13,[rdx]
M01_L12:
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
       jae       short M01_L12
M01_L13:
       cmp       eax,0A
       jb        short M01_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1A487400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L15
M01_L14:
       add       eax,30
       mov       [rcx-2],ax
M01_L15:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L69
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M01_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L70
       mov       rcx,1E515560C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L66
M01_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M01_L35
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L64
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,1A487400290
       mov       r13,[rdx]
M01_L21:
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
       jae       short M01_L21
M01_L22:
       cmp       eax,0A
       jb        short M01_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1A487400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L24
M01_L23:
       add       eax,30
       mov       [rcx-2],ax
M01_L24:
       xor       ecx,ecx
       mov       [rbp-90],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rbp-90],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L71
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M01_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
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
       je        near ptr M01_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-94],eax
       mov       rcx,7FFE8BBE5120
       mov       edx,0C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L72
M01_L28:
       xor       eax,eax
       mov       dword ptr [rbp-9C],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-94]
       cmp       edx,r10d
       jbe       near ptr M01_L29
       mov       dword ptr [rbp-98],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M01_L73
       cmp       r10d,edx
       jae       near ptr M01_L93
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
       jne       near ptr M01_L74
M01_L29:
       mov       rcx,1A4874005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L87
M01_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L34
M01_L31:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L57
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
M01_L32:
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L38
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L39
M01_L34:
       mov       r12,[r14+10]
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FFE8C045920]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,[rdi+8]
       mov       r11,7FFE8BB60A48
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8C0362D0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L48
M01_L35:
       test      rcx,rcx
       jne       short M01_L37
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L36:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L46
M01_L37:
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L36
M01_L38:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L39:
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
       call      qword ptr [7FFE8C6676D8]
       jmp       near ptr M01_L08
M01_L40:
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L43
       xor       r8d,r8d
       xor       r9d,r9d
M01_L42:
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
       call      qword ptr [7FFE8C6676D8]
       jmp       near ptr M01_L17
M01_L43:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M01_L42
M01_L44:
       test      rcx,rcx
       je        short M01_L40
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L41
M01_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L46:
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
       call      qword ptr [7FFE8C6676D8]
       jmp       near ptr M01_L26
M01_L47:
       test      rcx,rcx
       je        near ptr M01_L32
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M01_L33
M01_L48:
       jmp       short M01_L51
M01_L49:
       cmp       rdi,rsi
       jne       short M01_L53
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+10]
M01_L50:
       cmp       ebx,[r15+8]
       jae       short M01_L52
       mov       ecx,ebx
       lea       rcx,[r15+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebx
       mov       rax,[rbp-0E8]
M01_L51:
       mov       rdi,[rax]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M01_L54
       mov       rdx,rdi
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF76838]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L55
M01_L52:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L53:
       mov       rcx,[rbp-0E8]
       mov       r11,7FFE8BB60A20
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L50
M01_L54:
       mov       rcx,rax
       mov       r11,7FFE8BB60A18
       call      qword ptr [r11]
M01_L55:
       test      eax,eax
       jne       short M01_L49
       mov       rax,[rbp-0E8]
       test      rax,rax
       je        short M01_L56
       cmp       rdi,rsi
       jne       near ptr M01_L92
       movsx     rcx,byte ptr [rax+8]
M01_L56:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,r15
       mov       r9d,2
       call      qword ptr [7FFE8BCAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M01_L31
M01_L57:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE8C66CF60]
       int       3
M01_L58:
       call      CORINFO_HELP_OVERFLOW
M01_L59:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L60:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE8C66CF18]
       jmp       near ptr M01_L09
M01_L61:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L02
M01_L62:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L63:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L64:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M01_L25
M01_L65:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M01_L66:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE8C66CF18]
       jmp       near ptr M01_L27
M01_L67:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE8C66CF18]
       jmp       near ptr M01_L18
M01_L68:
       lea       rcx,[rbp-60]
       mov       rdx,1E515560C30
       call      qword ptr [7FFE8BE858F0]
       jmp       near ptr M01_L10
M01_L69:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L11
M01_L70:
       lea       rcx,[rbp-60]
       mov       rdx,1E515560C30
       call      qword ptr [7FFE8BE858F0]
       jmp       near ptr M01_L19
M01_L71:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L20
M01_L72:
       mov       rcx,r15
       call      qword ptr [7FFE8BF45F50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L28
M01_L73:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C1371C8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L93
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-98],eax
       jne       short M01_L76
       mov       rcx,r15
       mov       [rbp-94],r10d
       mov       edx,r10d
       call      qword ptr [7FFE8BF45ED8]
       mov       r9,rax
M01_L75:
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
       jne       short M01_L77
       call      qword ptr [7FFE8C4AF5A0]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M01_L78
M01_L76:
       mov       [rbp-94],r10d
       jmp       short M01_L75
M01_L77:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0B4],edx
M01_L78:
       mov       rcx,7FFE8BBE5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FFE8BBE5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L85
M01_L79:
       cmp       eax,[r8+8]
       jae       near ptr M01_L93
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
       jbe       short M01_L81
       test      r10d,r10d
       jne       short M01_L82
       xor       edx,edx
       mov       [rax+14],edx
M01_L80:
       movsxd    rdx,r10d
       mov       r8,[rbp-108]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M01_L81:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0BC]
       test      ecx,ecx
       je        short M01_L83
       mov       r8d,1
       jmp       short M01_L86
M01_L82:
       jmp       short M01_L80
M01_L83:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-110]
       cmp       [rcx+8],r8d
       jne       short M01_L84
       xor       r8d,r8d
M01_L84:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,r8d
M01_L85:
       mov       r8,[rbp-110]
       mov       [rbp-0B0],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L79
       xor       r8d,r8d
M01_L86:
       mov       eax,r8d
       mov       [rbp-9C],eax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jmp       near ptr M01_L29
M01_L87:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-9C]
       cmp       dword ptr [r12+8],0
       mov       [rbp-94],edx
       mov       [rbp-98],r8d
       mov       [rbp-0F0],r10
       mov       [rbp-9C],eax
       je        near ptr M01_L30
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
       call      qword ptr [7FFE8BD57678]
       mov       eax,[rbp-98]
       test      [rbp-9C],eax
       mov       [rbp-98],eax
       jne       near ptr M01_L30
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
       jne       short M01_L88
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L89
M01_L88:
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,[rbp-94]
M01_L89:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L90
       mov       eax,1
       jmp       short M01_L91
M01_L90:
       xor       eax,eax
M01_L91:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE8BF47060]
       jmp       near ptr M01_L30
M01_L92:
       mov       rcx,rax
       mov       r11,7FFE8BB60A28
       call      qword ptr [r11]
       jmp       near ptr M01_L56
M01_L93:
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
       je        short M01_L95
       mov       rcx,[rbp-0E8]
       mov       rdi,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M01_L94
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L95
M01_L94:
       mov       r11,7FFE8BB60A28
       call      qword ptr [r11]
M01_L95:
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
       je        short M02_L01
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L02
       mov       rsi,rdx
       mov       edx,[rsi+8]
       add       edx,1
       jo        short M02_L00
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M02_L03
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       mov       r9d,1
       call      qword ptr [7FFE8BBF7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,rdi
       xor       ecx,ecx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8C5468B0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       call      qword ptr [7FFE8C0E56B0]
       mov       ecx,9DE
       mov       rdx,7FFE8C0392E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF8C928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C0392E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E54A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       call      qword ptr [7FFE8C0E56B0]
       mov       ecx,2C1
       mov       rdx,7FFE8C0392E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF8C928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C0392E8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E54A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 427
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeHash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       xor       edx,edx
       call      qword ptr [7FFE8C03C4E0]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M01_L19
       mov       rdi,offset MT_System.CharEnumerator
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+10],0FFFFFFFF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15d,[r14+10]
       inc       r15d
       mov       ecx,r15d
       mov       rdx,[r14+8]
       mov       r13d,[rdx+8]
       cmp       ecx,r13d
       jge       short M01_L02
       mov       [r14+10],ecx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE8C03C4B0]; DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rbx,rax
       mov       rcx,12C7FC0B888
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L20
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L20
M01_L00:
       mov       r14,[rbp-40]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],r14
       jmp       short M01_L03
M01_L02:
       mov       [r14+10],r13d
       jmp       near ptr M01_L19
M01_L03:
       test      rbx,rbx
       je        near ptr M01_L05
       lea       r13,[rbx+10]
       mov       ebx,[rbx+8]
       xor       r12d,r12d
       test      ebx,ebx
       jle       near ptr M01_L12
M01_L04:
       mov       ecx,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       r8,12C83C00428
       mov       r8,[r8]
       mov       rdx,16D11B2A8A8
       call      qword ptr [7FFE8BEB4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [r14],r14b
       test      rax,rax
       je        near ptr M01_L11
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L11
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M01_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L09
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L10
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L10
M01_L05:
       call      qword ptr [7FFE8C0D6520]
       mov       ecx,0F
       mov       rdx,7FFE8C00ED80
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFE8C00ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE8C0D6310]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rax,rbx
       jmp       near ptr M01_L18
M01_L07:
       mov       rcx,r14
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L11
M01_L08:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE8BC873F0]
       mov       rbx,rax
       jmp       near ptr M01_L17
M01_L09:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       mov       [r14+18],esi
M01_L11:
       inc       r12d
       cmp       r12d,ebx
       jl        near ptr M01_L04
M01_L12:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       cmp       r15d,ecx
       jge       short M01_L13
       mov       [rdi+10],r15d
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L17
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L08
       jmp       short M01_L15
M01_L13:
       mov       [rdi+10],ecx
       jmp       near ptr M01_L06
M01_L14:
       call      qword ptr [7FFE8C686640]
       test      eax,eax
       jne       near ptr M01_L08
M01_L15:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L16
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L08
       jmp       short M01_L17
M01_L16:
       call      qword ptr [7FFE8C686640]
       test      eax,eax
       jne       near ptr M01_L08
M01_L17:
       mov       rax,rbx
M01_L18:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L22
       nop
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
M01_L19:
       mov       rax,16D11B20008
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
M01_L20:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2DEFD0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L00
M01_L21:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L22:
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
       mov       rcx,12C7FC0B888
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L23
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L27
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE8BF7C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L24
M01_L23:
       mov       r14,[rbp-48]
       mov       rdx,r14
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L27
M01_L24:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L25
       lea       rcx,[rsi+20]
       mov       rdx,r14
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
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2DEFA0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L27
M01_L26:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L27:
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
; Total bytes of code 1095
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeSHA256Hash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE8C03CB58]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       mov       [rsp+80],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L03
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rsi+10]
       inc       eax
       mov       r8,[rsi+8]
       mov       r8d,[r8+8]
       cmp       eax,r8d
       jge       near ptr M01_L02
       mov       [rsi+10],eax
       mov       r8,1B4BAC009F0
       mov       rdi,[r8]
       mov       ebp,[rbx+8]
       cmp       ebp,20
       jle       near ptr M01_L04
       lea       r8,[rbx+0C]
       mov       [rsp+80],r8
       mov       rsi,[rsp+80]
       mov       r14d,ebp
       lea       r8,[rsp+78]
       lea       r9,[rsp+70]
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFE8BF5D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rsi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rsp+78]
       cmp       r15,7FFFFFFF
       ja        near ptr M01_L06
       cmp       r9d,r14d
       jne       near ptr M01_L05
M01_L00:
       xor       edx,edx
       mov       [rsp+80],rdx
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsp+20],rsi
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,ebp
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE8BEC8A10]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L07
       lea       rdi,[rsi+10]
       mov       ebx,[rsi+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L08
       xor       ecx,ecx
       mov       [rsp+58],rdi
       mov       [rsp+60],ebx
       mov       [rsp+48],rcx
       xor       ecx,ecx
       mov       [rsp+50],ecx
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       lea       rdx,[rsp+68]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+48]
       mov       rcx,1F54CB2A6D8
       xor       r9d,r9d
       call      qword ptr [7FFE8C30D668]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,rsi
       call      qword ptr [7FFE8C30D050]; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       nop
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       [rsi+10],r8d
M01_L03:
       mov       rax,1F54CB20008
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFE8BF550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r14d
       call      qword ptr [7FFE8BC8C8A0]
       add       r15d,eax
       jns       near ptr M01_L00
M01_L06:
       call      qword ptr [7FFE8BC8C7E0]
       int       3
M01_L07:
       mov       ecx,6A61
       mov       rdx,7FFE8C071CB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C684168]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFE8C071CB0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 658
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       mov       rcx,rbx
       mov       edx,0A
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE8C054B88]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,2368F270C60
       mov       r8d,1
       call      qword ptr [7FFE8C05CB70]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
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
; Total bytes of code 110
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
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
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
       jo        near ptr M01_L58
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1F5FD401DD8
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE8C01EA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L59
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L60
M01_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M01_L47
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L62
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M01_L05
       cmp       edi,64
       jb        short M01_L04
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
M01_L03:
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
       jae       short M01_L03
M01_L04:
       cmp       eax,0A
       jb        short M01_L05
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
       shl       eax,2
       mov       eax,[r13+rax+10]
       mov       [rcx],eax
       jmp       short M01_L06
M01_L05:
       add       eax,30
       mov       [rcx-2],ax
M01_L06:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rbp-70],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L61
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M01_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L68
       mov       rcx,2368F270C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L67
M01_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M01_L44
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L63
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
M01_L12:
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
       jae       short M01_L12
M01_L13:
       cmp       eax,0A
       jb        short M01_L14
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L15
M01_L14:
       add       eax,30
       mov       [rcx-2],ax
M01_L15:
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L69
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M01_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L70
       mov       rcx,2368F270C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L66
M01_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M01_L35
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFEE9E585C8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L64
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
M01_L21:
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
       jae       short M01_L21
M01_L22:
       cmp       eax,0A
       jb        short M01_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       rdx,1F5FD400290
       mov       r13,[rdx]
       mov       rdx,r13
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L24
M01_L23:
       add       eax,30
       mov       [rcx-2],ax
M01_L24:
       xor       ecx,ecx
       mov       [rbp-90],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rbp-90],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L71
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M01_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L65
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
       je        near ptr M01_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-94],eax
       mov       rcx,7FFE8BBE5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L72
M01_L28:
       xor       eax,eax
       mov       dword ptr [rbp-9C],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-94]
       cmp       edx,r10d
       jbe       near ptr M01_L29
       mov       dword ptr [rbp-98],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M01_L73
       cmp       r10d,edx
       jae       near ptr M01_L93
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
       jne       near ptr M01_L74
M01_L29:
       mov       rcx,1F5FD4005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L87
M01_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L34
M01_L31:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L57
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
M01_L32:
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L38
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L39
M01_L34:
       mov       r12,[r14+10]
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,esi
       call      qword ptr [7FFE8C057CD8]; DotNetTips.Spargine.Tester.RandomData.GenerateWords(Int32, Int32, Int32)
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,[rdi+8]
       mov       r11,7FFE8BB60A88
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8C02E8F0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L48
M01_L35:
       test      rcx,rcx
       jne       short M01_L37
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L36:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L46
M01_L37:
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L36
M01_L38:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L39:
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
       call      qword ptr [7FFE8C5DC720]
       jmp       near ptr M01_L08
M01_L40:
       call      qword ptr [7FFE8BE8F348]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L43
       xor       r8d,r8d
       xor       r9d,r9d
M01_L42:
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
       call      qword ptr [7FFE8C5DC720]
       jmp       near ptr M01_L17
M01_L43:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M01_L42
M01_L44:
       test      rcx,rcx
       je        short M01_L40
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L41
M01_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L46:
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
       call      qword ptr [7FFE8C5DC720]
       jmp       near ptr M01_L26
M01_L47:
       test      rcx,rcx
       je        near ptr M01_L32
       call      qword ptr [7FFE8BE8F8A0]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M01_L33
M01_L48:
       jmp       short M01_L51
M01_L49:
       cmp       rdi,rsi
       jne       short M01_L53
       mov       rax,[rbp-0E8]
       mov       rdx,[rax+10]
M01_L50:
       cmp       ebx,[r15+8]
       jae       short M01_L52
       mov       ecx,ebx
       lea       rcx,[r15+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebx
       mov       rax,[rbp-0E8]
M01_L51:
       mov       rdi,[rax]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M01_L54
       mov       rdx,rdi
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L55
M01_L52:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L53:
       mov       rcx,[rbp-0E8]
       mov       r11,7FFE8BB60A60
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L50
M01_L54:
       mov       rcx,rax
       mov       r11,7FFE8BB60A58
       call      qword ptr [r11]
M01_L55:
       test      eax,eax
       jne       short M01_L49
       mov       rax,[rbp-0E8]
       test      rax,rax
       je        short M01_L56
       cmp       rdi,rsi
       jne       near ptr M01_L92
       movsx     rcx,byte ptr [rax+8]
M01_L56:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,r15
       mov       r9d,2
       call      qword ptr [7FFE8BCAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M01_L31
M01_L57:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE8C5DDFB0]
       int       3
M01_L58:
       call      CORINFO_HELP_OVERFLOW
M01_L59:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L60:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFE8C5DDF50]
       jmp       near ptr M01_L09
M01_L61:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L02
M01_L62:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L63:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L64:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M01_L25
M01_L65:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M01_L66:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE8C5DDF50]
       jmp       near ptr M01_L27
M01_L67:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE8C5DDF50]
       jmp       near ptr M01_L18
M01_L68:
       lea       rcx,[rbp-60]
       mov       rdx,2368F270C30
       call      qword ptr [7FFE8BE858F0]
       jmp       near ptr M01_L10
M01_L69:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L11
M01_L70:
       lea       rcx,[rbp-60]
       mov       rdx,2368F270C30
       call      qword ptr [7FFE8BE858F0]
       jmp       near ptr M01_L19
M01_L71:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85938]
       jmp       near ptr M01_L20
M01_L72:
       mov       rcx,r15
       call      qword ptr [7FFE8C00E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L28
M01_L73:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C156AC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L93
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-98],eax
       jne       short M01_L76
       mov       rcx,r15
       mov       [rbp-94],r10d
       mov       edx,r10d
       call      qword ptr [7FFE8C00E898]
       mov       r9,rax
M01_L75:
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
       jne       short M01_L77
       call      qword ptr [7FFE8C4A7990]
       mov       edx,eax
       mov       [rbp-0B4],edx
       jmp       short M01_L78
M01_L76:
       mov       [rbp-94],r10d
       jmp       short M01_L75
M01_L77:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0B4],edx
M01_L78:
       mov       rcx,7FFE8BBE5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0B4]
       xor       edx,edx
       div       dword ptr [7FFE8BBE5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L85
M01_L79:
       cmp       eax,[r8+8]
       jae       near ptr M01_L93
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
       jbe       short M01_L81
       test      r10d,r10d
       jne       short M01_L82
       xor       edx,edx
       mov       [rax+14],edx
M01_L80:
       movsxd    rdx,r10d
       mov       r8,[rbp-108]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C0]
       inc       ecx
       mov       rax,[rbp-118]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0BC],1
M01_L81:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0BC]
       test      ecx,ecx
       je        short M01_L83
       mov       r8d,1
       jmp       short M01_L86
M01_L82:
       jmp       short M01_L80
M01_L83:
       mov       eax,[rbp-0AC]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-110]
       cmp       [rcx+8],r8d
       jne       short M01_L84
       xor       r8d,r8d
M01_L84:
       mov       edx,[rbp-0B0]
       inc       edx
       mov       eax,r8d
M01_L85:
       mov       r8,[rbp-110]
       mov       [rbp-0B0],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L79
       xor       r8d,r8d
M01_L86:
       mov       eax,r8d
       mov       [rbp-9C],eax
       mov       eax,[rbp-98]
       mov       r10d,[rbp-94]
       jmp       near ptr M01_L29
M01_L87:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-9C]
       cmp       dword ptr [r12+8],0
       mov       [rbp-94],edx
       mov       [rbp-98],r8d
       mov       [rbp-0F0],r10
       mov       [rbp-9C],eax
       je        near ptr M01_L30
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
       call      qword ptr [7FFE8BD57678]
       mov       eax,[rbp-98]
       test      [rbp-9C],eax
       mov       [rbp-98],eax
       jne       near ptr M01_L30
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
       jne       short M01_L88
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L89
M01_L88:
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0A8]
       mov       r8d,[rbp-94]
M01_L89:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L90
       mov       eax,1
       jmp       short M01_L91
M01_L90:
       xor       eax,eax
M01_L91:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE8C00F360]
       jmp       near ptr M01_L30
M01_L92:
       mov       rcx,rax
       mov       r11,7FFE8BB60A68
       call      qword ptr [r11]
       jmp       near ptr M01_L56
M01_L93:
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
       je        short M01_L95
       mov       rcx,[rbp-0E8]
       mov       rdi,[rcx]
       mov       rsi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rdi,rsi
       jne       short M01_L94
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L95
M01_L94:
       mov       r11,7FFE8BB60A68
       call      qword ptr [r11]
M01_L95:
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
       mov       [rbp-50],rax
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       rsi,rcx
       mov       r14,rdx
       mov       ebx,r8d
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M02_L20
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+10],0FFFFFFFF
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[r15+10]
       inc       r13d
       mov       ecx,r13d
       mov       rax,[r15+8]
       mov       eax,[rax+8]
       cmp       ecx,eax
       jge       near ptr M02_L03
       mov       [r15+10],ecx
       test      r14,r14
       je        near ptr M02_L21
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
       jge       short M02_L04
       mov       [r15+10],r13d
M02_L00:
       test      rdi,rdi
       je        near ptr M02_L19
       mov       rcx,1F5FD40D880
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L22
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L22
M02_L01:
       mov       r13,[rbp-40]
M02_L02:
       xor       r8d,r8d
       mov       [rbp-40],r8
       mov       [rbp-48],r13
       jmp       short M02_L05
M02_L03:
       mov       [r15+10],eax
       jmp       near ptr M02_L20
M02_L04:
       mov       [r15+10],ecx
       jmp       near ptr M02_L21
M02_L05:
       cmp       [r13],r13b
       lea       rdx,[rsi+0C]
       mov       esi,[rsi+8]
       test      esi,esi
       je        short M02_L09
       mov       r8,[r13+8]
       mov       r15d,[r13+18]
       lea       ecx,[r15+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L08
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jg        short M02_L06
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L07
M02_L06:
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L07:
       add       esi,r15d
       mov       [r13+18],esi
       jmp       short M02_L09
M02_L08:
       mov       rcx,r13
       mov       r8d,esi
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L09:
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L18
       lea       rsi,[rdi+10]
       mov       edi,[rdi+8]
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M02_L18
M02_L10:
       mov       ecx,r15d
       mov       rcx,[rsi+rcx*8]
       test      bl,bl
       je        short M02_L11
       test      rcx,rcx
       je        near ptr M02_L15
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L15
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M02_L14
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L13
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L13
M02_L11:
       mov       rdx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L17
       mov       r8d,[rdx+8]
       add       rdx,0C
       mov       rcx,r13
       call      qword ptr [7FFE8BF9CA80]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       jmp       short M02_L17
M02_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L13:
       mov       [r13+18],r12d
       jmp       short M02_L15
M02_L14:
       mov       rcx,r13
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L15:
       mov       rdx,2368F271C14
       mov       rcx,[r13+8]
       mov       r8d,[r13+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M02_L16
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r13+18],eax
       jmp       short M02_L17
M02_L16:
       mov       rcx,r13
       mov       r8d,2
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L17:
       inc       r15d
       cmp       r15d,edi
       jl        near ptr M02_L10
M02_L18:
       mov       rcx,r13
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L24
       nop
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
M02_L19:
       mov       rax,rsi
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
M02_L20:
       mov       rax,2368F270008
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
M02_L21:
       mov       r14,2368F270008
       jmp       near ptr M02_L00
M02_L22:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2FF168]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L23
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M02_L01
M02_L23:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       near ptr M02_L02
M02_L24:
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
       mov       rcx,1F5FD40D880
       mov       rsi,[rcx]
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M02_L25
       mov       r13,[rbp-48]
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       add       ecx,[r13+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        short M02_L29
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L26
M02_L25:
       mov       rdx,[rbp-48]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       r13,[rbp-48]
       je        short M02_L29
M02_L26:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L27
       lea       rcx,[rsi+20]
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L29
M02_L27:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L28
       mov       rcx,[rsi+18]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2FF138]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L29
M02_L28:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M02_L29:
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
; Total bytes of code 1018
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ContainsAny()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,20AB78A1F10
       mov       [rax+10],rcx
       mov       rcx,20AB78BAED8
       mov       [rax+18],rcx
       mov       rcx,rsi
       mov       r8,rax
       mov       edx,3
       call      qword ptr [7FFE8C04CB88]; DotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.StringComparison, System.String[])
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 92
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.StringComparison, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       rbx,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass21_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+10],edi
       cmp       qword ptr [rbp+8],0
       je        near ptr M01_L06
       test      rbx,rbx
       je        near ptr M01_L01
       mov       ecx,[rbx+8]
       test      ecx,ecx
       jl        near ptr M01_L05
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
M01_L00:
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L06
       mov       esi,[rbp+10]
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,20AB78B3890
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BBDA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L02
       mov       [rbp+10],esi
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Func`2[[System.String, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,offset DotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass21_0.<ContainsAny>b__0(System.String)
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Func`2<System.String,Boolean>)
       call      qword ptr [7FFE8C51F3D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L02:
       call      qword ptr [7FFE8C0E6448]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE8C0E63A0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,20AB78BAEF0
       mov       r8,rbx
       call      qword ptr [7FFE8BD4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 339
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,26EE54FAED8
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,2B775D0AED8
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DelimitedStringToArray()
       push      rsi
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       test      rcx,rcx
       je        short M00_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        short M00_L02
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
       mov       rcx,rax
       mov       dword ptr [rsp+44],2C
       cmp       [rcx],cl
       lea       rdx,[rsp+44]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      qword ptr [7FFE8BCA70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M00_L02:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23483057C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 238
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C5DD890]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5DD890]
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
       call      qword ptr [7FFE8BCA73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp+8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       vmovdqa   xmmword ptr [rbp+40],xmm4
       vmovdqa   xmmword ptr [rbp+50],xmm4
       mov       [rbp+60],rax
       mov       rax,0B665EA63823C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      edi,edi
       jl        near ptr M02_L06
       test      r14d,0FFFFFFFC
       jne       near ptr M02_L07
M02_L00:
       cmp       edi,1
       jle       near ptr M02_L08
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M02_L08
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L10
M02_L01:
       test      [rsp],esp
       sub       rsp,200
       lea       rcx,[rsp+30]
       mov       [rbp+58],rcx
       mov       dword ptr [rbp+60],80
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       [rbp+50],ecx
       lea       rcx,[rsi+0C]
       mov       [rbp+38],rcx
       mov       [rbp+40],r15d
       vmovdqu   xmm0,xmmword ptr [rbx]
       vmovdqu   xmmword ptr [rbp+28],xmm0
       lea       rcx,[rbp+38]
       lea       rdx,[rbp+28]
       lea       r8,[rbp+48]
       call      qword ptr [7FFE8BCA71B0]; System.String.MakeSeparatorListAny(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+50]
       cmp       eax,[rbp+60]
       ja        near ptr M02_L11
       mov       r10,[rbp+58]
       test      eax,eax
       je        near ptr M02_L12
       test      r14d,r14d
       je        near ptr M02_L05
       xor       ecx,ecx
       mov       [rbp+18],r10
       mov       [rbp+20],eax
       mov       [rbp+8],rcx
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],edi
       mov       [rsp+28],r14d
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FFE8BCA7198]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rbx,rax
M02_L02:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M02_L03
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,23504001E68
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C307C38]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M02_L03:
       mov       rax,rbx
       mov       rcx,0B665EA63823C
       cmp       [rbp],rcx
       je        short M02_L04
       call      CORINFO_HELP_FAIL_FAST
M02_L04:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L05:
       xor       r14d,r14d
       mov       [rbp+18],r10
       mov       [rbp+20],eax
       mov       [rbp+8],r14
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FFE8BCA7180]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M02_L02
M02_L06:
       mov       ecx,1C7
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE8C54D290]
       int       3
M02_L07:
       mov       ecx,45
       mov       edx,59
       call      qword ptr [7FFE8BEFEC88]
       int       3
M02_L08:
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,edi
       call      qword ptr [7FFE8BCA7150]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       mov       rcx,0B665EA63823C
       cmp       [rbp],rcx
       je        short M02_L09
       call      CORINFO_HELP_FAIL_FAST
M02_L09:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L10:
       cmp       r15d,edi
       jge       near ptr M02_L01
       and       r14d,0FFFFFFFD
       jmp       near ptr M02_L01
M02_L11:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M02_L12:
       mov       edi,1
       jmp       near ptr M02_L00
; Total bytes of code 561
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsIgnoreCase()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vpcmpeqq  xmm0,xmm0,[7FFE8C5DC410]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 39
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsOrBothNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,22C94FDAED8
       mov       rdx,22C94FDAF10
       mov       r8d,4
       call      qword ptr [7FFE8BCA61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 53
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M01_L00:
       cmp       rbx,rsi
       je        short M01_L02
       test      rbx,rbx
       je        short M01_L03
       test      rsi,rsi
       je        short M01_L03
       cmp       edi,4
       jne       short M01_L05
       mov       ebp,[rbx+8]
       cmp       ebp,[rsi+8]
       jne       near ptr M01_L06
       lea       rcx,[rbx+0C]
       add       ebp,ebp
       mov       r8d,ebp
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       movzx     eax,al
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       edi,5
       ja        short M01_L04
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L03:
       cmp       edi,5
       jbe       near ptr M01_L06
M01_L04:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BEFEC88]
       int       3
M01_L05:
       cmp       edi,5
       ja        near ptr M01_L08
       mov       eax,edi
       lea       rcx,[7FFE8C5FC9C8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BEA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C3A4198]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       rcx,7FFE8BBE5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1EC030003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C3A4198]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       ebp,[rbx+8]
       cmp       ebp,[rsi+8]
       je        short M01_L07
M01_L06:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8BCA5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C15D338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 391
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,201BFE6AED8
       mov       r8,201BFE6AEF8
       call      qword ptr [7FFE8C05CC30]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
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
       je        near ptr M01_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
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
       je        near ptr M01_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE8BCA75D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE8BCA75D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8BCA7240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,201BFE57C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,201BFE6AF18
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFE8C0F6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE8C0F6388]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,201BFE6AF38
       mov       r8,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 472
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       call      qword ptr [7FFE8C02CC48]; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L17
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+10]
       inc       edx
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       cmp       edx,ecx
       jge       near ptr M01_L10
       mov       [rsi+10],edx
       mov       rcx,1E9E2C0D838
       mov       rdi,[rcx]
       lea       rdx,[rbx+0C]
       mov       [rbp-40],rdx
       mov       r14,[rbp-40]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       jle       short M01_L02
M01_L00:
       lea       edx,[rbx-1]
       movsxd    rcx,edx
       movzx     ecx,word ptr [r14+rcx*2]
       cmp       ecx,20
       je        short M01_L01
       cmp       ecx,0A
       je        short M01_L01
       cmp       ecx,0D
       je        short M01_L01
       cmp       ecx,9
       jne       short M01_L02
M01_L01:
       mov       ebx,edx
       test      ebx,ebx
       jg        short M01_L00
M01_L02:
       mov       rdx,r14
       movsxd    rcx,ebx
       lea       rsi,[rdx+rcx*2]
       mov       ecx,ebx
       xor       r15d,r15d
       cmp       r14,rsi
       jae       short M01_L05
       nop       dword ptr [rax]
M01_L03:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M01_L16
       cmp       eax,3D
       je        short M01_L06
M01_L04:
       cmp       rdx,rsi
       jb        short M01_L03
M01_L05:
       test      r15d,r15d
       je        near ptr M01_L11
       cmp       r15d,1
       jne       near ptr M01_L18
       mov       r15d,2
       jmp       near ptr M01_L11
M01_L06:
       dec       ecx
       inc       r15d
       jmp       short M01_L04
M01_L07:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M01_L22
       mov       [rbp-50],rsi
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       je        short M01_L09
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L30
       mov       rsi,[rbp-50]
       add       rsi,10
M01_L08:
       test      rsi,rsi
       je        near ptr M01_L23
       mov       rcx,[rdi+18]
       mov       r14d,ebx
       test      rcx,rcx
       je        near ptr M01_L24
       mov       rax,offset MT_System.Text.DecoderReplacementFallback
       cmp       [rcx],rax
       jne       near ptr M01_L24
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M01_L24
       jmp       short M01_L12
M01_L09:
       xor       esi,esi
       jmp       short M01_L08
M01_L10:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L17
M01_L11:
       mov       edx,ecx
       sar       edx,1F
       and       edx,3
       add       edx,ecx
       sar       edx,2
       lea       edx,[rdx+rdx*2]
       add       edx,r15d
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       test      ebx,ebx
       jl        near ptr M01_L20
       lea       rcx,[rsi+10]
       mov       edx,[rsi+8]
       mov       [rbp-68],r14
       mov       [rbp-60],ebx
       mov       [rbp-78],rcx
       mov       [rbp-70],edx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       lea       r8,[rbp-48]
       call      qword ptr [7FFE8BFD4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L21
       jmp       near ptr M01_L07
M01_L12:
       mov       r13d,r14d
       cmp       r14d,ebx
       jne       near ptr M01_L25
M01_L13:
       test      r13d,r13d
       je        near ptr M01_L26
       mov       ecx,r13d
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       [rbp-58],r8
       mov       r12,[rbp-58]
       test      r12,r12
       je        near ptr M01_L27
       mov       r8d,ebx
       or        r8d,r13d
       jl        near ptr M01_L28
       cmp       r13d,ebx
       mov       r8d,ebx
       cmovle    r8d,r13d
       mov       rcx,rsi
       mov       rdx,r12
       call      qword ptr [7FFE8BECC660]; System.Text.Ascii.WidenAsciiToUtf16(Byte*, Char*, UIntPtr)
       cmp       eax,ebx
       jne       near ptr M01_L29
M01_L14:
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,r14
M01_L15:
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       dec       ecx
       jmp       near ptr M01_L04
M01_L17:
       mov       rax,22A74B80008
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L18:
       cmp       r15d,2
       jne       short M01_L19
       mov       r15d,1
       jmp       near ptr M01_L11
M01_L19:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C127C78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BF47450]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M01_L21:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE8C127C78]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BF47450]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rax,22A74B80008
       jmp       near ptr M01_L15
M01_L23:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE8BECECE8]
       int       3
M01_L24:
       mov       edx,ebx
       mov       rcx,rsi
       call      qword ptr [7FFE8BECC468]; System.Text.Ascii.GetIndexOfFirstNonAsciiByte_Vector(Byte*, UIntPtr)
       mov       r14d,eax
       mov       r13d,r14d
       cmp       r14d,ebx
       je        near ptr M01_L13
M01_L25:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       call      qword ptr [7FFE8BC7C990]
       add       eax,r13d
       mov       r13d,eax
       test      r13d,r13d
       jge       near ptr M01_L13
       call      qword ptr [7FFE8BC7C7E0]
       int       3
M01_L26:
       mov       rax,22A74B80008
       jmp       near ptr M01_L15
M01_L27:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE8BECECE8]
       int       3
M01_L28:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE8BECED18]
       int       3
M01_L29:
       mov       [rsp+20],r13d
       mov       [rsp+28],eax
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9,r12
       call      qword ptr [7FFE8BC7CA08]
       jmp       near ptr M01_L14
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 985
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFE8BCA7318]; System.String.Trim()
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C5DD2D8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5DD2D8]
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
       call      qword ptr [7FFE8BCA73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE8C04CD38]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
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
       je        near ptr M01_L10
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L05
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       jne       near ptr M01_L12
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE8C5CD890]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       je        short M01_L09
M01_L08:
       inc       esi
       cmp       [rbx+8],esi
       jle       short M01_L13
       jmp       short M01_L06
M01_L09:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L10:
       call      qword ptr [7FFE8C0E6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE8C0E6388]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,180BC427C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
       mov       rbx,rax
       xor       esi,esi
       cmp       dword ptr [rbx+8],0
       jg        near ptr M01_L06
M01_L13:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 354
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C05CD50]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
       mov       rdi,rcx
       mov       ebx,edx
       mov       esi,r8d
       test      rdi,rdi
       je        near ptr M01_L22
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       rcx,1D165C0D880
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L23
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L23
M01_L00:
       mov       r15,[rbp-38]
M01_L01:
       xor       r8d,r8d
       mov       [rbp-38],r8
       mov       [rbp-40],r15
       mov       r14d,1
       jmp       short M01_L04
M01_L02:
       mov       r8d,[r15+18]
       mov       ecx,r8d
       mov       rdx,[r15+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M01_L07
       mov       eax,ecx
       mov       [rdx+rax*2+10],si
       inc       r8d
       mov       [r15+18],r8d
M01_L03:
       add       r14d,1
       jo        short M01_L08
M01_L04:
       mov       r8d,ebx
       cmp       r14d,r8d
       jle       short M01_L02
       cmp       [r15],r15b
       lea       rdx,[rdi+0C]
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        short M01_L11
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       esi,ecx
       lea       ecx,[rsi+r13]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M01_L10
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r13d,2
       jle       short M01_L06
       movsxd    r8,r13d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       add       r13d,esi
       mov       [r15+18],r13d
       jmp       short M01_L11
M01_L06:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r13d,2
       jne       short M01_L05
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L05
M01_L07:
       movzx     edx,si
       mov       rcx,r15
       call      qword ptr [7FFE8BF9C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L03
M01_L08:
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L10:
       mov       rcx,r15
       mov       r8d,r13d
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L11:
       mov       rcx,r15
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       edi,[rbx+8]
       lea       r14d,[rdi-1]
       test      r14d,r14d
       jl        near ptr M01_L20
       cmp       edi,r14d
       jle       short M01_L15
M01_L12:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L13
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        near ptr M01_L20
       jmp       short M01_L14
M01_L13:
       call      qword ptr [7FFE8C5DD8A8]
       test      eax,eax
       je        short M01_L20
M01_L14:
       dec       r14d
       jns       short M01_L12
       jmp       short M01_L20
M01_L15:
       cmp       r14d,edi
       jae       short M01_L09
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M01_L20
       jmp       short M01_L19
M01_L16:
       test      esi,esi
       je        short M01_L17
       mov       ecx,esi
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,esi
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       lea       rdx,[rbx+0C]
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       jmp       short M01_L21
M01_L17:
       mov       rax,211F7A20008
       jmp       short M01_L21
M01_L18:
       call      qword ptr [7FFE8C5DD8A8]
       test      eax,eax
       je        short M01_L20
M01_L19:
       dec       r14d
       jns       short M01_L15
M01_L20:
       lea       esi,[r14+1]
       cmp       edi,esi
       jne       short M01_L16
       mov       rax,rbx
M01_L21:
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M01_L25
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
M01_L22:
       mov       rax,211F7A20008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2FF168]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L24
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L00
M01_L24:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L25:
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
       mov       rcx,1D165C0D880
       mov       rbx,[rcx]
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L26
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L30
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L27
M01_L26:
       mov       r15,[rbp-40]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L30
M01_L27:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L28
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L30
M01_L28:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L29
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C2FF138]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L30
M01_L29:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L30:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 838
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFE8C05CD68]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       add       ecx,0FFFFFFD0
       xor       eax,eax
       cmp       ecx,9
       setbe     al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE8C5DDCB0]
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFE8C02CD80]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       mov       eax,ecx
       mov       rcx,7FFEE9E52C20
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE8C5ADCB0]
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFE8C03CD98]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFEE9E52C20
       movzx     eax,byte ptr [rax+rcx]
       and       eax,1F
M01_L00:
       mov       ecx,1
       shlx      eax,ecx,eax
       test      eax,11F
       setne     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE8C5BD9F8]
       jmp       short M01_L00
; Total bytes of code 68
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFE8C02CDB0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
       sub       rsp,28
       movzx     ecx,cx
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFEE9E52C20
       test      byte ptr [rax+rcx],80
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE8C5ADB48]
       jmp       short M01_L00
; Total bytes of code 50
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFE8C04CDC8]; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,2291880D818
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C354D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0E6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C01EC58
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
       mov       rdx,7FFE8C01EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       call      qword ptr [7FFE8C05CDE0]; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,2A09900D820
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C364D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0F6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C02EC58
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
       mov       rdx,7FFE8C02EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFE8C02CDF8]; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,11BEAC0D828
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C334D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0C6598]
       mov       ecx,2C1
       mov       rdx,7FFE8BFFEC58
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
       mov       rdx,7FFE8BFFEC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0C6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FFE8C05CE10]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,29D0C80D830
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C364D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0F6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C02EC58
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
       mov       rdx,7FFE8C02EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+168]
       call      qword ptr [7FFE8C02CE40]; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,23F8100B848
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C334D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0C6598]
       mov       ecx,2C1
       mov       rdx,7FFE8BFFEC58
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
       mov       rdx,7FFE8BFFEC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0C6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+108]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,1E8CEC01F10
       xor       r8d,r8d
       call      qword ptr [7FFE8BD47180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rcx,rax
       call      qword ptr [7FFE8C04CE58]; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
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
       call      qword ptr [7FFE8BF1CF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE8BD47348]
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
       call      qword ptr [7FFE8BD47348]
       int       3
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,1A83CC0D848
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C354D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M02_L00:
       call      qword ptr [7FFE8C0E6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C01EC58
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
       mov       rdx,7FFE8C01EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+150]
       call      qword ptr [7FFE8C05C810]; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,19DF440D850
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C33EAA8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0F6520]
       mov       ecx,2C1
       mov       rdx,7FFE8C02ED80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C02ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1A4BA9FAEB0
       call      qword ptr [7FFE8C03CE88]; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,16428C0B860
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C344D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0D6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C00EC58
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
       mov       rdx,7FFE8C00EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0D6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+160]
       call      qword ptr [7FFE8C04CEB8]; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,1A6AD80D860
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C354D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0E6598]
       mov       ecx,2C1
       mov       rdx,7FFE8C01EC58
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
       mov       rdx,7FFE8C01EC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1814EB3AED8
       call      qword ptr [7FFE8C05C870]; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,140BCC0D870
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C364D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0F6520]
       mov       ecx,2C1
       mov       rdx,7FFE8C02ED80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C02ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0F6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE8C02CEE8]; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,1A5E2C02CE8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C334D98]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0C6598]
       mov       ecx,2C1
       mov       rdx,7FFE8BFFEC58
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
       mov       rdx,7FFE8BFFEC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0C6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+148]
       call      qword ptr [7FFE8C04C8A0]; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,288C340D878
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8C32EAA8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFE8C0E6520]
       mov       ecx,2C1
       mov       rdx,7FFE8C01ED80
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
       mov       rdx,7FFE8C01ED80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0E6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFE8C02CF18]; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 34
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,1F760C0B898
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       call      qword ptr [7FFE8C334E40]; System.Text.RegularExpressions.Regex.Match(System.String)
       cmp       dword ptr [rax+30],0
       setne     al
       movzx     eax,al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFE8C0C6598]
       mov       ecx,2C1
       mov       rdx,7FFE8BFFEC58
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
       mov       rdx,7FFE8BFFEC58
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C0C6388]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 207
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+170]
       call      qword ptr [7FFE8C04C8E8]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
       sub       rsp,20
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C5CDB60]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE8C5CDB60]
       test      eax,eax
       jne       near ptr M01_L10
M01_L05:
       cmp       [rbx],bl
       mov       rdx,2209E2E7578
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
       call      qword ptr [7FFE8C494060]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       test      eax,eax
       je        short M01_L07
M01_L06:
       mov       esi,[rbx+8]
       lea       edi,[rsi-2]
       cmp       esi,edi
       jb        near ptr M01_L11
       test      edi,edi
       je        near ptr M01_L12
       cmp       esi,edi
       je        near ptr M01_L13
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,edi
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[rbx+0C]
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FFE8C0E65B0]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FFE8C0E6310]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2209E2E7C88
       mov       r8,rdi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE8BC973F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE8BC97258]
       int       3
M01_L12:
       mov       rbx,2209E2E0008
       jmp       near ptr M01_L07
M01_L13:
       jmp       near ptr M01_L07
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,2
       mov       r8d,2C
       call      qword ptr [7FFE8C06C900]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
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
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
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
       je        near ptr M01_L02
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,30B9229AED8
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BBFA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],di
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+20],rax
       mov       dword ptr [rsp+28],1
       lea       rdx,[rsp+20]
       mov       r9d,esi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFE8BCB70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M01_L06
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFE8C1065B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE8C106310]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,30B92287C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FFE8C1063D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE8C106328]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,30B92288818
       mov       r8,rbx
       call      qword ptr [7FFE8BD6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,14
       call      qword ptr [7FFE8BF0ECD0]
       int       3
; Total bytes of code 395
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SplitRemoveEmpty()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE8C04CFC0]; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
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
       je        near ptr M01_L02
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC97318]; System.String.Trim()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       word ptr [rax+10],2C
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+28],rax
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      qword ptr [7FFE8BC970C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      rbx,rbx
       je        short M01_L04
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFE8C0E6628]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE8C0E6388]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C759FA7C88
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       ecx,14
       call      qword ptr [7FFE8BEEECD0]
       int       3
; Total bytes of code 276
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1330
       cmp       [rbx],rcx
       jne       near ptr M00_L08
       mov       rsi,[rbx+50]
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,offset MT_System.String
       cmp       [rsi],rcx
       jne       near ptr M00_L09
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE8C2DD8C0]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L04
       mov       ecx,[rsi+8]
       cmp       ecx,32
       jl        short M00_L05
       cmp       ecx,32
       jb        near ptr M00_L06
       cmp       ecx,19
       je        near ptr M00_L07
       mov       ecx,19
       call      System.String.FastAllocateString(Int32)
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rax,[rcx+0C]
       add       rsi,3E
       vmovdqu   ymm0,ymmword ptr [rsi]
       vmovdqu   ymm1,ymmword ptr [rsi+12]
       vmovdqu   ymmword ptr [rax],ymm0
       vmovdqu   ymmword ptr [rax+12],ymm1
M00_L02:
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC77318]; System.String.Trim()
       mov       rdi,rax
M00_L03:
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       rdi,1C3E0DC0008
       jmp       short M00_L03
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0A38
       mov       rdx,7FFE8BFFED80
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       call      qword ptr [7FFE8C0C6328]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rcx,rsi
       mov       edx,19
       mov       r8d,19
       call      qword ptr [7FFE8BC77258]
       int       3
M00_L07:
       mov       rcx,rsi
       jmp       near ptr M00_L02
M00_L08:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       mov       r11,7FFE8BB309C0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE8BB309C8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
; Total bytes of code 405
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FFE8C5AD2D8]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFE8C5AD2D8]
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
       call      qword ptr [7FFE8BC773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
**Extern method**
System.String.FastAllocateString(Int32)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE8C04D020]; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L03
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+10]
       inc       edx
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       cmp       edx,ecx
       jge       short M01_L00
       mov       [rsi+10],edx
       mov       rcx,23025C0B840
       mov       rdi,[rcx]
       lea       rdx,[rbx+0C]
       mov       [rsp+40],rdx
       mov       rbp,[rsp+40]
       mov       r14d,[rbx+8]
       mov       rdx,[rdi+10]
       mov       r15d,r14d
       test      rdx,rdx
       je        near ptr M01_L04
       jmp       short M01_L01
M01_L00:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L03
M01_L01:
       mov       rcx,offset MT_System.Text.EncoderReplacementFallback
       cmp       [rdx],rcx
       jne       near ptr M01_L04
       mov       rdx,[rdx+8]
       cmp       dword ptr [rdx+8],1
       jne       near ptr M01_L04
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M01_L06
       cmp       word ptr [rdx+0C],7F
       ja        near ptr M01_L04
       mov       esi,r15d
       cmp       r15d,r14d
       jne       near ptr M01_L05
M01_L02:
       xor       edx,edx
       mov       [rsp+40],rdx
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       [rsp+20],r14
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rbx+8]
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE8C316BC0]; System.Text.ASCIIEncoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       lea       rcx,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FFE8C005638]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,270B7C00008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       mov       edx,r14d
       mov       rcx,rbp
       call      qword ptr [7FFE8BEEC4C8]; System.Text.Ascii.GetIndexOfFirstNonAsciiChar_Vector(Char*, UIntPtr)
       mov       r15d,eax
       mov       esi,r15d
       cmp       r15d,r14d
       je        near ptr M01_L02
M01_L05:
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FFE8BC9C8A0]
       add       esi,eax
       jns       near ptr M01_L02
       call      qword ptr [7FFE8BC9C7E0]
       int       3
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 413
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rax,1FF7201AED8
       mov       [rcx+8],rax
       call      qword ptr [7FFE8C2EEF58]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFE8BE5B7A0]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,1FF7201AED8
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BE8C378]; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       rax,1FF7201AED8
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
       mov       rax,[rax+30]
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
       mov       rax,1BEE4000438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1BEE4000418
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
       jmp       qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE8BE8C018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
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
       mov       r12,7FFEE9E61A80
       movzx     r8d,byte ptr [r8+r12]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r14,7FFEE9E5AA98
       movzx     r8d,word ptr [r8+r14]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFEE9E5E5C0
       movzx     r8d,byte ptr [r8+r13]
       mov       r15,7FFEE9E52F20
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
       call      qword ptr [7FFE8BE8C3A8]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       call      qword ptr [7FFE8C50F780]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE8BF85FA8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M04_L26:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FFE8C52DBD8]
       int       3
M04_L27:
       mov       ecx,2E5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M04_L28:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C136EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE8BD3D470]
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
       mov       rdx,1FF7201AF00
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF7C2A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFE8BE8C1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L36:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L38
M04_L37:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FFE8BF7CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M04_L18
M04_L43:
       mov       eax,[rsp+34]
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF7C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L18
M04_L44:
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L19
M04_L45:
       call      qword ptr [7FFE8BF7C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r14d,ebp
       jmp       near ptr M04_L22
M04_L46:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FFE8BE8C390]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L23
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2038
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1340
       cmp       [rbx],rcx
       jne       near ptr M00_L04
       mov       rsi,[rbx+50]
M00_L00:
       test      rsi,rsi
       je        short M00_L03
       mov       rcx,offset MT_System.String
       cmp       [rsi],rcx
       jne       short M00_L05
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE8C2EEF58]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       rcx,rsi
       call      qword ptr [7FFE8BC87318]; System.String.Trim()
       mov       rsi,rax
M00_L02:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       jmp       short M00_L02
M00_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       mov       r11,7FFE8BB409C8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE8BB409D0
       call      qword ptr [r11]
       jmp       short M00_L01
; Total bytes of code 216
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
; System.String.Trim()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        near ptr M02_L17
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M02_L00
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M02_L01
       jmp       near ptr M02_L16
M02_L00:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       je        near ptr M02_L16
M02_L01:
       xor       edi,edi
       test      esi,esi
       jle       short M02_L05
M02_L02:
       mov       ecx,edi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L03
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M02_L05
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       je        short M02_L05
M02_L04:
       inc       edi
       cmp       esi,edi
       jg        short M02_L02
M02_L05:
       lea       ebp,[rsi-1]
       cmp       ebp,edi
       jl        short M02_L12
       mov       ecx,ebp
       or        ecx,edi
       jl        short M02_L09
       cmp       esi,ebp
       jle       short M02_L09
M02_L06:
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L07
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L08
M02_L07:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       je        short M02_L12
M02_L08:
       dec       ebp
       cmp       ebp,edi
       jge       short M02_L06
       jmp       short M02_L12
M02_L09:
       cmp       ebp,esi
       jae       near ptr M02_L18
       mov       ecx,ebp
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L10
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L11
M02_L10:
       call      qword ptr [7FFE8C5CD890]
       test      eax,eax
       je        short M02_L12
M02_L11:
       dec       ebp
       cmp       ebp,edi
       jge       short M02_L09
M02_L12:
       sub       ebp,edi
       inc       ebp
       cmp       esi,ebp
       jne       short M02_L14
       mov       rax,rbx
M02_L13:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L14:
       test      ebp,ebp
       je        short M02_L15
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,ebp
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       mov       edx,edi
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M02_L13
M02_L15:
       mov       rax,1EC55D80008
       jmp       short M02_L13
M02_L16:
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FFE8BC15CE0]; System.Char.IsWhiteSpace(Char)
       test      eax,eax
       jne       near ptr M02_L01
M02_L17:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 366
```

