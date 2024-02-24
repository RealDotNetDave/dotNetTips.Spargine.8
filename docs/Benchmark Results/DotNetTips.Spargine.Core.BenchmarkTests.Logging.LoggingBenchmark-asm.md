## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+128]
       mov       rsi,[rcx+130]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,5
       call      qword ptr [7FFC20467660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC1FC809A8
       mov       edx,5
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC809A0
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC200987E0
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1F723805360
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,237B58231B8
       mov       rcx,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 184
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20476E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204762E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20476298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,1
       call      qword ptr [7FFC20487660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFC1FCA09B0
       mov       edx,1
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FCA09A8
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC200B87E0
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1FAF6805368
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,23B885331B8
       xor       r9d,r9d
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 174
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20496E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204962E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20496298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FFC20477660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFC1FC909A8
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC909A0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC200A8788
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,14F29005370
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,18FBAEE31B8
       xor       r9d,r9d
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 174
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20486E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204862E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20486298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+128]
       mov       rsi,[rcx+130]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FFC20457660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFC1FC709A8
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC200886F0
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,18D06005378
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,1CD97EC31B8
       mov       rcx,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax+18]
; Total bytes of code 184
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20466298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,2
       call      qword ptr [7FFC20447660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFC1FC609A8
       mov       edx,2
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC609A0
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC20078700
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1CDAD805380
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,20E3F7231B8
       xor       r9d,r9d
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 174
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20456E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204562E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20456298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       xor       edx,edx
       call      qword ptr [7FFC20457660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFC1FC709A8
       xor       edx,edx
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A0
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC20088898
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,24340C05388
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,283D29031B8
       xor       r9d,r9d
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 165
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20466298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,3
       call      qword ptr [7FFC20457660]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFC1FC709A8
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A0
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFC20088788
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21E84005390
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,25F15DF31B8
       xor       r9d,r9d
       mov       rcx,[rax+8]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+18]
; Total bytes of code 174
```
```assembly
; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebx,edx
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        short M01_L02
       xor       eax,eax
       mov       [rsp+28],rax
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jg        short M01_L03
M01_L00:
       cmp       qword ptr [rsp+28],0
       jne       short M01_L05
M01_L01:
       xor       eax,eax
       cmp       ebp,edi
       setg      al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r14,[rsi+rcx*8+10]
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L04:
       inc       edi
       cmp       ebp,edi
       jg        short M01_L03
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
M01_L05:
       mov       rcx,[rsp+28]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+28]
       call      qword ptr [7FFC20466298]
       int       3
; Total bytes of code 166
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,25EB79B31B8
       mov       r9,25EB79B31F0
       jmp       qword ptr [7FFC204CCCF0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       r14,[rcx+18]
       test      r14,r14
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M01_L08
M01_L01:
       xor       r12d,r12d
       cmp       r13d,r15d
       setg      r12b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L03:
       test      r12d,r12d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*4]
       lea       r12,[r14+rcx*8+10]
       mov       rcx,r12
       mov       edx,5
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L06
       cmp       qword ptr [rsp+50],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M01_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FFC20466298]
       int       3
M01_L09:
       mov       r11,7FFC1FC709B0
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A8
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogCriticalMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,25EB79B3260
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],390
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFC20088678
       mov       edx,8C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21E25805438
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rdi
       mov       edx,5
       call      r15
       jmp       near ptr M01_L04
; Total bytes of code 466
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,239D9BE31B8
       mov       r8,239D9BE31E8
       jmp       qword ptr [7FFC204DD3B0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       mov       edx,4
       call      qword ptr [7FFC20476E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFC204762E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20476298]
       int       3
M01_L09:
       mov       r11,7FFC1FC809B0
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC809A8
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogErrorMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,239D9BE3250
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12D
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200987E0
       mov       edx,8E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F947C05448
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 457
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,277D1B831B8
       mov       r8,277D1B831E8
       jmp       qword ptr [7FFC204CD398]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20466298]
       int       3
M01_L09:
       mov       r11,7FFC1FC709B0
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A8
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogDebugMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,277D1B78878
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C9
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200887E8
       mov       edx,8D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2373FC05440
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 457
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1E384DC31B8
       mov       r8,1E384DC31F0
       jmp       qword ptr [7FFC204BCD50]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       mov       edx,2
       call      qword ptr [7FFC20456E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFC204562E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20456298]
       int       3
M01_L09:
       mov       r11,7FFC1FC609B0
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC609A8
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogInformationMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1E384DC3260
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],191
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200787E0
       mov       edx,90
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A2F3003460
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 457
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,1FDF0DB31B8
       mov       r9,1FDF0DB31E8
       jmp       qword ptr [7FFC204DD3F8]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbp,r9
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       r14,[rcx+18]
       test      r14,r14
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+50],rcx
       xor       r15d,r15d
       mov       r13d,[r14+8]
       test      r13d,r13d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+50],0
       jne       short M01_L08
M01_L01:
       xor       r12d,r12d
       cmp       r13d,r15d
       setg      r12b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+50],rcx
M01_L03:
       test      r12d,r12d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r12d,r12d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r15d
       lea       rcx,[rcx+rcx*4]
       lea       r12,[r14+rcx*8+10]
       mov       rcx,r12
       mov       edx,4
       call      qword ptr [7FFC20476E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFC204762E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r15d
       cmp       r13d,r15d
       jg        short M01_L06
       cmp       qword ptr [rsp+50],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+50]
       cmp       dword ptr [rcx+10],0
       jle       near ptr M01_L01
       mov       rcx,[rsp+50]
       call      qword ptr [7FFC20476298]
       int       3
M01_L09:
       mov       r11,7FFC1FC809B0
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC809A8
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,1FDF0DB3270
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F6
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFC200987E0
       mov       edx,91
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BD5EC05460
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+40]
       lea       r9,[rsp+30]
       mov       [rsp+20],rdi
       mov       edx,4
       call      r15
       jmp       near ptr M01_L04
; Total bytes of code 466
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,2D0BC1A31B8
       mov       r8,2D0BC1A31E8
       jmp       qword ptr [7FFC204CCD80]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       mov       edx,4
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20466298]
       int       3
M01_L09:
       mov       r11,7FFC1FC709B0
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A8
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,2D0BC1A3280
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],25A
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200887E0
       mov       edx,92
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2902A405468
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 457
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,259104B31B8
       mov       r8,259104B31E8
       jmp       qword ptr [7FFC204CD428]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FFC20466E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFC204662E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20466298]
       int       3
M01_L09:
       mov       r11,7FFC1FC709B0
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC709A8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogTraceMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,259104B3250
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],65
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200887E0
       mov       edx,93
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2187E405470
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 442
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+128]
       mov       rdx,2147DBA31B8
       mov       r8,2147DBA31E8
       jmp       qword ptr [7FFC204BCDB0]; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L09
       mov       rbp,[rcx+18]
       test      rbp,rbp
       je        short M01_L05
       xor       ecx,ecx
       mov       [rsp+58],rcx
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jg        short M01_L06
M01_L00:
       cmp       qword ptr [rsp+58],0
       jne       short M01_L08
M01_L01:
       xor       r13d,r13d
       cmp       r15d,r14d
       setg      r13b
M01_L02:
       xor       ecx,ecx
       mov       [rsp+58],rcx
M01_L03:
       test      r13d,r13d
       jne       near ptr M01_L11
M01_L04:
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       xor       r13d,r13d
       jmp       short M01_L02
M01_L06:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rbp+rcx*8+10]
       mov       rcx,r13
       mov       edx,3
       call      qword ptr [7FFC20456E08]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,3
       call      qword ptr [7FFC204562E0]
       test      eax,eax
       jne       short M01_L00
M01_L07:
       inc       r14d
       cmp       r15d,r14d
       jg        short M01_L06
       cmp       qword ptr [rsp+58],0
       je        short M01_L01
M01_L08:
       mov       rcx,[rsp+58]
       cmp       dword ptr [rcx+10],0
       jle       short M01_L01
       mov       rcx,[rsp+58]
       call      qword ptr [7FFC20456298]
       int       3
M01_L09:
       mov       r11,7FFC1FC609B8
       mov       edx,3
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFC1FC609B0
       mov       edx,3
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.EasyLoggerExtensions+__LogWarningMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,2147DBA3250
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],259
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFC200787E0
       mov       edx,94
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D3EBC05478
       mov       rcx,[rcx]
       mov       [rsp+28],rcx
       mov       rcx,rbx
       lea       r8,[rsp+48]
       lea       r9,[rsp+38]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       call      r14
       jmp       near ptr M01_L04
; Total bytes of code 457
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2C913B731B8
       mov       [rsp+20],r8
       mov       r8,2C913B6C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,5
       call      qword ptr [7FFC204DD0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 96
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC204DD158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,28881C05DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201CA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC20477210]
       int       3
; Total bytes of code 214
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,21D9C3431B8
       mov       [rsp+20],r8
       mov       r8,21D9C33C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,1
       call      qword ptr [7FFC204BD770]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 96
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC204BD7E8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1DD0A405DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201AA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC20457210]
       int       3
; Total bytes of code 214
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2F7ED4531B8
       mov       [rsp+20],r8
       mov       r8,2F7ED44C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,4
       call      qword ptr [7FFC2050E790]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 96
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC2050E808]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,2B75B405DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201EA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC2049CF18]
       int       3
; Total bytes of code 214
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1F7B32A31B8
       mov       [rsp+20],r8
       mov       r8,1F7B329C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,2
       call      qword ptr [7FFC204DD0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 96
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC204DD158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1B721405DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201CA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC20477210]
       int       3
; Total bytes of code 214
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,264826931B8
       mov       [rsp+20],r8
       mov       r8,2648268C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       xor       edx,edx
       call      qword ptr [7FFC204EE790]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 93
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC204EE808]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,223F0805DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201BA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC2046CF18]
       int       3
; Total bytes of code 214
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,21E55A231B8
       mov       [rsp+20],r8
       mov       r8,21E55A1C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,3
       call      qword ptr [7FFC204BD770]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 96
```
```assembly
; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rsi,rcx
       mov       ebp,edx
       mov       rbx,r8
       mov       rdi,r9
       test      rsi,rsi
       je        near ptr M01_L00
       lea       rcx,[rsp+50]
       mov       rdx,[rsp+0B0]
       mov       r8,[rsp+0B8]
       call      qword ptr [7FFC204BD7E8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[Microsoft.Extensions.Logging.FormattedLogValues, Microsoft.Extensions.Logging.Abstractions]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, Microsoft.Extensions.Logging.FormattedLogValues, System.Exception, System.Func`3<Microsoft.Extensions.Logging.FormattedLogValues,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1DDC3C05DB0
       mov       r9,[r9]
       mov       [rsp+28],r9
       lea       r9,[rsp+38]
       call      rax
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       ecx,1BF
       mov       rdx,7FFC201AA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFC20457210]
       int       3
; Total bytes of code 214
```

