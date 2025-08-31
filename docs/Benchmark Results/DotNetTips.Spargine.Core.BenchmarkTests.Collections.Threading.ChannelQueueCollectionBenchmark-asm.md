## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A44738]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A442A0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A66DD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF8FFFFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A44528]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A44900]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A44900]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002BCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002BC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A66DF0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002BC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A76328]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A75E90]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A9C768]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A76118]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A764F0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A764F0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A9C780]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A45E18]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A45980]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A6C2E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF8FFFFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A45C08]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A45FE0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A45FE0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002BCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002BC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A6C300]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002BC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A76328]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A75E90]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A9C720]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A76118]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A764F0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A764F0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A9C738]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A66178]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A65CE0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A8C600]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90001D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A65F68]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A66340]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A66340]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002DCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002DC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A8C618]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002DC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A76328]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A75E90]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A9CBB8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A76118]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A764F0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A764F0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A9CBD0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900BBCA38]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900BBC5A0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900BFEDD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900BBC828]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A86550]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A86550]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900BFEDF0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteReadAsync()
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900C6C378]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900C67E58]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900CAE790]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteReadAsync>d__6 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900C6C168]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteReadAsync>d__6.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A957B8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A957B8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900CAE7A8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A641F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A3FF00]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A84240]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90001D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A640C0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A643C0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A643C0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002DCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002DC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A84258]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002DC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A65BF0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A65980]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A85B78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90001D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A65AB8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A65DB8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A65DB8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002DCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002DC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A85B90]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002DC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A65A40]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A657D0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A85B18]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90001D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A65908]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A65C08]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A65C08]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002DCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002DC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A85B30]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002DC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A55BF0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A55980]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A75B78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90000D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A55AB8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A55DB8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A55DB8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002CCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002CC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A75B90]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002CC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A55BF0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A55980]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A75B78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90000D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A55AB8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A55DB8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A55DB8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002CCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002CC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A75B90]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002CC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900A55BF0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900A55980]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900A75B78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90000D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900A55AB8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A55DB8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A55DB8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002CCB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002CC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900A75B90]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002CC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900B741F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900B4FF00]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900BA4240]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900B740C0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900B743C0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900B743C0]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900BA4258]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.19 (8.0.1925.36514), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ChannelQueueWriteAsync()
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF900C77948]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF900C776D8]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       sub       rsp,28
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       xor       edx,edx
       call      qword ptr [7FF900CA7708]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<ChannelQueueWriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],3
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF90002D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF900C77810]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ChannelQueueWriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M02_L05
M02_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L03
       call      qword ptr [7FF900A957B8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M02_L00
M02_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M02_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M02_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M02_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M02_L07
       call      qword ptr [7FF900A957B8]
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
; Total bytes of code 254
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9002ECB28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF9002EC2E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF900CA7720]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9002EC768]
       jmp       short M03_L02
; Total bytes of code 139
```

