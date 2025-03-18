## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogApplicationInformation()
       mov       rcx,[rcx+128]
       jmp       qword ptr [7FF98370FC90]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogApplicationInformation(Microsoft.Extensions.Logging.ILogger)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,208
       vzeroupper
       xor       eax,eax
       mov       [rsp+0F8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+100],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       vmovdqa   xmmword ptr [rsp+rax+210],xmm4
       vmovdqa   xmmword ptr [rsp+rax+220],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+200],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L97
       mov       rcx,1EB4F808AC0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L98
       mov       rbp,[rcx+18]
       xor       r14d,r14d
       test      rbp,rbp
       setne     r14b
       test      r14d,r14d
       je        near ptr M01_L99
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF982E5EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rbp
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EB4F80B3A0
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L18
M01_L02:
       test      r13,r13
       je        near ptr M01_L101
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L102
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      qword ptr [7FF982E54330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M01_L103
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E54360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L105
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rcx,1EB4F80B3A8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L17
M01_L04:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L125
       test      rdi,rdi
       je        near ptr M01_L124
       xor       ecx,ecx
       mov       [r12+10],rcx
       lea       rcx,[r12+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1EB4F805CD8
       mov       rsi,[rcx]
       lea       rcx,[r12+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r12+28],0
       mov       rdi,[r12+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L106
       mov       rcx,rax
       mov       r11,7FF982D10D48
       call      qword ptr [r11]
       mov       [rsp+1D0],rax
       mov       edx,[rax+8]
       mov       [rsp+1D8],edx
M01_L05:
       mov       edx,[rsp+1D8]
       test      edx,edx
       je        near ptr M01_L100
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r13,rax
       mov       r14,[rsp+1D0]
       mov       edi,[rsp+1D8]
       lea       rax,[r13+10]
       mov       edx,[r13+8]
       mov       [rsp+30],rax
       mov       [rsp+13C],edx
       mov       r8,[r12+20]
       cmp       r8,rsi
       mov       [rsp+0E8],r8
       jne       near ptr M01_L10
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L107
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L107
       mov       r10,[rcx]
       add       r10,10
M01_L06:
       mov       r9,[r10+8]
       test      r9,r9
       mov       [rsp+0D0],r9
       jne       short M01_L07
       mov       r9,1EB4F800438
       mov       r9,[r9]
       test      r9,r9
       mov       [rsp+0D0],r9
       jne       short M01_L07
       mov       r9,1EB4F800418
       mov       r9,[r9]
       mov       [rsp+0D0],r9
       test      r9,r9
       je        near ptr M01_L108
M01_L07:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0D8],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rax,[rsp+0D0]
       cmp       [rax],rcx
       jne       near ptr M01_L26
       mov       rdx,rax
       mov       r10,[rdx+8]
       test      r10,r10
       je        near ptr M01_L109
M01_L08:
       mov       rdx,r10
M01_L09:
       mov       r8,[rsp+0D8]
       lea       rcx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rsp+0D8]
       mov       [r8+10],ecx
       mov       [rsp+0E8],r8
M01_L10:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0E0],rax
       mov       rdx,[r12+18]
       movzx     r8d,byte ptr [r12+28]
       mov       [rsp+1CC],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0E0]
       lea       rcx,[rax+10]
       mov       rdx,[rsp+0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0E0]
       mov       edx,[rsp+1CC]
       mov       [rax+28],dl
       xor       edx,edx
       mov       [rax+18],rdx
       cmp       qword ptr [r12+10],0
       jne       near ptr M01_L112
M01_L11:
       mov       r12,rax
       mov       [rsp+0A8],r14
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [r12],rdx
       jne       near ptr M01_L117
       mov       r8,[rsp+0A8]
       mov       rdx,r12
       mov       r10,[rdx+8]
       mov       [rsp+98],r10
       mov       rdx,1EB4F805EA8
       cmp       r10,[rdx]
       je        near ptr M01_L115
       movsxd    rdx,edi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+90],rax
       xor       r8d,r8d
       cmp       dword ptr [rax+8],0
       mov       rax,[rsp+90]
       jle       near ptr M01_L14
M01_L12:
       cmp       r8d,[r14+8]
       jae       near ptr M01_L135
       mov       [rsp+1C8],r8d
       mov       edx,r8d
       mov       rcx,[r14+rdx*8+10]
       mov       r10,rcx
       mov       rdx,7FF983741920
       mov       r9,[rsp+98]
       cmp       [r9+18],rdx
       jne       near ptr M01_L114
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r10],rdx
       jne       near ptr M01_L113
       mov       [rsp+88],r10
       mov       r11,[r10+8]
       test      r11,r11
       je        short M01_L16
M01_L13:
       movsxd    rdx,dword ptr [rsp+1C8]
       mov       rcx,rax
       mov       r8,r11
       call      CORINFO_HELP_ARRADDR_ST
       mov       r8d,[rsp+1C8]
       inc       r8d
       mov       rax,[rsp+90]
       cmp       [rax+8],r8d
       jg        near ptr M01_L12
M01_L14:
       lea       rcx,[r12+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       rcx,[r12+18]
       test      rcx,rcx
       je        near ptr M01_L27
       mov       rdx,r14
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L16:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+1B8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rsp+1B8]
       call      qword ptr [7FF9830C51B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+1B8]
       vmovups   [rsp+1A8],xmm0
       lea       rcx,[rsp+1A8]
       call      qword ptr [7FF9830C5230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rsp+80],r11
       mov       rcx,[rsp+88]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rsp+80]
       mov       rax,[rsp+90]
       jmp       near ptr M01_L13
M01_L17:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1EB4F80B398
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983741920
       mov       [rdi+18],rcx
       mov       rcx,1EB4F80B3A8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L04
       nop       dword ptr [rax+rax]
M01_L18:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1EB4F80B398
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983741908
       mov       [r13+18],rcx
       mov       rcx,1EB4F80B3A0
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L19:
       mov       rcx,[rdi+18]
M01_L20:
       test      rcx,rcx
       je        near ptr M01_L121
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbp
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FF98308E9E8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r14,rax
M01_L21:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FF982E54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+0F0],rax
       test      rax,rax
       jne       near ptr M01_L119
M01_L22:
       test      r14,r14
       je        near ptr M01_L38
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdi],rdx
       jne       near ptr M01_L120
       mov       rax,[rdi+8]
       test      rax,rax
       je        short M01_L25
M01_L23:
       mov       rdi,rax
M01_L24:
       mov       rcx,offset MT_System.String
       cmp       [r14],rcx
       jne       near ptr M01_L34
       jmp       near ptr M01_L36
M01_L25:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+198],xmm0
       mov       rdx,[rdi+48]
       lea       rcx,[rsp+198]
       call      qword ptr [7FF9830C51B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+198]
       vmovups   [rsp+188],xmm0
       lea       rcx,[rsp+188]
       call      qword ptr [7FF9830C5230]; System.MdUtf8String.ToString()
       mov       [rsp+78],rax
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+78]
       mov       rax,rdi
       jmp       short M01_L23
M01_L26:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L09
M01_L27:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+0A0],rax
       xor       r9d,r9d
       cmp       dword ptr [rax+8],0
       jle       short M01_L29
M01_L28:
       mov       ecx,r9d
       mov       [rax+rcx*4+10],r9d
       inc       r9d
       cmp       [rax+8],r9d
       jg        short M01_L28
M01_L29:
       lea       r9d,[rdi-1]
       mov       rcx,r12
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[r12]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rdi,[rsp+0A0]
       xor       r12d,r12d
       mov       eax,[rsp+13C]
       test      eax,eax
       jle       near ptr M01_L32
       cmp       [rdi+8],eax
       jl        short M01_L31
M01_L30:
       cmp       r12d,eax
       jae       near ptr M01_L135
       mov       ecx,r12d
       mov       r8,[rsp+30]
       lea       rcx,[r8+rcx*8]
       mov       edx,r12d
       mov       r10d,[rdi+rdx*4+10]
       cmp       r10d,[r14+8]
       jae       near ptr M01_L135
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       eax,[rsp+13C]
       cmp       r12d,eax
       jl        short M01_L30
       jmp       short M01_L32
M01_L31:
       cmp       r12d,eax
       jae       near ptr M01_L135
       mov       ecx,r12d
       mov       r8,[rsp+30]
       lea       rcx,[r8+rcx*8]
       cmp       r12d,[rdi+8]
       jae       near ptr M01_L135
       mov       edx,r12d
       mov       r10d,[rdi+rdx*4+10]
       cmp       r10d,[r14+8]
       jae       near ptr M01_L135
       mov       edx,r10d
       mov       rdx,[r14+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       mov       eax,[rsp+13C]
       cmp       r12d,eax
       jl        short M01_L31
M01_L32:
       xor       r12d,r12d
       cmp       dword ptr [r13+8],0
       jle       near ptr M01_L39
M01_L33:
       mov       ecx,r12d
       mov       rdi,[r13+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L118
       mov       rcx,rdi
       cmp       qword ptr [rcx+18],0
       je        short M01_L35
       jmp       near ptr M01_L19
M01_L34:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       short M01_L37
M01_L35:
       xor       ecx,ecx
       jmp       near ptr M01_L20
M01_L36:
       cmp       [r14],r14b
M01_L37:
       mov       rcx,r15
       mov       r11,7FF982D10D58
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L122
       mov       [rsp+118],rdi
       mov       [rsp+120],r14
       mov       rcx,r15
       lea       rdx,[rsp+118]
       mov       r11,7FF982D10D60
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L38
       mov       [rsp+118],rdi
       mov       [rsp+120],r14
       mov       rcx,r15
       lea       rdx,[rsp+118]
       mov       r11,7FF982D10D50
       call      qword ptr [r11]
M01_L38:
       inc       r12d
       cmp       [r13+8],r12d
       jg        near ptr M01_L33
M01_L39:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       call      qword ptr [7FF983746430]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       r11,7FF982D10D68
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L65
       mov       rcx,1EB4F808DC8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M01_L66
M01_L40:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        near ptr M01_L124
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       rdi,[r14+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF982E54348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L126
       lea       r8,[rsp+180]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FF98374C2B8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rsp+178],rax
M01_L41:
       mov       edx,[rsp+180]
       test      edx,edx
       je        near ptr M01_L127
       movsxd    rbp,edx
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       r13,[rsp+178]
       mov       edi,[rsp+180]
       lea       r12,[r15+10]
       mov       eax,[r15+8]
       mov       [rsp+138],eax
       mov       rdx,[r14+20]
       cmp       rdx,rsi
       mov       [rsp+70],rdx
       jne       short M01_L43
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF982FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rax],rcx
       jne       near ptr M01_L67
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF982FE42A8]; System.Globalization.CultureInfo.get_CompareInfo()
M01_L42:
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],ecx
       mov       [rsp+70],rsi
M01_L43:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[r14+18]
       movzx     eax,byte ptr [r14+28]
       mov       [rsp+174],eax
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,[rsp+70]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsp+174]
       mov       [rsi+28],dl
       xor       edx,edx
       mov       [rsi+18],rdx
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L128
M01_L44:
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rdx
       jne       near ptr M01_L132
       mov       rdx,rsi
       mov       r14,[rdx+8]
       mov       rdx,1EB4F805EB8
       cmp       r14,[rdx]
       je        near ptr M01_L130
       mov       rdx,rbp
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+68],rax
       xor       r10d,r10d
       cmp       dword ptr [rax+8],0
       jle       short M01_L47
M01_L45:
       cmp       r10d,[r13+8]
       jae       near ptr M01_L135
       mov       edx,r10d
       shl       rdx,4
       lea       rdx,[r13+rdx+10]
       mov       r8,[rdx]
       mov       r9,[rdx+8]
       mov       rdx,7FF983740D80
       cmp       [r14+18],rdx
       jne       near ptr M01_L129
       mov       edx,[r14+8]
M01_L46:
       mov       [rsp+170],r10d
       movsxd    rdx,r10d
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       r10d,[rsp+170]
       inc       r10d
       mov       rax,[rsp+68]
       cmp       [rax+8],r10d
       jg        short M01_L45
M01_L47:
       lea       rcx,[rsi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L48:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L49
       mov       rdx,r13
       mov       r8d,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M01_L49:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       ecx,ecx
       cmp       dword ptr [r14+8],0
       jle       short M01_L51
M01_L50:
       mov       eax,ecx
       mov       [r14+rax*4+10],ecx
       inc       ecx
       cmp       [r14+8],ecx
       jg        short M01_L50
M01_L51:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L134
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rsi
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rsp+168],rax
       test      rsi,rsi
       je        near ptr M01_L133
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rsp+168]
       mov       [rbp+18],rsi
       mov       rdx,rbp
       cmp       [r14+8],edi
       jb        near ptr M01_L95
       lea       rcx,[r14+10]
       cmp       edi,1
       jle       short M01_L52
       mov       [rsp+108],rcx
       mov       [rsp+110],edi
       lea       rcx,[rsp+108]
       call      qword ptr [7FF98310DE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L52:
       xor       ebp,ebp
       mov       esi,[rsp+138]
       test      esi,esi
       jle       short M01_L54
       cmp       [r14+8],esi
       jl        near ptr M01_L68
M01_L53:
       cmp       ebp,esi
       jae       near ptr M01_L135
       mov       edi,ebp
       shl       rdi,4
       add       rdi,r12
       mov       eax,ebp
       mov       eax,[r14+rax*4+10]
       cmp       eax,[r13+8]
       jae       near ptr M01_L135
       shl       rax,4
       lea       rsi,[r13+rax+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       inc       ebp
       mov       esi,[rsp+138]
       cmp       ebp,esi
       jl        short M01_L53
M01_L54:
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L65
M01_L55:
       mov       ecx,edi
       shl       rcx,4
       lea       rcx,[r15+rcx+10]
       mov       rbp,[rcx]
       mov       r14,[rcx+8]
       xor       ecx,ecx
       mov       [rsp+1E0],rcx
       mov       rcx,1EB4F805CE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9831675C0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+1E8],rax
       test      rax,rax
       je        near ptr M01_L69
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L56:
       mov       [rsp+1F8],r10
       mov       [rsp+200],eax
       xor       r8d,r8d
       mov       [rsp+1F0],r8d
       mov       byte ptr [rsp+1F4],0
       cmp       byte ptr [rsp+1F4],0
       jne       near ptr M01_L70
       mov       r8d,[rsp+1F0]
       cmp       r8d,[rsp+200]
       ja        near ptr M01_L95
       mov       rcx,[rsp+1F8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+200]
       sub       edx,r8d
       cmp       edx,7
       jb        near ptr M01_L70
       mov       r8,22BE1624874
       mov       rax,[r8]
       mov       rdx,[r8+6]
       mov       [rcx],rax
       mov       [rcx+6],rdx
       mov       r8d,[rsp+1F0]
       add       r8d,7
       mov       [rsp+1F0],r8d
M01_L57:
       mov       r8d,[rsp+1F0]
       cmp       r8d,[rsp+200]
       ja        near ptr M01_L95
       mov       rcx,[rsp+1F8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+200]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M01_L71
       mov       r8,22BE1610A4C
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+1F0]
       inc       r8d
       mov       [rsp+1F0],r8d
       cmp       byte ptr [rsp+1F4],0
       jne       near ptr M01_L72
M01_L58:
       test      rbp,rbp
       je        near ptr M01_L72
       mov       r8d,[rsp+1F0]
       cmp       r8d,[rsp+200]
       ja        near ptr M01_L95
       mov       rcx,[rsp+1F8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+200]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M01_L72
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       add       r8,r8
       call      qword ptr [7FF982F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,[rsp+1F0]
       add       r8d,[rbp+8]
       mov       [rsp+1F0],r8d
M01_L59:
       mov       r8d,[rsp+1F0]
       cmp       r8d,[rsp+200]
       ja        near ptr M01_L95
       mov       rcx,[rsp+1F8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+200]
       sub       edx,r8d
       cmp       edx,3
       jb        near ptr M01_L73
       mov       r8,22BE162489C
       mov       eax,[r8]
       mov       edx,[r8+2]
       mov       [rcx],eax
       mov       [rcx+2],edx
       mov       r8d,[rsp+1F0]
       add       r8d,3
       mov       [rsp+1F0],r8d
       cmp       byte ptr [rsp+1F4],0
       jne       near ptr M01_L74
M01_L60:
       test      r14,r14
       je        near ptr M01_L74
       mov       r8d,[rsp+1F0]
       cmp       r8d,[rsp+200]
       ja        near ptr M01_L95
       mov       rcx,[rsp+1F8]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+200]
       sub       edx,r8d
       cmp       [r14+8],edx
       ja        near ptr M01_L74
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FF982F05B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+1F0]
       add       ecx,[r14+8]
       mov       [rsp+1F0],ecx
M01_L61:
       mov       ecx,[rsp+1F0]
       cmp       ecx,[rsp+200]
       ja        near ptr M01_L95
       mov       rax,[rsp+1F8]
       mov       [rsp+0F8],rax
       mov       [rsp+100],ecx
       lea       rcx,[rsp+0F8]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       r14,rax
       mov       rbp,[rsp+1E8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+1E0],ymm0
       vmovdqu   xmmword ptr [rsp+1F8],xmm0
       test      rbp,rbp
       je        near ptr M01_L64
       mov       rcx,1EB4F805CE8
       mov       rsi,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FF982D95120
       mov       edx,22
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       je        near ptr M01_L75
M01_L62:
       xor       r13d,r13d
       mov       dword ptr [rsp+164],1
       cmp       [rcx+8],r12d
       jbe       short M01_L63
       mov       r13d,1
       mov       edx,10
       shlx      edx,edx,r12d
       cmp       [rbp+8],edx
       jne       near ptr M01_L96
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L135
       mov       edx,r12d
       shl       rdx,4
       lea       r8,[rcx+rdx+10]
       mov       [rsp+50],r8
       mov       r10,[r8]
       mov       [rsp+48],r10
       mov       rcx,r8
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+50]
       mov       [rdx+8],ecx
       mov       rax,[rsp+48]
       test      rax,rax
       mov       [rsp+48],rax
       jne       near ptr M01_L76
M01_L63:
       mov       rcx,1EB4F8005D0
       mov       r10,[rcx]
       cmp       byte ptr [r10+9D],0
       jne       near ptr M01_L90
M01_L64:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,22BE16248B0
       call      qword ptr [7FF983744F60]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       inc       edi
       cmp       [r15+8],edi
       jg        near ptr M01_L55
M01_L65:
       add       rsp,208
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L66:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1EB4F808DC0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983740D80
       mov       [rdi+18],rcx
       mov       rcx,1EB4F808DC8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L67:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L42
M01_L68:
       cmp       ebp,esi
       jae       near ptr M01_L135
       mov       edi,ebp
       shl       rdi,4
       add       rdi,r12
       cmp       ebp,[r14+8]
       jae       near ptr M01_L135
       mov       eax,ebp
       mov       eax,[r14+rax*4+10]
       cmp       eax,[r13+8]
       jae       near ptr M01_L135
       shl       rax,4
       lea       rsi,[r13+rax+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       inc       ebp
       mov       esi,[rsp+138]
       cmp       ebp,esi
       jl        short M01_L68
       jmp       near ptr M01_L54
M01_L69:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L56
M01_L70:
       lea       rcx,[rsp+1E0]
       mov       rdx,22BE1624868
       call      qword ptr [7FF982FC5848]
       jmp       near ptr M01_L57
M01_L71:
       lea       rcx,[rsp+1E0]
       mov       rdx,22BE1610A40
       call      qword ptr [7FF982FC58F0]
       cmp       byte ptr [rsp+1F4],0
       je        near ptr M01_L58
M01_L72:
       lea       rcx,[rsp+1E0]
       mov       rdx,rbp
       call      qword ptr [7FF982FC5848]
       jmp       near ptr M01_L59
M01_L73:
       lea       rcx,[rsp+1E0]
       mov       rdx,22BE1624890
       call      qword ptr [7FF982FC58F0]
       cmp       byte ptr [rsp+1F4],0
       je        near ptr M01_L60
M01_L74:
       lea       rcx,[rsp+1E0]
       mov       rdx,r14
       call      qword ptr [7FF982FC5848]
       jmp       near ptr M01_L61
M01_L75:
       mov       rcx,rsi
       call      qword ptr [7FF98315E910]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
       jmp       near ptr M01_L62
M01_L76:
       mov       rcx,[rsi+10]
       cmp       r12d,[rcx+8]
       jae       near ptr M01_L135
       mov       edx,r12d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M01_L77
       mov       rcx,rsi
       mov       edx,r12d
       call      qword ptr [7FF98315E898]
       mov       r8,rax
M01_L77:
       mov       r8,[r8+8]
       mov       [rsp+40],r8
       mov       rcx,7FF982D95120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF982D95C38],0
       je        short M01_L78
       call      qword ptr [7FF982E5DC98]
       mov       edx,eax
       mov       [rsp+14C],edx
       jmp       short M01_L81
M01_L78:
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       eax,[rax+0A3C]
       mov       [rsp+148],eax
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       ecx,[rsp+148]
       lea       edx,[rcx-1]
       mov       [rax+0A3C],edx
       movzx     eax,cx
       test      eax,eax
       jne       short M01_L79
       call      qword ptr [7FF98378C8B8]
       mov       edx,eax
       jmp       short M01_L80
M01_L79:
       mov       edx,ecx
       sar       edx,10
M01_L80:
       mov       [rsp+14C],edx
M01_L81:
       mov       rcx,7FF982D95120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,[rsp+14C]
       xor       edx,edx
       div       dword ptr [7FF982D95C2C]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M01_L88
M01_L82:
       cmp       eax,[r8+8]
       jae       near ptr M01_L135
       mov       [rsp+154],eax
       mov       ecx,eax
       mov       r10,[r8+rcx*8+10]
       mov       [rsp+38],r10
       cmp       [r10],r10b
       xor       r9d,r9d
       mov       [rsp+144],r9d
       mov       rcx,r10
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rsp+140],r10d
       cmp       [rcx+8],r10d
       jbe       short M01_L84
       test      r10d,r10d
       jne       short M01_L85
       xor       edx,edx
       mov       [rax+14],edx
M01_L83:
       movsxd    rdx,r10d
       mov       r8,[rsp+48]
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rsp+140]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+144],1
M01_L84:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rsp+144]
       test      ecx,ecx
       je        short M01_L86
       mov       eax,1
       jmp       short M01_L89
M01_L85:
       jmp       short M01_L83
M01_L86:
       mov       eax,[rsp+154]
       inc       eax
       mov       ecx,eax
       mov       r8,[rsp+40]
       cmp       [r8+8],ecx
       jne       short M01_L87
       xor       ecx,ecx
M01_L87:
       mov       edx,[rsp+150]
       inc       edx
       mov       eax,ecx
M01_L88:
       mov       r8,[rsp+40]
       mov       [rsp+150],edx
       cmp       [r8+8],edx
       jg        near ptr M01_L82
       xor       eax,eax
M01_L89:
       mov       [rsp+164],eax
       jmp       near ptr M01_L63
M01_L90:
       mov       rdx,r10
       mov       eax,[rsp+164]
       cmp       dword ptr [rbp+8],0
       mov       [rsp+60],rdx
       mov       [rsp+164],eax
       je        near ptr M01_L64
       cmp       [rbp],bpl
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+160],eax
       mov       edx,[rbp+8]
       mov       [rsp+15C],edx
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,[rsp+60]
       mov       r8d,[rsp+160]
       mov       r9d,[rsp+15C]
       mov       edx,3
       call      qword ptr [7FF982F07678]
       test      [rsp+164],r13d
       jne       near ptr M01_L64
       cmp       [rbp],bpl
       mov       rcx,rbp
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebp,[rbp+8]
       mov       rdx,[rsp+60]
       mov       [rsp+58],rdx
       mov       [rsp+158],eax
       mov       rcx,rsi
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      r13d,r13d
       jne       short M01_L91
       mov       rsi,[rsp+58]
       mov       r12d,[rsp+158]
       mov       ecx,0FFFFFFFF
       jmp       short M01_L92
M01_L91:
       mov       rsi,[rsp+58]
       mov       ecx,[rsp+158]
       mov       edx,ecx
       mov       ecx,r12d
       mov       r12d,edx
M01_L92:
       mov       edx,r12d
       mov       r8d,ebp
       mov       r9d,eax
       test      r13d,r13d
       jne       short M01_L93
       mov       eax,1
       jmp       short M01_L94
M01_L93:
       xor       eax,eax
M01_L94:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,rsi
       call      qword ptr [7FF98315F360]
       jmp       near ptr M01_L64
M01_L95:
       call      qword ptr [7FF98304E9D0]
       int       3
M01_L96:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9833AEAC0]
       mov       rsi,rax
       mov       ecx,1D3
       mov       rdx,7FF982D04000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF982E5F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L97:
       call      qword ptr [7FF9833744C8]
       mov       ecx,3205
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833742B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L98:
       call      qword ptr [7FF983245E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       xor       r14d,r14d
       test      rbp,rbp
       setne     r14b
       test      r14d,r14d
       jne       near ptr M01_L01
M01_L99:
       call      qword ptr [7FF9833744C8]
       mov       ecx,13E0
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,1446
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF9833742B8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FF983076670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L100:
       mov       r13,[rsp+1D0]
       jmp       near ptr M01_L32
M01_L101:
       mov       ecx,0C
       call      qword ptr [7FF983074F30]
       int       3
M01_L102:
       mov       rcx,rax
       mov       rdx,r13
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rsi,rax
       jmp       near ptr M01_L03
M01_L103:
       cmp       dword ptr [r12+8],0
       je        short M01_L104
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r12
       mov       r8,r13
       call      qword ptr [7FF98324C720]
       jmp       near ptr M01_L03
M01_L104:
       mov       rcx,1EB4F805D18
       mov       rsi,[rcx]
       jmp       near ptr M01_L03
M01_L105:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,r13
       call      qword ptr [7FF98324C498]
       mov       rsi,rdi
       jmp       near ptr M01_L03
M01_L106:
       lea       r8,[rsp+1D8]
       mov       rdx,rdi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, Int32 ByRef)
       call      qword ptr [7FF9837D42E8]
       mov       [rsp+1D0],rax
       jmp       near ptr M01_L05
M01_L107:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       near ptr M01_L06
M01_L108:
       call      qword ptr [7FF982FF4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rsp+0D0],rcx
       jmp       near ptr M01_L07
M01_L109:
       mov       rcx,[rdx+30]
       mov       [rsp+0C8],rdx
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L110
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0B0],rax
       mov       rcx,rax
       mov       rdx,[rsp+0C8]
       call      qword ptr [7FF983246760]
       mov       rax,[rsp+0C8]
       mov       rdx,[rsp+0B0]
       mov       r10,rdx
       jmp       short M01_L111
M01_L110:
       mov       rax,rdx
       mov       [rsp+0C0],rax
       mov       rcx,[rax+40]
       call      qword ptr [7FF982FF4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r10,rax
       mov       rax,[rsp+0C0]
M01_L111:
       lea       rcx,[rax+8]
       mov       [rsp+0B8],r10
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rsp+0B8]
       jmp       near ptr M01_L08
M01_L112:
       mov       rcx,[r12+10]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M01_L11
M01_L113:
       mov       rcx,r10
       mov       rdx,[r10]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rsp+90]
       jmp       near ptr M01_L13
M01_L114:
       mov       rdx,r10
       mov       r9,[rsp+98]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r11,rax
       mov       rax,[rsp+90]
       jmp       near ptr M01_L13
M01_L115:
       mov       rcx,r14
       test      rcx,rcx
       je        short M01_L116
       mov       rdx,offset MT_System.String[]
       cmp       [rcx],rdx
       je        short M01_L116
       mov       rcx,rdx
       mov       rdx,r14
       call      qword ptr [7FF982E54390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,[rsp+0A8]
M01_L116:
       lea       rcx,[r12+20]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L117:
       mov       rcx,r12
       mov       rdx,r14
       mov       r8d,edi
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L27
M01_L118:
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r14,rax
       jmp       near ptr M01_L21
M01_L119:
       mov       rcx,rax
       mov       r11,7FF982D10D38
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L22
       mov       rcx,rdi
       mov       rdx,[rdi]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdi,rax
       mov       rcx,[rsp+0F0]
       mov       edx,2C
       call      qword ptr [7FF9836147F8]
       mov       [rsp+128],rdi
       mov       [rsp+130],rax
       lea       r8,[rsp+128]
       mov       rdx,r15
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF9837459C8]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M01_L38
M01_L120:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M01_L24
M01_L121:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833AC840]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF982E5F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L122:
       call      qword ptr [7FF9833742E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L123
       call      qword ptr [7FF9833744F8]
       mov       rbx,rax
M01_L123:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,135C
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF982E5F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L124:
       mov       ecx,9
       call      qword ptr [7FF983074F30]
       int       3
M01_L125:
       mov       ecx,10
       call      qword ptr [7FF983074F30]
       int       3
M01_L126:
       mov       rcx,rax
       mov       r11,7FF982D10D78
       call      qword ptr [r11]
       mov       [rsp+178],rax
       mov       ecx,[rax+8]
       mov       [rsp+180],ecx
       jmp       near ptr M01_L41
M01_L127:
       mov       r15,[rsp+178]
       jmp       near ptr M01_L54
M01_L128:
       mov       rcx,[r14+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rsi,rax
       jmp       near ptr M01_L44
M01_L129:
       mov       [rsp+170],r10d
       mov       [rsp+118],r8
       mov       [rsp+120],r9
       lea       rdx,[rsp+118]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r8,rax
       mov       rax,[rsp+68]
       mov       r10d,[rsp+170]
       jmp       near ptr M01_L46
M01_L130:
       test      r13,r13
       je        short M01_L131
       mov       rcx,offset MT_System.String[]
       cmp       [r13],rcx
       je        short M01_L131
       mov       rdx,r13
       call      qword ptr [7FF982E54390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L131:
       lea       rcx,[rsi+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L48
M01_L132:
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,edi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L49
M01_L133:
       call      qword ptr [7FF982E541F8]
       int       3
M01_L134:
       lea       r9d,[rdi-1]
       mov       rcx,rsi
       mov       rdx,r14
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L52
M01_L135:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6942
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Logging.LoggingHelperBenchmark.LogComputerInformation()
       mov       rcx,[rcx+128]
       jmp       qword ptr [7FF983734930]; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.Core.Logging.LoggingHelper.LogComputerInformation(Microsoft.Extensions.Logging.ILogger)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,218
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+210],xmm4
       vmovdqa   xmmword ptr [rsp+rax+220],xmm4
       vmovdqa   xmmword ptr [rsp+rax+230],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rsp+210],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L83
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ComputerInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF983734D50]; DotNetTips.Spargine.Core.ComputerInfo..ctor()
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF982E4EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       rcx,rbp
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.Extensions+<GetAllProperties>d__14
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+34],eax
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2040700B980
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L23
M01_L01:
       test      r15,r15
       je        near ptr M01_L85
       mov       rdx,rdi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L86
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      qword ptr [7FF982E44330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L27
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L87
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L02:
       mov       rcx,2040700B988
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L22
M01_L03:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       test      r13,r13
       je        near ptr M01_L115
       test      rsi,rsi
       je        near ptr M01_L114
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rdi+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20407005CD8
       mov       r13,[rcx]
       lea       rcx,[rdi+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rdi+28],0
       mov       rsi,[rdi+8]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L89
       mov       rcx,rax
       mov       r11,7FF982D00FD0
       call      qword ptr [r11]
       mov       [rsp+1E0],rax
       mov       edx,[rax+8]
       mov       [rsp+1E8],edx
M01_L04:
       mov       edx,[rsp+1E8]
       test      edx,edx
       je        near ptr M01_L84
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r12,rax
       mov       r15,[rsp+1E0]
       mov       esi,[rsp+1E8]
       lea       rax,[r12+10]
       mov       edx,[r12+8]
       mov       [rsp+30],rax
       mov       [rsp+134],edx
       mov       r8,[rdi+20]
       cmp       r8,r13
       mov       [rsp+0E0],r8
       jne       near ptr M01_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L90
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L90
       mov       r10,[rcx]
       add       r10,10
M01_L05:
       mov       r9,[r10+8]
       test      r9,r9
       mov       [rsp+0C8],r9
       jne       short M01_L06
       mov       r9,20407000438
       mov       r9,[r9]
       test      r9,r9
       mov       [rsp+0C8],r9
       jne       short M01_L06
       mov       r9,20407000418
       mov       r9,[r9]
       mov       [rsp+0C8],r9
       test      r9,r9
       je        near ptr M01_L91
M01_L06:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0D0],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       mov       rax,[rsp+0C8]
       cmp       [rax],rcx
       jne       near ptr M01_L39
       mov       rdx,rax
       mov       r10,[rdx+8]
       test      r10,r10
       je        near ptr M01_L92
M01_L07:
       mov       rdx,r10
M01_L08:
       mov       r8,[rsp+0D0]
       lea       rcx,[r8+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       r8,[rsp+0D0]
       mov       [r8+10],ecx
       mov       [rsp+0E0],r8
M01_L09:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0D8],rax
       mov       rdx,[rdi+18]
       movzx     r8d,byte ptr [rdi+28]
       mov       [rsp+1DC],r8d
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0D8]
       lea       rcx,[rax+10]
       mov       rdx,[rsp+0E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+0D8]
       mov       edx,[rsp+1DC]
       mov       [rax+28],dl
       xor       edx,edx
       mov       [rax+18],rdx
       cmp       qword ptr [rdi+10],0
       jne       near ptr M01_L95
M01_L10:
       mov       rdi,rax
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rdx
       jne       near ptr M01_L102
       mov       rdx,rdi
       mov       r8,[rdx+8]
       mov       [rsp+98],r8
       mov       rdx,20407005EE8
       cmp       r8,[rdx]
       je        near ptr M01_L100
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+90],rax
       xor       edx,edx
       cmp       dword ptr [rax+8],0
       mov       rax,[rsp+90]
       jle       near ptr M01_L13
M01_L11:
       cmp       edx,[r15+8]
       jae       near ptr M01_L130
       mov       [rsp+1D8],edx
       mov       ecx,edx
       mov       rcx,[r15+rcx*8+10]
       mov       r8,rcx
       mov       rcx,7FF9837E8AF8
       mov       r10,[rsp+98]
       cmp       [r10+18],rcx
       jne       near ptr M01_L99
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r8],rcx
       jne       near ptr M01_L98
       mov       r9,r8
       mov       [rsp+88],r9
       mov       r8,[r9+8]
       test      r8,r8
       je        short M01_L14
M01_L12:
       movsxd    rdx,dword ptr [rsp+1D8]
       mov       rcx,rax
       call      CORINFO_HELP_ARRADDR_ST
       mov       edx,[rsp+1D8]
       inc       edx
       mov       rax,[rsp+90]
       cmp       [rax+8],edx
       jg        near ptr M01_L11
M01_L13:
       lea       rcx,[rdi+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L14:
       mov       r8,[r9+48]
       mov       [rsp+1D0],r8
       test      r8,r8
       je        near ptr M01_L96
       mov       rcx,r8
       call      qword ptr [7FF982EF5050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M01_L15:
       mov       r8,204070009F0
       mov       r10,[r8]
       mov       [rsp+80],r10
       mov       r8,[rsp+1D0]
       test      eax,eax
       jl        near ptr M01_L82
       test      eax,eax
       je        near ptr M01_L21
       mov       r10,r8
M01_L16:
       mov       [rsp+1C8],r10
       mov       rdx,r10
       mov       [rsp+1C0],rdx
       mov       [rsp+1BC],eax
       test      rdx,rdx
       je        near ptr M01_L110
       lea       r8,[rsp+1A0]
       lea       r9,[rsp+198]
       mov       rcx,rdx
       mov       edx,[rsp+1BC]
       call      qword ptr [7FF983037F48]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       sub       rax,[rsp+1C0]
       mov       r9d,eax
       mov       eax,r9d
       add       eax,[rsp+1A0]
       mov       r8d,[rsp+1BC]
       cmp       r9d,r8d
       jne       near ptr M01_L97
M01_L17:
       mov       [rsp+1B8],eax
       test      eax,eax
       je        near ptr M01_L20
       mov       ecx,eax
       call      System.String.FastAllocateString(Int32)
       mov       r8,rax
       mov       [rsp+70],r8
       cmp       [r8],r8b
       lea       rcx,[r8+0C]
       mov       [rsp+1B0],rcx
       mov       rcx,[rsp+80]
       mov       rdx,[rsp+1C0]
       mov       r9d,[rsp+1BC]
       mov       rax,[rsp+1B0]
       mov       r10d,[rsp+1B8]
       mov       [rsp+20],r10d
       mov       r8d,r9d
       mov       r9,rax
       call      qword ptr [7FF9830216E0]; System.Text.UTF8Encoding.GetChars(Byte*, Int32, Char*, Int32)
       xor       ecx,ecx
       mov       [rsp+1B0],rcx
       mov       r8,[rsp+70]
M01_L18:
       xor       ecx,ecx
       mov       [rsp+1B0],rcx
       mov       [rsp+1C8],rcx
       mov       rax,[rsp+88]
       lea       rcx,[rax+8]
       mov       [rsp+78],r8
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+78]
       mov       rax,[rsp+90]
       jmp       near ptr M01_L12
M01_L19:
       test      rcx,rcx
       je        near ptr M01_L109
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbp
       mov       r8d,3C
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FF98307E9E8]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
       mov       r15,rax
       jmp       near ptr M01_L45
M01_L20:
       mov       r10,24498D80008
       mov       r8,r10
       jmp       short M01_L18
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M01_L21:
       mov       r10d,1
       jmp       near ptr M01_L16
M01_L22:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2040700B978
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9837E8AF8
       mov       [rsi+18],rcx
       mov       rcx,2040700B988
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L03
M01_L23:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2040700B978
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9837E8AE0
       mov       [r15+18],rcx
       mov       rcx,2040700B980
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L01
M01_L24:
       cmp       edi,eax
       jae       near ptr M01_L130
       mov       ecx,edi
       mov       r8,[rsp+30]
       lea       rcx,[r8+rcx*8]
       cmp       edi,[rsi+8]
       jae       near ptr M01_L130
       mov       edx,edi
       mov       r10d,[rsi+rdx*4+10]
       cmp       r10d,[r15+8]
       jae       near ptr M01_L130
       mov       edx,r10d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       eax,[rsp+134]
       cmp       edi,eax
       jl        short M01_L24
M01_L25:
       xor       esi,esi
       cmp       dword ptr [r12+8],0
       jle       near ptr M01_L65
M01_L26:
       mov       ecx,esi
       mov       rdi,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L104
       mov       rcx,rdi
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L103
       jmp       near ptr M01_L19
M01_L27:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF982E44360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M01_L88
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r13+10],eax
       lea       rcx,[r13+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L28:
       cmp       r13d,edi
       jae       near ptr M01_L130
       mov       eax,r13d
       shl       rax,4
       lea       rdi,[rax+rbp]
       cmp       r13d,[r14+8]
       jae       near ptr M01_L130
       mov       eax,r13d
       mov       eax,[r14+rax*4+10]
       cmp       eax,[r12+8]
       jae       near ptr M01_L130
       shl       rax,4
       lea       rsi,[r12+rax+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       inc       r13d
       mov       edi,[rsp+130]
       cmp       r13d,edi
       jl        short M01_L28
M01_L29:
       xor       esi,esi
       cmp       dword ptr [r15+8],0
       jle       near ptr M01_L38
M01_L30:
       mov       ecx,esi
       shl       rcx,4
       lea       rcx,[r15+rcx+10]
       mov       r14,[rcx]
       mov       r13,[rcx+8]
       xor       ecx,ecx
       mov       [rsp+1F0],rcx
       mov       rcx,20407005CE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9831575C0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+1F8],rax
       test      rax,rax
       je        near ptr M01_L127
       lea       r8,[rax+10]
       mov       eax,[rax+8]
M01_L31:
       mov       [rsp+208],r8
       mov       [rsp+210],eax
       xor       ecx,ecx
       mov       [rsp+200],ecx
       mov       byte ptr [rsp+204],0
       cmp       byte ptr [rsp+204],0
       jne       near ptr M01_L79
       mov       ecx,[rsp+200]
       cmp       ecx,[rsp+210]
       ja        near ptr M01_L82
       mov       rdx,[rsp+208]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+210]
       sub       eax,ecx
       cmp       eax,0C
       jb        near ptr M01_L79
       mov       rcx,24498D94874
       vmovdqu   xmm0,xmmword ptr [rcx]
       vmovdqu   xmm1,xmmword ptr [rcx+8]
       vmovdqu   xmmword ptr [rdx],xmm0
       vmovdqu   xmmword ptr [rdx+8],xmm1
       mov       ecx,[rsp+200]
       add       ecx,0C
       mov       [rsp+200],ecx
M01_L32:
       mov       r8d,[rsp+200]
       cmp       r8d,[rsp+210]
       ja        near ptr M01_L82
       mov       rcx,[rsp+208]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+210]
       sub       edx,r8d
       cmp       edx,1
       jb        near ptr M01_L128
       mov       r8,24498D80A4C
       movzx     edx,word ptr [r8]
       mov       [rcx],dx
       mov       r8d,[rsp+200]
       inc       r8d
       mov       [rsp+200],r8d
M01_L33:
       cmp       byte ptr [rsp+204],0
       jne       near ptr M01_L80
       test      r14,r14
       je        near ptr M01_L80
       mov       r8d,[rsp+200]
       cmp       r8d,[rsp+210]
       ja        near ptr M01_L82
       mov       rcx,[rsp+208]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+210]
       sub       edx,r8d
       cmp       [r14+8],edx
       ja        near ptr M01_L80
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       add       r8,r8
       call      qword ptr [7FF982EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+200]
       add       ecx,[r14+8]
       mov       [rsp+200],ecx
M01_L34:
       mov       r8d,[rsp+200]
       cmp       r8d,[rsp+210]
       ja        near ptr M01_L82
       mov       rcx,[rsp+208]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+210]
       sub       edx,r8d
       cmp       edx,3
       jb        near ptr M01_L129
       mov       r8,24498D948A4
       mov       eax,[r8]
       mov       edx,[r8+2]
       mov       [rcx],eax
       mov       [rcx+2],edx
       mov       r8d,[rsp+200]
       add       r8d,3
       mov       [rsp+200],r8d
M01_L35:
       cmp       byte ptr [rsp+204],0
       jne       near ptr M01_L81
       test      r13,r13
       je        near ptr M01_L81
       mov       r8d,[rsp+200]
       cmp       r8d,[rsp+210]
       ja        near ptr M01_L82
       mov       rcx,[rsp+208]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+210]
       sub       edx,r8d
       cmp       [r13+8],edx
       ja        near ptr M01_L81
       lea       rdx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8,r8
       call      qword ptr [7FF982EF5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+200]
       add       ecx,[r13+8]
       mov       [rsp+200],ecx
       mov       r12d,[rsp+200]
       cmp       r12d,[rsp+210]
       ja        near ptr M01_L82
M01_L36:
       mov       rcx,[rsp+208]
       mov       [rsp+0F0],rcx
       mov       [rsp+0F8],r12d
       lea       rcx,[rsp+0F0]
       call      System.String..ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rsp+1F8]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+1F0],ymm0
       vmovdqu   xmmword ptr [rsp+208],xmm0
       test      rdx,rdx
       je        short M01_L37
       mov       rcx,20407005CE8
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9831575C8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L37:
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8,24498D948B8
       call      qword ptr [7FF9837357D0]; DotNetTips.Spargine.Core.Logging.FastLoggerExtensions.LogInformationMessage(Microsoft.Extensions.Logging.ILogger, System.String, System.String)
       inc       esi
       cmp       [r15+8],esi
       jg        near ptr M01_L30
M01_L38:
       add       rsp,218
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L08
M01_L40:
       mov       rcx,[rdi+18]
       test      rcx,rcx
       je        short M01_L41
       mov       rdx,r15
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M01_L41:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rsp+0A0],rax
       xor       r9d,r9d
       cmp       dword ptr [rax+8],0
       jle       short M01_L43
M01_L42:
       mov       ecx,r9d
       mov       [rax+rcx*4+10],r9d
       inc       r9d
       cmp       [rax+8],r9d
       jg        short M01_L42
M01_L43:
       lea       r9d,[rsi-1]
       mov       rcx,rdi
       mov       rdx,rax
       xor       r8d,r8d
       mov       r10,[rdi]
       mov       r10,[r10+40]
       call      qword ptr [r10+30]
       mov       rsi,[rsp+0A0]
       xor       edi,edi
       mov       eax,[rsp+134]
       test      eax,eax
       jle       near ptr M01_L25
       cmp       [rsi+8],eax
       jl        near ptr M01_L24
       nop       dword ptr [rax+rax]
M01_L44:
       cmp       edi,eax
       jae       near ptr M01_L130
       mov       ecx,edi
       mov       r8,[rsp+30]
       lea       rcx,[r8+rcx*8]
       mov       edx,edi
       mov       r10d,[rsi+rdx*4+10]
       cmp       r10d,[r15+8]
       jae       near ptr M01_L130
       mov       edx,r10d
       mov       rdx,[r15+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       edi
       mov       eax,[rsp+134]
       cmp       edi,eax
       jl        short M01_L44
       jmp       near ptr M01_L25
M01_L45:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.IDictionary
       call      qword ptr [7FF982E44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       [rsp+0E8],rax
       test      rax,rax
       jne       near ptr M01_L105
M01_L46:
       test      r15,r15
       je        near ptr M01_L56
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L108
       mov       rax,[rdi+8]
       test      rax,rax
       je        short M01_L49
M01_L47:
       mov       rdi,rax
M01_L48:
       mov       rcx,offset MT_System.String
       cmp       [r15],rcx
       jne       near ptr M01_L54
       cmp       [r15],r15b
       jmp       near ptr M01_L55
M01_L49:
       mov       rax,[rdi+48]
       mov       [rsp+190],rax
       test      rax,rax
       je        near ptr M01_L106
       mov       rcx,rax
       call      qword ptr [7FF982EF5050]; System.SpanHelpers.IndexOfNullByte(Byte*)
M01_L50:
       mov       r8,204070009F0
       mov       r10,[r8]
       mov       [rsp+68],r10
       mov       r8,[rsp+190]
       test      eax,eax
       jl        near ptr M01_L82
       test      eax,eax
       je        near ptr M01_L59
       mov       r10,r8
M01_L51:
       mov       [rsp+188],r10
       mov       rdx,r10
       mov       [rsp+17C],eax
       test      rdx,rdx
       je        near ptr M01_L110
       lea       r8,[rsp+160]
       lea       r9,[rsp+158]
       mov       [rsp+180],rdx
       mov       rcx,rdx
       mov       edx,[rsp+17C]
       call      qword ptr [7FF983037F48]; System.Text.Unicode.Utf8Utility.GetPointerToFirstInvalidByte(Byte*, Int32, Int32 ByRef, Int32 ByRef)
       sub       rax,[rsp+180]
       mov       r9d,eax
       mov       eax,r9d
       add       eax,[rsp+160]
       mov       r8d,[rsp+17C]
       cmp       r9d,r8d
       jne       near ptr M01_L107
M01_L52:
       mov       [rsp+178],eax
       test      eax,eax
       je        near ptr M01_L57
       mov       ecx,eax
       call      System.String.FastAllocateString(Int32)
       mov       [rsp+58],rax
       cmp       [rax],al
       lea       rcx,[rax+0C]
       mov       [rsp+170],rcx
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+180]
       mov       r8d,[rsp+17C]
       mov       r9,[rsp+170]
       mov       r10d,[rsp+178]
       mov       [rsp+20],r10d
       call      qword ptr [7FF9830216E0]; System.Text.UTF8Encoding.GetChars(Byte*, Int32, Char*, Int32)
       xor       ecx,ecx
       mov       [rsp+170],rcx
       mov       rax,[rsp+58]
M01_L53:
       xor       ecx,ecx
       mov       [rsp+170],rcx
       mov       [rsp+188],rcx
       lea       rcx,[rdi+8]
       mov       [rsp+60],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rsp+60]
       mov       rax,rdi
       jmp       near ptr M01_L47
M01_L54:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r15,rax
M01_L55:
       mov       rcx,r14
       mov       r11,7FF982D00FE0
       call      qword ptr [r11]
       xor       ecx,ecx
       test      eax,eax
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L112
       mov       [rsp+110],rdi
       mov       [rsp+118],r15
       mov       rcx,r14
       lea       rdx,[rsp+110]
       mov       r11,7FF982D00FE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L56
       mov       [rsp+110],rdi
       mov       [rsp+118],r15
       mov       rcx,r14
       lea       rdx,[rsp+110]
       mov       r11,7FF982D00FD8
       call      qword ptr [r11]
M01_L56:
       inc       esi
       cmp       [r12+8],esi
       jg        near ptr M01_L26
       jmp       near ptr M01_L65
M01_L57:
       mov       r10,24498D80008
       mov       rax,r10
       jmp       near ptr M01_L53
M01_L58:
       mov       r14,r12
       mov       rdx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [r13],rdx
       jne       near ptr M01_L124
       jmp       short M01_L60
M01_L59:
       mov       r10d,1
       jmp       near ptr M01_L51
M01_L60:
       mov       rdx,r13
       mov       rax,[rdx+8]
       mov       [rsp+40],rax
       mov       rdx,20407005F28
       cmp       rax,[rdx]
       je        near ptr M01_L122
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       xor       eax,eax
       cmp       dword ptr [r14+8],0
       jle       short M01_L63
M01_L61:
       cmp       eax,[r12+8]
       jae       near ptr M01_L130
       mov       edx,eax
       shl       rdx,4
       lea       rdx,[r12+rdx+10]
       mov       r8,[rdx]
       mov       r10,[rdx+8]
       mov       rdx,7FF983731608
       mov       r9,[rsp+40]
       cmp       [r9+18],rdx
       jne       near ptr M01_L121
       mov       edx,[r9+8]
M01_L62:
       mov       [rsp+140],eax
       movsxd    rdx,eax
       mov       rcx,r14
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rsp+140]
       inc       eax
       cmp       [r14+8],eax
       jg        short M01_L61
M01_L63:
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L64:
       mov       rcx,[r13+18]
       test      rcx,rcx
       je        near ptr M01_L73
       mov       rdx,r12
       mov       r8d,esi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L73
M01_L65:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF9837BDBD8]; System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r11,7FF982D00FF0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L38
       mov       rcx,20407008DD0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L72
M01_L66:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L114
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+28],0
       mov       rsi,[r14+8]
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF982E44348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L116
       lea       r8,[rsp+150]
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, Int32 ByRef)
       call      qword ptr [7FF9838154B8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Int32 ByRef)
       mov       [rsp+148],rax
M01_L67:
       mov       edx,[rsp+150]
       test      edx,edx
       je        near ptr M01_L117
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]][]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r15,rax
       mov       r12,[rsp+148]
       mov       esi,[rsp+150]
       lea       rbp,[r15+10]
       mov       edi,[r15+8]
       mov       [rsp+130],edi
       mov       rax,[r14+20]
       cmp       rax,r13
       mov       [rsp+50],rax
       jne       near ptr M01_L71
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L118
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L118
       mov       rdx,[rcx]
       add       rdx,10
M01_L68:
       mov       r13,[rdx+8]
       test      r13,r13
       jne       short M01_L69
       mov       rcx,20407000438
       mov       r13,[rcx]
       test      r13,r13
       jne       short M01_L69
       mov       rcx,20407000418
       mov       r13,[rcx]
       test      r13,r13
       je        near ptr M01_L119
M01_L69:
       mov       rcx,offset MT_System.CultureAwareComparer
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M01_L78
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF982FD42A8]; System.Globalization.CultureInfo.get_CompareInfo()
M01_L70:
       mov       r13,[rsp+48]
       lea       rcx,[r13+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],ecx
       mov       [rsp+50],r13
M01_L71:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,[r14+18]
       movzx     eax,byte ptr [r14+28]
       mov       [rsp+144],eax
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsp+144]
       mov       [r13+28],dl
       xor       edx,edx
       mov       [r13+18],rdx
       cmp       qword ptr [r14+10],0
       jne       near ptr M01_L120
       jmp       near ptr M01_L58
M01_L72:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,20407008DC0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF983731608
       mov       [rsi+18],rcx
       mov       rcx,20407008DD0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L66
M01_L73:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       ecx,ecx
       cmp       dword ptr [r14+8],0
       jle       short M01_L75
M01_L74:
       mov       eax,ecx
       mov       [r14+rax*4+10],ecx
       inc       ecx
       cmp       [r14+8],ecx
       jg        short M01_L74
M01_L75:
       mov       rcx,offset MT_System.Linq.EnumerableSorter`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [r13],rcx
       jne       near ptr M01_L126
       cmp       [r13],r13b
       mov       rcx,offset MT_System.Comparison`1[[System.Int32, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       mov       rcx,r13
       mov       rdx,offset MT_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       mov       r8,offset MD_System.Linq.EnumerableSorter`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CompareAnyKeys(Int32, Int32)
       call      CORINFO_HELP_VIRTUAL_FUNC_PTR
       mov       [rsp+138],rax
       test      r13,r13
       je        near ptr M01_L125
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsp+38]
       mov       rcx,[rsp+138]
       mov       [r13+18],rcx
       mov       rdx,r13
       cmp       [r14+8],esi
       jb        near ptr M01_L82
       lea       rcx,[r14+10]
       cmp       esi,1
       jle       short M01_L76
       mov       [rsp+100],rcx
       mov       [rsp+108],esi
       lea       rcx,[rsp+100]
       call      qword ptr [7FF9830FDE00]; System.Collections.Generic.ArraySortHelper`1[[System.Int32, System.Private.CoreLib]].Sort(System.Span`1<Int32>, System.Comparison`1<Int32>)
M01_L76:
       xor       r13d,r13d
       test      edi,edi
       jle       near ptr M01_L29
       cmp       [r14+8],edi
       jl        near ptr M01_L28
M01_L77:
       cmp       r13d,edi
       jae       near ptr M01_L130
       mov       eax,r13d
       shl       rax,4
       lea       rdi,[rax+rbp]
       mov       eax,r13d
       mov       eax,[r14+rax*4+10]
       cmp       eax,[r12+8]
       jae       near ptr M01_L130
       shl       rax,4
       lea       rsi,[r12+rax+10]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
       inc       r13d
       mov       esi,[rsp+130]
       cmp       r13d,esi
       mov       edi,esi
       jl        short M01_L77
       jmp       near ptr M01_L29
M01_L78:
       mov       rcx,r13
       mov       rdx,[r13]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       jmp       near ptr M01_L70
M01_L79:
       lea       rcx,[rsp+1F0]
       mov       rdx,24498D94868
       call      qword ptr [7FF982FB5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L32
M01_L80:
       lea       rcx,[rsp+1F0]
       mov       rdx,r14
       call      qword ptr [7FF982FB5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M01_L34
M01_L81:
       lea       rcx,[rsp+1F0]
       mov       rdx,r13
       call      qword ptr [7FF982FB5848]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       mov       r12d,[rsp+200]
       cmp       r12d,[rsp+210]
       jbe       near ptr M01_L36
M01_L82:
       call      qword ptr [7FF98303E9D0]
       int       3
M01_L83:
       call      qword ptr [7FF9833644C8]
       mov       ecx,3205
       mov       rdx,7FF98315BB70
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF98315BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E46B08]; System.String.Concat(System.String, System.String)
       mov       rbp,rax
       mov       ecx,0CCA
       mov       rdx,7FF98315BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF982E46B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9833642B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r15
       call      qword ptr [7FF983066670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L84:
       mov       r12,[rsp+1E0]
       jmp       near ptr M01_L25
M01_L85:
       mov       ecx,0C
       call      qword ptr [7FF983064F30]
       int       3
M01_L86:
       mov       rcx,rax
       mov       rdx,r15
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r13,rax
       jmp       near ptr M01_L02
M01_L87:
       mov       rcx,20407005D18
       mov       r13,[rcx]
       jmp       near ptr M01_L02
M01_L88:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,r12
       mov       r8,r15
       call      qword ptr [7FF98323C498]
       jmp       near ptr M01_L02
M01_L89:
       lea       r8,[rsp+1E8]
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, Int32 ByRef)
       call      qword ptr [7FF98396D6E0]
       mov       [rsp+1E0],rax
       jmp       near ptr M01_L04
M01_L90:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       jmp       near ptr M01_L05
M01_L91:
       call      qword ptr [7FF982FE4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rsp+0C8],rcx
       jmp       near ptr M01_L06
M01_L92:
       mov       rcx,[rdx+30]
       mov       [rsp+0C0],rdx
       cmp       byte ptr [rcx+1B9],0
       jne       short M01_L93
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+0A8],rax
       mov       rcx,rax
       mov       rdx,[rsp+0C0]
       call      qword ptr [7FF983236760]
       mov       rax,[rsp+0C0]
       mov       rdx,[rsp+0A8]
       mov       r10,rdx
       jmp       short M01_L94
M01_L93:
       mov       rax,rdx
       mov       [rsp+0B8],rax
       mov       rcx,[rax+40]
       call      qword ptr [7FF982FE4630]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r10,rax
       mov       rax,[rsp+0B8]
M01_L94:
       lea       rcx,[rax+8]
       mov       [rsp+0B0],r10
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rsp+0B0]
       jmp       near ptr M01_L07
M01_L95:
       mov       rcx,[rdi+10]
       mov       rdx,rax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       jmp       near ptr M01_L10
M01_L96:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M01_L15
M01_L97:
       mov       [rsp+1AC],eax
       mov       rcx,[rsp+80]
       mov       rdx,[rsp+1C0]
       mov       r8d,[rsp+1BC]
       call      qword ptr [7FF982E4C990]
       add       eax,[rsp+1AC]
       js        near ptr M01_L111
       jmp       near ptr M01_L17
M01_L98:
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+30]
       mov       r8,rax
       mov       rax,[rsp+90]
       jmp       near ptr M01_L12
M01_L99:
       mov       rdx,r8
       mov       r10,[rsp+98]
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       mov       r8,rax
       mov       rax,[rsp+90]
       jmp       near ptr M01_L12
M01_L100:
       test      r15,r15
       je        short M01_L101
       mov       rcx,offset MT_System.String[]
       cmp       [r15],rcx
       je        short M01_L101
       mov       rdx,r15
       call      qword ptr [7FF982E44390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L101:
       lea       rcx,[rdi+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L40
M01_L102:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,esi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L41
M01_L103:
       xor       ecx,ecx
       jmp       near ptr M01_L19
M01_L104:
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       mov       rax,[rdi]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L45
M01_L105:
       mov       rcx,rax
       mov       r11,7FF982D00FC0
       call      qword ptr [r11]
       test      eax,eax
       jle       near ptr M01_L46
       mov       rcx,rdi
       mov       rdx,[rdi]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       rdi,rax
       mov       rcx,[rsp+0E8]
       mov       edx,2C
       call      qword ptr [7FF9836047F8]
       mov       [rsp+120],rdi
       mov       [rsp+128],rax
       lea       r8,[rsp+120]
       mov       rdx,r14
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       call      qword ptr [7FF9837ECBA0]; DotNetTips.Spargine.Core.Extensions.AddIfNotExists[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       jmp       near ptr M01_L56
M01_L106:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M01_L50
M01_L107:
       mov       [rsp+16C],eax
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+180]
       mov       r8d,[rsp+17C]
       call      qword ptr [7FF982E4C990]
       add       eax,[rsp+16C]
       js        near ptr M01_L111
       mov       rcx,[rsp+68]
       mov       rdx,[rsp+180]
       mov       r8d,[rsp+17C]
       mov       [rsp+17C],r8d
       mov       [rsp+180],rdx
       mov       [rsp+68],rcx
       jmp       near ptr M01_L52
M01_L108:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M01_L48
M01_L109:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF98339C840]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF982E4F708]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L110:
       mov       ecx,0A
       mov       edx,31
       call      qword ptr [7FF98303ED18]
       int       3
M01_L111:
       call      qword ptr [7FF982E4C7E0]
       int       3
M01_L112:
       call      qword ptr [7FF9833642E8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L113
       call      qword ptr [7FF9833644F8]
       mov       rbx,rax
M01_L113:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentReadOnlyException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,135C
       mov       rdx,7FF98315BB70
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF982E4F750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L114:
       mov       ecx,9
       call      qword ptr [7FF983064F30]
       int       3
M01_L115:
       mov       ecx,10
       call      qword ptr [7FF983064F30]
       int       3
M01_L116:
       mov       rcx,rax
       mov       r11,7FF982D01000
       call      qword ptr [r11]
       mov       [rsp+148],rax
       mov       ecx,[rax+8]
       mov       [rsp+150],ecx
       jmp       near ptr M01_L67
M01_L117:
       mov       r15,[rsp+148]
       jmp       near ptr M01_L29
M01_L118:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rdx,rax
       jmp       near ptr M01_L68
M01_L119:
       call      qword ptr [7FF982FE4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M01_L69
M01_L120:
       mov       rcx,[r14+10]
       mov       rdx,r13
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r13,rax
       jmp       near ptr M01_L58
M01_L121:
       mov       [rsp+140],eax
       mov       [rsp+110],r8
       mov       [rsp+118],r10
       lea       rdx,[rsp+110]
       mov       rcx,[r9+8]
       call      qword ptr [r9+18]
       mov       r8,rax
       mov       eax,[rsp+140]
       jmp       near ptr M01_L62
M01_L122:
       test      r12,r12
       je        short M01_L123
       mov       rcx,offset MT_System.String[]
       cmp       [r12],rcx
       je        short M01_L123
       mov       rdx,r12
       call      qword ptr [7FF982E44390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L123:
       lea       rcx,[r13+20]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L64
M01_L124:
       mov       rcx,r13
       mov       rdx,r12
       mov       r8d,esi
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L73
M01_L125:
       call      qword ptr [7FF982E441F8]
       int       3
M01_L126:
       lea       r9d,[rsi-1]
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L76
M01_L127:
       xor       r8d,r8d
       xor       eax,eax
       jmp       near ptr M01_L31
M01_L128:
       lea       rcx,[rsp+1F0]
       mov       rdx,24498D80A40
       call      qword ptr [7FF982FB58F0]
       jmp       near ptr M01_L33
M01_L129:
       lea       rcx,[rsp+1F0]
       mov       rdx,24498D94898
       call      qword ptr [7FF982FB58F0]
       jmp       near ptr M01_L35
M01_L130:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 6640
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,1C8032B4840
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,1C8032B4868
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FF98371FCC0]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptionMessages(System.Exception)
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
       call      qword ptr [7FF98371FCD8]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
       mov       rbx,rax
       mov       r8,1C884006DE0
       mov       r8,[r8]
       test      r8,r8
       je        near ptr M01_L03
M01_L00:
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Select[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Exception>, System.Func`2<System.Exception,System.String>)
       call      qword ptr [7FF983285E30]; System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M01_L04
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.String, System.Private.CoreLib]]
       call      qword ptr [7FF982E64348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L05
       mov       rcx,rax
       mov       r11,7FF982D20AE0
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
       call      qword ptr [7FF9833844C8]
       mov       ecx,13CC
       mov       rdx,7FF98317BB70
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF98317BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98317BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E66B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833842B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983086670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Func`2[[System.Exception, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C884006DC8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,7FF98371BDB0
       call      qword ptr [7FF982E64210]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C884006DE0
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L00
M01_L04:
       mov       ecx,10
       call      qword ptr [7FF983084F30]
       int       3
M01_L05:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF982F1DFC8]
       jmp       near ptr M01_L01
; Total bytes of code 435
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rcx,31EB8474840
       mov       [rsi+10],rcx
       mov       dword ptr [rsi+74],80131501
       mov       dword ptr [rsi+74],80070216
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+70],0E0434352
       mov       dword ptr [rdi+74],80131500
       mov       rcx,31EB8474868
       mov       [rdi+10],rcx
       lea       rcx,[rdi+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rdi+74],80131501
       mov       dword ptr [rdi+74],80070057
       mov       dword ptr [rdi+74],80004003
       mov       rcx,rdi
       call      qword ptr [7FF98370FCD8]; DotNetTips.Spargine.Core.Logging.LoggingHelper.RetrieveAllExceptions(System.Exception)
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
       mov       rcx,2DE26403EA0
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
       call      qword ptr [7FF9833744C8]
       mov       ecx,13CC
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1446
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF98316BB70
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF982E56B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9833742B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF983076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF982F0E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L01
; Total bytes of code 308
```

