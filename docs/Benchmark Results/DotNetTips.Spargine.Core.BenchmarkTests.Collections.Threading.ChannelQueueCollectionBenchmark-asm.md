## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF06DEA90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1DCEA265730
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF01F4BD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF9E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDF01F4BE8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       jmp       short M00_L03
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF9E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFDEFF9E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0095008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF06DEB38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF06DEB50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7F30],0
       cmp       dword ptr [7FFDF01C7F30],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE34030]; System.Object..ctor()
       call      qword ptr [7FFDEFE34030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE34030]; System.Object..ctor()
       call      qword ptr [7FFDEFE34030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF06EB498
       mov       rdx,7FFDF06EB498
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF06DEBE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF06DEBE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF0724990]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF0724720]
       jmp       short M02_L00
; Total bytes of code 100
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
       je        short M03_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M03_L01
M03_L00:
       mov       edx,4
M03_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFDEFF9DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF072CF00]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,78
       ret
M04_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF0724720]
       jmp       short M04_L00
; Total bytes of code 101
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
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M05_L00
       mov       rcx,rax
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFDF0801BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE37738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FFDF0801A90
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
       jne       near ptr M06_L29
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
       je        near ptr M06_L30
M06_L02:
       test      edx,edx
       je        short M06_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L36
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M06_L37
M06_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L38
M06_L04:
       dec       r13d
       jns       short M06_L01
       jmp       short M06_L09
M06_L05:
       cmp       r13d,r15d
       jae       near ptr M06_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L39
M06_L06:
       test      edx,edx
       je        short M06_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L45
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M06_L46
M06_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L47
M06_L08:
       dec       r13d
       jns       short M06_L05
M06_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M06_L48
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
       call      qword ptr [7FFDF009EC88]
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
       call      qword ptr [7FFDF090CB10]
M06_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00FE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L14
M06_L18:
       jmp       near ptr M06_L10
M06_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M06_L21
M06_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0094270]
       test      eax,eax
       jne       near ptr M06_L11
M06_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00FE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L20
       jmp       near ptr M06_L11
M06_L22:
       test      edi,edi
       jne       short M06_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0095530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M06_L24
M06_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0095740]
       int       3
M06_L24:
       xor       esi,esi
       jmp       short M06_L26
M06_L25:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF0095050]
       inc       esi
M06_L26:
       cmp       r15d,esi
       jg        short M06_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF009EEE0]
       int       3
M06_L27:
       mov       ecx,33
       call      qword ptr [7FFDF009ECD0]
       int       3
M06_L28:
       mov       ecx,3C
       call      qword ptr [7FFDF009ED00]
       int       3
M06_L29:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M06_L23
       jmp       near ptr M06_L00
M06_L30:
       cmp       esi,0FFFFFFFF
       jne       short M06_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L34
       mov       rcx,r12
       call      qword ptr [7FFDF0094AF8]
       test      eax,eax
       je        short M06_L32
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L33
M06_L31:
       mov       [rsp+5C],edx
       jmp       short M06_L34
M06_L32:
       xor       eax,eax
M06_L33:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M06_L35
M06_L34:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF090CB10]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L35:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L36:
       mov       edi,1
       jmp       near ptr M06_L03
M06_L37:
       mov       ebp,1
       jmp       near ptr M06_L03
M06_L38:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF090CB10]
       jmp       near ptr M06_L04
M06_L39:
       cmp       esi,0FFFFFFFF
       jne       short M06_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L43
       mov       rcx,r12
       call      qword ptr [7FFDF0094AF8]
       test      eax,eax
       je        short M06_L41
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L42
M06_L40:
       mov       [rsp+5C],edx
       jmp       short M06_L43
M06_L41:
       xor       eax,eax
M06_L42:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M06_L44
M06_L43:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF090CB10]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L44:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L45:
       mov       edi,1
       jmp       near ptr M06_L07
M06_L46:
       mov       ebp,1
       jmp       near ptr M06_L07
M06_L47:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF090CB10]
       jmp       near ptr M06_L08
M06_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF0095038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M06_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF9E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L17
M06_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01C7F30],0
       cmp       dword ptr [7FFDF01C7F30],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEEE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEEE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF06DED90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF06DED90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF06DED90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF06DED90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01C6890],0
       je        short M08_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M08_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01F4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0754570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF07348E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,210993B5750
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF0205158]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDF0205170]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       jmp       short M00_L03
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFDEFFAE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0734990]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF07349A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF06FD5F8
       mov       rdx,7FFDF06FD5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0734A38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0734A38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF0736730]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07364C0]
       jmp       short M02_L00
; Total bytes of code 100
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
       je        short M03_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M03_L01
M03_L00:
       mov       edx,4
M03_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFDEFFADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF073EBB0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,78
       ret
M04_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07364C0]
       jmp       short M04_L00
; Total bytes of code 101
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
       mov       rax,[rdx+70]
       test      rax,rax
       je        short M05_L00
       mov       rcx,rax
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFDF0816A68
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE47738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+68]
       test      rdx,rdx
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FFDF0816A58
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
       jne       near ptr M06_L29
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
       je        near ptr M06_L30
M06_L02:
       test      edx,edx
       je        short M06_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L36
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M06_L37
M06_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L38
M06_L04:
       dec       r13d
       jns       short M06_L01
       jmp       short M06_L09
M06_L05:
       cmp       r13d,r15d
       jae       near ptr M06_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L39
M06_L06:
       test      edx,edx
       je        short M06_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L45
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M06_L46
M06_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L47
M06_L08:
       dec       r13d
       jns       short M06_L05
M06_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M06_L48
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
       call      qword ptr [7FFDF00AEC88]
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
       call      qword ptr [7FFDF090D920]
M06_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L14
M06_L18:
       jmp       near ptr M06_L10
M06_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M06_L21
M06_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF00A4270]
       test      eax,eax
       jne       near ptr M06_L11
M06_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L20
       jmp       near ptr M06_L11
M06_L22:
       test      edi,edi
       jne       short M06_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M06_L24
M06_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5740]
       int       3
M06_L24:
       xor       esi,esi
       jmp       short M06_L26
M06_L25:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF00A5050]
       inc       esi
M06_L26:
       cmp       r15d,esi
       jg        short M06_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF00AEEE0]
       int       3
M06_L27:
       mov       ecx,33
       call      qword ptr [7FFDF00AECD0]
       int       3
M06_L28:
       mov       ecx,3C
       call      qword ptr [7FFDF00AED00]
       int       3
M06_L29:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M06_L23
       jmp       near ptr M06_L00
M06_L30:
       cmp       esi,0FFFFFFFF
       jne       short M06_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L34
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
       test      eax,eax
       je        short M06_L32
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L33
M06_L31:
       mov       [rsp+5C],edx
       jmp       short M06_L34
M06_L32:
       xor       eax,eax
M06_L33:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M06_L35
M06_L34:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF090D920]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L35:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L36:
       mov       edi,1
       jmp       near ptr M06_L03
M06_L37:
       mov       ebp,1
       jmp       near ptr M06_L03
M06_L38:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF090D920]
       jmp       near ptr M06_L04
M06_L39:
       cmp       esi,0FFFFFFFF
       jne       short M06_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L43
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
       test      eax,eax
       je        short M06_L41
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L42
M06_L40:
       mov       [rsp+5C],edx
       jmp       short M06_L43
M06_L41:
       xor       eax,eax
M06_L42:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M06_L44
M06_L43:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF090D920]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L44:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L45:
       mov       edi,1
       jmp       near ptr M06_L07
M06_L46:
       mov       ebp,1
       jmp       near ptr M06_L07
M06_L47:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF090D920]
       jmp       near ptr M06_L08
M06_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF00A5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M06_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L17
M06_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0734BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0734BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0734BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0734BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01D6918],0
       je        short M08_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M08_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0766298]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF07148E8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1AEA7415750
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF01E4BD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF8E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDF01E4BE8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       jmp       short M00_L03
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF8E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFDEFF8E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0085008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0714990]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF07149A8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B8100],0
       cmp       dword ptr [7FFDF01B8100],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF06DD5F8
       mov       rdx,7FFDF06DD5F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0714A38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0714A38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF0716730]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07164C0]
       jmp       short M02_L00
; Total bytes of code 100
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
       je        short M03_L00
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       short M03_L01
M03_L00:
       mov       edx,4
M03_L01:
       mov       eax,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,eax
       cmp       edx,ecx
       cmovl     edx,ecx
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF071EBB0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,78
       ret
M04_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07164C0]
       jmp       short M04_L00
; Total bytes of code 101
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
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M05_L00
       mov       rcx,rax
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFDF07F7178
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE27738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+70]
       test      rdx,rdx
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FFDF07F7180
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
       jne       near ptr M06_L29
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
       je        near ptr M06_L30
M06_L02:
       test      edx,edx
       je        short M06_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L36
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M06_L37
M06_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L38
M06_L04:
       dec       r13d
       jns       short M06_L01
       jmp       short M06_L09
M06_L05:
       cmp       r13d,r15d
       jae       near ptr M06_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L39
M06_L06:
       test      edx,edx
       je        short M06_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L45
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M06_L46
M06_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L47
M06_L08:
       dec       r13d
       jns       short M06_L05
M06_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M06_L48
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
       call      qword ptr [7FFDF008EC88]
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
       call      qword ptr [7FFDF08EE7A8]
M06_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00EE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L14
M06_L18:
       jmp       near ptr M06_L10
M06_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M06_L21
M06_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0084270]
       test      eax,eax
       jne       near ptr M06_L11
M06_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00EE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L20
       jmp       near ptr M06_L11
M06_L22:
       test      edi,edi
       jne       short M06_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0085530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M06_L24
M06_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0085740]
       int       3
M06_L24:
       xor       esi,esi
       jmp       short M06_L26
M06_L25:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF0085050]
       inc       esi
M06_L26:
       cmp       r15d,esi
       jg        short M06_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF008EEE0]
       int       3
M06_L27:
       mov       ecx,33
       call      qword ptr [7FFDF008ECD0]
       int       3
M06_L28:
       mov       ecx,3C
       call      qword ptr [7FFDF008ED00]
       int       3
M06_L29:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M06_L23
       jmp       near ptr M06_L00
M06_L30:
       cmp       esi,0FFFFFFFF
       jne       short M06_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L34
       mov       rcx,r12
       call      qword ptr [7FFDF0084AF8]
       test      eax,eax
       je        short M06_L32
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L33
M06_L31:
       mov       [rsp+5C],edx
       jmp       short M06_L34
M06_L32:
       xor       eax,eax
M06_L33:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M06_L35
M06_L34:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF08EE7A8]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L35:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L36:
       mov       edi,1
       jmp       near ptr M06_L03
M06_L37:
       mov       ebp,1
       jmp       near ptr M06_L03
M06_L38:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF08EE7A8]
       jmp       near ptr M06_L04
M06_L39:
       cmp       esi,0FFFFFFFF
       jne       short M06_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L43
       mov       rcx,r12
       call      qword ptr [7FFDF0084AF8]
       test      eax,eax
       je        short M06_L41
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L42
M06_L40:
       mov       [rsp+5C],edx
       jmp       short M06_L43
M06_L41:
       xor       eax,eax
M06_L42:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M06_L44
M06_L43:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF08EE7A8]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L44:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L45:
       mov       edi,1
       jmp       near ptr M06_L07
M06_L46:
       mov       ebp,1
       jmp       near ptr M06_L07
M06_L47:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF08EE7A8]
       jmp       near ptr M06_L08
M06_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF0085038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M06_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L17
M06_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B8100],0
       cmp       dword ptr [7FFDF01B8100],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEDE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEDE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0714BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0714BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0714BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0714BE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01B6A60],0
       je        short M08_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M08_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0746298]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF07B7E88]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1DDDB6E57A0
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF01E5158]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       mov       r8,rax
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rbp+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M00_L00:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFDF01E5170]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF8E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFF8E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L03:
       mov       rcx,rbp
       call      qword ptr [7FFDEFF8E640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0085008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF07B7F30]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF07B7F48]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7FB8],0
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       call      qword ptr [7FFDEFE24030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF071B5F0
       mov       rdx,7FFDF071B5F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF07B7FD8]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF07B7FD8]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF07BDCE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07BDA70]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF07E6070]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF07BDA70]
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       eax,ebp
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       short M04_L01
       mov       edx,4
M04_L00:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,eax
       cmovl     edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDEFF8DFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
M04_L01:
       mov       rcx,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       jmp       short M04_L00
; Total bytes of code 104
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
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M05_L00
       mov       rcx,rax
       jmp       short M05_L01
M05_L00:
       mov       rdx,7FFDF05AC678
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE27738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M05_L03
       jmp       short M05_L04
M05_L03:
       mov       rdx,7FFDF05AC668
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
       jne       near ptr M06_L29
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
       je        near ptr M06_L30
M06_L02:
       test      edx,edx
       je        short M06_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L36
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M06_L37
M06_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L38
M06_L04:
       dec       r13d
       jns       short M06_L01
       jmp       short M06_L09
M06_L05:
       cmp       r13d,r15d
       jae       near ptr M06_L49
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M06_L13
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M06_L39
M06_L06:
       test      edx,edx
       je        short M06_L08
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L45
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M06_L46
M06_L07:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L47
M06_L08:
       dec       r13d
       jns       short M06_L05
M06_L09:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M06_L48
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
       call      qword ptr [7FFDF008EC88]
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
       call      qword ptr [7FFDF0925050]
M06_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00EE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L14
M06_L18:
       jmp       near ptr M06_L10
M06_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M06_L21
M06_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0084270]
       test      eax,eax
       jne       near ptr M06_L11
M06_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF00EE670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M06_L20
       jmp       near ptr M06_L11
M06_L22:
       test      edi,edi
       jne       short M06_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0085530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M06_L24
M06_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF0085740]
       int       3
M06_L24:
       xor       esi,esi
       jmp       short M06_L26
M06_L25:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF0085050]
       inc       esi
M06_L26:
       cmp       r15d,esi
       jg        short M06_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF008EEE0]
       int       3
M06_L27:
       mov       ecx,33
       call      qword ptr [7FFDF008ECD0]
       int       3
M06_L28:
       mov       ecx,3C
       call      qword ptr [7FFDF008ED00]
       int       3
M06_L29:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M06_L23
       jmp       near ptr M06_L00
M06_L30:
       cmp       esi,0FFFFFFFF
       jne       short M06_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L34
       mov       rcx,r12
       call      qword ptr [7FFDF0084AF8]
       test      eax,eax
       je        short M06_L32
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L33
M06_L31:
       mov       [rsp+5C],edx
       jmp       short M06_L34
M06_L32:
       xor       eax,eax
M06_L33:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M06_L35
M06_L34:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF0925050]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L35:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L02
M06_L36:
       mov       edi,1
       jmp       near ptr M06_L03
M06_L37:
       mov       ebp,1
       jmp       near ptr M06_L03
M06_L38:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF0925050]
       jmp       near ptr M06_L04
M06_L39:
       cmp       esi,0FFFFFFFF
       jne       short M06_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M06_L43
       mov       rcx,r12
       call      qword ptr [7FFDF0084AF8]
       test      eax,eax
       je        short M06_L41
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M06_L42
M06_L40:
       mov       [rsp+5C],edx
       jmp       short M06_L43
M06_L41:
       xor       eax,eax
M06_L42:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M06_L44
M06_L43:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF0925050]
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L44:
       mov       edx,[rsp+5C]
       jmp       near ptr M06_L06
M06_L45:
       mov       edi,1
       jmp       near ptr M06_L07
M06_L46:
       mov       ebp,1
       jmp       near ptr M06_L07
M06_L47:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF0925050]
       jmp       near ptr M06_L08
M06_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF0085038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M06_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFF8E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M06_L17
M06_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01B7FB8],0
       cmp       dword ptr [7FFDF01B7FB8],0
       je        short M07_L00
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       nop
M07_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEDE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEDE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07BC198]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF07BC198]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M07_L01
       jne       short M07_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M07_L02
       jmp       short M07_L02
M07_L01:
       mov       rcx,[rbp+10]
M07_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07BC198]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF07BC198]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M07_L02:
       mov       ecx,[rbp-34]
M07_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M07_L03
       call      M07_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M07_L03:
       push      rbp
M07_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M07_L04
       je        short M07_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M07_L04:
       nop
M07_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01B6918],0
       je        short M08_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M08_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF01E4B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF07ED818]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF0836CE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2EC6ED757A0
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF0205158]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDF0205170]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDEFFAE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0836D90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836DA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF0828AC0
       mov       rdx,7FFDF0828AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0836E38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0836E38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF083CBA0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF083C930]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF0874F00]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF083C930]
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       rax,[rdx+68]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFDF05CC850
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE47738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+60]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFDF05CC840
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
       jne       near ptr M05_L29
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
       call      qword ptr [7FFDF00AEC88]
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
       call      qword ptr [7FFDF091F2E8]
M05_L17:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
M05_L18:
       jmp       near ptr M05_L10
M05_L19:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       short M05_L21
M05_L20:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF00A4270]
       test      eax,eax
       jne       near ptr M05_L11
M05_L21:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L20
       jmp       near ptr M05_L11
M05_L22:
       test      edi,edi
       jne       short M05_L24
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L24
M05_L23:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5740]
       int       3
M05_L24:
       xor       esi,esi
       jmp       short M05_L26
M05_L25:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF00A5050]
       inc       esi
M05_L26:
       cmp       r15d,esi
       jg        short M05_L25
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF00AEEE0]
       int       3
M05_L27:
       mov       ecx,33
       call      qword ptr [7FFDF00AECD0]
       int       3
M05_L28:
       mov       ecx,3C
       call      qword ptr [7FFDF00AED00]
       int       3
M05_L29:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M05_L23
       jmp       near ptr M05_L00
M05_L30:
       cmp       esi,0FFFFFFFF
       jne       short M05_L31
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L34
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
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
       call      qword ptr [7FFDF091F2E8]
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
       call      qword ptr [7FFDF091F2E8]
       jmp       near ptr M05_L04
M05_L39:
       cmp       esi,0FFFFFFFF
       jne       short M05_L40
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L43
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
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
       call      qword ptr [7FFDF091F2E8]
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
       call      qword ptr [7FFDF091F2E8]
       jmp       near ptr M05_L08
M05_L48:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF00A5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L18
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L17
M05_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1153
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M06_L00
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       nop
M06_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M06_L01
       jne       short M06_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M06_L02
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+10]
M06_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M06_L02:
       mov       ecx,[rbp-34]
M06_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M06_L03
       call      M06_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M06_L03:
       push      rbp
M06_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M06_L04
       je        short M06_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M06_L04:
       nop
M06_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01D6918],0
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF087C570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
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
       mov       eax,ebp
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,eax
       cmovl     edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDEFFADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       jmp       short M08_L00
; Total bytes of code 104
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF0836CE8]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2EAF43B57A0
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF0205158]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDF0205170]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDEFFAE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0836D90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836DA8]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFAE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       call      qword ptr [7FFDEFE44030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF082A3A8
       mov       rdx,7FFDF082A3A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0836E38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0836E38]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF083CBA0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF083C930]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF0874F00]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF083C930]
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       rax,[rdx+60]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFDF05CB7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE47738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFDF05CB7D0
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
       jl        near ptr M05_L08
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L24
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L30
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L31
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L32
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L08
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L50
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L33
M05_L06:
       test      edx,edx
       jne       short M05_L12
M05_L07:
       dec       r13d
       jns       short M05_L05
M05_L08:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L39
M05_L09:
       test      r14d,r14d
       je        short M05_L11
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L49
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
       jne       near ptr M05_L40
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L41
M05_L13:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L42
       jmp       short M05_L07
M05_L14:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF00A4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00A5740]
       int       3
M05_L18:
       xor       esi,esi
       jmp       short M05_L20
M05_L19:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF00A5050]
       inc       esi
M05_L20:
       cmp       r15d,esi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF00AEEE0]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFDF00AECD0]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFDF00AED00]
       int       3
M05_L23:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M05_L17
       jmp       near ptr M05_L00
M05_L24:
       cmp       esi,0FFFFFFFF
       jne       short M05_L25
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L28
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
       test      eax,eax
       je        short M05_L26
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L27
M05_L25:
       mov       [rsp+5C],edx
       jmp       short M05_L28
M05_L26:
       xor       eax,eax
M05_L27:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L29
M05_L28:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF091F2E8]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L29:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L30:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L31:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L32:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF091F2E8]
       jmp       near ptr M05_L04
M05_L33:
       cmp       esi,0FFFFFFFF
       jne       short M05_L34
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L37
       mov       rcx,r12
       call      qword ptr [7FFDF00A4AF8]
       test      eax,eax
       je        short M05_L35
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L36
M05_L34:
       mov       [rsp+5C],edx
       jmp       short M05_L37
M05_L35:
       xor       eax,eax
M05_L36:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L38
M05_L37:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF091F2E8]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L39:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF00A5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L48
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L47
M05_L40:
       mov       edi,1
       jmp       near ptr M05_L13
M05_L41:
       mov       ebp,1
       jmp       near ptr M05_L13
M05_L42:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF091F2E8]
       jmp       near ptr M05_L07
M05_L43:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFDF00AEC88]
       int       3
M05_L44:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L45
       mov       edi,1
       jmp       short M05_L46
M05_L45:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L46
       mov       ebp,1
M05_L46:
       test      dword ptr [rdx+34],10000000
       je        short M05_L47
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF091F2E8]
M05_L47:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF010E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L44
M05_L48:
       jmp       near ptr M05_L09
M05_L49:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFAE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L15
M05_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1147
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01D7FB8],0
       cmp       dword ptr [7FFDF01D7FB8],0
       je        short M06_L00
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       nop
M06_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFEFE028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M06_L01
       jne       short M06_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M06_L02
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+10]
M06_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0836FE8]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M06_L02:
       mov       ecx,[rbp-34]
M06_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M06_L03
       call      M06_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M06_L03:
       push      rbp
M06_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M06_L04
       je        short M06_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M06_L04:
       nop
M06_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01D6918],0
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0204B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF087C570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
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
       mov       eax,ebp
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,eax
       cmovl     edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDEFFADFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       jmp       short M08_L00
; Total bytes of code 104
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF0846A90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2629A0357A0
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF0214BD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDF0214BE8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDEFFBE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0846B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF0846B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01E7F60],0
       cmp       dword ptr [7FFDF01E7F60],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF0838BD0
       mov       rdx,7FFDF0838BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0846BE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0846BE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF084C990]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF084C720]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF0884CC0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF084C720]
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       rax,[rdx+60]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFDF05DB630
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFDF05DB620
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
       jl        near ptr M05_L08
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L24
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L30
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L31
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L32
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L08
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L50
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L33
M05_L06:
       test      edx,edx
       jne       short M05_L12
M05_L07:
       dec       r13d
       jns       short M05_L05
M05_L08:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L39
M05_L09:
       test      r14d,r14d
       je        short M05_L11
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L49
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
       jne       near ptr M05_L40
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L41
M05_L13:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L42
       jmp       short M05_L07
M05_L14:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF00B4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF011E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00B5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00B5740]
       int       3
M05_L18:
       xor       esi,esi
       jmp       short M05_L20
M05_L19:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF00B5050]
       inc       esi
M05_L20:
       cmp       r15d,esi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF00BEEE0]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFDF00BECD0]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFDF00BED00]
       int       3
M05_L23:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M05_L17
       jmp       near ptr M05_L00
M05_L24:
       cmp       esi,0FFFFFFFF
       jne       short M05_L25
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L28
       mov       rcx,r12
       call      qword ptr [7FFDF00B4AF8]
       test      eax,eax
       je        short M05_L26
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L27
M05_L25:
       mov       [rsp+5C],edx
       jmp       short M05_L28
M05_L26:
       xor       eax,eax
M05_L27:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L29
M05_L28:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF092EDC0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L29:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L30:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L31:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L32:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF092EDC0]
       jmp       near ptr M05_L04
M05_L33:
       cmp       esi,0FFFFFFFF
       jne       short M05_L34
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L37
       mov       rcx,r12
       call      qword ptr [7FFDF00B4AF8]
       test      eax,eax
       je        short M05_L35
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L36
M05_L34:
       mov       [rsp+5C],edx
       jmp       short M05_L37
M05_L35:
       xor       eax,eax
M05_L36:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L38
M05_L37:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF092EDC0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L39:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF00B5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L48
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L47
M05_L40:
       mov       edi,1
       jmp       near ptr M05_L13
M05_L41:
       mov       ebp,1
       jmp       near ptr M05_L13
M05_L42:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF092EDC0]
       jmp       near ptr M05_L07
M05_L43:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFDF00BEC88]
       int       3
M05_L44:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L45
       mov       edi,1
       jmp       short M05_L46
M05_L45:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L46
       mov       ebp,1
M05_L46:
       test      dword ptr [rdx+34],10000000
       je        short M05_L47
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF092EDC0]
M05_L47:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF011E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L44
M05_L48:
       jmp       near ptr M05_L09
M05_L49:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L15
M05_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1147
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01E7F60],0
       cmp       dword ptr [7FFDF01E7F60],0
       je        short M06_L00
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       nop
M06_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFF0E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFF0E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M06_L01
       jne       short M06_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M06_L02
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+10]
M06_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M06_L02:
       mov       ecx,[rbp-34]
M06_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M06_L03
       call      M06_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M06_L03:
       push      rbp
M06_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M06_L04
       je        short M06_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M06_L04:
       nop
M06_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01E68C0],0
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214588]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF088C570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
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
       mov       eax,ebp
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,eax
       cmovl     edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       jmp       short M08_L00
; Total bytes of code 104
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rcx,rsi
       call      qword ptr [7FFDF0846A90]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+180]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2681D7557A0
       mov       [rbp+8],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFDF0215158]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.AddToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Collections.Generic.IList`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDF0215170]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
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
       call      qword ptr [7FFDEFFBE640]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B5008]; System.Threading.Tasks.Task.WaitAllCore(System.Threading.Tasks.Task[], Int32, System.Threading.CancellationToken)
       mov       rcx,rsi
       call      qword ptr [7FFDF0846B38]; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDF0846B50]; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L03:
       mov       rcx,rbp
       mov       rdx,r8
       call      qword ptr [7FFDEFFBE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L01
; Total bytes of code 251
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbp
       push      rbp
       push      rdi
       push      rdi
       sub       rsp,58
       sub       rsp,58
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rcx
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01E7FB8],0
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M01_L00
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_System.Object
M01_L00:
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       rcx,[rbp-18]
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       lea       rcx,[rcx+10]
       mov       rdx,[rbp-18]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       call      qword ptr [7FFDEFE54030]; System.Object..ctor()
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       mov       [rbp-38],rcx
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+10],0
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       je        short M01_L01
       mov       rcx,[rbp-38]
       mov       rcx,[rbp-38]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-20],rcx
       mov       [rbp-20],rcx
       jmp       short M01_L02
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp-38]
M01_L01:
       mov       rcx,[rbp-38]
       mov       rdx,7FFDF08390E0
       mov       rdx,7FFDF08390E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp-20],rax
       mov       [rbp-20],rax
M01_L02:
       mov       rcx,[rbp+10]
M01_L02:
       mov       rcx,[rbp+10]
       mov       [rbp-28],rcx
       mov       [rbp-28],rcx
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       call      qword ptr [7FFDF0846BE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       call      qword ptr [7FFDF0846BE0]; System.Threading.Channels.Channel.CreateUnbounded[[System.__Canon, System.Private.CoreLib]]()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-28]
       mov       rcx,[rbp-28]
       lea       rcx,[rcx+8]
       lea       rcx,[rcx+8]
       mov       rdx,[rbp-30]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       call      CORINFO_HELP_ASSIGN_REF
       nop
       nop
       add       rsp,58
       add       rsp,58
       pop       rdi
       pop       rdi
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 448
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
       call      qword ptr [7FFDF084C990]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<AddToQueueAsync>d__1, DotNetTips.Spargine.Core.BenchmarkTests]](<AddToQueueAsync>d__1 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,68
       ret
M02_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF084C720]
       jmp       short M02_L00
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark.ListenToQueueAsync(DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>, System.Threading.CancellationToken)
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       [rsp+28],rcx
       mov       [rsp+50],rdx
       mov       dword ptr [rsp+40],0FFFFFFFF
       lea       rcx,[rsp+28]
       call      qword ptr [7FFDF0884CC0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<ListenToQueueAsync>d__2, DotNetTips.Spargine.Core.BenchmarkTests]](<ListenToQueueAsync>d__2 ByRef)
       mov       rax,[rsp+48]
       test      rax,rax
       je        short M03_L01
M03_L00:
       add       rsp,78
       ret
M03_L01:
       lea       rcx,[rsp+48]
       call      qword ptr [7FFDF084C720]
       jmp       short M03_L00
; Total bytes of code 101
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
       mov       rax,[rdx+60]
       test      rax,rax
       je        short M04_L00
       mov       rcx,rax
       jmp       short M04_L01
M04_L00:
       mov       rdx,7FFDF05DB7E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M04_L01:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,[rbx+8]
       mov       r8d,esi
       mov       rdx,rdi
       call      qword ptr [7FFDEFE57738]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFDF05DB7D0
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
       jl        near ptr M05_L08
       cmp       r15d,r13d
       jle       short M05_L05
M05_L01:
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L24
M05_L02:
       test      edx,edx
       je        short M05_L04
       test      dword ptr [r12+34],200000
       jne       near ptr M05_L30
       mov       edx,[r12+34]
       and       edx,600000
       cmp       edx,400000
       je        near ptr M05_L31
M05_L03:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L32
M05_L04:
       dec       r13d
       jns       short M05_L01
       jmp       short M05_L08
M05_L05:
       cmp       r13d,r15d
       jae       near ptr M05_L50
       mov       eax,r13d
       mov       r12,[rbx+rax*8+10]
       test      r12,r12
       je        near ptr M05_L43
       xor       edx,edx
       test      dword ptr [r12+34],1600000
       setne     dl
       test      edx,edx
       je        near ptr M05_L33
M05_L06:
       test      edx,edx
       jne       short M05_L12
M05_L07:
       dec       r13d
       jns       short M05_L05
M05_L08:
       cmp       qword ptr [rsp+68],0
       jne       near ptr M05_L39
M05_L09:
       test      r14d,r14d
       je        short M05_L11
       cmp       qword ptr [rsp+60],0
       jne       near ptr M05_L49
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
       jne       near ptr M05_L40
       mov       eax,[r12+34]
       and       eax,600000
       cmp       eax,400000
       je        near ptr M05_L41
M05_L13:
       test      dword ptr [r12+34],10000000
       jne       near ptr M05_L42
       jmp       short M05_L07
M05_L14:
       mov       rcx,[rsp+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF00B4270]
       test      eax,eax
       jne       short M05_L10
M05_L15:
       lea       rcx,[rsp+28]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF011E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L14
       jmp       short M05_L10
M05_L16:
       test      edi,edi
       jne       short M05_L18
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00B5530]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M05_L18
M05_L17:
       lea       rcx,[rsp+0D0]
       call      qword ptr [7FFDF00B5740]
       int       3
M05_L18:
       xor       esi,esi
       jmp       short M05_L20
M05_L19:
       mov       edx,esi
       mov       rdx,[rbx+rdx*8+10]
       lea       rcx,[rsp+70]
       call      qword ptr [7FFDF00B5050]
       inc       esi
M05_L20:
       cmp       r15d,esi
       jg        short M05_L19
       mov       rcx,[rsp+70]
       call      qword ptr [7FFDF00BEEE0]
       int       3
M05_L21:
       mov       ecx,33
       call      qword ptr [7FFDF00BECD0]
       int       3
M05_L22:
       mov       ecx,3C
       call      qword ptr [7FFDF00BED00]
       int       3
M05_L23:
       mov       rcx,[rsp+0D0]
       cmp       dword ptr [rcx+20],0
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M05_L17
       jmp       near ptr M05_L00
M05_L24:
       cmp       esi,0FFFFFFFF
       jne       short M05_L25
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L28
       mov       rcx,r12
       call      qword ptr [7FFDF00B4AF8]
       test      eax,eax
       je        short M05_L26
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L27
M05_L25:
       mov       [rsp+5C],edx
       jmp       short M05_L28
M05_L26:
       xor       eax,eax
M05_L27:
       movzx     edx,al
       mov       r10d,edx
       mov       [rsp+5C],r10d
       test      r10d,r10d
       jne       short M05_L29
M05_L28:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF09642D0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L29:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L02
M05_L30:
       mov       edi,1
       jmp       near ptr M05_L03
M05_L31:
       mov       ebp,1
       jmp       near ptr M05_L03
M05_L32:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF09642D0]
       jmp       near ptr M05_L04
M05_L33:
       cmp       esi,0FFFFFFFF
       jne       short M05_L34
       cmp       qword ptr [rsp+0D0],0
       mov       [rsp+5C],edx
       jne       short M05_L37
       mov       rcx,r12
       call      qword ptr [7FFDF00B4AF8]
       test      eax,eax
       je        short M05_L35
       xor       eax,eax
       test      dword ptr [r12+34],1600000
       setne     al
       jmp       short M05_L36
M05_L34:
       mov       [rsp+5C],edx
       jmp       short M05_L37
M05_L35:
       xor       eax,eax
M05_L36:
       movzx     edx,al
       mov       eax,edx
       mov       [rsp+5C],eax
       test      eax,eax
       jne       short M05_L38
M05_L37:
       mov       r9d,r15d
       lea       r8,[rsp+68]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       call      qword ptr [7FFDF09642D0]
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L38:
       mov       edx,[rsp+5C]
       jmp       near ptr M05_L06
M05_L39:
       mov       rcx,[rsp+68]
       mov       edx,esi
       mov       r8,[rsp+0D0]
       call      qword ptr [7FFDF00B5038]
       mov       r14d,eax
       test      r14d,r14d
       je        near ptr M05_L48
       lea       rdx,[rsp+40]
       mov       rcx,[rsp+68]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L47
M05_L40:
       mov       edi,1
       jmp       near ptr M05_L13
M05_L41:
       mov       ebp,1
       jmp       near ptr M05_L13
M05_L42:
       lea       r8,[rsp+60]
       mov       rdx,r12
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF09642D0]
       jmp       near ptr M05_L07
M05_L43:
       mov       ecx,2F
       mov       edx,33
       call      qword ptr [7FFDF00BEC88]
       int       3
M05_L44:
       mov       rdx,[rsp+48]
       test      dword ptr [rdx+34],200000
       je        short M05_L45
       mov       edi,1
       jmp       short M05_L46
M05_L45:
       mov       r8d,[rdx+34]
       and       r8d,600000
       cmp       r8d,400000
       jne       short M05_L46
       mov       ebp,1
M05_L46:
       test      dword ptr [rdx+34],10000000
       je        short M05_L47
       lea       r8,[rsp+60]
       mov       rcx,offset MD_System.Threading.Tasks.Task.AddToList[[System.Threading.Tasks.Task, System.Private.CoreLib]](System.Threading.Tasks.Task, System.Collections.Generic.List`1<System.Threading.Tasks.Task> ByRef, Int32)
       mov       r9d,1
       call      qword ptr [7FFDF09642D0]
M05_L47:
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Threading.Tasks.Task, System.Private.CoreLib]]
       call      qword ptr [7FFDF011E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       short M05_L44
M05_L48:
       jmp       near ptr M05_L09
M05_L49:
       lea       rdx,[rsp+28]
       mov       rcx,[rsp+60]
       cmp       [rcx],ecx
       call      qword ptr [7FFDEFFBE3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       jmp       near ptr M05_L15
M05_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1147
```
```assembly
; DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ChannelQueue`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbp
       push      rbp
       sub       rsp,60
       sub       rsp,60
       lea       rbp,[rsp+60]
       lea       rbp,[rsp+60]
       xor       eax,eax
       xor       eax,eax
       mov       [rbp-34],eax
       mov       [rbp-34],eax
       vxorps    xmm4,xmm4,xmm4
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-40],rsp
       mov       [rbp-40],rsp
       mov       [rbp+10],rcx
       mov       [rbp+10],rcx
       cmp       dword ptr [7FFDF01E7FB8],0
       cmp       dword ptr [7FFDF01E7FB8],0
       je        short M06_L00
       je        short M06_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M06_L00:
       nop
M06_L00:
       nop
       mov       rdx,[rbp+10]
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+10]
       mov       rdx,[rdx+10]
       mov       [rbp-8],rdx
       mov       [rbp-8],rdx
       xor       edx,edx
       xor       edx,edx
       mov       [rbp-10],edx
       mov       [rbp-10],edx
       lea       rdx,[rbp-10]
       lea       rdx,[rbp-10]
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      qword ptr [7FFDEFF0E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       call      qword ptr [7FFDEFF0E028]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       nop
       nop
       nop
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-20],rax
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       call      qword ptr [rax+28]
       mov       [rbp-24],eax
       mov       [rbp-24],eax
       cmp       dword ptr [rbp-24],0
       cmp       dword ptr [rbp-24],0
       jne       short M06_L01
       jne       short M06_L01
       mov       dword ptr [rbp-34],0FFFFFFFF
       mov       dword ptr [rbp-34],0FFFFFFFF
       jmp       short M06_L02
       jmp       short M06_L02
M06_L01:
       mov       rcx,[rbp+10]
M06_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       cmp       [rcx],ecx
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       call      qword ptr [7FFDF0846D90]; System.Threading.Channels.Channel`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Reader()
       mov       [rbp-30],rax
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax]
       mov       rax,[rax+40]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       call      qword ptr [rax+38]
       mov       [rbp-34],eax
       mov       [rbp-34],eax
M06_L02:
       mov       ecx,[rbp-34]
M06_L02:
       mov       ecx,[rbp-34]
       mov       [rbp-14],ecx
       mov       [rbp-14],ecx
       nop
       nop
       mov       rcx,rsp
       mov       rcx,rsp
       call      M06_L03
       call      M06_L03
       nop
       nop
       mov       eax,[rbp-14]
       mov       eax,[rbp-14]
       add       rsp,60
       add       rsp,60
       pop       rbp
       pop       rbp
       ret
       ret
M06_L03:
       push      rbp
M06_L03:
       push      rbp
       sub       rsp,30
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       lea       rbp,[rbp+60]
       mov       ecx,[rbp-10]
       mov       ecx,[rbp-10]
       movzx     ecx,cl
       movzx     ecx,cl
       test      ecx,ecx
       test      ecx,ecx
       je        short M06_L04
       je        short M06_L04
       mov       rcx,[rbp-8]
       mov       rcx,[rbp-8]
       call      System.Threading.Monitor.Exit(System.Object)
       call      System.Threading.Monitor.Exit(System.Object)
       nop
       nop
M06_L04:
       nop
M06_L04:
       nop
       add       rsp,30
       add       rsp,30
       pop       rbp
       pop       rbp
       ret
       ret
; Total bytes of code 514
```
```assembly
; DotNetTips.Spargine.Benchmarking.Benchmark.Consume[[System.Int32, System.Private.CoreLib]](Int32)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FFDF01E6918],0
       je        short M07_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M07_L00:
       mov       rcx,[rbp+10]
       call      qword ptr [7FFDF0214B10]; DotNetTips.Spargine.Benchmarking.Benchmark.get_Consumer()
       mov       [rbp-10],rax
       lea       rdx,[rbp+18]
       mov       rcx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FFDF088C570]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Int32, System.Private.CoreLib]](Int32 ByRef)
       nop
       nop
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 77
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
       mov       eax,ebp
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       short M08_L01
       mov       edx,4
M08_L00:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,eax
       cmovl     edx,eax
       mov       rcx,rbx
       call      qword ptr [7FFDEFFBDFF8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
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
       mov       rcx,[rbx+8]
       mov       edx,[rcx+8]
       add       edx,edx
       jmp       short M08_L00
; Total bytes of code 104
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF06DF030]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF06DEB98]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF06DEA90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF06DEE20]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF06DF1F8]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF06DF1F8]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF06DEAA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0724E88]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07249F0]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07248E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0724C78]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0725050]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0725050]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0724900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0754E88]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07549F0]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07548E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF1D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0754C78]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0755050]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0755050]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0754900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00C4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF07BC198]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07B7C60]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07B7B58]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF07B7EE8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF07BC360]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF07BC360]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF07B7B70]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0827288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0826DF0]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0826CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0827078]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0827450]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0827450]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0826D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0817288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0816DF0]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0816CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0817078]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0817450]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0817450]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0816D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0837030]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836B98]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836E20]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF08371F8]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF08371F8]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0857288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsyncIEnumerableAsync>d__8 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0856DF0]
       jmp       short M00_L00
; Total bytes of code 90
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0856CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF1D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0857078]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsyncIEnumerableAsync>d__8.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0857450]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0857450]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0856D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00C4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF06FF288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF06FEDF0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF06FECE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF0D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF06FF078]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF06FF450]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF06FF450]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF06FED00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00B4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0744E88]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07449F0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07448E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF0D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0744C78]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0745050]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0745050]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0744900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00B4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0714E88]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07149F0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07148E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0714C78]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0715050]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0715050]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0714900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0734E88]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07349F0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07348E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0734C78]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0735050]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0735050]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0734900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0837288]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836DF0]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0837078]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0837450]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0837450]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0837030]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836B98]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836E20]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF08371F8]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF08371F8]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0827030]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0826B98]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0826A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0826E20]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF08271F8]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF08271F8]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0826AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF08179D8]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteReadAsync>d__7 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,68
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0817540]
       jmp       short M00_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0817438]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF08177C8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteReadAsync>d__7.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0817BA0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0817BA0]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0817450]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0714C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07149F0]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07148E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0714B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0714E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0714E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0714900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0714C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07149F0]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07148E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0714B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0714E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0714E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0714900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0744C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07449F0]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07448E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF0D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0744B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0744E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0744E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0744900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00B4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0754C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07549F0]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07548E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF1D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0754B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0754E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0754E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00C4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00C42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0754900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00C4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0806E08]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0806B98]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0806A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0806CD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0806FD0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0806FD0]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0806AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0836E08]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836B98]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836CD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0836FD0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0836FD0]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF08277B0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0827540]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0827438]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0827678]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0827978]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0827978]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0827450]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0837060]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsyncIEnumerableAsync>d__5 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836DF0]
       jmp       short M00_L00
; Total bytes of code 84
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836F28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsyncIEnumerableAsync>d__5.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0837228]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0837228]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF06CF060]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF06CEDF0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF06CECE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF06CEF28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF06CF228]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF06CF228]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF06CED00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0714C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07149F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07148E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0714B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0714E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0714E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0714900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0724C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07249F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07248E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0724B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0724E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0724E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0724900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0744C60]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF07449F0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF07448E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFF0D1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0744B28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0744E28]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0744E28]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00B4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00B42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0744900]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00B4768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0817060]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0816DF0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0816CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0816F28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0817228]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0817228]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0816D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0817060]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0816DF0]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0816CE8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEDD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0816F28]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0817228]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0817228]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0084B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00842E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0816D00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0084768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0827AE0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0827870]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0827768]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEED1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF08279A8]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0827CA8]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0827CA8]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF0094B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00942E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0827780]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF0094768]
       jmp       short M04_L02
; Total bytes of code 139
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFDF0836E08]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4, DotNetTips.Spargine.Core.BenchmarkTests]](<WriteAsync>d__4 ByRef)
       mov       rax,[rsp+40]
       test      rax,rax
       je        short M00_L01
M00_L00:
       add       rsp,58
       ret
M00_L01:
       lea       rcx,[rsp+40]
       call      qword ptr [7FFDF0836B98]
       jmp       short M00_L00
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.GetAwaiter()
       mov       rax,rcx
       ret
; Total bytes of code 4
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.GetResult()
       mov       rcx,[rcx]
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M02_L00
       ret
M02_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDF0836A90]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 29
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
       cmp       dword ptr [rax+190],3
       jl        short M03_L04
       mov       rax,[rax+198]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M03_L04
       mov       rax,[rax]
       add       rax,10
M03_L00:
       mov       rax,[rax+18]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDEFEFD1D0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       [rbp-10],rax
       mov       rdx,[rax+8]
       mov       [rbp-18],rdx
       mov       rax,[rax+10]
       mov       [rbp-20],rax
       mov       rcx,rbx
       call      qword ptr [7FFDF0836CD0]; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Threading.ChannelQueueCollectionBenchmark+<WriteAsync>d__4.MoveNext()
       nop
       mov       rax,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rax,[rcx+10]
       jne       short M03_L05
M03_L02:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L03
       call      qword ptr [7FFDF0836FD0]
M03_L03:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M03_L04:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L00
M03_L05:
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
       jmp       short M03_L02
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rdx,[rbp-20]
       mov       rcx,[rbp-10]
       cmp       rdx,[rcx+10]
       je        short M03_L06
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-10]
M03_L06:
       mov       r8,[rcx+8]
       mov       rdx,[rbp-18]
       cmp       rdx,r8
       je        short M03_L07
       call      qword ptr [7FFDF0836FD0]
M03_L07:
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
       jne       short M04_L00
       mov       rcx,rbx
       xor       r8d,r8d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFDF00A4B28]; System.Threading.Tasks.Task.InternalWaitCore(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FFDF00A42E8]
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       je        short M04_L02
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FFDF0836AA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDF00A4768]
       jmp       short M04_L02
; Total bytes of code 139
```

