## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FFE6249CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61AF0A40
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61AF0A38
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F5C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D5E9808C00
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2167B714A38
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
       call      qword ptr [7FFE623FE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE623FDD40]
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
       call      qword ptr [7FFE623FDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2FF77214A38
       mov       [rsp+20],r8
       mov       r8,2BEE9401E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,5
       call      qword ptr [7FFE62544930]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 99
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
       call      qword ptr [7FFE625449A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62551008
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,2BEE5409DE0
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
       mov       rdx,7FFE620D0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6241EC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rcx,[rcx+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2AAEDFB4A38
       mov       [rsp+20],r8
       mov       r8,26A5C001E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FFE62534930]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 92
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
       call      qword ptr [7FFE625349A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62541500
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,26A5C00BDD8
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
       mov       rdx,7FFE620C0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6240EC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+128]
       mov       r9,[rcx+130]
       mov       rcx,1DCC7401E58
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],edx
       mov       rdx,21D59284A38
       mov       [rsp+20],rdx
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FFE62554D50]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 94
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
       call      qword ptr [7FFE62554F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62561CA0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1DCC740BDD8
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
       mov       rdx,7FFE620E0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6242EC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,26EB9BE4A38
       mov       [rsp+20],r8
       mov       r8,22E27C01E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,2
       call      qword ptr [7FFE625348A0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 99
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
       call      qword ptr [7FFE62534918]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62521CA0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,22E2FC09DE0
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
       mov       rdx,7FFE620B0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6248E958]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2A8E06D4A38
       mov       [rsp+20],r8
       mov       r8,2684E801E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       xor       edx,edx
       call      qword ptr [7FFE62534930]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFE625349A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62541500
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,2684E80BDD8
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
       mov       rdx,7FFE620C0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE6240EC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2F387AE4A38
       mov       [rsp+20],r8
       mov       r8,2B2F9C01E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,3
       call      qword ptr [7FFE62514EA0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
       nop
       add       rsp,48
       ret
; Total bytes of code 99
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
       call      qword ptr [7FFE62514F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62521CA0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,2B2F5C09DE0
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
       mov       rdx,7FFE620A0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE623EEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+128]
       mov       rsi,[rcx+130]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,5
       call      qword ptr [7FFE624ACA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFE61B00A40
       mov       edx,5
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61B00A38
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F6C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D0C680ABE8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,211585B4A38
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
       call      qword ptr [7FFE6240E880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE6240DD40]
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
       call      qword ptr [7FFE6240DCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,17B40824A38
       mov       r9,17B40824A70
       jmp       qword ptr [7FFE62514AB0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Critical))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Critical,
;                                                                            
;                     new global::Microsoft.Extensions.Logging.EventId(911, "CRITICAL"),
;                                                                                       
;                     new __LogCriticalMessageStruct(message, methodName),
;                                                                         
;                     exception,
;                               
;                     __LogCriticalMessageStruct.Format);
;                                                        
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Critical,
;                                                                            
;                     new global::Microsoft.Extensions.Logging.EventId(911, "CRITICAL"),
;                                                                                       
;                     new __LogCriticalMessageStruct(message, methodName),
;                                                                         
;                     exception,
;                               
;                     __LogCriticalMessageStruct.Format);
;                                                        
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Critical,
;                                                                            
;                     new global::Microsoft.Extensions.Logging.EventId(911, "CRITICAL"),
;                                                                                       
;                     new __LogCriticalMessageStruct(message, methodName),
;                                                                         
;                     exception,
;                               
;                     __LogCriticalMessageStruct.Format);
;                                                        
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE623EE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFE623EDD40]
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
       call      qword ptr [7FFE623EDCF8]
       int       3
M01_L09:
       mov       r11,7FFE61AE0A48
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61AE0A40
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE625219D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,17B40824AD8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFE61F4C6A0
       mov       edx,0BA
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,13AAE80ADD0
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,1
       call      qword ptr [7FFE624BCA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61B10A40
       mov       edx,1
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61B10A38
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F7C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1802A008BF8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1C0BBF54A38
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
       call      qword ptr [7FFE6241E880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE6241DD40]
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
       call      qword ptr [7FFE6241DCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1C889934A38
       mov       r8,1C889934A68
       jmp       qword ptr [7FFE625544C8]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Debug))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Debug,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(200, "DEBUG"),
;                                                                                    
;                     new __LogDebugMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogDebugMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Debug,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(200, "DEBUG"),
;                                                                                    
;                     new __LogDebugMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogDebugMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Debug,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(200, "DEBUG"),
;                                                                                    
;                     new __LogDebugMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogDebugMessageStruct.Format);
;                                                     
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE624AE550]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFE624ADA10]
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
       call      qword ptr [7FFE624AD9C8]
       int       3
M01_L09:
       mov       r11,7FFE61B10A48
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B10A40
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE625419D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1C8899289A0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFE61F7C6A0
       mov       edx,0BB
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18803C08DE0
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,2E41F7B4A38
       mov       r8,2E41F7B4A68
       jmp       qword ptr [7FFE62544570]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(300, "ERROR"),
;                                                                                    
;                     new __LogErrorMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogErrorMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(300, "ERROR"),
;                                                                                    
;                     new __LogErrorMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogErrorMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(300, "ERROR"),
;                                                                                    
;                     new __LogErrorMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogErrorMessageStruct.Format);
;                                                     
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6241E880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFE6241DD40]
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
       call      qword ptr [7FFE6241DCF8]
       int       3
M01_L09:
       mov       r11,7FFE61B10A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B10A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62551238
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,2E41F7B4AC8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFE61F7C6A0
       mov       edx,0BC
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A39180ADE0
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerBenchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+128]
       mov       rsi,[rcx+130]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FFE624CCA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFE61B20A40
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61B20A38
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F8C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1785540AC00
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,1B8E3384A38
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
       call      qword ptr [7FFE6242E880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE6242DD40]
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
       call      qword ptr [7FFE6242DCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,2852DCB4A38
       mov       r9,2852DCB4A68
       jmp       qword ptr [7FFE62534AF8]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogExceptionMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogExceptionMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(500, "EXCEPTION"),
;                                                                                        
;                     new __LogExceptionMessageStruct(message, methodName),
;                                                                          
;                     exception,
;                               
;                     __LogExceptionMessageStruct.Format);
;                                                         
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(500, "EXCEPTION"),
;                                                                                        
;                     new __LogExceptionMessageStruct(message, methodName),
;                                                                          
;                     exception,
;                               
;                     __LogExceptionMessageStruct.Format);
;                                                         
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(500, "EXCEPTION"),
;                                                                                        
;                     new __LogExceptionMessageStruct(message, methodName),
;                                                                          
;                     exception,
;                               
;                     __LogExceptionMessageStruct.Format);
;                                                         
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6240E880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFE6240DD40]
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
       call      qword ptr [7FFE6240DCF8]
       int       3
M01_L09:
       mov       r11,7FFE61B00A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B00A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE625419D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,2852DCB4AD0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFE61F6C6A0
       mov       edx,0BD
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2449FC0ADE8
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,2
       call      qword ptr [7FFE6248C9D0]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61AE0A40
       mov       edx,2
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61AE0A38
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F4C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D9B140AC08
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,21A43394A38
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
       call      qword ptr [7FFE623EE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE623EDD40]
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
       call      qword ptr [7FFE623EDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1451F854A38
       mov       r8,1451F854A68
       jmp       qword ptr [7FFE625445A0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Information))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Information,
;                                                                               
;                     new global::Microsoft.Extensions.Logging.EventId(400, "INFORMATION"),
;                                                                                          
;                     new __LogInformationMessageStruct(message, methodName),
;                                                                            
;                     null,
;                          
;                     __LogInformationMessageStruct.Format);
;                                                           
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Information,
;                                                                               
;                     new global::Microsoft.Extensions.Logging.EventId(400, "INFORMATION"),
;                                                                                          
;                     new __LogInformationMessageStruct(message, methodName),
;                                                                            
;                     null,
;                          
;                     __LogInformationMessageStruct.Format);
;                                                           
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Information,
;                                                                               
;                     new global::Microsoft.Extensions.Logging.EventId(400, "INFORMATION"),
;                                                                                          
;                     new __LogInformationMessageStruct(message, methodName),
;                                                                            
;                     null,
;                          
;                     __LogInformationMessageStruct.Format);
;                                                           
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6241E880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFE6241DD40]
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
       call      qword ptr [7FFE6241DCF8]
       int       3
M01_L09:
       mov       r11,7FFE61B10A48
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B10A40
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62551238
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1451F854AD8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFE61F7C6A0
       mov       edx,0BE
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1048D80ADF0
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureErrorFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,2E7CE104A38
       mov       r9,2E7CE104A70
       jmp       qword ptr [7FFE625345B8]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(700, "SP ERROR"),
;                                                                                       
;                     new __LogStoredProcedureErrorStruct(storedProcedure, methodName),
;                                                                                      
;                     exception,
;                               
;                     __LogStoredProcedureErrorStruct.Format);
;                                                             
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(700, "SP ERROR"),
;                                                                                       
;                     new __LogStoredProcedureErrorStruct(storedProcedure, methodName),
;                                                                                      
;                     exception,
;                               
;                     __LogStoredProcedureErrorStruct.Format);
;                                                             
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(700, "SP ERROR"),
;                                                                                       
;                     new __LogStoredProcedureErrorStruct(storedProcedure, methodName),
;                                                                                      
;                     exception,
;                               
;                     __LogStoredProcedureErrorStruct.Format);
;                                                             
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6240E880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFE6240DD40]
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
       call      qword ptr [7FFE6240DCF8]
       int       3
M01_L09:
       mov       r11,7FFE61B00A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B00A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62541238
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,2E7CE104AF0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFE61F6C6A0
       mov       edx,0BF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A73C40ADF8
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFoundFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,252F9494A38
       mov       r8,252F9494A70
       jmp       qword ptr [7FFE62544B40]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Error))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(701, "SP NO RECORDS ERROR"),
;                                                                                                  
;                     new __LogStoredProcedureNoRecordsFoundStruct(storedProcedure, methodName),
;                                                                                               
;                     null,
;                          
;                     __LogStoredProcedureNoRecordsFoundStruct.Format);
;                                                                      
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(701, "SP NO RECORDS ERROR"),
;                                                                                                  
;                     new __LogStoredProcedureNoRecordsFoundStruct(storedProcedure, methodName),
;                                                                                               
;                     null,
;                          
;                     __LogStoredProcedureNoRecordsFoundStruct.Format);
;                                                                      
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Error,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(701, "SP NO RECORDS ERROR"),
;                                                                                                  
;                     new __LogStoredProcedureNoRecordsFoundStruct(storedProcedure, methodName),
;                                                                                               
;                     null,
;                          
;                     __LogStoredProcedureNoRecordsFoundStruct.Format);
;                                                                      
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6241E880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFE6241DD40]
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
       call      qword ptr [7FFE6241DCF8]
       int       3
M01_L09:
       mov       r11,7FFE61B10A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B10A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE625519D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,252F9494B00
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFE61F7C6A0
       mov       edx,0C0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21267408E08
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       xor       edx,edx
       call      qword ptr [7FFE6249CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61AF0A40
       xor       edx,edx
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61AF0A38
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F5C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,26A1D80AC10
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2AAAF7A4A38
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
       call      qword ptr [7FFE623FE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE623FDD40]
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
       call      qword ptr [7FFE623FDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,20DAE824A38
       mov       r8,20DAE824A68
       jmp       qword ptr [7FFE62554558]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
;             if (logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace))
;             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Trace,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(100, "TRACE"),
;                                                                                    
;                     new __LogTraceMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogTraceMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Trace,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(100, "TRACE"),
;                                                                                    
;                     new __LogTraceMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogTraceMessageStruct.Format);
;                                                     
;                 logger.Log(
;                 ^^^^^^^^^^^
;                     global::Microsoft.Extensions.Logging.LogLevel.Trace,
;                                                                         
;                     new global::Microsoft.Extensions.Logging.EventId(100, "TRACE"),
;                                                                                    
;                     new __LogTraceMessageStruct(message, methodName),
;                                                                      
;                     null,
;                          
;                     __LogTraceMessageStruct.Format);
;                                                     
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
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
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
       call      qword ptr [7FFE6242E550]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFE6242DA10]
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
       call      qword ptr [7FFE6242D9C8]
       int       3
M01_L09:
       mov       r11,7FFE61B20A50
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFE61B20A48
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FFE62560638
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,20DAE824AC8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFE61F8C6A0
       mov       edx,0C1
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CD1C80AE08
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,3
       call      qword ptr [7FFE624AC5A8]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61B00A40
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61B00A38
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F6C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1B3F9C0AC18
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1F48BB94A38
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
       call      qword ptr [7FFE6240E880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE6240DD40]
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
       call      qword ptr [7FFE6240DCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerExtensionsBenchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+128]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger<DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark>
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,3
       call      qword ptr [7FFE624AC9D0]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFE61B00A48
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFE61B00A40
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFE61F6C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1C2BE008C20
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2034FF44A38
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
       call      qword ptr [7FFE6240E550]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFE6240DA10]
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
       call      qword ptr [7FFE6240D9C8]
       int       3
; Total bytes of code 166
```

