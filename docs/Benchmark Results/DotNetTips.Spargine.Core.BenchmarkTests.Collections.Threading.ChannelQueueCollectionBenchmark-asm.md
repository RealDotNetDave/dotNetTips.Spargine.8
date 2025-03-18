## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF98388E760]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2C341403EE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831B54E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9831B5500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982F2E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983065008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98388E2F8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A6AB80
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835DED30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A6AD08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF98388F258]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983064198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A6AE50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF98388F708]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A6AF88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98306ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838B40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF98388FE28]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9838BC660]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF98388FE28]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835F6158
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982DC7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835F6148
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L27
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L28
       cmp       qword ptr [rsp+0D0],0
       je        short M05_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M05_L23
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L09
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L29
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L35
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L36
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L37
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L09
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L48
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L38
M05_L06:
       test      edx,edx
       je        short M05_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L44
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L45
M05_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L46
M05_L08:
       dec       r13d
       jns       short M05_L05
M05_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L47
M05_L10:
       test      r14d,r14d
       je        short M05_L12
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L19
M05_L11:
       or        ebp,edi
       jne       near ptr M05_L22
M05_L12:
       mov       eax,r14d
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
M05_L13:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98306ECB8]
       int       3
M05_L14:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L15
       mov       edi,1
       jmp       short M05_L16
M05_L15:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L16
       mov       ebp,1
M05_L16:
       test      dword ptr [rdx+34],10000000
       je        short M05_L17
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A94BB8]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830BE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983064270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830BE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983065530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983065740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983065050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98306EF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FF98306ED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FF98306ED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FF983064AF8]
       test      eax,eax
       je        short M05_L31
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L32
M05_L30:
       mov       [rsp+5C],edx
       jmp       short M05_L33
M05_L31:
       xor       eax,eax
M05_L32:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L34
M05_L33:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A94BB8]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L34:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L35:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L36:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L37:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A94BB8]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FF983064AF8]
       test      eax,eax
       je        short M05_L40
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L41
M05_L39:
       mov       [rsp+5C],edx
       jmp       short M05_L42
M05_L40:
       xor       eax,eax
M05_L41:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L43
M05_L42:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A94BB8]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L43:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L44:
       mov       edi,1
       jmp       near ptr M05_L07
M05_L45:
       mov       ebp,1
       jmp       near ptr M05_L07
M05_L46:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A94BB8]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983065038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L17
M05_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1140
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835EF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E7E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982F2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF983894438]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,17D92C05EE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831954E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF983195500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982F0E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983045008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98386FF60]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A4D640
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835BEDA8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A4D7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983894F30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983044198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A4D910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838953E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A4DA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98304ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF983895D70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF983895B00]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF98389E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF983895B00]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835D4350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982DA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835D4340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L27
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L28
       cmp       qword ptr [rsp+0D0],0
       je        short M05_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M05_L23
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L09
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L29
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L35
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L36
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L37
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L09
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L48
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L38
M05_L06:
       test      edx,edx
       je        short M05_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L44
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L45
M05_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L46
M05_L08:
       dec       r13d
       jns       short M05_L05
M05_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L47
M05_L10:
       test      r14d,r14d
       je        short M05_L12
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L19
M05_L11:
       or        ebp,edi
       jne       near ptr M05_L22
M05_L12:
       mov       eax,r14d
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
M05_L13:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98304ECB8]
       int       3
M05_L14:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L15
       mov       edi,1
       jmp       short M05_L16
M05_L15:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L16
       mov       ebp,1
M05_L16:
       test      dword ptr [rdx+34],10000000
       je        short M05_L17
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A75A10]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98309E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983044270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98309E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983045530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983045740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983045050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98304EF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FF98304ED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FF98304ED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FF983044AF8]
       test      eax,eax
       je        short M05_L31
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L32
M05_L30:
       mov       [rsp+5C],edx
       jmp       short M05_L33
M05_L31:
       xor       eax,eax
M05_L32:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L34
M05_L33:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A75A10]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L34:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L35:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L36:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L37:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A75A10]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FF983044AF8]
       test      eax,eax
       je        short M05_L40
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L41
M05_L39:
       mov       [rsp+5C],edx
       jmp       short M05_L42
M05_L40:
       xor       eax,eax
M05_L41:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L43
M05_L42:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A75A10]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L43:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L44:
       mov       edi,1
       jmp       near ptr M05_L07
M05_L45:
       mov       ebp,1
       jmp       near ptr M05_L07
M05_L46:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A75A10]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983045038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L17
M05_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1140
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835CF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E5E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982F0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9838B4138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1A458403EE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831B54E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9831B5500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982F2E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983065008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98388FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F2E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A6D220
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835DED30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A6D3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9838B4C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983064198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A6D4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838B50E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A6D628
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98306ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838B5A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9838B5800]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9838BE268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF9838B5800]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835F72A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982DC7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835F7290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L27
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L28
       cmp       qword ptr [rsp+0D0],0
       je        short M05_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M05_L23
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L09
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L29
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L35
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L36
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L37
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L09
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L48
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L38
M05_L06:
       test      edx,edx
       je        short M05_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L44
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L45
M05_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L46
M05_L08:
       dec       r13d
       jns       short M05_L05
M05_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L47
M05_L10:
       test      r14d,r14d
       je        short M05_L12
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L19
M05_L11:
       or        ebp,edi
       jne       near ptr M05_L22
M05_L12:
       mov       eax,r14d
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
M05_L13:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98306ECB8]
       int       3
M05_L14:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L15
       mov       edi,1
       jmp       short M05_L16
M05_L15:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L16
       mov       ebp,1
M05_L16:
       test      dword ptr [rdx+34],10000000
       je        short M05_L17
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A95A10]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830BE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983064270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830BE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983065530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983065740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983065050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98306EF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FF98306ED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FF98306ED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FF983064AF8]
       test      eax,eax
       je        short M05_L31
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L32
M05_L30:
       mov       [rsp+5C],edx
       jmp       short M05_L33
M05_L31:
       xor       eax,eax
M05_L32:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L34
M05_L33:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A95A10]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L34:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L35:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L36:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L37:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A95A10]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FF983064AF8]
       test      eax,eax
       je        short M05_L40
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L41
M05_L39:
       mov       [rsp+5C],edx
       jmp       short M05_L42
M05_L40:
       xor       eax,eax
M05_L41:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L43
M05_L42:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A95A10]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L43:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L44:
       mov       edi,1
       jmp       near ptr M05_L07
M05_L45:
       mov       ebp,1
       jmp       near ptr M05_L07
M05_L46:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A95A10]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983065038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F2E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L17
M05_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1140
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835EF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E7E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982F2DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF983884138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       vmovsd    xmm0,qword ptr [7FF98395D878]
       call      qword ptr [7FF98314CEA0]; System.TimeSpan.IntervalFromDoubleTicks(Double)
       mov       [rsi+18],rax
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1B649803EE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831854E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF983185500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982EFE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983035008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98385FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 337
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A70CA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835AED30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A70E30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983884C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983034198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A70F78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838850E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A710B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98303ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; System.TimeSpan.IntervalFromDoubleTicks(Double)
       sub       rsp,28
       vzeroupper
       vmovsd    xmm1,qword ptr [7FF983956438]
       vucomisd  xmm0,xmm1
       ja        short M02_L01
       vmovsd    xmm2,qword ptr [7FF983956440]
       vucomisd  xmm2,xmm0
       ja        short M02_L01
       vucomisd  xmm0,xmm0
       jp        short M02_L01
       vucomisd  xmm0,xmm1
       jp        short M02_L00
       je        short M02_L02
M02_L00:
       vcvttsd2si rax,xmm0
       add       rsp,28
       ret
M02_L01:
       call      qword ptr [7FF98303EBF8]
       int       3
M02_L02:
       mov       rax,7FFFFFFFFFFFFFFF
       add       rsp,28
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF983885A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,68
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF983885800]
       jmp       short M03_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF98388E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,78
       ret
M04_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF983885800]
       jmp       short M04_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M05_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M05_L00
       mov       rcx,rax
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FF9835C6948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982D97738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FF9835C6938
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M05_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M06_L27
       cmp       esi,0FFFFFFFF
       jl        near ptr M06_L28
       cmp       qword ptr [rsp+0D0],0
       je        short M06_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M06_L23
M06_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M06_L09
       cmp       r15d,r13d
       jle       short M06_L05
M06_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L29
M06_L02:
       test      edx,edx
       je        short M06_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L35
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M06_L36
M06_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L37
M06_L04:
       dec       r13d
       jns       short M06_L01
       jmp       short M06_L09
M06_L05:
       cmp       r13d,r15d
       jae       near ptr M06_L48
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L38
M06_L06:
       test      edx,edx
       je        short M06_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L44
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M06_L45
M06_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L46
M06_L08:
       dec       r13d
       jns       short M06_L05
M06_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M06_L47
M06_L10:
       test      r14d,r14d
       je        short M06_L12
       cmp       qword ptr [rsp+60],0
       jne       near ptr M06_L19
M06_L11:
       or        ebp,edi
       jne       near ptr M06_L22
M06_L12:
       mov       eax,r14d
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
M06_L13:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98303ECB8]
       int       3
M06_L14:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M06_L15
       mov       edi,1
       jmp       short M06_L16
M06_L15:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M06_L16
       mov       ebp,1
M06_L16:
       test      dword ptr [rdx+34],10000000
       je        short M06_L17
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A65080]
M06_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98308E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L14
M06_L18:
       jmp       near ptr M06_L10
M06_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M06_L21
M06_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983034270]
       test      eax,eax
       jne       near ptr M06_L11
M06_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98308E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L20
       jmp       near ptr M06_L11
M06_L22:
       test      edi,edi
       jne       short M06_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983035530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M06_L24
M06_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983035740]
       int       3
M06_L24:
       xor       edi,edi
       jmp       short M06_L26
M06_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983035050]
       inc       edi
M06_L26:
       cmp       r15d,edi
       jg        short M06_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98303EF10]
       int       3
M06_L27:
       mov       ecx,33
       call      qword ptr [7FF98303ED00]
       int       3
M06_L28:
       mov       ecx,3C
       call      qword ptr [7FF98303ED30]
       int       3
M06_L29:
       cmp       esi,0FFFFFFFF
       jne       short M06_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L33
       mov       rcx,r12
       call      qword ptr [7FF983034AF8]
       test      eax,eax
       je        short M06_L31
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L32
M06_L30:
       mov       [rsp+5C],edx
       jmp       short M06_L33
M06_L31:
       xor       eax,eax
M06_L32:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M06_L34
M06_L33:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A65080]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L34:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L35:
       mov       edi,1
       jmp       near ptr M06_L03
M06_L36:
       mov       ebp,1
       jmp       near ptr M06_L03
M06_L37:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A65080]
       jmp       near ptr M06_L04
M06_L38:
       cmp       esi,0FFFFFFFF
       jne       short M06_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L42
       mov       rcx,r12
       call      qword ptr [7FF983034AF8]
       test      eax,eax
       je        short M06_L40
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L41
M06_L39:
       mov       [rsp+5C],edx
       jmp       short M06_L42
M06_L40:
       xor       eax,eax
M06_L41:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M06_L43
M06_L42:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A65080]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L43:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L44:
       mov       edi,1
       jmp       near ptr M06_L07
M06_L45:
       mov       ebp,1
       jmp       near ptr M06_L07
M06_L46:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A65080]
       jmp       near ptr M06_L08
M06_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983035038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M06_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L17
M06_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1140
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M07_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M07_L03
M07_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M07_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835BF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M07_L01:
       mov       ebx,eax
M07_L02:
       jmp       short M07_L06
M07_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M07_L00
       mov       ebx,0FFFFFFFF
       jmp       short M07_L02
M07_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M07_L01
M07_L05:
       call      qword ptr [7FF982E4E040]
       int       3
M07_L06:
       cmp       byte ptr [rbp-18],0
       je        short M07_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M07_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M07_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982EFDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M08_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF983884138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1FFF4C05EE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831854E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF983185500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982EFE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983035008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98385FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EFE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A3E958
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835AF198]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A3EAE0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983884C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983034198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A3EC28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838850E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A3ED60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98303ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF983885A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF983885800]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF98388E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF983885800]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835C3BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982D97738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835C3BC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L28
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L29
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M05_L24
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L09
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L30
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L36
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L37
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L38
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L09
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L39
M05_L06:
       test      edx,edx
       je        short M05_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L45
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L46
M05_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L47
M05_L08:
       dec       r13d
       jns       short M05_L05
M05_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L48
M05_L10:
       test      r14d,r14d
       je        short M05_L12
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L19
M05_L11:
       or        ebp,edi
       jne       near ptr M05_L22
M05_L12:
       mov       eax,r14d
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
M05_L13:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98303ECB8]
       int       3
M05_L14:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L15
       mov       edi,1
       jmp       short M05_L16
M05_L15:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L16
       mov       ebp,1
M05_L16:
       test      dword ptr [rdx+34],10000000
       je        short M05_L17
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A54D80]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98308E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983034270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98308E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L25
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983035530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L25
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983035740]
       int       3
M05_L24:
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       je        near ptr M05_L00
       jmp       short M05_L23
M05_L25:
       xor       edi,edi
       jmp       short M05_L27
M05_L26:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983035050]
       inc       edi
M05_L27:
       cmp       r15d,edi
       jg        short M05_L26
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98303EF10]
       int       3
M05_L28:
       mov       ecx,33
       call      qword ptr [7FF98303ED00]
       int       3
M05_L29:
       mov       ecx,3C
       call      qword ptr [7FF98303ED30]
       int       3
M05_L30:
       cmp       esi,0FFFFFFFF
       jne       short M05_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L34
       mov       rcx,r12
       call      qword ptr [7FF983034AF8]
       test      eax,eax
       je        short M05_L32
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L33
M05_L31:
       mov       [rsp+5C],edx
       jmp       short M05_L34
M05_L32:
       xor       eax,eax
M05_L33:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L35
M05_L34:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A54D80]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L35:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L36:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L37:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L38:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A54D80]
       jmp       near ptr M05_L04
M05_L39:
       cmp       esi,0FFFFFFFF
       jne       short M05_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L43
       mov       rcx,r12
       call      qword ptr [7FF983034AF8]
       test      eax,eax
       je        short M05_L41
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L42
M05_L40:
       mov       [rsp+5C],edx
       jmp       short M05_L43
M05_L41:
       xor       eax,eax
M05_L42:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L44
M05_L43:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A54D80]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L44:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L45:
       mov       edi,1
       jmp       near ptr M05_L07
M05_L46:
       mov       ebp,1
       jmp       near ptr M05_L07
M05_L47:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A54D80]
       jmp       near ptr M05_L08
M05_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983035038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EFE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L17
M05_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1146
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835BF430]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E4E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M07_L01
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982EFDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       edx,4
       jmp       short M07_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF9838A4138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,23D74C05EE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831A54E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF9831A5500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982F1E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983055008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98387FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F1E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A5E940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835CEDA8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A5EAC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9838A4C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983054198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A5EC10
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838A50E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A5ED48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98305ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838A5A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF9838A5800]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9838AE268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF9838A5800]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835E46E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982DB7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835E46D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L45
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L46
       cmp       qword ptr [rsp+0D0],0
       jne       near ptr M05_L13
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        short M05_L05
       cmp       r15d,r13d
       jle       near ptr M05_L09
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L31
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L47
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L18
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L19
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L20
M05_L04:
       dec       r13d
       jns       short M05_L01
M05_L05:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L30
M05_L06:
       test      r14d,r14d
       je        short M05_L08
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L37
M05_L07:
       or        ebp,edi
       jne       near ptr M05_L40
M05_L08:
       mov       eax,r14d
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
M05_L09:
       cmp       r13d,r15d
       jae       near ptr M05_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L31
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L21
M05_L10:
       test      edx,edx
       je        short M05_L12
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L27
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L28
M05_L11:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L29
M05_L12:
       dec       r13d
       jns       short M05_L09
       jmp       near ptr M05_L05
M05_L13:
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       je        near ptr M05_L00
       jmp       near ptr M05_L41
M05_L14:
       xor       eax,eax
M05_L15:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L17
M05_L16:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A74D68]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L17:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L18:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L19:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L20:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A74D68]
       jmp       near ptr M05_L04
M05_L21:
       cmp       esi,0FFFFFFFF
       jne       short M05_L22
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L25
       mov       rcx,r12
       call      qword ptr [7FF983054AF8]
       test      eax,eax
       je        short M05_L23
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L24
M05_L22:
       mov       [rsp+5C],edx
       jmp       short M05_L25
M05_L23:
       xor       eax,eax
M05_L24:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L26
M05_L25:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A74D68]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L10
M05_L26:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L10
M05_L27:
       mov       edi,1
       jmp       near ptr M05_L11
M05_L28:
       mov       ebp,1
       jmp       near ptr M05_L11
M05_L29:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A74D68]
       jmp       near ptr M05_L12
M05_L30:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983055038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L36
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L35
M05_L31:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98305ECB8]
       int       3
M05_L32:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L33
       mov       edi,1
       jmp       short M05_L34
M05_L33:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L34
       mov       ebp,1
M05_L34:
       test      dword ptr [rdx+34],10000000
       je        short M05_L35
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A74D68]
M05_L35:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830AE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L32
M05_L36:
       jmp       near ptr M05_L06
M05_L37:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F1E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L39
M05_L38:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983054270]
       test      eax,eax
       jne       near ptr M05_L07
M05_L39:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF9830AE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L38
       jmp       near ptr M05_L07
M05_L40:
       test      edi,edi
       jne       short M05_L42
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983055530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L42
M05_L41:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983055740]
       int       3
M05_L42:
       xor       edi,edi
       jmp       short M05_L44
M05_L43:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983055050]
       inc       edi
M05_L44:
       cmp       r15d,edi
       jg        short M05_L43
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98305EF10]
       int       3
M05_L45:
       mov       ecx,33
       call      qword ptr [7FF98305ED00]
       int       3
M05_L46:
       mov       ecx,3C
       call      qword ptr [7FF98305ED30]
       int       3
M05_L47:
       cmp       esi,0FFFFFFFF
       jne       short M05_L48
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       near ptr M05_L16
       mov       rcx,r12
       call      qword ptr [7FF983054AF8]
       test      eax,eax
       je        near ptr M05_L14
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       near ptr M05_L15
M05_L48:
       mov       [rsp+5C],edx
       jmp       near ptr M05_L16
M05_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1163
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835DF360]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E6E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       edx,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982F1DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L00
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF983894138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,23DB3805EE0
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831954E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF983195500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982F0E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983045008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98386FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A4EAC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9835BED30]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A4EC50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983894C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983044198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A4ED98
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838950E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A4EED0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98304ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF983895A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF983895800]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF98389E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF983895800]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835D5930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982DA7738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835D5920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L21
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L22
       cmp       qword ptr [rsp+0D0],0
       je        short M05_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M05_L17
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L08
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L42
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L23
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L29
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L30
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L31
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L08
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L42
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L32
M05_L06:
       test      edx,edx
       jne       short M05_L12
M05_L07:
       dec       r13d
       jns       short M05_L05
M05_L08:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L38
M05_L09:
       test      r14d,r14d
       je        short M05_L11
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L48
M05_L10:
       or        ebp,edi
       jne       short M05_L16
M05_L11:
       mov       eax,r14d
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
M05_L12:
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L39
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L40
M05_L13:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L41
       jmp       short M05_L07
M05_L14:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983044270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98309E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983045530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983045740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983045050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98304EF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FF98304ED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FF98304ED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FF983044AF8]
       test      eax,eax
       je        short M05_L25
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L26
M05_L24:
       mov       [rsp+5C],edx
       jmp       short M05_L27
M05_L25:
       xor       eax,eax
M05_L26:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L28
M05_L27:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A652F0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L28:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L29:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L30:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L31:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A652F0]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FF983044AF8]
       test      eax,eax
       je        short M05_L34
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L35
M05_L33:
       mov       [rsp+5C],edx
       jmp       short M05_L36
M05_L34:
       xor       eax,eax
M05_L35:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L37
M05_L36:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A652F0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983045038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L46
M05_L39:
       mov       edi,1
       jmp       near ptr M05_L13
M05_L40:
       mov       ebp,1
       jmp       near ptr M05_L13
M05_L41:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A652F0]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98304ECB8]
       int       3
M05_L43:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L44
       mov       edi,1
       jmp       short M05_L45
M05_L44:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L45
       mov       ebp,1
M05_L45:
       test      dword ptr [rdx+34],10000000
       je        short M05_L46
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A652F0]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98309E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982F0E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L15
M05_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1134
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835CF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E5E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M07_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L01
M07_L00:
       mov       edx,4
M07_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982F0DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteListenAsyncTest()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.Channels.UnboundedChannel`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,1
       call      qword ptr [7FF983874138]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+280]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,189F9803EE8
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9831754E8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L02
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF983175500]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L03
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L01:
       mov       rcx,rbp
       call      qword ptr [7FF982EEE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF983025008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FF98384FC30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FF982EEE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 325
```
```assembly
; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       [rsp+38],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       rdi,[rbx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+10]
       cmp       qword ptr [rdx+8],30
       jle       short M01_L00
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FF983A2F5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF98359EA18]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FF983A2F750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983874C30]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+40],sil
       test      sil,sil
       je        near ptr M01_L12
       mov       esi,40
M01_L04:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      esi,0FFFFFFBB
       jne       near ptr M01_L13
       test      sil,4
       je        near ptr M01_L07
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],6
       jl        near ptr M01_L14
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       r15,[rax+68]
       test      r15,r15
       je        short M01_L07
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M01_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       dword ptr [r13+3C],1
       lea       rcx,[r14+28]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r13
M01_L06:
       lea       rcx,[rax+30]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       mov       [rsp+20],esi
       mov       dword ptr [rsp+28],400
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,r14
       xor       r9d,r9d
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF983024198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rdi
       mov       rdx,7FF983A2F898
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9838750E0]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+30]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M01_L10
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rdi
       mov       rdx,7FF983A2F9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       xor       esi,esi
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,2D
       call      qword ptr [7FF98302ED30]
       int       3
M01_L14:
       mov       ecx,6
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
; Total bytes of code 650
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+30],rcx
       mov       [rsp+28],rdx
       mov       [rsp+50],r8
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF983875A70]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF983875800]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+20],rcx
       mov       [rsp+40],rdx
       mov       dword ptr [rsp+30],0FFFFFFFF
       lea       rcx,[rsp+20]
       call      qword ptr [7FF98387E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FF983875800]
       jmp       short M03_L00
; Total bytes of code 102
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       esi,[rbx+10]
       test      esi,esi
       je        short M04_L02
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+38]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FF9835B4968
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FF982D87738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FF9835B4958
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M04_L04:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 160
```
```assembly
; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+0D0],r8
       mov       rbx,rcx
       mov       esi,edx
       test      rbx,rbx
       je        near ptr M05_L21
       cmp       esi,0FFFFFFFF
       jl        near ptr M05_L22
       cmp       qword ptr [rsp+0D0],0
       je        short M05_L00
       mov       rax,[rsp+0D0]
       cmp       dword ptr [rax+20],0
       jne       near ptr M05_L17
M05_L00:
       xor       eax,eax
       mov       [rsp+70],rax
       mov       [rsp+68],rax
       mov       [rsp+60],rax
       xor       edi,edi
       xor       ebp,ebp
       mov       r14d,1
       mov       r15d,[rbx+8]
       lea       r13d,[r15-1]
       test      r13d,r13d
       jl        near ptr M05_L08
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L42
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L23
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L29
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L30
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L31
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L08
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L42
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L32
M05_L06:
       test      edx,edx
       jne       short M05_L12
M05_L07:
       dec       r13d
       jns       short M05_L05
M05_L08:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L38
M05_L09:
       test      r14d,r14d
       je        short M05_L11
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L48
M05_L10:
       or        ebp,edi
       jne       short M05_L16
M05_L11:
       mov       eax,r14d
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
M05_L12:
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L39
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L40
M05_L13:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L41
       jmp       short M05_L07
M05_L14:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF983024270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98307E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983025530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FF983025740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FF983025050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FF98302EF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FF98302ED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FF98302ED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FF983024AF8]
       test      eax,eax
       je        short M05_L25
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L26
M05_L24:
       mov       [rsp+5C],edx
       jmp       short M05_L27
M05_L25:
       xor       eax,eax
M05_L26:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L28
M05_L27:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A45590]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L28:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L29:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L30:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L31:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A45590]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FF983024AF8]
       test      eax,eax
       je        short M05_L34
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L35
M05_L33:
       mov       [rsp+5C],edx
       jmp       short M05_L36
M05_L34:
       xor       eax,eax
M05_L35:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L37
M05_L36:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FF983A45590]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FF983025038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EEE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L46
M05_L39:
       mov       edi,1
       jmp       near ptr M05_L13
M05_L40:
       mov       ebp,1
       jmp       near ptr M05_L13
M05_L41:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A45590]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FF98302ECB8]
       int       3
M05_L43:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L44
       mov       edi,1
       jmp       short M05_L45
M05_L44:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L45
       mov       ebp,1
M05_L45:
       test      dword ptr [rdx+34],10000000
       je        short M05_L46
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FF983A45590]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FF98307E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FF982EEE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L15
M05_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1134
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       mov       [rbp-20],rcx
       cmp       byte ptr [rbp-18],0
       jne       short M06_L05
       lea       rdx,[rbp-18]
       call      System.Threading.Monitor.ReliableEnter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       mov       rsi,offset MT_System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rsi
       jne       short M06_L03
M06_L00:
       mov       rcx,[rbx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],rsi
       jne       short M06_L04
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9835AF4A8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
M06_L01:
       mov       ebx,eax
M06_L02:
       jmp       short M06_L06
M06_L03:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       test      eax,eax
       jne       short M06_L00
       mov       ebx,0FFFFFFFF
       jmp       short M06_L02
M06_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       short M06_L01
M06_L05:
       call      qword ptr [7FF982E3E040]
       int       3
M06_L06:
       cmp       byte ptr [rbp-18],0
       je        short M06_L07
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L07:
       mov       eax,ebx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       byte ptr [rbp-18],0
       je        short M06_L08
       mov       rcx,[rbp-20]
       call      System.Threading.Monitor.Exit(System.Object)
M06_L08:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 213
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       lea       ebp,[rdi+1]
       mov       ecx,ebp
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       je        short M07_L00
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M07_L01
M07_L00:
       mov       edx,4
M07_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FF982EEDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],ebp
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98386E3A0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386DF08]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838B4CA8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386E190]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF98386E568]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98386E568]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B4CC0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838840A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838A63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF983884270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884270]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838B40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838D63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF9838B4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4270]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838A40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838C63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF9838A4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4270]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838C63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838B40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838D63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF9838B4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4270]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838840A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838A63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF983884270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884270]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98387D770]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387D2D8]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838BFF18]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387D560]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF98387D938]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98387D938]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838BFF30]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsyncIEnumerableAsync()
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9838A40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387FB70]
       jmp       short M00_L00
; Total bytes of code 90
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
       call      qword ptr [7FF9838C63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FF9838A4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4270]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838C63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF98386E6D0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386E238]
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
       call      qword ptr [7FF9838B4D08]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386E4C0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF98386E898]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98386E898]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B4D20]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF98387DE90]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387D9F8]
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
       call      qword ptr [7FF9838D42E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387DC80]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF98387E058]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98387E058]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D4300]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF983894378]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386FEA0]
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
       call      qword ptr [7FF9838B6790]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF983894168]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF983894540]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983894540]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B67A8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF9838A40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387FB70]
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
       call      qword ptr [7FF9838C63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF9838A4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4270]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838C63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF9838B40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
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
       call      qword ptr [7FF9838D63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF9838B4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4270]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF9838840A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
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
       call      qword ptr [7FF9838A63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF983884270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884270]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF9838840A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
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
       call      qword ptr [7FF9838A63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF983884270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884270]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteReadAsync()
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
       call      qword ptr [7FF9838B40A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
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
       call      qword ptr [7FF9838D63B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FDF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FF9838B4270]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4270]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D63D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98385E2F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385E088]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF98388E478]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385E1C0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF98385E4C0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98385E4C0]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF98388E490]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98385FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838A40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF983884198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884198]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98387FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838C40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98387FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF9838A4198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4198]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838C40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98386FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838B40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF983894198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983894198]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98388FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838D40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF9838B4198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4198]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98384FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98384FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838940C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E3D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98384FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF983874198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983874198]
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
       call      qword ptr [7FF983024B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830242E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838940D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983024768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98388FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838D40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF9838A4198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4198]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsyncIEnumerableAsync()
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+28],rcx
       mov       dword ptr [rsp+38],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FF98388FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
       jmp       short M00_L00
; Total bytes of code 84
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
       call      qword ptr [7FF9838D40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FF9838B4198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4198]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98385E2F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385E088]
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
       call      qword ptr [7FF98388E478]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385E1C0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF98385E4C0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF98385E4C0]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF98388E490]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98388FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98388FB70]
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
       call      qword ptr [7FF9838D40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E7D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98388FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF9838B4198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838B4198]
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
       call      qword ptr [7FF983064B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830642E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838D40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983064768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98385FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
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
       call      qword ptr [7FF9838A40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF983884198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884198]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98385FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98385FB70]
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
       call      qword ptr [7FF9838A40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E4D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98385FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF983884198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884198]
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
       call      qword ptr [7FF983034B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830342E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838A40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983034768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98386FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386FB70]
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
       call      qword ptr [7FF9838B40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF983894198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983894198]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF9838A4150]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98387FEA0]
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
       call      qword ptr [7FF9838C40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E6D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF9838A4018]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF9838A4318]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF9838A4318]
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
       call      qword ptr [7FF983054B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830542E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838C40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983054768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98386FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386FB70]
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
       call      qword ptr [7FF9838B40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF983884198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983884198]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.WriteAsync()
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
       call      qword ptr [7FF98386FDE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF98386FB70]
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
       call      qword ptr [7FF9838B40C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 36
```
```assembly
; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       [rbp-30],rsp
       mov       rbx,rcx
       cmp       [rbx],bl
       mov       rax,gs:[58]
       mov       rax,[rax+30]
       cmp       dword ptr [rax+190],4
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF982E5D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FF98386FCA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FF983894198]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,4
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
       call      qword ptr [7FF983894198]
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
       call      qword ptr [7FF983044B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9830442E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF9838B40D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF983044768]
       jmp       short M03_L02
; Total bytes of code 139
```

