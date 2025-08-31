## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90087CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFED0A48
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A40
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90033C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2247C00ABF8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2650DD94A38
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
       call      qword ptr [7FF90086E550]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF90086DA10]
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
       call      qword ptr [7FF90086D9C8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       r8,1DCB0CF4A38
       mov       [rsp+20],r8
       mov       r8,19C1F001E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,5
       call      qword ptr [7FF9008E4930]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9008E49A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9008F09F8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,19C1F00BDD8
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
       mov       rdx,7FF900470000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007BEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rcx,[rcx+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,21A4EFE4A38
       mov       [rsp+20],r8
       mov       r8,1D9BD001E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FF900914EA0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF900914F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900921CA0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1D9C5003E00
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
       mov       rdx,7FF9004A0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007EEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+128]
       mov       r9,[rcx+130]
       mov       rcx,1F2E7801E58
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],edx
       mov       rdx,233755B4A38
       mov       [rsp+20],rdx
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FF9009147E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9009149A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900921500
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1F2E3809DE0
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
       mov       rdx,7FF9004A0000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007EEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       r8,1D269904A38
       mov       [rsp+20],r8
       mov       r8,191D7801E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,2
       call      qword ptr [7FF900904EA0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF900904F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900911480
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,191D780BDD8
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
       mov       rdx,7FF900490000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007DEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       r8,2E69A564A38
       mov       [rsp+20],r8
       mov       r8,2A608401E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       xor       edx,edx
       call      qword ptr [7FF9008E4EA0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9008E4F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9008F1CA0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,2A60840BDD8
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
       mov       rdx,7FF900470000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007BEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       mov       r8,1E29AD54A38
       mov       [rsp+20],r8
       mov       r8,1A209001E58
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,3
       call      qword ptr [7FF900904930]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF9009049A8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
       mov       rcx,rsi
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900911500
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       vmovdqu   xmm0,xmmword ptr [rsp+50]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       mov       r9,[rsp+60]
       mov       [rsp+48],r9
       mov       [rsp+20],rdi
       mov       r9,1A20900BDD8
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
       mov       rdx,7FF900490000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9007DEC88]
       int       3
; Total bytes of code 214
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90087CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF8FFED0A48
       mov       edx,5
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A40
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90033C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AEEA002C10
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,1EF73D64A38
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
       call      qword ptr [7FF9007DE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007DDD40]
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
       call      qword ptr [7FF9007DDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,288883C4A38
       mov       r9,288883C4A70
       jmp       qword ptr [7FF900904540]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FF9007DE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FF9007DDD40]
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
       call      qword ptr [7FF9007DDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFED0A50
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A48
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900911238
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,288883C4AD8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FF90033C6A0
       mov       edx,0BA
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,247F640ADD0
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90086CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFEC0A40
       mov       edx,1
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A38
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90032C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1865BC0ABF0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1C6ED984A38
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
       call      qword ptr [7FF9007CE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007CDD40]
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
       call      qword ptr [7FF9007CDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,2CD72C74A38
       mov       r8,2CD72C74A68
       jmp       qword ptr [7FF9009244C8]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FF90087E550]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FF90087DA10]
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
       call      qword ptr [7FF90087D9C8]
       int       3
M01_L09:
       mov       r11,7FF8FFEE0A48
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEE0A40
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9009119D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,2CD72C689A0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FF90034C6A0
       mov       edx,0BB
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28CE0C0ADD8
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,246F1294A38
       mov       r8,246F1294A68
       jmp       qword ptr [7FF9008E4570]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FF9007BE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FF9007BDD40]
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
       call      qword ptr [7FF9007BDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFEB0A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEB0A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9008F0AC0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,246F1294AC8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FF90031C6A0
       mov       edx,0BC
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20667402E08
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90087CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF8FFED0A40
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A38
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90033C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,176FE80AC00
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,1B7906D4A38
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
       call      qword ptr [7FF9007DE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007DDD40]
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
       call      qword ptr [7FF9007DDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,1597AF74A10
       mov       r9,1597AF74A40
       jmp       qword ptr [7FF9008F4948]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogExceptionMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FF9007CE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FF9007CDD40]
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
       call      qword ptr [7FF9007CDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFEC0A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9009009D0
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,1597AF74AA8
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FF90032C6A0
       mov       edx,0BD
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,118F1002E10
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90086C9D0]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFEC0A48
       mov       edx,2
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A40
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90032C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,25B7280AC08
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,29C04804A38
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
       call      qword ptr [7FF9007CE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007CDD40]
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
       call      qword ptr [7FF9007CDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1FC4F4B4A38
       mov       r8,1FC4F4B4A68
       jmp       qword ptr [7FF9009045A0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FF9007DE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FF9007DDD40]
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
       call      qword ptr [7FF9007DDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFED0A48
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A40
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900911238
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1FC4F4B4AD8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FF90033C6A0
       mov       edx,0BE
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BBBD40ADF0
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureErrorFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,25592B24A38
       mov       r9,25592B24A70
       jmp       qword ptr [7FF9008E4B28]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FF9007BE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FF9007BDD40]
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
       call      qword ptr [7FF9007BDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFEB0A48
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEB0A40
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9008F15A8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,25592B24AF0
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FF90031C6A0
       mov       edx,0BF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21500C0ADF8
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFoundFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,21CBB0C49E8
       mov       r8,21CBB0C4A20
       jmp       qword ptr [7FF9008F4540]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FF9007CE550]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FF9007CDA10]
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
       call      qword ptr [7FF9007CD9C8]
       int       3
M01_L09:
       mov       r11,7FF8FFEC0A28
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A20
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF900900118
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,21CBB0C4AB0
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FF90032C6A0
       mov       edx,0C0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DC31002E28
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90086CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFEC0A40
       xor       edx,edx
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A38
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90032C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27F8740AC10
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2C019314A38
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
       call      qword ptr [7FF9007CE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007CDD40]
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
       call      qword ptr [7FF9007CDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1B9C8C04A38
       mov       r8,1B9C8C04A68
       jmp       qword ptr [7FF900914B58]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FF9007EE880]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FF9007EDD40]
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
       call      qword ptr [7FF9007EDCF8]
       int       3
M01_L09:
       mov       r11,7FF8FFEE0A50
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FF8FFEE0A48
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,7FF9009219D8
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1B9C8C04AC8
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FF90034C6A0
       mov       edx,0C1
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,17936C0AE08
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

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90087CA70]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFED0A48
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFED0A40
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90033C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1AB7300AC18
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1EC04E04A38
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
       call      qword ptr [7FF9007DE880]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007DDD40]
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
       call      qword ptr [7FF9007DDCF8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
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
       call      qword ptr [7FF90086BF48]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF8FFEC0A40
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF8FFEC0A38
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF90032C6A0
       mov       edx,62
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21AA080AC18
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,25B32834A38
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
       call      qword ptr [7FF9007CE550]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF9007CDA10]
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
       call      qword ptr [7FF9007CD9C8]
       int       3
; Total bytes of code 166
```

