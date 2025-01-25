## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,2FFAA5A0008
       mov       rax,2FFAA5BAF40
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,1FA112A0008
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rsi,2AD2112AF40
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,20B31FCAF40
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,64
       call      qword ptr [7FFBF98EC6A8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
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
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ebx,edx
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFBF9E5FAF8]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFBF9E5FAF8]
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
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBF95E47B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFBF9986508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFBF9986328]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,223AAAD7598
       mov       r8,rbx
       call      qword ptr [7FFBF95ED470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBF95373F0]
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 311
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFBF991CD50]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
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
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rdi,rcx
       mov       ebx,edx
       mov       esi,r8d
       xor       eax,eax
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
       mov       [rsp+28],rax
       xor       ecx,ecx
       cmp       esi,7FFFFFFF
       setle     cl
       cmp       esi,ebx
       cmovge    eax,ecx
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
       movzx     eax,byte ptr [rsp+28]
       test      al,al
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBF96147B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ebx,eax
       jmp       short M01_L01
M01_L07:
       call      qword ptr [7FFBF99B6928]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L08
       call      qword ptr [7FFBF99B6748]
       mov       rdi,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,29DE718A5D8
       mov       r8,rdi
       call      qword ptr [7FFBF961D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBF96147B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFBF99B6928]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFBF99B6748]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29DE718A600
       mov       r8,rbx
       call      qword ptr [7FFBF961D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 333
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,31B73ACAF40
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,31B73ACAF78
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,31B73AB0008
       mov       r8,31B73AB8818
       call      qword ptr [7FFBF9DA5218]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFBF9BCCD38]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FFBF9BCCF30]; System.Text.RegularExpressions.Regex.get_RightToLeft()
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
       mov       r9,31B73ACAF40
       call      qword ptr [7FFBF9BCCFF0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9DA6E98]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,31B73ACAFE8
       cmp       [rcx],ecx
       call      qword ptr [7FFBF947A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFBF99867F0]
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
       call      qword ptr [7FFBF9986748]
       mov       rsi,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFBF95ED470]
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
       call      qword ptr [7FFBF9BCCD80]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FFBF9C96430]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFBF9C96418]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFBF9DA6E08]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FFBF9BBDD28
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
       mov       rcx,7FFBF9BBDD28
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2DAE1C0F7E8
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FFBF978ED30]
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
       test      byte ptr [7FFBF9BBDD79],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,2DAE1C0F7E8
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
       call      qword ptr [7FFBF9F0EEF8]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFBF9F0EEF8]
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9567318]; System.String.Trim()
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFBF9E8FAF8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFBF9E8FAF8]
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
       call      qword ptr [7FFBF95673F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF990CFA8]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
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
       call      qword ptr [7FFBF9557318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rdx,rax
       mov       rcx,23E06BBAF40
       cmp       [rcx],ecx
       call      qword ptr [7FFBF949A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L07
       xor       ecx,ecx
       mov       [rsp+38],rcx
       test      esi,esi
       jle       near ptr M01_L09
       xor       r14d,r14d
       cmp       esi,7FFFFFFF
       setle     r14b
       mov       eax,r14d
       test      r14d,r14d
       je        near ptr M01_L10
M01_L02:
       test      eax,eax
       je        near ptr M01_L11
M01_L03:
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rax+10],bp
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+28],rax
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFBF95570C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L13
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L14
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M01_L04:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       call      qword ptr [7FFBF99A69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFBF99A6730]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,23E06BA7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFBF99A67F0]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M01_L08
       call      qword ptr [7FFBF99A6748]
       mov       rbp,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23E06BA8818
       mov       r8,rbp
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       xor       r14d,r14d
       mov       eax,r14d
       test      r14d,r14d
       jne       near ptr M01_L02
M01_L10:
       movzx     ecx,byte ptr [rsp+38]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+38]
       call      qword ptr [7FFBF96047B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L11:
       call      qword ptr [7FFBF99A6928]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L12
       call      qword ptr [7FFBF99A6748]
       mov       rbx,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23E06BA4368
       mov       r8,rbx
       call      qword ptr [7FFBF960D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFBF97AED00]
       int       3
M01_L14:
       mov       rcx,7FFBF9495120
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1FD74C01F58
       mov       rax,[rax]
       jmp       near ptr M01_L04
; Total bytes of code 625
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,28D2D400970
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98FD080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9547318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95D0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFBF99969D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9996730]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CDBF4A7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFBF9996940]
       mov       ecx,0A72
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2B007C009C8
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98FD080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9547318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95D0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFBF99969D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9996730]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2F0959C7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFBF9996940]
       mov       ecx,0A72
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,24C1C0009A0
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98ED080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9537318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95C0180]; System.Text.Encoding.GetBytes(System.String)
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L04:
       call      qword ptr [7FFBF99869D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFBF9986730]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28CA9E97C88
       mov       r8,rbx
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFBF9986940]
       mov       ecx,0A72
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9986730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF98050C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 365
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,15BE70009C0
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98FD080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9547318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95D0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFBF99969D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9996730]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,19C75037C88
       mov       r8,rbx
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFBF9996940]
       mov       ecx,0A72
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,22F7B4009D0
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98FD080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9547318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95D0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFBF99969D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9996730]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2700D3D7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFBF9996940]
       mov       ecx,0A72
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1C4E7C009D8
       mov       rdx,[rdx]
       call      qword ptr [7FFBF98FD080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9547318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95D0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFBF99969D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFBF9996730]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,205799D7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFBF9996940]
       mov       ecx,0A72
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,133CD8009F0
       mov       rdx,[rdx]
       call      qword ptr [7FFBF990D080]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFBF9557318]; System.String.Trim()
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
       jmp       qword ptr [7FFBF95E0180]; System.Text.Encoding.GetBytes(System.String)
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
       call      qword ptr [7FFBF99A69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFBF99A6730]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1745F4B7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,0A72
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF98250C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9924B88]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF992CB58]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
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
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-0C8],rsp
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
       jo        near ptr M01_L101
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,14EC5C01DE0
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFBF98DFC48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L102
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L103
M01_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M01_L50
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L105
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M01_L05
       cmp       edi,64
       jb        short M01_L04
       mov       rdx,14EC5C00290
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
       mov       rdx,14EC5C00290
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
       je        near ptr M01_L104
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M01_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L111
       mov       rcx,18F53C70C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L110
M01_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M01_L45
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L106
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,14EC5C00290
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
       mov       rdx,14EC5C00290
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
       je        near ptr M01_L112
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M01_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L113
       mov       rcx,18F53C70C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L109
M01_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M01_L40
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L107
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,14EC5C00290
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
       mov       rdx,14EC5C00290
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
       je        near ptr M01_L114
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M01_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],ecx
       lea       rcx,[rbp-0A8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       rdx,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      rdx,rdx
       je        short M01_L28
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFBF98DFC50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L28:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFBF957EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L32
M01_L29:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFBF957EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L100
       mov       rax,[rax]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       xor       edx,edx
M01_L31:
       mov       r8d,edx
       test      edx,edx
       jne       near ptr M01_L59
       mov       ecx,1
       jmp       near ptr M01_L60
M01_L32:
       mov       r12,[r14+10]
       test      edi,edi
       jle       near ptr M01_L63
       xor       eax,eax
       cmp       edi,7FFFFFFF
       setle     al
M01_L33:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L64
       mov       edi,1
M01_L34:
       test      ebx,ebx
       jle       near ptr M01_L66
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
M01_L35:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L67
       mov       ebx,1
M01_L36:
       test      esi,esi
       jle       near ptr M01_L69
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
M01_L37:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L70
       mov       esi,1
M01_L38:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,edi
       call      qword ptr [7FFBF962DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rbp-94],eax
       test      edi,edi
       jle       near ptr M01_L82
M01_L39:
       mov       ecx,ebx
       test      ecx,ecx
       jle       near ptr M01_L30
       xor       edx,edx
       cmp       ebx,7FFFFFFF
       setle     dl
       jmp       near ptr M01_L31
M01_L40:
       test      rcx,rcx
       jne       short M01_L42
       call      qword ptr [7FFBF975F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L61
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L62
M01_L42:
       call      qword ptr [7FFBF975F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L41
M01_L43:
       xor       r8d,r8d
M01_L44:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L72
       mov       edx,1
       jmp       near ptr M01_L73
M01_L45:
       test      rcx,rcx
       jne       short M01_L47
       call      qword ptr [7FFBF975F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L46:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L57
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L58
M01_L47:
       call      qword ptr [7FFBF975F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L46
M01_L48:
       xor       r8d,r8d
M01_L49:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L74
       mov       ecx,1
       jmp       near ptr M01_L75
M01_L50:
       test      rcx,rcx
       jne       short M01_L52
       call      qword ptr [7FFBF975F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L51:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L53
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L54
M01_L52:
       call      qword ptr [7FFBF975F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L51
M01_L53:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L54:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       ecx,edi
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E9E6E8]
       jmp       near ptr M01_L08
M01_L55:
       xor       r8d,r8d
M01_L56:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L76
       mov       edx,1
       jmp       near ptr M01_L77
M01_L57:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L58:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-78]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E9E6E8]
       jmp       near ptr M01_L17
M01_L59:
       test      r8d,r8d
       je        near ptr M01_L83
M01_L60:
       mov       edx,esi
       test      esi,esi
       jle       near ptr M01_L43
       xor       r8d,r8d
       cmp       esi,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L44
M01_L61:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L62:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E9E6E8]
       jmp       near ptr M01_L26
M01_L63:
       xor       eax,eax
       jmp       near ptr M01_L33
M01_L64:
       test      ecx,ecx
       jne       near ptr M01_L34
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L65
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L65:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,18F53C74368
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L66:
       xor       eax,eax
       jmp       near ptr M01_L35
M01_L67:
       test      ecx,ecx
       jne       near ptr M01_L36
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L68
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18F53C7A5D8
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       xor       eax,eax
       jmp       near ptr M01_L37
M01_L70:
       test      ecx,ecx
       jne       near ptr M01_L38
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L71
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L71:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18F53C7A600
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       test      r10d,r10d
       je        near ptr M01_L85
M01_L73:
       test      ecx,ecx
       jle       near ptr M01_L48
       xor       r8d,r8d
       cmp       ecx,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L49
M01_L74:
       test      r10d,r10d
       je        near ptr M01_L87
M01_L75:
       test      edx,edx
       jle       near ptr M01_L55
       xor       r8d,r8d
       cmp       edx,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L56
M01_L76:
       test      r10d,r10d
       je        near ptr M01_L89
M01_L77:
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L101
       cmp       edx,r8d
       jl        short M01_L79
M01_L78:
       call      qword ptr [7FFBF992D770]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBF9927CD8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M01_L80
       lea       r10d,[rdx+1]
       mov       [r15+10],r10d
       cmp       edx,r8d
       jae       near ptr M01_L116
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L81
M01_L79:
       mov       edx,r8d
       jmp       short M01_L78
M01_L80:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFBF962E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L81:
       mov       eax,[rbp-94]
       add       eax,1
       jo        near ptr M01_L101
       cmp       eax,edi
       mov       [rbp-94],eax
       jl        near ptr M01_L39
M01_L82:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFBF992C330]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       xor       esi,esi
       mov       rcx,[rbx+8]
       mov       r11,7FFBF9430A68
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF99605B0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L91
M01_L83:
       call      qword ptr [7FFBF99C6928]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L84
       call      qword ptr [7FFBF99C6748]
       mov       rbx,rax
M01_L84:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,18F53C7A5D8
       mov       r8,rbx
       call      qword ptr [7FFBF962D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L85:
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L86
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18F53C7A600
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L87:
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L88
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L88:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18F53C7A5D8
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L89:
       call      qword ptr [7FFBF99C6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L90
       call      qword ptr [7FFBF99C6748]
       mov       r15,rax
M01_L90:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18F53C7A600
       mov       r8,r15
       call      qword ptr [7FFBF962D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L91:
       jmp       short M01_L94
M01_L92:
       cmp       r15,rbx
       jne       short M01_L96
       mov       rax,[rbp-0C0]
       mov       rdx,[rax+10]
M01_L93:
       cmp       esi,[rdi+8]
       jae       short M01_L95
       mov       ecx,esi
       lea       rcx,[rdi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       rax,[rbp-0C0]
M01_L94:
       mov       r15,[rax]
       mov       rbx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       r15,rbx
       jne       short M01_L97
       mov       rdx,r15
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF981E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L98
M01_L95:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L96:
       mov       rcx,[rbp-0C0]
       mov       r11,7FFBF9430A40
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L93
M01_L97:
       mov       rcx,rax
       mov       r11,7FFBF9430A38
       call      qword ptr [r11]
M01_L98:
       test      eax,eax
       jne       short M01_L92
       mov       rax,[rbp-0C0]
       test      rax,rax
       je        short M01_L99
       cmp       r15,rbx
       jne       near ptr M01_L115
       movsx     rcx,byte ptr [rax+8]
M01_L99:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFBF957EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M01_L29
M01_L100:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9F442B8]
       int       3
M01_L101:
       call      CORINFO_HELP_OVERFLOW
M01_L102:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L103:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFBF9E9FF18]
       jmp       near ptr M01_L09
M01_L104:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9755938]
       jmp       near ptr M01_L02
M01_L105:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L106:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L107:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M01_L25
M01_L108:
       call      qword ptr [7FFBF97CE9D0]
       int       3
M01_L109:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFBF9E9FF18]
       jmp       near ptr M01_L27
M01_L110:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFBF9E9FF18]
       jmp       near ptr M01_L18
M01_L111:
       lea       rcx,[rbp-60]
       mov       rdx,18F53C70C30
       call      qword ptr [7FFBF97558F0]
       jmp       near ptr M01_L10
M01_L112:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9755938]
       jmp       near ptr M01_L11
M01_L113:
       lea       rcx,[rbp-60]
       mov       rdx,18F53C70C30
       call      qword ptr [7FFBF97558F0]
       jmp       near ptr M01_L19
M01_L114:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9755938]
       jmp       near ptr M01_L20
M01_L115:
       mov       rcx,rax
       mov       r11,7FFBF9430A48
       call      qword ptr [r11]
       jmp       near ptr M01_L99
M01_L116:
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
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L118
       mov       rcx,[rbp-0C0]
       mov       r15,[rcx]
       mov       rbx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       r15,rbx
       jne       short M01_L117
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L118
M01_L117:
       mov       r11,7FFBF9430A48
       call      qword ptr [r11]
M01_L118:
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
; Total bytes of code 3326
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rdx,rdx
       je        near ptr M02_L01
       mov       rbx,rdx
       mov       rsi,rcx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rbx+8]
       mov       rdx,rdi
       add       rdx,1
       jo        short M02_L00
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       cmp       dword ptr [rbp+8],0
       jbe       near ptr M02_L04
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       movsxd    rdx,ecx
       cmp       rdi,rdx
       jne       near ptr M02_L03
       mov       [rsp+20],ecx
       mov       rcx,rbx
       xor       edx,edx
       mov       r8,rbp
       mov       r9d,1
       call      qword ptr [7FFBF94C7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,rbp
       xor       ecx,ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFBF9DE5A10]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       call      qword ptr [7FFBF99C6940]
       mov       ecx,9AA
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99C6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       call      qword ptr [7FFBF99C6940]
       mov       ecx,29B
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99C6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       ecx,28
       mov       edx,35
       call      qword ptr [7FFBF97CED48]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 461
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeHash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       xor       edx,edx
       call      qword ptr [7FFBF990CB70]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
       je        near ptr M01_L23
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
       jge       near ptr M01_L04
       mov       [r14+10],ecx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFBF990CB40]; DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rbx,rax
       mov       rcx,2216100E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L24
       mov       rcx,[rcx+18]
M01_L00:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L27
       mov       rcx,[rsi+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L25
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L25
M01_L01:
       mov       r14,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L03:
       mov       [rbp-48],r14
       jmp       short M01_L05
M01_L04:
       mov       [r14+10],r13d
       jmp       near ptr M01_L23
M01_L05:
       test      rbx,rbx
       je        near ptr M01_L07
       lea       r13,[rbx+10]
       mov       ebx,[rbx+8]
       xor       r12d,r12d
       test      ebx,ebx
       jle       near ptr M01_L15
M01_L06:
       mov       ecx,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       r8,22161000428
       mov       r8,[r8]
       mov       rdx,261F2D1A8C8
       call      qword ptr [7FFBF9784810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [r14],r14b
       test      rax,rax
       je        near ptr M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M01_L09
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L13
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       near ptr M01_L13
M01_L07:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,0F
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFBF97D6670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rax,rbx
       jmp       near ptr M01_L22
M01_L09:
       mov       rcx,r14
       call      qword ptr [7FFBF984CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L14
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFBF95573F0]
       mov       rbx,rax
       jmp       near ptr M01_L21
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [r14+18],esi
M01_L14:
       inc       r12d
       cmp       r12d,ebx
       jl        near ptr M01_L06
M01_L15:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9856C50]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L08
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
       jge       short M01_L16
       mov       [rdi+10],r15d
       cmp       dword ptr [rbx+8],0
       je        short M01_L21
       jmp       short M01_L17
M01_L16:
       mov       [rdi+10],ecx
       jmp       near ptr M01_L08
M01_L17:
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L18
       mov       rdx,7FFC58492C38
       test      byte ptr [rcx+rdx],80
       jne       near ptr M01_L10
       jmp       short M01_L19
M01_L18:
       call      qword ptr [7FFBF9F27A08]
       test      eax,eax
       jne       near ptr M01_L10
M01_L19:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L11
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L20
       mov       rdx,7FFC58492C38
       test      byte ptr [rcx+rdx],80
       jne       near ptr M01_L10
       jmp       short M01_L21
M01_L20:
       call      qword ptr [7FFBF9F27A08]
       test      eax,eax
       jne       near ptr M01_L10
M01_L21:
       mov       rax,rbx
M01_L22:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L28
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
M01_L23:
       mov       rax,261F2D10008
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
M01_L24:
       call      qword ptr [7FFBF990E160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L25:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9BBF168]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L26
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L01
M01_L26:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L27:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L03
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
       mov       rcx,2216100E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L29
       call      qword ptr [7FFBF990E160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M01_L30
M01_L29:
       mov       rdi,[rcx+18]
M01_L30:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       near ptr M01_L35
       mov       r14,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r14+18],rcx
       jne       short M01_L31
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L36
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFBF984C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L32
M01_L31:
       mov       rdx,[rbp-48]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       r15,[rbp-48]
       je        short M01_L36
M01_L32:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L33
       lea       rcx,[rdi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L36
M01_L33:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L34
       mov       rcx,[rdi+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9BBF138]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L36
M01_L34:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       short M01_L36
M01_L35:
       mov       r15,[rbp-48]
       mov       rcx,rdi
       mov       rdx,r15
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L36:
       nop
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
; Total bytes of code 1257
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeSHA256Hash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFBF98ECB88]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
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
       mov       r8,1C5AE4009F0
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
       call      qword ptr [7FFBF980D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFBF97792D8]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
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
       mov       rcx,2063C34A6F8
       xor       r9d,r9d
       call      qword ptr [7FFBF9BC5B48]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,rsi
       call      qword ptr [7FFBF9BC52C0]; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
       mov       rax,2063C340008
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
       call      qword ptr [7FFBF98050C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r14d
       call      qword ptr [7FFBF953C8A0]
       add       r15d,eax
       jns       near ptr M01_L00
M01_L06:
       call      qword ptr [7FFBF953C7E0]
       int       3
M01_L07:
       mov       ecx,6A61
       mov       rdx,7FFBF9923118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97B66E8]
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBF9F07540]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFBF9923118
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF953F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 658
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF9904B88]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,23C718E0C60
       mov       r8d,1
       call      qword ptr [7FFBF990CBA0]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
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
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-0C8],rsp
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
       jo        near ptr M01_L101
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1FBE3801DE0
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFBF98BFC48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L102
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-48],r13
       mov       [rbp-40],r12d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L103
M01_L02:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      edi,edi
       jl        near ptr M01_L50
       mov       eax,edi
       mov       ecx,edi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L105
       mov       [rbp-68],eax
       mov       [rbp-70],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,edi
       cmp       edi,0A
       jb        short M01_L05
       cmp       edi,64
       jb        short M01_L04
       mov       rdx,1FBE3800290
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
       mov       rdx,1FBE3800290
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
       je        near ptr M01_L104
       mov       ecx,[rbp-50]
       add       ecx,[rbp-68]
       mov       [rbp-50],ecx
M01_L09:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L111
       mov       rcx,23C718E0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L10:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L110
M01_L11:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      ebx,ebx
       jl        near ptr M01_L45
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L106
       mov       [rbp-78],eax
       mov       [rbp-80],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,1FBE3800290
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
       mov       rdx,1FBE3800290
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
       je        near ptr M01_L112
       mov       ecx,[rbp-50]
       add       ecx,[rbp-78]
       mov       [rbp-50],ecx
M01_L18:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L113
       mov       rcx,23C718E0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M01_L19:
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L109
M01_L20:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-40]
       sub       r12d,ecx
       mov       rcx,[rbp-60]
       test      esi,esi
       jl        near ptr M01_L40
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFC584985E0
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L107
       mov       [rbp-88],eax
       mov       [rbp-90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,1FBE3800290
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
       mov       rdx,1FBE3800290
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
       je        near ptr M01_L114
       mov       ecx,[rbp-50]
       add       ecx,[rbp-88]
       mov       [rbp-50],ecx
M01_L27:
       mov       ecx,[rbp-50]
       cmp       ecx,[rbp-40]
       ja        near ptr M01_L108
       mov       rax,[rbp-48]
       mov       [rbp-0A8],rax
       mov       [rbp-0A0],ecx
       lea       rcx,[rbp-0A8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       rdx,[rbp-58]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-60],ymm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       test      rdx,rdx
       je        short M01_L28
       mov       rcx,r15
       xor       r8d,r8d
       call      qword ptr [7FFBF98BFC50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L28:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFBF955EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L32
M01_L29:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFBF955EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L100
       mov       rax,[rax]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       xor       edx,edx
M01_L31:
       mov       r8d,edx
       test      edx,edx
       jne       near ptr M01_L59
       mov       ecx,1
       jmp       near ptr M01_L60
M01_L32:
       mov       r12,[r14+10]
       test      edi,edi
       jle       near ptr M01_L63
       xor       eax,eax
       cmp       edi,7FFFFFFF
       setle     al
M01_L33:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L64
       mov       edi,1
M01_L34:
       test      ebx,ebx
       jle       near ptr M01_L66
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
M01_L35:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L67
       mov       ebx,1
M01_L36:
       test      esi,esi
       jle       near ptr M01_L69
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
M01_L37:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L70
       mov       esi,1
M01_L38:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,edi
       call      qword ptr [7FFBF960DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rbp-94],eax
       test      edi,edi
       jle       near ptr M01_L82
M01_L39:
       mov       ecx,ebx
       test      ecx,ecx
       jle       near ptr M01_L30
       xor       edx,edx
       cmp       ebx,7FFFFFFF
       setle     dl
       jmp       near ptr M01_L31
M01_L40:
       test      rcx,rcx
       jne       short M01_L42
       call      qword ptr [7FFBF973F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L41:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L61
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L62
M01_L42:
       call      qword ptr [7FFBF973F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L41
M01_L43:
       xor       r8d,r8d
M01_L44:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L72
       mov       edx,1
       jmp       near ptr M01_L73
M01_L45:
       test      rcx,rcx
       jne       short M01_L47
       call      qword ptr [7FFBF973F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L46:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L57
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L58
M01_L47:
       call      qword ptr [7FFBF973F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L46
M01_L48:
       xor       r8d,r8d
M01_L49:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L74
       mov       ecx,1
       jmp       near ptr M01_L75
M01_L50:
       test      rcx,rcx
       jne       short M01_L52
       call      qword ptr [7FFBF973F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L51:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L53
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L54
M01_L52:
       call      qword ptr [7FFBF973F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L51
M01_L53:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L54:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-68]
       mov       [rsp+20],rcx
       mov       ecx,edi
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E7E6E8]
       jmp       near ptr M01_L08
M01_L55:
       xor       r8d,r8d
M01_L56:
       mov       r10d,r8d
       test      r8d,r8d
       jne       near ptr M01_L76
       mov       edx,1
       jmp       near ptr M01_L77
M01_L57:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L58:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-78]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E7E6E8]
       jmp       near ptr M01_L17
M01_L59:
       test      r8d,r8d
       je        near ptr M01_L83
M01_L60:
       mov       edx,esi
       test      esi,esi
       jle       near ptr M01_L43
       xor       r8d,r8d
       cmp       esi,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L44
M01_L61:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L62:
       mov       [rbp-0A8],r8
       mov       [rbp-0A0],r9d
       mov       [rbp-0B8],r13
       mov       [rbp-0B0],r12d
       lea       rcx,[rbp-88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBF9E7E6E8]
       jmp       near ptr M01_L26
M01_L63:
       xor       eax,eax
       jmp       near ptr M01_L33
M01_L64:
       test      ecx,ecx
       jne       near ptr M01_L34
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L65
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L65:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,23C718E4368
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L66:
       xor       eax,eax
       jmp       near ptr M01_L35
M01_L67:
       test      ecx,ecx
       jne       near ptr M01_L36
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L68
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L68:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C718EA5D8
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       xor       eax,eax
       jmp       near ptr M01_L37
M01_L70:
       test      ecx,ecx
       jne       near ptr M01_L38
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L71
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L71:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C718EA600
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       test      r10d,r10d
       je        near ptr M01_L85
M01_L73:
       test      ecx,ecx
       jle       near ptr M01_L48
       xor       r8d,r8d
       cmp       ecx,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L49
M01_L74:
       test      r10d,r10d
       je        near ptr M01_L87
M01_L75:
       test      edx,edx
       jle       near ptr M01_L55
       xor       r8d,r8d
       cmp       edx,7FFFFFFF
       setle     r8b
       jmp       near ptr M01_L56
M01_L76:
       test      r10d,r10d
       je        near ptr M01_L89
M01_L77:
       mov       r8d,ecx
       add       r8d,1
       jo        near ptr M01_L101
       cmp       edx,r8d
       jl        short M01_L78
       jmp       short M01_L79
M01_L78:
       mov       edx,r8d
M01_L79:
       call      qword ptr [7FFBF990D770]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBF9907CD8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M01_L80
       lea       r10d,[rdx+1]
       mov       [r15+10],r10d
       cmp       edx,r8d
       jae       near ptr M01_L116
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L81
M01_L80:
       mov       rcx,r15
       mov       rdx,rax
       call      qword ptr [7FFBF960E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L81:
       mov       eax,[rbp-94]
       add       eax,1
       jo        near ptr M01_L101
       cmp       eax,edi
       mov       [rbp-94],eax
       jl        near ptr M01_L39
M01_L82:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFBF990C330]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       xor       esi,esi
       mov       rcx,[rbx+8]
       mov       r11,7FFBF9410A88
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF99405B0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0C0],rax
       jmp       near ptr M01_L91
M01_L83:
       call      qword ptr [7FFBF99A6928]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L84
       call      qword ptr [7FFBF99A6748]
       mov       rbx,rax
M01_L84:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23C718EA5D8
       mov       r8,rbx
       call      qword ptr [7FFBF960D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L85:
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L86
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L86:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C718EA600
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L87:
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L88
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L88:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C718EA5D8
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L89:
       call      qword ptr [7FFBF99A6928]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L90
       call      qword ptr [7FFBF99A6748]
       mov       r15,rax
M01_L90:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C718EA600
       mov       r8,r15
       call      qword ptr [7FFBF960D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L91:
       jmp       short M01_L94
M01_L92:
       cmp       r15,rbx
       jne       short M01_L96
       mov       rax,[rbp-0C0]
       mov       rdx,[rax+10]
M01_L93:
       cmp       esi,[rdi+8]
       jae       short M01_L95
       mov       ecx,esi
       lea       rcx,[rdi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       rax,[rbp-0C0]
M01_L94:
       mov       r15,[rax]
       mov       rbx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       r15,rbx
       jne       short M01_L97
       mov       rdx,r15
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF97FE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L98
M01_L95:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L96:
       mov       rcx,[rbp-0C0]
       mov       r11,7FFBF9410A60
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L93
M01_L97:
       mov       rcx,rax
       mov       r11,7FFBF9410A58
       call      qword ptr [r11]
M01_L98:
       test      eax,eax
       jne       short M01_L92
       mov       rax,[rbp-0C0]
       test      rax,rax
       je        short M01_L99
       cmp       r15,rbx
       jne       near ptr M01_L115
       movsx     rcx,byte ptr [rax+8]
M01_L99:
       cmp       [r12],r12b
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,rdi
       mov       r9d,2
       call      qword ptr [7FFBF955EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       near ptr M01_L29
M01_L100:
       mov       rdx,r13
       mov       rcx,offset MD_System.ThrowHelper.ThrowKeyNotFoundException[[System.String, System.Private.CoreLib]](System.String)
       call      qword ptr [7FFBF9F242B8]
       int       3
M01_L101:
       call      CORINFO_HELP_OVERFLOW
M01_L102:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L103:
       lea       rcx,[rbp-60]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFBF9E7FF18]
       jmp       near ptr M01_L09
M01_L104:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9735938]
       jmp       near ptr M01_L02
M01_L105:
       xor       ecx,ecx
       mov       [rbp-68],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L106:
       xor       ecx,ecx
       mov       [rbp-78],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L107:
       xor       eax,eax
       mov       [rbp-88],eax
       jmp       near ptr M01_L25
M01_L108:
       call      qword ptr [7FFBF97AE9D0]
       int       3
M01_L109:
       lea       rcx,[rbp-60]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFBF9E7FF18]
       jmp       near ptr M01_L27
M01_L110:
       lea       rcx,[rbp-60]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFBF9E7FF18]
       jmp       near ptr M01_L18
M01_L111:
       lea       rcx,[rbp-60]
       mov       rdx,23C718E0C30
       call      qword ptr [7FFBF97358F0]
       jmp       near ptr M01_L10
M01_L112:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9735938]
       jmp       near ptr M01_L11
M01_L113:
       lea       rcx,[rbp-60]
       mov       rdx,23C718E0C30
       call      qword ptr [7FFBF97358F0]
       jmp       near ptr M01_L19
M01_L114:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBF9735938]
       jmp       near ptr M01_L20
M01_L115:
       mov       rcx,rax
       mov       r11,7FFBF9410A68
       call      qword ptr [r11]
       jmp       near ptr M01_L99
M01_L116:
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
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+0F0]
       cmp       qword ptr [rbp-0C0],0
       je        short M01_L118
       mov       rcx,[rbp-0C0]
       mov       r15,[rcx]
       mov       rbx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       r15,rbx
       jne       short M01_L117
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L118
M01_L117:
       mov       r11,7FFBF9410A68
       call      qword ptr [r11]
M01_L118:
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
; Total bytes of code 3326
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
       je        near ptr M02_L22
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
       jge       near ptr M02_L05
       mov       [r15+10],ecx
       test      r14,r14
       je        near ptr M02_L23
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
       jge       near ptr M02_L06
       mov       [r15+10],r13d
M02_L00:
       test      rdi,rdi
       je        near ptr M02_L21
       mov       rcx,1FBE380E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M02_L24
       mov       rcx,[rcx+18]
M02_L01:
       mov       r15,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r15],rcx
       jne       near ptr M02_L27
       mov       rcx,[r15+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M02_L25
       lea       rcx,[r15+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M02_L25
M02_L02:
       mov       r13,[rbp-40]
M02_L03:
       xor       r8d,r8d
       mov       [rbp-40],r8
M02_L04:
       mov       [rbp-48],r13
       jmp       short M02_L07
M02_L05:
       mov       [r15+10],eax
       jmp       near ptr M02_L22
M02_L06:
       mov       [r15+10],ecx
       jmp       near ptr M02_L23
M02_L07:
       cmp       [r13],r13b
       lea       rdx,[rsi+0C]
       mov       r12d,[rsi+8]
       test      r12d,r12d
       je        short M02_L11
       mov       r8,[r13+8]
       mov       esi,[r13+18]
       lea       ecx,[rsi+r12]
       cmp       ecx,[r8+8]
       ja        short M02_L10
       movsxd    rcx,esi
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jg        short M02_L08
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r12d,2
       jne       short M02_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L09
M02_L08:
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L09:
       add       r12d,esi
       mov       [r13+18],r12d
       jmp       short M02_L11
M02_L10:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FFBF984CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L11:
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M02_L20
       xor       r12d,r12d
       test      esi,esi
       jle       near ptr M02_L20
M02_L12:
       mov       ecx,r12d
       mov       rcx,[rdi+rcx*8+10]
       test      bl,bl
       je        near ptr M02_L18
       test      rcx,rcx
       je        short M02_L17
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L17
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M02_L13
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L15
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L16
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L16
M02_L13:
       mov       rcx,r13
       call      qword ptr [7FFBF984CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L17
M02_L14:
       mov       rcx,r13
       mov       r8d,2
       call      qword ptr [7FFBF984CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L19
M02_L15:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L16:
       mov       [r13+18],r15d
M02_L17:
       mov       rdx,23C718E1C14
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r8d,[rax+2]
       cmp       [rcx+8],r8d
       jb        short M02_L14
       cdqe
       lea       rcx,[rcx+rax*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r13+18],r8d
       jmp       short M02_L19
M02_L18:
       mov       rdx,r14
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBF984C2A0]; System.Text.StringBuilder.Append(System.String)
M02_L19:
       inc       r12d
       cmp       esi,r12d
       jg        near ptr M02_L12
M02_L20:
       mov       rcx,r13
       call      qword ptr [7FFBF9856C50]; System.Text.StringBuilder.ToString()
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M02_L28
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
M02_L21:
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
M02_L22:
       mov       rax,23C718E0008
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
M02_L23:
       mov       r14,23C718E0008
       jmp       near ptr M02_L00
M02_L24:
       call      qword ptr [7FFBF990E160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L25:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9BBEEF8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M02_L26
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M02_L02
M02_L26:
       mov       rax,[r15+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r13,rax
       jmp       near ptr M02_L03
M02_L27:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r13,rax
       jmp       near ptr M02_L04
M02_L28:
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
       mov       rcx,1FBE380E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M02_L29
       call      qword ptr [7FFBF990E160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M02_L30
M02_L29:
       mov       r15,[rcx+18]
M02_L30:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r15],rcx
       jne       near ptr M02_L35
       mov       r13,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M02_L31
       mov       rsi,[rbp-48]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L36
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBF984C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L32
M02_L31:
       mov       rdx,[rbp-48]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       rsi,[rbp-48]
       je        short M02_L36
M02_L32:
       cmp       qword ptr [r15+20],0
       jne       short M02_L33
       lea       rcx,[r15+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L36
M02_L33:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M02_L34
       mov       rcx,[r15+18]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9BBEEC8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L36
M02_L34:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       short M02_L36
M02_L35:
       mov       rsi,[rbp-48]
       mov       rcx,r15
       mov       rdx,rsi
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M02_L36:
       nop
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
; Total bytes of code 1150
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rcx,2C244041F10
       mov       [rax+10],rcx
       mov       rcx,2C24405AF40
       mov       [rax+18],rcx
       mov       rcx,rsi
       mov       r8,rax
       mov       edx,3
       call      qword ptr [7FFBF98FCBB8]; DotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.StringComparison, System.String[])
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
       mov       rcx,2C244053890
       cmp       [rcx],ecx
       call      qword ptr [7FFBF948A770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FFBF9DBD260]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       call      qword ptr [7FFBF99967F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFBF9996748]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C24405AF58
       mov       r8,rbx
       call      qword ptr [7FFBF95FD470]
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,25DADDBAF40
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,25CF790AF40
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       mov       dword ptr [rsp+44],2C
       lea       rdx,[rsp+44]
       mov       [rsp+28],rdx
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      qword ptr [7FFBF95370C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rsi,rax
M00_L00:
       mov       [rsp+38],rsi
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
M00_L01:
       mov       rcx,7FFBF9475120
       mov       edx,61
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2A18C401F58
       mov       rsi,[rcx]
       jmp       short M00_L00
; Total bytes of code 167
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
       mov       rax,0F9FD1F12040C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      edi,edi
       jl        near ptr M01_L05
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L06
M01_L00:
       cmp       edi,1
       jle       near ptr M01_L07
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L07
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L09
M01_L01:
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
       call      qword ptr [7FFBF95371B0]; System.String.MakeSeparatorListAny(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+50]
       cmp       eax,[rbp+60]
       ja        near ptr M01_L10
       mov       r10,[rbp+58]
       test      eax,eax
       je        near ptr M01_L11
       test      r14d,r14d
       je        near ptr M01_L12
       xor       r15d,r15d
       mov       [rbp+18],r10
       mov       [rbp+20],eax
       mov       [rbp+8],r15
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],edi
       mov       [rsp+28],r14d
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FFBF9537198]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rdi,rax
M01_L02:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L03
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,2A18C401E70
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBF9B8A478]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L03:
       mov       rax,rdi
       mov       rcx,0F9FD1F12040C
       cmp       [rbp],rcx
       je        short M01_L04
       call      CORINFO_HELP_FAIL_FAST
M01_L04:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       ecx,1C7
       mov       rdx,7FFBF93E4000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFBF9DAF540]
       int       3
M01_L06:
       mov       ecx,45
       mov       edx,59
       call      qword ptr [7FFBF978ECB8]
       int       3
M01_L07:
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,edi
       call      qword ptr [7FFBF9537150]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       mov       rcx,0F9FD1F12040C
       cmp       [rbp],rcx
       je        short M01_L08
       call      CORINFO_HELP_FAIL_FAST
M01_L08:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       cmp       r15d,edi
       jge       near ptr M01_L01
       and       r14d,0FFFFFFFD
       jmp       near ptr M01_L01
M01_L10:
       call      qword ptr [7FFBF978E9D0]
       int       3
M01_L11:
       mov       edi,1
       jmp       near ptr M01_L00
M01_L12:
       xor       r15d,r15d
       mov       [rbp+18],r10
       mov       [rbp+20],eax
       mov       [rbp+8],r15
       xor       ecx,ecx
       mov       [rbp+10],ecx
       mov       [rsp+20],edi
       mov       rcx,rsi
       lea       rdx,[rbp+18]
       lea       r8,[rbp+8]
       mov       r9d,1
       call      qword ptr [7FFBF9537180]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rdi,rax
       jmp       near ptr M01_L02
; Total bytes of code 565
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsIgnoreCase()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vpcmpeqq  xmm0,xmm0,[7FFBF9E80170]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 39
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsOrBothNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2B15821AF40
       mov       rdx,2B15821AF78
       mov       r8d,4
       call      qword ptr [7FFBF95461D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       call      qword ptr [7FFBF95F5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF979ECB8]
       int       3
M01_L05:
       cmp       edi,5
       ja        near ptr M01_L08
       mov       eax,edi
       lea       rcx,[7FFBF9E7FDC8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFBF9744180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFBF9C0C198]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       rcx,7FFBF9485120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,270C64003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9C0C198]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
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
       jmp       qword ptr [7FFBF9545F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBF99FD338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFBF93F4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFBF954F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 391
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1D9AC42AF40
       mov       r8,1D9AC42AF60
       call      qword ptr [7FFBF990CC60]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
       call      qword ptr [7FFBF9557318]; System.String.Trim()
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
       call      qword ptr [7FFBF9557318]; System.String.Trim()
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
       call      qword ptr [7FFBF9557318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFBF95575D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFBF95575D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFBF9557240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FFBF99A69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFBF99A6730]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D9AC417C88
       mov       r8,rbx
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FFBF99A69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFBF99A6730]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D9AC42AF80
       mov       r8,rbx
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFBF99A69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFBF99A6730]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D9AC42AFA0
       mov       r8,rbx
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 472
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       call      qword ptr [7FFBF992CC78]; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
       je        near ptr M01_L16
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
       jge       near ptr M01_L06
       mov       [rsi+10],edx
       mov       rcx,12403C0E0C8
       mov       rdi,[rcx]
       lea       rdx,[rbx+0C]
       mov       [rbp-40],rdx
       mov       r14,[rbp-40]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       jle       short M01_L02
M01_L00:
       lea       edx,[rbx-1]
       movsxd    rdx,edx
       movzx     edx,word ptr [r14+rdx*2]
       cmp       edx,20
       je        short M01_L01
       cmp       edx,0A
       je        short M01_L01
       cmp       edx,0D
       je        short M01_L01
       cmp       edx,9
       jne       short M01_L02
M01_L01:
       dec       ebx
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
       jbe       near ptr M01_L17
       cmp       eax,3D
       je        short M01_L07
M01_L04:
       cmp       rdx,rsi
       jb        short M01_L03
M01_L05:
       test      r15d,r15d
       je        short M01_L08
       cmp       r15d,1
       jne       near ptr M01_L18
       mov       r15d,2
       jmp       short M01_L08
M01_L06:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L16
M01_L07:
       dec       ecx
       inc       r15d
       jmp       short M01_L04
M01_L08:
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
       mov       r15,rax
       test      ebx,ebx
       jl        near ptr M01_L20
       mov       ecx,ebx
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       mov       [rbp-68],r14
       mov       [rbp-60],ecx
       mov       [rbp-78],rdx
       mov       [rbp-70],r8d
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       lea       r8,[rbp-48]
       call      qword ptr [7FFBF98E4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L21
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       esi,[r15+8]
       test      esi,esi
       je        near ptr M01_L22
       mov       [rbp-50],r15
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       je        short M01_L11
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L28
       mov       r14,[rbp-50]
       add       r14,10
M01_L09:
       test      r14,r14
       je        short M01_L10
       mov       rcx,[rdi+18]
       mov       r15d,esi
       test      rcx,rcx
       je        near ptr M01_L23
       mov       rax,offset MT_System.Text.DecoderReplacementFallback
       cmp       [rcx],rax
       jne       near ptr M01_L23
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M01_L23
       jmp       short M01_L14
M01_L10:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFBF97CED18]
       int       3
M01_L11:
       xor       r14d,r14d
       jmp       short M01_L09
M01_L12:
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,r15
M01_L13:
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
M01_L14:
       mov       r13d,r15d
       cmp       r15d,esi
       jne       near ptr M01_L24
M01_L15:
       test      r13d,r13d
       je        near ptr M01_L25
       mov       ecx,r13d
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r8,[r15+0C]
       mov       [rbp-58],r8
       mov       r12,[rbp-58]
       test      r12,r12
       je        near ptr M01_L26
       mov       r8d,esi
       or        r8d,r13d
       jl        near ptr M01_L27
       cmp       r13d,esi
       mov       r8d,esi
       cmovle    r8d,r13d
       mov       rcx,r14
       mov       rdx,r12
       call      qword ptr [7FFBF97CC660]; System.Text.Ascii.WidenAsciiToUtf16(Byte*, Char*, UIntPtr)
       cmp       eax,esi
       je        short M01_L12
       mov       [rsp+20],r13d
       mov       [rsp+28],eax
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8d,esi
       mov       r9,r12
       call      qword ptr [7FFBF957CA08]
       jmp       near ptr M01_L12
M01_L16:
       mov       rax,16491DA0008
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
M01_L17:
       dec       ecx
       jmp       near ptr M01_L04
M01_L18:
       cmp       r15d,2
       jne       short M01_L19
       mov       r15d,1
       jmp       near ptr M01_L08
M01_L19:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9A27C78]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBF9847450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L20:
       call      qword ptr [7FFBF97CE9D0]
       int       3
M01_L21:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBF9A27C78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBF9847450]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rax,16491DA0008
       jmp       near ptr M01_L13
M01_L23:
       mov       edx,esi
       mov       rcx,r14
       call      qword ptr [7FFBF97CC468]; System.Text.Ascii.GetIndexOfFirstNonAsciiByte_Vector(Byte*, UIntPtr)
       mov       r15d,eax
       mov       r13d,r15d
       cmp       r15d,esi
       je        near ptr M01_L15
M01_L24:
       mov       rcx,rdi
       mov       rdx,r14
       mov       r8d,esi
       mov       r9d,r13d
       call      qword ptr [7FFBF957C990]
       add       eax,r13d
       mov       r13d,eax
       test      r13d,r13d
       jge       near ptr M01_L15
       call      qword ptr [7FFBF957C7E0]
       int       3
M01_L25:
       mov       rax,16491DA0008
       jmp       near ptr M01_L13
M01_L26:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFBF97CED18]
       int       3
M01_L27:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFBF97CED48]
       int       3
M01_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 971
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFBF9567318]; System.String.Trim()
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFBF9E8FAF8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFBF9E8FAF8]
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
       call      qword ptr [7FFBF95673F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFBF991C708]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFBF9F343A8]
       test      eax,eax
       jne       near ptr M01_L12
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFBF9F343A8]
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFBF9F343A8]
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
       call      qword ptr [7FFBF99B65B0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFBF99B6310]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1D74BBB7C88
       mov       r8,rbx
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFBF95673F0]
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

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       dword ptr [rsp+28],0A
       lea       rdx,[rsp+28]
       mov       r8d,3E
       call      qword ptr [7FFBF98ECD80]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32 ByRef, Char)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 79
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32 ByRef, Char)
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
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L28
       cmp       dword ptr [rbx],0
       jle       near ptr M01_L28
       mov       rcx,1BDEB80E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L29
       mov       rcx,[rcx+18]
M01_L00:
       mov       r14,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L32
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L30
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L30
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       r8d,r8d
       mov       [rbp-40],r8
M01_L03:
       mov       [rbp-48],r15
       cmp       dword ptr [rbx],0
       je        short M01_L05
M01_L04:
       mov       r14d,1
       jmp       short M01_L08
M01_L05:
       mov       rcx,r15
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBF982C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L04
M01_L06:
       mov       r8d,[r15+18]
       mov       ecx,r8d
       mov       rdx,[r15+8]
       mov       eax,[rdx+8]
       cmp       eax,ecx
       jbe       near ptr M01_L14
       mov       eax,ecx
       mov       [rdx+rax*2+10],si
       inc       r8d
       mov       [r15+18],r8d
M01_L07:
       add       r14d,1
       jo        short M01_L11
M01_L08:
       mov       r13d,[rbx]
       test      r13d,r13d
       jl        short M01_L13
M01_L09:
       cmp       r14d,r13d
       jle       short M01_L06
       cmp       dword ptr [rbx],0
       jle       near ptr M01_L17
       cmp       [r15],r15b
       lea       rdx,[rdi+0C]
       mov       r12d,[rdi+8]
       test      r12d,r12d
       je        near ptr M01_L17
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       edi,ecx
       lea       ecx,[rdi+r12]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M01_L16
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M01_L12
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       add       r12d,edi
       mov       [r15+18],r12d
       jmp       short M01_L17
M01_L11:
       call      CORINFO_HELP_OVERFLOW
M01_L12:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r12d,2
       jne       short M01_L10
       movzx     eax,word ptr [rdx+2]
       mov       [rcx+2],ax
       jmp       short M01_L10
M01_L13:
       neg       r13d
       jns       short M01_L09
       call      qword ptr [7FFBF9AF4708]
       int       3
M01_L14:
       movzx     edx,si
       mov       rcx,r15
       call      qword ptr [7FFBF982C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L07
M01_L15:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L16:
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFBF982CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L17:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9836C50]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       r13d,[rsi+8]
       lea       ebx,[r13-1]
       test      ebx,ebx
       jl        near ptr M01_L26
       cmp       r13d,ebx
       jle       short M01_L21
M01_L18:
       mov       ecx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L19
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       je        near ptr M01_L26
       jmp       short M01_L20
M01_L19:
       call      qword ptr [7FFBF9E5FAF8]
       test      eax,eax
       je        short M01_L26
M01_L20:
       dec       ebx
       jns       short M01_L18
       jmp       short M01_L26
M01_L21:
       cmp       ebx,r13d
       jae       short M01_L15
       mov       ecx,ebx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L24
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       je        short M01_L26
       jmp       short M01_L25
M01_L22:
       test      r14d,r14d
       je        short M01_L23
       mov       ecx,r14d
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       mov       r8d,r14d
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       lea       rdx,[rsi+0C]
       add       r8,r8
       call      qword ptr [7FFBF95E5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       jmp       short M01_L27
M01_L23:
       mov       rax,1FE7D750008
       jmp       short M01_L27
M01_L24:
       call      qword ptr [7FFBF9E5FAF8]
       test      eax,eax
       je        short M01_L26
M01_L25:
       dec       ebx
       jns       short M01_L21
M01_L26:
       lea       r14d,[rbx+1]
       cmp       r13d,r14d
       jne       short M01_L22
       mov       rax,rsi
M01_L27:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L33
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
M01_L28:
       mov       rax,1FE7D750008
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
M01_L29:
       call      qword ptr [7FFBF98EE160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L30:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9B9F168]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L31
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L31:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L32:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L33:
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
       mov       rcx,1BDEB80E110
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L34
       mov       r15,[rbp-48]
       call      qword ptr [7FFBF98EE160]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L35
M01_L34:
       mov       rbx,[rcx+18]
M01_L35:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       near ptr M01_L40
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L36
       mov       r15,[rbp-48]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L41
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFBF982C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L37
M01_L36:
       mov       r15,[rbp-48]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L41
M01_L37:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L38
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L41
M01_L38:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L39
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9B9F138]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L41
M01_L39:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L41
M01_L40:
       mov       r15,[rbp-48]
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L41:
       nop
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
; Total bytes of code 1060
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFBF98ECD98]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char)
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
       call      qword ptr [7FFBF9F04510]
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFBF98ECDB0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char)
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
       mov       rcx,7FFC58492C38
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFBF9F04510]
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFBF990CDC8]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char)
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
       mov       rcx,7FFC58492C38
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
       call      qword ptr [7FFBF9F24510]
       jmp       short M01_L00
; Total bytes of code 68
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       movzx     ecx,word ptr [rbx+180]
       call      qword ptr [7FFBF98ECDE0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char)
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
       mov       rcx,7FFC58492C38
       test      byte ptr [rax+rcx],80
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFBF9F043A8]
       jmp       short M01_L00
; Total bytes of code 50
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFBF98FCDF8]; DotNetTips.Spargine.Extensions.StringExtensions.IsCreditCardNumber(System.String)
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
       mov       rdx,26CFF40E0A8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BDD260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF9996940]
       mov       ecx,29B
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       call      qword ptr [7FFBF990CE10]; DotNetTips.Spargine.Extensions.StringExtensions.IsCurrencyCode(System.String)
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
       mov       rdx,17B4D00E0B0
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BED260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,29B
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFBF990CE28]; DotNetTips.Spargine.Extensions.StringExtensions.IsDomainAddress(System.String)
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
       mov       rdx,1A1D540E0B8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BED260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,29B
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       call      qword ptr [7FFBF992CE40]; DotNetTips.Spargine.Extensions.StringExtensions.IsEmailAddress(System.String)
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
       mov       rdx,26EF9C0C0C8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9C0D260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99C6940]
       mov       ecx,29B
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99C6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+168]
       call      qword ptr [7FFBF98FCE70]; DotNetTips.Spargine.Extensions.StringExtensions.IsFirstLastName(System.String)
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
       mov       rdx,1A2F6C0C0D8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BDD260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF9996940]
       mov       ecx,29B
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+108]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,2CE2F311F10
       xor       r8d,r8d
       call      qword ptr [7FFBF9627180]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rcx,rax
       call      qword ptr [7FFBF992CE88]; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
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
       call      qword ptr [7FFBF97FCF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFBF9627348]
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
       call      qword ptr [7FFBF9627348]
       int       3
; Total bytes of code 235
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsGuid(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rdx,28D9D40E0D8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M02_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9C0D260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M02_L00:
       call      qword ptr [7FFBF99C6940]
       mov       ecx,29B
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98F4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9960918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9576B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99C6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+150]
       call      qword ptr [7FFBF98ECEA0]; DotNetTips.Spargine.Extensions.StringExtensions.IsISBN(System.String)
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
       mov       rdx,1BFAAC0E0E0
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BCD260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF9986940]
       mov       ecx,29B
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9986730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,22C2089AF40
       call      qword ptr [7FFBF98EC858]; DotNetTips.Spargine.Extensions.StringExtensions.IsMacAddress(System.String)
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
       mov       rdx,1EB8E80E0E8
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BCC558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF9986520]
       mov       ecx,29B
       mov       rdx,7FFBF9921048
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4940
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9921048
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9986310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+160]
       call      qword ptr [7FFBF990CEE8]; DotNetTips.Spargine.Extensions.StringExtensions.IsOneToSevenAlpha(System.String)
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
       mov       rdx,1C87B80E0F0
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BED260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,29B
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2ECC41AAF40
       call      qword ptr [7FFBF990CF00]; DotNetTips.Spargine.Extensions.StringExtensions.IsScientific(System.String)
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
       mov       rdx,2AC3240E100
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BED260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99A6940]
       mov       ecx,29B
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98D4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9940918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9556B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99A6730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFBF98ECF18]; DotNetTips.Spargine.Extensions.StringExtensions.IsString(System.String)
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
       mov       rdx,1D8D640E118
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BCD260]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF9986940]
       mov       ecx,29B
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98B4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9920918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9536B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9986730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+148]
       call      qword ptr [7FFBF991C8D0]; DotNetTips.Spargine.Extensions.StringExtensions.IsStringSHA1Hash(System.String)
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
       mov       rdx,1D73280C110
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBF9BCF8B8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M01_L00:
       call      qword ptr [7FFBF99B6520]
       mov       ecx,29B
       mov       rdx,7FFBF9950268
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98E3C38
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9950268
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9566B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF99B6310]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 196
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       call      qword ptr [7FFBF98FCF48]; DotNetTips.Spargine.Extensions.StringExtensions.IsUrl(System.String)
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
       mov       rdx,18E2240C128
       mov       rdx,[rdx]
       mov       [rsp+20],rcx
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,rdx
       mov       rdx,[rsp+20]
       call      qword ptr [7FFBF9BDD308]; System.Text.RegularExpressions.Regex.Match(System.String)
       cmp       dword ptr [rax+30],0
       setne     al
       movzx     eax,al
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L00:
       call      qword ptr [7FFBF9996940]
       mov       ecx,29B
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,10A8
       mov       rdx,7FFBF98C4148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBF9930918
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBF9546B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBF9996730]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBF97C6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 207
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+170]
       call      qword ptr [7FFBF990CF78]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFBF9E7FB10]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFBF9E7FB10]
       test      eax,eax
       jne       near ptr M01_L10
M01_L05:
       cmp       [rbx],bl
       mov       rdx,190391A7578
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
       call      qword ptr [7FFBF9C14AB0]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FFBF9605B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FFBF99A69D0]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FFBF99A6730]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,190391A7C88
       mov       r8,rdi
       call      qword ptr [7FFBF97D6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFBF95573F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFBF9557258]
       int       3
M01_L12:
       mov       rbx,190391A0008
       jmp       near ptr M01_L07
M01_L13:
       jmp       near ptr M01_L07
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       call      qword ptr [7FFBF991CF90]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
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
       call      qword ptr [7FFBF9567318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,1C57BE4AF40
       cmp       [rcx],ecx
       call      qword ptr [7FFBF94AA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FFBF95670C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FFBF99B69D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFBF99B6730]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C57BE37C88
       mov       r8,rbx
       call      qword ptr [7FFBF97E6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FFBF99B67F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFBF99B6748]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C57BE38818
       mov       r8,rbx
       call      qword ptr [7FFBF961D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,14
       call      qword ptr [7FFBF97BED00]
       int       3
; Total bytes of code 395
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SplitRemoveEmpty()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFBF98ECFF0]; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
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
       call      qword ptr [7FFBF9537318]; System.String.Trim()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9537318]; System.String.Trim()
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
       call      qword ptr [7FFBF95370C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FFBF99869D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFBF9986730]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F6EE887C88
       mov       r8,rbx
       call      qword ptr [7FFBF97B6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       ecx,14
       call      qword ptr [7FFBF978ED00]
       int       3
; Total bytes of code 276
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1340
       cmp       [rbx],rcx
       jne       near ptr M00_L02
       mov       rsi,[rbx+50]
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L03
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFBF9BF22A0]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L03
       cmp       dword ptr [rsi+8],32
       jl        short M00_L04
       mov       rcx,rsi
       mov       edx,19
       mov       r8d,19
       call      qword ptr [7FFBF9567240]; System.String.Substring(Int32, Int32)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFBF9567318]; System.String.Trim()
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
       pop       rsi
       pop       rdi
       ret
       call      CORINFO_HELP_OVERFLOW
M00_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L03:
       mov       rax,28932480008
       jmp       short M00_L01
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A04
       mov       rdx,7FFBF9950268
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFBF99B6328]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBF961D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 282
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
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M02_L00
       test      ebx,ebx
       je        short M02_L01
       cmp       eax,ebx
       je        short M02_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FFBF9567258]
       int       3
M02_L01:
       mov       rax,28932480008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFBF9F343A8]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFBF9F343A8]
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
       call      qword ptr [7FFBF95673F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFBF98EC9F0]; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
       mov       rcx,1E7B1C0E0C8
       mov       rdi,[rcx]
       lea       rdx,[rbx+0C]
       mov       [rsp+40],rdx
       mov       rbp,[rsp+40]
       mov       r14d,[rbx+8]
       mov       rdx,[rdi+10]
       mov       r15d,r14d
       test      rdx,rdx
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Text.EncoderReplacementFallback
       cmp       [rdx],rcx
       jne       near ptr M01_L04
       mov       rdx,[rdx+8]
       cmp       dword ptr [rdx+8],1
       jne       near ptr M01_L04
       jmp       short M01_L01
M01_L00:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L03
M01_L01:
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
       call      qword ptr [7FFBF9BB35C8]; System.Text.ASCIIEncoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       lea       rcx,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FFBF98A4648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
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
       mov       rax,2283FCE0008
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
       call      qword ptr [7FFBF978C4C8]; System.Text.Ascii.GetIndexOfFirstNonAsciiChar_Vector(Char*, UIntPtr)
       mov       r15d,eax
       mov       esi,r15d
       cmp       r15d,r14d
       je        near ptr M01_L02
M01_L05:
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FFBF953C8A0]
       add       esi,eax
       jns       near ptr M01_L02
       call      qword ptr [7FFBF953C7E0]
       int       3
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 413
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
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
       mov       rax,17AF088AF40
       mov       [rcx+8],rax
       call      qword ptr [7FFBF9BE4258]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
       call      qword ptr [7FFBF9764180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFBF973BFC0]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,17AF088AF40
       cmp       [rcx],ecx
       call      qword ptr [7FFBF976C378]; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       rax,17AF088AF40
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
       mov       rax,13A5E800438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,13A5E800418
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
       jmp       qword ptr [7FFBF9764030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFBF976C018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
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
       mov       r14,7FFC584A1A98
       movzx     r8d,byte ptr [r8+r14]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r15,7FFC5849AAB0
       movzx     r8d,word ptr [r8+r15]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFC5849E5D8
       movzx     r8d,byte ptr [r8+r13]
       mov       r12,7FFC58492F38
       movzx     eax,byte ptr [r8+r12]
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
       call      qword ptr [7FFBF976C3A8]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       cmp       [r10+8],r9d
       jbe       short M04_L09
       mov       ecx,r9d
       movzx     ecx,word ptr [r10+rcx*2+0C]
       lea       r11d,[rcx-0D800]
       cmp       r11d,3FF
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
       movzx     edx,byte ptr [rdx+r14]
       shl       edx,6
       mov       r10d,ecx
       shr       r10d,3
       and       r10d,3E
       add       edx,r10d
       movzx     edx,word ptr [rdx+r15]
       shl       edx,4
       and       ecx,0F
       add       ecx,edx
       movzx     ecx,byte ptr [rcx+r13]
       movzx     ecx,byte ptr [rcx+r12]
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
       call      qword ptr [7FFBF9DD5608]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBF985C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFBF9866C50]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFBF9414000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97E66E8]
       int       3
M04_L26:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FFBF9414000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FFBF9DDF840]
       int       3
M04_L27:
       mov       ecx,2E5
       mov       rdx,7FFBF9414000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFBF97E66E8]
       int       3
M04_L28:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FFBF9414000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFBF9A16EE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFBF961D470]
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
       mov       rdx,17AF088AF68
       cmp       [rcx],ecx
       call      qword ptr [7FFBF985C2A0]; System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       near ptr M04_L07
M04_L34:
       inc       r9d
       cmp       [r10+8],r9d
       jbe       near ptr M04_L09
       mov       edx,r9d
       movzx     edx,word ptr [r10+rdx*2+0C]
       add       edx,0FFFF2400
       cmp       edx,3FF
       ja        near ptr M04_L09
       shl       r11d,0A
       lea       ecx,[r11+rdx+10000]
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
       call      qword ptr [7FFBF976C1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L36:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFBF985C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L38
M04_L37:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFBF985C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FFBF985CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M04_L18
M04_L43:
       mov       eax,[rsp+34]
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FFBF985C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L18
M04_L44:
       call      qword ptr [7FFBF985C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L19
M04_L45:
       call      qword ptr [7FFBF985C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r14d,ebp
       jmp       near ptr M04_L22
M04_L46:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FFBF976C390]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L23
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2040
```

## .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1350
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
       call      qword ptr [7FFBF9BE4258]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       rcx,rsi
       call      qword ptr [7FFBF9567318]; System.String.Trim()
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
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,rsi
       mov       r11,7FFBF94209E8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFBF94209F0
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       jne       short M02_L01
       jmp       near ptr M02_L16
M02_L00:
       call      qword ptr [7FFBF9F340F0]
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       je        short M02_L05
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FFBF9F340F0]
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L08
M02_L07:
       call      qword ptr [7FFBF9F340F0]
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
       mov       rax,7FFC58492C38
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L11
M02_L10:
       call      qword ptr [7FFBF9F340F0]
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
       call      qword ptr [7FFBF9615B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M02_L13
M02_L15:
       mov       rax,225498A0008
       jmp       short M02_L13
M02_L16:
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FFBF94F5CE0]; System.Char.IsWhiteSpace(Char)
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

