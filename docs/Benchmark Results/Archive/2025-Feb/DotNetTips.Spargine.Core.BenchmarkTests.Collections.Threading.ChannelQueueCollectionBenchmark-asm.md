## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEDE190]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,24534003640
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C805488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8054A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C57E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6B5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CEDDD28]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D0BD890
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC2E628]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D0BDA18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CEDEC88]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6B4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D0BDB60
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CEDF138]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D0BDC98
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
       call      qword ptr [7FFE5C6BED30]
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
       call      qword ptr [7FFE5CEDFAC8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CEDF858]
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
       call      qword ptr [7FFE5CF0C288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CEDF858]
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
       mov       rdx,7FFE5CC40CB8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C417738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC40CA8
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
       call      qword ptr [7FFE5C6BECB8]
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
       call      qword ptr [7FFE5D0D72D0]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C6B4270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6B5050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6BEF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FFE5C6BED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FFE5C6BED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D0D72D0]
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
       call      qword ptr [7FFE5D0D72D0]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D0D72D0]
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
       call      qword ptr [7FFE5D0D72D0]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6B5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC3EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4CE040]
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
       call      qword ptr [7FFE5C57DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEDF0F0]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,127F6403640
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C805488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8054A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C57E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6B5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CEDEC88]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D0F0438
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC2E670]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D0F05C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CEDFBE8]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6B4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D0F0708
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CF04108]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D0F0840
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
       call      qword ptr [7FFE5C6BED30]
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
       call      qword ptr [7FFE5CF04A98]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CF04828]
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
       call      qword ptr [7FFE5CF0CF18]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CF04828]
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
       mov       rdx,7FFE5CC40E30
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C417738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC40E20
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
       call      qword ptr [7FFE5C6BECB8]
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
       call      qword ptr [7FFE5D0E7738]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C6B4270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6B5050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6BEF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FFE5C6BED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FFE5C6BED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D0E7738]
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
       call      qword ptr [7FFE5D0E7738]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D0E7738]
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
       call      qword ptr [7FFE5D0E7738]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6B5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC3EB38]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4CE040]
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
       call      qword ptr [7FFE5C57DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0F348]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1F5B1C05638
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C835488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8354A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C5AE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6E5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CF0EEE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C5AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C5AE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D120560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC5E628]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D1206E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CF0FE40]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6E4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D120830
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CF34318]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D120968
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
       call      qword ptr [7FFE5C6EED30]
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
       call      qword ptr [7FFE5CF34CA8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CF34A38]
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
       call      qword ptr [7FFE5CF3D158]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CF34A38]
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
       mov       rdx,7FFE5CBFD768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C447738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CBFD758
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
       call      qword ptr [7FFE5C6EECB8]
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
       call      qword ptr [7FFE5D117738]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C73E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C5AE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C6E4270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C73E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6E5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6E5740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6E5050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6EEF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FFE5C6EED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FFE5C6EED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FFE5C6E4AF8]
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
       call      qword ptr [7FFE5D117738]
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
       call      qword ptr [7FFE5D117738]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FFE5C6E4AF8]
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
       call      qword ptr [7FFE5D117738]
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
       call      qword ptr [7FFE5D117738]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6E5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C5AE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC6EBA0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4FE040]
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
       call      qword ptr [7FFE5C5ADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF1F348]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,17814003640
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C845488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8454A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C5BE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6F5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CF1EEE0]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C5BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C5BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D130D70
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC6E628]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D130EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CF1FE40]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6F4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D131040
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CF44318]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D131178
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
       call      qword ptr [7FFE5C6FED30]
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
       call      qword ptr [7FFE5CF44CA8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CF44A38]
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
       call      qword ptr [7FFE5CF4D158]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CF44A38]
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
       mov       rdx,7FFE5CC80E20
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C457738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC80E10
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
       call      qword ptr [7FFE5C6FECB8]
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
       call      qword ptr [7FFE5D127738]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C74E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C5BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C6F4270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C74E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6F5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6F5740]
       int       3
M05_L24:
       xor       edi,edi
       jmp       short M05_L26
M05_L25:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6F5050]
       inc       edi
M05_L26:
       cmp       r15d,edi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6FEF10]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FFE5C6FED00]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FFE5C6FED30]
       int       3
M05_L29:
       cmp       esi,0FFFFFFFF
       jne       short M05_L30
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L33
       mov       rcx,r12
       call      qword ptr [7FFE5C6F4AF8]
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
       call      qword ptr [7FFE5D127738]
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
       call      qword ptr [7FFE5D127738]
       jmp       near ptr M05_L04
M05_L38:
       cmp       esi,0FFFFFFFF
       jne       short M05_L39
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L42
       mov       rcx,r12
       call      qword ptr [7FFE5C6F4AF8]
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
       call      qword ptr [7FFE5D127738]
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
       call      qword ptr [7FFE5D127738]
       jmp       near ptr M05_L08
M05_L47:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6F5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C5BE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC7EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C50E040]
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
       call      qword ptr [7FFE5C5BDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFD800]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2E700C05638
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C824F00]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C824F18]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C59E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6D5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CEFD398]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D110800
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC5CD80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D110988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CEFE2F8]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6D4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D110AD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CEFE7A8]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D110C08
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
       call      qword ptr [7FFE5C6DED30]
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
       call      qword ptr [7FFE5CEFF138]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CEFEEC8]
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
       call      qword ptr [7FFE5CF275B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CEFEEC8]
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
       mov       rdx,7FFE5CC60978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C437738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC60968
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
       call      qword ptr [7FFE5C6D4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6D5050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6DEF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFE5C6DED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFE5C6DED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D105980]
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
       call      qword ptr [7FFE5D105980]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D105980]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6D5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5D105980]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFE5C6DECB8]
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
       call      qword ptr [7FFE5D105980]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC4EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4EE040]
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
       mov       edx,[rdx+8]
       add       edx,edx
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE5C59DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF1EB98]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,19B43403648
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C804F00]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C804F18]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C57E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6B5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5CF1E730]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C57E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D129448
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC3CD80]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D1295D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CF1F690]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6B4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D129718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5CF1FB40]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D129850
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
       call      qword ptr [7FFE5C6BED30]
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
       call      qword ptr [7FFE5CF544F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5CF54288]
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
       call      qword ptr [7FFE5CF5C978]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5CF54288]
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
       mov       rdx,7FFE5CC40848
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C417738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC40838
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
       call      qword ptr [7FFE5C6B4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6B5740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6B5050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6BEF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFE5C6BED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFE5C6BED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D145398]
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
       call      qword ptr [7FFE5D145398]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FFE5C6B4AF8]
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
       call      qword ptr [7FFE5D145398]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6B5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5D145398]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFE5C6BECB8]
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
       call      qword ptr [7FFE5D145398]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C70E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C57E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC2EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4CE040]
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
       mov       edx,[rdx+8]
       add       edx,edx
M07_L00:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFE5C57DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D00EB98]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,255E5405670
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C825488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8254A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C59E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6D5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5D00E730]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D174A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC4E628]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D174BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5D00F690]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6D4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D174D18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5D00FB40]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D174E50
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
       call      qword ptr [7FFE5C6DED30]
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
       call      qword ptr [7FFE5D0344F8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5D034288]
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
       call      qword ptr [7FFE5D03C978]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5D034288]
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
       mov       rdx,7FFE5CC60AD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C437738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CC60AC8
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
       call      qword ptr [7FFE5C6D4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6D5050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6DEF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFE5C6DED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFE5C6DED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D194DE0]
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
       call      qword ptr [7FFE5D194DE0]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D194DE0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6D5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5D194DE0]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFE5C6DECB8]
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
       call      qword ptr [7FFE5D194DE0]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC5EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4EE040]
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
       call      qword ptr [7FFE5C59DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D124630]; System.Threading.Channels.UnboundedChannel`1[[System.__Canon, System.Private.CoreLib]]..ctor(Boolean)
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,0B2D05E00
       mov       [rsi+18],rcx
       mov       rdi,[rbx+278]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,203EF003678
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE5C825488]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C8254A0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C59E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFE5C6D5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFE5D1241C8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFE5C59E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       rdx,7FFE5D2088C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5CC4E6A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFE5D208A48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFE5D125128]; System.Collections.Generic.Deque`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7FFE5C6D4198]; System.Threading.Tasks.Task.TaskConstructorCore(System.Delegate, System.Object, System.Threading.CancellationToken, System.Threading.Tasks.TaskCreationOptions, System.Threading.Tasks.InternalTaskOptions, System.Threading.Tasks.TaskScheduler)
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
       mov       rdx,7FFE5D208B90
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5D1255D8]; System.Threading.Channels.UnboundedChannel`1+UnboundedChannelReader[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Channels.UnboundedChannel`1<System.__Canon>)
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
       mov       rdx,7FFE5D208CC8
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
       call      qword ptr [7FFE5C6DED30]
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
       call      qword ptr [7FFE5D125F68]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5D125CF8]
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
       call      qword ptr [7FFE5D12E268]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+38]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5D125CF8]
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
       mov       rdx,7FFE5CBEE748
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFE5C437738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,7FFE5CBEE738
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
       call      qword ptr [7FFE5C6D4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFE5C6D5740]
       int       3
M05_L18:
       xor       edi,edi
       jmp       short M05_L20
M05_L19:
       mov       edx,edi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFE5C6D5050]
       inc       edi
M05_L20:
       cmp       r15d,edi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFE5C6DEF10]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFE5C6DED00]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFE5C6DED30]
       int       3
M05_L23:
       cmp       esi,0FFFFFFFF
       jne       short M05_L24
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L27
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D15FC90]
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
       call      qword ptr [7FFE5D15FC90]
       jmp       near ptr M05_L04
M05_L32:
       cmp       esi,0FFFFFFFF
       jne       short M05_L33
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L36
       mov       rcx,r12
       call      qword ptr [7FFE5C6D4AF8]
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
       call      qword ptr [7FFE5D15FC90]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L37:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFE5C6D5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L47
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5D15FC90]
       jmp       near ptr M05_L07
M05_L42:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFE5C6DECB8]
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
       call      qword ptr [7FFE5D15FC90]
M05_L46:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFE5C72E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L43
M05_L47:
       jmp       near ptr M05_L09
M05_L48:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C59E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
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
       call      qword ptr [7FFE5CC5EC78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
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
       call      qword ptr [7FFE5C4EE040]
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
       call      qword ptr [7FFE5C59DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0E1C0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0DD28]
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
       call      qword ptr [7FFE5CF54600]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0DFB0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CF0E388]
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
       call      qword ptr [7FFE5CF0E388]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF54618]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFF2B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFEE20]
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
       call      qword ptr [7FFE5CF45BA8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFF0A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CEFF480]
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
       call      qword ptr [7FFE5CEFF480]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF45BC0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0EA30]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0E598]
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
       call      qword ptr [7FFE5CF54EA0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0E820]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CF0EBF8]
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
       call      qword ptr [7FFE5CF0EBF8]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF54EB8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0F2B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0EE20]
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
       call      qword ptr [7FFE5CF55B90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0F0A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CF0F480]
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
       call      qword ptr [7FFE5CF0F480]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF55BA8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0F060]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0EBC8]
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
       call      qword ptr [7FFE5CF555F0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0EE50]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CF0F228]
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
       call      qword ptr [7FFE5CF0F228]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF55608]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF2CD68]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF2C8D0]
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
       call      qword ptr [7FFE5CF5F138]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF2CB58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CF2CF30]
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
       call      qword ptr [7FFE5CF2CF30]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF5F150]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CFDC0A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CFD7B70]
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
       call      qword ptr [7FFE5D00E3B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4CD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CFD7DF8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CFDC270]
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
       call      qword ptr [7FFE5CFDC270]
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
       call      qword ptr [7FFE5C6B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D00E3D0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6B4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D10FB10]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D10F678]
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
       call      qword ptr [7FFE5D165E60]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D10F900]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
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
       call      qword ptr [7FFE5CFEC618]
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
       call      qword ptr [7FFE5CFEC618]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D165E78]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEECD68]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEEC8D0]
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
       call      qword ptr [7FFE5CF1F078]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEECB58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CEECF30]
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
       call      qword ptr [7FFE5CEECF30]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF1F090]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEEF2B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEEEE20]
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
       call      qword ptr [7FFE5CF35BA8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEEF0A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CEEF480]
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
       call      qword ptr [7FFE5CEEF480]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF35BC0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF1DE90]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF1D9F8]
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
       call      qword ptr [7FFE5CF742E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C50D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF1DC80]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CF1E058]
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
       call      qword ptr [7FFE5CF1E058]
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
       call      qword ptr [7FFE5C6F4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6F42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF74300]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEEF2B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEEEE20]
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
       call      qword ptr [7FFE5CF35BA8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEEF0A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CEEF480]
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
       call      qword ptr [7FFE5CEEF480]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF35BC0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFF2B8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFEE20]
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
       call      qword ptr [7FFE5CF45B90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFF0A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CEFF480]
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
       call      qword ptr [7FFE5CEFF480]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF45BA8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF35020]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF34B88]
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
       call      qword ptr [7FFE5CF67450]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF34E10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CF351E8]
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
       call      qword ptr [7FFE5CF351E8]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF67468]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D01C378]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D017EA0]
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
       call      qword ptr [7FFE5D05E790]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C50D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D01C168]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5D01C540]
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
       call      qword ptr [7FFE5D01C540]
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
       call      qword ptr [7FFE5C6F4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6F42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D05E7A8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D1140A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D0EFB88]
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
       call      qword ptr [7FFE5D146250]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D0EFE10]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
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
       call      qword ptr [7FFE5CFCC618]
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
       call      qword ptr [7FFE5CFCC618]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D146268]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFDED8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFDC68]
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
       call      qword ptr [7FFE5CF2DF98]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       cmp       dword ptr [rax+190],5
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFDDA0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CEFE0A0]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,5
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
       call      qword ptr [7FFE5CEFE0A0]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF2DFB0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFE8E0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFE670]
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
       call      qword ptr [7FFE5CF2E8F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       cmp       dword ptr [rax+190],5
       jl        short M02_L04
       mov       rax,[rax+198]
       mov       rax,[rax+28]
       test      rax,rax
       je        short M02_L04
       mov       rax,[rax]
       add       rax,10
M02_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFE7A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CEFEAA8]
M02_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M02_L04:
       mov       ecx,5
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
       call      qword ptr [7FFE5CEFEAA8]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF2E910]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEEEE38]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEEEBC8]
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
       call      qword ptr [7FFE5CF1F090]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEEED00]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CEEF000]
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
       call      qword ptr [7FFE5CEEF000]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF1F0A8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF1F090]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF1EE20]
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
       call      qword ptr [7FFE5CF4F258]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C50D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF1EF58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CF1F258]
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
       call      qword ptr [7FFE5CF1F258]
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
       call      qword ptr [7FFE5C6F4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6F42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF4F270]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0F090]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0EE20]
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
       call      qword ptr [7FFE5CF3F258]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0EF58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CF0F258]
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
       call      qword ptr [7FFE5CF0F258]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF3F270]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF240A8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFFDC8]
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
       call      qword ptr [7FFE5CF440C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFFF00]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CF24270]
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
       call      qword ptr [7FFE5CF24270]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF440D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D046178]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D045F08]
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
       call      qword ptr [7FFE5D076100]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D046040]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5D046340]
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
       call      qword ptr [7FFE5D046340]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D076118]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D0DF8E8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D0DF678]
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
       call      qword ptr [7FFE5D11F6D8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4CD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D0DF7B0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
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
       call      qword ptr [7FFE5CFBC618]
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
       call      qword ptr [7FFE5CFBC618]
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
       call      qword ptr [7FFE5C6B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D11F6F0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6B4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0D548]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0D2D8]
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
       call      qword ptr [7FFE5CF3D620]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0D410]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CF0D710]
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
       call      qword ptr [7FFE5CF0D710]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF3D638]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFF090]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFEE20]
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
       call      qword ptr [7FFE5CF2F258]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFEF58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CEFF258]
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
       call      qword ptr [7FFE5CEFF258]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF2F270]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEFF090]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEFEE20]
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
       call      qword ptr [7FFE5CF2F258]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEFEF58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CEFF258]
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
       call      qword ptr [7FFE5CEFF258]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF2F270]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0F090]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0EE20]
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
       call      qword ptr [7FFE5CF3F258]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4FD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0EF58]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CF0F258]
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
       call      qword ptr [7FFE5CF0F258]
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
       call      qword ptr [7FFE5C6E4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6E42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF3F270]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6E4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CEEE808]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CEEE598]
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
       call      qword ptr [7FFE5CF1E8F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4DD1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CEEE6D0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CEEE9D0]
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
       call      qword ptr [7FFE5CEEE9D0]
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
       call      qword ptr [7FFE5C6C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF1E910]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6C4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5CF0E8E0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5CF0E670]
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
       call      qword ptr [7FFE5CF3E8F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C4ED1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5CF0E7A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CF0EAA8]
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
       call      qword ptr [7FFE5CF0EAA8]
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
       call      qword ptr [7FFE5C6D4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6D42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5CF3E910]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6D4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D057DE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D057B70]
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
       call      qword ptr [7FFE5D08C0C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C50D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D057CA8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5D05C198]
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
       call      qword ptr [7FFE5D05C198]
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
       call      qword ptr [7FFE5C6F4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6F42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D08C0D8]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F4768]
       jmp       short M03_L02
; Total bytes of code 139
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE5D11E4C0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFE5D11E250]
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
       call      qword ptr [7FFE5D15E268]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFE5C50D1D0]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFE5D11E388]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
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
       call      qword ptr [7FFE5CFF6BC8]
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
       call      qword ptr [7FFE5CFF6BC8]
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
       call      qword ptr [7FFE5C6F4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FFE5C6F42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M03_L02
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FFE5D15E280]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F4768]
       jmp       short M03_L02
; Total bytes of code 139
```

