## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsFirstLastName()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,2E6CE002A60
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0E
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,32757E64768
       call      qword ptr [7FF9003BF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,0E
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
       call      qword ptr [7FF9008CEAC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008CEAA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008CF120]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003ABC00
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
       mov       rcx,7FF9003ABC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E6CE0037E8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900315B48]
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
       test      byte ptr [7FF9003ABC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,2E6CE0037E8
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
       call      qword ptr [7FF900924798]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900924798]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ContainsWord()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rdx,[rbx+38]
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,17DCEC0AA08
       mov       rcx,[rcx]
       call      qword ptr [7FF90039FAF8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M01_L01:
       mov       ecx,7
       call      qword ptr [7FF900904B40]
       int       3
M01_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M01_L00
; Total bytes of code 90
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCreditCardNumber()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,18F15408A18
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],10
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1CFA7574740
       call      qword ptr [7FF9003BF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,10
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
       call      qword ptr [7FF9008CE460]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008CE448]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008CEAC0]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003ABC00
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
       mov       rcx,7FF9003ABC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18F154097C8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900315B48]
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
       test      byte ptr [7FF9003ABC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,18F154097C8
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
       call      qword ptr [7FF900925C20]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900925C20]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsCurrencyCode()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1CD7D00AA10
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],3
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,20E0F1B4768
       call      qword ptr [7FF9003AF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,3
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
       call      qword ptr [7FF9008BE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008BE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008BEC70]
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
       mov       rdx,1CD7D00B7C0
       mov       r12,[rdx]
       jmp       short M01_L10
M01_L06:
       mov       ecx,21
       call      qword ptr [7FF900305B48]
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
       mov       rdx,1CD7D00B7C0
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
       call      qword ptr [7FF900914168]
       int       3
M01_L12:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900914168]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsEmailAddress()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,20243808A28
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],13
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,242D5954768
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,13
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
       call      qword ptr [7FF9008AE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008AE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008AEC58]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF90038BC00
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
       mov       rcx,7FF90038BC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,202438097C8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF9002F5B48]
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
       test      byte ptr [7FF90038BC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,202438097C8
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
       call      qword ptr [7FF900904B10]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900904B10]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsGuid()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,154F000AA40
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],24
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,19581F54768
       call      qword ptr [7FF9003BF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,24
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
       call      qword ptr [7FF9008CE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008CE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008CEC70]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003ABC00
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
       mov       rcx,7FF9003ABC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,154F000B7C0
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900315B48]
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
       test      byte ptr [7FF9003ABC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,154F000B7C0
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
       call      qword ptr [7FF9008FFF18]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF9008FFF18]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv4Address()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,19AE2C0AA48
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0B
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1DB74D54768
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,0B
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
       call      qword ptr [7FF9008AE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008AE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008AEC70]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF90038BC00
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
       mov       rcx,7FF90038BC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19AE2C0B7C0
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF9002F5B48]
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
       test      byte ptr [7FF90038BC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,19AE2C0B7C0
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
       call      qword ptr [7FF900904168]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900904168]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsIPv6Address()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,2411C80AA50
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],27
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,281AE674768
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,27
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
       call      qword ptr [7FF9008AEAC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008AEAA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008AF120]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF90038BC00
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
       mov       rcx,7FF90038BC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2411C80B7C0
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF9002F5B48]
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
       test      byte ptr [7FF90038BC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,2411C80B7C0
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
       call      qword ptr [7FF900904798]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900904798]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsISBN()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,24002408A60
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],0D
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,280941D4768
       call      qword ptr [7FF9003CF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,0D
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
       call      qword ptr [7FF9008DE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008DE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008DEC58]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003BBC00
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
       mov       rcx,7FF9003BBC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,240024097C8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900325B48]
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
       test      byte ptr [7FF9003BBC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,240024097C8
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
       call      qword ptr [7FF900944408]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900944408]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsMACAddress()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1435B80AA60
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
       mov       r9,183ED514768
       call      qword ptr [7FF9003CF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       call      qword ptr [7FF9008DEAC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008DEAA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008DF120]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003BBC00
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
       mov       rcx,7FF9003BBC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1435B80B7C0
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900325B48]
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
       test      byte ptr [7FF9003BBC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,1435B80B7C0
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
       call      qword ptr [7FF900934798]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900934798]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsScientific()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1BCBD008A90
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],8
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1FD4AE84768
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,8
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
       call      qword ptr [7FF9008AEAC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008AEAA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008AF108]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF90038BC00
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
       mov       rcx,7FF90038BC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BCBD0097C8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF9002F5B48]
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
       test      byte ptr [7FF90038BC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,1BCBD0097C8
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
       call      qword ptr [7FF900904798]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900904798]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsSHA1Hash()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1A88FC08A98
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],28
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1E921C84768
       call      qword ptr [7FF9003CF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,28
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
       call      qword ptr [7FF9008DEAC0]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008DEAA8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008DF120]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003BBC00
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
       mov       rcx,7FF9003BBC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A88FC097C8
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900325B48]
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
       test      byte ptr [7FF9003BBC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,1A88FC097C8
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
       call      qword ptr [7FF900934B70]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900934B70]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrl()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,2A2AFC0AAB0
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],15
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,2E341AC4768
       call      qword ptr [7FF9003BF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,15
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
       call      qword ptr [7FF9008CE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008CE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008CEC70]
M01_L02:
       jmp       near ptr M01_L12
M01_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       rcx,7FF9003ABC00
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
       mov       rcx,7FF9003ABC00
       mov       edx,21
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A2AFC0B7C0
       mov       r12,[rcx]
       jmp       short M01_L12
M01_L07:
       mov       ecx,21
       call      qword ptr [7FF900315B48]
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
       test      byte ptr [7FF9003ABC51],1
       je        near ptr M01_L04
M01_L11:
       mov       rdx,2A2AFC0B7C0
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
       call      qword ptr [7FF900925C08]
       int       3
M01_L14:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900925C08]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsUrlDomainAddress()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,18800402AD0
       mov       rcx,[rcx]
       test      byte ptr [rcx+40],40
       jne       short M00_L01
       xor       esi,esi
M00_L00:
       xor       edx,edx
       mov       [rsp+20],edx
       mov       dword ptr [rsp+28],15
       mov       [rsp+30],esi
       mov       r8d,0FFFFFFFF
       mov       r9,1C88A324768
       call      qword ptr [7FF90039F888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
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
       mov       esi,15
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
       call      qword ptr [7FF9008AE610]; System.Text.RegularExpressions.RegexRunner.InitializeTimeout(System.TimeSpan)
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
       call      qword ptr [7FF9008AE5F8]; System.Text.RegularExpressions.RegexRunner.InitializeForScan(System.Text.RegularExpressions.Regex, System.ReadOnlySpan`1<Char>, Int32, System.Text.RegularExpressions.RegexRunnerMode)
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
       call      qword ptr [7FF9008AEC70]
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
       mov       rdx,188004037E8
       mov       r12,[rdx]
       jmp       short M01_L10
M01_L06:
       mov       ecx,21
       call      qword ptr [7FF9002F5B48]
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
       mov       rdx,188004037E8
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
       call      qword ptr [7FF900905368]
       int       3
M01_L12:
       mov       ecx,8
       mov       edx,2
       call      qword ptr [7FF900905368]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.IsValidString()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       call      qword ptr [7FF90050C228]; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
       test      rax,rax
       je        short M00_L01
       mov       rcx,25433C0AAA0
       mov       rcx,[rcx]
       mov       rdx,rax
       call      qword ptr [7FF9003CFAF8]; System.Text.RegularExpressions.Regex.IsMatch(System.String)
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
       call      qword ptr [7FF90050C0D8]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,25433C0A2E8
       mov       r8,[r8]
       mov       rdx,294C59C4768
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
       call      qword ptr [7FF9003CF888]; System.Text.RegularExpressions.Regex.RunSingleMatch(System.Text.RegularExpressions.RegexRunnerMode, Int32, System.String, Int32, Int32, Int32)
       test      rax,rax
       sete      al
       movzx     eax,al
       add       rsp,40
       pop       rbx
       ret
M02_L01:
       mov       ecx,7
       call      qword ptr [7FF900934E58]
       int       3
M02_L02:
       mov       r9,rdx
       mov       ebx,[r9+8]
       jmp       short M02_L00
; Total bytes of code 90
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveHtml()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,2463E80AA78
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       edi,11
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF9003CF858]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,286D0680008
       call      qword ptr [7FF9008DEA60]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,286D0694768
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FF9008DEAC0]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
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
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9000DD098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
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
       call      qword ptr [7FF9008DF000]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF9000DD0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF90093CC00]
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
       call      qword ptr [7FF9000D5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r10,286D0680008
M03_L00:
       mov       [rsp+50],eax
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FF9008DEAD8]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M03_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FF9008DEAF0]
M03_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FF90093CB28]
       int       3
M03_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF90093CB28]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.RemoveSpecialChar()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,2C8C540AA80
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       mov       edi,0D
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF9003AF858]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,309573D0008
       call      qword ptr [7FF9008BE400]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,309573E4740
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FF9008BE460]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
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
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9000BD098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
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
       call      qword ptr [7FF9008BE9A0]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF9000BD0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF90091CD98]
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
       call      qword ptr [7FF9000B5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r10,309573D0008
M03_L00:
       mov       [rsp+50],eax
       mov       rcx,rdx
       mov       rdx,r8
       mov       r8,r10
       add       rsp,28
       jmp       qword ptr [7FF9008BE478]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M03_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FF9008BE490]
M03_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FF90091CCC0]
       int       3
M03_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF90091CCC0]
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.RegularExpressions.RegexProcessorBenchmark.ReplaceCrLf()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,22103C08A78
       mov       rsi,[rcx]
       test      byte ptr [rsi+40],40
       je        near ptr M00_L01
       mov       edi,0C
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9003AF858]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rsi+20]
       mov       [rsp+20],r8
       mov       r8d,[rsi+40]
       mov       [rsp+28],r8d
       mov       r8,[rsi+18]
       mov       r9d,[rsi+44]
       mov       rdx,26195C10008
       call      qword ptr [7FF9008BEA60]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],edi
       mov       rdx,rsi
       mov       r8,26195C24768
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FF9008BEAC0]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
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
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9000BD098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
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
       call      qword ptr [7FF9008BF000]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF9000BD0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M02_L01
M02_L03:
       xor       r14d,r14d
       jmp       short M02_L00
M02_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF90090D278]
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
       call      qword ptr [7FF9000B5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9008BEAF0]; System.Text.RegularExpressions.RegexReplacement.ReplaceNonSimpleText(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
M03_L01:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FF90090D1A0]
       int       3
M03_L02:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF90090D1A0]
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
       mov       r10,26195C10008
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
       jmp       qword ptr [7FF9008BEAD8]
M03_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 160
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9004DC228]; DotNetTips.Spargine.Tester.Properties.Resources.get_LongTestString()
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L03
       mov       rcx,25C5B00AA98
       mov       rdi,[rcx]
       mov       rbp,rsi
       test      byte ptr [rdi+40],40
       jne       short M00_L00
       xor       r14d,r14d
       jmp       short M00_L01
M00_L00:
       mov       rbp,rsi
       mov       r14d,[rbp+8]
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF90039F858]; System.Text.RegularExpressions.Regex.get_RegexReplacementWeakReference()
       mov       rcx,rax
       mov       r8,[rdi+20]
       mov       [rsp+20],r8
       mov       r8d,[rdi+40]
       mov       [rsp+28],r8d
       mov       r8,[rdi+18]
       mov       r9d,[rdi+44]
       mov       rdx,29CECE42AE0
       call      qword ptr [7FF9008AEA60]; System.Text.RegularExpressions.RegexReplacement.GetOrCreate(System.WeakReference`1<System.Text.RegularExpressions.RegexReplacement>, System.String, System.Collections.Hashtable, Int32, System.Collections.Hashtable, System.Text.RegularExpressions.RegexOptions)
       mov       rcx,rax
       mov       [rsp+20],r14d
       mov       rdx,rdi
       mov       r8,rbp
       mov       r9d,0FFFFFFFF
       cmp       [rcx],ecx
       call      qword ptr [7FF9008AEAC0]; System.Text.RegularExpressions.RegexReplacement.Replace(System.Text.RegularExpressions.Regex, System.String, Int32, Int32)
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
       call      qword ptr [7FF9004DC0D8]; DotNetTips.Spargine.Tester.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       r8,25C5B00A2E8
       mov       r8,[r8]
       mov       rdx,29CECE54768
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
       mov       rcx,offset MT_System.WeakReference<System.Text.RegularExpressions.RegexReplacement>
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9000AD098]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].Create(System.__Canon, Boolean)
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
       je        short M03_L03
       test      al,2
       jne       short M03_L04
       mov       r14,[rax]
M03_L00:
       test      r14,r14
       je        short M03_L02
       mov       r15,[r14+18]
       cmp       [r15],r15b
       cmp       r15,rsi
       jne       short M03_L05
M03_L01:
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
M03_L02:
       mov       r13,[rsp+90]
       mov       [rsp+20],r13
       mov       rcx,rsi
       mov       edx,[rsp+98]
       mov       r8,rdi
       mov       r9d,ebp
       call      qword ptr [7FF9008AF000]; System.Text.RegularExpressions.RegexParser.ParseReplacement(System.String, System.Text.RegularExpressions.RegexOptions, System.Collections.Hashtable, Int32, System.Collections.Hashtable)
       mov       r14,rax
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF9000AD0B0]; System.WeakReference`1[[System.__Canon, System.Private.CoreLib]].SetTarget(System.__Canon)
       jmp       short M03_L01
M03_L03:
       xor       r14d,r14d
       jmp       short M03_L00
M03_L04:
       and       rax,0FFFFFFFFFFFFFFFC
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF90090C360]
       mov       r14,rax
       jmp       short M03_L00
M03_L05:
       test      rsi,rsi
       je        short M03_L02
       mov       r8d,[r15+8]
       cmp       r8d,[rsi+8]
       jne       short M03_L02
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9000A5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M03_L01
       jmp       short M03_L02
; Total bytes of code 201
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
       jmp       qword ptr [7FF9008AEAD8]; System.Text.RegularExpressions.RegexReplacement.ReplaceSimpleText(System.Text.RegularExpressions.Regex, System.String, System.String, Int32, Int32)
M04_L01:
       mov       [rsp+50],eax
       add       rsp,28
       jmp       qword ptr [7FF9008AEAF0]
M04_L02:
       mov       ecx,3
       mov       edx,1
       call      qword ptr [7FF90090C288]
       int       3
M04_L03:
       mov       ecx,0E
       xor       edx,edx
       call      qword ptr [7FF90090C288]
       int       3
M04_L04:
       mov       rax,r8
       add       rsp,28
       ret
M04_L05:
       mov       r10,29CECE40008
       jmp       short M04_L00
M04_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 156
```

