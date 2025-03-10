## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsFirstLastName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,15E5F402A10
       mov       rcx,[rcx]
       mov       rdx,19EE94E4358
       call      qword ptr [7FFF7E76FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E76F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8C810]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsWord()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,1B74300A9B0
       mov       rcx,[rcx]
       call      qword ptr [7FFF7E76FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E76F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8CC00]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCreditCardNumber()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,27F7D8029F0
       mov       rcx,[rcx]
       mov       rdx,2C0037743A8
       call      qword ptr [7FFF7E74FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E74F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC6DC98]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCurrencyCode()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1FFF7C089C0
       mov       rcx,[rcx]
       mov       rdx,240899243A8
       call      qword ptr [7FFF7E77FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E77F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC9C810]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsEmailAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1ECF74089D0
       mov       rcx,[rcx]
       mov       rdx,22D893E43A8
       call      qword ptr [7FFF7E75FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E75F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8CF30]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsGuid()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2822AC02A18
       mov       rcx,[rcx]
       mov       rdx,2C2B4AE43A8
       call      qword ptr [7FFF7E77FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E77F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC9C270]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv4Address()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,19A42C02A20
       mov       rcx,[rcx]
       mov       rdx,1DACCBB43A8
       call      qword ptr [7FFF7E75FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E75F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8C270]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv6Address()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,18C7780A9F0
       mov       rcx,[rcx]
       mov       rdx,1CD094B43A8
       call      qword ptr [7FFF7E77FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E77F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC9C810]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsISBN()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1E9CF402A30
       mov       rcx,[rcx]
       mov       rdx,22A593C43A8
       call      qword ptr [7FFF7E76FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E76F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8D308]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsMACAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,1F42E80AA00
       mov       rcx,[rcx]
       mov       rdx,234C08843A8
       call      qword ptr [7FFF7E75FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E75F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC7C270]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsScientific()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,209C080AA28
       mov       rcx,[rcx]
       mov       rdx,24A528543A8
       call      qword ptr [7FFF7E74FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E74F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC6C810]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsSHA1Hash()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,2218DC08A38
       mov       rcx,[rcx]
       mov       rdx,2621FB243A8
       call      qword ptr [7FFF7E76FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E76F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8CC60]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrl()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,18D54C02A88
       mov       rcx,[rcx]
       mov       rdx,1CDDAC643A8
       call      qword ptr [7FFF7E73FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E73F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC6DC08]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrlDomainAddress()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,11AA2C02A80
       mov       rcx,[rcx]
       mov       rdx,15B2CCA43A8
       call      qword ptr [7FFF7E73FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FFF7E73F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC5D728]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsValidString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FFF7E854D20]; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
       test      rax,rax
       je        short M00_L01
       mov       rcx,1E8B4808A48
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FFF7E76FB88]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
M00_L00:
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
M00_L01:
       xor       eax,eax
       jmp       short M00_L00
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
;                 return ResourceManager.GetString("LongTestString", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFF7E854BD0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,1E8B48082A0
       mov       r8,[r8]
       mov       rdx,229468543A8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
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
       call      qword ptr [7FFF7E76F918]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FFF7EC8D608]
       int       3
M02_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveHtml()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,1F81F008A20
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       edi,11
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF7E77F8E8]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,238B0DA0008
       call      qword ptr [7FFF7EC6C1E0]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,238B0DB43A8
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EC6C240]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+30]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rsi,[rbx+30]
       mov       rcx,offset MT_System.WeakReference`1[[System.Text.RegularExpressions.RegexReplacement, System.Text.RegularExpressions]]
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFF7E47D098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M01_L00
       mov       rax,[rbx+30]
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rax,[rbx+8]
       and       rax,0FFFFFFFFFFFFFFFE
       je        short M02_L03
       test      al,2
       jne       short M02_L04
       mov       r14,[rax]
M02_L00:
       test      r14,r14
       je        short M02_L02
       mov       r15,[r14+18]
       cmp       [r15],r15b
       cmp       r15,rsi
       jne       short M02_L05
M02_L01:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       r13,[rsp+90]
       mov       [rsp+20],r13
       mov       rcx,rsi
       mov       edx,[rsp+98]
       mov       r8,rdi
       mov       r9d,ebp
       call      qword ptr [7FFF7EC6C780]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF7E47D0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7ECC4C00]
       mov       r14,rax
       jmp       short M02_L00
M02_L05:
       test      rsi,rsi
       je        short M02_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rsi+8]
       jne       short M02_L02
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7E475068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L01
       jmp       short M02_L02
; Total bytes of code 201
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       cmp       r9d,0FFFFFFFF
       jl        short M03_L02
       cmp       [r8+8],eax
       jb        short M03_L03
       test      r9d,r9d
       je        short M03_L04
       test      byte ptr [rdx+40],40
       jne       short M03_L01
       cmp       byte ptr [rcx+20],0
       jne       short M03_L01
       mov       r10,[rcx+10]
       cmp       dword ptr [r10+8],0
       jne       short M03_L05
       mov       r10,238B0DA0008
M03_L00:
       mov       [rsp+50],eax
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C258]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M03_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C270]
M03_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FFF7ECC4B28]
       int       3
M03_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFF7ECC4B28]
       int       3
M03_L04:
       mov       rax,r8
       add       rsp,28
       ret
M03_L05:
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jbe       short M03_L06
       mov       r10,[rcx+10]
       jmp       short M03_L00
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveSpecialChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,11333402A58
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       edi,0D
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF7E77F8E8]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,153B9450008
       call      qword ptr [7FFF7EC6C1E0]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,153B94643A8
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EC6C240]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+30]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rsi,[rbx+30]
       mov       rcx,offset MT_System.WeakReference`1[[System.Text.RegularExpressions.RegexReplacement, System.Text.RegularExpressions]]
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFF7E47D098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M01_L00
       mov       rax,[rbx+30]
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rax,[rbx+8]
       and       rax,0FFFFFFFFFFFFFFFE
       je        short M02_L03
       test      al,2
       jne       short M02_L04
       mov       r14,[rax]
M02_L00:
       test      r14,r14
       je        short M02_L02
       mov       r15,[r14+18]
       cmp       [r15],r15b
       cmp       r15,rsi
       jne       short M02_L05
M02_L01:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       r13,[rsp+90]
       mov       [rsp+20],r13
       mov       rcx,rsi
       mov       edx,[rsp+98]
       mov       r8,rdi
       mov       r9d,ebp
       call      qword ptr [7FFF7EC6C780]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF7E47D0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7ECD4840]
       mov       r14,rax
       jmp       short M02_L00
M02_L05:
       test      rsi,rsi
       je        short M02_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rsi+8]
       jne       short M02_L02
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7E475068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L01
       jmp       short M02_L02
; Total bytes of code 201
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       cmp       r9d,0FFFFFFFF
       jl        short M03_L02
       cmp       [r8+8],eax
       jb        short M03_L03
       test      r9d,r9d
       je        short M03_L04
       test      byte ptr [rdx+40],40
       jne       short M03_L01
       cmp       byte ptr [rcx+20],0
       jne       short M03_L01
       mov       r10,[rcx+10]
       cmp       dword ptr [r10+8],0
       jne       short M03_L05
       mov       r10,153B9450008
M03_L00:
       mov       [rsp+50],eax
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C258]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M03_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C270]
M03_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FFF7ECD4768]
       int       3
M03_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFF7ECD4768]
       int       3
M03_L04:
       mov       rax,r8
       add       rsp,28
       ret
M03_L05:
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jbe       short M03_L06
       mov       r10,[rcx+10]
       jmp       short M03_L00
M03_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ReplaceCrLf()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,1FA1380AA10
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       je        near ptr M00_L01
       mov       edi,0C
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFF7E75F8E8]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,23AA5820008
       call      qword ptr [7FFF7EC4C648]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,23AA58343A8
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EC4C6A8]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       xor       edi,edi
       jmp       near ptr M00_L00
; Total bytes of code 177
```
```assembly
; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+30]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       lea       rsi,[rbx+30]
       mov       rcx,offset MT_System.WeakReference`1[[System.Text.RegularExpressions.RegexReplacement, System.Text.RegularExpressions]]
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFF7E45D098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M01_L00
       mov       rax,[rbx+30]
       jmp       short M01_L00
; Total bytes of code 88
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rax,[rbx+8]
       and       rax,0FFFFFFFFFFFFFFFE
       je        short M02_L03
       test      al,2
       jne       short M02_L04
       mov       r14,[rax]
M02_L00:
       test      r14,r14
       je        short M02_L02
       mov       r15,[r14+18]
       cmp       [r15],r15b
       cmp       r15,rsi
       jne       short M02_L05
M02_L01:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L02:
       mov       r13,[rsp+90]
       mov       [rsp+20],r13
       mov       rcx,rsi
       mov       edx,[rsp+98]
       mov       r8,rdi
       mov       r9d,ebp
       call      qword ptr [7FFF7EC4CBE8]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF7E45D0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7ECB4EE8]
       mov       r14,rax
       jmp       short M02_L00
M02_L05:
       test      rsi,rsi
       je        short M02_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rsi+8]
       jne       short M02_L02
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7E455068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M02_L01
       jmp       short M02_L02
; Total bytes of code 201
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       cmp       r9d,0FFFFFFFF
       jl        short M03_L01
       cmp       [r8+8],eax
       jb        short M03_L02
       test      r9d,r9d
       je        short M03_L03
       test      byte ptr [rdx+40],40
       je        short M03_L04
M03_L00:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FFF7EC4C6D8]; System.Text.RegularExpressions.RegexReplacement.ReplaceNonSimpleText(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
M03_L01:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FFF7ECB4E10]
       int       3
M03_L02:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFF7ECB4E10]
       int       3
M03_L03:
       mov       rax,r8
       add       rsp,28
       ret
M03_L04:
       cmp       byte ptr [rcx+20],0
       jne       short M03_L00
       mov       r10,[rcx+10]
       cmp       dword ptr [r10+8],0
       jne       short M03_L05
       mov       rcx,rdx
       mov       r10,23AA5820008
       jmp       short M03_L06
M03_L05:
       mov       r10,[rcx+8]
       cmp       dword ptr [r10+8],0
       jbe       short M03_L07
       mov       r10,[r10+10]
       mov       rcx,rdx
M03_L06:
       mov       [rsp+50],eax
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FFF7EC4C6C0]
M03_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ReplaceSpaces()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       call      qword ptr [7FFF7E864D20]; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
       test      rax,rax
       je        near ptr M00_L03
       mov       rcx,2028680AA38
       mov       rsi,[rcx]
       mov       rdi,rax
       mov       rbp,rdi
       test      byte ptr [rsi+40],40
       jne       short M00_L00
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rbp,rdi
       mov       r14d,[rbp+8]
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFF7E77F8E8]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,24318862AE0
       call      qword ptr [7FFF7EC6C1E0]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],r14d
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EC6C240]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
M00_L02:
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L03:
       xor       eax,eax
       jmp       short M00_L02
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
;                 return ResourceManager.GetString("LongTestString", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      qword ptr [7FFF7E864BD0]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,2028680A298
       mov       r8,[r8]
       mov       rdx,243188743A8
       mov       rax,[rax]
       mov       rax,[rax+48]
       add       rsp,28
       jmp       qword ptr [rax+28]
; Total bytes of code 51
```
```assembly
; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+30]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L01:
       lea       rsi,[rbx+30]
       mov       rcx,offset MT_System.WeakReference`1[[System.Text.RegularExpressions.RegexReplacement, System.Text.RegularExpressions]]
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFF7E47D098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       short M02_L00
       mov       rax,[rbx+30]
       jmp       short M02_L00
; Total bytes of code 88
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       rcx,[rbx+8]
       and       rcx,0FFFFFFFFFFFFFFFE
       je        short M03_L02
       test      cl,2
       jne       short M03_L03
       mov       r14,[rcx]
M03_L00:
       test      r14,r14
       je        short M03_L05
       mov       r15,[r14+18]
       cmp       [r15],r15b
       cmp       r15,rsi
       jne       short M03_L04
M03_L01:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L02:
       xor       r14d,r14d
       jmp       short M03_L00
M03_L03:
       and       rcx,0FFFFFFFFFFFFFFFC
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7ECE4048]
       mov       r14,rax
       jmp       short M03_L00
M03_L04:
       test      rsi,rsi
       je        short M03_L05
       mov       r8d,[r15+8]
       cmp       r8d,[rsi+8]
       jne       short M03_L05
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFF7E475068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       short M03_L01
M03_L05:
       mov       r14,[rsp+80]
       mov       [rsp+20],r14
       mov       rcx,rsi
       mov       edx,[rsp+88]
       mov       r8,rdi
       mov       r9d,ebp
       call      qword ptr [7FFF7EC6C780]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FFF7E47D0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       near ptr M03_L01
; Total bytes of code 195
```
```assembly
; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
       sub       rsp,28
       mov       eax,[rsp+50]
       cmp       r9d,0FFFFFFFF
       jl        short M04_L02
       cmp       [r8+8],eax
       jb        short M04_L03
       test      r9d,r9d
       je        short M04_L04
       test      byte ptr [rdx+40],40
       jne       short M04_L01
       cmp       byte ptr [rcx+20],0
       jne       short M04_L01
       mov       r10,[rcx+10]
       cmp       dword ptr [r10+8],0
       je        short M04_L05
       mov       rcx,[rcx+8]
       cmp       dword ptr [rcx+8],0
       jbe       short M04_L06
       mov       r10,[rcx+10]
M04_L00:
       mov       [rsp+50],eax
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C258]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M04_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FFF7EC6C270]
M04_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FFF7EC9FF60]
       int       3
M04_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FFF7EC9FF60]
       int       3
M04_L04:
       mov       rax,r8
       add       rsp,28
       ret
M04_L05:
       mov       r10,24318860008
       jmp       short M04_L00
M04_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```

