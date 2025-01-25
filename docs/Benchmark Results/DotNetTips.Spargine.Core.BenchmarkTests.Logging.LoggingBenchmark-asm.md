## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_FastLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+118]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FF94D3E8DF0]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF94CA509B0
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA509A8
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CEAC0D8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,18661008BA0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1C6EEF83E58
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
       call      qword ptr [7FF94D35F570]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D35EA30]
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
       call      qword ptr [7FF94D35E9E8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1A71E123E58
       mov       [rsp+20],r8
       mov       r8,1668C0054A0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,5
       call      qword ptr [7FF94D43FE88]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D474018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1668C009B80
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
       mov       rdx,7FF94CFDF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D34F978]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,24253043E08
       mov       [rsp+20],r8
       mov       r8,201C10034A8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,1
       call      qword ptr [7FF94D43E958]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D43E9D0]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,201C1007B88
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
       mov       rdx,7FF94CFCF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D33ED30]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,21288C83E58
       mov       [rsp+20],r8
       mov       r8,1D1F6C054A0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,4
       call      qword ptr [7FF94D43F2B8]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D43F330]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1D1F6C09B80
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
       mov       rdx,7FF94CFDF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D34F060]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,238C9CC3E58
       mov       [rsp+20],r8
       mov       r8,1F8380054A0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,2
       call      qword ptr [7FF94D42FE88]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D464018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1F838009B80
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
       mov       rdx,7FF94CFCF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D33F978]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,22458E93E58
       mov       [rsp+20],r8
       mov       r8,1E3C70034A8
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       xor       edx,edx
       call      qword ptr [7FF94D42FE88]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D464018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1E3C7007B88
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
       mov       rdx,7FF94CFCF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D33F978]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_ILogger_Benchmark()
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+38],rax
       mov       r9,rcx
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1E676BC3E58
       mov       [rsp+20],r8
       mov       r8,1A5E4C054A0
       mov       r8,[r8]
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,3
       call      qword ptr [7FF94D44FE88]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FF94D484018]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1A5E4C09B80
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
       mov       rdx,7FF94CFEF480
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF94D35F978]
       int       3
; Total bytes of code 214
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+118]
       mov       rsi,[rcx+120]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,5
       call      qword ptr [7FF94D3B8788]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94CA209B0
       mov       edx,5
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA209A8
       mov       edx,5
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE7C0D8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1BFEE408B90
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,200803C3E58
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
       call      qword ptr [7FF94D32F570]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D32EA30]
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
       call      qword ptr [7FF94D32E9E8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_FastLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+118]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,1
       call      qword ptr [7FF94D3C8950]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF94CA309B0
       mov       edx,1
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA309A8
       mov       edx,1
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE8BFF8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,190C4008B98
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,1D151E03E58
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
       call      qword ptr [7FF94D33EC58]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D33E118]
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
       call      qword ptr [7FF94D33E0D0]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_FastLogger_Benchmark()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,[rcx+118]
       mov       rsi,[rcx+120]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,4
       call      qword ptr [7FF94D3D8A28]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       r11,7FF94CA409B0
       mov       edx,4
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA409A8
       mov       edx,4
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE9C010
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,28B3D808BA8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8,2CBCF833E58
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
       call      qword ptr [7FF94D34EC58]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D34E118]
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
       call      qword ptr [7FF94D34E0D0]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_FastLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+118]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,2
       call      qword ptr [7FF94D3A8A28]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF94CA109B0
       mov       edx,2
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA109A8
       mov       edx,2
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE6C0D8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,26BBB808BB0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,2AC4D4B3E58
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
       call      qword ptr [7FF94D31F570]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D31EA30]
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
       call      qword ptr [7FF94D31E9E8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_FastLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+118]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       xor       edx,edx
       call      qword ptr [7FF94D3B8C08]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF94CA209B0
       xor       edx,edx
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA209A8
       xor       edx,edx
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE7C0D8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,21782806BC0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,25814683E58
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
       call      qword ptr [7FF94D32F570]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D32EA30]
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
       call      qword ptr [7FF94D32E9E8]
       int       3
; Total bytes of code 166
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_FastLogger_Benchmark()
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+118]
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       short M00_L03
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       short M00_L02
       mov       edx,3
       call      qword ptr [7FF94D3D8950]; Microsoft.Extensions.Logging.Logger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)
M00_L00:
       test      eax,eax
       jne       short M00_L04
M00_L01:
       add       rsp,20
       pop       rbx
       ret
M00_L02:
       mov       r11,7FF94CA409B0
       mov       edx,3
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbx
       mov       r11,7FF94CA409A8
       mov       edx,3
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L01
M00_L04:
       mov       rcx,7FF94CE9C0D8
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,237E5808BC0
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,27877893E58
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
       call      qword ptr [7FF94D34F570]
       test      eax,eax
       je        short M01_L04
       mov       rdx,[r14]
       lea       r8,[rsp+28]
       mov       ecx,ebx
       call      qword ptr [7FF94D34EA30]
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
       call      qword ptr [7FF94D34E9E8]
       int       3
; Total bytes of code 166
```

