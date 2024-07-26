## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogApplicationInformation()
       mov       rcx,[rcx+118]
       jmp       qword ptr [7FFE338254A0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       vzeroupper
       lea       rbp,[rsp+1D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-1A0],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L178
       mov       rdx,2667B003A30
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L179
       mov       r14,[rcx+18]
M01_L01:
       mov       [rbp-40],r14
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Core.AppInfo, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.AppInfo ByRef)
       call      qword ptr [7FFE338260E8]; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L177
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE33827CF0]; System.Linq.Enumerable.LongCount[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       test      rax,rax
       jle       near ptr M01_L177
       mov       rcx,2667B003C50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L03
M01_L02:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L180
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,26677001DC8
       mov       r15,[rcx]
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+18],ecx
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-108],r13
       jmp       short M01_L04
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2667B003C48
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogApplicationInformation>b__15_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,2667B003C50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L04:
       test      r13,r13
       je        near ptr M01_L152
       mov       rdx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rdx
       jne       near ptr M01_L152
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rdx
       jne       near ptr M01_L152
       jmp       near ptr M01_L19
M01_L05:
       vmovdqu   xmm0,xmmword ptr [r13+20]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,26677001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE33323950]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L101
       lea       r10,[rax+10]
       mov       r9d,[rax+8]
M01_L06:
       xor       r8d,r8d
       mov       [rbp-78],r8
       mov       [rbp-70],rax
       mov       [rbp-68],r8d
       mov       byte ptr [rbp-64],0
       mov       [rbp-60],r10
       mov       [rbp-58],r9d
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L102
       mov       r11d,[rbp-68]
       cmp       r11d,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,r11d
       lea       rdx,[r8+rcx*2]
       mov       ecx,[rbp-58]
       sub       ecx,r11d
       cmp       ecx,7
       jb        near ptr M01_L102
       mov       r8,2A704F1ADBC
       mov       rax,[r8]
       mov       rcx,[r8+6]
       mov       [rdx],rax
       mov       [rdx+6],rcx
       mov       r8d,[rbp-68]
       add       r8d,7
       mov       [rbp-68],r8d
M01_L07:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,eax
       cmp       r8d,1
       jb        near ptr M01_L103
       mov       rax,2A704F00A4C
       movzx     r8d,word ptr [rax]
       mov       [rcx],r8w
       mov       r8d,[rbp-68]
       inc       r8d
       mov       [rbp-68],r8d
M01_L08:
       mov       rsi,[rbp-50]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L104
       test      rsi,rsi
       je        near ptr M01_L104
       mov       r8d,[rbp-68]
       cmp       r8d,[rbp-58]
       ja        near ptr M01_L91
       mov       rcx,[rbp-60]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-58]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L104
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE330F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-68]
       add       r8d,[rsi+8]
       mov       [rbp-68],r8d
M01_L09:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L105
       mov       r11,2A704F1ADE4
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-68]
       add       r8d,3
       mov       [rbp-68],r8d
M01_L10:
       mov       rdi,[rbp-48]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L106
       test      rdi,rdi
       je        near ptr M01_L106
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rdi+8],r8d
       ja        near ptr M01_L106
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFE330F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rdi+8]
       mov       [rbp-68],ecx
M01_L11:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       rdx,[rbp-60]
       mov       [rbp-0E0],rdx
       mov       [rbp-0D8],eax
       lea       rcx,[rbp-0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp-70]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       test      rdi,rdi
       je        near ptr M01_L14
       mov       rcx,26677001DD8
       mov       r12,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE32F85120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L100
M01_L12:
       xor       r8d,r8d
       mov       dword ptr [rbp-80],1
       cmp       [rax+8],r14d
       jbe       short M01_L13
       mov       dword ptr [rbp-7C],1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L34
       mov       ecx,r14d
       shl       rcx,4
       lea       r9,[rax+rcx+10]
       mov       r11,[r9]
       mov       [rbp-128],r11
       mov       [rbp-120],r9
       mov       rcx,r9
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       edx,edx
       mov       rax,[rbp-120]
       mov       [rax+8],edx
       mov       r8,[rbp-128]
       test      r8,r8
       mov       [rbp-128],r8
       mov       r8d,[rbp-7C]
       jne       near ptr M01_L98
M01_L13:
       mov       rdx,266770005D0
       mov       r9,[rdx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L97
M01_L14:
       mov       rcx,[rbx+8]
       mov       rdx,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rdx
       jne       near ptr M01_L123
       xor       edx,edx
       mov       [rbp-0B0],rdx
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M01_L96
       xor       edx,edx
       mov       [rbp-0B0],rdx
       xor       r12d,r12d
       cmp       dword ptr [r14+8],0
       jg        near ptr M01_L94
M01_L15:
       cmp       qword ptr [rbp-0B0],0
       jne       near ptr M01_L93
M01_L16:
       xor       r11d,r11d
       cmp       [r14+8],r12d
       setg      r11b
M01_L17:
       xor       edx,edx
       mov       [rbp-0B0],rdx
M01_L18:
       test      r11d,r11d
       jne       near ptr M01_L92
M01_L19:
       mov       r14,r13
       mov       r12d,[r14+18]
       mov       rsi,[r14+8]
       test      r12d,r12d
       je        short M01_L23
       cmp       r12d,1
       jne       near ptr M01_L176
       mov       dword ptr [r14+18],0FFFFFFFF
       mov       edx,[r14+1C]
       inc       edx
       mov       [r14+1C],edx
       cmp       edx,[r14+38]
       jge       short M01_L22
M01_L20:
       lea       rdi,[r14+20]
       mov       rax,[r14+30]
       mov       rcx,[r14+10]
       mov       edx,[r14+1C]
       cmp       edx,[rcx+8]
       jae       short M01_L21
       mov       edx,[rcx+rdx*4+10]
       cmp       edx,[rax+8]
       jae       short M01_L21
       mov       ecx,edx
       shl       rcx,4
       lea       rsi,[rax+rcx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       dword ptr [r14+18],1
       jmp       near ptr M01_L05
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L22:
       xor       edx,edx
       mov       [r14+10],rdx
       jmp       near ptr M01_L176
M01_L23:
       mov       dword ptr [r14+18],0FFFFFFFF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rdi,[rsi+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE33044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L31
       lea       r8,[rbp-0B8]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FFE3382CC18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rbp-0C0],rax
M01_L24:
       lea       rcx,[r14+30]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B8]
       mov       [r14+38],ecx
       mov       edi,[r14+38]
       test      edi,edi
       jle       near ptr M01_L176
       mov       r12,[r14+30]
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L69
       mov       rax,[rsi+20]
       cmp       rax,r15
       mov       [rbp-140],rax
       jne       near ptr M01_L126
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L30
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L30
       mov       rdx,[rcx]
       add       rdx,10
M01_L25:
       mov       r8,[rdx+8]
       mov       r10,r8
       test      r10,r10
       mov       [rbp-158],r10
       jne       short M01_L26
       mov       r10,26677000438
       mov       r10,[r10]
       mov       r9,r10
       test      r9,r9
       mov       [rbp-158],r9
       jne       short M01_L26
       mov       r9,26677000418
       mov       r9,[r9]
       mov       r11,r9
       mov       [rbp-158],r11
       test      r11,r11
       je        near ptr M01_L29
M01_L26:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rdx,[rbp-158]
       cmp       [rdx],rcx
       jne       near ptr M01_L124
       mov       r8,rdx
       mov       rdx,[r8+8]
       test      rdx,rdx
       je        short M01_L28
M01_L27:
       jmp       near ptr M01_L125
M01_L28:
       mov       rdx,[r8+30]
       mov       [rbp-160],r8
       cmp       byte ptr [rdx+1B9],0
       jne       near ptr M01_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       mov       rcx,rax
       mov       rdx,[rbp-160]
       call      qword ptr [7FFE333F4F60]
       mov       rax,[rbp-160]
       mov       rdx,rax
       mov       r8,[rbp-178]
       mov       rcx,r8
       mov       [rbp-170],rcx
       jmp       short M01_L33
M01_L29:
       call      qword ptr [7FFE331B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       [rbp-158],rax
       jmp       near ptr M01_L26
M01_L30:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M01_L25
M01_L31:
       mov       rcx,rax
       mov       r11,7FFE32F00C30
       call      qword ptr [r11]
       mov       [rbp-0C0],rax
       mov       ecx,[rax+8]
       mov       [rbp-0B8],ecx
       jmp       near ptr M01_L24
M01_L32:
       mov       rdx,r8
       mov       [rbp-168],rdx
       mov       rcx,[rdx+40]
       call      qword ptr [7FFE331B4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       [rbp-170],rax
       mov       rdx,[rbp-168]
M01_L33:
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-170]
       mov       rdx,rcx
       jmp       near ptr M01_L27
M01_L34:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE3354EAC0]
       mov       r15,rax
       mov       ecx,1D3
       mov       rdx,7FFE32EF4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FFE3304F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L35:
       lea       r9d,[rdi-1]
       mov       rcx,rsi
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L170
M01_L36:
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L167
M01_L37:
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L38
       mov       rdx,offset MT_System.String[]
       cmp       [rcx],rdx
       je        short M01_L38
       mov       rcx,rdx
       mov       rdx,r12
       call      qword ptr [7FFE33044390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L38:
       mov       rax,[rbp-180]
       lea       rcx,[rax+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L166
M01_L39:
       mov       [rbp-0C8],r10d
       mov       [rbp-190],rax
       mov       [rbp-0F0],r8
       mov       [rbp-0E8],r11
       lea       rdx,[rbp-0F0]
       mov       rcx,[r9+8]
       mov       [rbp-188],r9
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rbp-190]
       mov       r10d,[rbp-0C8]
       jmp       near ptr M01_L164
M01_L40:
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L162
M01_L41:
       mov       rcx,[rsi+10]
       mov       rdx,r10
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       mov       r10,rsi
       jmp       near ptr M01_L161
M01_L42:
       mov       rcx,[rdx+30]
       mov       [rbp-160],rdx
       cmp       byte ptr [rcx+1B9],0
       jne       near ptr M01_L87
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-178],rcx
       mov       rdx,[rbp-160]
       call      qword ptr [7FFE333F4F60]
       mov       rdx,[rbp-160]
       mov       rax,rdx
       mov       rcx,[rbp-178]
       mov       [rbp-170],rcx
       jmp       near ptr M01_L88
M01_L43:
       call      qword ptr [7FFE331B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-158],rcx
       jmp       near ptr M01_L156
M01_L44:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M01_L155
M01_L45:
       mov       rcx,rax
       mov       r11,7FFE32F00C30
       call      qword ptr [r11]
       mov       [rbp-0C0],rax
       mov       ecx,[rax+8]
       mov       [rbp-0B8],ecx
       jmp       near ptr M01_L154
M01_L46:
       mov       rcx,7FFE333286C0
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2667B003AD8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L152
M01_L47:
       mov       rcx,rbx
       mov       r11,7FFE32F00C20
       mov       edx,2
       call      qword ptr [r11]
       mov       r11d,eax
       jmp       near ptr M01_L151
M01_L48:
       mov       r11,7FFE32F00C28
       mov       edx,2
       call      qword ptr [r11]
       mov       r11d,eax
       jmp       near ptr M01_L151
M01_L49:
       mov       rax,[rbp-0B0]
       cmp       dword ptr [rax+10],0
       jg        near ptr M01_L89
       jmp       near ptr M01_L149
M01_L50:
       cmp       r12d,[r14+8]
       jae       near ptr M01_L21
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*4]
       lea       rdi,[r14+rcx*8+10]
       mov       rcx,rdi
       mov       edx,2
       call      qword ptr [7FFE3377F3C0]
       test      eax,eax
       je        short M01_L51
       mov       rdx,[rdi]
       lea       r8,[rbp-0B0]
       mov       ecx,2
       call      qword ptr [7FFE3377E898]
       test      eax,eax
       jne       near ptr M01_L148
M01_L51:
       inc       r12d
       cmp       [r14+8],r12d
       jg        short M01_L50
       jmp       near ptr M01_L148
M01_L52:
       xor       r11d,r11d
       jmp       near ptr M01_L150
M01_L53:
       mov       r11,rdx
       mov       edx,r8d
       mov       eax,[rbp-80]
       cmp       dword ptr [rdi+8],0
       mov       [rbp-110],r11
       mov       [rbp-7C],edx
       mov       [rbp-80],eax
       je        near ptr M01_L147
       cmp       [rdi],dil
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-84],eax
       mov       r9d,[rdi+8]
       mov       [rbp-88],r9d
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-110]
       mov       r8d,[rbp-84]
       mov       r9d,[rbp-88]
       mov       edx,3
       call      qword ptr [7FFE330F7678]
       mov       eax,[rbp-7C]
       test      [rbp-80],eax
       mov       [rbp-7C],eax
       jne       near ptr M01_L147
       cmp       [rdi],dil
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edx,eax
       mov       edi,[rdi+8]
       mov       r11,[rbp-110]
       mov       [rbp-118],r11
       mov       [rbp-8C],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-7C]
       test      r12d,r12d
       jne       near ptr M01_L83
       mov       r14,[rbp-118]
       mov       edx,[rbp-8C]
       mov       r10d,0FFFFFFFF
       jmp       near ptr M01_L84
M01_L54:
       mov       r9,[r12+10]
       cmp       r14d,[r9+8]
       jae       near ptr M01_L21
       mov       ecx,r14d
       mov       r11,[r9+rcx*8+10]
       test      r11,r11
       mov       [rbp-7C],r8d
       jne       short M01_L55
       mov       rcx,r12
       mov       edx,r14d
       call      qword ptr [7FFE3331E880]
       mov       r11,rax
M01_L55:
       mov       rcx,[r11+8]
       mov       [rbp-130],rcx
       mov       rcx,7FFE32F85120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE32F85C38],0
       je        near ptr M01_L71
       call      qword ptr [7FFE3304DC98]
       mov       [rbp-98],eax
       jmp       near ptr M01_L74
M01_L56:
       mov       rcx,r12
       call      qword ptr [7FFE3331E8F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L145
M01_L57:
       lea       rcx,[rbp-78]
       mov       rdx,rdi
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L144
M01_L58:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F1ADD8
       call      qword ptr [7FFE331858F0]
       jmp       near ptr M01_L143
M01_L59:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L142
M01_L60:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F00A40
       call      qword ptr [7FFE331858F0]
       jmp       near ptr M01_L141
M01_L61:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F1ADB0
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L140
M01_L62:
       xor       r10d,r10d
       xor       r9d,r9d
       jmp       near ptr M01_L139
M01_L63:
       lea       rdx,[rbp-50]
       mov       rcx,r13
       mov       r11,7FFE32F00C10
       call      qword ptr [r11]
       jmp       near ptr M01_L138
M01_L64:
       lea       r9d,[rdi-1]
       mov       rcx,rsi
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L136
M01_L65:
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L133
M01_L66:
       mov       rax,r12
       test      rax,rax
       je        short M01_L67
       mov       rcx,offset MT_System.String[]
       cmp       [rax],rcx
       je        short M01_L67
       mov       rdx,r12
       call      qword ptr [7FFE33044390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L67:
       mov       r9,[rbp-180]
       lea       rcx,[r9+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L132
M01_L68:
       mov       [rbp-0C8],r10d
       mov       [rbp-190],rax
       mov       [rbp-0F0],r8
       mov       [rbp-0E8],r11
       lea       rdx,[rbp-0F0]
       mov       [rbp-188],rcx
       mov       rcx,[rcx+8]
       mov       r9,[rbp-188]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rbp-190]
       mov       r10d,[rbp-0C8]
       jmp       near ptr M01_L130
M01_L69:
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L128
M01_L70:
       mov       rcx,[rsi+10]
       mov       rdx,r10
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       mov       r10,rsi
       jmp       near ptr M01_L127
M01_L71:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rax+0A3C]
       mov       [rbp-9C],ecx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-9C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L72
       call      qword ptr [7FFE338B4CF0]
       jmp       short M01_L73
M01_L72:
       mov       eax,ecx
       sar       eax,10
M01_L73:
       mov       [rbp-98],eax
M01_L74:
       mov       rcx,7FFE32F85120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-98]
       xor       edx,edx
       div       dword ptr [7FFE32F85C2C]
       mov       eax,edx
       xor       r10d,r10d
       xor       edx,edx
       jmp       near ptr M01_L81
M01_L75:
       cmp       eax,[r8+8]
       jae       near ptr M01_L21
       mov       [rbp-90],eax
       mov       ecx,eax
       mov       [rbp-130],r8
       mov       rcx,[r8+rcx*8+10]
       mov       r10,rcx
       cmp       [r10],r10b
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       [rbp-138],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-138]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       mov       r10d,edx
       cmp       [rcx+8],r10d
       jbe       short M01_L77
       test      r10d,r10d
       jne       short M01_L78
       xor       edx,edx
       mov       [rbp-138],rax
       mov       [rax+14],edx
M01_L76:
       mov       [rbp-0A4],r10d
       movsxd    rdx,r10d
       mov       r8,[rbp-128]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0A4]
       inc       ecx
       mov       rax,[rbp-138]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0A0],1
M01_L77:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0A0]
       test      ecx,ecx
       je        short M01_L79
       mov       r10d,1
       jmp       short M01_L82
M01_L78:
       mov       [rbp-138],rax
       jmp       short M01_L76
M01_L79:
       mov       r10d,[rbp-90]
       lea       eax,[r10+1]
       mov       r10d,eax
       mov       rcx,[rbp-130]
       cmp       [rcx+8],r10d
       jne       short M01_L80
       xor       r10d,r10d
M01_L80:
       mov       edx,[rbp-94]
       inc       edx
       mov       [rbp-130],rcx
       mov       eax,r10d
M01_L81:
       mov       r8,[rbp-130]
       mov       [rbp-94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L75
       xor       r10d,r10d
M01_L82:
       mov       eax,r10d
       mov       [rbp-80],eax
       mov       r8d,[rbp-7C]
       jmp       near ptr M01_L146
M01_L83:
       mov       rdx,[rbp-118]
       mov       rcx,rdx
       mov       edx,[rbp-8C]
       mov       r10d,r14d
       mov       r14,rcx
M01_L84:
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L85
       mov       r11d,1
       jmp       short M01_L86
M01_L85:
       xor       r11d,r11d
M01_L86:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE3331F348]
       jmp       near ptr M01_L147
M01_L87:
       mov       [rbp-168],rdx
       mov       rcx,[rdx+40]
       call      qword ptr [7FFE331B4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       [rbp-170],rax
       mov       rax,[rbp-168]
M01_L88:
       lea       rcx,[rax+8]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-170]
       jmp       near ptr M01_L157
M01_L89:
       mov       rcx,[rbp-0B0]
       call      qword ptr [7FFE3377E850]
       int       3
M01_L90:
       call      qword ptr [7FFE330441F8]
       int       3
M01_L91:
       call      qword ptr [7FFE331FE9A0]
       int       3
M01_L92:
       mov       rcx,7FFE333286C0
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2667B003AD8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L19
M01_L93:
       mov       rax,[rbp-0B0]
       cmp       dword ptr [rax+10],0
       jg        short M01_L89
       jmp       near ptr M01_L16
M01_L94:
       cmp       r12d,[r14+8]
       jae       near ptr M01_L21
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*4]
       lea       rdi,[r14+rcx*8+10]
       mov       rcx,rdi
       mov       edx,2
       call      qword ptr [7FFE3377F3C0]
       test      eax,eax
       je        short M01_L95
       mov       rdx,[rdi]
       lea       r8,[rbp-0B0]
       mov       ecx,2
       call      qword ptr [7FFE3377E898]
       test      eax,eax
       jne       near ptr M01_L15
M01_L95:
       inc       r12d
       cmp       [r14+8],r12d
       jg        short M01_L94
       jmp       near ptr M01_L15
M01_L96:
       xor       r11d,r11d
       jmp       near ptr M01_L17
M01_L97:
       mov       ecx,r8d
       mov       r11,r9
       mov       r9d,[rbp-80]
       cmp       dword ptr [rdi+8],0
       mov       [rbp-110],r11
       mov       [rbp-7C],ecx
       mov       [rbp-80],r9d
       je        near ptr M01_L14
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-84],eax
       mov       edx,[rdi+8]
       mov       [rbp-88],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-110]
       mov       r8d,[rbp-84]
       mov       r9d,[rbp-88]
       mov       edx,3
       call      qword ptr [7FFE330F7678]
       mov       eax,[rbp-7C]
       test      [rbp-80],eax
       mov       [rbp-7C],eax
       jne       near ptr M01_L14
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,[rdi+8]
       mov       rdx,[rbp-110]
       mov       [rbp-118],rdx
       mov       [rbp-8C],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-7C]
       test      r12d,r12d
       jne       near ptr M01_L119
       mov       r14,[rbp-118]
       mov       edx,[rbp-8C]
       mov       r10d,0FFFFFFFF
       jmp       near ptr M01_L120
M01_L98:
       mov       r9,[r12+10]
       cmp       r14d,[r9+8]
       jae       near ptr M01_L21
       mov       ecx,r14d
       mov       r11,[r9+rcx*8+10]
       test      r11,r11
       mov       [rbp-7C],r8d
       jne       short M01_L99
       mov       rcx,r12
       mov       edx,r14d
       call      qword ptr [7FFE3331E880]
       mov       r11,rax
M01_L99:
       mov       rax,[r11+8]
       mov       [rbp-130],rax
       mov       rcx,7FFE32F85120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE32F85C38],0
       je        near ptr M01_L107
       call      qword ptr [7FFE3304DC98]
       mov       edx,eax
       mov       [rbp-98],edx
       jmp       near ptr M01_L110
M01_L100:
       mov       rcx,r12
       call      qword ptr [7FFE3331E8F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L12
M01_L101:
       xor       r10d,r10d
       xor       r9d,r9d
       jmp       near ptr M01_L06
M01_L102:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F1ADB0
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L07
M01_L103:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F00A40
       call      qword ptr [7FFE331858F0]
       jmp       near ptr M01_L08
M01_L104:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L09
M01_L105:
       lea       rcx,[rbp-78]
       mov       rdx,2A704F1ADD8
       call      qword ptr [7FFE331858F0]
       jmp       near ptr M01_L10
M01_L106:
       lea       rcx,[rbp-78]
       mov       rdx,rdi
       call      qword ptr [7FFE33185848]
       jmp       near ptr M01_L11
M01_L107:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-9C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-9C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L108
       call      qword ptr [7FFE338B4CF0]
       mov       edx,eax
       jmp       short M01_L109
M01_L108:
       mov       edx,ecx
       sar       edx,10
M01_L109:
       mov       [rbp-98],edx
M01_L110:
       mov       rcx,7FFE32F85120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-98]
       xor       edx,edx
       div       dword ptr [7FFE32F85C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L117
M01_L111:
       cmp       eax,[r8+8]
       jae       near ptr M01_L21
       mov       [rbp-90],eax
       mov       ecx,eax
       mov       [rbp-130],r8
       mov       r10,[r8+rcx*8+10]
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0A0],r9d
       mov       [rbp-138],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-138]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       cmp       [rcx+8],r10d
       jbe       short M01_L113
       test      r10d,r10d
       jne       short M01_L114
       xor       edx,edx
       mov       [rbp-138],rax
       mov       [rax+14],edx
M01_L112:
       mov       [rbp-0A4],r10d
       movsxd    rdx,r10d
       mov       r8,[rbp-128]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0A4]
       inc       ecx
       mov       rax,[rbp-138]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0A0],1
M01_L113:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       eax,[rbp-0A0]
       test      eax,eax
       je        short M01_L115
       mov       r10d,1
       jmp       short M01_L118
M01_L114:
       mov       [rbp-138],rax
       jmp       short M01_L112
M01_L115:
       mov       eax,[rbp-90]
       inc       eax
       mov       edx,eax
       mov       r8,[rbp-130]
       cmp       [r8+8],edx
       jne       short M01_L116
       xor       edx,edx
M01_L116:
       mov       r10d,[rbp-94]
       inc       r10d
       mov       [rbp-130],r8
       mov       eax,edx
       mov       edx,r10d
M01_L117:
       mov       r8,[rbp-130]
       mov       [rbp-94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L111
       xor       r10d,r10d
M01_L118:
       mov       r9d,r10d
       mov       [rbp-80],r9d
       mov       r8d,[rbp-7C]
       jmp       near ptr M01_L13
M01_L119:
       mov       r11,[rbp-118]
       mov       edx,[rbp-8C]
       mov       r10d,r14d
       mov       r14,r11
M01_L120:
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L121
       mov       r11d,1
       jmp       short M01_L122
M01_L121:
       xor       r11d,r11d
M01_L122:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE3331F348]
       jmp       near ptr M01_L14
M01_L123:
       mov       r11,7FFE32F00C28
       mov       edx,2
       call      qword ptr [r11]
       mov       r11d,eax
       jmp       near ptr M01_L18
M01_L124:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
M01_L125:
       mov       rax,[rbp-150]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-150]
       mov       [rax+10],ecx
       mov       [rbp-140],rax
M01_L126:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,[rsi+18]
       movzx     r8d,byte ptr [rsi+28]
       mov       [rbp-0C4],r8d
       mov       [rbp-148],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       mov       r8d,[rbp-0C4]
       mov       [rax+28],r8b
       xor       edx,edx
       mov       [rax+18],rdx
       mov       r10,rax
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L70
M01_L127:
       mov       rsi,r10
M01_L128:
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L65
       mov       r9,rsi
       mov       [rbp-180],r9
       mov       r11,[r9+8]
       mov       rdx,26677001F80
       mov       [rbp-188],r11
       cmp       r11,[rdx]
       je        near ptr M01_L66
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       xor       r10d,r10d
       cmp       dword ptr [rax+8],0
       jle       short M01_L131
M01_L129:
       cmp       r10d,[r12+8]
       jae       near ptr M01_L21
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[r12+rdx+10]
       mov       r8,[r9]
       mov       r11,[r9+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogApplicationInformation>b__15_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rcx,[rbp-188]
       cmp       [rcx+18],rdx
       jne       near ptr M01_L68
       mov       [rbp-188],rcx
       mov       edx,[rcx+8]
M01_L130:
       mov       [rbp-0C8],r10d
       movsxd    rdx,r10d
       mov       [rbp-190],rax
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       r10d,[rbp-0C8]
       inc       r10d
       mov       rax,[rbp-190]
       cmp       [rax+8],r10d
       jg        short M01_L129
M01_L131:
       mov       r8,[rbp-180]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L132:
       mov       rax,[rbp-180]
       mov       rcx,[rax+18]
       test      rcx,rcx
       je        short M01_L133
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M01_L133:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       ecx,ecx
       cmp       dword ptr [r12+8],0
       jle       short M01_L135
M01_L134:
       mov       eax,ecx
       mov       [r12+rax*4+10],ecx
       inc       ecx
       cmp       [r12+8],ecx
       jg        short M01_L134
M01_L135:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L64
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-198],rax
       mov       rcx,rsi
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-0D0],rax
       test      rsi,rsi
       je        near ptr M01_L90
       mov       rdx,[rbp-198]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-198]
       mov       rax,[rbp-0D0]
       mov       [rsi+18],rax
       mov       rdx,rsi
       cmp       [r12+8],edi
       jb        near ptr M01_L91
       lea       r8,[r12+10]
       cmp       edi,1
       jle       short M01_L136
       mov       [rbp-100],r8
       mov       [rbp-0F8],edi
       lea       rcx,[rbp-100]
       call      qword ptr [7FFE332CDE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L136:
       mov       rdx,r12
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+1C],eax
       mov       eax,[r14+1C]
       cmp       eax,[r14+38]
       jge       near ptr M01_L22
       jmp       near ptr M01_L20
M01_L137:
       vmovdqu   xmm0,xmmword ptr [r13+20]
       vmovdqu   xmmword ptr [rbp-50],xmm0
M01_L138:
       mov       rcx,26677001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE33323950]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L62
       lea       r10,[rax+10]
       mov       r9d,[rax+8]
M01_L139:
       xor       r8d,r8d
       mov       [rbp-78],r8
       mov       [rbp-70],rax
       mov       [rbp-68],r8d
       mov       byte ptr [rbp-64],0
       mov       [rbp-60],r10
       mov       [rbp-58],r9d
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L61
       mov       r11d,[rbp-68]
       cmp       r11d,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,r11d
       lea       rdx,[r8+rcx*2]
       mov       ecx,[rbp-58]
       sub       ecx,r11d
       cmp       ecx,7
       jb        near ptr M01_L61
       mov       r8,2A704F1ADBC
       mov       rax,[r8]
       mov       rcx,[r8+6]
       mov       [rdx],rax
       mov       [rdx+6],rcx
       mov       r8d,[rbp-68]
       add       r8d,7
       mov       [rbp-68],r8d
M01_L140:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,eax
       cmp       r8d,1
       jb        near ptr M01_L60
       mov       rax,2A704F00A4C
       movzx     r8d,word ptr [rax]
       mov       [rcx],r8w
       mov       r8d,[rbp-68]
       inc       r8d
       mov       [rbp-68],r8d
M01_L141:
       mov       rsi,[rbp-50]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L59
       test      rsi,rsi
       je        near ptr M01_L59
       mov       r8d,[rbp-68]
       cmp       r8d,[rbp-58]
       ja        near ptr M01_L91
       mov       rcx,[rbp-60]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-58]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE330F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-68]
       add       r8d,[rsi+8]
       mov       [rbp-68],r8d
M01_L142:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L58
       mov       r11,2A704F1ADE4
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-68]
       add       r8d,3
       mov       [rbp-68],r8d
M01_L143:
       mov       rdi,[rbp-48]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L57
       test      rdi,rdi
       je        near ptr M01_L57
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L91
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rdi+8],r8d
       ja        near ptr M01_L57
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFE330F5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rdi+8]
       mov       [rbp-68],ecx
M01_L144:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L91
       mov       rdx,[rbp-60]
       mov       [rbp-0E0],rdx
       mov       [rbp-0D8],eax
       lea       rcx,[rbp-0E0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp-70]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       test      rdi,rdi
       je        near ptr M01_L147
       mov       rcx,26677001DD8
       mov       r12,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE32F85120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L56
M01_L145:
       xor       r8d,r8d
       mov       dword ptr [rbp-80],1
       cmp       [rax+8],r14d
       jbe       short M01_L146
       mov       dword ptr [rbp-7C],1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L34
       cmp       r14d,[rax+8]
       jae       near ptr M01_L21
       mov       ecx,r14d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       rcx,[rax]
       mov       [rbp-128],rcx
       mov       [rbp-120],rax
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       r11,[rbp-120]
       mov       [r11+8],ecx
       mov       rax,[rbp-128]
       test      rax,rax
       mov       [rbp-128],rax
       mov       r8d,[rbp-7C]
       jne       near ptr M01_L54
M01_L146:
       mov       rcx,266770005D0
       mov       r9,[rcx]
       mov       rdx,r9
       cmp       byte ptr [rdx+9D],0
       jne       near ptr M01_L53
M01_L147:
       mov       rcx,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rcx
       jne       near ptr M01_L47
       mov       rcx,[rbx+8]
       mov       r11,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],r11
       jne       near ptr M01_L48
       xor       r11d,r11d
       mov       [rbp-0B0],r11
       mov       r14,[rcx+18]
       test      r14,r14
       je        near ptr M01_L52
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
       xor       r12d,r12d
       cmp       dword ptr [r14+8],0
       jg        near ptr M01_L50
M01_L148:
       cmp       qword ptr [rbp-0B0],0
       jne       near ptr M01_L49
M01_L149:
       xor       r11d,r11d
       cmp       [r14+8],r12d
       setg      r11b
M01_L150:
       xor       ecx,ecx
       mov       [rbp-0B0],rcx
M01_L151:
       test      r11d,r11d
       jne       near ptr M01_L46
M01_L152:
       mov       rdx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rdx
       jne       near ptr M01_L174
       mov       r14,r13
       mov       r12d,[r14+18]
       mov       rsi,[r14+8]
       test      r12d,r12d
       je        short M01_L153
       cmp       r12d,1
       jne       near ptr M01_L176
       mov       dword ptr [r14+18],0FFFFFFFF
       inc       dword ptr [r14+1C]
       mov       edx,[r14+1C]
       cmp       edx,[r14+38]
       jl        near ptr M01_L171
       jmp       near ptr M01_L175
M01_L153:
       mov       dword ptr [r14+18],0FFFFFFFF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0C0],xmm0
       mov       rdi,[rsi+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE33044348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L45
       lea       r8,[rbp-0B8]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FFE3382CC18]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rbp-0C0],rax
M01_L154:
       lea       rcx,[r14+30]
       mov       rdx,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B8]
       mov       [r14+38],ecx
       cmp       dword ptr [r14+38],0
       jle       near ptr M01_L176
       mov       r12,[r14+30]
       mov       edi,[r14+38]
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       rdx,[rsi+20]
       mov       rax,rdx
       cmp       rax,r15
       mov       [rbp-140],rax
       jne       near ptr M01_L160
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L44
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L44
       mov       rdx,[rcx]
       add       rdx,10
M01_L155:
       mov       r8,[rdx+8]
       mov       rdx,r8
       mov       r8,rdx
       test      r8,r8
       mov       [rbp-158],r8
       jne       short M01_L156
       mov       r8,26677000438
       mov       r10,[r8]
       mov       r8,r10
       test      r8,r8
       mov       [rbp-158],r8
       jne       short M01_L156
       mov       r8,26677000418
       mov       r9,[r8]
       mov       r8,r9
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L43
M01_L156:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-150],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       r8,[rbp-158]
       cmp       [r8],rcx
       jne       short M01_L158
       mov       rdx,r8
       mov       rcx,[rdx+8]
       test      rcx,rcx
       je        near ptr M01_L42
M01_L157:
       mov       rdx,rcx
       jmp       short M01_L159
M01_L158:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
M01_L159:
       mov       rax,[rbp-150]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-150]
       mov       [rax+10],ecx
       mov       [rbp-140],rax
M01_L160:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r10,rax
       mov       rdx,[rsi+18]
       movzx     r8d,byte ptr [rsi+28]
       mov       [rbp-0C4],r8d
       mov       [rbp-148],r10
       lea       rcx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-148]
       lea       rcx,[r10+10]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-148]
       mov       edx,[rbp-0C4]
       mov       [r10+28],dl
       xor       edx,edx
       mov       [r10+18],rdx
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L41
M01_L161:
       mov       rsi,r10
M01_L162:
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L36
       mov       rax,rsi
       mov       [rbp-180],rax
       mov       rcx,[rax+8]
       mov       r8,rcx
       mov       rdx,26677001F80
       mov       [rbp-188],r8
       cmp       r8,[rdx]
       je        near ptr M01_L37
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       xor       r10d,r10d
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L173
M01_L163:
       cmp       r10d,[r12+8]
       jae       near ptr M01_L21
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[r12+rdx+10]
       mov       r8,[r9]
       mov       r11,[r9+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogApplicationInformation>b__15_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-188]
       cmp       [r9+18],rdx
       jne       near ptr M01_L39
       mov       [rbp-188],r9
       mov       edx,[r9+8]
M01_L164:
       mov       [rbp-0C8],r10d
       movsxd    rdx,r10d
       mov       [rbp-190],rax
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0C8]
       inc       eax
       mov       rdx,[rbp-190]
       cmp       [rdx+8],eax
       mov       r10d,eax
       jg        near ptr M01_L172
M01_L165:
       mov       r8,[rbp-180]
       lea       rcx,[r8+20]
       call      CORINFO_HELP_ASSIGN_REF
M01_L166:
       mov       rax,[rbp-180]
       mov       rcx,[rax+18]
       test      rcx,rcx
       je        short M01_L167
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M01_L167:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       ecx,ecx
       cmp       dword ptr [r12+8],0
       jle       short M01_L169
M01_L168:
       mov       eax,ecx
       mov       [r12+rax*4+10],ecx
       inc       ecx
       cmp       [r12+8],ecx
       jg        short M01_L168
M01_L169:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L35
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-198],rax
       mov       rcx,rsi
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-0D0],rax
       test      rsi,rsi
       je        near ptr M01_L90
       mov       rdx,[rbp-198]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-198]
       mov       rcx,[rbp-0D0]
       mov       [rsi+18],rcx
       mov       rdx,rsi
       cmp       [r12+8],edi
       jb        near ptr M01_L91
       lea       r8,[r12+10]
       cmp       edi,1
       jle       short M01_L170
       mov       [rbp-100],r8
       mov       [rbp-0F8],edi
       lea       rcx,[rbp-100]
       call      qword ptr [7FFE332CDE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L170:
       mov       rdx,r12
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+1C],eax
       mov       eax,[r14+1C]
       cmp       eax,[r14+38]
       jge       short M01_L175
M01_L171:
       lea       rdi,[r14+20]
       mov       rax,[r14+30]
       mov       rcx,[r14+10]
       mov       edx,[r14+1C]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L21
       mov       edx,[rcx+rdx*4+10]
       cmp       edx,[rax+8]
       jae       near ptr M01_L21
       mov       ecx,edx
       shl       rcx,4
       lea       rsi,[rax+rcx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       dword ptr [r14+18],1
       jmp       near ptr M01_L137
M01_L172:
       mov       rax,rdx
       jmp       near ptr M01_L163
M01_L173:
       mov       rdx,rax
       jmp       near ptr M01_L165
M01_L174:
       mov       rcx,r13
       mov       r11,7FFE32F00C08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L63
       jmp       short M01_L176
M01_L175:
       xor       ecx,ecx
       mov       [r14+10],rcx
M01_L176:
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rax
       jne       near ptr M01_L181
M01_L177:
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L178:
       call      qword ptr [7FFE3359DE30]
       mov       ecx,26D4
       mov       rdx,7FFE33327CC0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE33327CC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE33046B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,9EA
       mov       rdx,7FFE33327CC0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE33046B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE3359DC20]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rsi
       call      qword ptr [7FFE33226670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L179:
       call      qword ptr [7FFE333F4678]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L180:
       mov       ecx,9
       call      qword ptr [7FFE33224F30]
       int       3
M01_L181:
       mov       rcx,r13
       mov       r11,7FFE32F00C18
       call      qword ptr [r11]
       jmp       near ptr M01_L177
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1D0]
       cmp       qword ptr [rbp-108],0
       je        short M01_L182
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       rax,[rbp-108]
       cmp       [rax],rcx
       je        short M01_L182
       mov       rcx,rax
       mov       r11,7FFE32F00C18
       call      qword ptr [r11]
M01_L182:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 8297
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogComputerInformation()
       mov       rcx,[rcx+118]
       jmp       qword ptr [7FFE33844960]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       vzeroupper
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0F0],xmm4
       vmovdqa   xmmword ptr [rbp-0E0],xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-1A0],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L156
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ComputerInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE338449A8]; DotNetTips.Spargine.Core.ComputerInfo..ctor()
       mov       [rbp-40],rsi
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[DotNetTips.Spargine.Core.ComputerInfo, DotNetTips.Spargine.8.Core]](DotNetTips.Spargine.Core.ComputerInfo ByRef)
       call      qword ptr [7FFE33845440]; DotNetTips.Spargine.Core.TypeHelper.GetPropertyValues[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L155
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.LongCount[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE3390CAC8]; System.Linq.Enumerable.LongCount[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       test      rax,rax
       jle       near ptr M01_L155
       mov       rcx,20587405C50
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L02
M01_L01:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L157
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20587401DC8
       mov       r15,[rcx]
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       xor       ecx,ecx
       mov       [r13+18],ecx
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-100],r13
       jmp       short M01_L03
M01_L02:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,20587405C40
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogComputerInformation>b__16_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,20587405C50
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L03:
       test      r13,r13
       je        near ptr M01_L127
       mov       rdx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rdx
       jne       near ptr M01_L127
       jmp       near ptr M01_L14
M01_L04:
       vmovdqu   xmm0,xmmword ptr [r13+20]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,20587401DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE33343A40]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L87
       lea       r8,[rax+10]
       mov       r10d,[rax+8]
M01_L05:
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       [rbp-70],rax
       mov       [rbp-68],ecx
       mov       byte ptr [rbp-64],0
       mov       [rbp-60],r8
       mov       [rbp-58],r10d
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L18
       mov       r9d,[rbp-68]
       cmp       r9d,[rbp-58]
       ja        near ptr M01_L86
       mov       rcx,[rbp-60]
       mov       edx,r9d
       lea       r11,[rcx+rdx*2]
       mov       edx,[rbp-58]
       sub       edx,r9d
       cmp       edx,0C
       jb        near ptr M01_L18
       mov       rcx,2461912ADBC
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmm1,xmmword ptr [rcx+8]
       vmovdqu   xmmword ptr [r11],xmm0
       vmovdqu   xmmword ptr [r11+8],xmm1
       mov       ecx,[rbp-68]
       add       ecx,0C
       mov       [rbp-68],ecx
M01_L06:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,1
       jb        near ptr M01_L31
       mov       r11,24619110A4C
       movzx     r8d,word ptr [r11]
       mov       [r10],r8w
       mov       r8d,[rbp-68]
       inc       r8d
       mov       [rbp-68],r8d
       mov       rsi,[rbp-50]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L32
M01_L07:
       test      rsi,rsi
       je        near ptr M01_L32
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M01_L32
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE33115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rsi+8]
       mov       [rbp-68],ecx
M01_L08:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L36
       mov       r11,2461912ADEC
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-68]
       add       r8d,3
       mov       [rbp-68],r8d
       mov       rsi,[rbp-48]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L37
M01_L09:
       test      rsi,rsi
       je        near ptr M01_L37
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M01_L37
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE33115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rsi+8]
       mov       [rbp-68],ecx
M01_L10:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       rdx,[rbp-60]
       mov       [rbp-0D8],rdx
       mov       [rbp-0D0],eax
       lea       rcx,[rbp-0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp-70]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       test      rdi,rdi
       je        near ptr M01_L13
       mov       rcx,20587401DD8
       mov       r12,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE32FA5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L88
M01_L11:
       xor       r8d,r8d
       mov       dword ptr [rbp-80],1
       cmp       [rax+8],r14d
       jbe       short M01_L12
       mov       dword ptr [rbp-7C],1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L50
       mov       ecx,r14d
       shl       rcx,4
       lea       r9,[rax+rcx+10]
       mov       r11,[r9]
       mov       [rbp-120],r11
       mov       [rbp-118],r9
       mov       rcx,r9
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-118]
       mov       [rax+8],ecx
       mov       r10,[rbp-120]
       test      r10,r10
       mov       [rbp-120],r10
       mov       r8d,[rbp-7C]
       jne       near ptr M01_L89
M01_L12:
       mov       rcx,205874005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L103
M01_L13:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,2461912AE00
       call      qword ptr [7FFE338455C0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
M01_L14:
       mov       r14,r13
       mov       r12d,[r14+18]
       mov       rsi,[r14+8]
       test      r12d,r12d
       je        near ptr M01_L39
       cmp       r12d,1
       jne       near ptr M01_L154
       mov       dword ptr [r14+18],0FFFFFFFF
       mov       edx,[r14+1C]
       inc       edx
       mov       [r14+1C],edx
       cmp       edx,[r14+38]
       jge       short M01_L17
M01_L15:
       lea       rdi,[r14+20]
       mov       rax,[r14+30]
       mov       rcx,[r14+10]
       mov       edx,[r14+1C]
       cmp       edx,[rcx+8]
       jae       short M01_L16
       mov       edx,[rcx+rdx*4+10]
       cmp       edx,[rax+8]
       jae       short M01_L16
       mov       ecx,edx
       shl       rcx,4
       lea       rsi,[rax+rcx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       dword ptr [r14+18],1
       jmp       near ptr M01_L04
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L17:
       xor       edx,edx
       mov       [r14+10],rdx
       jmp       near ptr M01_L154
M01_L18:
       lea       rcx,[rbp-78]
       mov       rdx,2461912ADB0
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L06
M01_L19:
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L29
       mov       r9,rsi
       mov       [rbp-180],r9
       mov       r11,[r9+8]
       mov       rdx,20587401FB8
       mov       [rbp-188],r11
       cmp       r11,[rdx]
       je        near ptr M01_L27
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       xor       r10d,r10d
       cmp       dword ptr [rax+8],0
       jle       short M01_L22
M01_L20:
       cmp       r10d,[r12+8]
       jae       near ptr M01_L16
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[r12+rdx+10]
       mov       r8,[r9]
       mov       r11,[r9+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogComputerInformation>b__16_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rcx,[rbp-188]
       cmp       [rcx+18],rdx
       jne       near ptr M01_L26
       mov       [rbp-188],rcx
       mov       edx,[rcx+8]
M01_L21:
       mov       [rbp-0C0],r10d
       movsxd    rdx,r10d
       mov       [rbp-190],rax
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       r10d,[rbp-0C0]
       inc       r10d
       mov       rax,[rbp-190]
       cmp       [rax+8],r10d
       jg        short M01_L20
M01_L22:
       mov       r8,[rbp-180]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L23:
       mov       rax,[rbp-180]
       mov       rcx,[rax+18]
       test      rcx,rcx
       je        near ptr M01_L33
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L33
M01_L24:
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L19
       nop       word ptr [rax+rax]
M01_L25:
       mov       rcx,[rsi+10]
       mov       rdx,r10
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       mov       r10,rsi
       jmp       near ptr M01_L114
M01_L26:
       mov       [rbp-0C0],r10d
       mov       [rbp-190],rax
       mov       [rbp-0E8],r8
       mov       [rbp-0E0],r11
       lea       rdx,[rbp-0E8]
       mov       [rbp-188],rcx
       mov       rcx,[rcx+8]
       mov       r9,[rbp-188]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rbp-190]
       mov       r10d,[rbp-0C0]
       jmp       near ptr M01_L21
M01_L27:
       mov       rax,r12
       test      rax,rax
       je        short M01_L28
       mov       rcx,offset MT_System.String[]
       cmp       [rax],rcx
       je        short M01_L28
       mov       rdx,r12
       call      qword ptr [7FFE33064390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L28:
       mov       r9,[rbp-180]
       lea       rcx,[r9+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L23
M01_L29:
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L33
M01_L30:
       lea       r9d,[rdi-1]
       mov       rcx,rsi
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L115
M01_L31:
       lea       rcx,[rbp-78]
       mov       rdx,24619110A40
       call      qword ptr [7FFE331A58F0]
       mov       rsi,[rbp-50]
       cmp       byte ptr [rbp-64],0
       je        near ptr M01_L07
M01_L32:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L08
M01_L33:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       ecx,ecx
       cmp       dword ptr [r12+8],0
       jle       short M01_L35
M01_L34:
       mov       eax,ecx
       mov       [r12+rax*4+10],ecx
       inc       ecx
       cmp       [r12+8],ecx
       jg        short M01_L34
M01_L35:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L30
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-198],rax
       mov       rcx,rsi
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-0C8],rax
       test      rsi,rsi
       je        near ptr M01_L85
       mov       rdx,[rbp-198]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-198]
       mov       rax,[rbp-0C8]
       mov       [rsi+18],rax
       mov       rdx,rsi
       cmp       [r12+8],edi
       jb        near ptr M01_L86
       lea       r8,[r12+10]
       cmp       edi,1
       jle       near ptr M01_L115
       mov       [rbp-0F8],r8
       mov       [rbp-0F0],edi
       lea       rcx,[rbp-0F8]
       call      qword ptr [7FFE332EDE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       jmp       near ptr M01_L115
M01_L36:
       lea       rcx,[rbp-78]
       mov       rdx,2461912ADE0
       call      qword ptr [7FFE331A58F0]
       mov       rsi,[rbp-48]
       cmp       byte ptr [rbp-64],0
       je        near ptr M01_L09
M01_L37:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L10
M01_L38:
       mov       rcx,r13
       mov       r11,7FFE32F20E88
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L57
       jmp       near ptr M01_L154
M01_L39:
       mov       dword ptr [r14+18],0FFFFFFFF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       rdi,[rsi+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE33064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L47
       lea       r8,[rbp-0B0]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FFE3390D800]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rbp-0B8],rax
M01_L40:
       lea       rcx,[r14+30]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B0]
       mov       [r14+38],ecx
       mov       edi,[r14+38]
       test      edi,edi
       jle       near ptr M01_L154
       mov       r12,[r14+30]
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L24
       mov       rax,[rsi+20]
       cmp       rax,r15
       mov       [rbp-138],rax
       jne       near ptr M01_L113
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L46
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L46
       mov       rdx,[rcx]
       add       rdx,10
M01_L41:
       mov       r8,[rdx+8]
       mov       r10,r8
       test      r10,r10
       mov       [rbp-150],r10
       jne       short M01_L42
       mov       r10,20587400438
       mov       r10,[r10]
       mov       r9,r10
       test      r9,r9
       mov       [rbp-150],r9
       jne       short M01_L42
       mov       r9,20587400418
       mov       r9,[r9]
       mov       r11,r9
       mov       [rbp-150],r11
       test      r11,r11
       je        near ptr M01_L45
M01_L42:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rdx,[rbp-150]
       cmp       [rdx],rcx
       jne       near ptr M01_L111
       mov       r8,rdx
       mov       rdx,[r8+8]
       test      rdx,rdx
       je        short M01_L44
M01_L43:
       jmp       near ptr M01_L112
M01_L44:
       mov       rdx,[r8+30]
       mov       [rbp-160],r8
       cmp       byte ptr [rdx+1B9],0
       jne       near ptr M01_L48
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       mov       rcx,rax
       mov       rdx,[rbp-160]
       call      qword ptr [7FFE33414F60]
       mov       rax,[rbp-160]
       mov       rdx,rax
       mov       r8,[rbp-178]
       mov       rcx,r8
       mov       [rbp-170],rcx
       jmp       short M01_L49
M01_L45:
       call      qword ptr [7FFE331D4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       [rbp-150],rax
       jmp       near ptr M01_L42
M01_L46:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M01_L41
M01_L47:
       mov       rcx,rax
       mov       r11,7FFE32F20EA8
       call      qword ptr [r11]
       mov       [rbp-0B8],rax
       mov       ecx,[rax+8]
       mov       [rbp-0B0],ecx
       jmp       near ptr M01_L40
M01_L48:
       mov       rdx,r8
       mov       [rbp-168],rdx
       mov       rcx,[rdx+40]
       call      qword ptr [7FFE331D4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       [rbp-170],rax
       mov       rdx,[rbp-168]
M01_L49:
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-170]
       mov       rdx,rcx
       jmp       near ptr M01_L43
M01_L50:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE3356EAC0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE32F14000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE3306F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,[rsi+10]
       mov       rdx,r10
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       mov       r10,rsi
       jmp       near ptr M01_L149
M01_L52:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L144
M01_L53:
       mov       rcx,rax
       mov       r11,7FFE32F20EA8
       call      qword ptr [r11]
       mov       [rbp-0B8],rax
       mov       ecx,[rax+8]
       mov       [rbp-0B0],ecx
       jmp       near ptr M01_L151
M01_L54:
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       near ptr M01_L118
M01_L55:
       lea       rcx,[rbp-78]
       mov       rdx,2461912ADE0
       call      qword ptr [7FFE331A58F0]
       jmp       near ptr M01_L122
M01_L56:
       lea       rcx,[rbp-78]
       mov       rdx,24619110A40
       call      qword ptr [7FFE331A58F0]
       jmp       near ptr M01_L120
M01_L57:
       lea       rdx,[rbp-50]
       mov       rcx,r13
       mov       r11,7FFE32F20E90
       call      qword ptr [r11]
       jmp       near ptr M01_L117
M01_L58:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rax+0A3C]
       mov       [rbp-9C],ecx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-9C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L59
       call      qword ptr [7FFE339861D8]
       jmp       short M01_L60
M01_L59:
       mov       eax,ecx
       sar       eax,10
M01_L60:
       mov       [rbp-98],eax
M01_L61:
       mov       rcx,7FFE32FA5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-98]
       xor       edx,edx
       div       dword ptr [7FFE32FA5C2C]
       mov       eax,edx
       xor       r10d,r10d
       xor       edx,edx
       jmp       near ptr M01_L68
M01_L62:
       cmp       eax,[r8+8]
       jae       near ptr M01_L16
       mov       [rbp-90],eax
       mov       ecx,eax
       mov       [rbp-128],r8
       mov       rcx,[r8+rcx*8+10]
       mov       r10,rcx
       cmp       [r10],r10b
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       mov       [rbp-130],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-130]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       mov       r10d,edx
       cmp       [rcx+8],r10d
       jbe       short M01_L64
       test      r10d,r10d
       jne       short M01_L65
       xor       edx,edx
       mov       [rbp-130],rax
       mov       [rax+14],edx
M01_L63:
       mov       [rbp-0A4],r10d
       movsxd    rdx,r10d
       mov       r8,[rbp-120]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0A4]
       inc       ecx
       mov       rax,[rbp-130]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0A0],1
M01_L64:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0A0]
       test      ecx,ecx
       je        short M01_L66
       mov       r10d,1
       jmp       short M01_L69
M01_L65:
       mov       [rbp-130],rax
       jmp       short M01_L63
M01_L66:
       mov       r10d,[rbp-90]
       lea       eax,[r10+1]
       mov       r10d,eax
       mov       rcx,[rbp-128]
       cmp       [rcx+8],r10d
       jne       short M01_L67
       xor       r10d,r10d
M01_L67:
       mov       edx,[rbp-94]
       inc       edx
       mov       [rbp-128],rcx
       mov       eax,r10d
M01_L68:
       mov       r8,[rbp-128]
       mov       [rbp-94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L62
       xor       r10d,r10d
M01_L69:
       mov       eax,r10d
       mov       [rbp-80],eax
       mov       r8d,[rbp-7C]
       jmp       near ptr M01_L125
M01_L70:
       mov       edx,r8d
       mov       r11,r9
       mov       eax,[rbp-80]
       cmp       dword ptr [rdi+8],0
       mov       [rbp-108],r11
       mov       [rbp-7C],edx
       mov       [rbp-80],eax
       je        near ptr M01_L126
       cmp       [rdi],dil
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-84],eax
       mov       r9d,[rdi+8]
       mov       [rbp-88],r9d
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-108]
       mov       r8d,[rbp-84]
       mov       r9d,[rbp-88]
       mov       edx,3
       call      qword ptr [7FFE33117678]
       mov       eax,[rbp-7C]
       test      [rbp-80],eax
       mov       [rbp-7C],eax
       jne       near ptr M01_L126
       cmp       [rdi],dil
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edx,eax
       mov       edi,[rdi+8]
       mov       r11,[rbp-108]
       mov       [rbp-110],r11
       mov       [rbp-8C],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-7C]
       test      r12d,r12d
       jne       short M01_L71
       mov       r14,[rbp-110]
       mov       edx,[rbp-8C]
       mov       r10d,0FFFFFFFF
       jmp       short M01_L72
M01_L71:
       mov       rdx,[rbp-110]
       mov       rcx,rdx
       mov       edx,[rbp-8C]
       mov       r10d,r14d
       mov       r14,rcx
M01_L72:
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L73
       mov       r11d,1
       jmp       short M01_L74
M01_L73:
       xor       r11d,r11d
M01_L74:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE3333F360]
       jmp       near ptr M01_L126
M01_L75:
       call      qword ptr [7FFE331D4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-150],rcx
       jmp       near ptr M01_L145
M01_L76:
       mov       rcx,[rax+30]
       mov       [rbp-160],rax
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L77
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-178],rcx
       mov       rdx,[rbp-160]
       call      qword ptr [7FFE33414F60]
       mov       rdx,[rbp-160]
       mov       rax,rdx
       mov       rcx,[rbp-178]
       mov       [rbp-170],rcx
       jmp       short M01_L78
M01_L77:
       mov       [rbp-168],rax
       mov       rcx,[rax+40]
       call      qword ptr [7FFE331D4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       [rbp-170],rax
       mov       rax,[rbp-168]
M01_L78:
       lea       rcx,[rax+8]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-170]
       jmp       near ptr M01_L146
M01_L79:
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L131
M01_L80:
       mov       [rbp-0C0],r10d
       mov       [rbp-190],rax
       mov       [rbp-0E8],r8
       mov       [rbp-0E0],r11
       lea       rdx,[rbp-0E8]
       mov       rcx,[r9+8]
       mov       [rbp-188],r9
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       rax,[rbp-190]
       mov       r10d,[rbp-0C0]
       jmp       near ptr M01_L133
M01_L81:
       mov       rcx,r12
       test      rcx,rcx
       je        short M01_L82
       mov       rdx,offset MT_System.String[]
       cmp       [rcx],rdx
       je        short M01_L82
       mov       rcx,rdx
       mov       rdx,r12
       call      qword ptr [7FFE33064390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L82:
       mov       rax,[rbp-180]
       lea       rcx,[rax+20]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L135
M01_L83:
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L139
M01_L84:
       lea       r9d,[rdi-1]
       mov       rcx,rsi
       mov       rdx,r12
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L153
M01_L85:
       call      qword ptr [7FFE330641F8]
       int       3
M01_L86:
       call      qword ptr [7FFE3321E9A0]
       int       3
M01_L87:
       xor       ecx,ecx
       xor       r10d,r10d
       mov       r8,rcx
       jmp       near ptr M01_L05
M01_L88:
       mov       rcx,r12
       call      qword ptr [7FFE3333E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L11
M01_L89:
       mov       r9,[r12+10]
       cmp       r14d,[r9+8]
       jae       near ptr M01_L16
       mov       ecx,r14d
       mov       r11,[r9+rcx*8+10]
       test      r11,r11
       mov       [rbp-7C],r8d
       jne       short M01_L90
       mov       rcx,r12
       mov       edx,r14d
       call      qword ptr [7FFE3333E898]
       mov       r11,rax
M01_L90:
       mov       rax,[r11+8]
       mov       [rbp-128],rax
       mov       rcx,7FFE32FA5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE32FA5C38],0
       je        short M01_L91
       call      qword ptr [7FFE3306DC98]
       mov       edx,eax
       mov       [rbp-98],edx
       jmp       short M01_L94
M01_L91:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-9C],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-9C]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L92
       call      qword ptr [7FFE339861D8]
       mov       edx,eax
       jmp       short M01_L93
M01_L92:
       mov       edx,ecx
       sar       edx,10
M01_L93:
       mov       [rbp-98],edx
M01_L94:
       mov       rcx,7FFE32FA5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-98]
       xor       edx,edx
       div       dword ptr [7FFE32FA5C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L101
M01_L95:
       cmp       eax,[r8+8]
       jae       near ptr M01_L16
       mov       [rbp-90],eax
       mov       ecx,eax
       mov       [rbp-128],r8
       mov       r10,[r8+rcx*8+10]
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0A0],r9d
       mov       [rbp-130],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-130]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       cmp       [rcx+8],r10d
       jbe       short M01_L97
       test      r10d,r10d
       jne       short M01_L98
       xor       edx,edx
       mov       [rbp-130],rax
       mov       [rax+14],edx
M01_L96:
       mov       [rbp-0A4],r10d
       movsxd    rdx,r10d
       mov       r8,[rbp-120]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0A4]
       inc       ecx
       mov       rax,[rbp-130]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0A0],1
M01_L97:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       eax,[rbp-0A0]
       test      eax,eax
       je        short M01_L99
       mov       r10d,1
       jmp       short M01_L102
M01_L98:
       mov       [rbp-130],rax
       jmp       short M01_L96
M01_L99:
       mov       eax,[rbp-90]
       inc       eax
       mov       edx,eax
       mov       r8,[rbp-128]
       cmp       [r8+8],edx
       jne       short M01_L100
       xor       edx,edx
M01_L100:
       mov       r10d,[rbp-94]
       inc       r10d
       mov       [rbp-128],r8
       mov       eax,edx
       mov       edx,r10d
M01_L101:
       mov       r8,[rbp-128]
       mov       [rbp-94],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L95
       xor       r10d,r10d
M01_L102:
       mov       r9d,r10d
       mov       [rbp-80],r9d
       mov       r8d,[rbp-7C]
       jmp       near ptr M01_L12
M01_L103:
       mov       ecx,r8d
       mov       r11,r9
       mov       r9d,[rbp-80]
       cmp       dword ptr [rdi+8],0
       mov       [rbp-108],r11
       mov       [rbp-7C],ecx
       mov       [rbp-80],r9d
       je        near ptr M01_L13
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-84],eax
       mov       edx,[rdi+8]
       mov       [rbp-88],edx
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-108]
       mov       r8d,[rbp-84]
       mov       r9d,[rbp-88]
       mov       edx,3
       call      qword ptr [7FFE33117678]
       mov       eax,[rbp-7C]
       test      [rbp-80],eax
       mov       [rbp-7C],eax
       jne       near ptr M01_L13
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,[rdi+8]
       mov       rdx,[rbp-108]
       mov       [rbp-110],rdx
       mov       [rbp-8C],eax
       mov       rcx,r12
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,[rbp-7C]
       test      r12d,r12d
       jne       short M01_L104
       mov       r14,[rbp-110]
       mov       edx,[rbp-8C]
       mov       r10d,0FFFFFFFF
       jmp       short M01_L105
M01_L104:
       mov       r11,[rbp-110]
       mov       edx,[rbp-8C]
       mov       r10d,r14d
       mov       r14,r11
M01_L105:
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,eax
       test      r12d,r12d
       jne       short M01_L106
       mov       r11d,1
       jmp       short M01_L107
M01_L106:
       xor       r11d,r11d
M01_L107:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE3333F360]
       jmp       near ptr M01_L13
M01_L108:
       mov       r9,[r12+10]
       cmp       r14d,[r9+8]
       jae       near ptr M01_L16
       mov       ecx,r14d
       mov       r11,[r9+rcx*8+10]
       test      r11,r11
       mov       [rbp-7C],r8d
       jne       short M01_L109
       mov       rcx,r12
       mov       edx,r14d
       call      qword ptr [7FFE3333E898]
       mov       r11,rax
M01_L109:
       mov       rcx,[r11+8]
       mov       [rbp-128],rcx
       mov       rcx,7FFE32FA5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE32FA5C38],0
       je        near ptr M01_L58
       call      qword ptr [7FFE3306DC98]
       mov       [rbp-98],eax
       jmp       near ptr M01_L61
M01_L110:
       mov       rcx,r12
       call      qword ptr [7FFE3333E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L124
M01_L111:
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
M01_L112:
       mov       rax,[rbp-148]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-148]
       mov       [rax+10],ecx
       mov       [rbp-138],rax
M01_L113:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,[rsi+18]
       movzx     r8d,byte ptr [rsi+28]
       mov       [rbp-0BC],r8d
       mov       [rbp-140],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-140]
       mov       r8d,[rbp-0BC]
       mov       [rax+28],r8b
       xor       edx,edx
       mov       [rax+18],rdx
       mov       r10,rax
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L25
M01_L114:
       mov       rsi,r10
       jmp       near ptr M01_L19
M01_L115:
       mov       rdx,r12
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+1C],eax
       mov       eax,[r14+1C]
       cmp       eax,[r14+38]
       jge       near ptr M01_L17
       jmp       near ptr M01_L15
M01_L116:
       vmovdqu   xmm0,xmmword ptr [r13+20]
       vmovdqu   xmmword ptr [rbp-50],xmm0
M01_L117:
       mov       rcx,20587401DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE33343A40]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       r8,rax
       test      rax,rax
       je        near ptr M01_L54
       lea       rcx,[r8+10]
       mov       r10d,[r8+8]
M01_L118:
       xor       edx,edx
       mov       [rbp-78],rdx
       mov       [rbp-70],r8
       mov       [rbp-68],edx
       mov       byte ptr [rbp-64],0
       mov       [rbp-60],rcx
       mov       [rbp-58],r10d
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L130
       mov       r9d,[rbp-68]
       cmp       r9d,[rbp-58]
       ja        near ptr M01_L86
       mov       rcx,[rbp-60]
       mov       edx,r9d
       lea       r11,[rcx+rdx*2]
       mov       edx,[rbp-58]
       sub       edx,r9d
       cmp       edx,0C
       jb        near ptr M01_L130
       mov       rcx,2461912ADBC
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmm1,xmmword ptr [rcx+8]
       vmovdqu   xmmword ptr [r11],xmm0
       vmovdqu   xmmword ptr [r11+8],xmm1
       mov       ecx,[rbp-68]
       add       ecx,0C
       mov       [rbp-68],ecx
M01_L119:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,1
       jb        near ptr M01_L56
       mov       r11,24619110A4C
       movzx     r8d,word ptr [r11]
       mov       [r10],r8w
       mov       r8d,[rbp-68]
       inc       r8d
       mov       [rbp-68],r8d
M01_L120:
       mov       rsi,[rbp-50]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L138
       test      rsi,rsi
       je        near ptr M01_L138
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M01_L138
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE33115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rsi+8]
       mov       [rbp-68],ecx
M01_L121:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-58]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L55
       mov       r11,2461912ADEC
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-68]
       add       r8d,3
       mov       [rbp-68],r8d
M01_L122:
       mov       rsi,[rbp-48]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M01_L142
       test      rsi,rsi
       je        near ptr M01_L142
       mov       edx,[rbp-68]
       cmp       edx,[rbp-58]
       ja        near ptr M01_L86
       mov       r8,[rbp-60]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-58]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M01_L142
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE33115B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-68]
       add       ecx,[rsi+8]
       mov       [rbp-68],ecx
M01_L123:
       mov       eax,[rbp-68]
       cmp       eax,[rbp-58]
       ja        near ptr M01_L86
       mov       rdx,[rbp-60]
       mov       [rbp-0D8],rdx
       mov       [rbp-0D0],eax
       lea       rcx,[rbp-0D8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdi,[rbp-70]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-78],ymm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       test      rdi,rdi
       je        near ptr M01_L126
       mov       rcx,20587401DD8
       mov       r12,[rcx]
       mov       ecx,[rdi+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE32FA5120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L110
M01_L124:
       xor       r8d,r8d
       mov       dword ptr [rbp-80],1
       cmp       [rax+8],r14d
       jbe       short M01_L125
       mov       dword ptr [rbp-7C],1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [rdi+8],ecx
       jne       near ptr M01_L50
       cmp       r14d,[rax+8]
       jae       near ptr M01_L16
       mov       ecx,r14d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       rcx,[rax]
       mov       [rbp-120],rcx
       mov       [rbp-118],rax
       mov       rcx,rax
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-118]
       mov       [rdx+8],ecx
       mov       rax,[rbp-120]
       test      rax,rax
       mov       [rbp-120],rax
       mov       r8d,[rbp-7C]
       jne       near ptr M01_L108
M01_L125:
       mov       rcx,205874005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L70
M01_L126:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,2461912AE00
       call      qword ptr [7FFE338455C0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
M01_L127:
       mov       rdx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rdx
       jne       near ptr M01_L38
       mov       r14,r13
       mov       r12d,[r14+18]
       mov       rsi,[r14+8]
       test      r12d,r12d
       je        near ptr M01_L150
       cmp       r12d,1
       jne       near ptr M01_L154
       mov       dword ptr [r14+18],0FFFFFFFF
       inc       dword ptr [r14+1C]
       mov       edx,[r14+1C]
       cmp       edx,[r14+38]
       jge       short M01_L129
M01_L128:
       lea       rdi,[r14+20]
       mov       rax,[r14+30]
       mov       rcx,[r14+10]
       mov       edx,[r14+1C]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L16
       mov       edx,[rcx+rdx*4+10]
       cmp       edx,[rax+8]
       jae       near ptr M01_L16
       mov       ecx,edx
       shl       rcx,4
       lea       rsi,[rax+rcx+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       mov       dword ptr [r14+18],1
       jmp       near ptr M01_L116
M01_L129:
       xor       ecx,ecx
       mov       [r14+10],rcx
       jmp       near ptr M01_L154
M01_L130:
       lea       rcx,[rbp-78]
       mov       rdx,2461912ADB0
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L119
M01_L131:
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L83
       mov       rax,rsi
       mov       [rbp-180],rax
       mov       rcx,[rax+8]
       mov       r8,rcx
       mov       rdx,20587401FB8
       mov       [rbp-188],r8
       cmp       r8,[rdx]
       je        near ptr M01_L81
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       xor       r10d,r10d
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L137
M01_L132:
       cmp       r10d,[r12+8]
       jae       near ptr M01_L16
       mov       edx,r10d
       shl       rdx,4
       lea       r9,[r12+rdx+10]
       mov       r8,[r9]
       mov       r11,[r9+8]
       mov       rdx,offset DotNetTips.Spargine.Core.Logging.LoggingHelper+<>c.<LogComputerInformation>b__16_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-188]
       cmp       [r9+18],rdx
       jne       near ptr M01_L80
       mov       [rbp-188],r9
       mov       edx,[r9+8]
M01_L133:
       mov       [rbp-0C0],r10d
       movsxd    rdx,r10d
       mov       [rbp-190],rax
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0C0]
       inc       eax
       mov       rdx,[rbp-190]
       cmp       [rdx+8],eax
       mov       r10d,eax
       jg        short M01_L136
M01_L134:
       mov       r8,[rbp-180]
       lea       rcx,[r8+20]
       call      CORINFO_HELP_ASSIGN_REF
M01_L135:
       mov       rax,[rbp-180]
       mov       rcx,[rax+18]
       test      rcx,rcx
       je        short M01_L139
       mov       rdx,r12
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       short M01_L139
M01_L136:
       mov       rax,rdx
       jmp       near ptr M01_L132
M01_L137:
       mov       rdx,rax
       jmp       short M01_L134
M01_L138:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L121
M01_L139:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       xor       ecx,ecx
       cmp       dword ptr [r12+8],0
       jle       short M01_L141
M01_L140:
       mov       eax,ecx
       mov       [r12+rax*4+10],ecx
       inc       ecx
       cmp       [r12+8],ecx
       jg        short M01_L140
M01_L141:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L84
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-198],rax
       mov       rcx,rsi
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rbp-0C8],rax
       test      rsi,rsi
       je        near ptr M01_L85
       mov       rdx,[rbp-198]
       lea       rcx,[rdx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-198]
       mov       rcx,[rbp-0C8]
       mov       [rsi+18],rcx
       mov       rdx,rsi
       cmp       [r12+8],edi
       jb        near ptr M01_L86
       lea       r8,[r12+10]
       cmp       edi,1
       jle       near ptr M01_L153
       mov       [rbp-0F8],r8
       mov       [rbp-0F0],edi
       lea       rcx,[rbp-0F8]
       call      qword ptr [7FFE332EDE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
       jmp       near ptr M01_L153
M01_L142:
       lea       rcx,[rbp-78]
       mov       rdx,rsi
       call      qword ptr [7FFE331A5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L123
M01_L143:
       mov       rax,[rdx]
       add       rax,10
M01_L144:
       mov       r8,[rax+8]
       mov       rdx,r8
       mov       r8,rdx
       test      r8,r8
       mov       [rbp-150],r8
       jne       short M01_L145
       mov       r8,20587400438
       mov       r10,[r8]
       mov       r8,r10
       test      r8,r8
       mov       [rbp-150],r8
       jne       short M01_L145
       mov       r8,20587400418
       mov       r9,[r8]
       mov       r8,r9
       mov       [rbp-150],r8
       test      r8,r8
       je        near ptr M01_L75
M01_L145:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       r8,[rbp-150]
       cmp       [r8],rcx
       jne       near ptr M01_L152
       mov       rax,r8
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        near ptr M01_L76
M01_L146:
       mov       [rbp-158],rcx
M01_L147:
       mov       rdx,[rbp-148]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       rdx,[rbp-148]
       mov       [rdx+10],eax
       mov       [rbp-138],rdx
M01_L148:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r10,rax
       mov       rdx,[rsi+18]
       movzx     r8d,byte ptr [rsi+28]
       mov       [rbp-0BC],r8d
       mov       [rbp-140],r10
       lea       rcx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-140]
       lea       rcx,[r10+10]
       mov       rdx,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-140]
       mov       edx,[rbp-0BC]
       mov       [r10+28],dl
       xor       edx,edx
       mov       [r10+18],rdx
       cmp       qword ptr [rsi+10],0
       jne       near ptr M01_L51
M01_L149:
       mov       rsi,r10
       jmp       near ptr M01_L131
M01_L150:
       mov       dword ptr [r14+18],0FFFFFFFF
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       mov       rdi,[rsi+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE33064348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L53
       lea       r8,[rbp-0B0]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FFE3390D800]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rbp-0B8],rax
M01_L151:
       lea       rcx,[r14+30]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-0B0]
       mov       [r14+38],ecx
       mov       edi,[r14+38]
       test      edi,edi
       jle       near ptr M01_L154
       mov       r12,[r14+30]
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L79
       mov       rdx,[rsi+20]
       mov       rax,rdx
       mov       [rbp-138],rax
       cmp       rax,r15
       jne       near ptr M01_L148
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L52
       mov       rcx,[rcx+198]
       mov       rdx,[rcx+18]
       test      rdx,rdx
       je        near ptr M01_L52
       jmp       near ptr M01_L143
M01_L152:
       mov       rcx,r8
       mov       rax,[r8]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       [rbp-158],rax
       jmp       near ptr M01_L147
M01_L153:
       mov       rdx,r12
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+1C],eax
       mov       eax,[r14+1C]
       cmp       eax,[r14+38]
       jge       near ptr M01_L129
       jmp       near ptr M01_L128
M01_L154:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r13],rcx
       jne       near ptr M01_L158
M01_L155:
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L156:
       call      qword ptr [7FFE335BDE30]
       mov       ecx,26D4
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,100A
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE33066B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,9EA
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE33066B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE335BDC20]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      qword ptr [7FFE33246670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L157:
       mov       ecx,9
       call      qword ptr [7FFE33244F30]
       int       3
M01_L158:
       mov       rcx,r13
       mov       r11,7FFE32F20E98
       call      qword ptr [r11]
       jmp       near ptr M01_L155
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+1D0]
       cmp       qword ptr [rbp-100],0
       je        short M01_L159
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       rax,[rbp-100]
       cmp       [rax],rcx
       je        short M01_L159
       mov       rcx,rax
       mov       r11,7FFE32F20E98
       call      qword ptr [r11]
M01_L159:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 7727
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptionMessages()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       mov       rcx,2B74876AD88
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,2B74876ADB0
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFE338274C8]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp-50],rsp
       test      rcx,rcx
       je        near ptr M01_L29
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,276BA801F60
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE330FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       cmp       qword ptr [rbx+20],0
       je        short M01_L00
       mov       rcx,[rbx+20]
       call      qword ptr [7FFE338274E0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE330FE160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L00:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rbx+8]
       mov       r11,7FFE32F00A38
       call      qword ptr [r11]
       test      eax,eax
       jl        near ptr M01_L30
       test      eax,eax
       je        near ptr M01_L31
       movsxd    rdx,eax
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       rcx,[rbx+8]
       mov       r11,7FFE32F00A40
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L32
       mov       rcx,[rbx+8]
       mov       r11,7FFE32F00A48
       call      qword ptr [r11]
       mov       rdi,rax
M01_L02:
       mov       [rbp-40],rdi
       test      rdi,rdi
       je        near ptr M01_L19
       mov       r14,[rdi]
       mov       r15,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Exception, System.Private.CoreLib]]
       cmp       r14,r15
       jne       near ptr M01_L19
       jmp       near ptr M01_L10
M01_L03:
       mov       rcx,[rdi+10]
M01_L04:
       mov       r12,rcx
       mov       rcx,offset MT_System.ArithmeticException
       cmp       [r12],rcx
       jne       near ptr M01_L08
       mov       rdx,[r12+10]
       test      rdx,rdx
       je        short M01_L06
M01_L05:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L09
       mov       [rbp-48],rdx
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       movsxd    rdx,eax
       mov       r8,[rbp-48]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L10
M01_L06:
       mov       rcx,2B74876AE80
       call      qword ptr [7FFE3354C030]
       mov       rbx,rax
       mov       rcx,r12
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFE32F8A418]; Precode of System.RuntimeType.ToString()
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE3354C048]
       mov       rdx,rax
       jmp       short M01_L05
M01_L07:
       mov       rcx,rdi
       mov       r11,7FFE32F00A28
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L08:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       rdx,[rbp-48]
       jmp       near ptr M01_L05
M01_L09:
       mov       rcx,rsi
       call      qword ptr [7FFE330FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L10:
       cmp       r14,r15
       jne       short M01_L11
       lea       rbx,[rdi+8]
       mov       r13,[rbx]
       mov       rax,r13
       mov       ecx,[rbx+14]
       cmp       ecx,[rax+14]
       jne       short M01_L12
       mov       r8d,[rbx+10]
       cmp       r8d,[rax+10]
       jae       short M01_L13
       lea       rcx,[rbx+8]
       mov       r12,[rax+8]
       cmp       r8d,[r12+8]
       jae       near ptr M01_L21
       mov       edx,r8d
       mov       rdx,[r12+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+10]
       jmp       near ptr M01_L03
M01_L11:
       mov       rcx,rdi
       mov       r11,7FFE32F00A20
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L07
       jmp       near ptr M01_L27
M01_L12:
       mov       ecx,[rbx+14]
       cmp       ecx,[r13+14]
       jne       near ptr M01_L24
M01_L13:
       mov       ecx,[r13+10]
       inc       ecx
       mov       [rbx+10],ecx
       xor       ecx,ecx
       mov       [rbx+8],rcx
       jmp       near ptr M01_L27
M01_L14:
       mov       rcx,[rdi+10]
M01_L15:
       mov       r12,rcx
       mov       rcx,offset MT_System.ArithmeticException
       cmp       [r12],rcx
       jne       short M01_L17
       mov       rdx,[r12+10]
       test      rdx,rdx
       je        near ptr M01_L22
M01_L16:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [rcx+8],eax
       jbe       short M01_L18
       mov       [rbp-48],rdx
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       movsxd    rdx,eax
       mov       r8,[rbp-48]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L17:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-48],rax
       mov       rdx,[rbp-48]
       jmp       short M01_L16
M01_L18:
       mov       rcx,rsi
       call      qword ptr [7FFE330FE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       r14,[rdi]
       mov       r15,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Exception, System.Private.CoreLib]]
       cmp       r14,r15
       jne       short M01_L20
       lea       rbx,[rdi+8]
       mov       rax,[rbx]
       mov       ecx,[rbx+14]
       cmp       ecx,[rax+14]
       jne       near ptr M01_L25
       mov       r8d,[rbx+10]
       cmp       r8d,[rax+10]
       jae       near ptr M01_L26
       lea       rcx,[rbx+8]
       mov       r12,[rax+8]
       cmp       r8d,[r12+8]
       jae       short M01_L21
       mov       edx,r8d
       mov       rdx,[r12+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [rbx+10]
       jmp       near ptr M01_L14
M01_L20:
       mov       rcx,rdi
       mov       r11,7FFE32F00A20
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L23
       jmp       short M01_L27
M01_L21:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L22:
       mov       rcx,2B74876AE80
       call      qword ptr [7FFE3354C030]
       mov       rbx,rax
       mov       rcx,r12
       call      System.Object.GetType()
       mov       rcx,rax
       call      qword ptr [7FFE32F8A418]; Precode of System.RuntimeType.ToString()
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFE3354C048]
       mov       rdx,rax
       jmp       near ptr M01_L16
M01_L23:
       mov       rcx,rdi
       mov       r11,7FFE32F00A28
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L15
M01_L24:
       call      qword ptr [7FFE331FEFB8]
       int       3
M01_L25:
       mov       ecx,[rbx+14]
       mov       r11,[rbx]
       cmp       ecx,[r11+14]
       jne       short M01_L24
M01_L26:
       mov       rcx,[rbx]
       mov       ecx,[rcx+10]
       inc       ecx
       mov       [rbx+10],ecx
       xor       ecx,ecx
       mov       [rbx+8],rcx
M01_L27:
       cmp       r14,r15
       jne       near ptr M01_L33
M01_L28:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       call      qword ptr [7FFE3359DE30]
       mov       ecx,1096
       mov       rdx,7FFE33327DB0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,100A
       mov       rdx,7FFE33327DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE33046B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,9EA
       mov       rdx,7FFE33327DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE33046B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE3359DC20]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rsi
       call      qword ptr [7FFE33226670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L30:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFE331FED18]
       int       3
M01_L31:
       mov       rcx,276BA801D80
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L32:
       mov       rcx,7FFE32F85120
       mov       edx,63
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,276BA801F68
       mov       rdi,[rcx]
       jmp       near ptr M01_L02
M01_L33:
       mov       rcx,rdi
       mov       r11,7FFE32F00A30
       call      qword ptr [r11]
       jmp       near ptr M01_L28
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp-40],0
       je        short M01_L34
       mov       rdi,[rbp-40]
       mov       r14,[rdi]
       mov       r15,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Exception, System.Private.CoreLib]]
       cmp       r14,r15
       je        short M01_L34
       mov       rcx,rdi
       mov       r11,7FFE32F00A30
       call      qword ptr [r11]
M01_L34:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1388
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.RetrieveAllExceptions()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.ArithmeticException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       mov       rcx,2633EADAD88
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,2633EADADB0
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFE338454E8]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 202
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
M01_L00:
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L02
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,222ACC01F60
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE3311E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L01
       call      qword ptr [7FFE338454E8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE3311E160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
M01_L01:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFE335BDE30]
       mov       ecx,1096
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE33066B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,9EA
       mov       rdx,7FFE33347DB0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE33066B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE335BDC20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE33246670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 283
```

