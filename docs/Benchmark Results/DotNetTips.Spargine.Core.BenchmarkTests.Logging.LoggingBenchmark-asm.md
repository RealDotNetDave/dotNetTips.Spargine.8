## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C067878]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B720AB8
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B720AB0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB27948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,20734002BC8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,247BDFC4678
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
       call      qword ptr [7FFF4C0840F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFCF5A0]
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
       call      qword ptr [7FFF4BFCF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       r8,2DC73A74678
       mov       [rsp+20],r8
       mov       r8,29BEDC03F30
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,5
       call      qword ptr [7FFF4C104BE8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C104C60]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,29BEDC03BF8
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
       mov       rdx,7FFF4BC6AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C0847E0]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rcx,[rcx+128]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2FC3BBC4678
       mov       [rsp+20],r8
       mov       r8,2BBA9C07F20
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       edx,1
       xor       r9d,r9d
       call      qword ptr [7FFF4C0F4588]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C0F4600]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,2BBA9C07BE8
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
       mov       rdx,7FFF4BC5AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C0747E0]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorILoggerBenchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r8,[rcx+128]
       mov       r9,[rcx+130]
       mov       rcx,1DC4C007F20
       mov       rcx,[rcx]
       xor       edx,edx
       mov       [rsp+38],rdx
       mov       [rsp+40],edx
       mov       rdx,21CDDDE4678
       mov       [rsp+20],rdx
       mov       [rsp+28],rcx
       mov       rcx,r8
       lea       r8,[rsp+38]
       mov       edx,4
       call      qword ptr [7FFF4C104288]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C104450]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1DC4C007BE8
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
       mov       rdx,7FFF4BC6AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C084600]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       r8,28E5C7C4678
       mov       [rsp+20],r8
       mov       r8,24DD6803F30
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,2
       call      qword ptr [7FFF4C124EA0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C124F18]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,24DD6803BF8
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
       mov       rdx,7FFF4BC8AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C0A4F30]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       r8,1E4FAE64678
       mov       [rsp+20],r8
       mov       r8,1A469007F20
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       xor       edx,edx
       call      qword ptr [7FFF4C1043F0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C104468]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1A469007BE8
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
       mov       rdx,7FFF4BC6AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C0844F8]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
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
       mov       r8,2629AFD4628
       mov       [rsp+20],r8
       mov       r8,22209007F20
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+130]
       mov       edx,3
       call      qword ptr [7FFF4C104588]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFF4C104600]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,22209007BE8
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
       mov       rdx,7FFF4BC6AF88
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF4C0847E0]
       int       3
; Total bytes of code 214
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C0CF1F0]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFF4B740B88
       mov       edx,5
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B740B80
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB47948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,16C03406BA8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,1AC954F46C8
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
       call      qword ptr [7FFF4C0D5818]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4C0D4CD8]
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
       call      qword ptr [7FFF4C0D4C90]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCriticalFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,2827F354678
       mov       r9,2827F3546B0
       jmp       qword ptr [7FFF4C124AB0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FFF4C0A4B28]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,5
       call      qword ptr [7FFF4BFEFAE0]
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
       call      qword ptr [7FFF4BFEFA98]
       int       3
M01_L09:
       mov       r11,7FFF4B740AC0
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B740AB8
       mov       edx,5
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,2827F354718
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],38F
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFF4BB47948
       mov       edx,0AE
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,241F9402D58
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C087878]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B740AB8
       mov       edx,1
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B740AB0
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB47948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,26D4DC04BB8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2ADDFC04678
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
       call      qword ptr [7FFF4C0A40F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFEF5A0]
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
       call      qword ptr [7FFF4BFEF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebugFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,180B0444678
       mov       r8,180B04446A8
       jmp       qword ptr [7FFF4C0F41B0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FFF4C0743D8]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,1
       call      qword ptr [7FFF4BFBF768]
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
       call      qword ptr [7FFF4BFBF720]
       int       3
M01_L09:
       mov       r11,7FFF4B710AC0
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B710AB8
       mov       edx,1
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,180B0438818
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],0C8
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFF4BB17948
       mov       edx,0AF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1401E406D50
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogErrorFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,1E7307C4678
       mov       r8,1E7307C46A8
       jmp       qword ptr [7FFF4C0F4030]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FFF4C0740F0]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFF4BFBF5A0]
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
       call      qword ptr [7FFF4BFBF558]
       int       3
M01_L09:
       mov       r11,7FFF4B710AC0
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B710AB8
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,1E7307C4708
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],12C
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFF4BB17948
       mov       edx,0B0
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A69E806D58
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C077930]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FFF4B730AB8
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B730AB0
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB37948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2087A002BD0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,249041B4678
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
       call      qword ptr [7FFF4C0940F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFDF5A0]
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
       call      qword ptr [7FFF4BFDF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogExceptionFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,251382C4678
       mov       r9,251382C46A8
       jmp       qword ptr [7FFF4C0F4048]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogExceptionMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FFF4C0741F8]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFF4BFBF678]
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
       call      qword ptr [7FFF4BFBF630]
       int       3
M01_L09:
       mov       r11,7FFF4B710AC0
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B710AB8
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogExceptionMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogExceptionMessageStruct, System.Exception, System.Func`3<__LogExceptionMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,251382C4710
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1F4
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFF4BB17948
       mov       edx,0B1
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,210A6404D68
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C067930]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B720AB8
       mov       edx,2
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B720AB0
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB27948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21701C06BC8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2578B9C4678
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
       call      qword ptr [7FFF4C0840F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFCF5A0]
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
       call      qword ptr [7FFF4BFCF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformationFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,21A25144678
       mov       r8,21A251446A8
       jmp       qword ptr [7FFF4C0F4060]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FFF4C0740F0]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,2
       call      qword ptr [7FFF4BFBF5A0]
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
       call      qword ptr [7FFF4BFBF558]
       int       3
M01_L09:
       mov       r11,7FFF4B710AC0
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B710AB8
       mov       edx,2
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,21A25144718
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],190
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFF4BB17948
       mov       edx,0B2
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D99B002D78
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureErrorFastLoggerExtensionsBenchmark()
       mov       r8,rcx
       mov       rcx,[r8+128]
       mov       r8,[r8+130]
       mov       rdx,2985B914678
       mov       r9,2985B9146B0
       jmp       qword ptr [7FFF4C0CFD68]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
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
       call      qword ptr [7FFF4C0741F8]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r12]
       lea       r8,[rsp+50]
       mov       ecx,4
       call      qword ptr [7FFF4BFBF678]
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
       call      qword ptr [7FFF4BFBF630]
       int       3
M01_L09:
       mov       r11,7FFF4B710AC0
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B710AB8
       mov       edx,4
       call      qword ptr [r11]
       mov       r12d,eax
       test      r12d,r12d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r15,rax
       mov       rcx,2985B914730
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],2BC
       mov       [rsp+30],rsi
       mov       [rsp+38],rbp
       mov       rcx,7FFF4BB17948
       mov       edx,0B3
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,257D1C02D80
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFoundFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,25428294678
       mov       r8,254282946B0
       jmp       qword ptr [7FFF4C124090]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FFF4C0A41F8]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       mov       ecx,4
       call      qword ptr [7FFF4BFEF678]
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
       call      qword ptr [7FFF4BFEF630]
       int       3
M01_L09:
       mov       r11,7FFF4B740AC8
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B740AC0
       mov       edx,4
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,25428294740
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],2BD
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFF4BB47948
       mov       edx,0B4
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21396404D80
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C067930]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B720AB8
       xor       edx,edx
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B720AB0
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB27948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,14846406BD0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,188D4444678
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
       call      qword ptr [7FFF4C0840F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFCF5A0]
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
       call      qword ptr [7FFF4BFCF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTraceFastLoggerExtensionsBenchmark()
       mov       rcx,[rcx+128]
       mov       rdx,2E9DC374678
       mov       r8,2E9DC3746A8
       jmp       qword ptr [7FFF4C0BFC18]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
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
       call      qword ptr [7FFF4C0640F0]
       test      eax,eax
       je        short M01_L07
       mov       rdx,[r13]
       lea       r8,[rsp+58]
       xor       ecx,ecx
       call      qword ptr [7FFF4BFAF5A0]
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
       call      qword ptr [7FFF4BFAF558]
       int       3
M01_L09:
       mov       r11,7FFF4B700AC0
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L03
M01_L10:
       mov       rcx,rbx
       mov       r11,7FFF4B700AB8
       xor       edx,edx
       call      qword ptr [r11]
       mov       r13d,eax
       test      r13d,r13d
       je        near ptr M01_L04
M01_L11:
       mov       rcx,rbx
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       r14,rax
       mov       rcx,2E9DC374708
       mov       [rsp+48],rcx
       mov       dword ptr [rsp+50],64
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       rcx,7FFF4BB07948
       mov       edx,0B5
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A94A406D80
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

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerBenchmark()
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
       call      qword ptr [7FFF4C077878]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B730AB8
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B730AB0
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB37948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,22BD2802BE8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,26C5C6F4678
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
       call      qword ptr [7FFF4C0940F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFDF5A0]
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
       call      qword ptr [7FFF4BFDF558]
       int       3
; Total bytes of code 166
```

## .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarningFastLoggerExtensionsBenchmark()
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
       call      qword ptr [7FFF4C047878]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FFF4B700AB8
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FFF4B700AB0
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FFF4BB07948
       mov       edx,5D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,146BB806BD8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1874D654678
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
       call      qword ptr [7FFF4C0640F0]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FFF4BFAF5A0]
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
       call      qword ptr [7FFF4BFAF558]
       int       3
; Total bytes of code 166
```

