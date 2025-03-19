## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,18F9EAD0008
       mov       rax,18F9EAE49E8
       cmp       qword ptr [rcx+168],0
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,1CA84A00008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValueFromNull()
       push      rsi
       push      rbx
       push      rax
       xor       eax,eax
       mov       [rsp],rax
       mov       rbx,[rcx+168]
       test      rbx,rbx
       jne       short M00_L02
M00_L00:
       mov       rsi,2D109E449E8
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,1EB254E49E8
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,64
       call      qword ptr [7FF9F61ACDB0]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F67A63B8]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FF9F67A63B8]
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
       call      qword ptr [7FF9F5E947B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FF9F625D2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FF9F625D0C8]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29BD3767598
       mov       r8,rbx
       call      qword ptr [7FF9F5E9D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F5DE73F0]
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 311
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FF9F617CDF8]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
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
       mov       [rsp+28],rax
       xor       eax,eax
       cmp       esi,ebx
       setge     al
       mov       r8d,eax
       test      eax,eax
       je        near ptr M01_L10
M01_L02:
       test      r8d,r8d
       je        near ptr M01_L11
M01_L03:
       test      rdi,rdi
       je        short M01_L05
       mov       eax,[rdi+8]
       cmp       eax,ebx
       jl        near ptr M01_L13
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
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5E647B0]
       mov       ebx,eax
       jmp       short M01_L01
M01_L08:
       call      qword ptr [7FF9F622D2A8]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FF9F622D0C8]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B57EE3BBE8
       mov       r8,rdi
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5E647B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L11:
       call      qword ptr [7FF9F622D2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L12
       call      qword ptr [7FF9F622D0C8]
       mov       rbx,rax
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B57EE3BC10
       mov       r8,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 331
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,28C909D49E8
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,28C909D4A20
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,28C909C0008
       mov       r8,28C909C82D0
       call      qword ptr [7FF9F6716EE0]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FF9F6546A48]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FF9F6546C40]; System.Text.RegularExpressions.Regex.get_RightToLeft()
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
       mov       r9,28C909D49E8
       call      qword ptr [7FF9F6546D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6736E08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rcx,28C909D4A90
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5D1A770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FF9F624D170]
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
       call      qword ptr [7FF9F624D0C8]
       mov       rsi,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FF9F5E8D470]
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
       call      qword ptr [7FF9F6546A90]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FF9F6736448]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9F6736430]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9F6736D48]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FF9F6537628
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
       mov       rcx,7FF9F6537628
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24BFEC0FF30
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FF9F603ED30]
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
       test      byte ptr [7FF9F6537679],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,24BFEC0FF30
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
       call      qword ptr [7FF9F67CFD20]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF9F67CFD20]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       test      rsi,rsi
       je        short M00_L02
       mov       rcx,rsi
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F67863B8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F67863B8]
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
       call      qword ptr [7FF9F5DC73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split_WithCount()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,2
       mov       r8d,2
       mov       r9d,2C
       call      qword ptr [7FF9F617D050]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rdx,rax
       mov       rcx,2CA6B5449E8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5CFA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FF9F5DB70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FF9F622D368]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L06
       call      qword ptr [7FF9F622D0B0]
       mov       rdi,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,2CA6B537DC0
       mov       r8,rdi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF9F622D170]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FF9F622D0C8]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CA6B5382D0
       mov       r8,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F5E647B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FF9F622D2A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FF9F622D0C8]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2CA6B534368
       mov       r8,rbx
       call      qword ptr [7FF9F5E6D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       ecx,2
       call      qword ptr [7FF9F601ED00]
       int       3
M01_L13:
       mov       rcx,7FF9F5CF5120
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,289D9401F78
       mov       rax,[rax]
       jmp       near ptr M01_L04
; Total bytes of code 589
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,1D994C00970
       mov       rdx,[rdx]
       call      qword ptr [7FF9F61AD140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DE7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E70180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FF9F625D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9F625D0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21A26B17DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF9F625D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61E2BF0
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
       mov       rdx,7FF9F61E2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F625D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,20CFB0009C8
       mov       rdx,[rdx]
       call      qword ptr [7FF9F617D140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E40180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24D8CE47DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF9F622D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61B2BF0
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
       mov       rdx,7FF9F61B2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F622D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,22AED8009A0
       mov       rdx,[rdx]
       call      qword ptr [7FF9F617D140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E40180]; System.Text.Encoding.GetBytes(System.String)
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
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26B7F6A7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF9F622D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61B2BF0
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
       mov       rdx,7FF9F61B2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F622D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9F60950C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,267624009C0
       mov       rdx,[rdx]
       call      qword ptr [7FF9F618D140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E50180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FF9F623D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9F623D0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A7F4147DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF9F623D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61C2BF0
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
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F623D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,1A145C009D0
       mov       rdx,[rdx]
       call      qword ptr [7FF9F61AD140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DE7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E70180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FF9F625D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9F625D0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E1D39A7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF9F625D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61E2BF0
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
       mov       rdx,7FF9F61E2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F625D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,1739EC009D8
       mov       rdx,[rdx]
       call      qword ptr [7FF9F617D140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E40180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B42CB97DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF9F622D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61B2BF0
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
       mov       rdx,7FF9F61B2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F622D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,244CC4009F0
       mov       rdx,[rdx]
       call      qword ptr [7FF9F61AD140]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
       call      qword ptr [7FF9F5DE7318]; System.String.Trim()
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
       jmp       qword ptr [7FF9F5E70180]; System.Text.Encoding.GetBytes(System.String)
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
       call      qword ptr [7FF9F625D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FF9F625D0B0]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2855A467DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FF9F625D2C0]
       mov       ecx,0AD4
       mov       rdx,7FF9F61E2BF0
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
       mov       rdx,7FF9F61E2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F625D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF9F60C50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.CombineToString()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       mov       dword ptr [rsp+30],0A
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FF9F6184C00]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F618CBE8]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
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
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rdi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       esi,r9d
       mov       ecx,1
       test      ebx,ebx
       cmovg     ecx,ebx
       mov       ebx,ecx
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M01_L51
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rsp+0B0],rcx
       mov       rcx,13AA2801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61514A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0B8],rax
       test      rax,rax
       je        near ptr M01_L52
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L01:
       mov       [rsp+0C8],r14
       mov       [rsp+0D0],r15d
       xor       ecx,ecx
       mov       [rsp+0C0],ecx
       mov       byte ptr [rsp+0C4],0
       mov       r13d,[rbp]
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L53
M01_L02:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r14,[rax+rdx*2]
       mov       r15d,[rsp+0D0]
       sub       r15d,ecx
       mov       rcx,[rsp+0B0]
       test      r13d,r13d
       jl        near ptr M01_L43
       mov       eax,r13d
       mov       ecx,r13d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r15d
       jg        near ptr M01_L55
       mov       [rsp+0A8],eax
       mov       [rsp+0A0],r14
       movsxd    rcx,eax
       lea       rcx,[r14+rcx*2]
       mov       eax,r13d
       cmp       r13d,0A
       jb        short M01_L05
       cmp       r13d,64
       jb        short M01_L04
       mov       rdx,13AA2800290
       mov       r14,[rdx]
M01_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r14
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
       mov       rdx,13AA2800290
       mov       r14,[rdx]
       shl       eax,2
       mov       eax,[r14+rax+10]
       mov       [rcx],eax
       jmp       short M01_L06
M01_L05:
       add       eax,30
       mov       [rcx-2],ax
M01_L06:
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L54
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+0A8]
       mov       [rsp+0C0],ecx
M01_L09:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+0D0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L44
       mov       rcx,17B34840C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
M01_L10:
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L60
M01_L11:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r14d,[rsp+0D0]
       sub       r14d,ecx
       mov       rcx,[rsp+0B0]
       test      ebx,ebx
       jl        near ptr M01_L36
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r14d
       jg        near ptr M01_L56
       mov       [rsp+98],eax
       mov       [rsp+90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,13AA2800290
       mov       r14,[rdx]
M01_L12:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r14
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
       mov       rdx,13AA2800290
       mov       r14,[rdx]
       mov       rdx,r14
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L15
M01_L14:
       add       eax,30
       mov       [rcx-2],ax
M01_L15:
       xor       ecx,ecx
       mov       [rsp+90],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rsp+90],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L45
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+98]
       mov       [rsp+0C0],ecx
M01_L18:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+0D0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L46
       mov       rcx,17B34840C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
M01_L19:
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L59
M01_L20:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r14,[rax+rdx*2]
       mov       r15d,[rsp+0D0]
       sub       r15d,ecx
       mov       rcx,[rsp+0B0]
       test      esi,esi
       jl        near ptr M01_L33
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r15d
       jg        near ptr M01_L57
       mov       [rsp+88],eax
       mov       [rsp+80],r14
       movsxd    rcx,eax
       lea       rcx,[r14+rcx*2]
       mov       edx,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       r9,13AA2800290
       mov       r14,[r9]
M01_L21:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9d,edx
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       edx,r8d
       mov       r8,r14
       shl       edx,2
       mov       edx,[r8+rdx+10]
       mov       [rcx],edx
       cmp       r9d,64
       mov       edx,r9d
       jae       short M01_L21
M01_L22:
       cmp       edx,0A
       jb        short M01_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9,13AA2800290
       mov       r14,[r9]
       mov       r9,r14
       shl       edx,2
       mov       edx,[r9+rdx+10]
       mov       [rcx],edx
       jmp       short M01_L24
M01_L23:
       add       edx,30
       mov       [rcx-2],dx
M01_L24:
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rsp+80],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L47
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+88]
       mov       [rsp+0C0],ecx
M01_L27:
       lea       rcx,[rsp+0C8]
       lea       rdx,[rsp+70]
       mov       r9d,[rsp+0C0]
       xor       r8d,r8d
       call      qword ptr [7FF9F5E7FE70]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32, Int32)
       mov       rcx,[rsp+70]
       mov       eax,[rsp+78]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5758]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Clear()
       mov       rcx,[rdi+10]
       lea       r8,[rsp+0D8]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5E54630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L58
M01_L28:
       mov       rax,[rsp+0D8]
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L29:
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L30:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L32
       xor       r8d,r8d
       xor       r9d,r9d
M01_L31:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r14
       mov       [rsp+40],r15d
       lea       rcx,[rsp+0A8]
       mov       [rsp+20],rcx
       mov       ecx,r13d
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EFE8]
       jmp       near ptr M01_L08
M01_L32:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M01_L31
M01_L33:
       test      rcx,rcx
       jne       short M01_L35
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L34:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L41
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L42
M01_L35:
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L34
M01_L36:
       test      rcx,rcx
       jne       short M01_L38
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L37:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L39
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L40
M01_L38:
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L37
M01_L39:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L40:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r13
       mov       [rsp+40],r14d
       lea       rcx,[rsp+98]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EFE8]
       jmp       near ptr M01_L17
M01_L41:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L42:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r14
       mov       [rsp+40],r15d
       lea       rcx,[rsp+88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EFE8]
       jmp       near ptr M01_L26
M01_L43:
       test      rcx,rcx
       je        near ptr M01_L29
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M01_L30
M01_L44:
       lea       rcx,[rsp+0B0]
       mov       rdx,17B34840C30
       call      qword ptr [7FF9F5FB58F0]
       jmp       near ptr M01_L10
M01_L45:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L11
M01_L46:
       lea       rcx,[rsp+0B0]
       mov       rdx,17B34840C30
       call      qword ptr [7FF9F5FB58F0]
       jmp       near ptr M01_L19
M01_L47:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L20
M01_L48:
       call      qword ptr [7FF9F602E9D0]
       int       3
M01_L49:
       mov       ecx,ebx
       mov       edx,esi
       call      qword ptr [7FF9F6187D98]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9F5F564B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r13d,1
       jo        short M01_L51
M01_L50:
       cmp       r13d,ebp
       jl        short M01_L49
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.String, System.Private.CoreLib]](System.Collections.Generic.List`1<System.String>)
       call      qword ptr [7FF9F64FC300]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF9F656E7A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+0D8],rax
       mov       rdx,[rdi+10]
       lea       r9,[rsp+0D8]
       mov       r8,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.String, System.Private.CoreLib],[System.String[], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String[]>, System.String, System.String[] ByRef)
       call      qword ptr [7FF9F67070D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       jmp       near ptr M01_L28
M01_L51:
       call      CORINFO_HELP_OVERFLOW
M01_L52:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L01
M01_L53:
       lea       rcx,[rsp+0B0]
       mov       edx,r13d
       xor       r8d,r8d
       call      qword ptr [7FF9F67848D0]
       jmp       near ptr M01_L09
M01_L54:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L02
M01_L55:
       xor       ecx,ecx
       mov       [rsp+0A8],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L56:
       xor       ecx,ecx
       mov       [rsp+98],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L57:
       xor       ecx,ecx
       mov       [rsp+88],ecx
       xor       eax,eax
       jmp       near ptr M01_L25
M01_L58:
       mov       ebp,[rbp]
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,17B34840008
       mov       [rsp+28],rcx
       mov       ecx,ebp
       mov       edx,1
       mov       r8,17B34844368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       ebp,eax
       xor       ecx,ecx
       mov       [rsp+60],rcx
       lea       rcx,[rsp+60]
       mov       edx,1
       call      qword ptr [7FF9F5E74780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rsp+60]
       mov       [rsp+68],rcx
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,17B34840008
       mov       [rsp+28],rcx
       mov       ecx,ebx
       mov       edx,1
       mov       r8,17B3484BBE8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       ebx,eax
       xor       ecx,ecx
       mov       [rsp+58],rcx
       lea       rcx,[rsp+58]
       mov       edx,1
       call      qword ptr [7FF9F5E74780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rsp+58]
       mov       [rsp+68],rcx
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,17B34840008
       mov       [rsp+28],rcx
       mov       ecx,esi
       mov       edx,1
       mov       r8,17B3484BC10
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       esi,eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,ebp
       call      qword ptr [7FF9F5E7DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       jmp       near ptr M01_L50
M01_L59:
       lea       rcx,[rsp+0B0]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FF9F67848D0]
       jmp       near ptr M01_L27
M01_L60:
       lea       rcx,[rsp+0B0]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F67848D0]
       jmp       near ptr M01_L18
; Total bytes of code 2420
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
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
       call      qword ptr [7FF9F5D17750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,rbp
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F64FD8A8]; DotNetTips.Spargine.Core.FastStringBuilder.Combine(Boolean ByRef, System.String[])
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
M02_L01:
       call      qword ptr [7FF9F623D2C0]
       mov       ecx,0A0C
       mov       rdx,7FF9F61C2BF0
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
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F623D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       call      qword ptr [7FF9F623D2C0]
       mov       ecx,2F3
       mov       rdx,7FF9F61C2BF0
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
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F623D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       ecx,28
       mov       edx,35
       call      qword ptr [7FF9F602ED48]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 473
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeHash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       xor       edx,edx
       call      qword ptr [7FF9F618CC00]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeHash(System.String, DotNetTips.Spargine.Extensions.HashType)
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
       call      qword ptr [7FF9F618CBB8]; DotNetTips.Spargine.Extensions.StringExtensions.GetHash(System.String, DotNetTips.Spargine.Extensions.HashType)
       mov       rbx,rax
       mov       rcx,1F15940C8E0
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
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L24
       lea       rcx,[rsi+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L24
M01_L01:
       mov       rdi,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L03:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-48],rdi
       jmp       short M01_L05
M01_L04:
       mov       [rdi+10],r15d
       jmp       near ptr M01_L22
M01_L05:
       test      rbx,rbx
       je        near ptr M01_L07
       lea       r15,[rbx+10]
       mov       ebx,[rbx+8]
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L15
M01_L06:
       mov       ecx,r13d
       movzx     ecx,byte ptr [r15+rcx]
       mov       r8,1F15D400428
       mov       r8,[r8]
       mov       rdx,231EB3B49E8
       call      qword ptr [7FF9F6004810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        near ptr M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        near ptr M01_L14
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        near ptr M01_L08
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
       call      qword ptr [7FF9F623D2C0]
       mov       ecx,0F
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       r12,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF9F623D0B0]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r13
       call      qword ptr [7FF9F6056670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rdi
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L14
M01_L09:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF9F5DC73F0]
       mov       rbx,rax
       jmp       near ptr M01_L20
M01_L10:
       mov       rax,rbx
       jmp       near ptr M01_L21
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L13:
       mov       [rdi+18],r12d
M01_L14:
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L06
M01_L15:
       mov       rcx,rdi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       rbx,rax
       test      rbx,rbx
       je        short M01_L10
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L18
M01_L16:
       mov       [rsi+10],ecx
       jmp       near ptr M01_L10
M01_L17:
       call      qword ptr [7FF9F67B43C0]
       test      eax,eax
       jne       near ptr M01_L09
M01_L18:
       mov       ecx,[rbx+8]
       dec       ecx
       cmp       ecx,[rbx+8]
       jae       near ptr M01_L11
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L19
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L09
       jmp       short M01_L20
M01_L19:
       call      qword ptr [7FF9F67B43C0]
       test      eax,eax
       jne       near ptr M01_L09
M01_L20:
       mov       rax,rbx
M01_L21:
       mov       [rbp-50],rax
       mov       rcx,rsp
       call      M01_L27
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
M01_L22:
       mov       rax,231EB3A0008
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
       call      qword ptr [7FF9F618E340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L24:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F64F6B38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rcx,1F15940C8E0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L28
       call      qword ptr [7FF9F618E340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       r14,[rbp-48]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L35
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-48]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       r14,[rbp-48]
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
       call      qword ptr [7FF9F64F6B08]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L35
M01_L33:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L35
M01_L34:
       mov       r14,[rbp-48]
       mov       rcx,rsi
       mov       rdx,r14
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L35:
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
; Total bytes of code 1265
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeSHA256Hash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FF9F618CC18]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
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
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       [rsp+90],rax
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
       mov       r8,20BE58009F0
       mov       rdi,[r8]
       mov       ebp,[rbx+8]
       cmp       ebp,20
       jle       near ptr M01_L04
       lea       r8,[rbx+0C]
       mov       [rsp+90],r8
       mov       rsi,[rsp+90]
       mov       r14d,ebp
       lea       r8,[rsp+88]
       lea       r9,[rsp+80]
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FF9F60AD140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rsi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rsp+88]
       cmp       r15,7FFFFFFF
       ja        near ptr M01_L06
       cmp       r9d,r14d
       jne       near ptr M01_L05
M01_L00:
       xor       edx,edx
       mov       [rsp+90],rdx
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
       call      qword ptr [7FF9F601A478]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
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
       lea       rdx,[rsp+78]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+38]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+58]
       lea       r8,[rsp+48]
       mov       rcx,24C734BBD08
       xor       r9d,r9d
       call      qword ptr [7FF9F64FE040]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       rsi,10
       mov       ecx,20
       mov       [rsp+68],rsi
       mov       [rsp+70],ecx
       lea       rcx,[rsp+68]
       call      qword ptr [7FF9F64FD890]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(System.ReadOnlySpan`1<Byte> ByRef)
       nop
       add       rsp,98
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
       mov       rax,24C734B0008
       add       rsp,98
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
       call      qword ptr [7FF9F60A50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r14d
       call      qword ptr [7FF9F5DCC8A0]
       add       r15d,eax
       jns       near ptr M01_L00
M01_L06:
       call      qword ptr [7FF9F5DCC7E0]
       int       3
M01_L07:
       mov       ecx,6A61
       mov       rdx,7FF9F61C56E0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F67B6A48]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF9F61C56E0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DCF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 696
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Concat()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       mov       dword ptr [rsp+30],0A
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FF9F6184C00]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       mov       r9,rax
       mov       rcx,rsi
       mov       rdx,29B45490C60
       mov       r8d,1
       call      qword ptr [7FF9F618CC30]; DotNetTips.Spargine.Extensions.StringExtensions.Concat(System.String, System.String, Boolean, System.String[])
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
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0E0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+0E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+0F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+100],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rdi,rcx
       mov       rbp,rdx
       mov       ebx,r8d
       mov       esi,r9d
       mov       ecx,1
       test      ebx,ebx
       cmovg     ecx,ebx
       mov       ebx,ecx
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M01_L51
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       xor       ecx,ecx
       mov       [rsp+0B0],rcx
       mov       rcx,25AB7401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61514A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+0B8],rax
       test      rax,rax
       je        near ptr M01_L52
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M01_L01:
       mov       [rsp+0C8],r14
       mov       [rsp+0D0],r15d
       xor       ecx,ecx
       mov       [rsp+0C0],ecx
       mov       byte ptr [rsp+0C4],0
       mov       r13d,[rbp]
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L53
M01_L02:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r14,[rax+rdx*2]
       mov       r15d,[rsp+0D0]
       sub       r15d,ecx
       mov       rcx,[rsp+0B0]
       test      r13d,r13d
       jl        near ptr M01_L43
       mov       eax,r13d
       mov       ecx,r13d
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r15d
       jg        near ptr M01_L55
       mov       [rsp+0A8],eax
       mov       [rsp+0A0],r14
       movsxd    rcx,eax
       lea       rcx,[r14+rcx*2]
       mov       eax,r13d
       cmp       r13d,0A
       jb        short M01_L05
       cmp       r13d,64
       jb        short M01_L04
       mov       rdx,25AB7400290
       mov       r14,[rdx]
M01_L03:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r14
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
       mov       rdx,25AB7400290
       mov       r14,[rdx]
       shl       eax,2
       mov       eax,[r14+rax+10]
       mov       [rcx],eax
       jmp       short M01_L06
M01_L05:
       add       eax,30
       mov       [rcx-2],ax
M01_L06:
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
       mov       eax,1
M01_L07:
       xor       ecx,ecx
       mov       [rsp+0A0],rcx
M01_L08:
       test      eax,eax
       je        near ptr M01_L54
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+0A8]
       mov       [rsp+0C0],ecx
M01_L09:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+0D0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L44
       mov       rcx,29B45490C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
M01_L10:
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L60
M01_L11:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r13,[rax+rdx*2]
       mov       r14d,[rsp+0D0]
       sub       r14d,ecx
       mov       rcx,[rsp+0B0]
       test      ebx,ebx
       jl        near ptr M01_L36
       mov       eax,ebx
       mov       ecx,ebx
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r14d
       jg        near ptr M01_L56
       mov       [rsp+98],eax
       mov       [rsp+90],r13
       movsxd    rcx,eax
       lea       rcx,[r13+rcx*2]
       mov       eax,ebx
       cmp       ebx,0A
       jb        short M01_L14
       cmp       ebx,64
       jb        short M01_L13
       mov       rdx,25AB7400290
       mov       r14,[rdx]
M01_L12:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       edx,eax
       imul      rdx,51EB851F
       shr       rdx,25
       imul      r8d,edx,64
       sub       eax,r8d
       mov       r8,r14
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
       mov       rdx,25AB7400290
       mov       r14,[rdx]
       mov       rdx,r14
       shl       eax,2
       mov       eax,[rdx+rax+10]
       mov       [rcx],eax
       jmp       short M01_L15
M01_L14:
       add       eax,30
       mov       [rcx-2],ax
M01_L15:
       xor       ecx,ecx
       mov       [rsp+90],rcx
       mov       eax,1
M01_L16:
       xor       ecx,ecx
       mov       [rsp+90],rcx
M01_L17:
       test      eax,eax
       je        near ptr M01_L45
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+98]
       mov       [rsp+0C0],ecx
M01_L18:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       rax,[rax+rdx*2]
       mov       edx,[rsp+0D0]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L46
       mov       rcx,29B45490C3C
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+0C0]
       inc       ecx
       mov       [rsp+0C0],ecx
M01_L19:
       cmp       byte ptr [rsp+0C4],0
       jne       near ptr M01_L59
M01_L20:
       mov       ecx,[rsp+0C0]
       cmp       ecx,[rsp+0D0]
       ja        near ptr M01_L48
       mov       rax,[rsp+0C8]
       mov       edx,ecx
       lea       r14,[rax+rdx*2]
       mov       r15d,[rsp+0D0]
       sub       r15d,ecx
       mov       rcx,[rsp+0B0]
       test      esi,esi
       jl        near ptr M01_L33
       mov       eax,esi
       mov       ecx,esi
       or        ecx,1
       lzcnt     ecx,ecx
       xor       ecx,1F
       mov       rdx,7FFA52A487F8
       add       rax,[rdx+rcx*8]
       sar       rax,20
       cmp       eax,r15d
       jg        near ptr M01_L57
       mov       [rsp+88],eax
       mov       [rsp+80],r14
       movsxd    rcx,eax
       lea       rcx,[r14+rcx*2]
       mov       edx,esi
       cmp       esi,0A
       jb        short M01_L23
       cmp       esi,64
       jb        short M01_L22
       mov       r9,25AB7400290
       mov       r14,[r9]
M01_L21:
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9d,edx
       imul      r9,51EB851F
       shr       r9,25
       imul      r8d,r9d,64
       sub       edx,r8d
       mov       r8,r14
       shl       edx,2
       mov       edx,[r8+rdx+10]
       mov       [rcx],edx
       cmp       r9d,64
       mov       edx,r9d
       jae       short M01_L21
M01_L22:
       cmp       edx,0A
       jb        short M01_L23
       add       rcx,0FFFFFFFFFFFFFFFC
       mov       r9,25AB7400290
       mov       r14,[r9]
       mov       r9,r14
       shl       edx,2
       mov       edx,[r9+rdx+10]
       mov       [rcx],edx
       jmp       short M01_L24
M01_L23:
       add       edx,30
       mov       [rcx-2],dx
M01_L24:
       xor       ecx,ecx
       mov       [rsp+80],rcx
       mov       eax,1
M01_L25:
       xor       ecx,ecx
       mov       [rsp+80],rcx
M01_L26:
       test      eax,eax
       je        near ptr M01_L47
       mov       ecx,[rsp+0C0]
       add       ecx,[rsp+88]
       mov       [rsp+0C0],ecx
M01_L27:
       lea       rcx,[rsp+0C8]
       lea       rdx,[rsp+70]
       mov       r9d,[rsp+0C0]
       xor       r8d,r8d
       call      qword ptr [7FF9F5E7FE70]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32, Int32)
       mov       rcx,[rsp+70]
       mov       eax,[rsp+78]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5758]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Clear()
       mov       rcx,[rdi+10]
       lea       r8,[rsp+0D8]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5E54630]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L58
M01_L28:
       mov       rax,[rsp+0D8]
       add       rsp,0E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L29:
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L30:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L32
       xor       r8d,r8d
       xor       r9d,r9d
M01_L31:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r14
       mov       [rsp+40],r15d
       lea       rcx,[rsp+0A8]
       mov       [rsp+20],rcx
       mov       ecx,r13d
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EDA8]
       jmp       near ptr M01_L08
M01_L32:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
       jmp       short M01_L31
M01_L33:
       test      rcx,rcx
       jne       short M01_L35
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L34:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L41
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L42
M01_L35:
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L34
M01_L36:
       test      rcx,rcx
       jne       short M01_L38
       call      qword ptr [7FF9F5FBF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L37:
       mov       rcx,[rax+28]
       test      rcx,rcx
       jne       short M01_L39
       xor       r8d,r8d
       xor       r9d,r9d
       jmp       short M01_L40
M01_L38:
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L37
M01_L39:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L40:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r13
       mov       [rsp+40],r14d
       lea       rcx,[rsp+98]
       mov       [rsp+20],rcx
       mov       ecx,ebx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EDA8]
       jmp       near ptr M01_L17
M01_L41:
       lea       r8,[rcx+0C]
       mov       r9d,[rcx+8]
M01_L42:
       mov       [rsp+48],r8
       mov       [rsp+50],r9d
       mov       [rsp+38],r14
       mov       [rsp+40],r15d
       lea       rcx,[rsp+88]
       mov       [rsp+20],rcx
       mov       ecx,esi
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F675EDA8]
       jmp       near ptr M01_L26
M01_L43:
       test      rcx,rcx
       je        near ptr M01_L29
       call      qword ptr [7FF9F5FBF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       near ptr M01_L30
M01_L44:
       lea       rcx,[rsp+0B0]
       mov       rdx,29B45490C30
       call      qword ptr [7FF9F5FB58F0]
       jmp       near ptr M01_L10
M01_L45:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L11
M01_L46:
       lea       rcx,[rsp+0B0]
       mov       rdx,29B45490C30
       call      qword ptr [7FF9F5FB58F0]
       jmp       near ptr M01_L19
M01_L47:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L20
M01_L48:
       call      qword ptr [7FF9F602E9D0]
       int       3
M01_L49:
       mov       ecx,ebx
       mov       edx,esi
       call      qword ptr [7FF9F6187D98]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Int32)
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9F5F564B8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r13d,1
       jo        short M01_L51
M01_L50:
       cmp       r13d,ebp
       jl        short M01_L49
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.String, System.Private.CoreLib]](System.Collections.Generic.List`1<System.String>)
       call      qword ptr [7FF9F64FC300]; DotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>)
       call      qword ptr [7FF9F656E7A8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+0D8],rax
       mov       rdx,[rdi+10]
       lea       r9,[rsp+0D8]
       mov       r8,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.String, System.Private.CoreLib],[System.String[], System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.String,System.String[]>, System.String, System.String[] ByRef)
       call      qword ptr [7FF9F67070D8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       jmp       near ptr M01_L28
M01_L51:
       call      CORINFO_HELP_OVERFLOW
M01_L52:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L01
M01_L53:
       lea       rcx,[rsp+0B0]
       mov       edx,r13d
       xor       r8d,r8d
       call      qword ptr [7FF9F6784888]
       jmp       near ptr M01_L09
M01_L54:
       lea       rcx,[rsp+0B0]
       call      qword ptr [7FF9F5FB5938]
       jmp       near ptr M01_L02
M01_L55:
       xor       ecx,ecx
       mov       [rsp+0A8],ecx
       xor       eax,eax
       jmp       near ptr M01_L07
M01_L56:
       xor       ecx,ecx
       mov       [rsp+98],ecx
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L57:
       xor       ecx,ecx
       mov       [rsp+88],ecx
       xor       eax,eax
       jmp       near ptr M01_L25
M01_L58:
       mov       ebp,[rbp]
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,29B45490008
       mov       [rsp+28],rcx
       mov       ecx,ebp
       mov       edx,1
       mov       r8,29B45494368
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       ebp,eax
       xor       ecx,ecx
       mov       [rsp+60],rcx
       lea       rcx,[rsp+60]
       mov       edx,1
       call      qword ptr [7FF9F5E74780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rsp+60]
       mov       [rsp+68],rcx
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,29B45490008
       mov       [rsp+28],rcx
       mov       ecx,ebx
       mov       edx,1
       mov       r8,29B4549BBE8
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       ebx,eax
       xor       ecx,ecx
       mov       [rsp+58],rcx
       lea       rcx,[rsp+58]
       mov       edx,1
       call      qword ptr [7FF9F5E74780]; System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rsp+58]
       mov       [rsp+68],rcx
       lea       rcx,[rsp+68]
       mov       [rsp+20],rcx
       mov       rcx,29B45490008
       mov       [rsp+28],rcx
       mov       ecx,esi
       mov       edx,1
       mov       r8,29B4549BC10
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9F618D2A8]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32> ByRef, System.String)
       mov       esi,eax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       edx,ebp
       call      qword ptr [7FF9F5E7DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       jmp       near ptr M01_L50
M01_L59:
       lea       rcx,[rsp+0B0]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FF9F6784888]
       jmp       near ptr M01_L27
M01_L60:
       lea       rcx,[rsp+0B0]
       mov       edx,ebx
       xor       r8d,r8d
       call      qword ptr [7FF9F6784888]
       jmp       near ptr M01_L18
; Total bytes of code 2420
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
       je        near ptr M02_L21
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
       je        near ptr M02_L22
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
       je        near ptr M02_L23
       mov       rcx,25AB740E8D8
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
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-48],r13
       jmp       short M02_L07
M02_L05:
       mov       [r15+10],eax
       jmp       near ptr M02_L21
M02_L06:
       mov       [r15+10],ecx
       jmp       near ptr M02_L22
M02_L07:
       lea       rdx,[rsi+0C]
       mov       esi,[rsi+8]
       test      esi,esi
       je        short M02_L11
       mov       r8,[r13+8]
       mov       r15d,[r13+18]
       lea       ecx,[r15+rsi]
       cmp       ecx,[r8+8]
       ja        short M02_L10
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jg        short M02_L08
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M02_L09
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L09
M02_L08:
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L09:
       add       esi,r15d
       mov       [r13+18],esi
       jmp       short M02_L11
M02_L10:
       mov       rcx,r13
       mov       r8d,esi
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L11:
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M02_L20
       xor       r15d,r15d
       test      esi,esi
       jle       near ptr M02_L20
M02_L12:
       mov       ecx,r15d
       mov       rcx,[rdi+rcx*8+10]
       test      bl,bl
       je        near ptr M02_L17
       test      rcx,rcx
       je        short M02_L16
       lea       rdx,[rcx+0C]
       mov       r8d,[rcx+8]
       test      r8d,r8d
       je        short M02_L16
       mov       rcx,[r13+8]
       mov       eax,[r13+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M02_L15
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M02_L13
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M02_L14
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M02_L14
M02_L13:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L14:
       mov       [r13+18],r12d
       jmp       short M02_L16
M02_L15:
       mov       rcx,r13
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L16:
       mov       rdx,29B45491C14
       mov       rcx,[r13+8]
       mov       r8d,[r13+18]
       lea       eax,[r8+2]
       cmp       [rcx+8],eax
       jb        short M02_L18
       movsxd    rdx,r8d
       lea       rcx,[rcx+rdx*2+10]
       mov       word ptr [rcx],0D
       mov       word ptr [rcx+2],0A
       mov       [r13+18],eax
       jmp       short M02_L19
M02_L17:
       mov       rdx,r14
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F60CC2A0]; System.Text.StringBuilder.Append(System.String)
       jmp       short M02_L19
M02_L18:
       mov       rcx,r13
       mov       r8d,2
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M02_L19:
       inc       r15d
       cmp       esi,r15d
       jg        near ptr M02_L12
M02_L20:
       mov       rcx,r13
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
       mov       rax,29B45490008
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
       mov       r14,29B45490008
       jmp       near ptr M02_L00
M02_L23:
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
M02_L24:
       call      qword ptr [7FF9F618E340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L25:
       mov       rcx,[r15+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F64F6A30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rcx,25AB740E8D8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M02_L29
       call      qword ptr [7FF9F618E340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M02_L30
M02_L29:
       mov       rsi,[rcx+18]
M02_L30:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M02_L35
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       short M02_L31
       mov       r13,[rbp-48]
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       add       ecx,[r13+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M02_L36
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M02_L32
M02_L31:
       mov       rdx,[rbp-48]
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       mov       r13,[rbp-48]
       je        short M02_L36
M02_L32:
       cmp       qword ptr [rsi+20],0
       jne       short M02_L33
       lea       rcx,[rsi+20]
       mov       rdx,r13
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M02_L36
M02_L33:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M02_L34
       mov       rcx,[rsi+18]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF9F64F6A00]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M02_L36
M02_L34:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M02_L36
M02_L35:
       mov       r13,[rbp-48]
       mov       rcx,rsi
       mov       rdx,r13
       mov       rax,[rsi]
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
; Total bytes of code 1154
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ContainsAny()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rcx,1E3757F1F10
       mov       [rax+10],rcx
       mov       rcx,1E3758049E8
       mov       [rax+18],rcx
       mov       rcx,rsi
       mov       r8,rax
       mov       edx,3
       call      qword ptr [7FF9F619C5E8]; DotNetTips.Spargine.Extensions.StringExtensions.ContainsAny(System.String, System.StringComparison, System.String[])
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
       mov       rcx,1E375804A38
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5D1A770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       mov       r8,7FF9F6713468
       mov       [rsi+18],r8
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Func`2<System.String,Boolean>)
       call      qword ptr [7FF9F6717498]; DotNetTips.Spargine.Extensions.EnumerableExtensions.FastAny[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
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
       call      qword ptr [7FF9F624CBA0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FF9F624CAF8]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1E375804A00
       mov       r8,rbx
       call      qword ptr [7FF9F5E8D470]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,259F29149E8
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,21D266349E8
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DelimitedStringToArray()
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],0
       je        short M00_L01
       mov       dword ptr [rsp+3C],2C
       lea       rdx,[rsp+3C]
       mov       [rsp+20],rdx
       mov       dword ptr [rsp+28],1
       lea       rdx,[rsp+20]
       mov       r8d,7FFFFFFF
       mov       r9d,1
       call      qword ptr [7FF9F5DE70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
M00_L00:
       mov       [rsp+30],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rcx,7FF9F5D25120
       mov       edx,61
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2AE69801F78
       mov       rax,[rcx]
       jmp       short M00_L00
; Total bytes of code 162
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
       mov       rax,204FA0C0E604
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      edi,edi
       jl        near ptr M01_L06
       test      r14d,0FFFFFFFC
       jne       near ptr M01_L07
M01_L00:
       cmp       edi,1
       jle       near ptr M01_L08
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M01_L08
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L10
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
       call      qword ptr [7FF9F5DE71B0]; System.String.MakeSeparatorListAny(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
       mov       eax,[rbp+50]
       cmp       eax,[rbp+60]
       ja        near ptr M01_L11
       mov       r10,[rbp+58]
       test      eax,eax
       je        near ptr M01_L12
       test      r14d,r14d
       je        near ptr M01_L05
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
       call      qword ptr [7FF9F5DE7198]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rbx,rax
M01_L02:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L03
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,2AE69801ED0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F650CD60]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L03:
       mov       rax,rbx
       mov       rcx,204FA0C0E604
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
       call      qword ptr [7FF9F5DE7180]
       mov       rbx,rax
       jmp       short M01_L02
M01_L06:
       mov       ecx,1C7
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FF9F672D440]
       int       3
M01_L07:
       mov       ecx,45
       mov       edx,59
       call      qword ptr [7FF9F604ECB8]
       int       3
M01_L08:
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,edi
       call      qword ptr [7FF9F5DE7150]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       mov       rcx,204FA0C0E604
       cmp       [rbp],rcx
       je        short M01_L09
       call      CORINFO_HELP_FAIL_FAST
M01_L09:
       nop
       lea       rsp,[rbp+68]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       cmp       r15d,edi
       jge       near ptr M01_L01
       and       r14d,0FFFFFFFD
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF9F604E9D0]
       int       3
M01_L12:
       mov       edi,1
       jmp       near ptr M01_L00
; Total bytes of code 561
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsIgnoreCase()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vpcmpeqq  xmm0,xmm0,[7FF9F661C980]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 39
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsOrBothNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,296A05349E8
       mov       rdx,296A0534A20
       mov       r8d,4
       call      qword ptr [7FF9F5DE61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       call      qword ptr [7FF9F5E95068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604ECB8]
       int       3
M01_L05:
       cmp       edi,5
       ja        near ptr M01_L08
       mov       eax,edi
       lea       rcx,[7FF9F662C378]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6586598]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       rcx,7FF9F5D25120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,256128003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6586598]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
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
       jmp       qword ptr [7FF9F5DE5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F62C5338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 391
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,208C97B49E8
       mov       r8,208C97B4A08
       call      qword ptr [7FF9F617CCF0]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF9F5DB75D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9F5DB75D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F5DB7240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,208C97A7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,208C97B4A28
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FF9F622D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FF9F622D0B0]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,208C97B4A48
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 472
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       call      qword ptr [7FF9F618CD20]; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
       mov       eax,[rsi+10]
       inc       eax
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       cmp       eax,edx
       jge       near ptr M01_L16
       mov       [rsi+10],eax
       mov       rdx,187C440E8D0
       mov       rdi,[rdx]
       lea       rax,[rbx+0C]
       mov       [rbp-40],rax
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
       jbe       near ptr M01_L18
       cmp       eax,3D
       je        short M01_L06
M01_L04:
       cmp       rdx,rsi
       jb        short M01_L03
M01_L05:
       test      r15d,r15d
       je        near ptr M01_L10
       cmp       r15d,1
       jne       near ptr M01_L19
       mov       r15d,2
       jmp       short M01_L10
M01_L06:
       dec       ecx
       inc       r15d
       jmp       short M01_L04
M01_L07:
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
       call      qword ptr [7FF9F602C660]; System.Text.Ascii.WidenAsciiToUtf16(Byte*, Char*, UIntPtr)
       cmp       eax,ebx
       jne       near ptr M01_L29
M01_L08:
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rax,r14
M01_L09:
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
M01_L10:
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
       jl        near ptr M01_L21
       lea       rcx,[rsi+10]
       mov       edx,[rsi+8]
       mov       [rbp-68],r14
       mov       [rbp-60],ebx
       mov       [rbp-78],rcx
       mov       [rbp-70],edx
       lea       rcx,[rbp-68]
       lea       rdx,[rbp-78]
       lea       r8,[rbp-48]
       call      qword ptr [7FF9F6144720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        near ptr M01_L22
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       ebx,[rsi+8]
       test      ebx,ebx
       je        near ptr M01_L23
       mov       [rbp-50],rsi
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       je        short M01_L13
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L30
       mov       rsi,[rbp-50]
       add       rsi,10
M01_L11:
       test      rsi,rsi
       je        short M01_L12
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
       jmp       short M01_L14
M01_L12:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF9F602ED18]
       int       3
M01_L13:
       xor       esi,esi
       jmp       short M01_L11
M01_L14:
       mov       r13d,r14d
       cmp       r14d,ebx
       jne       near ptr M01_L25
M01_L15:
       test      r13d,r13d
       je        near ptr M01_L26
       jmp       near ptr M01_L07
M01_L16:
       mov       [rsi+10],edx
M01_L17:
       mov       rax,1C8522F0008
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
       jmp       near ptr M01_L04
M01_L19:
       cmp       r15d,2
       jne       short M01_L20
       mov       r15d,1
       jmp       near ptr M01_L10
M01_L20:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F628FC78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F60A74B0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       call      qword ptr [7FF9F602E9D0]
       int       3
M01_L22:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF9F628FC78]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F60A74B0]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rax,1C8522F0008
       jmp       near ptr M01_L09
M01_L24:
       mov       edx,ebx
       mov       rcx,rsi
       call      qword ptr [7FF9F602C468]; System.Text.Ascii.GetIndexOfFirstNonAsciiByte_Vector(Byte*, UIntPtr)
       mov       r14d,eax
       mov       r13d,r14d
       cmp       r14d,ebx
       je        near ptr M01_L15
M01_L25:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       call      qword ptr [7FF9F5DCC990]
       add       eax,r13d
       mov       r13d,eax
       test      r13d,r13d
       jge       near ptr M01_L15
       call      qword ptr [7FF9F5DCC7E0]
       int       3
M01_L26:
       mov       rax,1C8522F0008
       jmp       near ptr M01_L09
M01_L27:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FF9F602ED18]
       int       3
M01_L28:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FF9F602ED48]
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
       call      qword ptr [7FF9F5DCCA08]
       jmp       near ptr M01_L08
M01_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 973
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F6775AE8]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F6775AE8]
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
       call      qword ptr [7FF9F5DB73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FF9F618CE10]; DotNetTips.Spargine.Extensions.StringExtensions.HasWhitespace(System.String)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F6785AE8]
       test      eax,eax
       jne       near ptr M01_L12
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L12
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FF9F6785AE8]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L08
       jmp       short M01_L09
M01_L07:
       call      qword ptr [7FF9F6785AE8]
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
       call      qword ptr [7FF9F623D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FF9F623D0B0]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,240EF4F7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF9F5DC73F0]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,0A
       mov       r8d,3E
       call      qword ptr [7FF9F61ACE28]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32, Char)
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
       mov       [rbp-50],rsp
       mov       rdi,rcx
       mov       ebx,edx
       mov       esi,r8d
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L24
       test      ebx,ebx
       jle       near ptr M01_L24
       mov       rcx,1B16240E8D8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L25
       mov       rcx,[rcx+18]
M01_L00:
       mov       r14,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L28
       mov       rcx,[r14+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M01_L26
       lea       rcx,[r14+20]
       mov       r8,[rbp-30]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-30]
       jne       near ptr M01_L26
M01_L01:
       mov       r15,[rbp-30]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-30],rcx
M01_L03:
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9F60EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-38],r15
       mov       r14d,1
M01_L04:
       mov       r8d,ebx
       cmp       r14d,r8d
       jg        short M01_L06
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
M01_L05:
       add       r14d,1
       jo        short M01_L09
       jmp       short M01_L04
M01_L06:
       lea       rdx,[rdi+0C]
       mov       esi,[rdi+8]
       test      esi,esi
       je        short M01_L13
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       ebx,ecx
       lea       ecx,[rbx+rsi]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M01_L12
       movsxd    rcx,ebx
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M01_L08
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       add       esi,ebx
       mov       [r15+18],esi
       jmp       short M01_L13
M01_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M01_L07
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L07
M01_L09:
       call      CORINFO_HELP_OVERFLOW
M01_L10:
       movzx     edx,si
       mov       rcx,r15
       call      qword ptr [7FF9F60EC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L05
M01_L11:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L12:
       mov       rcx,r15
       mov       r8d,esi
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       mov       rcx,r15
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       r14d,[rdi+8]
       lea       ebx,[r14-1]
       test      ebx,ebx
       jl        near ptr M01_L22
       cmp       r14d,ebx
       jle       short M01_L17
M01_L14:
       mov       ecx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        near ptr M01_L22
       jmp       short M01_L16
M01_L15:
       call      qword ptr [7FF9F67A5B18]
       test      eax,eax
       je        short M01_L22
M01_L16:
       dec       ebx
       jns       short M01_L14
       jmp       short M01_L22
M01_L17:
       cmp       ebx,r14d
       jae       short M01_L11
       mov       ecx,ebx
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L20
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M01_L22
       jmp       short M01_L21
M01_L18:
       test      ebx,ebx
       je        short M01_L19
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       mov       r8d,ebx
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[rdi+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M01_L23
M01_L19:
       mov       rax,1F1F42E0008
       jmp       short M01_L23
M01_L20:
       call      qword ptr [7FF9F67A5B18]
       test      eax,eax
       je        short M01_L22
M01_L21:
       dec       ebx
       jns       short M01_L17
M01_L22:
       inc       ebx
       cmp       r14d,ebx
       jne       short M01_L18
       mov       rax,rdi
M01_L23:
       mov       [rbp-40],rax
       mov       rcx,rsp
       call      M01_L29
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
M01_L24:
       mov       rax,1F1F42E0008
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       call      qword ptr [7FF9F61AE340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L26:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6516A78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L27
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L27:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L28:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M01_L03
M01_L29:
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
       mov       rcx,1B16240E8D8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L30
       mov       r15,[rbp-38]
       call      qword ptr [7FF9F61AE340]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M01_L31
M01_L30:
       mov       rbx,[rcx+18]
M01_L31:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rbx],rcx
       jne       near ptr M01_L36
       mov       rsi,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rsi+18],rcx
       jne       short M01_L32
       mov       r15,[rbp-38]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[rsi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L37
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9F60EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L33
M01_L32:
       mov       r15,[rbp-38]
       mov       rdx,r15
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L37
M01_L33:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L34
       lea       rcx,[rbx+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L37
M01_L34:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L35
       mov       rcx,[rbx+18]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6516A48]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L37
M01_L35:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L37
M01_L36:
       mov       r15,[rbp-38]
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L37:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 976
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FF9F619CE40]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char ByRef)
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
       call      qword ptr [7FF9F6796520]
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FF9F619CE58]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char ByRef)
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
       mov       rcx,7FFA52A42E50
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FF9F6796BC8]
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FF9F617CE70]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char ByRef)
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
       mov       rcx,7FFA52A42E50
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
       call      qword ptr [7FF9F6776BC8]
       jmp       short M01_L00
; Total bytes of code 68
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FF9F61ACE88]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char ByRef)
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
       mov       rcx,7FFA52A42E50
       test      byte ptr [rax+rcx],80
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FF9F67A63B8]
       jmp       short M01_L00
; Total bytes of code 50
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+130]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2078400DC10
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6546F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6546D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F67969D0]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,28B3280DC18
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6517648]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F65173D8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F6777570]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+148]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1EF2100DCA0
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6556F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6556D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F67A7888]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+150]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1B49F80DC20
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6526F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6526D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F6777390]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+178]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2661F40DC30
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6537648]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F65373D8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F6797570]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+118]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,22E74171F10
       xor       r8d,r8d
       call      qword ptr [7FF9F5E87180]; System.Guid.ToString(System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L01
       mov       rcx,1EDE200DC38
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FF9F6546F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F606CF48]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FF9F5E87348]
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
       call      qword ptr [7FF9F5E87348]
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
       call      qword ptr [7FF9F6546D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FF9F679CF48]
       int       3
M02_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+160]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,23482C0DC50
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6556F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6556D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F67A6DA8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1834240DC58
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],11
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1C3D05049E8
       call      qword ptr [7FF9F6536D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       esi,11
       jmp       short M00_L00
; Total bytes of code 100
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
       jb        near ptr M01_L13
       cmp       r12d,r15d
       jb        near ptr M01_L14
       cmp       [rcx],cl
       lea       rdx,[rcx+38]
       xor       eax,eax
       xchg      rax,[rdx]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L15
M01_L00:
       mov       [rbp-50],rdx
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6707570]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M01_L07
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
       call      qword ptr [7FF9F6707558]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      edi,edi
       je        near ptr M01_L05
M01_L01:
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
       jbe       short M01_L03
       cmp       dword ptr [rdx+10],0
       jle       near ptr M01_L10
       test      esi,esi
       je        near ptr M01_L09
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
       call      qword ptr [7FF9F6707BD0]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9F6527628
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M01_L11
M01_L05:
       mov       ecx,r15d
       mov       eax,1
       mov       r8,[rbp+10]
       test      byte ptr [r8+40],40
       je        short M01_L06
       xor       ecx,ecx
       mov       eax,0FFFFFFFF
M01_L06:
       mov       rdx,[rbp-50]
       cmp       [rdx+48],ecx
       jne       short M01_L08
       mov       rcx,7FF9F6527628
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1834240FF30
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF9F602ED30]
       int       3
M01_L08:
       mov       rdx,[rbp-50]
       add       [rdx+4C],eax
       jmp       near ptr M01_L01
M01_L09:
       xor       edx,edx
       mov       [r12+8],rdx
       xor       r12d,r12d
       jmp       near ptr M01_L02
M01_L10:
       xor       edx,edx
       mov       [r12+8],rdx
       test      byte ptr [7FF9F6527679],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,1834240FF30
       mov       r12,[rdx]
       jmp       near ptr M01_L02
M01_L12:
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
M01_L13:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F67869A0]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF9F67869A0]
       int       3
M01_L15:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
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
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
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
; Total bytes of code 696
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+170]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1E26D80BC68
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6556F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6556D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F67A6E20]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1CF2400DC80
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0A
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,20FB5DE4998
       call      qword ptr [7FF9F6536D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L01:
       mov       esi,0A
       jmp       short M00_L00
; Total bytes of code 100
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
       jb        near ptr M01_L11
       cmp       r12d,r15d
       jb        near ptr M01_L12
       cmp       [rcx],cl
       lea       rdx,[rcx+38]
       xor       eax,eax
       xchg      rax,[rdx]
       mov       rdx,rax
       test      rdx,rdx
       je        near ptr M01_L13
M01_L00:
       mov       [rbp-50],rdx
       mov       rdx,[rcx+48]
       mov       rcx,[rbp-50]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6707AE0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       mov       edx,r15d
       add       rcx,rdx
       mov       edx,r12d
       cmp       rcx,rdx
       ja        near ptr M01_L06
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
       call      qword ptr [7FF9F6707AC8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
       test      edi,edi
       je        short M01_L04
M01_L01:
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
       jbe       short M01_L03
       cmp       dword ptr [rdx+10],0
       jle       near ptr M01_L09
       test      esi,esi
       je        short M01_L08
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
       call      qword ptr [7FF9F670C180]
M01_L02:
       jmp       short M01_L10
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,r15d
       mov       edx,1
       mov       rax,[rbp+10]
       test      byte ptr [rax+40],40
       je        short M01_L05
       xor       ecx,ecx
       mov       edx,0FFFFFFFF
M01_L05:
       mov       rdi,[rbp-50]
       cmp       [rdi+48],ecx
       jne       short M01_L07
       mov       rdx,1CF2400FF30
       mov       r12,[rdx]
       jmp       short M01_L10
M01_L06:
       mov       ecx,21
       call      qword ptr [7FF9F602ED30]
       int       3
M01_L07:
       add       [rdi+4C],edx
       jmp       near ptr M01_L01
M01_L08:
       xor       edx,edx
       mov       [r12+8],rdx
       xor       r12d,r12d
       jmp       short M01_L02
M01_L09:
       xor       edx,edx
       mov       [r12+8],rdx
       mov       rdx,1CF2400FF30
       mov       r12,[rdx]
       jmp       short M01_L02
M01_L10:
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
M01_L11:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF9F6787108]
       int       3
M01_L12:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF9F6787108]
       int       3
M01_L13:
       mov       rax,[rcx+10]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdx,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L00
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
       mov       rax,[rbp+10]
       lea       rcx,[rax+38]
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
; Total bytes of code 616
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2660C40DC98
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6537648]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F65373D8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F679CC30]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+158]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,154E140DC88
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6546F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6546D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F67970D8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+148]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1CC5A00DCA8
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6526F70]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF9F6526D00]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF9F6776970]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FF9F616D020]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F67663D0]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FF9F67663D0]
       test      eax,eax
       jne       near ptr M01_L10
M01_L05:
       cmp       [rbx],bl
       mov       rdx,2148EAD7578
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
       call      qword ptr [7FF9F651EAD8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FF9F621D368]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FF9F621D0B0]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2148EAD7DC0
       mov       r8,rdi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF9F5DA73F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9F5DA7258]
       int       3
M01_L12:
       mov       rbx,2148EAD0008
       jmp       near ptr M01_L07
M01_L13:
       jmp       near ptr M01_L07
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Split()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,2
       mov       r8d,2C
       call      qword ptr [7FF9F619D038]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
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
       call      qword ptr [7FF9F5DD7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,1FBC2EE49E8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5D1A770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FF9F5DD70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       call      qword ptr [7FF9F624D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FF9F624D0B0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1FBC2ED7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FF9F624D170]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FF9F624D0C8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1FBC2ED82D0
       mov       r8,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,14
       call      qword ptr [7FF9F603ED00]
       int       3
; Total bytes of code 395
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SplitRemoveEmpty()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FF9F619D098]; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
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
       call      qword ptr [7FF9F5DD7318]; System.String.Trim()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DD7318]; System.String.Trim()
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
       call      qword ptr [7FF9F5DD70C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,24E1FC01D90
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,rsi
       call      qword ptr [7FF9F5E8E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FF9F624D368]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FF9F624D0B0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28EAD8A7DC0
       mov       r8,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FF9F624D2C0]
       mov       ecx,43
       mov       rdx,7FF9F61D2BF0
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
       mov       rdx,7FF9F61D2BF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F624D0B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 463
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SubstringTrim()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1445
       cmp       [rbx],rcx
       jne       near ptr M00_L06
       mov       rsi,[rbx+60]
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L03
       mov       rcx,offset MT_System.String
       cmp       [rsi],rcx
       jne       near ptr M00_L07
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+10],0FFFFFFFF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF9F65195A8]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       ecx,[rsi+8]
       cmp       ecx,32
       jl        short M00_L04
       cmp       ecx,32
       jb        near ptr M00_L05
       add       rsi,3E
       mov       [rsp+30],rsi
       mov       dword ptr [rsp+38],19
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F5E7C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
       mov       rdi,rax
M00_L02:
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rdi,1F78AE20008
       jmp       short M00_L02
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A66
       mov       rdx,7FF9F61C2BF0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F623D0C8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,21
       call      qword ptr [7FF9F602ED30]
       int       3
M00_L06:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rsi
       mov       r11,7FF9F5C80B28
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FF9F5C80B30
       call      qword ptr [r11]
       jmp       near ptr M00_L01
; Total bytes of code 376
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
; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[rcx]
       mov       ecx,[rcx+8]
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       nop
       add       rsp,38
       ret
; Total bytes of code 42
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF9F67863B8]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF9F67863B8]
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
       call      qword ptr [7FF9F5DC73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FF9F617CA98]; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
       mov       rcx,2307200E8D0
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
       call      qword ptr [7FF9F65064E0]; System.Text.ASCIIEncoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       lea       rcx,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FF9F6134E40]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
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
       mov       rax,271040A0008
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
       call      qword ptr [7FF9F601C4C8]
       mov       r15d,eax
       mov       esi,r15d
       cmp       r15d,r14d
       je        near ptr M01_L02
M01_L05:
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FF9F5DBC8A0]
       add       esi,eax
       jns       near ptr M01_L02
       call      qword ptr [7FF9F5DBC7E0]
       int       3
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 413
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,[rbx+38]
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
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
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
       call      qword ptr [7FF9F6144720]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L07
       xor       esi,esi
       xor       r14d,r14d
M00_L02:
       test      r14d,r14d
       jne       near ptr M00_L09
       mov       r15,206FA717178
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
       call      qword ptr [7FF9F623D368]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FF9F623D0B0]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,206FA717DC0
       mov       r8,rdi
       call      qword ptr [7FF9F6056670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M00_L07:
       mov       r14d,[rsp+50]
       cmp       r14d,ebp
       jbe       short M00_L08
       call      qword ptr [7FF9F602E9D0]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F6786418]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F6786418]
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
       call      qword ptr [7FF9F5DC73F0]
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
       mov       rax,37684B501E27
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
       call      qword ptr [7FF9F60EE628]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
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
       call      qword ptr [7FF9F60EE628]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
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
       mov       rcx,37684B501E27
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
       mov       rcx,37684B501E27
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
       call      qword ptr [7FF9F602E9D0]
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
       jmp       qword ptr [7FF9F5E75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rax,2D6303B49E8
       mov       [rcx+8],rax
       call      qword ptr [7FF9F65195A8]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L03
       call      qword ptr [7FF9F5FD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L02
       mov       rcx,rax
       call      qword ptr [7FF9F5FACFF8]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,2D6303B49E8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5FDC378]; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       jmp       short M00_L00
M00_L03:
       mov       rax,2D6303B49E8
       jmp       short M00_L01
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
       mov       rax,2959E400438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,2959E400418
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
       jmp       qword ptr [7FF9F5FD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9F5FDC018]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
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
       je        near ptr M04_L27
       mov       rcx,[rsp+98]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L31
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
       jle       near ptr M04_L22
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
       jbe       near ptr M04_L32
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
       mov       r12,7FFA52A51CB0
       movzx     r8d,byte ptr [r8+r12]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r14,7FFA52A4ACC8
       movzx     r8d,word ptr [r8+r14]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFA52A4E7F0
       movzx     r8d,byte ptr [r8+r13]
       mov       r15,7FFA52A43150
       movzx     eax,byte ptr [r8+r15]
       and       eax,1F
       mov       [rsp+3C],eax
       cmp       eax,4
       ja        near ptr M04_L26
       test      edi,edi
       jne       near ptr M04_L33
M04_L06:
       mov       r8d,[rsp+38]
       mov       [rsp+20],r8d
       lea       r8,[rsp+98]
       lea       rdx,[rsp+40]
       mov       rcx,rbx
       mov       r9d,ebp
       call      qword ptr [7FF9F5FDC3A8]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       jbe       near ptr M04_L36
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
       jne       near ptr M04_L41
       mov       r8d,1
       jmp       near ptr M04_L41
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
       je        near ptr M04_L37
       mov       ecx,1
       shlx      ecx,ecx,r10d
       test      ecx,1FFCF800
       je        near ptr M04_L41
M04_L14:
       mov       [rsp+34],eax
       mov       r14d,ebp
       sub       r14d,eax
       test      r14d,r14d
       jle       near ptr M04_L18
       test      r8d,r8d
       je        near ptr M04_L44
       test      rsi,rsi
       jne       short M04_L15
       mov       rdx,[rsp+98]
       test      rdx,rdx
       je        near ptr M04_L27
       mov       rcx,rbx
       call      qword ptr [7FF9F67072D0]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
       mov       rsi,rax
M04_L15:
       mov       r15,[rsp+40]
       cmp       [r15],r15b
       mov       eax,[rsp+34]
       test      eax,eax
       jl        near ptr M04_L28
       test      rsi,rsi
       je        near ptr M04_L43
       mov       r8d,[rsi+8]
       sub       r8d,r14d
       cmp       r8d,eax
       jl        near ptr M04_L30
       movsxd    r8,eax
       lea       rdx,[rsi+r8*2+0C]
       mov       r8,[r15+8]
       mov       r13d,[r15+18]
       lea       ecx,[r14+r13]
       cmp       ecx,[r8+8]
       ja        near ptr M04_L20
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L17:
       add       r14d,r13d
       mov       [r15+18],r14d
M04_L18:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jle       near ptr M04_L21
       mov       ecx,[rsp+38]
       cmp       ecx,2
       jne       near ptr M04_L24
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
       jbe       near ptr M04_L45
       cmp       eax,[r8+8]
       jae       near ptr M04_L47
       mov       [r8+rax*2+10],dx
       inc       r12d
       mov       [rcx+18],r12d
M04_L19:
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
       jbe       short M04_L23
       cmp       r8d,[r10+8]
       jae       near ptr M04_L47
       mov       [r10+r8*2+10],dx
       inc       eax
       mov       [rcx+18],eax
       jmp       near ptr M04_L25
M04_L20:
       mov       rcx,r15
       mov       r8d,r14d
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M04_L18
M04_L21:
       inc       ebp
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L02
M04_L22:
       mov       rcx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
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
M04_L23:
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M04_L25
M04_L24:
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
       jbe       near ptr M04_L46
       cmp       eax,[r8+8]
       jae       near ptr M04_L47
       mov       [r8+rax*2+10],dx
       lea       eax,[r12+1]
       mov       [rcx+18],eax
       mov       r15d,ebp
M04_L25:
       mov       ebp,r15d
       jmp       near ptr M04_L21
M04_L26:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FF9F5FDC390]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L21
M04_L27:
       mov       ecx,16EB
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M04_L28:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FF9F670D5F0]
       int       3
M04_L29:
       mov       ecx,2E5
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M04_L30:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF9F628EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FF9F5E7D470]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M04_L31:
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
M04_L32:
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
M04_L33:
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
       je        short M04_L34
       mov       rcx,[rsp+98]
       cmp       ebp,[rcx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       mov       edx,ebp
       cmp       word ptr [rcx+rdx*2+0C],49
       jne       near ptr M04_L06
M04_L34:
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],6A
       je        short M04_L35
       lea       ecx,[rbp+1]
       mov       rdx,[rsp+98]
       cmp       ecx,[rdx+8]
       jae       near ptr M04_L47
       mov       rcx,[rsp+98]
       lea       edx,[rbp+1]
       cmp       word ptr [rcx+rdx*2+0C],4A
       jne       near ptr M04_L06
M04_L35:
       mov       rcx,[rsp+40]
       mov       rdx,2D6303B4A10
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC2A0]; System.Text.StringBuilder.Append(System.String)
       add       ebp,2
       jmp       near ptr M04_L07
M04_L36:
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
M04_L37:
       inc       ebp
       test      r8d,r8d
       je        short M04_L39
       test      rsi,rsi
       jne       short M04_L38
       mov       [rsp+34],eax
       mov       rcx,rbx
       mov       rdx,[rsp+98]
       call      qword ptr [7FF9F5FDC1C8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L38:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L40
M04_L39:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
M04_L40:
       mov       eax,ebp
       mov       r8d,1
       jmp       short M04_L42
M04_L41:
       add       ebp,[rsp+38]
M04_L42:
       mov       rcx,[rsp+98]
       cmp       [rcx+8],ebp
       jg        near ptr M04_L08
       jmp       near ptr M04_L14
M04_L43:
       test      eax,eax
       jne       near ptr M04_L29
       jmp       near ptr M04_L29
M04_L44:
       mov       eax,[rsp+34]
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       mov       r9d,r14d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F60CC2B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L18
M04_L45:
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L19
M04_L46:
       call      qword ptr [7FF9F60CC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r15d,ebp
       jmp       near ptr M04_L25
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2046
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1454
       cmp       [rbx],rcx
       jne       near ptr M00_L04
       mov       rsi,[rbx+60]
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
       call      qword ptr [7FF9F65095A8]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
M00_L02:
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
M00_L03:
       mov       rax,rsi
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
       mov       r11,7FF9F5C70B28
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FF9F5C70B30
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
       mov       ecx,ecx
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L01
       jmp       near ptr M02_L16
M02_L00:
       call      qword ptr [7FF9F67763B8]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M02_L05
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FF9F67763B8]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L08
M02_L07:
       call      qword ptr [7FF9F67763B8]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L11
M02_L10:
       call      qword ptr [7FF9F67763B8]
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M02_L13
M02_L15:
       mov       rax,33CF6820008
       jmp       short M02_L13
M02_L16:
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FF9F5D45CE0]; System.Char.IsWhiteSpace(Char)
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
; Total bytes of code 368
```

