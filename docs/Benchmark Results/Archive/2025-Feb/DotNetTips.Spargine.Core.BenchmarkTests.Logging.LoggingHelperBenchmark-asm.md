## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogApplicationInformation()
       mov       rcx,[rcx+118]
       jmp       qword ptr [7FFE5CDAE5E0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
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
       sub       rsp,208
       vzeroupper
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-210],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L149
       mov       rcx,1CEF4408AD0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L150
       mov       rsi,[rcx+18]
       xor       edi,edi
       test      rsi,rsi
       setne     dil
       test      edi,edi
       je        near ptr M01_L151
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE5C4FEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+34],eax
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CEF440B3E8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L19
M01_L02:
       test      rdi,rdi
       je        near ptr M01_L153
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L154
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      qword ptr [7FFE5C4F4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M01_L155
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M01_L157
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rcx,1CEF440B3F0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L18
M01_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M01_L178
       test      rdi,rdi
       je        near ptr M01_L177
       xor       ecx,ecx
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CEF4405420
       mov       rdi,[rcx]
       lea       rcx,[r15+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],0
       mov       r13,[r15+8]
       mov       rdx,r13
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L158
       mov       rcx,rax
       mov       r11,7FFE5C3B0D88
       call      qword ptr [r11]
       mov       [rbp-80],rax
       mov       edx,[rax+8]
       mov       [rbp-78],edx
M01_L05:
       mov       edx,[rbp-78]
       test      edx,edx
       je        near ptr M01_L152
       movsxd    r13,edx
       mov       rdx,r13
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       rax,[rbp-80]
       mov       [rbp-1F0],rax
       mov       edx,[rbp-78]
       mov       [rbp-104],edx
       lea       r8,[r12+10]
       mov       r10d,[r12+8]
       mov       [rbp-1F8],r8
       mov       [rbp-108],r10d
       mov       r9,[r15+20]
       cmp       r9,rdi
       mov       [rbp-158],r9
       jne       near ptr M01_L10
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L159
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L159
       mov       r11,[rcx]
       add       r11,10
M01_L06:
       mov       rcx,[r11+8]
       test      rcx,rcx
       mov       [rbp-170],rcx
       jne       short M01_L07
       mov       rcx,1CEF4400438
       mov       rcx,[rcx]
       test      rcx,rcx
       mov       [rbp-170],rcx
       jne       short M01_L07
       mov       rcx,1CEF4400418
       mov       rcx,[rcx]
       mov       [rbp-170],rcx
       test      rcx,rcx
       je        near ptr M01_L160
M01_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-168],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rax,[rbp-170]
       cmp       [rax],rcx
       jne       near ptr M01_L27
       mov       rdx,rax
       mov       r8,[rdx+8]
       test      r8,r8
       je        near ptr M01_L161
M01_L08:
       mov       rdx,r8
M01_L09:
       mov       r9,[rbp-168]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r9,[rbp-168]
       mov       [r9+10],ecx
       mov       [rbp-158],r9
M01_L10:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       mov       rdx,[r15+18]
       movzx     r8d,byte ptr [r15+28]
       mov       [rbp-84],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-158]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-160]
       mov       edx,[rbp-84]
       mov       [rax+28],dl
       xor       edx,edx
       mov       [rax+18],rdx
       cmp       qword ptr [r15+10],0
       jne       near ptr M01_L164
M01_L11:
       mov       r15,rax
       mov       r8d,[rbp-104]
       mov       [rbp-88],r8d
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [r15],rdx
       jne       near ptr M01_L170
       mov       rdx,r15
       mov       r10,[rdx+8]
       mov       [rbp-198],r10
       mov       rdx,1CEF44055F0
       cmp       r10,[rdx]
       je        near ptr M01_L167
       mov       rdx,r13
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-1A0],rax
       xor       r8d,r8d
       cmp       dword ptr [rax+8],0
       mov       rax,[rbp-1A0]
       jle       near ptr M01_L15
M01_L12:
       mov       r10,[rbp-1F0]
       cmp       r8d,[r10+8]
       jae       near ptr M01_L180
       mov       [rbp-8C],r8d
       mov       edx,r8d
       mov       rcx,[r10+rdx*8+10]
       mov       r9,rcx
       mov       rdx,7FFE5CDABE40
       mov       r11,[rbp-198]
       cmp       [r11+18],rdx
       jne       near ptr M01_L166
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r9],rdx
       jne       near ptr M01_L165
       mov       [rbp-1B0],r9
       mov       rcx,[r9+8]
       test      rcx,rcx
       je        short M01_L17
M01_L13:
       mov       [rbp-1A8],rcx
M01_L14:
       movsxd    rdx,dword ptr [rbp-8C]
       mov       rcx,rax
       mov       r8,[rbp-1A8]
       call      CORINFO_HELP_ARRADDR_ST
       mov       r8d,[rbp-8C]
       inc       r8d
       mov       rax,[rbp-1A0]
       cmp       [rax+8],r8d
       jg        near ptr M01_L12
M01_L15:
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L16:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        near ptr M01_L28
       mov       rdx,[rbp-1F0]
       mov       r8d,[rbp-88]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L28
M01_L17:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0A0],xmm0
       mov       rdx,[r9+48]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFE5C7551B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0A0]
       vmovups   [rbp-0B0],xmm0
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFE5C755230]; System.MdUtf8String.ToString()
       mov       [rbp-1B8],rax
       mov       rdx,[rbp-1B0]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-1B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-1B8]
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L13
M01_L18:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1CEF440B3E0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CDABE40
       mov       [rdi+18],rcx
       mov       rcx,1CEF440B3F0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L04
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1CEF440B3E0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CDABE28
       mov       [rdi+18],rcx
       mov       rcx,1CEF440B3E8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L20:
       mov       rcx,[r13+18]
M01_L21:
       test      rcx,rcx
       je        near ptr M01_L174
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C72DEB8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L22:
       mov       [rbp-148],rax
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FFE5C4F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-150],rax
       test      rax,rax
       jne       near ptr M01_L172
M01_L23:
       cmp       qword ptr [rbp-148],0
       je        near ptr M01_L39
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r13],rdx
       jne       near ptr M01_L173
       mov       r8,[r13+8]
       test      r8,r8
       je        short M01_L26
M01_L24:
       mov       r13,r8
M01_L25:
       mov       rcx,offset MT_System.String
       mov       rax,[rbp-148]
       cmp       [rax],rcx
       jne       near ptr M01_L35
       jmp       near ptr M01_L37
M01_L26:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C0],xmm0
       mov       rdx,[r13+48]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFE5C7551B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0C0]
       vmovups   [rbp-0D0],xmm0
       lea       rcx,[rbp-0D0]
       call      qword ptr [7FFE5C755230]; System.MdUtf8String.ToString()
       mov       r8,rax
       mov       [rbp-1C0],r8
       lea       rcx,[r13+8]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-1C0]
       mov       r8,r13
       jmp       short M01_L24
M01_L27:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L09
M01_L28:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       xor       r9d,r9d
       cmp       dword ptr [r13+8],0
       jle       short M01_L30
M01_L29:
       mov       ecx,r9d
       mov       [r13+rcx*4+10],r9d
       inc       r9d
       cmp       [r13+8],r9d
       jg        short M01_L29
M01_L30:
       mov       r9d,[rbp-88]
       dec       r9d
       mov       rcx,r15
       mov       rdx,r13
       xor       r8d,r8d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       xor       r15d,r15d
       mov       eax,[rbp-108]
       test      eax,eax
       jle       near ptr M01_L33
       cmp       [r13+8],eax
       jl        short M01_L32
M01_L31:
       cmp       r15d,eax
       jae       near ptr M01_L180
       mov       ecx,r15d
       mov       r8,[rbp-1F8]
       lea       rcx,[r8+rcx*8]
       mov       edx,r15d
       mov       r10d,[r13+rdx*4+10]
       mov       r9,[rbp-1F0]
       cmp       r10d,[r9+8]
       jae       near ptr M01_L180
       mov       edx,r10d
       mov       rdx,[r9+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r15d
       mov       eax,[rbp-108]
       cmp       r15d,eax
       jl        short M01_L31
       jmp       short M01_L33
M01_L32:
       cmp       r15d,eax
       jae       near ptr M01_L180
       mov       ecx,r15d
       mov       r8,[rbp-1F8]
       lea       rcx,[r8+rcx*8]
       cmp       r15d,[r13+8]
       jae       near ptr M01_L180
       mov       edx,r15d
       mov       r10d,[r13+rdx*4+10]
       mov       r9,[rbp-1F0]
       cmp       r10d,[r9+8]
       jae       near ptr M01_L180
       mov       edx,r10d
       mov       rdx,[r9+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r15d
       mov       eax,[rbp-108]
       cmp       r15d,eax
       jl        short M01_L32
M01_L33:
       xor       r15d,r15d
       cmp       dword ptr [r12+8],0
       jle       near ptr M01_L40
M01_L34:
       mov       ecx,r15d
       mov       r13,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r13],rcx
       jne       near ptr M01_L171
       mov       rcx,r13
       cmp       qword ptr [rcx+18],0
       je        short M01_L36
       jmp       near ptr M01_L20
M01_L35:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       short M01_L38
M01_L36:
       xor       ecx,ecx
       jmp       near ptr M01_L21
M01_L37:
       cmp       [rax],al
M01_L38:
       mov       [rbp-200],rax
       mov       rcx,r14
       mov       r11,7FFE5C3B0D98
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L175
       mov       [rbp-128],r13
       mov       rax,[rbp-200]
       mov       [rbp-120],rax
       mov       rcx,r14
       lea       rdx,[rbp-128]
       mov       r11,7FFE5C3B0DA0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L39
       mov       [rbp-128],r13
       mov       r13,[rbp-200]
       mov       [rbp-120],r13
       mov       rcx,r14
       lea       rdx,[rbp-128]
       mov       r11,7FFE5C3B0D90
       call      qword ptr [r11]
M01_L39:
       inc       r15d
       cmp       [r12+8],r15d
       jg        near ptr M01_L34
M01_L40:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FFE5CDD49F0]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r15+8]
       mov       r11,7FFE5C3B0DA8
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L148
       mov       rcx,1CEF4408DF0
       mov       r12,[rcx]
       test      r12,r12
       je        short M01_L42
M01_L41:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       test      r12,r12
       je        near ptr M01_L177
       xor       ecx,ecx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+28],0
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       xor       ecx,ecx
       mov       [rdi+18],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       [rbp-140],rcx
       jmp       short M01_L43
M01_L42:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,1CEF4408DE8
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CDAB390
       mov       [r12+18],rcx
       mov       rcx,1CEF4408DF0
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L41
M01_L43:
       test      rcx,rcx
       je        near ptr M01_L75
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [rcx],rax
       jne       near ptr M01_L75
       mov       rax,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rax
       jne       near ptr M01_L75
       jmp       near ptr M01_L58
M01_L44:
       mov       rcx,[rbp-140]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rdx,1CEF4405430
       mov       r8,[rdx]
       mov       rcx,r8
       mov       edx,100
       call      qword ptr [7FFE5C806FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L124
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L45:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],rax
       mov       [rbp-60],r8d
       mov       byte ptr [rbp-5C],0
       mov       [rbp-58],rsi
       mov       [rbp-50],edi
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L125
       mov       r14d,[rbp-60]
       cmp       r14d,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,r14d
       lea       r15,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r14d
       cmp       r10d,7
       jb        near ptr M01_L125
       mov       r13,20F8257464C
       mov       rcx,[r13]
       mov       r8,[r13+6]
       mov       [r15],rcx
       mov       [r15+6],r8
       mov       r8d,[rbp-60]
       add       r8d,7
       mov       [rbp-60],r8d
M01_L46:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       r9,[r8+rcx*2]
       mov       r11d,[rbp-50]
       sub       r11d,r12d
       cmp       r11d,1
       jb        near ptr M01_L126
       mov       rdx,20F82560A4C
       movzx     r8d,word ptr [rdx]
       mov       [r9],r8w
       mov       r8d,[rbp-60]
       inc       r8d
       mov       [rbp-60],r8d
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L127
M01_L47:
       test      r12,r12
       je        near ptr M01_L127
       mov       ecx,[rbp-60]
       cmp       ecx,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       edx,ecx
       lea       rdx,[r8+rdx*2]
       mov       r8d,[rbp-50]
       sub       r8d,ecx
       mov       rcx,rdx
       cmp       [r12+8],r8d
       ja        near ptr M01_L127
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-60]
       add       r8d,[r12+8]
       mov       [rbp-60],r8d
M01_L48:
       mov       eax,[rbp-60]
       cmp       eax,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-50]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L128
       mov       r11,20F82574674
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-60]
       add       r8d,3
       mov       [rbp-60],r8d
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L129
M01_L49:
       test      r12,r12
       je        near ptr M01_L129
       mov       edx,[rbp-60]
       cmp       edx,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-50]
       sub       r8d,edx
       cmp       [r12+8],r8d
       ja        near ptr M01_L129
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L50:
       mov       eax,[rbp-60]
       cmp       eax,[rbp-50]
       ja        near ptr M01_L112
       mov       rdx,[rbp-58]
       mov       [rbp-138],rdx
       mov       [rbp-130],eax
       lea       rcx,[rbp-138]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rbp-68]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       test      r13,r13
       je        near ptr M01_L53
       mov       rcx,1CEF4405430
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE5C435120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L123
M01_L51:
       xor       edi,edi
       mov       esi,1
       cmp       [rax+8],r14d
       jbe       short M01_L52
       mov       edi,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [r13+8],ecx
       jne       near ptr M01_L113
       cmp       r14d,[rax+8]
       jae       near ptr M01_L59
       mov       ecx,r14d
       shl       rcx,4
       lea       r8,[rax+rcx+10]
       mov       r10,[r8]
       mov       [rbp-1D8],r10
       mov       [rbp-1D0],r8
       mov       rcx,r8
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-1D0]
       mov       [rax+8],ecx
       mov       rdx,[rbp-1D8]
       test      rdx,rdx
       jne       near ptr M01_L121
M01_L52:
       mov       rcx,1CEF44005D0
       mov       r8,[rcx]
       cmp       byte ptr [r8+9D],0
       jne       near ptr M01_L120
M01_L53:
       mov       rcx,[rbx+8]
       mov       rax,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rax
       jne       near ptr M01_L146
       xor       eax,eax
       mov       [rbp-100],rax
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L119
       xor       ecx,ecx
       mov       [rbp-100],rcx
       xor       edi,edi
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L117
M01_L54:
       cmp       qword ptr [rbp-100],0
       jne       near ptr M01_L116
M01_L55:
       xor       eax,eax
       cmp       [rsi+8],edi
       setg      al
M01_L56:
       xor       ecx,ecx
       mov       [rbp-100],rcx
M01_L57:
       test      eax,eax
       jne       near ptr M01_L115
M01_L58:
       mov       rcx,[rbp-140]
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CDE7008]; System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L44
       jmp       near ptr M01_L147
M01_L59:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L60:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,[rbp-140]
       cmp       [r8],rcx
       jne       near ptr M01_L87
       vmovdqu   xmm0,xmmword ptr [r8+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M01_L61:
       mov       rcx,1CEF4405430
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE5C806FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L86
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L62:
       xor       r8d,r8d
       mov       [rbp-70],r8
       mov       [rbp-68],rax
       mov       [rbp-60],r8d
       mov       byte ptr [rbp-5C],0
       mov       [rbp-58],rsi
       mov       [rbp-50],edi
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L88
       mov       r14d,[rbp-60]
       cmp       r14d,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,r14d
       lea       r15,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r14d
       cmp       r10d,7
       jb        near ptr M01_L88
       mov       r13,20F8257464C
       mov       rcx,[r13]
       mov       r8,[r13+6]
       mov       [r15],rcx
       mov       [r15+6],r8
       mov       r8d,[rbp-60]
       add       r8d,7
       mov       [rbp-60],r8d
M01_L63:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       r9,[r8+rcx*2]
       mov       r11d,[rbp-50]
       sub       r11d,r12d
       cmp       r11d,1
       jb        near ptr M01_L89
       mov       rdx,20F82560A4C
       movzx     r8d,word ptr [rdx]
       mov       [r9],r8w
       mov       r8d,[rbp-60]
       inc       r8d
       mov       [rbp-60],r8d
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L90
M01_L64:
       test      r12,r12
       je        near ptr M01_L90
       mov       ecx,[rbp-60]
       cmp       ecx,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       edx,ecx
       lea       rdx,[r8+rdx*2]
       mov       r8d,[rbp-50]
       sub       r8d,ecx
       mov       rcx,rdx
       cmp       [r12+8],r8d
       ja        near ptr M01_L90
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rbp-60]
       add       r8d,[r12+8]
       mov       [rbp-60],r8d
M01_L65:
       mov       eax,[rbp-60]
       cmp       eax,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,eax
       lea       r10,[r8+rcx*2]
       mov       r9d,[rbp-50]
       sub       r9d,eax
       cmp       r9d,3
       jb        near ptr M01_L91
       mov       r11,20F82574674
       mov       ecx,[r11]
       mov       r8d,[r11+2]
       mov       [r10],ecx
       mov       [r10+2],r8d
       mov       r8d,[rbp-60]
       add       r8d,3
       mov       [rbp-60],r8d
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L92
M01_L66:
       test      r12,r12
       je        near ptr M01_L92
       mov       edx,[rbp-60]
       cmp       edx,[rbp-50]
       ja        near ptr M01_L112
       mov       r8,[rbp-58]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rbp-50]
       sub       r8d,edx
       cmp       [r12+8],r8d
       ja        near ptr M01_L92
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C5A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L67:
       mov       eax,[rbp-60]
       cmp       eax,[rbp-50]
       ja        near ptr M01_L112
       mov       rdx,[rbp-58]
       mov       [rbp-138],rdx
       mov       [rbp-130],eax
       lea       rcx,[rbp-138]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rbp-68]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       test      r13,r13
       je        near ptr M01_L70
       mov       rcx,1CEF4405430
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE5C435120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L85
M01_L68:
       xor       edi,edi
       mov       esi,1
       cmp       [rax+8],r14d
       jbe       short M01_L69
       mov       edi,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [r13+8],ecx
       jne       near ptr M01_L113
       cmp       r14d,[rax+8]
       jae       near ptr M01_L59
       mov       ecx,r14d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       rdx,[rax]
       mov       [rbp-1D8],rdx
       mov       [rbp-1D0],rax
       mov       rcx,rax
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       rcx,[rbp-1D0]
       mov       [rcx+8],eax
       mov       rax,[rbp-1D8]
       test      rax,rax
       jne       near ptr M01_L83
M01_L69:
       mov       rax,1CEF44005D0
       mov       r8,[rax]
       mov       rax,r8
       cmp       byte ptr [rax+9D],0
       jne       near ptr M01_L82
M01_L70:
       mov       rax,offset MT_Microsoft.Extensions.Logging.Logger`1[[DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark, DotNetTips.Spargine.Core.BenchmarkTests]]
       cmp       [rbx],rax
       jne       near ptr M01_L110
       mov       rcx,[rbx+8]
       mov       rax,offset MT_Microsoft.Extensions.Logging.Logger
       cmp       [rcx],rax
       jne       near ptr M01_L109
       xor       eax,eax
       mov       [rbp-100],rax
       mov       rsi,[rcx+18]
       test      rsi,rsi
       je        near ptr M01_L81
       xor       eax,eax
       mov       [rbp-100],rax
       xor       edi,edi
       cmp       dword ptr [rsi+8],0
       jg        near ptr M01_L79
M01_L71:
       cmp       qword ptr [rbp-100],0
       jne       short M01_L78
M01_L72:
       xor       eax,eax
       cmp       [rsi+8],edi
       setg      al
M01_L73:
       xor       ecx,ecx
       mov       [rbp-100],rcx
M01_L74:
       test      eax,eax
       jne       short M01_L77
M01_L75:
       mov       rcx,[rbp-140]
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [rcx],rax
       jne       near ptr M01_L111
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CDE7008]; System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
M01_L76:
       test      eax,eax
       jne       near ptr M01_L60
       jmp       near ptr M01_L147
M01_L77:
       mov       rcx,7FFE5C80C130
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1CEF4408BB8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,r12
       xor       r9d,r9d
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       short M01_L75
M01_L78:
       mov       rax,[rbp-100]
       cmp       dword ptr [rax+10],0
       jg        near ptr M01_L114
       jmp       near ptr M01_L72
M01_L79:
       cmp       edi,[rsi+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rsi+rcx*8+10]
       mov       rcx,r13
       mov       edx,2
       call      qword ptr [7FFE5CCAE220]
       test      eax,eax
       je        short M01_L80
       mov       rdx,[r13]
       lea       r8,[rbp-100]
       mov       ecx,2
       call      qword ptr [7FFE5CCAD6E0]
       test      eax,eax
       jne       near ptr M01_L71
M01_L80:
       inc       edi
       cmp       [rsi+8],edi
       jg        short M01_L79
       jmp       near ptr M01_L71
M01_L81:
       xor       eax,eax
       jmp       near ptr M01_L73
M01_L82:
       cmp       dword ptr [r13+8],0
       mov       [rbp-1C8],rax
       je        near ptr M01_L70
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D4],eax
       mov       r9d,[r13+8]
       mov       [rbp-0D8],r9d
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-1C8]
       mov       r8d,[rbp-0D4]
       mov       r9d,[rbp-0D8]
       mov       edx,3
       call      qword ptr [7FFE5C5A7678]
       test      esi,edi
       jne       near ptr M01_L70
       mov       rsi,[rbp-1C8]
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       [rbp-0DC],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      edi,edi
       jne       near ptr M01_L105
       mov       r15d,[rbp-0DC]
       mov       r10d,0FFFFFFFF
       jmp       near ptr M01_L106
M01_L83:
       mov       rsi,rax
       mov       r8,[r15+10]
       cmp       r14d,[r8+8]
       jae       near ptr M01_L59
       mov       ecx,r14d
       mov       r10,[r8+rcx*8+10]
       test      r10,r10
       jne       short M01_L84
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFE5C7FE898]
       mov       r10,rax
M01_L84:
       mov       r10,[r10+8]
       mov       [rbp-1E0],r10
       mov       rcx,7FFE5C435120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE5C435C38],0
       je        near ptr M01_L93
       call      qword ptr [7FFE5C4FDC98]
       mov       [rbp-0E8],eax
       jmp       near ptr M01_L96
M01_L85:
       mov       rcx,r15
       call      qword ptr [7FFE5C7FE910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L68
M01_L86:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L62
M01_L87:
       lea       rdx,[rbp-48]
       mov       rcx,r8
       mov       r11,7FFE5C3B0D68
       call      qword ptr [r11]
       jmp       near ptr M01_L61
M01_L88:
       lea       rcx,[rbp-70]
       mov       rdx,20F82574640
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L63
M01_L89:
       lea       rcx,[rbp-70]
       mov       rdx,20F82560A40
       call      qword ptr [7FFE5C6658F0]
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       je        near ptr M01_L64
M01_L90:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L65
M01_L91:
       lea       rcx,[rbp-70]
       mov       rdx,20F82574668
       call      qword ptr [7FFE5C6658F0]
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       je        near ptr M01_L66
M01_L92:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L67
M01_L93:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rax+0A3C]
       mov       [rbp-0EC],ecx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0EC]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L94
       call      qword ptr [7FFE5CE169A0]
       jmp       short M01_L95
M01_L94:
       mov       eax,ecx
       sar       eax,10
M01_L95:
       mov       [rbp-0E8],eax
M01_L96:
       mov       rcx,7FFE5C435120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0E8]
       xor       edx,edx
       div       dword ptr [7FFE5C435C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L103
M01_L97:
       cmp       eax,[r8+8]
       jae       near ptr M01_L59
       mov       [rbp-0E0],eax
       mov       ecx,eax
       mov       [rbp-1E0],r8
       mov       rcx,[r8+rcx*8+10]
       mov       r10,rcx
       cmp       [r10],r10b
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       mov       [rbp-1E8],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1E8]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       mov       r10d,edx
       cmp       [rcx+8],r10d
       jbe       short M01_L99
       test      r10d,r10d
       jne       short M01_L100
       xor       edx,edx
       mov       [rbp-1E8],rax
       mov       [rax+14],edx
M01_L98:
       mov       [rbp-0F4],r10d
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0F4]
       inc       ecx
       mov       rax,[rbp-1E8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0F0],1
M01_L99:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0F0]
       test      ecx,ecx
       je        short M01_L101
       mov       edx,1
       jmp       short M01_L104
M01_L100:
       mov       [rbp-1E8],rax
       jmp       short M01_L98
M01_L101:
       mov       edx,[rbp-0E0]
       lea       eax,[rdx+1]
       mov       edx,eax
       mov       rcx,[rbp-1E0]
       cmp       [rcx+8],edx
       jne       short M01_L102
       xor       edx,edx
M01_L102:
       mov       eax,[rbp-0E4]
       inc       eax
       mov       [rbp-1E0],rcx
       mov       r8d,eax
       mov       eax,edx
       mov       edx,r8d
M01_L103:
       mov       r8,[rbp-1E0]
       mov       [rbp-0E4],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L97
       xor       edx,edx
M01_L104:
       mov       esi,edx
       jmp       near ptr M01_L69
M01_L105:
       mov       r15d,[rbp-0DC]
       mov       r10d,r14d
M01_L106:
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8d,r13d
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L107
       mov       r11d,1
       jmp       short M01_L108
M01_L107:
       xor       r11d,r11d
M01_L108:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE5C7FF360]
       jmp       near ptr M01_L70
M01_L109:
       mov       r11,7FFE5C3B0DB8
       mov       edx,2
       call      qword ptr [r11]
       jmp       near ptr M01_L74
M01_L110:
       mov       rcx,rbx
       mov       r11,7FFE5C3B0DB0
       mov       edx,2
       call      qword ptr [r11]
       jmp       near ptr M01_L74
M01_L111:
       mov       r11,7FFE5C3B0D60
       call      qword ptr [r11]
       jmp       near ptr M01_L76
M01_L112:
       call      qword ptr [7FFE5C6EE9D0]
       int       3
M01_L113:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA3DAD0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C3A4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L114:
       mov       rcx,[rbp-100]
       call      qword ptr [7FFE5CCAD698]
       int       3
M01_L115:
       mov       rcx,7FFE5C80C130
       mov       edx,60
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1CEF4408BB8
       mov       rax,[rdx]
       mov       rdx,rbx
       mov       r8,r12
       xor       r9d,r9d
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L58
M01_L116:
       mov       rax,[rbp-100]
       cmp       dword ptr [rax+10],0
       jg        short M01_L114
       jmp       near ptr M01_L55
M01_L117:
       cmp       edi,[rsi+8]
       jae       near ptr M01_L59
       mov       ecx,edi
       lea       rcx,[rcx+rcx*4]
       lea       r13,[rsi+rcx*8+10]
       mov       rcx,r13
       mov       edx,2
       call      qword ptr [7FFE5CCAE220]
       test      eax,eax
       je        short M01_L118
       mov       rdx,[r13]
       lea       r8,[rbp-100]
       mov       ecx,2
       call      qword ptr [7FFE5CCAD6E0]
       test      eax,eax
       jne       near ptr M01_L54
M01_L118:
       inc       edi
       cmp       [rsi+8],edi
       jg        short M01_L117
       jmp       near ptr M01_L54
M01_L119:
       xor       eax,eax
       jmp       near ptr M01_L56
M01_L120:
       mov       r9,r8
       cmp       dword ptr [r13+8],0
       mov       [rbp-1C8],r9
       je        near ptr M01_L53
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D4],eax
       mov       edx,[r13+8]
       mov       [rbp-0D8],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-1C8]
       mov       r8d,[rbp-0D4]
       mov       r9d,[rbp-0D8]
       mov       edx,3
       call      qword ptr [7FFE5C5A7678]
       test      esi,edi
       jne       near ptr M01_L53
       mov       rsi,[rbp-1C8]
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       [rbp-0DC],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      edi,edi
       jne       near ptr M01_L142
       mov       r15d,[rbp-0DC]
       mov       r10d,0FFFFFFFF
       jmp       near ptr M01_L143
M01_L121:
       mov       rsi,rdx
       mov       r8,[r15+10]
       cmp       r14d,[r8+8]
       jae       near ptr M01_L59
       mov       ecx,r14d
       mov       r10,[r8+rcx*8+10]
       test      r10,r10
       jne       short M01_L122
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFE5C7FE898]
       mov       r10,rax
M01_L122:
       mov       rax,[r10+8]
       mov       [rbp-1E0],rax
       mov       rcx,7FFE5C435120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE5C435C38],0
       je        near ptr M01_L130
       call      qword ptr [7FFE5C4FDC98]
       mov       edx,eax
       mov       [rbp-0E8],edx
       jmp       near ptr M01_L133
M01_L123:
       mov       rcx,r15
       call      qword ptr [7FFE5C7FE910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L51
M01_L124:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L45
M01_L125:
       lea       rcx,[rbp-70]
       mov       rdx,20F82574640
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L46
M01_L126:
       lea       rcx,[rbp-70]
       mov       rdx,20F82560A40
       call      qword ptr [7FFE5C6658F0]
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       je        near ptr M01_L47
M01_L127:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L48
M01_L128:
       lea       rcx,[rbp-70]
       mov       rdx,20F82574668
       call      qword ptr [7FFE5C6658F0]
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       je        near ptr M01_L49
M01_L129:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C665848]
       jmp       near ptr M01_L50
M01_L130:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0EC],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0EC]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L131
       call      qword ptr [7FFE5CE169A0]
       mov       edx,eax
       jmp       short M01_L132
M01_L131:
       mov       edx,ecx
       sar       edx,10
M01_L132:
       mov       [rbp-0E8],edx
M01_L133:
       mov       rcx,7FFE5C435120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0E8]
       xor       edx,edx
       div       dword ptr [7FFE5C435C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L140
M01_L134:
       cmp       eax,[r8+8]
       jae       near ptr M01_L59
       mov       [rbp-0E0],eax
       mov       ecx,eax
       mov       [rbp-1E0],r8
       mov       r10,[r8+rcx*8+10]
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0F0],r9d
       mov       [rbp-1E8],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1E8]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       cmp       [rcx+8],r10d
       jbe       short M01_L136
       test      r10d,r10d
       jne       short M01_L137
       xor       edx,edx
       mov       [rbp-1E8],rax
       mov       [rax+14],edx
M01_L135:
       mov       [rbp-0F4],r10d
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0F4]
       inc       ecx
       mov       rax,[rbp-1E8]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0F0],1
M01_L136:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       eax,[rbp-0F0]
       test      eax,eax
       je        short M01_L138
       mov       edx,1
       jmp       short M01_L141
M01_L137:
       mov       [rbp-1E8],rax
       jmp       short M01_L135
M01_L138:
       mov       eax,[rbp-0E0]
       inc       eax
       mov       r8d,eax
       mov       r10,[rbp-1E0]
       cmp       [r10+8],r8d
       jne       short M01_L139
       xor       r8d,r8d
M01_L139:
       mov       edx,[rbp-0E4]
       inc       edx
       mov       [rbp-1E0],r10
       mov       eax,r8d
M01_L140:
       mov       r8,[rbp-1E0]
       mov       [rbp-0E4],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L134
       xor       edx,edx
M01_L141:
       mov       esi,edx
       jmp       near ptr M01_L52
M01_L142:
       mov       r15d,[rbp-0DC]
       mov       r10d,r14d
M01_L143:
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8d,r13d
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L144
       mov       r11d,1
       jmp       short M01_L145
M01_L144:
       xor       r11d,r11d
M01_L145:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE5C7FF360]
       jmp       near ptr M01_L53
M01_L146:
       mov       r11,7FFE5C3B0DB8
       mov       edx,2
       call      qword ptr [r11]
       jmp       near ptr M01_L57
M01_L147:
       mov       r8,[rbp-140]
       test      r8,r8
       je        short M01_L148
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r8],rax
       jne       near ptr M01_L179
       cmp       [r8],r8b
M01_L148:
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L149:
       call      qword ptr [7FFE5C9AFB58]
       mov       ecx,2F9F
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFE5C9AF948]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r13
       call      qword ptr [7FFE5C716670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L150:
       call      qword ptr [7FFE5C8E5680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       xor       edi,edi
       test      rsi,rsi
       setne     dil
       test      edi,edi
       jne       near ptr M01_L01
M01_L151:
       call      qword ptr [7FFE5C9AFB58]
       mov       ecx,1406
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE5C9AF948]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,r12
       call      qword ptr [7FFE5C716670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L152:
       mov       r12,[rbp-80]
       jmp       near ptr M01_L33
M01_L153:
       mov       ecx,0C
       call      qword ptr [7FFE5C714F30]
       int       3
M01_L154:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r13,rax
       jmp       near ptr M01_L03
M01_L155:
       cmp       dword ptr [r13+8],0
       je        short M01_L156
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,r13
       mov       r8,rdi
       call      qword ptr [7FFE5C8E7F18]
       mov       r13,r15
       jmp       near ptr M01_L03
M01_L156:
       mov       rcx,1CEF4405460
       mov       r13,[rcx]
       jmp       near ptr M01_L03
M01_L157:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r12
       mov       r8,rdi
       call      qword ptr [7FFE5C8E7C90]
       jmp       near ptr M01_L03
M01_L158:
       lea       r8,[rbp-78]
       mov       rdx,r13
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, Int32 ByRef)
       call      qword ptr [7FFE5CE1E628]
       mov       [rbp-80],rax
       jmp       near ptr M01_L05
M01_L159:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r11,rax
       jmp       near ptr M01_L06
M01_L160:
       call      qword ptr [7FFE5C694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-170],rcx
       jmp       near ptr M01_L07
M01_L161:
       mov       rcx,[rdx+30]
       mov       [rbp-178],rdx
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L162
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-190],rax
       mov       rcx,rax
       mov       rdx,[rbp-178]
       call      qword ptr [7FFE5C8E5F68]
       mov       rax,[rbp-178]
       mov       rdx,[rbp-190]
       mov       r8,rdx
       jmp       short M01_L163
M01_L162:
       mov       rax,rdx
       mov       [rbp-180],rax
       mov       rcx,[rax+40]
       call      qword ptr [7FFE5C694630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r8,rax
       mov       rax,[rbp-180]
M01_L163:
       lea       rcx,[rax+8]
       mov       [rbp-188],r8
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-188]
       jmp       near ptr M01_L08
M01_L164:
       mov       rcx,[r15+10]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M01_L11
M01_L165:
       mov       rcx,r9
       mov       rdx,[r9]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r8,rax
       mov       rcx,r8
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L13
M01_L166:
       mov       rdx,r9
       mov       r11,[rbp-198]
       mov       rcx,[r11+8]
       call      qword ptr [r11+18]
       mov       r8,rax
       mov       [rbp-1A8],r8
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L14
M01_L167:
       mov       r9d,[rbp-88]
       mov       rax,[rbp-1F0]
       test      rax,rax
       je        short M01_L169
       mov       rcx,offset MT_System.String[]
       cmp       [rax],rcx
       je        short M01_L168
       mov       rdx,rax
       call      qword ptr [7FFE5C4F4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rax,[rbp-1F0]
M01_L168:
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L16
M01_L169:
       jmp       short M01_L168
M01_L170:
       mov       r9d,[rbp-88]
       mov       rcx,r15
       mov       rdx,[rbp-1F0]
       mov       r8d,r9d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L28
M01_L171:
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L22
M01_L172:
       mov       rcx,rax
       mov       r11,7FFE5C3B0D78
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L23
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r13,rax
       mov       rcx,[rbp-150]
       mov       edx,2C
       call      qword ptr [7FFE5CC5E610]
       mov       [rbp-118],r13
       mov       [rbp-110],rax
       lea       r8,[rbp-118]
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFE5CDAFEE8]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M01_L39
M01_L173:
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r13,rax
       jmp       near ptr M01_L25
M01_L174:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA377F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4FF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L175:
       call      qword ptr [7FFE5C9AF978]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L176
       call      qword ptr [7FFE5C9AFB88]
       mov       rbx,rax
M01_L176:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1382
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C4FF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L177:
       mov       ecx,9
       call      qword ptr [7FFE5C714F30]
       int       3
M01_L178:
       mov       ecx,10
       call      qword ptr [7FFE5C714F30]
       int       3
M01_L179:
       mov       rcx,r8
       mov       r11,7FFE5C3B0D70
       call      qword ptr [r11]
       jmp       near ptr M01_L148
M01_L180:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
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
       lea       rbp,[rbp+240]
       cmp       qword ptr [rbp-140],0
       je        short M01_L182
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       rax,[rbp-140]
       cmp       [rax],rcx
       jne       short M01_L181
       cmp       [rax],al
       jmp       short M01_L182
M01_L181:
       mov       rcx,rax
       mov       r11,7FFE5C3B0D70
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
; Total bytes of code 8239
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogComputerInformation()
       mov       rcx,[rcx+118]
       jmp       qword ptr [7FFE5CD8E6D0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
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
       sub       rsp,1F8
       vzeroupper
       lea       rbp,[rsp+230]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-200],rsp
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L126
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ComputerInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5CD8E730]; DotNetTips.Spargine.Core.ComputerInfo..ctor()
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE5C4DEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r14,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+34],eax
       lea       rcx,[r15+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,193B4409A58
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L17
M01_L01:
       test      r14,r14
       je        near ptr M01_L128
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L129
       mov       rdx,r15
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      qword ptr [7FFE5C4D4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       je        near ptr M01_L24
       cmp       dword ptr [r13+8],0
       je        near ptr M01_L130
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r12+10],eax
       lea       rcx,[r12+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,193B4409A60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M01_L16
M01_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       test      r12,r12
       je        near ptr M01_L153
       test      r14,r14
       je        near ptr M01_L152
       xor       ecx,ecx
       mov       [r15+10],rcx
       lea       rcx,[r15+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,193B4403428
       mov       r14,[rcx]
       lea       rcx,[r15+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r15+28],0
       mov       r12,[r15+8]
       mov       rdx,r12
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L132
       mov       rcx,rax
       mov       r11,7FFE5C390F90
       call      qword ptr [r11]
       mov       [rbp-80],rax
       mov       edx,[rax+8]
       mov       [rbp-78],edx
M01_L04:
       mov       edx,[rbp-78]
       test      edx,edx
       je        near ptr M01_L127
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       r13,[rbp-80]
       mov       eax,[rbp-78]
       mov       [rbp-0F8],eax
       lea       rdx,[r12+10]
       mov       r8d,[r12+8]
       mov       [rbp-1E8],rdx
       mov       [rbp-0FC],r8d
       mov       r10,[r15+20]
       cmp       r10,r14
       mov       [rbp-150],r10
       jne       near ptr M01_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L133
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L133
       mov       r9,[rcx]
       add       r9,10
M01_L05:
       mov       r11,[r9+8]
       test      r11,r11
       mov       [rbp-168],r11
       jne       short M01_L06
       mov       r11,193B8400438
       mov       r11,[r11]
       test      r11,r11
       mov       [rbp-168],r11
       jne       short M01_L06
       mov       r11,193B8400418
       mov       r11,[r11]
       mov       [rbp-168],r11
       test      r11,r11
       je        near ptr M01_L134
M01_L06:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-160],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rax,[rbp-168]
       cmp       [rax],rcx
       jne       near ptr M01_L31
       mov       rdx,rax
       mov       r8,[rdx+8]
       test      r8,r8
       je        near ptr M01_L135
M01_L07:
       mov       rdx,r8
M01_L08:
       mov       r10,[rbp-160]
       lea       rcx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r10,[rbp-160]
       mov       [r10+10],ecx
       mov       [rbp-150],r10
M01_L09:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-158],rax
       mov       rdx,[r15+18]
       movzx     r8d,byte ptr [r15+28]
       mov       [rbp-88],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-158]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-150]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-158]
       mov       edx,[rbp-88]
       mov       [rax+28],dl
       xor       edx,edx
       mov       [rax+18],rdx
       cmp       qword ptr [r15+10],0
       jne       near ptr M01_L138
M01_L10:
       mov       r15,rax
       mov       r8d,[rbp-0F8]
       mov       r9d,r8d
       mov       [rbp-8C],r9d
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [r15],rdx
       jne       near ptr M01_L144
       mov       rdx,r15
       mov       r10,[rdx+8]
       mov       [rbp-198],r10
       mov       rdx,193B4403638
       cmp       r10,[rdx]
       je        near ptr M01_L141
       movsxd    rdx,r9d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-1A0],rax
       xor       r8d,r8d
       cmp       dword ptr [rax+8],0
       mov       rax,[rbp-1A0]
       jle       near ptr M01_L13
M01_L11:
       cmp       r8d,[r13+8]
       jae       near ptr M01_L155
       mov       [rbp-90],r8d
       mov       edx,r8d
       mov       rcx,[r13+rdx*8+10]
       mov       r10,rcx
       mov       rdx,7FFE5CE63B88
       mov       r9,[rbp-198]
       cmp       [r9+18],rdx
       jne       near ptr M01_L140
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r10],rdx
       jne       near ptr M01_L139
       mov       [rbp-1A8],r10
       mov       r11,[r10+8]
       test      r11,r11
       je        short M01_L15
M01_L12:
       movsxd    rdx,dword ptr [rbp-90]
       mov       rcx,rax
       mov       r8,r11
       call      CORINFO_HELP_ARRADDR_ST
       mov       r8d,[rbp-90]
       inc       r8d
       mov       rax,[rbp-1A0]
       cmp       [rax+8],r8d
       jg        near ptr M01_L11
M01_L13:
       lea       rcx,[r15+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        near ptr M01_L25
       mov       rdx,r13
       mov       r8d,[rbp-8C]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L25
M01_L15:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0A0],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFE5C7351B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0A0]
       vmovups   [rbp-0B0],xmm0
       lea       rcx,[rbp-0B0]
       call      qword ptr [7FFE5C735230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-1B0],r11
       mov       rcx,[rbp-1A8]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-1B0]
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L12
M01_L16:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,193B4409A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CE63B88
       mov       [r14+18],rcx
       mov       rcx,193B4409A60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L17:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,193B4409A50
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CE63B70
       mov       [r14+18],rcx
       mov       rcx,193B4409A58
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L18:
       test      rcx,rcx
       je        near ptr M01_L149
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rsi
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFE5C70DEB8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L19:
       mov       [rbp-140],rax
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FFE5C4D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rbp-148],rax
       test      rax,rax
       jne       near ptr M01_L147
M01_L20:
       cmp       qword ptr [rbp-140],0
       je        near ptr M01_L36
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r13],rdx
       jne       near ptr M01_L148
       mov       r8,[r13+8]
       test      r8,r8
       je        short M01_L23
M01_L21:
       mov       r13,r8
M01_L22:
       mov       rcx,offset MT_System.String
       mov       rax,[rbp-140]
       cmp       [rax],rcx
       jne       near ptr M01_L38
       jmp       near ptr M01_L34
M01_L23:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C0],xmm0
       mov       rdx,[r13+48]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFE5C7351B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0C0]
       vmovups   [rbp-0D0],xmm0
       lea       rcx,[rbp-0D0]
       call      qword ptr [7FFE5C735230]; System.MdUtf8String.ToString()
       mov       r8,rax
       mov       [rbp-1B8],r8
       lea       rcx,[r13+8]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-1B8]
       mov       r8,r13
       jmp       short M01_L21
M01_L24:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       near ptr M01_L131
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r12+10],eax
       lea       rcx,[r12+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L25:
       movsxd    rdx,dword ptr [rbp-8C]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-190],rax
       xor       r9d,r9d
       cmp       dword ptr [rax+8],0
       jle       short M01_L27
M01_L26:
       mov       ecx,r9d
       mov       [rax+rcx*4+10],r9d
       inc       r9d
       cmp       [rax+8],r9d
       jg        short M01_L26
M01_L27:
       mov       r9d,[rbp-8C]
       dec       r9d
       mov       rcx,r15
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r15]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       r15,[rbp-190]
       xor       eax,eax
       mov       r8d,[rbp-0FC]
       test      r8d,r8d
       jle       short M01_L29
       cmp       [r15+8],r8d
       jl        near ptr M01_L32
M01_L28:
       cmp       eax,r8d
       jae       near ptr M01_L155
       mov       ecx,eax
       mov       r10,[rbp-1E8]
       lea       rcx,[r10+rcx*8]
       mov       [rbp-84],eax
       mov       edx,eax
       mov       r9d,[r15+rdx*4+10]
       cmp       r9d,[r13+8]
       jae       near ptr M01_L155
       mov       edx,r9d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rbp-84]
       inc       eax
       mov       r8d,[rbp-0FC]
       cmp       eax,r8d
       jl        short M01_L28
M01_L29:
       xor       r15d,r15d
       cmp       dword ptr [r12+8],0
       jle       near ptr M01_L37
M01_L30:
       mov       ecx,r15d
       mov       r13,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r13],rcx
       jne       near ptr M01_L146
       mov       rcx,r13
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L145
       jmp       near ptr M01_L18
M01_L31:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L08
M01_L32:
       cmp       eax,r8d
       jae       near ptr M01_L155
       mov       ecx,eax
       mov       r10,[rbp-1E8]
       lea       rcx,[r10+rcx*8]
       cmp       eax,[r15+8]
       jae       near ptr M01_L155
       mov       [rbp-84],eax
       mov       edx,eax
       mov       r9d,[r15+rdx*4+10]
       cmp       r9d,[r13+8]
       jae       near ptr M01_L155
       mov       edx,r9d
       mov       rdx,[r13+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rbp-84]
       inc       ecx
       mov       eax,[rbp-0FC]
       cmp       ecx,eax
       mov       r8d,eax
       jl        short M01_L33
       jmp       near ptr M01_L29
M01_L33:
       mov       eax,ecx
       jmp       short M01_L32
M01_L34:
       cmp       [rax],al
M01_L35:
       mov       [rbp-1F0],rax
       mov       rcx,rdi
       mov       r11,7FFE5C390FA0
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L150
       mov       [rbp-120],r13
       mov       rax,[rbp-1F0]
       mov       [rbp-118],rax
       mov       rcx,rdi
       lea       rdx,[rbp-120]
       mov       r11,7FFE5C390FA8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L36
       mov       [rbp-120],r13
       mov       r13,[rbp-1F0]
       mov       [rbp-118],r13
       mov       rcx,rdi
       lea       rdx,[rbp-120]
       mov       r11,7FFE5C390F98
       call      qword ptr [r11]
M01_L36:
       inc       r15d
       cmp       [r12+8],r15d
       jg        near ptr M01_L30
M01_L37:
       jmp       short M01_L39
M01_L38:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L35
M01_L39:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFE5CE3CCA8]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r12+8]
       mov       r11,7FFE5C390FB0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L125
       mov       rcx,193B4406E00
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M01_L41
M01_L40:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L152
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       ecx,ecx
       mov       [r14+18],ecx
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       [rbp-138],rcx
       jmp       short M01_L42
M01_L41:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,193B4406DF0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE5CD8B318
       mov       [rsi+18],rcx
       mov       rcx,193B4406E00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L42:
       test      rcx,rcx
       je        near ptr M01_L60
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [rcx],rax
       jne       near ptr M01_L60
       jmp       near ptr M01_L53
M01_L43:
       mov       rcx,[rbp-138]
       vmovdqu   xmm0,xmmword ptr [rcx+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       rdx,193B4403438
       mov       r8,[rdx]
       mov       rcx,r8
       mov       edx,100
       call      qword ptr [7FFE5C7E6FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       test      rax,rax
       je        near ptr M01_L122
       lea       rsi,[rax+10]
       mov       edi,[rax+8]
M01_L44:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       [rbp-68],rax
       mov       [rbp-60],ecx
       mov       byte ptr [rbp-5C],0
       mov       [rbp-58],rsi
       mov       [rbp-50],edi
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L55
       mov       r14d,[rbp-60]
       cmp       r14d,[rbp-50]
       ja        near ptr M01_L120
       mov       rcx,[rbp-58]
       mov       edx,r14d
       lea       r15,[rcx+rdx*2]
       mov       r8d,[rbp-50]
       sub       r8d,r14d
       cmp       r8d,0C
       jb        near ptr M01_L55
       mov       r13,1D44637464C
       vmovdqu   xmm0,xmmword ptr [r13]
       vmovdqu   xmm1,xmmword ptr [r13+8]
       vmovdqu   xmmword ptr [r15],xmm0
       vmovdqu   xmmword ptr [r15+8],xmm1
       mov       ecx,[rbp-60]
       add       ecx,0C
       mov       [rbp-60],ecx
M01_L45:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       rax,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r12d
       cmp       r10d,1
       jb        near ptr M01_L123
       mov       r9,1D446360A4C
       movzx     r8d,word ptr [r9]
       mov       [rax],r8w
       mov       r8d,[rbp-60]
       inc       r8d
       mov       [rbp-60],r8d
M01_L46:
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L57
       test      r12,r12
       je        near ptr M01_L57
       mov       r11d,[rbp-60]
       cmp       r11d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r11d
       lea       rcx,[r8+rcx*2]
       mov       edx,[rbp-50]
       sub       edx,r11d
       cmp       [r12+8],edx
       ja        near ptr M01_L57
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L47:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       rax,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r12d
       cmp       r10d,3
       jb        near ptr M01_L62
       mov       r9,1D44637467C
       mov       ecx,[r9]
       mov       r8d,[r9+2]
       mov       [rax],ecx
       mov       [rax+2],r8d
       mov       r8d,[rbp-60]
       add       r8d,3
       mov       [rbp-60],r8d
M01_L48:
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L58
       test      r12,r12
       je        near ptr M01_L58
       mov       r11d,[rbp-60]
       cmp       r11d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r11d
       lea       rcx,[r8+rcx*2]
       mov       edx,[rbp-50]
       sub       edx,r11d
       cmp       [r12+8],edx
       ja        near ptr M01_L58
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L49:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       rax,[rbp-58]
       mov       [rbp-130],rax
       mov       [rbp-128],r12d
       lea       rcx,[rbp-130]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rbp-68]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       test      r13,r13
       je        near ptr M01_L52
       mov       rcx,193B4403438
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE5C415120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L63
M01_L50:
       xor       edi,edi
       mov       esi,1
       cmp       [rax+8],r14d
       jbe       short M01_L51
       mov       edi,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [r13+8],ecx
       jne       near ptr M01_L121
       cmp       r14d,[rax+8]
       jae       near ptr M01_L54
       mov       ecx,r14d
       shl       rcx,4
       lea       r8,[rax+rcx+10]
       mov       r10,[r8]
       mov       [rbp-1D0],r10
       mov       [rbp-1C8],r8
       mov       rcx,r8
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp-1C8]
       mov       [rax+8],ecx
       mov       r10,[rbp-1D0]
       test      r10,r10
       jne       near ptr M01_L64
M01_L51:
       mov       rcx,193B84005D0
       mov       r9,[rcx]
       cmp       byte ptr [r9+9D],0
       jne       near ptr M01_L78
M01_L52:
       mov       rcx,rbx
       mov       rdx,r12
       mov       r8,1D446374690
       call      qword ptr [7FFE5CD8F408]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       mov       rcx,[rbp-138]
M01_L53:
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CE88D00]; System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L43
       jmp       near ptr M01_L124
M01_L54:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L55:
       lea       rcx,[rbp-70]
       mov       rdx,1D446374640
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L45
M01_L56:
       test      eax,eax
       jne       near ptr M01_L84
       jmp       near ptr M01_L124
M01_L57:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L47
M01_L58:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L49
M01_L59:
       mov       rcx,rbx
       mov       rdx,r12
       mov       r8,1D446374690
       call      qword ptr [7FFE5CD8F408]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogDebugMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       mov       rcx,[rbp-138]
M01_L60:
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [rcx],rax
       jne       near ptr M01_L119
       cmp       [rcx],ecx
       call      qword ptr [7FFE5CE88D00]; System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].MoveNext()
       jmp       short M01_L56
M01_L61:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L86
M01_L62:
       lea       rcx,[rbp-70]
       mov       rdx,1D446374670
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M01_L48
M01_L63:
       mov       rcx,r15
       call      qword ptr [7FFE5C7DE910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L50
M01_L64:
       mov       rsi,r10
       mov       r8,[r15+10]
       cmp       r14d,[r8+8]
       jae       near ptr M01_L54
       mov       ecx,r14d
       mov       r10,[r8+rcx*8+10]
       test      r10,r10
       jne       short M01_L65
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFE5C7DE898]
       mov       r10,rax
M01_L65:
       mov       rax,[r10+8]
       mov       [rbp-1D8],rax
       mov       rcx,7FFE5C415120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE5C415C38],0
       je        short M01_L66
       call      qword ptr [7FFE5C4DDC98]
       mov       edx,eax
       mov       [rbp-0E8],edx
       jmp       short M01_L69
M01_L66:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rbp-0EC],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0EC]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L67
       call      qword ptr [7FFE5CEAE940]
       mov       edx,eax
       jmp       short M01_L68
M01_L67:
       mov       edx,ecx
       sar       edx,10
M01_L68:
       mov       [rbp-0E8],edx
M01_L69:
       mov       rcx,7FFE5C415120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0E8]
       xor       edx,edx
       div       dword ptr [7FFE5C415C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L76
M01_L70:
       cmp       eax,[r8+8]
       jae       near ptr M01_L54
       mov       [rbp-0E0],eax
       mov       ecx,eax
       mov       [rbp-1D8],r8
       mov       r10,[r8+rcx*8+10]
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rbp-0F0],r9d
       mov       [rbp-1E0],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1E0]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       cmp       [rcx+8],r10d
       jbe       short M01_L72
       test      r10d,r10d
       jne       short M01_L73
       xor       edx,edx
       mov       [rbp-1E0],rax
       mov       [rax+14],edx
M01_L71:
       mov       [rbp-0F4],r10d
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0F4]
       inc       ecx
       mov       rax,[rbp-1E0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0F0],1
M01_L72:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       eax,[rbp-0F0]
       test      eax,eax
       je        short M01_L74
       mov       edx,1
       jmp       short M01_L77
M01_L73:
       mov       [rbp-1E0],rax
       jmp       short M01_L71
M01_L74:
       mov       eax,[rbp-0E0]
       inc       eax
       mov       r8d,eax
       mov       r10,[rbp-1D8]
       cmp       [r10+8],r8d
       jne       short M01_L75
       xor       r8d,r8d
M01_L75:
       mov       edx,[rbp-0E4]
       inc       edx
       mov       [rbp-1D8],r10
       mov       eax,r8d
M01_L76:
       mov       r8,[rbp-1D8]
       mov       [rbp-0E4],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L70
       xor       edx,edx
M01_L77:
       mov       esi,edx
       jmp       near ptr M01_L51
M01_L78:
       cmp       dword ptr [r13+8],0
       mov       [rbp-1C0],r9
       je        near ptr M01_L52
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D4],eax
       mov       edx,[r13+8]
       mov       [rbp-0D8],edx
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-1C0]
       mov       r8d,[rbp-0D4]
       mov       r9d,[rbp-0D8]
       mov       edx,3
       call      qword ptr [7FFE5C587678]
       test      esi,edi
       jne       near ptr M01_L52
       mov       rsi,[rbp-1C0]
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       [rbp-0DC],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      edi,edi
       jne       short M01_L79
       mov       r15d,[rbp-0DC]
       mov       r10d,0FFFFFFFF
       jmp       short M01_L80
M01_L79:
       mov       r15d,[rbp-0DC]
       mov       r10d,r14d
M01_L80:
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8d,r13d
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L81
       mov       r11d,1
       jmp       short M01_L82
M01_L81:
       xor       r11d,r11d
M01_L82:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE5C7DF360]
       jmp       near ptr M01_L52
M01_L83:
       lea       rdx,[rbp-48]
       mov       rcx,r8
       mov       r11,7FFE5C390F70
       call      qword ptr [r11]
       jmp       short M01_L85
M01_L84:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,[rbp-138]
       cmp       [r8],rcx
       jne       short M01_L83
       vmovdqu   xmm0,xmmword ptr [r8+20]
       vmovdqu   xmmword ptr [rbp-48],xmm0
M01_L85:
       mov       rcx,193B4403438
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE5C7E6FF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       r8,rax
       test      rax,rax
       je        near ptr M01_L61
       lea       rsi,[r8+10]
       mov       edi,[r8+8]
M01_L86:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       [rbp-68],r8
       mov       [rbp-60],ecx
       mov       byte ptr [rbp-5C],0
       mov       [rbp-58],rsi
       mov       [rbp-50],edi
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L94
       mov       r14d,[rbp-60]
       cmp       r14d,[rbp-50]
       ja        near ptr M01_L120
       mov       rcx,[rbp-58]
       mov       edx,r14d
       lea       r15,[rcx+rdx*2]
       mov       r8d,[rbp-50]
       sub       r8d,r14d
       cmp       r8d,0C
       jb        near ptr M01_L94
       mov       r13,1D44637464C
       vmovdqu   xmm0,xmmword ptr [r13]
       vmovdqu   xmm1,xmmword ptr [r13+8]
       vmovdqu   xmmword ptr [r15],xmm0
       vmovdqu   xmmword ptr [r15+8],xmm1
       mov       ecx,[rbp-60]
       add       ecx,0C
       mov       [rbp-60],ecx
M01_L87:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       rax,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r12d
       cmp       r10d,1
       jb        near ptr M01_L99
       mov       r9,1D446360A4C
       movzx     r8d,word ptr [r9]
       mov       [rax],r8w
       mov       r8d,[rbp-60]
       inc       r8d
       mov       [rbp-60],r8d
M01_L88:
       mov       r12,[rbp-48]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L95
       test      r12,r12
       je        near ptr M01_L95
       mov       r11d,[rbp-60]
       cmp       r11d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r11d
       lea       rcx,[r8+rcx*2]
       mov       edx,[rbp-50]
       sub       edx,r11d
       cmp       [r12+8],edx
       ja        near ptr M01_L95
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L89:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r12d
       lea       rax,[r8+rcx*2]
       mov       r10d,[rbp-50]
       sub       r10d,r12d
       cmp       r10d,3
       jb        near ptr M01_L98
       mov       r9,1D44637467C
       mov       ecx,[r9]
       mov       r8d,[r9+2]
       mov       [rax],ecx
       mov       [rax+2],r8d
       mov       r8d,[rbp-60]
       add       r8d,3
       mov       [rbp-60],r8d
M01_L90:
       mov       r12,[rbp-40]
       cmp       byte ptr [rbp-5C],0
       jne       near ptr M01_L96
       test      r12,r12
       je        near ptr M01_L96
       mov       r11d,[rbp-60]
       cmp       r11d,[rbp-50]
       ja        near ptr M01_L120
       mov       r8,[rbp-58]
       mov       ecx,r11d
       lea       rcx,[r8+rcx*2]
       mov       edx,[rbp-50]
       sub       edx,r11d
       cmp       [r12+8],edx
       ja        near ptr M01_L96
       lea       rdx,[r12+0C]
       mov       r8d,[r12+8]
       add       r8,r8
       call      qword ptr [7FFE5C585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-60]
       add       ecx,[r12+8]
       mov       [rbp-60],ecx
M01_L91:
       mov       r12d,[rbp-60]
       cmp       r12d,[rbp-50]
       ja        near ptr M01_L120
       mov       rax,[rbp-58]
       mov       [rbp-130],rax
       mov       [rbp-128],r12d
       lea       rcx,[rbp-130]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       mov       r13,[rbp-68]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-70],ymm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       test      r13,r13
       je        near ptr M01_L59
       mov       rcx,193B4403438
       mov       r15,[rcx]
       mov       ecx,[r13+8]
       dec       ecx
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,7FFE5C415120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L97
M01_L92:
       xor       edi,edi
       mov       esi,1
       cmp       [rax+8],r14d
       jbe       short M01_L93
       mov       edi,1
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       [r13+8],ecx
       jne       near ptr M01_L121
       cmp       r14d,[rax+8]
       jae       near ptr M01_L54
       mov       ecx,r14d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       r10,[rax]
       mov       [rbp-1D0],r10
       mov       [rbp-1C8],rax
       mov       rcx,rax
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp-1C8]
       mov       [rdx+8],ecx
       mov       rax,[rbp-1D0]
       test      rax,rax
       jne       near ptr M01_L100
M01_L93:
       mov       rcx,193B84005D0
       mov       r9,[rcx]
       mov       r10,r9
       cmp       byte ptr [r10+9D],0
       jne       near ptr M01_L114
       mov       r8,[rbp-138]
       jmp       near ptr M01_L59
M01_L94:
       lea       rcx,[rbp-70]
       mov       rdx,1D446374640
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L87
M01_L95:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L89
M01_L96:
       lea       rcx,[rbp-70]
       mov       rdx,r12
       call      qword ptr [7FFE5C645848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L91
M01_L97:
       mov       rcx,r15
       call      qword ptr [7FFE5C7DE910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M01_L92
M01_L98:
       lea       rcx,[rbp-70]
       mov       rdx,1D446374670
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M01_L90
M01_L99:
       lea       rcx,[rbp-70]
       mov       rdx,1D446360A40
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M01_L88
M01_L100:
       mov       rsi,rax
       mov       r8,[r15+10]
       cmp       r14d,[r8+8]
       jae       near ptr M01_L54
       mov       ecx,r14d
       mov       r10,[r8+rcx*8+10]
       test      r10,r10
       jne       short M01_L101
       mov       rcx,r15
       mov       edx,r14d
       call      qword ptr [7FFE5C7DE898]
       mov       r10,rax
M01_L101:
       mov       r10,[r10+8]
       mov       [rbp-1D8],r10
       mov       rcx,7FFE5C415120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFE5C415C38],0
       je        short M01_L102
       call      qword ptr [7FFE5C4DDC98]
       mov       [rbp-0E8],eax
       jmp       short M01_L105
M01_L102:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rax+0A3C]
       mov       [rbp-0EC],ecx
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rbp-0EC]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L103
       call      qword ptr [7FFE5CEAE940]
       jmp       short M01_L104
M01_L103:
       mov       eax,ecx
       sar       eax,10
M01_L104:
       mov       [rbp-0E8],eax
M01_L105:
       mov       rcx,7FFE5C415120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rbp-0E8]
       xor       edx,edx
       div       dword ptr [7FFE5C415C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L112
M01_L106:
       cmp       eax,[r8+8]
       jae       near ptr M01_L54
       mov       [rbp-0E0],eax
       mov       ecx,eax
       mov       [rbp-1D8],r8
       mov       rcx,[r8+rcx*8+10]
       mov       r10,rcx
       cmp       [r10],r10b
       xor       ecx,ecx
       mov       [rbp-0F0],ecx
       mov       [rbp-1E0],r10
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-1E0]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       mov       r10d,edx
       cmp       [rcx+8],r10d
       jbe       short M01_L108
       test      r10d,r10d
       jne       short M01_L109
       xor       edx,edx
       mov       [rbp-1E0],rax
       mov       [rax+14],edx
M01_L107:
       mov       [rbp-0F4],r10d
       movsxd    rdx,r10d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-0F4]
       inc       ecx
       mov       rax,[rbp-1E0]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-0F0],1
M01_L108:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-0F0]
       test      ecx,ecx
       je        short M01_L110
       mov       edx,1
       jmp       short M01_L113
M01_L109:
       mov       [rbp-1E0],rax
       jmp       short M01_L107
M01_L110:
       mov       edx,[rbp-0E0]
       lea       eax,[rdx+1]
       mov       edx,eax
       mov       rcx,[rbp-1D8]
       cmp       [rcx+8],edx
       jne       short M01_L111
       xor       edx,edx
M01_L111:
       mov       eax,[rbp-0E4]
       inc       eax
       mov       [rbp-1D8],rcx
       mov       r8d,eax
       mov       eax,edx
       mov       edx,r8d
M01_L112:
       mov       r8,[rbp-1D8]
       mov       [rbp-0E4],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L106
       xor       edx,edx
M01_L113:
       mov       esi,edx
       jmp       near ptr M01_L93
M01_L114:
       cmp       dword ptr [r13+8],0
       mov       [rbp-1C0],r10
       je        near ptr M01_L59
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-0D4],eax
       mov       r9d,[r13+8]
       mov       [rbp-0D8],r9d
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rbp-1C0]
       mov       r8d,[rbp-0D4]
       mov       r9d,[rbp-0D8]
       mov       edx,3
       call      qword ptr [7FFE5C587678]
       test      esi,edi
       jne       near ptr M01_L59
       mov       rsi,[rbp-1C0]
       cmp       [r13],r13b
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,[r13+8]
       mov       [rbp-0DC],eax
       mov       rcx,r15
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      edi,edi
       jne       short M01_L115
       mov       r15d,[rbp-0DC]
       mov       r10d,0FFFFFFFF
       jmp       short M01_L116
M01_L115:
       mov       r15d,[rbp-0DC]
       mov       r10d,r14d
M01_L116:
       mov       rcx,rsi
       mov       edx,r15d
       mov       r8d,r13d
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L117
       mov       r11d,1
       jmp       short M01_L118
M01_L117:
       xor       r11d,r11d
M01_L118:
       mov       [rsp+20],r10d
       mov       [rsp+28],r11d
       call      qword ptr [7FFE5C7DF360]
       jmp       near ptr M01_L59
M01_L119:
       mov       r11,7FFE5C390F68
       call      qword ptr [r11]
       jmp       near ptr M01_L56
M01_L120:
       call      qword ptr [7FFE5C6CE9D0]
       int       3
M01_L121:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA1DAD0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FFE5C384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L122:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M01_L44
M01_L123:
       lea       rcx,[rbp-70]
       mov       rdx,1D446360A40
       call      qword ptr [7FFE5C6458F0]
       jmp       near ptr M01_L46
M01_L124:
       mov       r8,[rbp-138]
       test      r8,r8
       je        short M01_L125
       mov       rax,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       cmp       [r8],rax
       jne       near ptr M01_L154
       cmp       [r8],r8b
M01_L125:
       add       rsp,1F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L126:
       call      qword ptr [7FFE5C98FB58]
       mov       ecx,2F9F
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE5C4D6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5C98F948]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FFE5C6F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L127:
       mov       r12,[rbp-80]
       jmp       near ptr M01_L29
M01_L128:
       mov       ecx,0C
       call      qword ptr [7FFE5C6F4F30]
       int       3
M01_L129:
       mov       rcx,rax
       mov       rdx,r14
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r12,rax
       jmp       near ptr M01_L02
M01_L130:
       mov       rcx,193B4403468
       mov       r12,[rcx]
       jmp       near ptr M01_L02
M01_L131:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       rdx,r13
       mov       r8,r14
       call      qword ptr [7FFE5C8C7C90]
       jmp       near ptr M01_L02
M01_L132:
       lea       r8,[rbp-78]
       mov       rdx,r12
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, Int32 ByRef)
       call      qword ptr [7FFE5CFD5E30]
       mov       [rbp-80],rax
       jmp       near ptr M01_L04
M01_L133:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r9,rax
       jmp       near ptr M01_L05
M01_L134:
       call      qword ptr [7FFE5C674030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-168],rcx
       jmp       near ptr M01_L06
M01_L135:
       mov       rcx,[rdx+30]
       mov       [rbp-170],rdx
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L136
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-188],rax
       mov       rcx,rax
       mov       rdx,[rbp-170]
       call      qword ptr [7FFE5C8C5F68]
       mov       rax,[rbp-170]
       mov       rdx,[rbp-188]
       mov       r8,rdx
       jmp       short M01_L137
M01_L136:
       mov       rax,rdx
       mov       [rbp-178],rax
       mov       rcx,[rax+40]
       call      qword ptr [7FFE5C674630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r8,rax
       mov       rax,[rbp-178]
M01_L137:
       lea       rcx,[rax+8]
       mov       [rbp-180],r8
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-180]
       jmp       near ptr M01_L07
M01_L138:
       mov       rcx,[r15+10]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M01_L10
M01_L139:
       mov       rcx,r10
       mov       rdx,[r10]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L12
M01_L140:
       mov       rdx,r10
       mov       r9,[rbp-198]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r11,rax
       mov       rax,[rbp-1A0]
       jmp       near ptr M01_L12
M01_L141:
       test      r13,r13
       je        short M01_L143
       mov       rcx,offset MT_System.String[]
       cmp       [r13],rcx
       je        short M01_L142
       mov       rdx,r13
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L142:
       lea       rcx,[r15+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L14
M01_L143:
       jmp       short M01_L142
M01_L144:
       mov       rcx,r15
       mov       rdx,r13
       mov       r8d,r9d
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L25
M01_L145:
       xor       ecx,ecx
       jmp       near ptr M01_L18
M01_L146:
       mov       rcx,r13
       mov       rdx,rsi
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L19
M01_L147:
       mov       rcx,rax
       mov       r11,7FFE5C390F80
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L20
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r13,rax
       mov       rcx,[rbp-148]
       mov       edx,2C
       call      qword ptr [7FFE5CC3E610]
       mov       [rbp-110],r13
       mov       [rbp-108],rax
       lea       r8,[rbp-110]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FFE5CE67C30]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M01_L36
M01_L148:
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r13,rax
       jmp       near ptr M01_L22
M01_L149:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE5CA177F8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L150:
       call      qword ptr [7FFE5C98F978]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L151
       call      qword ptr [7FFE5C98FB88]
       mov       rbx,rax
M01_L151:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1382
       mov       rdx,7FFE5C7EB558
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C4DF750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L152:
       mov       ecx,9
       call      qword ptr [7FFE5C6F4F30]
       int       3
M01_L153:
       mov       ecx,10
       call      qword ptr [7FFE5C6F4F30]
       int       3
M01_L154:
       mov       rcx,r8
       mov       r11,7FFE5C390F78
       call      qword ptr [r11]
       jmp       near ptr M01_L125
M01_L155:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
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
       lea       rbp,[rbp+230]
       cmp       qword ptr [rbp-138],0
       je        short M01_L157
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`1+<GetEnumerator>d__19[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       rax,[rbp-138]
       cmp       [rax],rcx
       jne       short M01_L156
       cmp       [rax],al
       jmp       short M01_L157
M01_L156:
       mov       rcx,rax
       mov       r11,7FFE5C390F78
       call      qword ptr [r11]
M01_L157:
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
; Total bytes of code 7390
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rcx,28147904618
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,28147904640
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFE5CDAE6E8]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
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
       push      rsi
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L02
       call      qword ptr [7FFE5CDAE700]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rbx,rax
       mov       r8,240B5808E00
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L03
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FFE5C9257E8]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FFE5C4F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       r11,7FFE5C3B0AC8
       call      qword ptr [r11]
       mov       rbx,rax
M01_L01:
       cmp       [rbx],bl
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       call      qword ptr [7FFE5C9AFB58]
       mov       ecx,13F2
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C80B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C4F6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9AF948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,240B5808DE8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FFE5CDAA7D8
       call      qword ptr [7FFE5C4F4210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,240B5808E00
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,10
       call      qword ptr [7FFE5C714F30]
       int       3
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFE5C5ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L01
; Total bytes of code 435
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
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
       mov       rcx,20D4A704618
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,20D4A704640
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FFE5CDBE700]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
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
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L02
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1CCB88055E0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L00:
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L03
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       movsxd    rdx,edx
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
M01_L01:
       mov       rbx,[rbx+20]
       test      rbx,rbx
       jne       short M01_L00
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
       call      qword ptr [7FFE5C9BFB58]
       mov       ecx,13F2
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE5C81B558
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE5C506B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE5C9BF948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE5C726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE5C5BE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L01
; Total bytes of code 308
```

