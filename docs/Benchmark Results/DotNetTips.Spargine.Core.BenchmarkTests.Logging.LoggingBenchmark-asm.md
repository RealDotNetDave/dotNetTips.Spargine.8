## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLogger_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+118]
       mov       r8,[r8+120]
       mov       rdx,210EBB831E0
       jmp       qword ptr [7FFDF061CCF0]; DotNetTips.Spargine.Core.Logging.FastLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogCritical(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDA07D0
       mov       edx,5
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1D059C05660
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 160
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogDebug_EasyLogger_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,2774DB631E0
       jmp       qword ptr [7FFDF064D398]; DotNetTips.Spargine.Core.Logging.FastLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogDebug(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDD07D0
       mov       edx,1
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,236BBC03670
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EasyLogger_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,19E75F031E0
       jmp       qword ptr [7FFDF061CD20]; DotNetTips.Spargine.Core.Logging.FastLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogError(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01C8070],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDA07D0
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01C87E8
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,15DE4005670
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EasyLogger_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+118]
       mov       r8,[r8+120]
       mov       rdx,2902B9C31E0
       jmp       qword ptr [7FFDF062D3C8]; DotNetTips.Spargine.Core.Logging.FastLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogException(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDB07D0
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01D8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,24F99C05678
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 160
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EasyLogger_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,2747D7531E0
       jmp       qword ptr [7FFDF064CD50]; DotNetTips.Spargine.Core.Logging.FastLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogInformation(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDD07D0
       mov       edx,2
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01F8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,233EB803688
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EasyLogger_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,26BFED731E0
       jmp       qword ptr [7FFDF061CD68]; DotNetTips.Spargine.Core.Logging.FastLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogTrace(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01C7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDA07D0
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01C8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,22B6CC05688
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 152
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EasyLogger_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,2BAC07031E0
       jmp       qword ptr [7FFDF060D410]; DotNetTips.Spargine.Core.Logging.FastLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
; Total bytes of code 23
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLogger.LogWarning(Microsoft.Extensions.Logging.ILogger, System.String)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-4],eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFD907D0
       mov       edx,3
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        short M01_L01
       nop
       mov       rcx,7FFDF01B8730
       mov       edx,55
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27A2E803698
       mov       rdx,[rdx]
       mov       [rbp-10],rdx
       mov       rcx,[rbp-10]
       mov       rdx,[rbp+10]
       mov       r8,[rbp+18]
       xor       r9d,r9d
       mov       rcx,[rcx+8]
       mov       rax,[rbp-10]
       call      qword ptr [rax+18]
       nop
       nop
M01_L01:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 155
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogCritical_EazyLoggerExtensions_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+118]
       mov       r8,[r8+120]
       mov       rdx,280B1E631E0
       mov       r9,280B1E63218
       jmp       qword ptr [7FFDF062CCF0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogCriticalMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01D7ED8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDB07D0
       mov       edx,5
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,390
       mov       r8,280B1E63288
       call      qword ptr [7FFDF062CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      qword ptr [7FFDF062CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogCriticalMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogCriticalMessageStruct, System.Exception, System.Func`3<__LogCriticalMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01D8650
       mov       edx,8A
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24020005738
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,5
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 341
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogError_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,21C6DD531E0
       mov       r8,21C6DD53210
       jmp       qword ptr [7FFDF060CD20]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogErrorMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01B7FB0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFD907D0
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,12D
       mov       r8,21C6DD53278
       call      qword ptr [7FFDF060CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF060CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogErrorMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogErrorMessageStruct, System.Exception, System.Func`3<__LogErrorMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01B8728
       mov       edx,8C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DBDC005748
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogException_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,24FB86A31E0
       mov       r8,24FB86A3210
       jmp       qword ptr [7FFDF064CD08]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01F7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDD07D0
       mov       edx,1
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,0C9
       mov       r8,24FB8698878
       call      qword ptr [7FFDF064CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF064CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogDebugMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogDebugMessageStruct, System.Exception, System.Func`3<__LogDebugMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01F8730
       mov       edx,8B
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20F26803748
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       edx,1
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogInformation_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,2D95EA231E0
       mov       r8,2D95EA23218
       jmp       qword ptr [7FFDF063CD50]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDC07D0
       mov       edx,2
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,191
       mov       r8,2D95EA23288
       call      qword ptr [7FFDF063CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF063CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogInformationMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogInformationMessageStruct, System.Exception, System.Func`3<__LogInformationMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01E8730
       mov       edx,8E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,298CCC05758
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       edx,2
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureError_EazyLoggerExtensions_Benchmark()
       mov       r8,rcx
       mov       rcx,[r8+118]
       mov       r8,[r8+120]
       mov       rdx,2934E5F31E0
       mov       r9,2934E5F3210
       jmp       qword ptr [7FFDF060CD68]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
; Total bytes of code 43
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureError(Microsoft.Extensions.Logging.ILogger, System.String, System.Exception, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFD907D0
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,1F6
       mov       r8,2934E5F3298
       call      qword ptr [7FFDF060CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+28]
       call      qword ptr [7FFDF060CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureErrorStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureErrorStruct, System.Exception, System.Func`3<__LogStoredProcedureErrorStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01B8730
       mov       edx,8F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,252BC803768
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       rdx,[rbp+20]
       mov       [rsp+20],rdx
       mov       edx,4
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 341
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogStoredProcedureNoRecordsFound_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,20D24FE31E0
       mov       r8,20D24FE3210
       jmp       qword ptr [7FFDF062CD80]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogStoredProcedureNoRecordsFound(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDB07D0
       mov       edx,4
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,25A
       mov       r8,20D24FE32A8
       call      qword ptr [7FFDF062CE10]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF062CF18]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogStoredProcedureNoRecordsFoundStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogStoredProcedureNoRecordsFoundStruct, System.Exception, System.Func`3<__LogStoredProcedureNoRecordsFoundStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01D8730
       mov       edx,90
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CC93003770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       edx,4
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogTrace_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,328B82831E0
       mov       r8,328B8283210
       jmp       qword ptr [7FFDF062D428]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogTraceMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF01D7F60],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDB07D0
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,65
       mov       r8,328B8283278
       call      qword ptr [7FFDF062D4A0]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF062D5A8]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogTraceMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogTraceMessageStruct, System.Exception, System.Func`3<__LogTraceMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF01D86D8
       mov       edx,91
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2E826405770
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       xor       edx,edx
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 329
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingBenchmark.LogWarning_EazyLoggerExtensions_Benchmark()
       mov       rcx,[rcx+118]
       mov       rdx,2FDA62931E0
       mov       r8,2FDA6293210
       jmp       qword ptr [7FFDF061D440]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
; Total bytes of code 33
```
```assembly
; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogWarningMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       push      rbp
       sub       rsp,0A0
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FFDF0140860],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       rcx,[rbp+10]
       mov       r11,7FFDEFDA07D0
       mov       edx,3
       call      qword ptr [r11]
       mov       [rbp-8],eax
       mov       ecx,[rbp-8]
       movzx     ecx,cl
       mov       [rbp-4],ecx
       cmp       dword ptr [rbp-4],0
       je        near ptr M01_L02
       nop
       lea       rcx,[rbp-18]
       mov       edx,259
       mov       r8,2FDA6293278
       call      qword ptr [7FFDF061D4A0]
       vmovdqu   xmm0,xmmword ptr [rbp-18]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       lea       rcx,[rbp-28]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FFDF061D5A8]
       mov       rcx,[rbp+10]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.ILogger
       mov       r8,offset MD_Microsoft.Extensions.Logging.ILogger.Log[[DotNetTips.Spargine.Core.Logging.FastLoggerExtensions+__LogWarningMessageStruct, DotNetTips.Spargine.8.Core]](Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, __LogWarningMessageStruct, System.Exception, System.Func`3<__LogWarningMessageStruct,System.Exception,System.String>)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-40],rax
       mov       rcx,[rbp+10]
       mov       [rbp-70],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-38]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmm0,xmmword ptr [rbp-28]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       rcx,7FFDF0141DD0
       mov       edx,92
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2BD18405778
       mov       rcx,[rcx]
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       mov       [rsp+28],rcx
       mov       rcx,[rbp-70]
       lea       r8,[rbp-50]
       lea       r9,[rbp-60]
       mov       edx,3
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,[rbp-40]
       call      rax
       nop
       nop
M01_L02:
       nop
       add       rsp,0A0
       pop       rbp
       ret
; Total bytes of code 335
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       r8,32FB6E431E0
       mov       [rsp+20],r8
       mov       r8,32FB6E3C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,5
       call      qword ptr [7FFDF062D0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF062D158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,2EF29000130
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
       mov       rdx,7FFDF030A190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05C7048]
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
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2107C6531E0
       mov       [rsp+20],r8
       mov       r8,2107C64C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,1
       call      qword ptr [7FFDF064D770]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF064D7E8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1CFEA800130
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
       mov       rdx,7FFDF032A190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05E7048]
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
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,2E5429F31E0
       mov       [rsp+20],r8
       mov       r8,2E5429EC798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,4
       call      qword ptr [7FFDF064D0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF064D158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,2A4B2C00130
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
       mov       rdx,7FFDF032A190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05E7048]
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
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,30019EB31E0
       mov       [rsp+20],r8
       mov       r8,30019EAC798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,2
       call      qword ptr [7FFDF063D0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF063D158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,2BF88006100
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
       mov       rdx,7FFDF031A190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05D7048]
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
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,1FFE99131E0
       mov       [rsp+20],r8
       mov       r8,1FFE990C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       xor       edx,edx
       call      qword ptr [7FFDF061D0E0]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF061D158]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,1BF5FC00130
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
       mov       rdx,7FFDF02FA190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05B7048]
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
       mov       rcx,[r9+118]
       xor       r8d,r8d
       mov       [rsp+38],r8
       mov       dword ptr [rsp+40],64
       mov       r8,291361831E0
       mov       [rsp+20],r8
       mov       r8,2913617C798
       mov       [rsp+28],r8
       lea       r8,[rsp+38]
       mov       r9,[r9+120]
       mov       edx,3
       call      qword ptr [7FFDF062D770]; Microsoft.Extensions.Logging.LoggerExtensions.Log(Microsoft.Extensions.Logging.ILogger, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, System.String, System.Object[])
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
       call      qword ptr [7FFDF062D7E8]; Microsoft.Extensions.Logging.FormattedLogValues..ctor(System.String, System.Object[])
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
       mov       r9,250A4406100
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
       mov       rdx,7FFDF030A190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFDF05C7048]
       int       3
; Total bytes of code 214
```
