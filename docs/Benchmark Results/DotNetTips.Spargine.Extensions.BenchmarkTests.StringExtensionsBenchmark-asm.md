## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,27D44F60008
       mov       rax,27D44F74768
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,23E82120008
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rsi,2394D744768
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,2D7445C4768
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,64
       call      qword ptr [7FFE1884CD80]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18E0EF10]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE18E0EF10]
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
       call      qword ptr [7FFE185347B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE188ED2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE188ED0C8]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,31B992A7598
       mov       r8,rbx
       call      qword ptr [7FFE1853D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE184873F0]
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 311
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFE1885CDC8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
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
       call      qword ptr [7FFE185447B0]
       mov       ebx,eax
       jmp       short M01_L01
M01_L07:
       call      qword ptr [7FFE188FD2A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L08
       call      qword ptr [7FFE188FD0C8]
       mov       rdi,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23D3596BBE8
       mov       r8,rdi
       call      qword ptr [7FFE1854D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE185447B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23D3596BC10
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 333
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,1B0946D4768
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,1B0946D47A0
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,1B0946C0008
       mov       r8,1B0946C82D0
       call      qword ptr [7FFE18DC41B0]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE18BF4030]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FFE18BF4228]; System.Text.RegularExpressions.Regex.get_RightToLeft()
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
       mov       r9,1B0946D4768
       call      qword ptr [7FFE18BF42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18DCFE10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,1B0946D4810
       cmp       [rcx],ecx
       call      qword ptr [7FFE183CA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFE188ED170]
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
       call      qword ptr [7FFE188ED0C8]
       mov       rsi,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE1853D470]
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
       call      qword ptr [7FFE18BF4078]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FFE18DCF450]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE18DCF438]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFE18DCFD50]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FFE18BDE3A8
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
       mov       rcx,7FFE18BDE3A8
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1700280DC68
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FFE186EED30]
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
       test      byte ptr [7FFE18BDE3F9],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,1700280DC68
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
       call      qword ptr [7FFE18E7CB28]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE18E7CB28]
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE18467318]; System.String.Trim()
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE18DEEF10]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18DEEF10]
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
       call      qword ptr [7FFE184673F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split_WithCount()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       dword ptr [rsp+28],2C
       lea       r9,[rsp+28]
       mov       edx,2
       mov       r8d,2
       call      qword ptr [7FFE1885D020]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char ByRef)
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
; Total bytes of code 84
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char ByRef)
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
       mov       rbp,r9
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
       call      qword ptr [7FFE18497318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rdx,rax
       mov       rcx,25DE7A04768
       cmp       [rcx],ecx
       call      qword ptr [7FFE183DA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       movzx     ecx,word ptr [rbp]
       mov       [rax+10],cx
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+28],rax
       mov       dword ptr [rsp+30],1
       lea       rdx,[rsp+28]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFE184970C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FFE188FD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE188FD0B0]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,25DE79F7DC0
       mov       r8,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE188FD170]
       mov       rbp,rax
       test      rbp,rbp
       jne       short M01_L08
       call      qword ptr [7FFE188FD0C8]
       mov       rbp,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,25DE79F82D0
       mov       r8,rbp
       call      qword ptr [7FFE1854D470]
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
       call      qword ptr [7FFE185447B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L11:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L12
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25DE79F4368
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFE186FED00]
       int       3
M01_L14:
       mov       rcx,7FFE183D5120
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,21D55C01F78
       mov       rax,[rax]
       jmp       near ptr M01_L04
; Total bytes of code 629
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,16501400970
       mov       rdx,[rdx]
       call      qword ptr [7FFE1883CAB0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18477318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18500180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE188DCD98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE188DCAE0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1A58F537DC0
       mov       r8,rbx
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE188DCCF0]
       mov       ecx,0AD2
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE188051D0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188DCAE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1E7B68009C8
       mov       rdx,[rdx]
       call      qword ptr [7FFE1884D110]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18510180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE188ED368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE188ED0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,22844607DC0
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE188ED2C0]
       mov       ecx,0AD2
       mov       rdx,7FFE18881A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18881A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188ED0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,29952C009A0
       mov       rdx,[rdx]
       call      qword ptr [7FFE1884CAB0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18510180]; System.Text.Encoding.GetBytes(System.String)
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L04:
       call      qword ptr [7FFE188ECD98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE188ECAE0]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2D9E4CD7DC0
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE188ECCF0]
       mov       ecx,0AD2
       mov       rdx,7FFE188813F8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE188813F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188ECAE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE187650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 365
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,215D50009C0
       mov       rdx,[rdx]
       call      qword ptr [7FFE1882D110]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18467318]; System.String.Trim()
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
       jmp       qword ptr [7FFE184F0180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE188CD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE188CD0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,25662D57DC0
       mov       r8,rbx
       call      qword ptr [7FFE186F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE188CD2C0]
       mov       ecx,0AD2
       mov       rdx,7FFE18861A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18861A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188CD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE186F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,1C9D50009D0
       mov       rdx,[rdx]
       call      qword ptr [7FFE1884D110]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18510180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE188ED368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE188ED0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,20A63037DC0
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE188ED2C0]
       mov       ecx,0AD2
       mov       rdx,7FFE18881A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18881A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188ED0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2143A4009D8
       mov       rdx,[rdx]
       call      qword ptr [7FFE1883D110]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18477318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18500180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE188DD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE188DD0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,254C8507DC0
       mov       r8,rbx
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE188DD2C0]
       mov       ecx,0AD2
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188DD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,17C374009F0
       mov       rdx,[rdx]
       call      qword ptr [7FFE1883D110]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FFE18477318]; System.String.Trim()
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
       jmp       qword ptr [7FFE18500180]; System.Text.Encoding.GetBytes(System.String)
M01_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L04:
       call      qword ptr [7FFE188DD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE188DD0B0]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1BCC5247DC0
       mov       r8,rbx
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       call      qword ptr [7FFE188DD2C0]
       mov       ecx,0AD2
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188DD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE187550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 365
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       mov       dword ptr [rsp+30],0A
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE18854BA0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE1885CBD0]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,128
       vzeroupper
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-130],rsp
       mov       r14,rcx
       mov       rdi,rdx
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
       mov       [rbp-68],rcx
       mov       rcx,18B08001DE8
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE18820C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L102
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-50],r13
       mov       [rbp-48],r12d
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       byte ptr [rbp-54],0
       mov       r12d,[rdi]
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L103
M01_L02:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       mov       [rbp-0CC],eax
       mov       rcx,[rbp-68]
       test      r12d,r12d
       jl        near ptr M01_L42
       mov       ecx,r12d
       mov       edx,r12d
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       r8,7FFE773C87F8
       add       rcx,[r8+rdx*8]
       sar       rcx,20
       cmp       ecx,[rbp-0CC]
       jg        near ptr M01_L105
       mov       [rbp-70],ecx
       mov       [rbp-78],r13
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       r12d,0A
       jb        short M01_L05
       cmp       r12d,64
       jb        short M01_L04
       mov       rdx,18B08000290
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
       mov       rdx,18B08000290
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
       mov       [rbp-78],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rbp-78],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L104
       mov       ecx,[rbp-58]
       add       ecx,[rbp-70]
       mov       [rbp-58],ecx
M01_L09:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L111
       mov       rcx,18A82E50C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M01_L10:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L110
M01_L11:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r12,[rax+rdx*2]
       mov       r13d,[rbp-48]
       sub       r13d,ecx
       mov       rcx,[rbp-68]
       test      ebx,ebx
       jl        near ptr M01_L37
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE773C87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r13d
       jg        near ptr M01_L106
       mov       [rbp-80],eax
       mov       [rbp-88],r12
       movsxd    rcx,eax
       lea       rcx,[r12+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,18B08000290
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
       mov       rdx,18B08000290
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
       mov       [rbp-88],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rbp-88],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L112
       mov       ecx,[rbp-58]
       add       ecx,[rbp-80]
       mov       [rbp-58],ecx
M01_L18:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L113
       mov       rcx,18A82E50C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M01_L19:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L109
M01_L20:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-48]
       sub       r12d,ecx
       mov       rcx,[rbp-68]
       test      esi,esi
       jl        near ptr M01_L32
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE773C87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L107
       mov       [rbp-90],eax
       mov       [rbp-98],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,18B08000290
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
       mov       rdx,18B08000290
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
       mov       [rbp-98],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L114
       mov       ecx,[rbp-58]
       add       ecx,[rbp-90]
       mov       [rbp-58],ecx
M01_L27:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       [rbp-0E0],rax
       mov       [rbp-0D8],ecx
       lea       rcx,[rbp-0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r12,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r12,r12
       je        near ptr M01_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-9C],eax
       mov       rcx,7FFE183D5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L115
M01_L28:
       xor       eax,eax
       mov       dword ptr [rbp-0A4],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-9C]
       cmp       edx,r10d
       jbe       near ptr M01_L29
       mov       dword ptr [rbp-0A0],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M01_L116
       cmp       r10d,edx
       jae       near ptr M01_L137
       mov       [rbp-9C],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-110],r9
       mov       r11,[r9]
       mov       [rbp-118],r11
       mov       rcx,r9
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-110]
       mov       [rdx+8],ecx
       mov       rax,[rbp-118]
       test      rax,rax
       mov       [rbp-118],rax
       mov       eax,[rbp-0A0]
       mov       r10d,[rbp-9C]
       jne       near ptr M01_L117
M01_L29:
       mov       rcx,18B080005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L130
M01_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE1849EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L35
       mov       rax,[rax]
       mov       [rbp-40],rax
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,128
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
       test      rcx,rcx
       jne       short M01_L34
       call      qword ptr [7FFE1868F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L53
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L54
M01_L34:
       call      qword ptr [7FFE1868F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L33
M01_L35:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       edi,[rdi]
       test      edi,edi
       jle       near ptr M01_L57
       xor       eax,eax
       cmp       edi,7FFFFFFF
       setle     al
M01_L36:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L58
       mov       edi,1
       jmp       near ptr M01_L60
M01_L37:
       test      rcx,rcx
       jne       short M01_L39
       call      qword ptr [7FFE1868F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L38:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L49
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L50
M01_L39:
       call      qword ptr [7FFE1868F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L38
M01_L40:
       xor       edx,edx
M01_L41:
       mov       eax,edx
       test      edx,edx
       jne       near ptr M01_L72
       mov       ecx,1
       jmp       near ptr M01_L73
M01_L42:
       test      rcx,rcx
       jne       short M01_L44
       call      qword ptr [7FFE1868F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L43:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L46
M01_L44:
       call      qword ptr [7FFE1868F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L43
M01_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L46:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r13
       mov       r13d,[rbp-0CC]
       mov       [rbp-0E8],r13d
       lea       rcx,[rbp-70]
       mov       [rsp+20],rcx
       mov       ecx,r12d
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E27FA8]
       jmp       near ptr M01_L08
M01_L47:
       xor       eax,eax
M01_L48:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L74
       mov       edx,1
       jmp       near ptr M01_L75
M01_L49:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L50:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r12
       mov       [rbp-0E8],r13d
       lea       rcx,[rbp-80]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E27FA8]
       jmp       near ptr M01_L17
M01_L51:
       xor       eax,eax
M01_L52:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L76
       mov       ecx,1
       jmp       near ptr M01_L77
M01_L53:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L54:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r13
       mov       [rbp-0E8],r12d
       lea       rcx,[rbp-90]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E27FA8]
       jmp       near ptr M01_L26
M01_L55:
       xor       eax,eax
M01_L56:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L78
       mov       edx,1
       jmp       near ptr M01_L79
M01_L57:
       xor       eax,eax
       jmp       near ptr M01_L36
M01_L58:
       test      ecx,ecx
       jne       short M01_L60
       call      qword ptr [7FFE188FD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L59
       call      qword ptr [7FFE188FD0C8]
       mov       r12,rax
M01_L59:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,18A82E54368
       mov       r8,r12
       call      qword ptr [7FFE1854D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L60:
       test      ebx,ebx
       jle       short M01_L61
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       jmp       short M01_L62
M01_L61:
       xor       eax,eax
M01_L62:
       mov       ecx,eax
       test      eax,eax
       jne       short M01_L63
       mov       ebx,1
       jmp       short M01_L65
M01_L63:
       test      ecx,ecx
       jne       short M01_L65
       call      qword ptr [7FFE188FD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L64
       call      qword ptr [7FFE188FD0C8]
       mov       r12,rax
M01_L64:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18A82E5BBE8
       mov       r8,r12
       call      qword ptr [7FFE1854D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L65:
       test      esi,esi
       jle       short M01_L66
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
       jmp       short M01_L67
M01_L66:
       xor       eax,eax
M01_L67:
       mov       ecx,eax
       test      eax,eax
       jne       short M01_L68
       mov       esi,1
       jmp       short M01_L70
M01_L68:
       test      ecx,ecx
       jne       short M01_L70
       call      qword ptr [7FFE188FD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L69
       call      qword ptr [7FFE188FD0C8]
       mov       r12,rax
M01_L69:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18A82E5BC10
       mov       r8,r12
       call      qword ptr [7FFE1854D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFE1854DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M01_L83
M01_L71:
       mov       ecx,ebx
       test      ecx,ecx
       jle       near ptr M01_L40
       xor       edx,edx
       cmp       ebx,7FFFFFFF
       setle     dl
       jmp       near ptr M01_L41
M01_L72:
       test      eax,eax
       je        near ptr M01_L84
M01_L73:
       mov       edx,esi
       test      esi,esi
       jle       near ptr M01_L47
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
       jmp       near ptr M01_L48
M01_L74:
       test      r8d,r8d
       je        near ptr M01_L86
M01_L75:
       test      ecx,ecx
       jle       near ptr M01_L51
       xor       eax,eax
       cmp       ecx,7FFFFFFF
       setle     al
       jmp       near ptr M01_L52
M01_L76:
       test      r8d,r8d
       je        near ptr M01_L88
M01_L77:
       test      edx,edx
       jle       near ptr M01_L55
       xor       eax,eax
       cmp       edx,7FFFFFFF
       setle     al
       jmp       near ptr M01_L56
M01_L78:
       test      r8d,r8d
       je        near ptr M01_L90
M01_L79:
       mov       eax,ecx
       add       eax,1
       jo        near ptr M01_L101
       cmp       edx,eax
       jl        short M01_L80
       jmp       short M01_L81
M01_L80:
       mov       edx,eax
M01_L81:
       call      qword ptr [7FFE1885D8F0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE18857CF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L135
       lea       r10d,[rdx+1]
       mov       [r12+10],r10d
       cmp       edx,r8d
       jae       near ptr M01_L137
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L82:
       add       r15d,1
       jo        near ptr M01_L101
       cmp       r15d,edi
       jl        near ptr M01_L71
M01_L83:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FFE1885C330]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       r11,7FFE18350BA0
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE188916E0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0F8],rax
       jmp       near ptr M01_L92
M01_L84:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L85
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L85:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,18A82E5BBE8
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L86:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L87
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L87:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,18A82E5BC10
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L88:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L89
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L89:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,18A82E5BBE8
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L90:
       call      qword ptr [7FFE188FD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L91
       call      qword ptr [7FFE188FD0C8]
       mov       rbx,rax
M01_L91:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,18A82E5BC10
       mov       r8,rbx
       call      qword ptr [7FFE1854D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L92:
       jmp       short M01_L95
M01_L93:
       cmp       rbx,rdi
       jne       short M01_L97
       mov       rax,[rbp-0F8]
       mov       rdx,[rax+10]
M01_L94:
       cmp       r12d,[rsi+8]
       jae       short M01_L96
       mov       ecx,r12d
       lea       rcx,[rsi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rax,[rbp-0F8]
M01_L95:
       mov       rbx,[rax]
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rbx,rdi
       jne       short M01_L98
       mov       rdx,rbx
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE1874E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L99
M01_L96:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L97:
       mov       rcx,[rbp-0F8]
       mov       r11,7FFE18350B78
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L94
M01_L98:
       mov       rcx,rax
       mov       r11,7FFE18350B70
       call      qword ptr [r11]
M01_L99:
       test      eax,eax
       jne       near ptr M01_L93
       mov       rax,[rbp-0F8]
       test      rax,rax
       je        short M01_L100
       cmp       rbx,rdi
       jne       near ptr M01_L136
       movsx     rdx,byte ptr [rax+8]
M01_L100:
       mov       [rbp-40],rsi
       mov       rdx,[r14+10]
       lea       r9,[rbp-40]
       mov       r8,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.String, System.Private.CoreLib],[System.String[], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String[]>, System.String, System.String[] ByRef)
       call      qword ptr [7FFE18DD43A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       jmp       near ptr M01_L31
M01_L101:
       call      CORINFO_HELP_OVERFLOW
M01_L102:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L103:
       lea       rcx,[rbp-68]
       mov       edx,r12d
       xor       r8d,r8d
       call      qword ptr [7FFE18E2D8A8]
       jmp       near ptr M01_L09
M01_L104:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18685938]
       jmp       near ptr M01_L02
M01_L105:
       xor       ecx,ecx
       mov       [rbp-70],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L106:
       xor       ecx,ecx
       mov       [rbp-80],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L107:
       xor       eax,eax
       mov       [rbp-90],eax
       jmp       near ptr M01_L25
M01_L108:
       call      qword ptr [7FFE186FE9D0]
       int       3
M01_L109:
       lea       rcx,[rbp-68]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE18E2D8A8]
       jmp       near ptr M01_L27
M01_L110:
       lea       rcx,[rbp-68]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE18E2D8A8]
       jmp       near ptr M01_L18
M01_L111:
       lea       rcx,[rbp-68]
       mov       rdx,18A82E50C30
       call      qword ptr [7FFE186858F0]
       jmp       near ptr M01_L10
M01_L112:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18685938]
       jmp       near ptr M01_L11
M01_L113:
       lea       rcx,[rbp-68]
       mov       rdx,18A82E50C30
       call      qword ptr [7FFE186858F0]
       jmp       near ptr M01_L19
M01_L114:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18685938]
       jmp       near ptr M01_L20
M01_L115:
       mov       rcx,r15
       call      qword ptr [7FFE1881E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L28
M01_L116:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE1894EAC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE1849F750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L117:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L137
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-0A0],eax
       jne       short M01_L119
       mov       rcx,r15
       mov       [rbp-9C],r10d
       mov       edx,r10d
       call      qword ptr [7FFE1881E898]
       mov       r9,rax
M01_L118:
       mov       rdx,[r9+8]
       mov       [rbp-120],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0C0],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0C0]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L120
       call      qword ptr [7FFE18D3E1D8]
       mov       edx,eax
       mov       [rbp-0BC],edx
       jmp       short M01_L121
M01_L119:
       mov       [rbp-9C],r10d
       jmp       short M01_L118
M01_L120:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0BC],edx
M01_L121:
       mov       rcx,7FFE183D5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0BC]
       xor       edx,edx
       div       dword ptr [7FFE183D5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L128
M01_L122:
       cmp       eax,[r8+8]
       jae       near ptr M01_L137
       mov       [rbp-0B4],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-128],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0C4],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-128]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-0C8],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L124
       test      r10d,r10d
       jne       short M01_L125
       xor       edx,edx
       mov       [rax+14],edx
M01_L123:
       movsxd    rdx,r10d
       mov       r8,[rbp-118]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C8]
       inc       ecx
       mov       rax,[rbp-128]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0C4],1
M01_L124:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0C4]
       test      ecx,ecx
       je        short M01_L126
       mov       r8d,1
       jmp       short M01_L129
M01_L125:
       jmp       short M01_L123
M01_L126:
       mov       eax,[rbp-0B4]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-120]
       cmp       [rcx+8],r8d
       jne       short M01_L127
       xor       r8d,r8d
M01_L127:
       mov       edx,[rbp-0B8]
       inc       edx
       mov       eax,r8d
M01_L128:
       mov       r8,[rbp-120]
       mov       [rbp-0B8],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L122
       xor       r8d,r8d
M01_L129:
       mov       eax,r8d
       mov       [rbp-0A4],eax
       mov       eax,[rbp-0A0]
       mov       r10d,[rbp-9C]
       jmp       near ptr M01_L29
M01_L130:
       mov       edx,r10d
       mov       r8,r9
       mov       r10d,eax
       mov       eax,[rbp-0A4]
       cmp       dword ptr [r12+8],0
       mov       [rbp-9C],edx
       mov       [rbp-100],r8
       mov       [rbp-0A0],r10d
       mov       [rbp-0A4],eax
       je        near ptr M01_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A8],eax
       mov       edx,[r12+8]
       mov       [rbp-0AC],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-100]
       mov       r8d,[rbp-0A8]
       mov       r9d,[rbp-0AC]
       mov       edx,3
       call      qword ptr [7FFE18547678]
       mov       eax,[rbp-0A0]
       test      [rbp-0A4],eax
       mov       [rbp-0A0],eax
       jne       near ptr M01_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rbp-100]
       mov       [rbp-108],rdx
       mov       [rbp-0B0],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rbp-0A0]
       test      r15d,r15d
       jne       short M01_L131
       mov       rcx,[rbp-108]
       mov       edx,[rbp-0B0]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L132
M01_L131:
       mov       rcx,[rbp-108]
       mov       edx,[rbp-0B0]
       mov       r8d,[rbp-9C]
M01_L132:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L133
       mov       eax,1
       jmp       short M01_L134
M01_L133:
       xor       eax,eax
M01_L134:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE1881F360]
       jmp       near ptr M01_L30
M01_L135:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFE1854E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L82
M01_L136:
       mov       rcx,rax
       mov       r11,7FFE18350B80
       call      qword ptr [r11]
       jmp       near ptr M01_L100
M01_L137:
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
       lea       rbp,[rbp+160]
       cmp       qword ptr [rbp-0F8],0
       je        short M01_L139
       mov       rcx,[rbp-0F8]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rbx,rdi
       jne       short M01_L138
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L139
M01_L138:
       mov       r11,7FFE18350B80
       call      qword ptr [r11]
M01_L139:
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
; Total bytes of code 4355
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
       call      qword ptr [7FFE183E7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,rbp
       xor       ecx,ecx
       call      qword ptr [7FFE18DD45A0]; DotNetTips.Spargine.Core.FastStringBuilder.CombineStrings(Boolean, System.String[])
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       call      qword ptr [7FFE188FD2C0]
       mov       ecx,0A0A
       mov       rdx,7FFE18891A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18891A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188FD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       call      qword ptr [7FFE188FD2C0]
       mov       ecx,2F7
       mov       rdx,7FFE18891A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18891A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188FD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       ecx,28
       mov       edx,35
       call      qword ptr [7FFE186FED48]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 463
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeHash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       xor       edx,edx
       call      qword ptr [7FFE1882CBE8]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M01_L22
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14d,[rdi+10]
       inc       r14d
       mov       ecx,r14d
       mov       rdx,[rdi+8]
       mov       r15d,[rdx+8]
       cmp       ecx,r15d
       jge       near ptr M01_L04
       mov       [rdi+10],ecx
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFE1882CBA0]; DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rbx,rax
       mov       rcx,17465C0E5F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L23
       mov       rcx,[rcx+18]
M01_L00:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L26
       mov       rcx,[rsi+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L24
       lea       rcx,[rsi+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L24
M01_L01:
       mov       rdi,[rbp-38]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M01_L03:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE1876C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-40],rdi
       jmp       short M01_L05
M01_L04:
       mov       [rdi+10],r15d
       jmp       near ptr M01_L22
M01_L05:
       test      rbx,rbx
       je        near ptr M01_L07
       lea       rsi,[rbx+10]
       mov       ebx,[rbx+8]
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L15
M01_L06:
       mov       ecx,r15d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,17465C00428
       mov       r8,[r8]
       mov       rdx,1B4F7C3BED8
       call      qword ptr [7FFE186A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L14
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        near ptr M01_L13
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       near ptr M01_L12
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M01_L12
M01_L07:
       call      qword ptr [7FFE188CD2C0]
       mov       ecx,0F
       mov       rdx,7FFE18861A48
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE18861A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE188CD0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE186F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rax,rbx
       jmp       near ptr M01_L21
M01_L09:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184673F0]
       mov       rbx,rax
       jmp       near ptr M01_L20
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18515B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L12:
       mov       [rdi+18],r13d
       jmp       short M01_L14
M01_L13:
       mov       rcx,rdi
       call      qword ptr [7FFE1876CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       inc       r15d
       cmp       r15d,ebx
       jl        near ptr M01_L06
M01_L15:
       mov       rcx,rdi
       call      qword ptr [7FFE18777A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L08
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       cmp       r14d,ecx
       jge       short M01_L16
       mov       [rsi+10],r14d
       cmp       dword ptr [rbx+8],0
       je        short M01_L20
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L18
M01_L16:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L08
M01_L17:
       call      qword ptr [7FFE18E3CDB0]
       test      eax,eax
       jne       near ptr M01_L09
M01_L18:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L10
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L19
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L20
M01_L19:
       call      qword ptr [7FFE18E3CDB0]
       test      eax,eax
       jne       near ptr M01_L09
M01_L20:
       mov       rax,rbx
M01_L21:
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M01_L27
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
       mov       rax,1B4F7C30008
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
       call      qword ptr [7FFE1882E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L24:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18B96328]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L25
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L01
M01_L25:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L02
M01_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L03
M01_L27:
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
       mov       rcx,17465C0E5F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L28
       call      qword ptr [7FFE1882E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L29
M01_L28:
       mov       rsi,[rcx+18]
M01_L29:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L34
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M01_L30
       mov       r14,[rbp-40]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L35
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE1876C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-40]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       r14,[rbp-40]
       je        short M01_L35
M01_L31:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L32
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L35
M01_L32:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L33
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFE18B962F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L35
M01_L33:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L35
M01_L34:
       mov       r14,[rbp-40]
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L35:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1250
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeSHA256Hash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE1884CC00]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
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
       mov       r8,18E3FC009F0
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
       call      qword ptr [7FFE1876D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       call      qword ptr [7FFE186D9E58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
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
       mov       rcx,1CED19FBD08
       xor       r9d,r9d
       call      qword ptr [7FFE18BBCC90]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,rsi
       call      qword ptr [7FFE18BBC420]; DotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
       mov       rax,1CED19F0008
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
       call      qword ptr [7FFE187650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r14d
       call      qword ptr [7FFE1848C8A0]
       add       r15d,eax
       jns       near ptr M01_L00
M01_L06:
       call      qword ptr [7FFE1848C7E0]
       int       3
M01_L07:
       mov       ecx,6A61
       mov       rdx,7FFE188844C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18E56A60]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFE188844C0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 658
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+28]
       mov       dword ptr [rsp+30],0A
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFE18834BA0]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,2C7823A0C60
       mov       r8d,1
       call      qword ptr [7FFE1883CC18]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 118
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,128
       vzeroupper
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-130],rsp
       mov       r14,rcx
       mov       rdi,rdx
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
       mov       [rbp-68],rcx
       mov       rcx,286F0401DE8
       mov       r15,[rcx]
       mov       rcx,r15
       mov       edx,100
       call      qword ptr [7FFE18800C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-60],rax
       test      rax,rax
       je        near ptr M01_L102
       lea       r13,[rax+10]
       mov       r12d,[rax+8]
M01_L01:
       mov       [rbp-50],r13
       mov       [rbp-48],r12d
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       byte ptr [rbp-54],0
       mov       r12d,[rdi]
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L103
M01_L02:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       eax,[rbp-48]
       sub       eax,ecx
       mov       [rbp-0CC],eax
       mov       rcx,[rbp-68]
       test      r12d,r12d
       jl        near ptr M01_L42
       mov       ecx,r12d
       mov       edx,r12d
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       r8,7FFE773C87F8
       add       rcx,[r8+rdx*8]
       sar       rcx,20
       cmp       ecx,[rbp-0CC]
       jg        near ptr M01_L105
       mov       [rbp-70],ecx
       mov       [rbp-78],r13
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       mov       eax,r12d
       cmp       r12d,0A
       jb        short M01_L05
       cmp       r12d,64
       jb        short M01_L04
       mov       rdx,286F0400290
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
       mov       rdx,286F0400290
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
       mov       [rbp-78],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rbp-78],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L104
       mov       ecx,[rbp-58]
       add       ecx,[rbp-70]
       mov       [rbp-58],ecx
M01_L09:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L111
       mov       rcx,2C7823A0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M01_L10:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L110
M01_L11:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r12,[rax+rdx*2]
       mov       r13d,[rbp-48]
       sub       r13d,ecx
       mov       rcx,[rbp-68]
       test      ebx,ebx
       jl        near ptr M01_L37
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE773C87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r13d
       jg        near ptr M01_L106
       mov       [rbp-80],eax
       mov       [rbp-88],r12
       movsxd    rcx,eax
       lea       rcx,[r12+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,286F0400290
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
       mov       rdx,286F0400290
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
       mov       [rbp-88],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rbp-88],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L112
       mov       ecx,[rbp-58]
       add       ecx,[rbp-80]
       mov       [rbp-58],ecx
M01_L18:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rbp-48]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L113
       mov       rcx,2C7823A0C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M01_L19:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M01_L109
M01_L20:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r12d,[rbp-48]
       sub       r12d,ecx
       mov       rcx,[rbp-68]
       test      esi,esi
       jl        near ptr M01_L32
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFE773C87F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r12d
       jg        near ptr M01_L107
       mov       [rbp-90],eax
       mov       [rbp-98],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       rdx,286F0400290
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
       mov       rdx,286F0400290
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
       mov       [rbp-98],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L114
       mov       ecx,[rbp-58]
       add       ecx,[rbp-90]
       mov       [rbp-58],ecx
M01_L27:
       mov       ecx,[rbp-58]
       cmp       ecx,[rbp-48]
       ja        near ptr M01_L108
       mov       rax,[rbp-50]
       mov       [rbp-0E0],rax
       mov       [rbp-0D8],ecx
       lea       rcx,[rbp-0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       mov       r12,[rbp-60]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-68],ymm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       test      r12,r12
       je        near ptr M01_L30
       mov       ecx,[r12+8]
       dec       ecx
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp-9C],eax
       mov       rcx,7FFE183B5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L115
M01_L28:
       xor       eax,eax
       mov       dword ptr [rbp-0A4],1
       mov       edx,[rcx+8]
       mov       r10d,[rbp-9C]
       cmp       edx,r10d
       jbe       near ptr M01_L29
       mov       dword ptr [rbp-0A0],1
       mov       r9d,10
       shlx      r9d,r9d,r10d
       cmp       [r12+8],r9d
       jne       near ptr M01_L116
       cmp       r10d,edx
       jae       near ptr M01_L137
       mov       [rbp-9C],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[rcx+rdx+10]
       mov       [rbp-110],r9
       mov       r11,[r9]
       mov       [rbp-118],r11
       mov       rcx,r9
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-110]
       mov       [rdx+8],ecx
       mov       rax,[rbp-118]
       test      rax,rax
       mov       [rbp-118],rax
       mov       eax,[rbp-0A0]
       mov       r10d,[rbp-9C]
       jne       near ptr M01_L117
M01_L29:
       mov       rcx,286F04005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L130
M01_L30:
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,r13
       call      qword ptr [7FFE1847EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L35
       mov       rax,[rax]
       mov       [rbp-40],rax
M01_L31:
       mov       rax,[rbp-40]
       add       rsp,128
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
       test      rcx,rcx
       jne       short M01_L34
       call      qword ptr [7FFE1866F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L33:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L53
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L54
M01_L34:
       call      qword ptr [7FFE1866F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L33
M01_L35:
       xor       eax,eax
       mov       [rbp-40],rax
       mov       edi,[rdi]
       test      edi,edi
       jle       near ptr M01_L57
       xor       eax,eax
       cmp       edi,7FFFFFFF
       setle     al
M01_L36:
       mov       ecx,eax
       test      eax,eax
       jne       near ptr M01_L58
       mov       edi,1
       jmp       near ptr M01_L60
M01_L37:
       test      rcx,rcx
       jne       short M01_L39
       call      qword ptr [7FFE1866F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L38:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       near ptr M01_L49
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       near ptr M01_L50
M01_L39:
       call      qword ptr [7FFE1866F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L38
M01_L40:
       xor       edx,edx
M01_L41:
       mov       eax,edx
       test      edx,edx
       jne       near ptr M01_L72
       mov       ecx,1
       jmp       near ptr M01_L73
M01_L42:
       test      rcx,rcx
       jne       short M01_L44
       call      qword ptr [7FFE1866F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L43:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L45
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L46
M01_L44:
       call      qword ptr [7FFE1866F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L43
M01_L45:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L46:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r13
       mov       r13d,[rbp-0CC]
       mov       [rbp-0E8],r13d
       lea       rcx,[rbp-70]
       mov       [rsp+20],rcx
       mov       ecx,r12d
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E07FA8]
       jmp       near ptr M01_L08
M01_L47:
       xor       eax,eax
M01_L48:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L74
       mov       edx,1
       jmp       near ptr M01_L75
M01_L49:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L50:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r12
       mov       [rbp-0E8],r13d
       lea       rcx,[rbp-80]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E07FA8]
       jmp       near ptr M01_L17
M01_L51:
       xor       eax,eax
M01_L52:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L76
       mov       ecx,1
       jmp       near ptr M01_L77
M01_L53:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L54:
       mov       [rbp-0E0],r8
       mov       [rbp-0D8],r9d
       mov       [rbp-0F0],r13
       mov       [rbp-0E8],r12d
       lea       rcx,[rbp-90]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rbp-0E0]
       lea       r9,[rbp-0F0]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE18E07FA8]
       jmp       near ptr M01_L26
M01_L55:
       xor       eax,eax
M01_L56:
       mov       r8d,eax
       test      eax,eax
       jne       near ptr M01_L78
       mov       edx,1
       jmp       near ptr M01_L79
M01_L57:
       xor       eax,eax
       jmp       near ptr M01_L36
M01_L58:
       test      ecx,ecx
       jne       short M01_L60
       call      qword ptr [7FFE188DD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L59
       call      qword ptr [7FFE188DD0C8]
       mov       r12,rax
M01_L59:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2C7823A4368
       mov       r8,r12
       call      qword ptr [7FFE1852D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L60:
       test      ebx,ebx
       jle       short M01_L61
       xor       eax,eax
       cmp       ebx,7FFFFFFF
       setle     al
       jmp       short M01_L62
M01_L61:
       xor       eax,eax
M01_L62:
       mov       ecx,eax
       test      eax,eax
       jne       short M01_L63
       mov       ebx,1
       jmp       short M01_L65
M01_L63:
       test      ecx,ecx
       jne       short M01_L65
       call      qword ptr [7FFE188DD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L64
       call      qword ptr [7FFE188DD0C8]
       mov       r12,rax
M01_L64:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C7823ABBE8
       mov       r8,r12
       call      qword ptr [7FFE1852D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L65:
       test      esi,esi
       jle       short M01_L66
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
       jmp       short M01_L67
M01_L66:
       xor       eax,eax
M01_L67:
       mov       ecx,eax
       test      eax,eax
       jne       short M01_L68
       mov       esi,1
       jmp       short M01_L70
M01_L68:
       test      ecx,ecx
       jne       short M01_L70
       call      qword ptr [7FFE188DD2A8]
       mov       r12,rax
       test      r12,r12
       jne       short M01_L69
       call      qword ptr [7FFE188DD0C8]
       mov       r12,rax
M01_L69:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2C7823ABC10
       mov       r8,r12
       call      qword ptr [7FFE1852D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,edi
       call      qword ptr [7FFE1852DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r15d,r15d
       test      edi,edi
       jle       near ptr M01_L82
M01_L71:
       mov       ecx,ebx
       test      ecx,ecx
       jle       near ptr M01_L40
       xor       edx,edx
       cmp       ebx,7FFFFFFF
       setle     dl
       jmp       near ptr M01_L41
M01_L72:
       test      eax,eax
       je        near ptr M01_L84
M01_L73:
       mov       edx,esi
       test      esi,esi
       jle       near ptr M01_L47
       xor       eax,eax
       cmp       esi,7FFFFFFF
       setle     al
       jmp       near ptr M01_L48
M01_L74:
       test      r8d,r8d
       je        near ptr M01_L86
M01_L75:
       test      ecx,ecx
       jle       near ptr M01_L51
       xor       eax,eax
       cmp       ecx,7FFFFFFF
       setle     al
       jmp       near ptr M01_L52
M01_L76:
       test      r8d,r8d
       je        near ptr M01_L88
M01_L77:
       test      edx,edx
       jle       near ptr M01_L55
       xor       eax,eax
       cmp       edx,7FFFFFFF
       setle     al
       jmp       near ptr M01_L56
M01_L78:
       test      r8d,r8d
       je        near ptr M01_L90
M01_L79:
       mov       eax,ecx
       add       eax,1
       jo        near ptr M01_L101
       cmp       edx,eax
       jl        near ptr M01_L83
M01_L80:
       call      qword ptr [7FFE1883D8F0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE18837CF0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L135
       lea       r10d,[rdx+1]
       mov       [r12+10],r10d
       cmp       edx,r8d
       jae       near ptr M01_L137
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L81:
       add       r15d,1
       jo        near ptr M01_L101
       cmp       r15d,edi
       jl        near ptr M01_L71
M01_L82:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FFE1883C330]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       xor       r12d,r12d
       mov       rcx,[rbx+8]
       mov       r11,7FFE18330BC0
       call      qword ptr [r11]
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE188716E0]; Precode of System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       mov       [rbp-0F8],rax
       jmp       near ptr M01_L92
M01_L83:
       mov       edx,eax
       jmp       near ptr M01_L80
M01_L84:
       call      qword ptr [7FFE188DD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L85
       call      qword ptr [7FFE188DD0C8]
       mov       rbx,rax
M01_L85:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2C7823ABBE8
       mov       r8,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L86:
       call      qword ptr [7FFE188DD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L87
       call      qword ptr [7FFE188DD0C8]
       mov       rbx,rax
M01_L87:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,2C7823ABC10
       mov       r8,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L88:
       call      qword ptr [7FFE188DD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L89
       call      qword ptr [7FFE188DD0C8]
       mov       rbx,rax
M01_L89:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C7823ABBE8
       mov       r8,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L90:
       call      qword ptr [7FFE188DD2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L91
       call      qword ptr [7FFE188DD0C8]
       mov       rbx,rax
M01_L91:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2C7823ABC10
       mov       r8,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L92:
       jmp       short M01_L95
M01_L93:
       cmp       rbx,rdi
       jne       short M01_L97
       mov       rax,[rbp-0F8]
       mov       rdx,[rax+10]
M01_L94:
       cmp       r12d,[rsi+8]
       jae       short M01_L96
       mov       ecx,r12d
       lea       rcx,[rsi+rcx*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       rax,[rbp-0F8]
M01_L95:
       mov       rbx,[rax]
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rbx,rdi
       jne       short M01_L98
       mov       rdx,rbx
       lea       rcx,[rax+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE1872E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       jmp       short M01_L99
M01_L96:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L97:
       mov       rcx,[rbp-0F8]
       mov       r11,7FFE18330B98
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M01_L94
M01_L98:
       mov       rcx,rax
       mov       r11,7FFE18330B90
       call      qword ptr [r11]
M01_L99:
       test      eax,eax
       jne       near ptr M01_L93
       mov       rax,[rbp-0F8]
       test      rax,rax
       je        short M01_L100
       cmp       rbx,rdi
       jne       near ptr M01_L136
       movsx     rdx,byte ptr [rax+8]
M01_L100:
       mov       [rbp-40],rsi
       mov       rdx,[r14+10]
       lea       r9,[rbp-40]
       mov       r8,r13
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.String, System.Private.CoreLib],[System.String[], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String[]>, System.String, System.String[] ByRef)
       call      qword ptr [7FFE18DB43A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       jmp       near ptr M01_L31
M01_L101:
       call      CORINFO_HELP_OVERFLOW
M01_L102:
       xor       r13d,r13d
       xor       r12d,r12d
       jmp       near ptr M01_L01
M01_L103:
       lea       rcx,[rbp-68]
       mov       edx,r12d
       xor       r8d,r8d
       call      qword ptr [7FFE18E0D8A8]
       jmp       near ptr M01_L09
M01_L104:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18665938]
       jmp       near ptr M01_L02
M01_L105:
       xor       ecx,ecx
       mov       [rbp-70],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L106:
       xor       ecx,ecx
       mov       [rbp-80],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L107:
       xor       eax,eax
       mov       [rbp-90],eax
       jmp       near ptr M01_L25
M01_L108:
       call      qword ptr [7FFE186DE9D0]
       int       3
M01_L109:
       lea       rcx,[rbp-68]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFE18E0D8A8]
       jmp       near ptr M01_L27
M01_L110:
       lea       rcx,[rbp-68]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FFE18E0D8A8]
       jmp       near ptr M01_L18
M01_L111:
       lea       rcx,[rbp-68]
       mov       rdx,2C7823A0C30
       call      qword ptr [7FFE186658F0]
       jmp       near ptr M01_L10
M01_L112:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18665938]
       jmp       near ptr M01_L11
M01_L113:
       lea       rcx,[rbp-68]
       mov       rdx,2C7823A0C30
       call      qword ptr [7FFE186658F0]
       jmp       near ptr M01_L19
M01_L114:
       lea       rcx,[rbp-68]
       call      qword ptr [7FFE18665938]
       jmp       near ptr M01_L20
M01_L115:
       mov       rcx,r15
       call      qword ptr [7FFE187FE910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L28
M01_L116:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE1892EAC0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r15
       call      qword ptr [7FFE1847F750]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L117:
       mov       rcx,[r15+10]
       cmp       r10d,[rcx+8]
       jae       near ptr M01_L137
       mov       edx,r10d
       mov       r9,[rcx+rdx*8+10]
       test      r9,r9
       mov       [rbp-0A0],eax
       jne       short M01_L119
       mov       rcx,r15
       mov       [rbp-9C],r10d
       mov       edx,r10d
       call      qword ptr [7FFE187FE898]
       mov       r9,rax
M01_L118:
       mov       rdx,[r9+8]
       mov       [rbp-120],rdx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0C0],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0C0]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L120
       call      qword ptr [7FFE18D1E1D8]
       mov       edx,eax
       mov       [rbp-0BC],edx
       jmp       short M01_L121
M01_L119:
       mov       [rbp-9C],r10d
       jmp       short M01_L118
M01_L120:
       mov       edx,ecx
       sar       edx,10
       mov       [rbp-0BC],edx
M01_L121:
       mov       rcx,7FFE183B5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0BC]
       xor       edx,edx
       div       dword ptr [7FFE183B5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L128
M01_L122:
       cmp       eax,[r8+8]
       jae       near ptr M01_L137
       mov       [rbp-0B4],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rbp-128],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0C4],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-128]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-0C8],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L124
       test      r10d,r10d
       jne       short M01_L125
       xor       edx,edx
       mov       [rax+14],edx
M01_L123:
       movsxd    rdx,r10d
       mov       r8,[rbp-118]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0C8]
       inc       ecx
       mov       rax,[rbp-128]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0C4],1
M01_L124:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0C4]
       test      ecx,ecx
       je        short M01_L126
       mov       r8d,1
       jmp       short M01_L129
M01_L125:
       jmp       short M01_L123
M01_L126:
       mov       eax,[rbp-0B4]
       inc       eax
       mov       r8d,eax
       mov       rcx,[rbp-120]
       cmp       [rcx+8],r8d
       jne       short M01_L127
       xor       r8d,r8d
M01_L127:
       mov       edx,[rbp-0B8]
       inc       edx
       mov       eax,r8d
M01_L128:
       mov       r8,[rbp-120]
       mov       [rbp-0B8],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L122
       xor       r8d,r8d
M01_L129:
       mov       eax,r8d
       mov       [rbp-0A4],eax
       mov       eax,[rbp-0A0]
       mov       r10d,[rbp-9C]
       jmp       near ptr M01_L29
M01_L130:
       mov       edx,r10d
       mov       r8d,eax
       mov       r10,r9
       mov       eax,[rbp-0A4]
       cmp       dword ptr [r12+8],0
       mov       [rbp-9C],edx
       mov       [rbp-0A0],r8d
       mov       [rbp-100],r10
       mov       [rbp-0A4],eax
       je        near ptr M01_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0A8],eax
       mov       edx,[r12+8]
       mov       [rbp-0AC],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-100]
       mov       r8d,[rbp-0A8]
       mov       r9d,[rbp-0AC]
       mov       edx,3
       call      qword ptr [7FFE18527678]
       mov       eax,[rbp-0A0]
       test      [rbp-0A4],eax
       mov       [rbp-0A0],eax
       jne       near ptr M01_L30
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[r12+8]
       mov       rdx,[rbp-100]
       mov       [rbp-108],rdx
       mov       [rbp-0B0],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,[rbp-0A0]
       test      r15d,r15d
       jne       short M01_L131
       mov       rcx,[rbp-108]
       mov       edx,[rbp-0B0]
       mov       r8d,0FFFFFFFF
       jmp       short M01_L132
M01_L131:
       mov       rcx,[rbp-108]
       mov       edx,[rbp-0B0]
       mov       r8d,[rbp-9C]
M01_L132:
       mov       r9d,eax
       test      r15d,r15d
       jne       short M01_L133
       mov       eax,1
       jmp       short M01_L134
M01_L133:
       xor       eax,eax
M01_L134:
       mov       [rsp+20],r8d
       mov       [rsp+28],eax
       mov       r8d,r12d
       call      qword ptr [7FFE187FF360]
       jmp       near ptr M01_L30
M01_L135:
       mov       rcx,r12
       mov       rdx,rax
       call      qword ptr [7FFE1852E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L81
M01_L136:
       mov       rcx,rax
       mov       r11,7FFE18330BA0
       call      qword ptr [r11]
       jmp       near ptr M01_L100
M01_L137:
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
       lea       rbp,[rbp+160]
       cmp       qword ptr [rbp-0F8],0
       je        short M01_L139
       mov       rcx,[rbp-0F8]
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[System.String, System.Private.CoreLib]]
       cmp       rbx,rdi
       jne       short M01_L138
       movsx     rcx,byte ptr [rcx+8]
       jmp       short M01_L139
M01_L138:
       mov       r11,7FFE18330BA0
       call      qword ptr [r11]
M01_L139:
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
; Total bytes of code 4362
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
       mov       rcx,286F040E5F8
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
       xor       ecx,ecx
       mov       [rbp-40],rcx
M02_L04:
       cmp       [r13],r13b
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFE1877C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-48],r13
       jmp       short M02_L07
M02_L05:
       mov       [r15+10],eax
       jmp       near ptr M02_L22
M02_L06:
       mov       [r15+10],ecx
       jmp       near ptr M02_L23
M02_L07:
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
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L09:
       add       r12d,esi
       mov       [r13+18],r12d
       jmp       short M02_L11
M02_L10:
       mov       rcx,r13
       mov       r8d,r12d
       call      qword ptr [7FFE1877CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE1877CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L17
M02_L14:
       mov       rcx,r13
       mov       r8d,2
       call      qword ptr [7FFE1877CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M02_L19
M02_L15:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L16:
       mov       [r13+18],r15d
M02_L17:
       mov       rdx,2C7823A1C14
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
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE1877C2A0]; System.Text.StringBuilder.Append(System.String)
M02_L19:
       inc       r12d
       cmp       esi,r12d
       jg        near ptr M02_L12
M02_L20:
       mov       rcx,r13
       call      qword ptr [7FFE18787A60]; System.Text.StringBuilder.ToString()
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
       mov       rax,2C7823A0008
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
       mov       r14,2C7823A0008
       jmp       near ptr M02_L00
M02_L24:
       call      qword ptr [7FFE1883E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L25:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18BA6430]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,286F040E5F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M02_L29
       call      qword ptr [7FFE1883E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FFE1877C1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE18BA6400]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
; Total bytes of code 1160
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rcx,280E6331F10
       mov       [rax+10],rcx
       mov       rcx,280E6344768
       mov       [rax+18],rcx
       mov       rcx,rsi
       mov       r8,rax
       mov       edx,3
       call      qword ptr [7FFE1884CC30]; DotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.StringComparison, System.String[])
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
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringExtensions+<>c__DisplayClass8_0
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
       mov       rcx,280E63447B8
       cmp       [rcx],ecx
       call      qword ptr [7FFE183CA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       mov       r8,7FFE18DC01C8
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Func`2<System.String,Boolean>)
       call      qword ptr [7FFE18DC41F8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       call      qword ptr [7FFE188ED170]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE188ED0C8]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,280E6344780
       mov       r8,rbx
       call      qword ptr [7FFE1853D470]
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,2CA5B174768
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,273C68C4768
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DelimitedStringToArray()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       dword ptr [rsp+28],2C
       lea       rdx,[rsp+28]
       call      qword ptr [7FFE1882CC90]; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char ByRef)
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
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.DelimitedStringToArray(System.String, Char ByRef)
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       test      rcx,rcx
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       movzx     edx,word ptr [rdx]
       mov       [rsp+34],dx
       lea       rdx,[rsp+34]
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      qword ptr [7FFE184670C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       nop
       add       rsp,38
       ret
M01_L00:
       mov       rcx,7FFE183A5120
       mov       edx,61
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,173C3801F78
       mov       rax,[rax]
       add       rsp,38
       ret
; Total bytes of code 115
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsIgnoreCase()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vpcmpeqq  xmm0,xmm0,[7FFE18CDC140]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 39
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsOrBothNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,281AF664768
       mov       rdx,281AF6647A0
       mov       r8d,4
       call      qword ptr [7FFE184961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       call      qword ptr [7FFE18545068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE186FECB8]
       int       3
M01_L05:
       cmp       edi,5
       ja        near ptr M01_L08
       mov       eax,edi
       lea       rcx,[7FFE18CDBE78]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE18C0F588]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       rcx,7FFE183D5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2411D8003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C0F588]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
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
       jmp       qword ptr [7FFE18495F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18975338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1849F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 391
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       rdx,2BEABB04768
       mov       r8,2BEABB04788
       call      qword ptr [7FFE1884CCD8]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
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
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE184875D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE184875D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18487240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FFE188ED368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE188ED0B0]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BEABAF7DC0
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FFE188ED368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE188ED0B0]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BEABB047A8
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFE188ED368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE188ED0B0]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BEABB047C8
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 472
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       call      qword ptr [7FFE1883C690]; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
       jge       short M01_L00
       mov       [rsi+10],edx
       jmp       short M01_L01
       xchg      ax,ax
M01_L00:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L17
M01_L01:
       mov       rdx,1E52B40C5F8
       mov       rsi,[rdx]
       lea       rdx,[rbx+0C]
       mov       [rbp-40],rdx
       mov       rdi,[rbp-40]
       mov       ebx,[rbx+8]
       test      ebx,ebx
       jle       short M01_L04
M01_L02:
       lea       edx,[rbx-1]
       movsxd    rcx,edx
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,20
       je        short M01_L03
       cmp       ecx,0A
       je        short M01_L03
       cmp       ecx,0D
       je        short M01_L03
       cmp       ecx,9
       jne       short M01_L04
M01_L03:
       mov       ebx,edx
       test      ebx,ebx
       jg        short M01_L02
M01_L04:
       mov       rdx,rdi
       movsxd    rcx,ebx
       lea       r14,[rdx+rcx*2]
       mov       ecx,ebx
       xor       r15d,r15d
       cmp       rdi,r14
       jae       short M01_L07
M01_L05:
       movzx     eax,word ptr [rdx]
       add       rdx,2
       cmp       eax,20
       jbe       near ptr M01_L18
       cmp       eax,3D
       je        short M01_L08
M01_L06:
       cmp       rdx,r14
       jb        short M01_L05
M01_L07:
       test      r15d,r15d
       je        near ptr M01_L12
       cmp       r15d,1
       jne       near ptr M01_L19
       mov       r15d,2
       jmp       near ptr M01_L12
M01_L08:
       dec       ecx
       inc       r15d
       jmp       short M01_L06
M01_L09:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       ebx,[r14+8]
       test      ebx,ebx
       je        near ptr M01_L23
       mov       [rbp-50],r14
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       je        short M01_L11
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L31
       mov       rdi,[rbp-50]
       add       rdi,10
M01_L10:
       test      rdi,rdi
       je        near ptr M01_L24
       mov       rcx,[rsi+18]
       mov       r14d,ebx
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rax,offset MT_System.Text.DecoderReplacementFallback
       cmp       [rcx],rax
       jne       near ptr M01_L25
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],1
       jne       near ptr M01_L25
       jmp       short M01_L13
M01_L11:
       xor       edi,edi
       jmp       short M01_L10
M01_L12:
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
       mov       r14,rax
       test      ebx,ebx
       jl        near ptr M01_L21
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rbp-68],rdi
       mov       [rbp-60],ebx
       mov       [rbp-78],rcx
       mov       [rbp-70],edx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       lea       r8,[rbp-48]
       call      qword ptr [7FFE187F4720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L22
       jmp       near ptr M01_L09
M01_L13:
       mov       r13d,r14d
       cmp       r14d,ebx
       jne       near ptr M01_L26
M01_L14:
       test      r13d,r13d
       je        near ptr M01_L27
       mov       ecx,r13d
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       r8,[r14+0C]
       mov       [rbp-58],r8
       mov       r12,[rbp-58]
       test      r12,r12
       je        near ptr M01_L28
       mov       r8d,ebx
       or        r8d,r13d
       jl        near ptr M01_L29
       cmp       r13d,ebx
       mov       r8d,ebx
       cmovle    r8d,r13d
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFE186DC660]; System.Text.Ascii.WidenAsciiToUtf16(Byte*, Char*, UIntPtr)
       cmp       eax,ebx
       jne       near ptr M01_L30
M01_L15:
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,r14
M01_L16:
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
       mov       rax,225BD3F0008
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
       dec       ecx
       jmp       near ptr M01_L06
M01_L19:
       cmp       r15d,2
       jne       short M01_L20
       mov       r15d,1
       jmp       near ptr M01_L12
M01_L20:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE1892F480]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE187574B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       call      qword ptr [7FFE186DE9D0]
       int       3
M01_L22:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE1892F480]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE187574B0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rax,225BD3F0008
       jmp       near ptr M01_L16
M01_L24:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE186DED18]
       int       3
M01_L25:
       mov       edx,ebx
       mov       rcx,rdi
       call      qword ptr [7FFE186DC468]; System.Text.Ascii.GetIndexOfFirstNonAsciiByte_Vector(Byte*, UIntPtr)
       mov       r14d,eax
       mov       r13d,r14d
       cmp       r14d,ebx
       je        near ptr M01_L14
M01_L26:
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9d,r13d
       call      qword ptr [7FFE1847C990]
       add       eax,r13d
       mov       r13d,eax
       test      r13d,r13d
       jge       near ptr M01_L14
       call      qword ptr [7FFE1847C7E0]
       int       3
M01_L27:
       mov       rax,225BD3F0008
       jmp       near ptr M01_L16
M01_L28:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE186DED18]
       int       3
M01_L29:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE186DED48]
       int       3
M01_L30:
       mov       [rsp+20],r13d
       mov       [rsp+28],eax
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       mov       r9,r12
       call      qword ptr [7FFE1847CA08]
       jmp       near ptr M01_L15
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 979
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFE18477318]; System.String.Trim()
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE18DFEF10]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18DFEF10]
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
       call      qword ptr [7FFE184773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE1885CDE0]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18E1EF10]
       test      eax,eax
       jne       near ptr M01_L12
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE18E1EF10]
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FFE18E1EF10]
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
       call      qword ptr [7FFE188FD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE188FD0B0]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,237872A7DC0
       mov       r8,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184973F0]
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       dword ptr [rsp+38],0A
       mov       dword ptr [rsp+30],3E
       lea       r8,[rsp+30]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFE1884CDF8]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32 ByRef, Char ByRef)
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
; Total bytes of code 86
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32 ByRef, Char ByRef)
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
       mov       rbx,rdx
       mov       rsi,r8
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L28
       cmp       dword ptr [rbx],0
       jle       near ptr M01_L28
       mov       rcx,1753F00C600
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
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L30
       lea       rcx,[r14+20]
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-38]
       jne       near ptr M01_L30
M01_L01:
       mov       r15,[rbp-38]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-38],rcx
M01_L03:
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-40],r15
       cmp       dword ptr [rbx],0
       je        short M01_L06
M01_L04:
       mov       r14d,1
       jmp       short M01_L12
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFE1878C2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L04
M01_L07:
       neg       r13d
       jns       short M01_L13
       call      qword ptr [7FFE18AAE7D8]
       int       3
M01_L08:
       mov       rcx,r15
       call      qword ptr [7FFE1878C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L11
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L10:
       movzx     edx,word ptr [rsi]
       mov       r8d,[r15+18]
       mov       ecx,r8d
       mov       rax,[r15+8]
       mov       r10d,[rax+8]
       cmp       r10d,ecx
       jbe       short M01_L08
       mov       r10d,ecx
       mov       [rax+r10*2+10],dx
       inc       r8d
       mov       [r15+18],r8d
M01_L11:
       add       r14d,1
       jo        short M01_L05
M01_L12:
       mov       r13d,[rbx]
       test      r13d,r13d
       jl        short M01_L07
M01_L13:
       cmp       r14d,r13d
       jle       short M01_L10
       cmp       dword ptr [rbx],0
       jle       short M01_L17
       lea       rdx,[rdi+0C]
       mov       edi,[rdi+8]
       test      edi,edi
       je        short M01_L17
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       r13d,ecx
       lea       ecx,[rdi+r13]
       mov       r10d,[r8+8]
       cmp       ecx,r10d
       ja        short M01_L16
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       short M01_L15
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L14:
       add       edi,r13d
       mov       [r15+18],edi
       jmp       short M01_L17
M01_L15:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       short M01_L14
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L14
M01_L16:
       mov       rcx,r15
       mov       r8d,edi
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L17:
       mov       rcx,r15
       call      qword ptr [7FFE18797A60]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       mov       esi,[rbx+8]
       lea       r14d,[rsi-1]
       test      r14d,r14d
       jl        near ptr M01_L26
       cmp       esi,r14d
       jle       short M01_L21
M01_L18:
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L19
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       je        near ptr M01_L26
       jmp       short M01_L20
M01_L19:
       call      qword ptr [7FFE18E1EF28]
       test      eax,eax
       je        short M01_L26
M01_L20:
       dec       r14d
       jns       short M01_L18
       jmp       short M01_L26
M01_L21:
       cmp       r14d,esi
       jae       near ptr M01_L09
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L24
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       je        short M01_L26
       jmp       short M01_L25
M01_L22:
       test      edi,edi
       je        short M01_L23
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,edi
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[rbx+0C]
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M01_L27
M01_L23:
       mov       rax,1B5D0F00008
       jmp       short M01_L27
M01_L24:
       call      qword ptr [7FFE18E1EF28]
       test      eax,eax
       je        short M01_L26
M01_L25:
       dec       r14d
       jns       short M01_L21
M01_L26:
       lea       edi,[r14+1]
       cmp       esi,edi
       jne       short M01_L22
       mov       rax,rbx
M01_L27:
       mov       [rbp-48],rax
       mov       rcx,rsp
       call      M01_L33
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
M01_L28:
       mov       rax,1B5D0F00008
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       call      qword ptr [7FFE1884E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L30:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18BB6328]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       mov       rcx,1753F00C600
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L34
       mov       r15,[rbp-40]
       call      qword ptr [7FFE1884E310]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       r15,[rbp-40]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L41
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L37
M01_L36:
       mov       r15,[rbp-40]
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
       call      qword ptr [7FFE18BB62F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L41
M01_L39:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L41
M01_L40:
       mov       r15,[rbp-40]
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L41:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1046
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+180]
       call      qword ptr [7FFE1885CE10]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char ByRef)
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
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
       call      qword ptr [7FFE18E1F078]
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+180]
       call      qword ptr [7FFE1885CE28]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char ByRef)
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       mov       eax,ecx
       mov       rcx,7FFE773C2E50
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE18E1F078]
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+180]
       call      qword ptr [7FFE1882CE40]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char ByRef)
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFE773C2E50
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
       call      qword ptr [7FFE18DEEBC8]
       jmp       short M01_L00
; Total bytes of code 68
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+180]
       call      qword ptr [7FFE1884C7F8]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char ByRef)
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFE773C2E50
       test      byte ptr [rax+rcx],80
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE18E0EF10]
       jmp       short M01_L00
; Total bytes of code 50
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+120]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,24E7780D900
       mov       rcx,[rcx]
       call      qword ptr [7FFE18C04558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18C042E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E2F978]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+128]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1CBC6C0D908
       mov       rcx,[rcx]
       call      qword ptr [7FFE18C04558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18C042E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E2F978]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2972640D998
       mov       rcx,[rcx]
       call      qword ptr [7FFE18C04558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18C042E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E64C30]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+140]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,15A0800D910
       mov       rcx,[rcx]
       call      qword ptr [7FFE18BF4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18BF42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E1FD08]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+168]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,16619C0D920
       mov       rcx,[rcx]
       call      qword ptr [7FFE18BF4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18BF42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E1F978]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+108]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,29B6FDD1F10
       xor       r8d,r8d
       call      qword ptr [7FFE18527180]; System.Guid.ToString(System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L01
       mov       rcx,25ADE00D928
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFE18BE4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 93
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
       call      qword ptr [7FFE1870CF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE18527348]
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
       call      qword ptr [7FFE18527348]
       int       3
; Total bytes of code 235
```
```assembly
; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       push      rbx
       sub       rsp,40
       test      rdx,rdx
       je        short M02_L01
       mov       eax,[rdx+8]
       mov       r8,rcx
       mov       r9,rdx
       test      byte ptr [r8+40],40
       jne       short M02_L02
       xor       ebx,ebx
M02_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       [rsp+28],eax
       mov       [rsp+30],ebx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FFE18BE42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E45E90]
       int       3
M02_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+150]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1F2E940D940
       mov       rcx,[rcx]
       call      qword ptr [7FFE18BF4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18BF42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E1FD50]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,237FA80D948
       mov       rcx,[rcx]
       mov       rdx,2788C664768
       call      qword ptr [7FFE18C04558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 50
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
       call      qword ptr [7FFE18C042E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E2F978]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+160]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2426D80D950
       mov       rcx,[rcx]
       call      qword ptr [7FFE18BE4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18BE42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E0F978]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1675BC0D978
       mov       rcx,[rcx]
       mov       rdx,1A7EDB64768
       call      qword ptr [7FFE18BE4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 50
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
       call      qword ptr [7FFE18BE42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E0FE70]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1EC3C40D990
       mov       rcx,[rcx]
       call      qword ptr [7FFE18C04558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 53
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
       call      qword ptr [7FFE18C042E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E64C30]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+148]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,21F2B80D980
       mov       rcx,[rcx]
       call      qword ptr [7FFE18BE4558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18BE42E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E0FE70]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,17C36C0D9A0
       mov       rcx,[rcx]
       call      qword ptr [7FFE18C14558]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 56
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
       call      qword ptr [7FFE18C142E8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE18E3F9A8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+170]
       call      qword ptr [7FFE1882CFF0]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18DEEF28]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE18DEEF28]
       test      eax,eax
       jne       near ptr M01_L10
M01_L05:
       cmp       [rbx],bl
       mov       rdx,2AD8DF87578
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
       call      qword ptr [7FFE18BD7C00]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FFE18515B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FFE188CD368]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FFE188CD0B0]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2AD8DF87DC0
       mov       r8,rdi
       call      qword ptr [7FFE186F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184673F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE18467258]
       int       3
M01_L12:
       mov       rbx,2AD8DF80008
       jmp       near ptr M01_L07
M01_L13:
       jmp       near ptr M01_L07
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       mov       dword ptr [rsp+28],2C
       lea       r8,[rsp+28]
       mov       edx,2
       call      qword ptr [7FFE1882D008]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char ByRef)
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
; Total bytes of code 78
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       esi,edx
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
       je        near ptr M01_L02
       cmp       [rcx],ecx
       call      qword ptr [7FFE18467318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,1F47F264768
       cmp       [rcx],ecx
       call      qword ptr [7FFE183AA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M01_L04
       mov       rcx,offset MT_System.Char[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_VC
       movzx     ecx,word ptr [rdi]
       mov       [rax+10],cx
       cmp       [rbx],bl
       add       rax,10
       mov       rcx,rbx
       mov       [rsp+20],rax
       mov       dword ptr [rsp+28],1
       lea       rdx,[rsp+20]
       mov       r9d,esi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFE184670C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FFE188CD368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE188CD0B0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F47F257DC0
       mov       r8,rbx
       call      qword ptr [7FFE186F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FFE188CD170]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE188CD0C8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1F47F2582D0
       mov       r8,rbx
       call      qword ptr [7FFE1851D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,14
       call      qword ptr [7FFE186CED00]
       int       3
; Total bytes of code 398
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SplitRemoveEmpty()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE1886D068]; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
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
       call      qword ptr [7FFE184A7318]; System.String.Trim()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE184A7318]; System.String.Trim()
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
       call      qword ptr [7FFE184A70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FFE1890D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE1890D0B0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,308498B7DC0
       mov       r8,rbx
       call      qword ptr [7FFE18736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       ecx,14
       call      qword ptr [7FFE1870ED00]
       int       3
; Total bytes of code 276
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1436
       cmp       [rbx],rcx
       jne       near ptr M00_L02
       mov       rsi,[rbx+50]
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE18BC4258]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        near ptr M00_L04
       cmp       dword ptr [rsi+8],32
       jl        short M00_L03
       mov       rcx,rsi
       mov       edx,19
       mov       r8d,19
       call      qword ptr [7FFE18477240]; System.String.Substring(Int32, Int32)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE18477318]; System.String.Trim()
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
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A64
       mov       rdx,7FFE18871A48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE188DD0C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rax,1BB08B90008
       jmp       near ptr M00_L01
; Total bytes of code 288
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
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE18477258]
       int       3
M02_L01:
       mov       rax,1BB08B90008
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFE18DFEF10]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFE18DFEF10]
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
       call      qword ptr [7FFE184773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
       call      qword ptr [7FFE1884D0C8]; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
       mov       rcx,2198D80E5F0
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
       call      qword ptr [7FFE18BD4748]; System.Text.ASCIIEncoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       lea       rcx,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FFE18804648]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
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
       mov       rax,25A1B8A0008
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
       call      qword ptr [7FFE186EC4C8]
       mov       r15d,eax
       mov       esi,r15d
       cmp       r15d,r14d
       je        near ptr M01_L02
M01_L05:
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FFE1848C8A0]
       add       esi,eax
       jns       near ptr M01_L02
       call      qword ptr [7FFE1848C7E0]
       int       3
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 413
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64ToBase64ByteSpan()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+28]
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
       je        near ptr M00_L05
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rsi,rax
       imul      edx,[rsi+8],3
       jo        near ptr M00_L04
       mov       ecx,edx
       sar       ecx,1F
       and       ecx,3
       add       edx,ecx
       sar       edx,2
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rdi,[rax+10]
       mov       ebp,[rax+8]
       mov       rcx,rdi
       mov       edx,ebp
       lea       r8,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],r8
       mov       [rsp+40],eax
       mov       [rsp+28],rcx
       mov       [rsp+30],edx
       lea       rcx,[rsp+38]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+50]
       call      qword ptr [7FFE18804720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L07
       xor       esi,esi
       xor       r14d,r14d
M00_L02:
       test      r14d,r14d
       jne       near ptr M00_L09
       mov       r15,1DC74057178
M00_L03:
       mov       [rsp+48],r15
       mov       rbp,[rbx+18]
       mov       rdx,[rsp+48]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbp+8],rax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       call      CORINFO_HELP_OVERFLOW
M00_L05:
       call      qword ptr [7FFE188ED368]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFE188ED0B0]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,1DC74057DC0
       mov       r8,rdi
       call      qword ptr [7FFE18716670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M00_L07:
       mov       r14d,[rsp+50]
       cmp       r14d,ebp
       jbe       short M00_L08
       call      qword ptr [7FFE186EE9D0]
       int       3
M00_L08:
       mov       rsi,rdi
       jmp       near ptr M00_L02
M00_L09:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       r8d,r14d
       mov       rdx,rsi
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L03
; Total bytes of code 413
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE18E1EF70]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18E1EF70]
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
       call      qword ptr [7FFE184873F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rax,0D6F181C49345
       mov       [rsp+70],rax
       mov       rbx,r8
       mov       rsi,rdx
       mov       rdi,rcx
       mov       rbp,[rdi]
       mov       r14d,[rdi+8]
       mov       r15,[rsi]
       mov       r13d,[rsi+8]
       lea       r12,[rsp+28]
       mov       dword ptr [rsp+44],4
       xor       r8d,r8d
       mov       [rbx],r8d
       test      r14d,r14d
       je        near ptr M02_L13
M02_L00:
       mov       [rdi],rbp
       mov       [rdi+8],r14d
       mov       [rsi],r15
       mov       [rsi+8],r13d
       lea       r8,[rsp+68]
       lea       r9,[rsp+60]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE187AE628]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       mov       edx,[rsp+60]
       add       [rbx],edx
       test      eax,eax
       jne       near ptr M02_L13
       mov       eax,[rsp+68]
       cmp       eax,r14d
       ja        near ptr M02_L18
       mov       edx,eax
       lea       rbp,[rbp+rdx*2]
       sub       r14d,eax
       mov       eax,[rsp+60]
       cmp       eax,r13d
       ja        near ptr M02_L18
       mov       edx,eax
       add       r15,rdx
       sub       r13d,eax
       test      r14d,r14d
       je        near ptr M02_L21
       movzx     eax,word ptr [rbp]
       cmp       eax,20
       je        short M02_L01
       cmp       eax,9
       je        short M02_L01
       cmp       eax,0D
       je        short M02_L01
       cmp       eax,0A
       je        short M02_L01
       mov       rax,r12
       mov       r11d,[rsp+44]
       mov       r10d,r11d
       xor       ecx,ecx
       xor       r9d,r9d
       test      r14d,r14d
       jle       near ptr M02_L17
       jmp       near ptr M02_L05
       nop
M02_L01:
       mov       r10d,1
       cmp       r14d,1
       je        short M02_L03
M02_L02:
       cmp       r10d,r14d
       jae       near ptr M02_L21
       mov       eax,r10d
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,20
       je        near ptr M02_L15
       cmp       eax,9
       je        near ptr M02_L15
       cmp       eax,0D
       je        near ptr M02_L15
       cmp       eax,0A
       je        near ptr M02_L15
M02_L03:
       cmp       r10d,r14d
       ja        near ptr M02_L18
       mov       eax,r10d
       lea       rbp,[rbp+rax*2]
       sub       r14d,r10d
       mov       ecx,[rsp+60]
       mov       edx,55555556
       mov       eax,edx
       imul      dword ptr [rsp+60]
       mov       r9d,edx
       shr       r9d,1F
       add       r9d,edx
       lea       r9d,[r9+r9*2]
       sub       ecx,r9d
       jne       near ptr M02_L16
M02_L04:
       test      r14d,r14d
       je        near ptr M02_L13
       jmp       near ptr M02_L00
M02_L05:
       mov       r8d,r9d
       movzx     r8d,word ptr [rbp+r8*2]
       cmp       r8d,20
       je        short M02_L06
       cmp       r8d,9
       je        short M02_L06
       cmp       r8d,0D
       je        short M02_L06
       cmp       r8d,0A
       je        short M02_L06
       lea       edx,[rcx+1]
       cmp       ecx,r10d
       jae       near ptr M02_L21
       mov       ecx,ecx
       mov       [rax+rcx*2],r8w
       cmp       edx,r10d
       mov       ecx,edx
       je        short M02_L07
M02_L06:
       inc       r9d
       cmp       r9d,r14d
       jge       near ptr M02_L17
       jmp       short M02_L05
M02_L07:
       lea       eax,[r9+1]
       mov       [rsp+5C],eax
M02_L08:
       test      cl,3
       jne       near ptr M02_L09
       cmp       ecx,r11d
       ja        near ptr M02_L18
       mov       r11d,ecx
       mov       [rsi],r15
       mov       [rsi+8],r13d
       mov       [rsp+30],r12
       mov       [rsp+44],r11d
       mov       [rsp+38],r11d
       lea       rcx,[rsp+30]
       lea       r9,[rsp+48]
       lea       r8,[rsp+50]
       mov       rdx,rsi
       call      qword ptr [7FFE187AE628]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       test      eax,eax
       je        short M02_L09
       mov       eax,[rsp+48]
       add       [rbx],eax
       mov       eax,[rsp+5C]
       cmp       eax,r14d
       ja        near ptr M02_L18
       mov       edx,eax
       lea       rbp,[rbp+rdx*2]
       sub       r14d,eax
       mov       eax,[rsp+48]
       cmp       eax,r13d
       ja        near ptr M02_L18
       mov       edx,eax
       add       rdx,r15
       mov       r15,rdx
       sub       r13d,eax
       mov       ecx,[rsp+48]
       mov       edx,55555556
       mov       eax,edx
       imul      dword ptr [rsp+48]
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       sub       ecx,eax
       jne       near ptr M02_L19
       jmp       near ptr M02_L04
M02_L09:
       xor       eax,eax
       mov       [rbx],eax
       mov       rcx,0D6F181C49345
       cmp       [rsp+70],rcx
       je        short M02_L10
       call      CORINFO_HELP_FAIL_FAST
M02_L10:
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L11:
       inc       eax
M02_L12:
       cmp       eax,r14d
       jl        short M02_L20
M02_L13:
       mov       eax,1
       mov       rcx,0D6F181C49345
       cmp       [rsp+70],rcx
       je        short M02_L14
       call      CORINFO_HELP_FAIL_FAST
M02_L14:
       nop
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L15:
       inc       r10d
       cmp       r10d,r14d
       jne       near ptr M02_L02
       jmp       near ptr M02_L03
M02_L16:
       test      r14d,r14d
       je        near ptr M02_L04
       jmp       short M02_L09
M02_L17:
       mov       eax,r14d
       mov       [rsp+5C],eax
       jmp       near ptr M02_L08
M02_L18:
       call      qword ptr [7FFE186EE9D0]
       int       3
M02_L19:
       xor       eax,eax
       jmp       short M02_L12
M02_L20:
       cmp       eax,r14d
       jae       short M02_L21
       mov       ecx,eax
       movzx     ecx,word ptr [rbp+rcx*2]
       cmp       ecx,20
       je        short M02_L11
       cmp       ecx,9
       je        short M02_L11
       cmp       ecx,0D
       je        near ptr M02_L11
       cmp       ecx,0A
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L11
       jmp       near ptr M02_L09
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 833
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       ret
M03_L01:
       test      r8b,4
       je        short M03_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       cmp       r8,40
       ja        short M03_L07
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L06
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L05:
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L04
M03_L07:
       cmp       r8,800
       ja        short M03_L10
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L03
       jmp       near ptr M03_L04
M03_L09:
       cmp       rcx,rdx
       je        near ptr M03_L00
M03_L10:
       jmp       qword ptr [7FFE18535B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rax,23B60054768
       mov       [rcx+8],rax
       call      qword ptr [7FFE18BE4258]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L02
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L03
       mov       rcx,rax
       call      qword ptr [7FFE1867C7E0]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,23B60054768
       cmp       [rcx],ecx
       call      qword ptr [7FFE186AC378]; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       rax,23B60054768
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
       mov       rax,1FAD2000438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,1FAD2000418
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
       jmp       qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE186AC018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
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
       je        near ptr M04_L26
       mov       rcx,[rsp+98]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L30
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
       jle       near ptr M04_L25
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
       jbe       near ptr M04_L31
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
       mov       r12,7FFE773D1CB0
       movzx     r8d,byte ptr [r8+r12]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r14,7FFE773CACC8
       movzx     r8d,word ptr [r8+r14]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFE773CE7F0
       movzx     r8d,byte ptr [r8+r13]
       mov       r15,7FFE773C3150
       movzx     eax,byte ptr [r8+r15]
       and       eax,1F
       mov       [rsp+3C],eax
       cmp       eax,4
       ja        near ptr M04_L46
       test      edi,edi
       jne       near ptr M04_L32
M04_L06:
       mov       r8d,[rsp+38]
       mov       [rsp+20],r8d
       lea       r8,[rsp+98]
       lea       rdx,[rsp+40]
       mov       rcx,rbx
       mov       r9d,ebp
       call      qword ptr [7FFE186AC3A8]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       jbe       near ptr M04_L35
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
       jne       near ptr M04_L40
       mov       r8d,1
       jmp       near ptr M04_L40
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
       je        near ptr M04_L36
       mov       ecx,1
       shlx      ecx,ecx,r10d
       test      ecx,1FFCF800
       je        near ptr M04_L40
M04_L14:
       mov       [rsp+34],eax
       mov       r14d,ebp
       sub       r14d,eax
       test      r14d,r14d
       jle       near ptr M04_L19
       test      r8d,r8d
       je        near ptr M04_L43
       test      rsi,rsi
       jne       short M04_L15
       mov       rdx,[rsp+98]
       test      rdx,rdx
       je        near ptr M04_L26
       mov       rcx,rbx
       call      qword ptr [7FFE18DD45A0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
M04_L15:
       mov       r15,[rsp+40]
       cmp       [r15],r15b
       mov       eax,[rsp+34]
       test      eax,eax
       jl        near ptr M04_L27
       test      rsi,rsi
       je        near ptr M04_L42
       mov       r8d,[rsi+8]
       sub       r8d,r14d
       cmp       r8d,eax
       jl        near ptr M04_L29
       movsxd    r8,eax
       lea       rdx,[rsi+r8*2+0C]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[r14+r13]
       cmp       ecx,[r8+8]
       ja        short M04_L18
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
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L17:
       add       r14d,r13d
       mov       [r15+18],r14d
       jmp       short M04_L19
M04_L18:
       mov       rcx,r15
       mov       r8d,r14d
       call      qword ptr [7FFE1879CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M04_L19:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jle       near ptr M04_L24
       mov       ecx,[rsp+38]
       cmp       ecx,2
       jne       near ptr M04_L22
       lea       ecx,[rbp+1]
       mov       r15d,ecx
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
M04_L20:
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       cmp       r15d,[rdx+8]
       jae       near ptr M04_L47
       mov       rdx,[rsp+98]
       mov       eax,r15d
       movzx     edx,word ptr [rdx+rax*2+0C]
       mov       eax,[rcx+18]
       mov       r8d,eax
       mov       r10,[rcx+8]
       cmp       [r10+8],r8d
       jbe       short M04_L21
       cmp       r8d,[r10+8]
       jae       near ptr M04_L47
       mov       [r10+r8*2+10],dx
       inc       eax
       mov       [rcx+18],eax
       jmp       short M04_L23
M04_L21:
       call      qword ptr [7FFE1879C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M04_L23
M04_L22:
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
       mov       r15d,ebp
M04_L23:
       mov       ebp,r15d
M04_L24:
       inc       ebp
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L02
M04_L25:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE187A7A60]; System.Text.StringBuilder.ToString()
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
M04_L26:
       mov       ecx,16EB
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187266E8]
       int       3
M04_L27:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FFE18DD6538]
       int       3
M04_L28:
       mov       ecx,2E5
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187266E8]
       int       3
M04_L29:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE1894EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE1854D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L30:
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
M04_L31:
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
M04_L32:
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
       je        short M04_L33
       mov       rcx,[rsp+98]
       cmp       ebp,[rcx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],49
       jne       near ptr M04_L06
M04_L33:
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],6A
       je        short M04_L34
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],4A
       jne       near ptr M04_L06
M04_L34:
       mov       rcx,[rsp+40]
       mov       rdx,23B60054790
       cmp       [rcx],ecx
       call      qword ptr [7FFE1879C2A0]; System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       near ptr M04_L07
M04_L35:
       inc       r9d
       cmp       r11d,r9d
       jbe       near ptr M04_L09
       movzx     r9d,word ptr [r10+r9*2+0C]
       add       r9d,0FFFF2400
       cmp       r9d,3FF
       ja        near ptr M04_L09
       shl       edx,0A
       lea       ecx,[rdx+r9+10000]
       jmp       near ptr M04_L09
M04_L36:
       inc       ebp
       test      r8d,r8d
       je        short M04_L38
       test      rsi,rsi
       jne       short M04_L37
       mov       [rsp+34],eax
       mov       rcx,rbx
       mov       rdx,[rsp+98]
       call      qword ptr [7FFE186AC1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L37:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE1879C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L39
M04_L38:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE1879C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
M04_L39:
       mov       eax,ebp
       mov       r8d,1
       jmp       short M04_L41
M04_L40:
       add       ebp,[rsp+38]
M04_L41:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L08
       jmp       near ptr M04_L14
M04_L42:
       test      eax,eax
       jne       near ptr M04_L28
       jmp       near ptr M04_L28
M04_L43:
       mov       eax,[rsp+34]
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FFE1879C2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L19
M04_L44:
       call      qword ptr [7FFE1879C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L20
M04_L45:
       call      qword ptr [7FFE1879C3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r15d,ebp
       jmp       near ptr M04_L23
M04_L46:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FFE186AC390]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L24
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1447
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
       call      qword ptr [7FFE18BF4258]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       rcx,rsi
       call      qword ptr [7FFE184A7318]; System.String.Trim()
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
       mov       r11,7FFE18360B10
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE18360B18
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L01
       jmp       near ptr M02_L16
M02_L00:
       call      qword ptr [7FFE18E2EF10]
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L05
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FFE18E2EF10]
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L08
M02_L07:
       call      qword ptr [7FFE18E2EF10]
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
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L11
M02_L10:
       call      qword ptr [7FFE18E2EF10]
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
       call      qword ptr [7FFE18555B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M02_L13
M02_L15:
       mov       rax,24741210008
       jmp       short M02_L13
M02_L16:
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FFE18435CE0]; System.Char.IsWhiteSpace(Char)
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

