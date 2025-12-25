## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValueFromNull()
       push      rbx
       sub       rsp,10
       xor       eax,eax
       mov       [rsp+8],rax
       mov       rdx,221A42B0008
       mov       rax,221A42C4B50
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,24EF1BB0008
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rsi,1563BA94B50
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmptyWithDefaultValue()
       push      rbx
       sub       rsp,10
       mov       rdx,2355EEB4B50
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithLength()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,64
       call      qword ptr [7FFE00B3C750]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32)
; 		length = length.ArgumentInRange(lower: 1, upper: length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input is not null && (input.ArgumentNotNull().Trim().Length == length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       ecx,ecx
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE010FE2E0]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       ecx,ecx
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE010FE2E0]
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
       call      qword ptr [7FFE008247B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L08:
       call      qword ptr [7FFE00B3D998]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE00B3D7B8]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24B5B9F7598
       mov       r8,rbx
       call      qword ptr [7FFE0082D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFE007773F0]
       mov       rsi,rax
       jmp       near ptr M01_L05
; Total bytes of code 315
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithMinMaxCount()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       edx,5
       mov       r8d,64
       call      qword ptr [7FFE00B4C798]; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String, Int32, Int32)
; 		minLength = minLength.ArgumentInRange(lower: 0, upper: maxLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		maxLength = maxLength.ArgumentInRange(lower: minLength, upper: int.MaxValue);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input is not null && input.Length.IsInRange(minLength, maxLength);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       movzx     eax,byte ptr [rsp+28]
       test      al,al
       je        short M01_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008347B0]
       mov       ebx,eax
       jmp       short M01_L01
M01_L07:
       call      qword ptr [7FFE00B4D998]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L08
       call      qword ptr [7FFE00B4D7B8]
       mov       rdi,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1C1CC9CBBE8
       mov       r8,rdi
       call      qword ptr [7FFE0083D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008347B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE00B4D998]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE00B4D7B8]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C1CC9CBC10
       mov       r8,rbx
       call      qword ptr [7FFE0083D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       xor       eax,eax
       jmp       near ptr M01_L04
; Total bytes of code 324
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValueWithRegEx()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rcx,228FB084B50
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rsi,228FB084B88
       mov       rcx,rsi
       cmp       dword ptr [rcx+8],0
       jle       near ptr M00_L03
       mov       rcx,offset MT_System.Text.RegularExpressions.Regex
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,228FB070008
       mov       r8,228FB0782D0
       call      qword ptr [7FFE010A64D8]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[System.Text.RegularExpressions.RegexOptions, System.Text.RegularExpressions]](System.Text.RegularExpressions.RegexOptions, System.String, System.String)
       mov       r8d,eax
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE00EC4C18]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rdi
       call      qword ptr [7FFE00EC4E10]; System.Text.RegularExpressions.Regex.get_RightToLeft()
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
       mov       r9,228FB084B50
       call      qword ptr [7FFE00EC4ED0]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       xor       ebp,ebp
       test      rax,rax
       sete      bpl
M00_L01:
       mov       [rsp+40],bpl
       mov       rcx,[rbx+18]
       lea       rdx,[rsp+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE010D6148]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
; 		var isValid = Enum.IsDefined(input.ArgumentNotNull().GetType(), input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (isValid is false)
; 		^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowArgumentOutOfRangeException(CreateExceptionMessage(errorMessage, Resources.ErrorEnumNotDefined), paramName);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input;
; 		^^^^^^^^^^^^^
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
       mov       rcx,228FB084BF8
       cmp       [rcx],ecx
       call      qword ptr [7FFE006AA770]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        short M01_L00
       mov       eax,ebx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L00:
       call      qword ptr [7FFE00B2D860]
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
       call      qword ptr [7FFE00B2D7B8]
       mov       rsi,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFE0081D470]
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
       call      qword ptr [7FFE00EC4C60]; System.Text.RegularExpressions.Regex..ctor(System.String, System.Text.RegularExpressions.RegexOptions, System.TimeSpan, System.Globalization.CultureInfo)
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
       call      qword ptr [7FFE010D5788]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE010D5770]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFE010D6088]
M04_L02:
       jmp       near ptr M04_L12
M04_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L04:
       mov       rcx,7FFE00ED3158
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
       mov       rcx,7FFE00ED3158
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E869012550
       mov       r12,[rcx]
       jmp       short M04_L12
M04_L07:
       mov       ecx,21
       call      qword ptr [7FFE00AD5B48]
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
       test      byte ptr [7FFE00ED31A9],1
       je        near ptr M04_L04
M04_L11:
       mov       rdx,1E869012550
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
       call      qword ptr [7FFE0116C7C8]
       int       3
M04_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE0116C7C8]
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00787318]; System.String.Trim()
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE0110E2E0]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE0110E2E0]
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
       call      qword ptr [7FFE007873F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00B5C9F0]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Int32, Char)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		options = options.ArgumentDefined();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		count = count.ArgumentInRange(lower: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return Array.AsReadOnly(input.Split([delimiter], count, options));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00797318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       rdx,rax
       mov       rcx,23E7BD24B50
       cmp       [rcx],ecx
       call      qword ptr [7FFE006DA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FFE007970C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L12
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L13
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
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
       call      qword ptr [7FFE00B5DA58]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L06
       call      qword ptr [7FFE00B5D7A0]
       mov       rdi,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,23E7BD17DC0
       mov       r8,rdi
       call      qword ptr [7FFE00996718]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE00B5D860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FFE00B5D7B8]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23E7BD182D0
       mov       r8,rbx
       call      qword ptr [7FFE0084D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       movzx     ecx,byte ptr [rsp+30]
       test      cl,cl
       je        near ptr M01_L02
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE008447B0]
       mov       esi,eax
       jmp       near ptr M01_L03
M01_L10:
       call      qword ptr [7FFE00B5D998]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE00B5D7B8]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23E7BD13760
       mov       r8,rbx
       call      qword ptr [7FFE0084D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L12:
       mov       ecx,2
       call      qword ptr [7FFE00B05B18]
       int       3
M01_L13:
       mov       rcx,7FFE006D5120
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,1FDEDC01F80
       mov       rax,[rax]
       jmp       near ptr M01_L04
; Total bytes of code 589
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_ASCII()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,27A40000970
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B5CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00797318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00820180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE00B5DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE00B5D7A0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2BAD1FA7DC0
       mov       r8,rbx
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE00B5D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B5D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_BigEndianUnicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,23A35C009C8
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B3CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00800180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE00B3DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE00B3D7A0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27AC7A27DC0
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE00B3D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B3D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Default()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,131F7C009A0
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B2CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00767318]; System.String.Trim()
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
       jmp       qword ptr [7FFE007F0180]; System.Text.Encoding.GetBytes(System.String)
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
       call      qword ptr [7FFE00B2DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE00B2D7A0]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,17285947DC0
       mov       r8,rbx
       call      qword ptr [7FFE00966718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE00B2D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B43810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00AF7000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00766B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B43810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00766B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B2D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00966718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE0096FD38]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Latin1()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,12E90C009C0
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B5CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00797318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00820180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE00B5DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE00B5D7A0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,16F1EA07DC0
       mov       r8,rbx
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE00B5D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B5D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_Unicode()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,1F9DA4009D0
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B5CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00797318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00820180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE00B5DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE00B5D7A0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23A683A7DC0
       mov       r8,rbx
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE00B5D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B73810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B5D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF32()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,225000009D8
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B3CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00800180]; System.Text.Encoding.GetBytes(System.String)
M01_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+10]
M01_L03:
       call      qword ptr [7FFE00B3DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L04
       call      qword ptr [7FFE00B3D7A0]
       mov       rbx,rax
M01_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2658E0E7DC0
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE00B3D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B3D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 334
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArray_UTF8()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,245480009F0
       mov       rdx,[rdx]
       call      qword ptr [7FFE00B3CAE0]; DotNetTips.Spargine.Extensions.StringExtensions.ToByteArray(System.String, System.Text.Encoding)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		encoding = encoding.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return encoding.GetBytes(input);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
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
       jmp       qword ptr [7FFE00800180]; System.Text.Encoding.GetBytes(System.String)
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
       call      qword ptr [7FFE00B3DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L06
       call      qword ptr [7FFE00B3D7A0]
       mov       rbx,rax
M01_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,285D9E57DC0
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      qword ptr [7FFE00B3D9B0]
       mov       ecx,0B02
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B53810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B3D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,rax
       mov       rdx,[rsp+40]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE0097FD38]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
; Total bytes of code 396
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00B646D8]; DotNetTips.Spargine.Benchmarking.Benchmark.GetStringArray(Int32 ByRef, Int32, Int32)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE00B6C588]; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
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
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbp,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       esi,r9d
       mov       ecx,1
       test      ebx,ebx
       cmovg     ecx,ebx
       mov       ebx,ecx
       mov       ecx,ebx
       add       ecx,1
       jo        near ptr M01_L39
       cmp       esi,ecx
       cmovge    ecx,esi
       mov       esi,ecx
       lea       rcx,[rsp+30]
       mov       edx,2
       mov       r8d,3
       call      qword ptr [7FFE00A65CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       edx,[rdi]
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE00A67E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M01_L41
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L40
       mov       rcx,1C9FA490754
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M01_L00:
       lea       rcx,[rsp+30]
       mov       edx,ebx
       call      qword ptr [7FFE00A67E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       mov       ecx,[rsp+40]
       mov       edx,[rsp+50]
       cmp       ecx,edx
       ja        near ptr M01_L41
       mov       rax,[rsp+48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,1
       jb        near ptr M01_L42
       mov       rcx,1C9FA490754
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M01_L01:
       lea       rcx,[rsp+30]
       mov       edx,esi
       call      qword ptr [7FFE00A67E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE00A65D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r14,rax
       mov       rcx,[rbp+10]
       cmp       [rcx],cl
       mov       rdx,r14
       call      qword ptr [7FFE007AEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L03
       mov       rax,[rax]
       mov       [rsp+58],rax
M01_L02:
       mov       rax,[rsp+58]
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       xor       eax,eax
       mov       [rsp+58],rax
       mov       r15d,[rdi]
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],2
       xor       eax,eax
       test      r15d,r15d
       setg      al
       mov       r13d,eax
       test      eax,eax
       jne       short M01_L04
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        short M01_L04
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008547B0]
       mov       r15d,eax
       jmp       short M01_L06
M01_L04:
       test      r13d,r13d
       jne       short M01_L06
       call      qword ptr [7FFE00B6D998]
       mov       r15,rax
       test      r15,r15
       jne       short M01_L05
       call      qword ptr [7FFE00B6D7B8]
       mov       r15,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1C9FA493760
       mov       r8,r15
       call      qword ptr [7FFE0085D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L06:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      ebx,ebx
       setg      cl
       mov       edi,ecx
       test      ecx,ecx
       jne       short M01_L07
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        short M01_L07
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008547B0]
       mov       ebx,eax
       jmp       short M01_L09
M01_L07:
       test      edi,edi
       jne       short M01_L09
       call      qword ptr [7FFE00B6D998]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L08
       call      qword ptr [7FFE00B6D7B8]
       mov       rbx,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C9FA49BBE8
       mov       r8,rbx
       call      qword ptr [7FFE0085D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       xor       ecx,ecx
       test      esi,esi
       setg      cl
       mov       edi,ecx
       test      ecx,ecx
       jne       short M01_L10
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        short M01_L10
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008547B0]
       mov       esi,eax
       jmp       short M01_L12
M01_L10:
       test      edi,edi
       jne       short M01_L12
       call      qword ptr [7FFE00B6D998]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L11
       call      qword ptr [7FFE00B6D7B8]
       mov       rsi,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,1C9FA49BC10
       mov       r8,rsi
       call      qword ptr [7FFE0085D470]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L12:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,r15d
       call      qword ptr [7FFE0085DFB0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       jmp       near ptr M01_L38
M01_L13:
       mov       ecx,ebx
       test      ecx,ecx
       jle       short M01_L14
       mov       eax,1
       jmp       short M01_L15
M01_L14:
       xor       eax,eax
M01_L15:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L16
       mov       ecx,1
       jmp       short M01_L18
M01_L16:
       test      edx,edx
       jne       short M01_L18
       call      qword ptr [7FFE00B6D998]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L17
       call      qword ptr [7FFE00B6D7B8]
       mov       rsi,rax
M01_L17:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1C9FA49BBE8
       mov       r8,rsi
       call      qword ptr [7FFE0085D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L18:
       mov       edx,esi
       test      esi,esi
       jle       short M01_L19
       mov       eax,1
       jmp       short M01_L20
M01_L19:
       xor       eax,eax
M01_L20:
       mov       r8d,eax
       test      eax,eax
       jne       short M01_L21
       mov       edx,1
       jmp       short M01_L23
M01_L21:
       test      r8d,r8d
       jne       short M01_L23
       call      qword ptr [7FFE00B6D998]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L22
       call      qword ptr [7FFE00B6D7B8]
       mov       rdi,rax
M01_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,1C9FA49BC10
       mov       r8,rdi
       call      qword ptr [7FFE0085D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L23:
       test      ecx,ecx
       jle       short M01_L24
       mov       eax,1
       jmp       short M01_L25
M01_L24:
       xor       eax,eax
M01_L25:
       mov       r8d,eax
       test      eax,eax
       jne       short M01_L26
       mov       ecx,1
       jmp       short M01_L28
M01_L26:
       test      r8d,r8d
       jne       short M01_L28
       call      qword ptr [7FFE00B6D998]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L27
       call      qword ptr [7FFE00B6D7B8]
       mov       rdi,rax
M01_L27:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,1C9FA49BBE8
       mov       r8,rdi
       call      qword ptr [7FFE0085D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L28:
       test      edx,edx
       jle       short M01_L29
       mov       eax,1
       jmp       short M01_L30
M01_L29:
       xor       eax,eax
M01_L30:
       mov       r8d,eax
       test      eax,eax
       jne       short M01_L31
       mov       edx,1
       jmp       short M01_L33
M01_L31:
       test      r8d,r8d
       jne       short M01_L33
       call      qword ptr [7FFE00B6D998]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L32
       call      qword ptr [7FFE00B6D7B8]
       mov       rdi,rax
M01_L32:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,1C9FA49BC10
       mov       r8,rdi
       call      qword ptr [7FFE0085D470]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L33:
       mov       eax,ecx
       add       eax,1
       jo        near ptr M01_L39
       cmp       edx,eax
       jl        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       edx,eax
M01_L35:
       call      qword ptr [7FFE00B6D2D8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE00B67888]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L36
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       cmp       edx,[rcx+8]
       jae       near ptr M01_L43
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L37
M01_L36:
       mov       rcx,rdi
       mov       rdx,rax
       call      qword ptr [7FFE0085E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L37:
       add       r13d,1
       jo        short M01_L39
M01_L38:
       cmp       r13d,r15d
       jl        near ptr M01_L13
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE00B67C30]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,7FFE010F0118
       call      qword ptr [7FFE00F4C6C0]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rsp+58],rax
       mov       rdx,[rbp+10]
       lea       r9,[rsp+58]
       mov       r8,r14
       mov       rcx,7FFE010F0848
       call      qword ptr [7FFE010E75A0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon ByRef)
       jmp       near ptr M01_L02
M01_L39:
       call      CORINFO_HELP_OVERFLOW
M01_L40:
       lea       rcx,[rsp+30]
       mov       rdx,1C9FA490748
       call      qword ptr [7FFE00A65F38]
       jmp       near ptr M01_L00
M01_L41:
       call      qword ptr [7FFE00B157E8]
       int       3
M01_L42:
       lea       rcx,[rsp+30]
       mov       rdx,1C9FA490748
       call      qword ptr [7FFE00A65F38]
       jmp       near ptr M01_L01
M01_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1454
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.CombineToString(System.String, System.String[])
; 	public static string CombineToString([NotNull] this string input, [NotNull] params string[] args) => FastStringBuilder.Combine(false, args: args.ArgumentNotNull().AddFirst(input.ArgumentNotNull()));
; 	                                                                                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE006F7750]; System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rdx,rbp
       lea       rcx,[rsp+30]
       call      qword ptr [7FFE00EDD578]; DotNetTips.Spargine.Core.FastStringBuilder.Combine(Boolean ByRef, System.String[])
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
       call      qword ptr [7FFE00B6D9B0]
       mov       ecx,0A3A
       mov       rdx,7FFE00B83810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B37000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B83810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B6D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       call      qword ptr [7FFE00B6D9B0]
       mov       ecx,2F3
       mov       rdx,7FFE00B83810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B37000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B83810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B6D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L03:
       mov       ecx,28
       mov       edx,35
       call      qword ptr [7FFE00B15B60]
       int       3
M02_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 473
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ComputeSHA256Hash()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FFE00B6C5B8]; DotNetTips.Spargine.Extensions.StringExtensions.ComputeSHA256Hash(System.String)
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
; 		if (input.IsNullOrEmpty())
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return ControlChars.EmptyString;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(input));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return FastStringBuilder.BytesToString(ref bytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       vmovdqa   xmmword ptr [rsp+70],xmm4
       xor       eax,eax
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
       mov       r8,2456F0009F0
       mov       rdi,[r8]
       mov       ebp,[rbx+8]
       cmp       ebp,20
       jle       near ptr M01_L04
       lea       r8,[rbx+0C]
       mov       [rsp+78],r8
       mov       rsi,[rsp+78]
       mov       r14d,ebp
       lea       r8,[rsp+70]
       lea       r9,[rsp+68]
       mov       rcx,rsi
       mov       edx,r14d
       call      qword ptr [7FFE009CCFF0]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,rsi
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r15,r9d
       add       r15,[rsp+70]
       cmp       r15,7FFFFFFF
       ja        near ptr M01_L06
       cmp       r9d,r14d
       jne       near ptr M01_L05
M01_L00:
       xor       edx,edx
       mov       [rsp+78],rdx
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
       call      qword ptr [7FFE009B27F8]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
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
       mov       [rsp+50],rdi
       mov       [rsp+58],ebx
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+48],ecx
       mov       [rsp+30],rdx
       mov       [rsp+38],r8d
       lea       rdx,[rsp+60]
       mov       [rsp+28],rdx
       lea       rdx,[rsp+30]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+50]
       lea       r8,[rsp+40]
       mov       rcx,285FD0EBD08
       xor       r9d,r9d
       call      qword ptr [7FFE00EDDD40]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       [rsp+80],rsi
       lea       rcx,[rsp+80]
       call      qword ptr [7FFE00EDD548]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[] ByRef)
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
       mov       rax,285FD0E0008
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
       call      qword ptr [7FFE009AFD38]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,r14d
       call      qword ptr [7FFE007AC8A0]
       add       r15d,eax
       jns       near ptr M01_L00
M01_L06:
       call      qword ptr [7FFE007AC7E0]
       int       3
M01_L07:
       mov       ecx,6A61
       mov       rdx,7FFE00B86700
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE009A6790]
       int       3
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE011764F0]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFE00B86700
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE007AF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 663
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNull()
       push      rbx
       sub       rsp,10
       mov       rdx,21A16034B50
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.DefaultIfNullOrEmpty()
       push      rbx
       sub       rsp,10
       mov       rdx,2B74B6F4B50
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE007870C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
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
       mov       rcx,7FFE006C5120
       mov       edx,61
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,13317C01F80
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
       mov       rax,0DB7859557EDB
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
       call      qword ptr [7FFE007871B0]; System.String.MakeSeparatorListAny(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Collections.Generic.ValueListBuilder`1<Int32> ByRef)
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
       call      qword ptr [7FFE00787198]; System.String.SplitWithPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32, System.StringSplitOptions)
       mov       rbx,rax
M01_L02:
       mov       rdx,[rbp+48]
       test      rdx,rdx
       je        short M01_L03
       xor       ecx,ecx
       mov       [rbp+48],rcx
       mov       rcx,13317C01ED0
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00E9D038]; Precode of System.Buffers.SharedArrayPool`1[[System.Int32, System.Private.CoreLib]].Return(Int32[], Boolean)
M01_L03:
       mov       rax,rbx
       mov       rcx,0DB7859557EDB
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
       call      qword ptr [7FFE00787180]; System.String.SplitWithoutPostProcessing(System.ReadOnlySpan`1<Int32>, System.ReadOnlySpan`1<Int32>, Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L02
M01_L06:
       mov       ecx,1C7
       mov       rdx,7FFE00634000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,edi
       call      qword ptr [7FFE010CDBF0]
       int       3
M01_L07:
       mov       ecx,45
       mov       edx,59
       call      qword ptr [7FFE00AF5AD0]
       int       3
M01_L08:
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,edi
       call      qword ptr [7FFE00787150]; System.String.CreateSplitArrayOfThisAsSoleValue(System.StringSplitOptions, Int32)
       mov       rcx,0DB7859557EDB
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
       call      qword ptr [7FFE00AF57E8]
       int       3
M01_L12:
       mov       edi,1
       jmp       near ptr M01_L00
; Total bytes of code 561
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsIgnoreCase()
       vzeroupper
       vxorps    xmm0,xmm0,xmm0
       vpcmpeqq  xmm0,xmm0,[7FFE00FCB380]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       sete      al
       movzx     eax,al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 39
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.EqualsOrBothNullOrEmpty()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,21E895E4B50
       mov       rdx,21E895E4B88
       mov       r8d,4
       call      qword ptr [7FFE007761D8]; System.String.Equals(System.String, System.String, System.StringComparison)
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
       call      qword ptr [7FFE00825068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00AE5AD0]
       int       3
M01_L05:
       cmp       edi,5
       ja        near ptr M01_L08
       mov       eax,edi
       lea       rcx,[7FFE00FAB098]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M01_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE0094E1C0]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE00F144F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M01_L01
       mov       rcx,7FFE006B5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DDF78003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE00F144F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
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
       jmp       qword ptr [7FFE00775F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M01_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE00C55338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE00624000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE0077F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 391
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Extract()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       rdx,21EF2EE4B50
       mov       r8,21EF2EE4B70
       call      qword ptr [7FFE00B2C690]; DotNetTips.Spargine.Extensions.StringExtensions.Extract(System.String, System.String, System.String)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		start = start.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		end = end.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var startIndex = input.IndexOf(start, StringComparison.Ordinal);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var endIndex = input.IndexOf(end, StringComparison.Ordinal);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input[startIndex..endIndex];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       je        near ptr M01_L06
       cmp       [rcx],ecx
       call      qword ptr [7FFE00767318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,rsi
       test      rcx,rcx
       je        short M01_L02
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L03
       jmp       short M01_L03
M01_L02:
       xor       eax,eax
M01_L03:
       test      eax,eax
       je        near ptr M01_L08
       cmp       [rcx],ecx
       call      qword ptr [7FFE00767318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L04
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L05
       jmp       short M01_L05
M01_L04:
       xor       eax,eax
M01_L05:
       test      eax,eax
       je        near ptr M01_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE00767318]; System.String.Trim()
       mov       rdi,rax
       mov       dword ptr [rsp+20],4
       mov       ebp,[rbx+8]
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE007675D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       esi,eax
       mov       dword ptr [rsp+20],4
       mov       r9d,ebp
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE007675D0]; System.String.IndexOf(System.String, Int32, Int32, System.StringComparison)
       mov       r8d,eax
       sub       r8d,esi
       mov       rcx,rbx
       mov       edx,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE00767240]; System.String.Substring(Int32, Int32)
M01_L06:
       call      qword ptr [7FFE00B2DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L07
       call      qword ptr [7FFE00B2D7A0]
       mov       rbx,rax
M01_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21EF2ED7DC0
       mov       r8,rbx
       call      qword ptr [7FFE00966718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       call      qword ptr [7FFE00B2DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L09
       call      qword ptr [7FFE00B2D7A0]
       mov       rbx,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21EF2EE4B90
       mov       r8,rbx
       call      qword ptr [7FFE00966718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       call      qword ptr [7FFE00B2DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L11
       call      qword ptr [7FFE00B2D7A0]
       mov       rbx,rax
M01_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21EF2EE4BB0
       mov       r8,rbx
       call      qword ptr [7FFE00966718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 475
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.FromBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+20]
       call      qword ptr [7FFE00B5C6C0]; DotNetTips.Spargine.Extensions.StringExtensions.FromBase64(System.String)
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
; 	public static string FromBase64([NotNull] this string input) => input.IsNullOrEmpty() ? ControlChars.EmptyString : _encoding.GetString(Convert.FromBase64String(input));
; 	                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       jge       near ptr M01_L16
       mov       [rsi+10],edx
       mov       rcx,1BBD4003948
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
       jbe       near ptr M01_L18
       cmp       eax,3D
       je        short M01_L06
M01_L04:
       cmp       rdx,rsi
       jb        short M01_L03
M01_L05:
       test      r15d,r15d
       je        short M01_L07
       cmp       r15d,1
       jne       near ptr M01_L19
       mov       r15d,2
       jmp       short M01_L07
M01_L06:
       dec       ecx
       inc       r15d
       jmp       short M01_L04
M01_L07:
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
       call      qword ptr [7FFE00A37C60]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
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
       je        short M01_L10
       mov       rcx,[rbp-50]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L29
       mov       rsi,[rbp-50]
       add       rsi,10
M01_L08:
       test      rsi,rsi
       je        short M01_L09
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
       jmp       short M01_L13
M01_L09:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FFE00B05B30]
       int       3
M01_L10:
       xor       esi,esi
       jmp       short M01_L08
M01_L11:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rax,r12
M01_L12:
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
M01_L13:
       mov       r13d,r14d
       cmp       r14d,ebx
       jne       near ptr M01_L25
M01_L14:
       test      r13d,r13d
       je        short M01_L15
       mov       ecx,r13d
       call      00007FFE00791E60
       mov       r12,rax
       cmp       [r12],r12b
       lea       r8,[r12+0C]
       mov       [rbp-58],r8
       mov       r14,[rbp-58]
       test      r14,r14
       je        near ptr M01_L26
       mov       r8d,ebx
       or        r8d,r13d
       jl        near ptr M01_L27
       cmp       r13d,ebx
       mov       r8d,ebx
       cmovle    r8d,r13d
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE009BD668]; System.Text.Ascii.WidenAsciiToUtf16(Byte*, Char*, UIntPtr)
       cmp       eax,ebx
       jne       near ptr M01_L28
       jmp       short M01_L11
M01_L15:
       mov       rax,1FC5DE90008
       jmp       near ptr M01_L12
M01_L16:
       mov       [rsi+10],ecx
M01_L17:
       mov       rax,1FC5DE90008
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
       jmp       near ptr M01_L07
M01_L20:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE00C5FC78]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE009B7030]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L21:
       call      qword ptr [7FFE00B057E8]
       int       3
M01_L22:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE00C5FC78]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE009B7030]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rax,1FC5DE90008
       jmp       near ptr M01_L12
M01_L24:
       mov       edx,ebx
       mov       rcx,rsi
       call      qword ptr [7FFE009BD470]; System.Text.Ascii.GetIndexOfFirstNonAsciiByte_Vector(Byte*, UIntPtr)
       mov       r14d,eax
       mov       r13d,r14d
       cmp       r14d,ebx
       je        near ptr M01_L14
M01_L25:
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9d,r13d
       call      qword ptr [7FFE0079C990]
       add       eax,r13d
       mov       r13d,eax
       test      r13d,r13d
       jge       near ptr M01_L14
       call      qword ptr [7FFE0079C7E0]
       int       3
M01_L26:
       mov       ecx,0E
       mov       edx,31
       call      qword ptr [7FFE00B05B30]
       int       3
M01_L27:
       mov       ecx,10
       mov       edx,0D
       call      qword ptr [7FFE00B05B60]
       int       3
M01_L28:
       mov       [rsp+20],r13d
       mov       [rsp+28],eax
       mov       [rsp+30],eax
       mov       dword ptr [rsp+38],1
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,ebx
       mov       r9,r14
       call      qword ptr [7FFE0079CA08]
       jmp       near ptr M01_L11
M01_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 964
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.HasValue()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       test      rcx,rcx
       je        short M00_L01
       call      qword ptr [7FFE00777318]; System.String.Trim()
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE010FE988]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE010FE988]
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
       call      qword ptr [7FFE007773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.Indent()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       mov       dword ptr [rsp+38],0A
       mov       dword ptr [rsp+30],3E
       lea       r8,[rsp+30]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFE00B4C7C8]; DotNetTips.Spargine.Extensions.StringExtensions.Indent(System.String, Int32 ByRef, Char ByRef)
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
; 		if (input.CheckIsNotNull() is false || length <= 0)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return string.Empty;
; 			^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Value.Get().Clear();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (length == 0)
; 			^^^^^^^^^^^^^^^^
; 				_ = sb.Append(input.ArgumentNotNull());
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var charIndex = 1; charIndex <= Math.Abs(length); charIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(indentationCharacter);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (length > 0)
; 			^^^^^^^^^^^^^^^
; 				_ = sb.Append(input);
; 				^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Value.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       rsi,r8
       xor       ecx,ecx
       test      rdi,rdi
       setne     cl
       test      ecx,ecx
       je        near ptr M01_L17
       cmp       dword ptr [rbx],0
       jle       near ptr M01_L17
       mov       rcx,1A808410EF8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L18
       mov       rcx,[rcx+18]
M01_L00:
       mov       r14,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r14],rcx
       jne       near ptr M01_L21
       mov       rcx,[r14+20]
       mov       [rbp-40],rcx
       cmp       qword ptr [rbp-40],0
       je        near ptr M01_L19
       lea       rcx,[r14+20]
       mov       r8,[rbp-40]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-40]
       jne       near ptr M01_L19
M01_L01:
       mov       r15,[rbp-40]
M01_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L03:
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE009CD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-48],r15
       cmp       dword ptr [rbx],0
       je        short M01_L05
M01_L04:
       mov       r14d,1
       jmp       short M01_L08
M01_L05:
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFE009CD1A0]; System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L04
M01_L06:
       movzx     edx,word ptr [rsi]
       mov       r8d,[r15+18]
       mov       ecx,r8d
       mov       rax,[r15+8]
       mov       r10d,[rax+8]
       cmp       r10d,ecx
       jbe       near ptr M01_L14
       mov       r10d,ecx
       mov       [rax+r10*2+10],dx
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
       jle       near ptr M01_L16
       lea       rdx,[rdi+0C]
       mov       r12d,[rdi+8]
       test      r12d,r12d
       je        short M01_L16
       mov       r8,[r15+8]
       mov       ecx,[r15+18]
       mov       edi,ecx
       lea       ecx,[rdi+r12]
       mov       r10d,[r8+8]
       cmp       ecx,r10d
       ja        short M01_L15
       movsxd    rcx,edi
       lea       rcx,[r8+rcx*2+10]
       cmp       r12d,2
       jle       short M01_L12
       movsxd    r8,r12d
       add       r8,r8
       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L10:
       add       r12d,edi
       mov       [r15+18],r12d
       jmp       short M01_L16
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
       call      qword ptr [7FFE00DBE208]
       int       3
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FFE009CD2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M01_L07
M01_L15:
       mov       rcx,r15
       mov       r8d,r12d
       call      qword ptr [7FFE009CD998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FFE009D32D8]; System.Text.StringBuilder.ToString()
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
M01_L17:
       mov       rax,1E89A1F0008
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
M01_L18:
       call      qword ptr [7FFE00B4E940]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L19:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00EB6778]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L20
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L01
M01_L20:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L21:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M01_L03
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
       mov       rcx,1A808410EF8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L23
       call      qword ptr [7FFE00B4E940]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M01_L24
M01_L23:
       mov       r15,[rcx+18]
M01_L24:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool<System.Text.StringBuilder>
       cmp       [r15],rcx
       jne       near ptr M01_L29
       mov       r12,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r12+18],rcx
       jne       short M01_L25
       mov       rdi,[rbp-48]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[r12+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L30
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE009CD0F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L26
M01_L25:
       mov       rdx,[rbp-48]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       test      eax,eax
       mov       rdi,[rbp-48]
       je        short M01_L30
M01_L26:
       cmp       qword ptr [r15+20],0
       jne       short M01_L27
       lea       rcx,[r15+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L30
M01_L27:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L28
       mov       rcx,[r15+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE00EB6748]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L30
M01_L28:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       short M01_L30
M01_L29:
       mov       rdi,[rbp-48]
       mov       rcx,r15
       mov       rdx,rdi
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L30:
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
; Total bytes of code 868
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FFE00B5C7E0]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiDigit(Char ByRef)
; 	public static bool IsAsciiDigit(in this char character) => char.IsDigit(character.ArgumentNotNull());
; 	                                                           ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE0111E448]
       cmp       eax,8
       sete      al
       movzx     eax,al
       jmp       short M01_L00
; Total bytes of code 48
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FFE00B3C7F8]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetter(Char ByRef)
; 	public static bool IsAsciiLetter(in this char character) => char.IsLetter(character.ArgumentNotNull());
; 	                                                            ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,7F
       ja        short M01_L01
       cmp       ecx,100
       jae       short M01_L02
       mov       eax,ecx
       mov       rcx,7FFE5F0C2E50
       test      byte ptr [rax+rcx],60
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE010FE448]
       cmp       eax,4
       setbe     al
       movzx     eax,al
       jmp       short M01_L00
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 70
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiLetterOrDigit()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FFE00B6C810]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiLetterOrDigit(Char ByRef)
; 	public static bool IsAsciiLetterOrDigit(in this char character) => char.IsLetterOrDigit(character.ArgumentNotNull());
; 	                                                                   ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFE5F0C2E50
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
       call      qword ptr [7FFE0112E448]
       jmp       short M01_L00
; Total bytes of code 68
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsAsciiWhitespace()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       cmp       [rbx],bl
       lea       rcx,[rbx+190]
       call      qword ptr [7FFE00B4C828]; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char ByRef)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 36
```
```assembly
; DotNetTips.Spargine.Extensions.StringExtensions.IsAsciiWhitespace(Char ByRef)
; 	public static bool IsAsciiWhitespace(in this char character) => char.IsWhiteSpace(character.ArgumentNotNull());
; 	                                                                ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       movzx     ecx,word ptr [rcx]
       cmp       ecx,100
       jae       short M01_L01
       mov       eax,ecx
       mov       rcx,7FFE5F0C2E50
       test      byte ptr [rax+rcx],80
       setne     al
       movzx     eax,al
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE0111D740]
       jmp       short M01_L00
; Total bytes of code 50
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+130]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,22DCFC02A80
       mov       rcx,[rcx]
       call      qword ptr [7FFE00EF5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00EF53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0111F3F0]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+138]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1D7B5810030
       mov       rcx,[rcx]
       call      qword ptr [7FFE00ED5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00ED53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0110FAF8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+148]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,2545F00E0C8
       mov       rcx,[rcx]
       call      qword ptr [7FFE00F05638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00F053C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE01174C30]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+150]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,259FAC10038
       mov       rcx,[rcx]
       call      qword ptr [7FFE00F05638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00F053C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0114FBE8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],0
       ret
; Total bytes of code 9
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+178]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,21ACE002AA8
       mov       rcx,[rcx]
       call      qword ptr [7FFE00F05638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00F053C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0113F3F0]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsGuid()
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       vmovups   xmm0,[rbx+118]
       vmovups   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       mov       rdx,27C15DA0420
       xor       r8d,r8d
       call      qword ptr [7FFE00837180]; System.Guid.ToString(System.String, System.IFormatProvider)
       test      rax,rax
       je        short M00_L01
       mov       rcx,23B90002AB0
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFE00EE5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      00007FFE00781E60
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
       call      qword ptr [7FFE0093CF78]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFE00837348]
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
       call      qword ptr [7FFE00837348]
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
       call      qword ptr [7FFE00EE53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FFE011559F8]
       int       3
M02_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+160]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1EDF4410070
       mov       rcx,[rcx]
       call      qword ptr [7FFE00F05638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00F053C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0113F7C8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsMacAddress()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1BFAE802AD0
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
       mov       r9,20034784B50
       call      qword ptr [7FFE00EE53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       call      qword ptr [7FFE010C7A68]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE010C7A50]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFE010CC180]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FFE00EF3158
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
       mov       rcx,7FFE00EF3158
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BFAE804FA8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FFE00AF5B48]
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
       test      byte ptr [7FFE00EF31A9],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,1BFAE804FA8
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
       call      qword ptr [7FFE0111FB28]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE0111FB28]
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsNotEmpty()
       mov       rax,[rcx+18]
       mov       byte ptr [rax+4C],1
       ret
; Total bytes of code 9
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsOneToSevenAlpha()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+170]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,242CB410080
       mov       rcx,[rcx]
       call      qword ptr [7FFE00EF5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00EF53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0112FAF8]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsScientific()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,24EC7802AF8
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
       mov       r9,28F4D664B50
       call      qword ptr [7FFE00F053C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       call      qword ptr [7FFE010E7408]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FFE010E73F0]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FFE010E7A50]
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
       mov       rdx,24EC7804FA8
       mov       r12,[rdx]
       jmp       short M01_L10
M01_L06:
       mov       ecx,21
       call      qword ptr [7FFE00B15B48]
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
       mov       rdx,24EC7804FA8
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
       call      qword ptr [7FFE0113FBE8]
       int       3
M01_L12:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FFE0113FBE8]
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,22D0F002B10
       mov       rcx,[rcx]
       call      qword ptr [7FFE00ED5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00ED53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0110FF48]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsStringSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+158]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1A9B2402B00
       mov       rcx,[rcx]
       call      qword ptr [7FFE00EE5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00EE53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE0111FB58]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+148]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1EEF4002B20
       mov       rcx,[rcx]
       call      qword ptr [7FFE00ED5638]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFE00ED53C8]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFE010FFB28]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ReplaceEllipsisWithPeriod()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+180]
       call      qword ptr [7FFE00B4C9C0]; DotNetTips.Spargine.Extensions.StringExtensions.ReplaceEllipsisWithPeriod(System.String)
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
; 		input = input.ArgumentNotNullOrEmpty(true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (input.EndsWith("...", StringComparison.OrdinalIgnoreCase))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			input = input[0..^2];
; 			^^^^^^^^^^^^^^^^^^^^^
; 		return input;
; 		^^^^^^^^^^^^^
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE0110E3D0]
       test      eax,eax
       jne       near ptr M01_L10
M01_L03:
       lea       ecx,[rsi-1]
       cmp       ecx,esi
       jae       near ptr M01_L14
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L10
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFE0110E3D0]
       test      eax,eax
       jne       near ptr M01_L10
M01_L05:
       cmp       [rbx],bl
       mov       rdx,2BECA4B7578
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
       call      qword ptr [7FFE00EE4A98]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      00007FFE00781E60
       mov       rsi,rax
       mov       r8d,edi
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       lea       rdx,[rbx+0C]
       add       r8,r8
       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,rsi
M01_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FFE00B4DA58]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M01_L09
       call      qword ptr [7FFE00B4D7A0]
       mov       rdi,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2BECA4B7DC0
       mov       r8,rdi
       call      qword ptr [7FFE00986718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE007873F0]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L11:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFE00787258]
       int       3
M01_L12:
       mov       rbx,2BECA4B0008
       jmp       near ptr M01_L07
M01_L13:
       jmp       near ptr M01_L07
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00B3C9D8]; DotNetTips.Spargine.Extensions.StringExtensions.Split(System.String, System.StringSplitOptions, Char)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		options = options.ArgumentDefined();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input.Split([delimiter], options).AsReadOnly();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.StringSplitOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],esi
       mov       rdx,rax
       mov       rcx,21F03234B50
       cmp       [rcx],ecx
       call      qword ptr [7FFE006BA770]; System.RuntimeType.IsEnumDefined(System.Object)
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
       call      qword ptr [7FFE007770C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
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
       call      qword ptr [7FFE00B3DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE00B3D7A0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21F03227DC0
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FFE00B3D860]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L05
       call      qword ptr [7FFE00B3D7B8]
       mov       rbx,rax
M01_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21F032282D0
       mov       r8,rbx
       call      qword ptr [7FFE0082D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       ecx,14
       call      qword ptr [7FFE00AE5B18]
       int       3
; Total bytes of code 395
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.SplitRemoveEmpty()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FFE00B4CA38]; DotNetTips.Spargine.Extensions.StringExtensions.SplitRemoveEmpty(System.String)
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
; 		input = input.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return input.Trim().Split([ControlChars.Comma], options: StringSplitOptions.RemoveEmptyEntries).ToReadOnlyCollection();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       call      qword ptr [7FFE00787318]; System.String.Trim()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00787318]; System.String.Trim()
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
       call      qword ptr [7FFE007870C0]; System.String.SplitInternal(System.ReadOnlySpan`1<Char>, Int32, System.StringSplitOptions)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2C402401D88
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,rsi
       call      qword ptr [7FFE0083E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
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
       call      qword ptr [7FFE00B4DA58]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L03
       call      qword ptr [7FFE00B4D7A0]
       mov       rbx,rax
M01_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,304943D7DC0
       mov       r8,rbx
       call      qword ptr [7FFE00986718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L04:
       call      qword ptr [7FFE00B4D9B0]
       mov       ecx,43
       mov       rdx,7FFE00B63810
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B17000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00B63810
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00B4D7A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00986718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 463
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinal()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.StartsWithOrdinalIgnoreCase()
       xor       eax,eax
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 10
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1461
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
       call      qword ptr [7FFE00EF8E80]; System.CharEnumerator.MoveNext()
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
       call      qword ptr [7FFE0085C210]; System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE007A7318]; System.String.Trim()
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
       mov       rdi,1BAEAEA0008
       jmp       short M00_L02
M00_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A94
       mov       rdx,7FFE00B83810
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE00B6D7B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE0085D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L05:
       mov       ecx,21
       call      qword ptr [7FFE00B15B48]
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
       mov       r11,7FFE00660AB0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE00660AB8
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
       call      00007FFE007A2520
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFE0112E988]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFE0112E988]
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
       call      qword ptr [7FFE007A73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToBase64()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+38]
       call      qword ptr [7FFE00B6CA98]; DotNetTips.Spargine.Extensions.StringExtensions.ToBase64(System.String)
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
; 	public static string ToBase64([NotNull] this string input) => input.IsNullOrEmpty() ? ControlChars.EmptyString : Convert.ToBase64String(_encoding.GetBytes(input));
; 	                                                              ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       je        near ptr M01_L02
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
       jge       near ptr M01_L01
       mov       [rsi+10],eax
       mov       rdx,22475403948
       mov       rdi,[rdx]
       lea       rax,[rbx+0C]
       mov       [rsp+40],rax
       mov       rbp,[rsp+40]
       mov       r14d,[rbx+8]
       mov       rdx,[rdi+10]
       mov       r15d,r14d
       test      rdx,rdx
       je        near ptr M01_L03
       mov       rcx,offset MT_System.Text.EncoderReplacementFallback
       cmp       [rdx],rcx
       jne       near ptr M01_L03
       mov       rdx,[rdx+8]
       cmp       dword ptr [rdx+8],1
       jne       near ptr M01_L03
       cmp       dword ptr [rdx+8],0
       jbe       near ptr M01_L05
       cmp       word ptr [rdx+0C],7F
       ja        near ptr M01_L03
       mov       esi,r15d
       cmp       r15d,r14d
       jne       near ptr M01_L04
M01_L00:
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
       call      qword ptr [7FFE00EF9370]; System.Text.ASCIIEncoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       lea       rcx,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+30],rcx
       mov       [rsp+38],edx
       lea       rcx,[rsp+30]
       xor       edx,edx
       call      qword ptr [7FFE00A47B88]; System.Convert.ToBase64String(System.ReadOnlySpan`1<Byte>, System.Base64FormattingOptions)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L01:
       mov       [rsi+10],edx
M01_L02:
       mov       rax,264FF320008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       edx,r14d
       mov       rcx,rbp
       call      qword ptr [7FFE009CD4D0]
       mov       r15d,eax
       mov       esi,r15d
       cmp       r15d,r14d
       je        near ptr M01_L00
M01_L04:
       mov       rcx,rdi
       mov       rdx,rbp
       mov       r8d,r14d
       mov       r9d,esi
       call      qword ptr [7FFE007AC8A0]
       add       esi,eax
       jns       near ptr M01_L00
       call      qword ptr [7FFE007AC7E0]
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 410
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
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
       call      qword ptr [7FFE00A17C60]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       jne       near ptr M00_L07
       xor       esi,esi
       xor       r14d,r14d
M00_L02:
       test      r14d,r14d
       jne       near ptr M00_L09
       mov       r15,2B3C3D06758
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
       call      qword ptr [7FFE00B3DA58]
       mov       rdi,rax
       test      rdi,rdi
       jne       short M00_L06
       call      qword ptr [7FFE00B3D7A0]
       mov       rdi,rax
M00_L06:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,2B3C3D07DC0
       mov       r8,rdi
       call      qword ptr [7FFE00976718]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M00_L07:
       mov       r14d,[rsp+50]
       cmp       r14d,ebp
       jbe       short M00_L08
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE0110DC08]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE0110DC08]
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
       call      qword ptr [7FFE007773F0]
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
       mov       rax,0AE5BB72F5207
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
       je        near ptr M02_L18
M02_L00:
       mov       [rdi],rbp
       mov       [rdi+8],r14d
       mov       [rsi],r15
       mov       [rsi+8],r13d
       lea       r8,[rsp+68]
       lea       r9,[rsp+60]
       mov       rcx,rdi
       mov       rdx,rsi
       call      qword ptr [7FFE00A15D58]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       mov       edx,[rsp+60]
       add       [rbx],edx
       test      eax,eax
       jne       near ptr M02_L18
       mov       eax,[rsp+68]
       cmp       eax,r14d
       ja        near ptr M02_L23
       mov       edx,eax
       lea       rbp,[rbp+rdx*2]
       sub       r14d,eax
       mov       eax,[rsp+60]
       cmp       eax,r13d
       ja        near ptr M02_L23
       mov       edx,eax
       add       r15,rdx
       sub       r13d,eax
       test      r14d,r14d
       je        near ptr M02_L26
       movzx     eax,word ptr [rbp]
       cmp       eax,20
       je        short M02_L02
       cmp       eax,9
       je        short M02_L02
       cmp       eax,0D
       je        short M02_L02
       cmp       eax,0A
       je        short M02_L02
       mov       rax,r12
       mov       r11d,[rsp+44]
       mov       r10d,r11d
       xor       ecx,ecx
       xor       r9d,r9d
       test      r14d,r14d
       jle       short M02_L01
       jmp       near ptr M02_L06
M02_L01:
       mov       edx,ecx
       jmp       near ptr M02_L22
M02_L02:
       mov       r10d,1
       cmp       r14d,1
       je        short M02_L04
M02_L03:
       cmp       r10d,r14d
       jae       near ptr M02_L26
       mov       eax,r10d
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,20
       je        near ptr M02_L20
       cmp       eax,9
       je        near ptr M02_L20
       cmp       eax,0D
       je        near ptr M02_L20
       cmp       eax,0A
       je        near ptr M02_L20
M02_L04:
       cmp       r10d,r14d
       ja        near ptr M02_L23
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
       jne       near ptr M02_L21
M02_L05:
       test      r14d,r14d
       je        near ptr M02_L18
       jmp       near ptr M02_L00
M02_L06:
       mov       r8d,r9d
       movzx     r8d,word ptr [rbp+r8*2]
       cmp       r8d,20
       je        short M02_L11
       cmp       r8d,9
       je        short M02_L10
       cmp       r8d,0D
       je        short M02_L09
       cmp       r8d,0A
       je        short M02_L08
       lea       edx,[rcx+1]
       cmp       ecx,r10d
       jae       near ptr M02_L26
       mov       ecx,ecx
       mov       [rax+rcx*2],r8w
       cmp       edx,r10d
       je        short M02_L12
M02_L07:
       inc       r9d
       cmp       r9d,r14d
       jge       near ptr M02_L22
       mov       ecx,edx
       jmp       short M02_L06
M02_L08:
       mov       edx,ecx
       jmp       short M02_L07
M02_L09:
       mov       edx,ecx
       jmp       short M02_L07
M02_L10:
       mov       edx,ecx
       jmp       short M02_L07
M02_L11:
       mov       edx,ecx
       jmp       short M02_L07
M02_L12:
       lea       eax,[r9+1]
       mov       [rsp+5C],eax
M02_L13:
       test      dl,3
       jne       near ptr M02_L14
       mov       ecx,edx
       cmp       ecx,r11d
       ja        near ptr M02_L23
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
       call      qword ptr [7FFE00A15D58]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       test      eax,eax
       je        short M02_L14
       mov       eax,[rsp+48]
       add       [rbx],eax
       mov       eax,[rsp+5C]
       cmp       eax,r14d
       ja        near ptr M02_L23
       mov       edx,eax
       lea       rbp,[rbp+rdx*2]
       sub       r14d,eax
       mov       eax,[rsp+48]
       cmp       eax,r13d
       ja        near ptr M02_L23
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
       jne       near ptr M02_L24
       jmp       near ptr M02_L05
M02_L14:
       xor       eax,eax
       mov       [rbx],eax
       mov       rcx,0AE5BB72F5207
       cmp       [rsp+70],rcx
       je        short M02_L15
       call      CORINFO_HELP_FAIL_FAST
M02_L15:
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
M02_L16:
       inc       eax
M02_L17:
       cmp       eax,r14d
       jl        short M02_L25
M02_L18:
       mov       eax,1
       mov       rcx,0AE5BB72F5207
       cmp       [rsp+70],rcx
       je        short M02_L19
       call      CORINFO_HELP_FAIL_FAST
M02_L19:
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
M02_L20:
       inc       r10d
       cmp       r10d,r14d
       jne       near ptr M02_L03
       jmp       near ptr M02_L04
M02_L21:
       test      r14d,r14d
       je        near ptr M02_L05
       jmp       short M02_L14
M02_L22:
       mov       eax,r14d
       mov       [rsp+5C],eax
       jmp       near ptr M02_L13
M02_L23:
       call      qword ptr [7FFE00AE57E8]
       int       3
M02_L24:
       xor       eax,eax
       jmp       short M02_L17
M02_L25:
       cmp       eax,r14d
       jae       short M02_L26
       mov       ecx,eax
       movzx     ecx,word ptr [rbp+rcx*2]
       cmp       ecx,20
       je        short M02_L16
       cmp       ecx,9
       je        short M02_L16
       cmp       ecx,0D
       je        near ptr M02_L16
       cmp       ecx,0A
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L16
       jmp       near ptr M02_L14
M02_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 853
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
       jmp       qword ptr [7FFE00825B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToByteArrayFromBase64()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+20]
       test      rsi,rsi
       je        near ptr M00_L07
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L07
       mov       rcx,offset MT_System.CharEnumerator
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+10],0FFFFFFFF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFE00EC8E80]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        near ptr M00_L03
       imul      eax,edi,3
       jo        near ptr M00_L02
       mov       r8d,eax
       sar       r8d,1F
       and       r8d,3
       add       eax,r8d
       sar       eax,2
M00_L00:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rbp,[rax+10]
       mov       r14d,[rax+8]
       mov       rcx,rbp
       mov       edx,r14d
       add       rsi,0C
       mov       [rsp+30],rsi
       mov       [rsp+38],edi
       mov       [rsp+20],rcx
       mov       [rsp+28],edx
       lea       rcx,[rsp+30]
       lea       rdx,[rsp+20]
       lea       r8,[rsp+48]
       call      qword ptr [7FFE00A17C60]; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       test      eax,eax
       je        short M00_L04
       mov       esi,[rsp+48]
       cmp       esi,r14d
       ja        near ptr M00_L05
       test      esi,esi
       je        near ptr M00_L06
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       mov       rdx,rbp
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L01:
       mov       [rsp+40],rdi
       mov       rdi,[rbx+18]
       mov       rdx,[rsp+40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       call      CORINFO_HELP_OVERFLOW
M00_L03:
       xor       eax,eax
       jmp       near ptr M00_L00
M00_L04:
       mov       rcx,offset MT_System.FormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE010B71C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00997030]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE00AE57E8]
       int       3
M00_L06:
       mov       rdi,2777E0A6758
       jmp       short M00_L01
M00_L07:
       mov       rdi,2777E0A6758
       jmp       short M00_L01
; Total bytes of code 403
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
; System.Convert.TryFromBase64Chars(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,90
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rax,7F2C0CDE99A1
       mov       [rsp+88],rax
       mov       rbx,r8
       mov       rsi,rdx
       mov       rdi,rcx
       lea       rbp,[rsp+20]
       mov       r14d,4
       xor       ecx,ecx
       mov       [rbx],ecx
       cmp       dword ptr [rdi+8],0
       je        short M02_L01
M02_L00:
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+80]
       lea       r9,[rsp+78]
       call      qword ptr [7FFE00A15D58]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       mov       edx,[rsp+78]
       add       [rbx],edx
       test      eax,eax
       je        short M02_L03
M02_L01:
       mov       eax,1
       mov       rcx,7F2C0CDE99A1
       cmp       [rsp+88],rcx
       je        short M02_L02
       call      CORINFO_HELP_FAIL_FAST
M02_L02:
       nop
       add       rsp,90
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L03:
       mov       eax,[rsp+80]
       cmp       eax,[rdi+8]
       ja        near ptr M02_L10
       mov       rdx,[rdi]
       mov       ecx,eax
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rdi+8]
       sub       ecx,eax
       mov       [rdi],rdx
       mov       [rdi+8],ecx
       mov       eax,[rsp+78]
       cmp       eax,[rsi+8]
       ja        near ptr M02_L10
       mov       edx,eax
       add       rdx,[rsi]
       mov       ecx,[rsi+8]
       sub       ecx,eax
       mov       [rsi],rdx
       mov       [rsi+8],ecx
       cmp       dword ptr [rdi+8],0
       jbe       near ptr M02_L17
       mov       rax,[rdi]
       movzx     eax,word ptr [rax]
       cmp       eax,20
       je        short M02_L04
       cmp       eax,9
       je        short M02_L04
       cmp       eax,0D
       je        short M02_L04
       cmp       eax,0A
       sete      al
       movzx     eax,al
       test      eax,eax
       je        near ptr M02_L08
M02_L04:
       mov       eax,1
M02_L05:
       cmp       eax,[rdi+8]
       je        short M02_L07
       cmp       eax,[rdi+8]
       jae       near ptr M02_L17
       mov       rdx,[rdi]
       mov       ecx,eax
       movzx     edx,word ptr [rdx+rcx*2]
       cmp       edx,20
       je        short M02_L06
       cmp       edx,9
       je        short M02_L06
       cmp       edx,0D
       je        short M02_L06
       cmp       edx,0A
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L07
M02_L06:
       inc       eax
       jmp       short M02_L05
M02_L07:
       cmp       eax,[rdi+8]
       ja        near ptr M02_L10
       mov       rdx,[rdi]
       mov       ecx,eax
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rdi+8]
       sub       ecx,eax
       mov       [rdi],rdx
       mov       [rdi+8],ecx
       mov       ecx,[rsp+78]
       mov       edx,55555556
       mov       eax,edx
       imul      dword ptr [rsp+78]
       mov       r8d,edx
       shr       r8d,1F
       add       edx,r8d
       lea       edx,[rdx+rdx*2]
       sub       ecx,edx
       je        near ptr M02_L09
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L09
       jmp       near ptr M02_L13
M02_L08:
       vmovdqu   xmm0,xmmword ptr [rdi]
       vmovdqu   xmmword ptr [rsp+48],xmm0
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+28]
       lea       r8,[rsp+70]
       lea       r9,[rsp+68]
       call      qword ptr [7FFE00A17C78]
       test      byte ptr [rsp+68],3
       jne       near ptr M02_L13
       mov       ecx,[rsp+68]
       cmp       ecx,r14d
       ja        near ptr M02_L10
       mov       r14d,ecx
       mov       [rsp+48],rbp
       mov       [rsp+50],r14d
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       lea       r8,[rsp+60]
       lea       r9,[rsp+58]
       call      qword ptr [7FFE00A15D58]; System.Convert.TryDecodeFromUtf16(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>, Int32 ByRef, Int32 ByRef)
       test      eax,eax
       je        near ptr M02_L13
       mov       eax,[rsp+58]
       add       [rbx],eax
       mov       eax,[rsp+70]
       cmp       eax,[rdi+8]
       ja        short M02_L10
       mov       rdx,[rdi]
       mov       ecx,eax
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rdi+8]
       sub       ecx,eax
       mov       [rdi],rdx
       mov       [rdi+8],ecx
       mov       eax,[rsp+58]
       cmp       eax,[rsi+8]
       ja        short M02_L10
       mov       edx,eax
       add       rdx,[rsi]
       mov       ecx,[rsi+8]
       sub       ecx,eax
       mov       [rsi],rdx
       mov       [rsi+8],ecx
       mov       ecx,[rsp+58]
       mov       edx,55555556
       mov       eax,edx
       imul      dword ptr [rsp+58]
       mov       eax,edx
       shr       eax,1F
       add       eax,edx
       lea       eax,[rax+rax*2]
       sub       ecx,eax
       jne       short M02_L11
M02_L09:
       cmp       dword ptr [rdi+8],0
       jne       near ptr M02_L00
       jmp       near ptr M02_L01
M02_L10:
       call      qword ptr [7FFE00AE57E8]
       int       3
M02_L11:
       xor       ecx,ecx
       jmp       short M02_L16
M02_L12:
       cmp       ecx,[rdi+8]
       jae       short M02_L17
       mov       rax,[rdi]
       mov       edx,ecx
       movzx     eax,word ptr [rax+rdx*2]
       cmp       eax,20
       je        short M02_L15
       cmp       eax,9
       je        short M02_L15
       cmp       eax,0D
       je        short M02_L15
       cmp       eax,0A
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L15
M02_L13:
       xor       eax,eax
       mov       [rbx],eax
       mov       rcx,7F2C0CDE99A1
       cmp       [rsp+88],rcx
       je        short M02_L14
       call      CORINFO_HELP_FAIL_FAST
M02_L14:
       nop
       add       rsp,90
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L15:
       inc       ecx
M02_L16:
       cmp       ecx,[rdi+8]
       jl        short M02_L12
       jmp       near ptr M02_L01
M02_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 795
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
       jmp       qword ptr [7FFE00825B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rax,26C055B4B50
       mov       [rcx+8],rax
       call      qword ptr [7FFE00EF8E80]; System.CharEnumerator.MoveNext()
       test      eax,eax
       je        short M00_L03
       call      qword ptr [7FFE0097E1C0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       short M00_L02
       mov       rcx,rax
       call      qword ptr [7FFE00992CA0]; System.Globalization.CultureInfo.get_TextInfo()
M00_L00:
       mov       rcx,rax
       mov       rdx,26C055B4B50
       cmp       [rcx],ecx
       call      qword ptr [7FFE00A4F168]; System.Globalization.TextInfo.ToTitleCase(System.String)
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
       mov       rax,26C055B4B50
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
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],2
       jl        short M02_L02
       mov       rax,[rax+198]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L02
       mov       rdx,[rax]
       add       rdx,10
M02_L00:
       mov       rax,[rdx+8]
       test      rax,rax
       jne       short M02_L01
       mov       rax,22B73400438
       mov       rax,[rax]
       test      rax,rax
       jne       short M02_L01
       mov       rax,22B73400418
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L03
M02_L01:
       add       rsp,28
       ret
M02_L02:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       short M02_L00
M02_L03:
       add       rsp,28
       jmp       qword ptr [7FFE0097E070]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE00A4EE08]; System.Globalization.TextInfo..ctor(System.Globalization.CultureData)
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
       mov       r14,7FFE5F0D1CB0
       movzx     r8d,byte ptr [r8+r14]
       shl       r8d,6
       mov       edx,r13d
       shr       edx,3
       and       edx,3E
       add       r8d,edx
       mov       r15,7FFE5F0CACC8
       movzx     r8d,word ptr [r8+r15]
       shl       r8d,4
       and       r13d,0F
       add       r8d,r13d
       mov       r13,7FFE5F0CE7F0
       movzx     r8d,byte ptr [r8+r13]
       mov       r12,7FFE5F0C3150
       movzx     eax,byte ptr [r8+r12]
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
       call      qword ptr [7FFE00A4F198]; System.Globalization.TextInfo.AddTitlecaseLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
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
       call      qword ptr [7FFE010E7798]; System.Globalization.TextInfo.ChangeCaseCommon[[System.Globalization.TextInfo+ToLowerConversion, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L17:
       add       r14d,r13d
       mov       [r15+18],r14d
       jmp       short M04_L19
M04_L18:
       mov       rcx,r15
       mov       r8d,r14d
       call      qword ptr [7FFE009ED998]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
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
       call      qword ptr [7FFE009ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFE009F32D8]; System.Text.StringBuilder.ToString()
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
       mov       rdx,7FFE00654000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE009A6790]
       int       3
M04_L27:
       mov       [rsp+34],eax
       mov       ecx,172D
       mov       rdx,7FFE00654000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,[rsp+34]
       call      qword ptr [7FFE010EDF80]
       int       3
M04_L28:
       mov       ecx,2E5
       mov       rdx,7FFE00654000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE009A6790]
       int       3
M04_L29:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       ecx,172D
       mov       rdx,7FFE00654000
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE00C6EEE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbp
       call      qword ptr [7FFE0085D470]
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
       mov       rdx,26C055B4B78
       cmp       [rcx],ecx
       call      qword ptr [7FFE009ED1A0]; System.Text.StringBuilder.Append(System.String)
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
       call      qword ptr [7FFE00A4EFB8]; System.Globalization.TextInfo.ToLower(System.String)
       mov       rsi,rax
       mov       eax,[rsp+34]
M04_L37:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,rsi
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE009ED1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       short M04_L39
M04_L38:
       mov       r9d,ebp
       sub       r9d,eax
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+98]
       mov       r8d,eax
       cmp       [rcx],ecx
       call      qword ptr [7FFE009ED1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
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
       call      qword ptr [7FFE009ED1B8]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       jmp       near ptr M04_L19
M04_L44:
       call      qword ptr [7FFE009ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M04_L20
M04_L45:
       call      qword ptr [7FFE009ED2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       r15d,ebp
       jmp       near ptr M04_L23
M04_L46:
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+98]
       mov       r8d,ebp
       mov       r9d,[rsp+38]
       call      qword ptr [7FFE00A4F180]; System.Globalization.TextInfo.AddNonLetter(System.Text.StringBuilder ByRef, System.String ByRef, Int32, Int32)
       mov       ebp,eax
       jmp       near ptr M04_L24
M04_L47:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringExtensionsBenchmark.ToTrimmedString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_BenchmarkDotNet.Autogenerated.Runnable_1470
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
       call      qword ptr [7FFE00ED8E80]; System.CharEnumerator.MoveNext()
M00_L01:
       test      eax,eax
       je        short M00_L03
       mov       rcx,rsi
       call      qword ptr [7FFE00787318]; System.String.Trim()
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
       mov       r11,7FFE00640AB0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       r11,7FFE00640AB8
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M02_L01
       jmp       near ptr M02_L16
M02_L00:
       call      qword ptr [7FFE0110E388]
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L05
       jmp       short M02_L04
M02_L03:
       call      qword ptr [7FFE0110E388]
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L08
M02_L07:
       call      qword ptr [7FFE0110E388]
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       je        short M02_L12
       jmp       short M02_L11
M02_L10:
       call      qword ptr [7FFE0110E388]
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
       call      00007FFE00781E60
       mov       rsi,rax
       mov       r8d,ebp
       cmp       [rsi],sil
       lea       rcx,[rsi+0C]
       mov       edx,edi
       lea       rdx,[rbx+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FFE00835B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rsi
       jmp       short M02_L13
M02_L15:
       mov       rax,188D3C10008
       jmp       short M02_L13
M02_L16:
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       call      qword ptr [7FFE00715CE0]; System.Char.IsWhiteSpace(Char)
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

