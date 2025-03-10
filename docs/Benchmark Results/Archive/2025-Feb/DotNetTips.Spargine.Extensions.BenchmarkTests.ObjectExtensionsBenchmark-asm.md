## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rdx,[rbx+40]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE184743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 224
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L02
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
M01_L00:
       cmp       [r10],rcx
       je        short M01_L01
       cmp       [r10+8],rcx
       je        short M01_L01
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       jne       short M01_L03
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       jmp       qword ptr [7FFE184743A8]
M01_L03:
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L00
       test      r8,r8
       je        short M01_L02
M01_L04:
       cmp       [r10],rcx
       je        short M01_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
       jmp       short M01_L02
; Total bytes of code 99
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE186DEF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,220E6BC0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonArray()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE18EE4270]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       [rsp+30],rax
       mov       rcx,2044400EB98
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE189A6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9EDF0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        short M00_L04
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L05
       jmp       short M00_L05
M00_L03:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M00_L09
       jmp       short M00_L02
M00_L04:
       xor       edx,edx
M00_L05:
       test      edx,edx
       je        near ptr M00_L10
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE18EE5AE8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L06:
       mov       ecx,10
       call      qword ptr [7FFE18714F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFE18341048
       call      qword ptr [r11]
       test      rax,rax
       jne       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rdx,rax
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       call      qword ptr [7FFE18A04D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFE18A04AE0]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,244D5FC5A90
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 558
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L02
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L05
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L01
M01_L00:
       cmp       [r9],rcx
       je        short M01_L02
       cmp       [r9+8],rcx
       je        short M01_L02
       cmp       [r9+10],rcx
       je        short M01_L02
       cmp       [r9+18],rcx
       je        short M01_L02
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jl        short M01_L04
       jmp       short M01_L00
M01_L01:
       cmp       [r9],rcx
       je        short M01_L02
       add       r9,8
       dec       r10
       test      r10,r10
       jle       short M01_L05
       jmp       short M01_L01
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       jmp       qword ptr [7FFE18484378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       test      r10,r10
       jne       short M01_L01
M01_L05:
       test      dword ptr [r8],406C0000
       jne       short M01_L03
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 114
```
```assembly
; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       [rsp+58],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],30
       jle       short M02_L00
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE190B6860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M02_L08
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbx
       mov       rdx,7FFE190B6A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L03:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       je        near ptr M02_L15
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],48
       jle       short M02_L04
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rbx
       mov       rdx,7FFE190B6A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],50
       jle       short M02_L06
       mov       r11,[rcx+50]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       rdx,7FFE190B6B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rax,rsi
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L08:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L09
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rbx
       mov       rdx,7FFE190B6A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE190A6220]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FFE190B6A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFE190A6298]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFE190B6A50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE190A6328]
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L15:
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],58
       jle       short M02_L16
       mov       rcx,[rcx+58]
       test      rcx,rcx
       je        short M02_L16
       jmp       short M02_L17
M02_L16:
       mov       rcx,rbx
       mov       rdx,7FFE190B6BB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FFE18925578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 521
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M03_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M03_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE189A7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M03_L05
       call      qword ptr [7FFE18A0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M03_L03
       jmp       near ptr M03_L09
M03_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L09
M03_L03:
       call      qword ptr [7FFE189A6E68]
       test      eax,eax
       je        near ptr M03_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE18A0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18A0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M03_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A6730]
       jmp       short M03_L09
M03_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D7B8]
       jmp       short M03_L09
M03_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M03_L07
M03_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M03_L08
M03_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M03_L08:
       cmp       dword ptr [rbp-34],0
       je        short M03_L09
       call      qword ptr [7FFE189AC978]
M03_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M04_L01
M04_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M04_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,244D5FB2D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M04_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M05_L12
M05_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M05_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,20444001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE18C80DA0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M05_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M05_L02
M05_L01:
       mov       edx,2
M05_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M05_L13
       mov       rdi,244D5FB1C08
M05_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M05_L14
M05_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE18A0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M05_L08
       cmp       [rcx+8],r15d
       jb        short M05_L07
M05_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M05_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M05_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M05_L06:
       cmp       r15d,r12d
       ja        short M05_L07
       mov       r12d,r15d
       jmp       short M05_L10
M05_L07:
       call      qword ptr [7FFE186EE9D0]
       int       3
M05_L08:
       test      r15d,r15d
       jne       short M05_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M05_L05
M05_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M05_L06
M05_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE18A0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M05_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M05_L00
M05_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE18D569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L13:
       mov       rcx,7FFE189D3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2044400F688
       mov       rdi,[rcx]
       jmp       near ptr M05_L03
M05_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE18C9F9F0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE18D564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE18D540D8]
       mov       r14,r13
       jmp       near ptr M05_L04
M05_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M05_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M05_L18
M05_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L19
M05_L18:
       mov       rax,[rcx]
       add       rax,10
M05_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M05_L20
       test      r10d,r10d
       jne       short M05_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M05_L23
M05_L20:
       cmp       [rcx+8],r10d
       jae       short M05_L22
M05_L21:
       call      qword ptr [7FFE186EE9D0]
       int       3
M05_L22:
       add       rcx,10
M05_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M05_L25
       cmp       rdx,300
       ja        short M05_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L25
M05_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE18535BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,20444001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE18C80DA8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
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
; Total bytes of code 1178
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M06_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L00
       mov       ecx,ecx
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFE18E35B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       ecx,ecx
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFE18E35B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M06_L04
M06_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184873F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M07_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M07_L01
       jmp       short M07_L01
M07_L00:
       xor       edx,edx
M07_L01:
       test      edx,edx
       je        near ptr M07_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L03
M07_L02:
       mov       r8,2044400DA80
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE18EE5B48]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M07_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,rsi
       mov       rdx,7FFE18EBDA78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M07_L02
M07_L04:
       lea       rcx,[rsp+28]
       mov       rdx,244D5FC5CA0
       call      qword ptr [7FFE186758F0]
M07_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE188D4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M07_L07
M07_L06:
       call      qword ptr [7FFE186EE9D0]
       int       3
M07_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M07_L08
       mov       rdx,244D5FB0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M07_L09
M07_L08:
       lea       rcx,[rsp+28]
       mov       rdx,244D5FB0C48
       call      qword ptr [7FFE186758F0]
M07_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18716718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L10:
       call      qword ptr [7FFE18A04D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M07_L11
       call      qword ptr [7FFE18A04AE0]
       mov       rsi,rax
M07_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,244D5FC5A90
       mov       r8,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE186756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M07_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M07_L04
       mov       rcx,244D5FC5CAC
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M07_L05
; Total bytes of code 551
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,244D5FB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M09_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M09_L01
       test      r8,r8
       je        short M09_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M09_L01
       test      r8,r8
       je        short M09_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M09_L01
       test      r8,r8
       je        short M09_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M09_L01
       test      r8,r8
       je        short M09_L02
       jmp       short M09_L00
M09_L01:
       mov       rax,rdx
       ret
M09_L02:
       jmp       qword ptr [7FFE184843A8]
; Total bytes of code 71
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonCollection()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       [rsp+30],rcx
       mov       rcx,20B44C0CBA0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE189A6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9EE50]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        short M00_L03
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L04
       jmp       short M00_L04
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M00_L06
       jmp       short M00_L01
M00_L03:
       xor       edx,edx
M00_L04:
       test      edx,edx
       je        near ptr M00_L07
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE18F766E8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L05:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE18A04D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE18A04AE0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24BD6A259A0
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 465
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE189A7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE18A0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M01_L03
       jmp       near ptr M01_L09
M01_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L03:
       call      qword ptr [7FFE189A6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE18A0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18A0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M01_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L07
M01_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M01_L08:
       cmp       dword ptr [rbp-34],0
       je        short M01_L09
       call      qword ptr [7FFE189AC978]
M01_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,24BD6A12D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M02_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M03_L12
M03_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M03_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,20B48C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE18C80DA0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M03_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M03_L02
M03_L01:
       mov       edx,2
M03_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M03_L13
       mov       rdi,24BD6A11C08
M03_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M03_L14
M03_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE18A0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M03_L08
       cmp       [rcx+8],r15d
       jb        short M03_L07
M03_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M03_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M03_L06:
       cmp       r15d,r12d
       ja        short M03_L07
       mov       r12d,r15d
       jmp       short M03_L10
M03_L07:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L08:
       test      r15d,r15d
       jne       short M03_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M03_L05
M03_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M03_L06
M03_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE18A0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M03_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE18D569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE189D3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20B44C0D690
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE18C9FA50]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE18D564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE18D540D8]
       mov       r14,r13
       jmp       near ptr M03_L04
M03_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L19
M03_L18:
       mov       rax,[rcx]
       add       rax,10
M03_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M03_L20
       test      r10d,r10d
       jne       short M03_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M03_L23
M03_L20:
       cmp       [rcx+8],r10d
       jae       short M03_L22
M03_L21:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L22:
       add       rcx,10
M03_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M03_L25
       cmp       rdx,300
       ja        short M03_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE18535BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,20B48C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE18C80DA8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
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
; Total bytes of code 1178
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE18E35B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE18E35B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184873F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       je        near ptr M05_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,20B44C0BA88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE18F76748]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE18F67178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,24BD6A25BC0
       call      qword ptr [7FFE186758F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE188D4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FFE186EE9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,24BD6A10C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,24BD6A10C48
       call      qword ptr [7FFE186758F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18716718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FFE18A04D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FFE18A04AE0]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24BD6A259A0
       mov       r8,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE186756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M05_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M05_L04
       mov       rcx,24BD6A25BCC
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M05_L05
; Total bytes of code 551
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M06_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L02
       test      rbx,rbx
       je        short M06_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M06_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M06_L02:
       test      rbx,rbx
       je        short M06_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M06_L04
M06_L03:
       mov       rax,24BD6A10008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M07_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M07_L01
       test      r8,r8
       je        short M07_L02
       jmp       short M07_L00
M07_L01:
       mov       rax,rdx
       ret
M07_L02:
       jmp       qword ptr [7FFE184843A8]
; Total bytes of code 71
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePerson()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       [rsp+30],rcx
       mov       rcx,1449F40CBA0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE189A6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9EDF0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        short M00_L03
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L04
       jmp       short M00_L04
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M00_L06
       jmp       short M00_L01
M00_L03:
       xor       edx,edx
M00_L04:
       test      edx,edx
       je        near ptr M00_L07
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE18F3D6E0]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L05:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE18A04D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE18A04AE0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,18531335410
       mov       r8,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 462
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE189A7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE18A0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M01_L03
       jmp       near ptr M01_L09
M01_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L03:
       call      qword ptr [7FFE189A6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE18A0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18A0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M01_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L07
M01_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M01_L08:
       cmp       dword ptr [rbp-34],0
       je        short M01_L09
       call      qword ptr [7FFE189AC978]
M01_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,18531322D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M02_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M03_L12
M03_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M03_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,144A3401F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE18C80DA0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M03_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M03_L02
M03_L01:
       mov       edx,2
M03_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M03_L13
       mov       rdi,18531321C08
M03_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M03_L14
M03_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE18A0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M03_L08
       cmp       [rcx+8],r15d
       jb        short M03_L07
M03_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M03_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M03_L06:
       cmp       r15d,r12d
       ja        short M03_L07
       mov       r12d,r15d
       jmp       short M03_L10
M03_L07:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L08:
       test      r15d,r15d
       jne       short M03_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M03_L05
M03_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M03_L06
M03_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE18A0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M03_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE18D569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE189D3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1449F40D690
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE18C9F9F0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE18D564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE18D540D8]
       mov       r14,r13
       jmp       near ptr M03_L04
M03_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L19
M03_L18:
       mov       rax,[rcx]
       add       rax,10
M03_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M03_L20
       test      r10d,r10d
       jne       short M03_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M03_L23
M03_L20:
       cmp       [rcx+8],r10d
       jae       short M03_L22
M03_L21:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L22:
       add       rcx,10
M03_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M03_L25
       cmp       rdx,300
       ja        short M03_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE18535BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,144A3401F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE18C80DA8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
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
; Total bytes of code 1178
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M04_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M04_L00
       mov       ecx,ecx
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE18E35B18]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       ecx,ecx
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE18E35B18]
       test      eax,eax
       jne       short M04_L04
M04_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184873F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M05_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M05_L01
       jmp       short M05_L01
M05_L00:
       xor       edx,edx
M05_L01:
       test      edx,edx
       je        near ptr M05_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE18487318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,1449F40BA88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE18F3D740]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE18F44680
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,18531335630
       call      qword ptr [7FFE186758F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE188D4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FFE186EE9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,18531320C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,18531320C48
       call      qword ptr [7FFE186758F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18716718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FFE18A04D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FFE18A04AE0]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,18531335410
       mov       r8,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE186756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M05_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M05_L04
       mov       rcx,1853133563C
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M05_L05
; Total bytes of code 551
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M06_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L02
       test      rbx,rbx
       je        short M06_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M06_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M06_L02:
       test      rbx,rbx
       je        short M06_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M06_L04
M06_L03:
       mov       rax,18531320008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M07_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M07_L02
M07_L01:
       mov       rax,rdx
       ret
M07_L02:
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L01
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L01
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L01
       test      rax,rax
       jne       short M07_L00
M07_L03:
       jmp       qword ptr [7FFE184843A8]
; Total bytes of code 69
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonRecord()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       vmovups   xmm0,[rsi+40]
       vmovups   [rdi+40],xmm0
       mov       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+30]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+28],rdi
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
; Total bytes of code 183
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       call      qword ptr [7FFE18965728]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-0C0],rsp
       test      rcx,rcx
       je        near ptr M01_L21
       mov       rax,206B4C009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,206B4C0EB98
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L22
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L23
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9EDF0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L25
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L24
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE1876D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L27
       cmp       r9d,r15d
       jne       near ptr M01_L26
M01_L04:
       xor       edx,edx
       mov       [rbp-48],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       mov       [rsp+20],r14
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rdi+8]
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE186D9E58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r14,r14
       je        near ptr M01_L28
       lea       rsi,[r14+10]
       mov       ebx,[r14+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rdx,[r12+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L29
       xor       ecx,ecx
       mov       [rbp-80],rsi
       mov       [rbp-78],ebx
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-88],ecx
       mov       [rbp-0A0],rdx
       mov       [rbp-98],r8d
       lea       rdx,[rbp-60]
       mov       [rsp+28],rdx
       lea       rdx,[rbp-0A0]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-80]
       lea       r8,[rbp-90]
       mov       rcx,24746B69070
       xor       r9d,r9d
       call      qword ptr [7FFE18F758C0]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       r12,10
       mov       ebx,20
       mov       rcx,206B4C0EBA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L30
       mov       rcx,[rcx+18]
M01_L06:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L20
       mov       rcx,[rsi+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L17
       lea       rcx,[rsi+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L17
M01_L07:
       mov       rsi,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],rsi
       xor       edi,edi
       test      ebx,ebx
       jle       near ptr M01_L16
M01_L10:
       mov       ecx,edi
       movzx     ecx,byte ptr [r12+rcx]
       mov       r8,206B4C00428
       mov       r8,[r8]
       mov       rdx,24746B753E8
       call      qword ptr [7FFE186C4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L15
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L14
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L13
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L12
M01_L11:
       mov       [rsi+18],r13d
       jmp       short M01_L15
M01_L12:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L13:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rsi
       call      qword ptr [7FFE1878CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       inc       edi
       cmp       edi,ebx
       jl        near ptr M01_L10
M01_L16:
       mov       rcx,rsi
       call      qword ptr [7FFE18797A60]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,rsp
       call      M01_L33
       nop
       mov       rax,[rbp-0B0]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L17:
       mov       r13,[rsi+18]
       mov       r15,[r13+18]
       lea       rdx,[rbp-68]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C6ED00]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L31
M01_L18:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L07
M01_L19:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L08
M01_L20:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L09
M01_L21:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,24746B62D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L23:
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L24:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE187650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L25:
       mov       ecx,1763
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M01_L26:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFE1848C8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L27:
       call      qword ptr [7FFE1848C7E0]
       int       3
M01_L28:
       mov       ecx,6A61
       mov       rdx,7FFE1898E1A0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M01_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE18EAF120]
       mov       rbx,rax
       mov       ecx,4465
       mov       rdx,7FFE1898E1A0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE1848F750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L30:
       call      qword ptr [7FFE188F5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L31:
       cmp       qword ptr [r15+10],0
       jne       short M01_L32
       xor       edx,edx
       mov       [rbp-68],rdx
       jmp       near ptr M01_L19
M01_L32:
       lea       rdx,[rbp-68]
       mov       rcx,r13
       call      qword ptr [7FFE18C6E820]
       test      eax,eax
       je        near ptr M01_L19
       jmp       near ptr M01_L18
M01_L33:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,206B4C0EBA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L34
       call      qword ptr [7FFE188F5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M01_L35
M01_L34:
       mov       rsi,[rcx+18]
M01_L35:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L40
       mov       rax,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L36
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L41
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1878C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L37
M01_L36:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L41
M01_L37:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L38
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L41
M01_L38:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L39
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C6ED30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L41
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18C6E7F0]
       jmp       short M01_L41
M01_L39:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M01_L41
M01_L40:
       mov       rbx,[rbp-0A8]
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L41:
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
; Total bytes of code 1713
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       call      qword ptr [7FFE18945728]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-0B0],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp-0C0],rsp
       test      rcx,rcx
       je        near ptr M01_L20
       mov       rax,2C7A5C009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,2C7A5C0EB98
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE18986730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L21
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L22
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C7EDF0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L26
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L11
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE1874D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L25
       cmp       r9d,r15d
       jne       near ptr M01_L24
M01_L04:
       xor       edx,edx
       mov       [rbp-48],rdx
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsp+20],rsi
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,[rdi+8]
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE186B9E58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L27
       lea       rbx,[rax+10]
       mov       r14d,[rax+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L28
       xor       ecx,ecx
       mov       [rbp-80],rbx
       mov       [rbp-78],r14d
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-88],ecx
       mov       [rbp-0A0],rdx
       mov       [rbp-98],r8d
       lea       rdx,[rbp-60]
       mov       [rsp+28],rdx
       lea       rdx,[rbp-0A0]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-80]
       lea       r8,[rbp-90]
       mov       rcx,30837A49070
       xor       r9d,r9d
       call      qword ptr [7FFE18F54408]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       rsi,10
       mov       ebx,20
       mov       rcx,2C7A5C0EBA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L10
       mov       rcx,[rcx+18]
M01_L06:
       mov       r14,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L30
       mov       rcx,[r14+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L23
       lea       rcx,[r14+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L23
M01_L07:
       mov       r12,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [r12],r12b
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFE1876C1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],r12
       jmp       short M01_L12
M01_L10:
       call      qword ptr [7FFE188D5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       short M01_L06
M01_L11:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE187450C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L12:
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L19
M01_L13:
       mov       ecx,r15d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,2C7A5C00428
       mov       r8,[r8]
       mov       rdx,30837A55410
       call      qword ptr [7FFE186A4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L18
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L18
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        short M01_L17
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L16
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L15
M01_L14:
       mov       [r12+18],r14d
       jmp       short M01_L18
M01_L15:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L14
M01_L16:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE18515B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L14
M01_L17:
       mov       rcx,r12
       call      qword ptr [7FFE1876CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L18:
       inc       r15d
       cmp       r15d,ebx
       jl        near ptr M01_L13
M01_L19:
       mov       rcx,r12
       call      qword ptr [7FFE18777A60]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,rsp
       call      M01_L31
       nop
       mov       rax,[rbp-0B0]
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       call      qword ptr [7FFE189E4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE189E4AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7FFE186F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,30837A42D10
       mov       r8d,1
       call      qword ptr [7FFE18985FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       jmp       near ptr M01_L02
M01_L22:
       call      qword ptr [7FFE184643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L23:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C4E808]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L29
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L07
M01_L24:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFE1846C8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L25:
       call      qword ptr [7FFE1846C7E0]
       int       3
M01_L26:
       mov       ecx,1763
       mov       rdx,7FFE18314000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE186F66E8]
       int       3
M01_L27:
       mov       ecx,6A61
       mov       rdx,7FFE1896E1A0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE186F66E8]
       int       3
M01_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE18F55968]
       mov       rbx,rax
       mov       ecx,4465
       mov       rdx,7FFE1896E1A0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE1846F750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r12,rax
       jmp       near ptr M01_L08
M01_L30:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r12,rax
       jmp       near ptr M01_L09
M01_L31:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0F0]
       mov       rcx,2C7A5C0EBA0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L32
       call      qword ptr [7FFE188D5E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r12,rax
       jmp       short M01_L33
M01_L32:
       mov       r12,[rcx+18]
M01_L33:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r12],rcx
       jne       near ptr M01_L38
       mov       rax,[r12+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L34
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L39
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1876C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L35
M01_L34:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L39
M01_L35:
       cmp       qword ptr [r12+20],0
       jne       short M01_L36
       lea       rcx,[r12+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L39
M01_L36:
       lea       rcx,[r12+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r12+28]
       jg        short M01_L37
       mov       rcx,[r12+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C4E7D8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L39
M01_L37:
       add       r12,2C
       lock dec  dword ptr [r12]
       jmp       short M01_L39
M01_L38:
       mov       rbx,[rbp-0A8]
       mov       rcx,r12
       mov       rdx,rbx
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L39:
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
; Total bytes of code 1657
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18F5EF88]; System.Data.DataTable..ctor()
       mov       rcx,2669A655410
       mov       [rbx+70],rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rsp+28]
       xor       r8d,r8d
       mov       r9d,34
       call      qword ptr [7FFE183F6700]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       cmp       dword ptr [rsp+38],0
       je        near ptr M00_L10
       cmp       dword ptr [rsp+38],1
       je        near ptr M00_L11
       mov       esi,[rsp+38]
       test      esi,esi
       jl        near ptr M00_L12
       mov       rdi,[rsp+28]
       test      rdi,rdi
       je        near ptr M00_L13
       mov       ebp,[rdi+8]
       cmp       ebp,esi
       je        short M00_L01
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       esi,ebp
       cmovg     esi,ebp
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L08
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+28],r14
M00_L01:
       mov       edx,[rsp+38]
       mov       [rsp+3C],edx
       mov       rsi,[rsp+28]
M00_L02:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M00_L06
M00_L03:
       mov       edx,edi
       mov       r14,[rsi+rdx*8+10]
       mov       rdx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rdx
       jne       short M00_L09
       mov       rdx,r14
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M00_L14
M00_L04:
       cmp       [rdx],dl
       mov       rcx,2669A64F3D0
       call      qword ptr [7FFE183EA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
       test      eax,eax
       jne       short M00_L07
M00_L05:
       inc       edi
       cmp       ebp,edi
       jg        short M00_L03
M00_L06:
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L07:
       mov       rcx,r14
       mov       rdx,rbx
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE184A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L05
       xor       edx,edx
       call      qword ptr [7FFE18985890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M00_L05
M00_L08:
       call      qword ptr [7FFE18555BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       short M00_L04
M00_L10:
       mov       rcx,2260C801EE0
       mov       rsi,[rcx]
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+30]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE1870ED48]
       int       3
M00_L13:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+28],rax
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFE187C73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M00_L04
; Total bytes of code 527
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+70]
       mov       rsi,2669A640008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,2669A6554B0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,2669A655588
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,2260C801FC0
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2260C801FC8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2260C801FD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FFE183E5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFE18F792C0
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFE1875C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,22608810420
       mov       rcx,[rcx]
       mov       rsi,rcx
       mov       edi,[rbx+1C0]
       cmp       byte ptr [rcx+9D],0
       je        short M01_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       mov       rdx,2669A655430
       call      qword ptr [7FFE184A6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE185576D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18FB74B0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE186B4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18FB5878]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2260C801E58
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],2
       mov       rcx,rdi
       call      qword ptr [7FFE18FB65F8]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2260C801FE8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+58]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rbx+178]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 928
```
```assembly
; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
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
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbp,rcx
       mov       rdi,rdx
       mov       rsi,r8
       mov       ebx,r9d
       xor       r14d,r14d
       xor       r15d,r15d
       test      rsi,rsi
       je        near ptr M02_L05
       test      bl,1
       je        short M02_L00
       mov       rdx,rsi
       mov       rcx,2260C800590
       mov       rcx,[rcx]
       call      qword ptr [7FFE18E55920]
       mov       rsi,rax
       mov       r15d,1
       mov       r13d,2
       jmp       short M02_L01
M02_L00:
       mov       r13d,1
M02_L01:
       cmp       byte ptr [rsp+0C0],0
       je        short M02_L06
       mov       ecx,[rsi+8]
       mov       eax,ecx
       cmp       word ptr [rsi+rax*2+0A],2A
       jne       short M02_L06
       lea       r12d,[rcx-1]
       cmp       ecx,r12d
       jb        near ptr M02_L21
       test      r12d,r12d
       jne       short M02_L02
       mov       rsi,2669A640008
       jmp       short M02_L04
M02_L02:
       cmp       ecx,r12d
       jne       short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       ecx,r12d
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       mov       r8d,r12d
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rsi+0C]
       add       r8,r8
       call      qword ptr [7FFE18555B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r14
M02_L04:
       mov       r14d,1
M02_L05:
       xor       r13d,r13d
M02_L06:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L09
       mov       r12,[rcx]
       test      r12,r12
       je        short M02_L09
M02_L07:
       mov       rbp,rsi
       cmp       [r12],r12b
       lea       rax,[r12+48]
       mov       [rsp+30],rax
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L08
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+28]
       mov       rcx,[rsp+30]
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rdx,rax
       test      rdx,rdx
       cmove     rdx,r12
M02_L08:
       mov       r12,rdx
       cmp       [r12],r12b
       cmp       r13d,1
       je        short M02_L10
       cmp       r13d,2
       je        short M02_L12
       jmp       near ptr M02_L14
M02_L09:
       mov       rcx,rbp
       call      qword ptr [7FFE183F6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       short M02_L07
M02_L10:
       lea       rcx,[r12+20]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE1875CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M02_L11
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFE18784E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M02_L11:
       mov       r13,rax
       jmp       short M02_L16
M02_L12:
       lea       rcx,[r12+28]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE1875CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L13
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFE18784E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L13:
       jmp       short M02_L16
M02_L14:
       cmp       byte ptr [r12+18],0
       je        short M02_L15
       mov       r13,[r12+8]
       jmp       short M02_L16
M02_L15:
       mov       rcx,r12
       mov       r8d,r13d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE18784E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L16:
       xor       ebx,2
       mov       ebp,[r13+8]
       mov       ecx,ebp
       xor       r8d,r8d
       mov       [rsp+40],r8
       mov       [rsp+48],r8
       mov       [rsp+50],r8d
       mov       [rsp+54],ecx
       xor       r12d,r12d
       test      ebp,ebp
       jle       short M02_L20
M02_L17:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       mov       [rsp+38],rax
       mov       ecx,[rax+18]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M02_L19
       test      r14d,r14d
       jne       near ptr M02_L22
M02_L18:
       lea       rcx,[rsp+40]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18784BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L19:
       inc       r12d
       cmp       ebp,r12d
       jg        short M02_L17
M02_L20:
       mov       rdx,[rsp+40]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+50]
       mov       [rdi+10],eax
       mov       eax,[rsp+54]
       mov       [rdi+14],eax
       mov       rax,rdi
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
M02_L21:
       mov       ecx,57
       mov       rdx,7FFE18354000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FFE189455A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,57
       mov       rdx,7FFE18354000
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       call      qword ptr [7FFE18A5F630]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rsi
       call      qword ptr [7FFE1855D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FFE183F6538]
       test      eax,eax
       je        near ptr M02_L19
       mov       rax,[rsp+38]
       jmp       near ptr M02_L18
; Total bytes of code 818
```
```assembly
; System.RuntimeType.IsAssignableFrom(System.Type)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M03_L06
       cmp       rbx,rsi
       je        near ptr M03_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M03_L07
       mov       rcx,rbx
M03_L00:
       test      rcx,rcx
       je        short M03_L01
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       short M03_L01
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.RuntimeTypeHandle.CanCastTo(System.RuntimeType, System.RuntimeType)
M03_L01:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.Emit.TypeBuilder
       call      qword ptr [7FFE184A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M03_L06
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M03_L05
       mov       rcx,rsi
       call      qword ptr [7FFE183F4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE183F6148]
M03_L02:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        short M03_L06
       mov       rcx,rsi
       call      qword ptr [7FFE183EA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
       mov       rsi,rax
       xor       edi,edi
       jmp       short M03_L04
M03_L03:
       mov       ecx,edi
       mov       rcx,[rsi+rcx*8+10]
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L06
       inc       edi
M03_L04:
       cmp       [rsi+8],edi
       jg        short M03_L03
M03_L05:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L06:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L07:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rcx,rax
       jmp       near ptr M03_L00
; Total bytes of code 290
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       test      rdx,rdx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rbx,[rdx]
       movzx     esi,word ptr [rbx+0E]
       test      rsi,rsi
       je        short M04_L05
       mov       rdi,[rbx+38]
       cmp       rsi,4
       jge       short M04_L03
M04_L02:
       cmp       [rdi],rcx
       je        short M04_L00
       jmp       short M04_L04
M04_L03:
       cmp       [rdi],rcx
       je        short M04_L00
       cmp       [rdi+8],rcx
       je        short M04_L00
       cmp       [rdi+10],rcx
       je        short M04_L00
       cmp       [rdi+18],rcx
       je        short M04_L00
       add       rdi,20
       add       rsi,0FFFFFFFFFFFFFFFC
       cmp       rsi,4
       jl        short M04_L07
       jmp       short M04_L03
M04_L04:
       add       rdi,8
       dec       rsi
       test      rsi,rsi
       jg        short M04_L02
M04_L05:
       test      dword ptr [rbx],406C0000
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L00
M04_L06:
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE184A4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M04_L07:
       test      rsi,rsi
       je        short M04_L05
       jmp       short M04_L02
; Total bytes of code 123
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       [rbp+18],edx
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.IAsyncDisposable
       call      qword ptr [7FFE184A4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M05_L00
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       cmp       [rbx],rcx
       jne       short M05_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE18FB7B10]; System.Threading.ReaderWriterLockSlim.Dispose(Boolean)
       jmp       short M05_L03
M05_L00:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFE18360D18
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE18FD55D8]
       test      eax,eax
       je        short M05_L03
       call      qword ptr [7FFE18FD5AB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L01
       call      qword ptr [7FFE18A24C48]
       mov       rbx,rax
M05_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18736718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L02:
       mov       rcx,rbx
       mov       r11,7FFE18360D10
       call      qword ptr [r11]
       nop
M05_L03:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L04:
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
       cmp       byte ptr [rbp+18],0
       je        short M05_L05
       call      CORINFO_HELP_RETHROW
M05_L05:
       lea       rax,[M05_L03]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 270
```
```assembly
; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       cmp       rsi,rbx
       je        short M06_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M06_L03
M06_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFE77E21D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M06_L00
M06_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFE77E21D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFE77E21D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M06_L03
       jmp       short M06_L01
; Total bytes of code 150
```
```assembly
; System.Reflection.RtFieldInfo.InitializeFieldType()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_System.Signature
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       r9d,r9d
       mov       [rsp+20],r9
       mov       r9,[rbx+10]
       mov       [rsp+28],r9
       mov       r9,[rbx+30]
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      System.Signature.GetSignature(Void*, Int32, System.RuntimeFieldHandleInternal, System.IRuntimeMethodInfo, System.RuntimeType)
       mov       rsi,[rsi+18]
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 87
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       [rsp+30],rdx
       mov       rdx,27967CB53E8
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE183DA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
       test      rax,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+38],xmm4
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rax,rdx
       mov       ebx,r8d
       mov       rsi,r9
       test      rax,rax
       je        near ptr M01_L07
       mov       rdi,[rsp+0A8]
       mov       [rsp+20],rdi
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rsp+38]
       mov       r8,rax
       mov       r9d,ebx
       call      qword ptr [7FFE183E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       jne       near ptr M01_L08
M01_L00:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       mov       rax,rbp
       jmp       near ptr M01_L06
M01_L02:
       mov       r14,[rsp+0A0]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,rbp
       call      qword ptr [7FFE186FF1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18774B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE18B4CC00]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FFE183E5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18774B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r8,rax
       mov       [rsp+20],rdi
       mov       rdi,[rsp+0B0]
       mov       [rsp+28],rdi
       mov       edx,ebx
       mov       rcx,rsi
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
M01_L06:
       nop
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       mov       ecx,31F
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187266E8]
       int       3
M01_L08:
       test      rdi,rdi
       je        short M01_L09
       cmp       dword ptr [rdi+8],0
       jne       short M01_L10
M01_L09:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       xor       r8d,r8d
       call      qword ptr [7FFE18774B70]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
       mov       rbp,rax
       cmp       dword ptr [rsp+48],1
       jne       near ptr M01_L02
       mov       r14,[rsp+0A0]
       test      r14,r14
       je        near ptr M01_L01
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+10]
       test      eax,eax
       jne       near ptr M01_L01
       jmp       near ptr M01_L00
M01_L10:
       mov       r14,[rsp+0A0]
       jmp       near ptr M01_L03
; Total bytes of code 430
```
**Extern method**
System.Object.GetType()

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       [rsp+30],rdx
       mov       rdx,1D3A4C25410
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE183CA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
       test      rax,rax
       sete      al
       movzx     eax,al
       test      eax,eax
       sete      al
       movzx     eax,al
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 92
```
```assembly
; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+38],xmm4
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rax,rdx
       mov       ebx,r8d
       mov       rsi,r9
       mov       rdi,[rsp+0A8]
       test      rax,rax
       je        near ptr M01_L09
       mov       [rsp+20],rdi
       xor       edx,edx
       mov       [rsp+28],edx
       lea       rdx,[rsp+38]
       mov       r8,rax
       mov       r9d,ebx
       call      qword ptr [7FFE183D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       jne       short M01_L01
M01_L00:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L01:
       test      rdi,rdi
       je        short M01_L02
       cmp       dword ptr [rdi+8],0
       jne       near ptr M01_L06
M01_L02:
       cmp       qword ptr [rsp+38],0
       je        near ptr M01_L07
       mov       rcx,[rsp+38]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M01_L16
       mov       rcx,[rsp+38]
       mov       rbp,[rcx+10]
M01_L03:
       cmp       dword ptr [rsp+48],1
       jne       near ptr M01_L12
       mov       r14,[rsp+0A0]
       test      r14,r14
       je        short M01_L05
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rbp],rcx
       jne       short M01_L10
       mov       rcx,rbp
       call      qword ptr [7FFE1876CC60]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rdx,[rax+18]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       short M01_L11
       mov       rcx,r14
       call      qword ptr [7FFE183CA720]; Precode of System.RuntimeType.IsEquivalentTo(System.Type)
M01_L04:
       test      eax,eax
       je        near ptr M01_L00
M01_L05:
       mov       rax,rbp
       jmp       short M01_L08
M01_L06:
       mov       r14,[rsp+0A0]
       jmp       short M01_L13
M01_L07:
       mov       rbp,[rsp+40]
       jmp       short M01_L03
M01_L08:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       ecx,31F
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M01_L10:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       rdx,rax
M01_L11:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+0A0]
       call      qword ptr [rax+10]
       jmp       short M01_L04
M01_L12:
       mov       r14,[rsp+0A0]
       test      r14,r14
       jne       short M01_L13
       mov       rcx,rbp
       call      qword ptr [7FFE186EF1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L13:
       test      ebx,10000
       je        short M01_L14
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18764B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE18B3CC00]
       jmp       near ptr M01_L08
M01_L14:
       test      rsi,rsi
       jne       short M01_L15
       call      qword ptr [7FFE183D5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L15:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18764B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r8,rax
       mov       [rsp+20],rdi
       mov       rdi,[rsp+0B0]
       mov       [rsp+28],rdi
       mov       edx,ebx
       mov       rcx,rsi
       mov       r9,r14
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L08
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 499
```
**Extern method**
System.Object.GetType()

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+40],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+30],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+40],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+30],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       cmp       [rsi],sil
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       vmovups   xmm0,[rsi+40]
       vmovups   [rdi+40],xmm0
       mov       rdx,[rsi+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+18]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       lea       rcx,[rdi+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+28]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+30]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,25528B853E8
       call      qword ptr [7FFE1894FF98]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
       mov       [rsp+28],rdi
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
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+28]
       cmp       rdi,rbx
       je        near ptr M01_L06
       test      rdi,rdi
       je        short M01_L00
       test      rbx,rbx
       je        short M01_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       je        short M01_L05
M01_L00:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       [rsp+28],rcx
       mov       ebp,1
       mov       [rsp+28],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        short M01_L07
M01_L01:
       test      eax,eax
       je        near ptr M01_L08
M01_L02:
       test      rbx,rbx
       je        near ptr M01_L11
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M01_L10
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M01_L03:
       test      r14d,r14d
       je        near ptr M01_L12
M01_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFE18525068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        short M01_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE185247B0]
       mov       ecx,eax
       jmp       short M01_L02
M01_L08:
       call      qword ptr [7FFE189F4CD8]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L09
       call      qword ptr [7FFE189F4AF8]
       mov       r14,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,25528B7FC10
       mov       r8,r14
       call      qword ptr [7FFE1852D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       xor       r14d,r14d
       jmp       near ptr M01_L03
M01_L11:
       xor       r14d,r14d
       jne       near ptr M01_L04
M01_L12:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A19
       mov       rdx,7FFE188043C8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE18995B78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1852D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 381
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       cmp       [rcx],ecx
       call      qword ptr [7FFE1894FF70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2CD912D8D90
       mov       [rsi+8],rcx
       mov       word ptr [rsi+10],3A
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L04
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,2CD912DC8C8
       xor       edx,edx
       call      qword ptr [7FFE183C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFE184761D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2CD912D5F40
       test      eax,eax
       cmovne    rdi,rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189557E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,2CD912D0008
       call      qword ptr [7FFE18F652D8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184762F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,[rsi+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L00
       cmp       esi,edi
       jg        short M01_L02
M01_L00:
       test      esi,esi
       je        near ptr M01_L07
       sub       edi,esi
       je        short M01_L03
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       r14,[rbp+0C]
       mov       rcx,r14
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       ecx,1C7
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFE192A5458]
       int       3
M01_L03:
       mov       rax,2CD912D0008
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,825
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rax,rbx
       jmp       near ptr M01_L01
M01_L07:
       mov       rax,rbx
       jmp       near ptr M01_L01
; Total bytes of code 742
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       mov       rdx,280B6730008
       mov       r8d,1
       call      qword ptr [7FFE189457E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1846EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F1D2A8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1846EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L04
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1846EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F1DA58]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18655740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M01_L02
M01_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M01_L38
       jmp       near ptr M01_L24
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F1D668]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183B66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18745908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,280B6730008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,24024801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE187F0C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L55
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L57
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L56
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L57
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18515B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184643C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FFE18605EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L10:
       mov       rcx,rax
M01_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L16
M01_L12:
       cmp       r12,rdi
       jne       near ptr M01_L19
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1871E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L21
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18674180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,280B6745440
       call      qword ptr [7FFE18466C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189457E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F1D998]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,2402480EC50
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2402480EC48
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,2402480EC50
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       rcx,2402480EC58
       mov       r9,[rcx]
       test      r9,r9
       je        short M01_L18
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE1910FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L20
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1871E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L17:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       near ptr M01_L22
M01_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2402480EC48
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,2402480EC58
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r15
       jmp       near ptr M01_L15
M01_L19:
       mov       rcx,[rbp-118]
       mov       r11,7FFE18320E88
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L20:
       mov       r11,7FFE18320E80
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18464348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L23
       cmp       [rcx],rdi
       jne       near ptr M01_L51
M01_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L58
       mov       r8,280B673D5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18746208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18746280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L41
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE187EE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L37
M01_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L59
M01_L28:
       test      rcx,rcx
       je        near ptr M01_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18727910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       je        near ptr M01_L37
M01_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M01_L40
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       r10,[rcx]
       add       r10,10
M01_L31:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L32
       mov       r9,24024800438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L32
       mov       r9,24024800418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M01_L62
M01_L32:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M01_L64
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M01_L63
M01_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,280B6745468
       call      qword ptr [7FFE18466C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189457E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18464360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M01_L34:
       mov       rcx,2402480EC60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L45
M01_L35:
       mov       rcx,2402480EC68
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L44
       mov       rax,[rbp-138]
M01_L36:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE1910FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L37:
       add       esi,1
       jo        near ptr M01_L46
       cmp       esi,r15d
       jl        near ptr M01_L24
M01_L38:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L39:
       jmp       near ptr M01_L61
M01_L40:
       jmp       near ptr M01_L61
M01_L41:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L42
       mov       r8,[rbp-98]
       jmp       short M01_L43
M01_L42:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L43:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M01_L41
       jmp       near ptr M01_L25
M01_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,2402480EC48
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2402480EC68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2402480EC48
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2402480EC60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L46:
       call      CORINFO_HELP_OVERFLOW
M01_L47:
       call      qword ptr [7FFE189E4CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE189E4AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE186F6670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L48:
       call      qword ptr [7FFE189E4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE189E4AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE186F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L49:
       mov       r11,7FFE18320E98
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L50:
       mov       rcx,rax
       mov       r11,7FFE18320E78
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L51:
       mov       r11,7FFE18320E90
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L52:
       mov       rcx,24024801E10
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L53:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L54:
       call      qword ptr [7FFE189E4CF0]
       mov       ecx,0F
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE189E4AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE186F6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L56:
       call      qword ptr [7FFE186CE9D0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18655848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,280B673D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L26
M01_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M01_L28
M01_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L29
M01_L61:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L62:
       call      qword ptr [7FFE18674030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187451B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18745230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L33
M01_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L33
M01_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L34
M01_L66:
       call      qword ptr [7FFE189E4CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE187F5148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1893AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18466B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189E4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE186F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A1D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18314000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1846F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A1CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1846F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FFE186F4F30]
       int       3
M01_L71:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18464348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FFE18320E90
       call      qword ptr [r11]
M01_L72:
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
; Total bytes of code 3786
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       mov       rdx,2666E190008
       xor       r8d,r8d
       call      qword ptr [7FFE189657E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1848EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L46
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L47
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F3EDF0]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1848EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L48
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1848EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F3F5A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FFE18F3F1B0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18765908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L05:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2666E190008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,225E0401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18810C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L55
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L57
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L56
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L57
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FFE18625EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L08:
       mov       rcx,rax
M01_L09:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L14
M01_L10:
       cmp       r12,rdi
       jne       near ptr M01_L18
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1873E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L16
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2666E1A5418
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F3F4E0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,225DC40CC58
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,225DC40CC50
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       r14,225DC40CC60
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L17
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191549F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L19
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1873E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L15:
       test      eax,eax
       jne       near ptr M01_L10
       jmp       short M01_L20
M01_L16:
       call      CORINFO_HELP_OVERFLOW
M01_L17:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,225DC40CC50
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-118]
       mov       r11,7FFE18340EA8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       r11,7FFE18340EA0
       call      qword ptr [r11]
       jmp       near ptr M01_L15
M01_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L21
       cmp       [rcx],rdi
       jne       near ptr M01_L51
M01_L21:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M01_L37
M01_L23:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L58
       mov       r8,2666E19D5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18766208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18766280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L40
M01_L24:
       mov       rdx,[rbp-160]
M01_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE1880E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L26
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L36
M01_L26:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L59
M01_L27:
       test      rcx,rcx
       je        near ptr M01_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18747910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L29
       test      rax,rax
       je        near ptr M01_L36
M01_L29:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M01_L39
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M01_L38
       mov       r10,[rcx]
       add       r10,10
M01_L30:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L31
       mov       r9,225E0400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L31
       mov       r9,225E0400418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M01_L62
M01_L31:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M01_L64
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M01_L63
M01_L32:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2666E1A5440
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M01_L33:
       mov       rcx,225DC40CC68
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L44
M01_L34:
       mov       rcx,225DC40CC70
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L43
       mov       rax,[rbp-138]
M01_L35:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191549F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L36:
       add       esi,1
       jo        near ptr M01_L45
       cmp       esi,r15d
       jl        near ptr M01_L23
M01_L37:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L38:
       jmp       near ptr M01_L61
M01_L39:
       jmp       near ptr M01_L61
M01_L40:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L41
       mov       r8,[rbp-98]
       jmp       short M01_L42
M01_L41:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L42:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M01_L40
       jmp       near ptr M01_L24
M01_L43:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,225DC40CC50
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,225DC40CC70
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L35
M01_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,225DC40CC50
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,225DC40CC68
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L34
M01_L45:
       call      CORINFO_HELP_OVERFLOW
M01_L46:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18716670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L47:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L48:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M01_L02
M01_L49:
       mov       r11,7FFE18340EB8
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L50:
       mov       rcx,rax
       mov       r11,7FFE18340E98
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L51:
       mov       r11,7FFE18340EB0
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L52:
       mov       rcx,225E0401E10
       mov       r15,[rcx]
       jmp       near ptr M01_L05
M01_L53:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L54:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0F
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18716670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L56:
       call      qword ptr [7FFE186EE9D0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18675848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,2666E19D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L25
M01_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M01_L27
M01_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L28
M01_L61:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L30
M01_L62:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18765230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L32
M01_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L32
M01_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L33
M01_L66:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1848F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FFE18714F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FFE18714F30]
       int       3
M01_L71:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FFE18340EB0
       call      qword ptr [r11]
M01_L72:
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
; Total bytes of code 3773
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       mov       rdx,190AE210008
       mov       r8d,1
       call      qword ptr [7FFE189757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1849EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L49
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L50
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F852A8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1849EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L51
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1849EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F85A58]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FFE18F85668]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18775908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L05:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,190AE210008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1501C401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18820C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L58
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L60
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L59
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L60
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L52
       call      qword ptr [7FFE18635EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L08:
       mov       rcx,rax
M01_L09:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L14
M01_L10:
       cmp       r12,rdi
       jne       near ptr M01_L17
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1874E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,190AE225418
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F85998]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1501C40EC50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1501C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       r14,1501C40EC58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L16
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191679D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L18
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1874E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L15:
       test      eax,eax
       jne       near ptr M01_L10
       jmp       near ptr M01_L20
M01_L16:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1501C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L13
M01_L17:
       mov       rcx,[rbp-118]
       mov       r11,7FFE183514E0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L18:
       mov       r11,7FFE183514D8
       call      qword ptr [r11]
       jmp       near ptr M01_L15
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L21
       cmp       [rcx],rdi
       jne       near ptr M01_L54
M01_L21:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M01_L38
M01_L23:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L69
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L61
       mov       r8,190AE21D5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L70
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L70
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18776208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18776280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L24:
       mov       rdx,[rbp-160]
M01_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE1881E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L26
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L37
M01_L26:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L62
       mov       rcx,[rax+18]
M01_L27:
       test      rcx,rcx
       je        near ptr M01_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18757910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L29
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M01_L37
M01_L29:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+40]
       cmp       dword ptr [rdx+190],4
       jl        near ptr M01_L41
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M01_L40
       mov       r8,[rdx]
       add       r8,10
M01_L30:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L31
       mov       r10,1501C400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L31
       mov       r10,1501C400418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L65
M01_L31:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M01_L39
M01_L32:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M01_L46
M01_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,190AE225440
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18494360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L68
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M01_L34:
       mov       rcx,1501C40EC60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L47
M01_L35:
       mov       rcx,1501C40EC68
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L45
       mov       rax,[rbp-138]
M01_L36:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191679D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L37:
       add       esi,1
       jo        near ptr M01_L48
       cmp       esi,r15d
       jl        near ptr M01_L23
M01_L38:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L39:
       jmp       near ptr M01_L66
M01_L40:
       jmp       near ptr M01_L64
M01_L41:
       jmp       near ptr M01_L64
M01_L42:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L43
       mov       r8,[rbp-98]
       jmp       short M01_L44
M01_L43:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L44:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M01_L42
       jmp       near ptr M01_L24
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,1501C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1501C40EC68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L46:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18775230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1501C40EC48
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1501C40EC60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L48:
       call      CORINFO_HELP_OVERFLOW
M01_L49:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18726670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L50:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M01_L02
M01_L52:
       mov       r11,7FFE183514F0
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L53:
       mov       rcx,rax
       mov       r11,7FFE183514D0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L54:
       mov       r11,7FFE183514E8
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L55:
       mov       rcx,1501C401E10
       mov       r15,[rcx]
       jmp       near ptr M01_L05
M01_L56:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L57:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0F
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18726670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L59:
       call      qword ptr [7FFE186FE9D0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18685848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,190AE21D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L25
M01_L62:
       xor       ecx,ecx
       jmp       near ptr M01_L27
M01_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L28
M01_L64:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L30
M01_L65:
       call      qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M01_L67
M01_L66:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L34
M01_L69:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1849F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1849F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FFE18724F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FFE18724F30]
       int       3
M01_L74:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FFE183514E8
       call      qword ptr [r11]
M01_L75:
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
; Total bytes of code 3797
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       mov       rdx,29819260008
       xor       r8d,r8d
       call      qword ptr [7FFE189757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 73
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M01_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1849EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F4D2A8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1849EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L04
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1849EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F4DA58]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M01_L05
M01_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M01_L02
M01_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M01_L39
       jmp       near ptr M01_L24
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F4D668]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18775908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,29819260008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,25787401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18820C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L58
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L60
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L59
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L60
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L52
       call      qword ptr [7FFE18635EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L10:
       mov       rcx,rax
M01_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L16
M01_L12:
       cmp       r12,rdi
       jne       near ptr M01_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1874E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,29819275418
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F4D998]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2578740EC50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2578740EC48
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,2578740EC58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE1913FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1874E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L17:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       short M01_L22
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2578740EC48
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE18350F88
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FFE18350F80
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L23
       cmp       [rcx],rdi
       jne       near ptr M01_L54
M01_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L69
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L61
       mov       r8,2981926D5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L70
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L70
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18776208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18776280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L43
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE1881E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L38
M01_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L62
       mov       rcx,[rax+18]
M01_L28:
       test      rcx,rcx
       je        near ptr M01_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18757910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M01_L38
M01_L30:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],4
       jl        near ptr M01_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M01_L41
       mov       r8,[rdx]
       add       r8,10
M01_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L32
       mov       r10,25787400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,25787400418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L65
M01_L32:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M01_L40
M01_L33:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M01_L47
M01_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,29819275440
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18494360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L68
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M01_L35:
       mov       rcx,2578740EC60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L36:
       mov       rcx,2578740EC68
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L46
       mov       rax,[rbp-138]
M01_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE1913FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L49
       cmp       esi,r15d
       jl        near ptr M01_L24
M01_L39:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L40:
       jmp       near ptr M01_L66
M01_L41:
       jmp       near ptr M01_L64
M01_L42:
       jmp       near ptr M01_L64
M01_L43:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L44
       mov       r8,[rbp-98]
       jmp       short M01_L45
M01_L44:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L45:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M01_L43
       jmp       near ptr M01_L25
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,2578740EC48
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2578740EC68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187751B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18775230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2578740EC48
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2578740EC60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18726670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L52:
       mov       r11,7FFE18350F98
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L53:
       mov       rcx,rax
       mov       r11,7FFE18350F78
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L54:
       mov       r11,7FFE18350F90
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L55:
       mov       rcx,25787401E10
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L56:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L57:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0F
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18726670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L59:
       call      qword ptr [7FFE186FE9D0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18685848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,2981926D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L26
M01_L62:
       xor       ecx,ecx
       jmp       near ptr M01_L28
M01_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L29
M01_L64:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L65:
       call      qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M01_L67
M01_L66:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L35
M01_L69:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1849F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1849F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FFE18724F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FFE18724F30]
       int       3
M01_L74:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FFE18350F90
       call      qword ptr [r11]
M01_L75:
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
; Total bytes of code 3788
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,27E511E8D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,27E511EC8C8
       xor       edx,edx
       call      qword ptr [7FFE183C6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE184761D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,27E511E5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE189557E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,27E511E0008
       call      qword ptr [7FFE18F652D8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184762F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       mov       ebp,[rsi+8]
       mov       r14d,edi
       cmp       r14d,ebp
       jl        short M00_L00
       cmp       edi,ebp
       jg        short M00_L02
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
       sub       ebp,edi
       je        near ptr M00_L03
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r14,[r15+0C]
       mov       rcx,r14
       lea       rdx,[rsi+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r15
M00_L01:
       mov       [rsp+20],rsi
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,1C7
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE192A5458]
       int       3
M00_L03:
       mov       rsi,27E511E0008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,825
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 783
```
```assembly
; System.RuntimeType.GetCachedName(System.TypeNameKind)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M01_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE183C6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE1872CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 52
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M02_L00:
       cmp       rbx,rsi
       je        short M02_L05
       test      rbx,rbx
       jne       short M02_L03
M02_L01:
       cmp       edi,5
       ja        short M02_L06
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L01
       cmp       edi,4
       jne       short M02_L07
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        near ptr M02_L08
       jmp       short M02_L02
M02_L04:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       cmp       edi,5
       ja        short M02_L06
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186DECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE18D02980]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18684180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188E68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE183B5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23DC34003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188E68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18525068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L04
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18475F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18A459C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1847F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 395
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M03_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1847EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F65368]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1847EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M03_L04
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1847EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F65B18]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18665740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M03_L02
M03_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L38
       jmp       near ptr M03_L24
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F65728]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183C66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18755908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,27E511E0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,23DC3401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18800C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L55
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L57
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L56
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L57
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FFE18615EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L16
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1872E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18684180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,27E511F5450
       call      qword ptr [7FFE18476C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189557E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F65A58]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,23DBF40CC58
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,23DBF40CC50
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,23DBF40CC60
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191479D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1872E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       short M03_L22
M03_L18:
       call      CORINFO_HELP_OVERFLOW
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,23DBF40CC50
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE183314F8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FFE183314F0
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18474348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L51
M03_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L58
       mov       r8,27E511ED5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M03_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18756208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18756280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L41
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE187FE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L37
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L59
M03_L28:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18737910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       je        near ptr M03_L37
M03_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M03_L40
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L39
       mov       r10,[rcx]
       add       r10,10
M03_L31:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L32
       mov       r9,23DC3400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,23DC3400418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L62
M03_L32:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M03_L64
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M03_L63
M03_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,27E511F5478
       call      qword ptr [7FFE18476C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189557E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18474360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       mov       rcx,23DBF40CC68
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,23DBF40CC70
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L44
       mov       rax,[rbp-138]
M03_L36:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191479D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L37:
       add       esi,1
       jo        near ptr M03_L46
       cmp       esi,r15d
       jl        near ptr M03_L24
M03_L38:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L39:
       jmp       near ptr M03_L61
M03_L40:
       jmp       near ptr M03_L61
M03_L41:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L42
       mov       r8,[rbp-98]
       jmp       short M03_L43
M03_L42:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L43:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L41
       jmp       near ptr M03_L25
M03_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,23DBF40CC50
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,23DBF40CC70
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,23DBF40CC50
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,23DBF40CC68
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18706670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18706670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       r11,7FFE18331508
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L50:
       mov       rcx,rax
       mov       r11,7FFE183314E8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L51:
       mov       r11,7FFE18331500
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L52:
       mov       rcx,23DC3401E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L53:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L54:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,0F
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18706670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FFE186DE9D0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18665848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,27E511ED5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L61:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L62:
       call      qword ptr [7FFE18684030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187551B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18755230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L34
M03_L66:
       call      qword ptr [7FFE189F4CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18805148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1894AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18476B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE189F4AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18706670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A2D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1847F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A2CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1847F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FFE18704F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FFE18704F30]
       int       3
M03_L71:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18474348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FFE18331500
       call      qword ptr [r11]
M03_L72:
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
; Total bytes of code 3768
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       call      qword ptr [7FFE18684180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbp,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       ecx,5
       mov       [rsp+20],r14
       mov       [rsp+28],ecx
       mov       rcx,rbp
       lea       r8,[rsp+20]
       mov       rdx,27E5120DF50
       call      qword ptr [7FFE18476C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 202
```
```assembly
; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L30
       test      rsi,rsi
       je        near ptr M05_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L27
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L14
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,23DC3400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,23DC3400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L17
M05_L04:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,27E5120DF50
       call      qword ptr [7FFE18476C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M05_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M05_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE18331568
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       mov       rax,[rbp-78]
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L23
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,23DC3400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,23DC3400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
M05_L12:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,27E5120DF50
       call      qword ptr [7FFE18476C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L13:
       mov       rax,[rbp-78]
M05_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M05_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L16:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE18684030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE186DEFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE1918E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L21:
       mov       rcx,rax
       mov       r11,7FFE18331568
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M05_L28
       jmp       near ptr M05_L09
M05_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M05_L28
M05_L23:
       mov       rcx,rbx
       mov       rdx,7FFE1918E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE18684030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L12
M05_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L13
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE1918DFB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L32
M05_L29:
       mov       rax,r14
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       ecx,10
       call      qword ptr [7FFE18704F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE18704F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE18331570
       call      qword ptr [r11]
       jmp       short M05_L29
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M05_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M05_L33
       mov       rcx,rax
       mov       r11,7FFE18331570
       call      qword ptr [r11]
M05_L33:
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
; Total bytes of code 1501
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M06_L00:
       test      rsi,rsi
       je        near ptr M06_L08
       cmp       rbx,rsi
       jne       short M06_L02
       cmp       edi,5
       ja        near ptr M06_L09
M06_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M06_L03
       cmp       edi,5
       ja        near ptr M06_L09
       jmp       short M06_L01
M06_L03:
       cmp       edi,5
       ja        near ptr M06_L12
       mov       eax,edi
       lea       rcx,[7FFE191E1C90]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18684180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188E6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE183B539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,23DC34003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188E6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M06_L05
       cmp       ebp,1
       je        near ptr M06_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18525068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE188CE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M06_L07
M06_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      qword ptr [7FFE188CE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M06_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       ecx,2E5
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187066E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186DECB8]
       int       3
M06_L10:
       mov       rcx,7FFE183B5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE186DED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A459C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE18324000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1847F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M07_L00:
       ret
M07_L01:
       test      r8b,4
       je        short M07_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L00
M07_L02:
       cmp       r8,40
       ja        short M07_L07
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L06
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L00
M07_L05:
       test      r8,r8
       je        short M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M07_L00
M07_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L04
M07_L07:
       cmp       r8,800
       ja        short M07_L10
       mov       r9,r8
       shr       r9,6
M07_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L08
       and       r8,3F
       cmp       r8,10
       ja        near ptr M07_L03
       jmp       near ptr M07_L04
M07_L09:
       cmp       rcx,rdx
       je        near ptr M07_L00
M07_L10:
       jmp       qword ptr [7FFE18525B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 259
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18525B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FFE186DEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,27E511E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Object.GetType()
System.String.FastAllocateString(Int32)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2E39A2B8D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2E39A2BC8C8
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE184861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2E39A2B5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE189657E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,2E39A2B0008
       call      qword ptr [7FFE18F752D8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       mov       ebp,[rsi+8]
       mov       r14d,edi
       cmp       r14d,ebp
       jl        short M00_L00
       cmp       edi,ebp
       jg        short M00_L02
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
       sub       ebp,edi
       je        near ptr M00_L03
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r14,[r15+0C]
       mov       rcx,r14
       lea       rdx,[rsi+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r15
M00_L01:
       mov       [rsp+20],rsi
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,1C7
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE192A5458]
       int       3
M00_L03:
       mov       rsi,2E39A2B0008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,825
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 780
```
```assembly
; System.RuntimeType.GetCachedName(System.TypeNameKind)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M01_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE183D6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE1873CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 52
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M02_L00:
       cmp       rbx,rsi
       je        short M02_L05
       test      rbx,rbx
       jne       short M02_L03
M02_L01:
       cmp       edi,5
       ja        short M02_L06
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L01
       cmp       edi,4
       jne       short M02_L07
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        near ptr M02_L08
       jmp       short M02_L02
M02_L04:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       cmp       edi,5
       ja        short M02_L06
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE18D12780]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2A30C4003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L04
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18485F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18A559C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1848F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 395
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M03_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1848EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F75368]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1848EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M03_L04
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1848EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F75B18]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M03_L02
M03_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L38
       jmp       near ptr M03_L24
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F75728]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18765908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2E39A2B0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,2A30C401DC8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE187F4E80]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L55
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L57
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L56
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L57
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FFE18625EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L16
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1873E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2E39A2C5450
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F75A58]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2A30840CC58
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2A30840CC50
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,2A30840CC60
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1873E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       short M03_L22
M03_L18:
       call      CORINFO_HELP_OVERFLOW
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2A30840CC50
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE183414F8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FFE183414F0
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L51
M03_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L58
       mov       r8,2E39A2BD5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M03_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18766208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18766280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L41
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE187AECE8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L37
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L59
M03_L28:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18747910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       je        near ptr M03_L37
M03_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M03_L40
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L39
       mov       r10,[rcx]
       add       r10,10
M03_L31:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L32
       mov       r9,2A30C400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,2A30C400418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L62
M03_L32:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M03_L64
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M03_L63
M03_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2E39A2C5478
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       mov       rcx,2A30840CC68
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,2A30840CC70
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L44
       mov       rax,[rbp-138]
M03_L36:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L37:
       add       esi,1
       jo        near ptr M03_L46
       cmp       esi,r15d
       jl        near ptr M03_L24
M03_L38:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L39:
       jmp       near ptr M03_L61
M03_L40:
       jmp       near ptr M03_L61
M03_L41:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L42
       mov       r8,[rbp-98]
       jmp       short M03_L43
M03_L42:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L43:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L41
       jmp       near ptr M03_L25
M03_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,2A30840CC50
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2A30840CC70
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2A30840CC50
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2A30840CC68
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18716670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       r11,7FFE18341508
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L50:
       mov       rcx,rax
       mov       r11,7FFE183414E8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L51:
       mov       r11,7FFE18341500
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L52:
       mov       rcx,2A30C401E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L53:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L54:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0F
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18716670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18675848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,2E39A2BD5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L61:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L62:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18765230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L34
M03_L66:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1848F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FFE18714F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FFE18714F30]
       int       3
M03_L71:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FFE18341500
       call      qword ptr [r11]
M03_L72:
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
; Total bytes of code 3768
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbp,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       ecx,5
       mov       [rsp+20],r14
       mov       [rsp+28],ecx
       mov       rcx,rbp
       lea       r8,[rsp+20]
       mov       rdx,2E39A2DDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 202
```
```assembly
; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L30
       test      rsi,rsi
       je        near ptr M05_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L27
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L14
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,2A30C400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,2A30C400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L17
M05_L04:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,2E39A2DDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M05_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M05_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE18341568
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       mov       rax,[rbp-78]
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L23
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,2A30C400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,2A30C400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
M05_L12:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,2E39A2DDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L13:
       mov       rax,[rbp-78]
M05_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M05_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L16:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE186EEFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE1919E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L21:
       mov       rcx,rax
       mov       r11,7FFE18341568
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M05_L28
       jmp       near ptr M05_L09
M05_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M05_L28
M05_L23:
       mov       rcx,rbx
       mov       rdx,7FFE1919E088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L12
M05_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L13
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE1919DFB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L32
M05_L29:
       mov       rax,r14
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       ecx,10
       call      qword ptr [7FFE18714F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE18714F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE18341570
       call      qword ptr [r11]
       jmp       short M05_L29
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M05_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M05_L33
       mov       rcx,rax
       mov       r11,7FFE18341570
       call      qword ptr [r11]
M05_L33:
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
; Total bytes of code 1501
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M06_L00:
       test      rsi,rsi
       je        near ptr M06_L08
       cmp       rbx,rsi
       jne       short M06_L02
       cmp       edi,5
       ja        near ptr M06_L09
M06_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M06_L03
       cmp       edi,5
       ja        near ptr M06_L09
       jmp       short M06_L01
M06_L03:
       cmp       edi,5
       ja        near ptr M06_L12
       mov       eax,edi
       lea       rcx,[7FFE191F2430]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE183C539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,2A30C4003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M06_L05
       cmp       ebp,1
       je        near ptr M06_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE188DE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M06_L07
M06_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      qword ptr [7FFE188DE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M06_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       ecx,2E5
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M06_L10:
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE186EED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A559C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M07_L00:
       ret
M07_L01:
       test      r8b,4
       je        short M07_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L00
M07_L02:
       cmp       r8,40
       ja        short M07_L06
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L10
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L00
M07_L05:
       test      r8,r8
       je        short M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M07_L00
M07_L06:
       cmp       r8,800
       ja        short M07_L09
       mov       r9,r8
       shr       r9,6
M07_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L07
       and       r8,3F
       cmp       r8,10
       ja        short M07_L03
       jmp       short M07_L04
M07_L08:
       cmp       rcx,rdx
       je        near ptr M07_L00
M07_L09:
       jmp       qword ptr [7FFE18535B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M07_L04
; Total bytes of code 259
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,2E39A2B0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Object.GetType()
System.String.FastAllocateString(Int32)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1D4BA588D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,1D4BA58C8C8
       xor       edx,edx
       call      qword ptr [7FFE183E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE184961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,1D4BA585F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE189757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,1D4BA580008
       call      qword ptr [7FFE18F752D8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184962F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,1D4BA584388
       call      qword ptr [7FFE189355A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,edi
       mov       rdx,1D4BA584368
       call      qword ptr [7FFE189355A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ebp,[rsi+8]
       mov       r14d,edi
       cmp       r14d,ebp
       jl        short M00_L00
       cmp       edi,ebp
       jg        short M00_L02
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
       sub       ebp,edi
       je        near ptr M00_L03
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r14,[r15+0C]
       mov       rcx,r14
       lea       rdx,[rsi+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r15
M00_L01:
       mov       [rsp+20],rsi
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,1C7
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE192C5818]
       int       3
M00_L03:
       mov       rsi,1D4BA580008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,825
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 819
```
```assembly
; System.RuntimeType.GetCachedName(System.TypeNameKind)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M01_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE183E6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE1874CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 52
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M02_L00:
       cmp       rbx,rsi
       je        short M02_L05
       test      rbx,rbx
       jne       short M02_L03
M02_L01:
       cmp       edi,5
       ja        short M02_L06
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L01
       cmp       edi,4
       jne       short M02_L07
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        near ptr M02_L08
       jmp       short M02_L02
M02_L04:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       cmp       edi,5
       ja        short M02_L06
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186FECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE18D36FA0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189068F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE183D5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1942C4003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189068F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18545068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L04
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18495F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18A659C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1849F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 395
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M03_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1849EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F75368]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1849EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M03_L04
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1849EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F75B18]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M03_L02
M03_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L39
       jmp       near ptr M03_L24
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F75728]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18775908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,1D4BA580008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1942C401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18820C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L58
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L60
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L59
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L60
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L52
       call      qword ptr [7FFE18635EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L16
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1874E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,1D4BA595478
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F75A58]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1942C40EC50
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1942C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,1942C40EC58
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191679D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1874E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       short M03_L22
M03_L18:
       call      CORINFO_HELP_OVERFLOW
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1942C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE183510D0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FFE183510C8
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L54
M03_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L69
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L61
       mov       r8,1D4BA58D5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M03_L70
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L70
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18776208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18776280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE1881E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L38
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L62
       mov       rcx,[rax+18]
M03_L28:
       test      rcx,rcx
       je        near ptr M03_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18757910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M03_L38
M03_L30:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],4
       jl        near ptr M03_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       r8,[rdx]
       add       r8,10
M03_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M03_L32
       mov       r10,1942C400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L32
       mov       r10,1942C400418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M03_L65
M03_L32:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M03_L40
M03_L33:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M03_L47
M03_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,1D4BA5954A0
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18494360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L68
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       rcx,1942C40EC60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L36:
       mov       rcx,1942C40EC68
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-138]
M03_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191679D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L38:
       add       esi,1
       jo        near ptr M03_L49
       cmp       esi,r15d
       jl        near ptr M03_L24
M03_L39:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L40:
       jmp       near ptr M03_L66
M03_L41:
       jmp       near ptr M03_L64
M03_L42:
       jmp       near ptr M03_L64
M03_L43:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L44
       mov       r8,[rbp-98]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L43
       jmp       near ptr M03_L25
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,1942C40EC48
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1942C40EC68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L37
M03_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18775230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1942C40EC48
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1942C40EC60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L49:
       call      CORINFO_HELP_OVERFLOW
M03_L50:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18726670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L51:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L52:
       mov       r11,7FFE183510E0
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L53:
       mov       rcx,rax
       mov       r11,7FFE183510C0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L54:
       mov       r11,7FFE183510D8
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L55:
       mov       rcx,1942C401E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L56:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L57:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0F
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18726670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L59:
       call      qword ptr [7FFE186FE9D0]
       int       3
M03_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18685848]
       jmp       near ptr M03_L03
M03_L61:
       mov       rcx,rax
       mov       rdx,1D4BA58D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L62:
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L64:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L65:
       call      qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M03_L67
M03_L66:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M03_L33
M03_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L35
M03_L69:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1849F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1849F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FFE18724F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FFE18724F30]
       int       3
M03_L74:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FFE183510D8
       call      qword ptr [r11]
M03_L75:
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
; Total bytes of code 3788
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbp,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       ecx,5
       mov       [rsp+20],r14
       mov       [rsp+28],ecx
       mov       rcx,rbp
       lea       r8,[rsp+20]
       mov       rdx,1D4BA5AE130
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 202
```
```assembly
; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L30
       test      rsi,rsi
       je        near ptr M05_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L27
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L14
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1942C400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1942C400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L17
M05_L04:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,1D4BA5AE130
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M05_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M05_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE18351158
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       mov       rax,[rbp-78]
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L23
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1942C400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1942C400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
M05_L12:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,1D4BA5AE130
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L13:
       mov       rax,[rbp-78]
M05_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M05_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L16:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE186FEFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE191AE268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L21:
       mov       rcx,rax
       mov       r11,7FFE18351158
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M05_L28
       jmp       near ptr M05_L09
M05_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M05_L28
M05_L23:
       mov       rcx,rbx
       mov       rdx,7FFE191AE268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE186A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L12
M05_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L13
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE191AE190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L32
M05_L29:
       mov       rax,r14
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       ecx,10
       call      qword ptr [7FFE18724F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE18724F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE18351160
       call      qword ptr [r11]
       jmp       short M05_L29
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M05_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M05_L33
       mov       rcx,rax
       mov       r11,7FFE18351160
       call      qword ptr [r11]
M05_L33:
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
; Total bytes of code 1501
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M06_L00:
       test      rsi,rsi
       je        near ptr M06_L08
       cmp       rbx,rsi
       jne       short M06_L02
       cmp       edi,5
       ja        near ptr M06_L09
M06_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M06_L03
       cmp       edi,5
       ja        near ptr M06_L09
       jmp       short M06_L01
M06_L03:
       cmp       edi,5
       ja        near ptr M06_L12
       mov       eax,edi
       lea       rcx,[7FFE191F5C50]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE18906A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE183D539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1942C4003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE18906A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M06_L05
       cmp       ebp,1
       je        near ptr M06_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18545068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE188EE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M06_L07
M06_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      qword ptr [7FFE188EE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M06_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       ecx,2E5
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187266E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186FECB8]
       int       3
M06_L10:
       mov       rcx,7FFE183D5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE186FED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A659C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE18344000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1849F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M07_L00
       add       rsp,28
       ret
M07_L00:
       call      qword ptr [7FFE18DF7D68]
       int       3
; Total bytes of code 20
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M08_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M08_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M08_L03
       test      r8b,18
       jne       short M08_L01
       test      r8b,4
       je        short M08_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M08_L00:
       ret
M08_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M08_L00
M08_L02:
       test      r8,r8
       je        short M08_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M08_L06
       jmp       short M08_L00
M08_L03:
       cmp       r8,40
       ja        short M08_L07
M08_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M08_L11
M08_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M08_L00
M08_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M08_L00
M08_L07:
       cmp       r8,800
       ja        short M08_L10
       mov       r9,r8
       shr       r9,6
M08_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M08_L08
       and       r8,3F
       cmp       r8,10
       ja        short M08_L04
       jmp       short M08_L05
M08_L09:
       cmp       rcx,rdx
       je        near ptr M08_L00
M08_L10:
       jmp       qword ptr [7FFE18545B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M08_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M08_L05
; Total bytes of code 254
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M09_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M09_L02
       test      rbx,rbx
       je        short M09_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M09_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18545B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L01:
       call      qword ptr [7FFE186FEF40]
       int       3
M09_L02:
       test      rbx,rbx
       je        short M09_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M09_L04
M09_L03:
       mov       rax,1D4BA580008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Object.GetType()
System.String.FastAllocateString(Int32)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2417B8F8D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2417B8FC8C8
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE184861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2417B8F5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE189657E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,2417B8F0008
       call      qword ptr [7FFE18F652D8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       mov       ebp,[rsi+8]
       mov       r14d,edi
       cmp       r14d,ebp
       jl        short M00_L00
       cmp       edi,ebp
       jg        short M00_L02
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
       sub       ebp,edi
       je        near ptr M00_L03
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r14,[r15+0C]
       mov       rcx,r14
       lea       rdx,[rsi+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r15
M00_L01:
       mov       [rsp+20],rsi
       mov       rsi,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,1C7
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE192B5CE0]
       int       3
M00_L03:
       mov       rsi,2417B8F0008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,825
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 780
```
```assembly
; System.RuntimeType.GetCachedName(System.TypeNameKind)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M01_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE183D6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE1873CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 52
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M02_L00:
       cmp       rbx,rsi
       je        near ptr M02_L07
       test      rbx,rbx
       jne       short M02_L03
M02_L01:
       cmp       edi,5
       ja        near ptr M02_L08
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L01
       cmp       edi,4
       jne       near ptr M02_L09
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        short M02_L04
       jmp       short M02_L02
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,200ED8003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F68F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L04:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M02_L06
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18485F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18A559C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1848F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L07:
       cmp       edi,5
       ja        short M02_L08
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L08:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M02_L09:
       cmp       edi,5
       ja        short M02_L05
       mov       eax,edi
       lea       rcx,[7FFE18D12CE8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
; Total bytes of code 392
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M03_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1848EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F65368]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1848EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M03_L04
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1848EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F65B18]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M03_L02
M03_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L39
       jmp       near ptr M03_L24
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F65728]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18765908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2417B8F0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,200ED801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE18810C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L58
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L60
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L59
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L60
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L52
       call      qword ptr [7FFE18625EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L16
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1873E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2417B905478
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F65A58]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,200F980CC58
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,200F980CC50
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,200F980CC60
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1873E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       short M03_L22
M03_L18:
       call      CORINFO_HELP_OVERFLOW
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,200F980CC50
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE18341538
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FFE18341530
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L54
M03_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L69
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L61
       mov       r8,2417B8FD5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M03_L70
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L70
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18766208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18766280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE1880E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L38
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L62
       mov       rcx,[rax+18]
M03_L28:
       test      rcx,rcx
       je        near ptr M03_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18747910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M03_L38
M03_L30:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],4
       jl        near ptr M03_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       r8,[rdx]
       add       r8,10
M03_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M03_L32
       mov       r10,200ED800438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L32
       mov       r10,200ED800418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M03_L65
M03_L32:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M03_L40
M03_L33:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M03_L47
M03_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2417B9054A0
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE189657E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L68
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M03_L35:
       mov       rcx,200F980CC68
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L36:
       mov       rcx,200F980CC70
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-138]
M03_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L38:
       add       esi,1
       jo        near ptr M03_L49
       cmp       esi,r15d
       jl        near ptr M03_L24
M03_L39:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L40:
       jmp       near ptr M03_L66
M03_L41:
       jmp       near ptr M03_L64
M03_L42:
       jmp       near ptr M03_L64
M03_L43:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L44
       mov       r8,[rbp-98]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L43
       jmp       near ptr M03_L25
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,200F980CC50
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,200F980CC70
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L37
M03_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187651B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18765230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,200F980CC50
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,200F980CC68
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L49:
       call      CORINFO_HELP_OVERFLOW
M03_L50:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7EF
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18716670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L51:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L52:
       mov       r11,7FFE18341548
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L53:
       mov       rcx,rax
       mov       r11,7FFE18341528
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L54:
       mov       r11,7FFE18341540
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L55:
       mov       rcx,200ED801E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L56:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L57:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0F
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18716670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L59:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18675848]
       jmp       near ptr M03_L03
M03_L61:
       mov       rcx,rax
       mov       rdx,2417B8FD5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L62:
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L64:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L65:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M03_L67
M03_L66:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M03_L33
M03_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L35
M03_L69:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,0B30
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A3CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1848F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FFE18714F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FFE18714F30]
       int       3
M03_L74:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FFE18341540
       call      qword ptr [r11]
M03_L75:
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
; Total bytes of code 3788
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbp,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       ecx,5
       mov       [rsp+20],r14
       mov       [rsp+28],ecx
       mov       rcx,rbp
       lea       r8,[rsp+20]
       mov       rdx,2417B91E130
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 202
```
```assembly
; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L30
       test      rsi,rsi
       je        near ptr M05_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L27
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L14
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,200ED800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,200ED800418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L17
M05_L04:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,2417B91E130
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M05_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M05_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE183415C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       mov       rax,[rbp-78]
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L23
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,200ED800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,200ED800418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
M05_L12:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,2417B91E130
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L13:
       mov       rax,[rbp-78]
M05_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M05_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L16:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE186EEFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE1919E3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L21:
       mov       rcx,rax
       mov       r11,7FFE183415C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M05_L28
       jmp       near ptr M05_L09
M05_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M05_L28
M05_L23:
       mov       rcx,rbx
       mov       rdx,7FFE1919E3B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L12
M05_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L13
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE1919E2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L32
M05_L29:
       mov       rax,r14
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       ecx,10
       call      qword ptr [7FFE18714F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE18714F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE183415D0
       call      qword ptr [r11]
       jmp       short M05_L29
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M05_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M05_L33
       mov       rcx,rax
       mov       r11,7FFE183415D0
       call      qword ptr [r11]
M05_L33:
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
; Total bytes of code 1501
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M06_L00:
       test      rsi,rsi
       je        near ptr M06_L08
       cmp       rbx,rsi
       jne       short M06_L02
       cmp       edi,5
       ja        near ptr M06_L09
M06_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M06_L03
       cmp       edi,5
       ja        near ptr M06_L09
       jmp       short M06_L01
M06_L03:
       cmp       edi,5
       ja        near ptr M06_L12
       mov       eax,edi
       lea       rcx,[7FFE191F9F50]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE183C539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,200ED8003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M06_L05
       cmp       ebp,1
       je        near ptr M06_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE188DE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M06_L07
M06_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      qword ptr [7FFE188DE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M06_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       ecx,2E5
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M06_L10:
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE186EED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A559C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L03
       test      r8b,18
       jne       short M07_L01
       test      r8b,4
       je        short M07_L00
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L02
M07_L00:
       test      r8,r8
       je        short M07_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M07_L02
M07_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M07_L02:
       ret
M07_L03:
       cmp       r8,40
       ja        short M07_L06
M07_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L10
M07_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L02
M07_L06:
       cmp       r8,800
       ja        short M07_L09
       mov       r9,r8
       shr       r9,6
M07_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L07
       and       r8,3F
       cmp       r8,10
       ja        short M07_L04
       jmp       short M07_L05
M07_L08:
       cmp       rcx,rdx
       je        short M07_L02
M07_L09:
       jmp       qword ptr [7FFE18535B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L05
; Total bytes of code 248
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M08_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M08_L02
       test      rbx,rbx
       je        short M08_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M08_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M08_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M08_L02:
       test      rbx,rbx
       je        short M08_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M08_L04
M08_L03:
       mov       rax,2417B8F0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Object.GetType()
System.String.FastAllocateString(Int32)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,19FE8FD8D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L03
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,19FE8FDC8C8
       xor       edx,edx
       call      qword ptr [7FFE183D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE184861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,19FE8FD5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE18965440]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,19FE8FD0008
       call      qword ptr [7FFE18F65608]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE184862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L04
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       mov       ebp,[rsi+8]
       mov       r14d,edi
       cmp       r14d,ebp
       jl        short M00_L00
       cmp       edi,ebp
       jg        near ptr M00_L06
M00_L00:
       test      edi,edi
       je        near ptr M00_L05
       sub       ebp,edi
       je        near ptr M00_L07
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       r14,[r15+0C]
       mov       rcx,r14
       lea       rdx,[rsi+0C]
       xor       r8d,r8d
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx*2+0C]
       mov       rcx,r14
       movsxd    r8,ebp
       call      qword ptr [7FFE18DE7DB0]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       mov       rdi,r15
M00_L01:
       mov       rcx,19FE8FD0008
       test      rdi,rdi
       cmove     rdi,rcx
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE191A7078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L02:
       xor       edi,edi
       jmp       short M00_L01
M00_L03:
       call      qword ptr [7FFE18A044C8]
       mov       ecx,825
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A042B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rdi,rsi
       jmp       near ptr M00_L01
M00_L05:
       mov       rdi,rsi
       jmp       near ptr M00_L01
M00_L06:
       mov       ecx,1C7
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE192B5458]
       int       3
M00_L07:
       mov       rdi,19FE8FD0008
       jmp       near ptr M00_L01
; Total bytes of code 672
```
```assembly
; System.RuntimeType.GetCachedName(System.TypeNameKind)
       push      rbx
       sub       rsp,20
       mov       ebx,edx
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M01_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE183D6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE1873CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
       nop
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 52
```
```assembly
; System.String.Equals(System.String, System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M02_L00:
       cmp       rbx,rsi
       je        short M02_L05
       test      rbx,rbx
       jne       short M02_L03
M02_L01:
       cmp       edi,5
       ja        short M02_L06
M02_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       test      rsi,rsi
       je        short M02_L01
       cmp       edi,4
       jne       short M02_L07
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        near ptr M02_L08
       jmp       short M02_L02
M02_L04:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       cmp       edi,5
       ja        short M02_L06
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE18D26AA0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F6100]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15F570003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE188F6100]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L04
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18485F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE18A55338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE1848F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 395
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
M03_L00:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,188
       vzeroupper
       lea       rbp,[rsp+1C0]
       xor       eax,eax
       mov       [rbp-108],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-190],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FFE1848EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L49
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FFE18F65698]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FFE1848EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M03_L04
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE1848EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L03:
       lea       rcx,[rbp-60]
       mov       edx,2E
       call      qword ptr [7FFE18F65E48]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE18675740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       short M03_L05
M03_L04:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       short M03_L02
M03_L05:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L38
       jmp       near ptr M03_L24
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE18F65A58]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE183D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L53
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L54
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE18765908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L55
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,19FE8FD0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,15F57001DC8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE187F2CC0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L56
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L58
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L57
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L58
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE184843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L51
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L50
       call      qword ptr [7FFE18625EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L16
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L19
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE1873E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L21
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r15+8],r13d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-70],rsi
       mov       [rbp-68],r15
       lea       r8,[rbp-70]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,19FE8FE5450
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE18965440]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE18F65D88]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,15F5700EC50
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,15F5700EC48
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,15F5700EC58
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L18
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE1873E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L22
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,15F5700EC48
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L19:
       mov       rcx,[rbp-118]
       mov       r11,7FFE18341130
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L20:
       mov       r11,7FFE18341128
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L52
M03_L23:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L24:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L67
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L59
       mov       r8,19FE8FDD5E8
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M03_L68
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L68
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-120]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0B8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-0A0]
       mov       r9,[rbp-158]
       call      qword ptr [7FFE18766208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE18766280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L44
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE187AE8B0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L37
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L61
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L60
M03_L28:
       test      rcx,rcx
       je        near ptr M03_L69
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE18747910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       je        near ptr M03_L37
M03_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M03_L40
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M03_L39
       mov       r10,[rcx]
       add       r10,10
M03_L31:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L32
       mov       r9,15F57000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,15F57000418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L63
M03_L32:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M03_L65
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M03_L64
M03_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,19FE8FE5478
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE18965440]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L70
       test      rax,rax
       je        near ptr M03_L71
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L66
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-178],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-178]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-178]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-170]
       call      CORINFO_HELP_ASSIGN_REF
M03_L34:
       mov       rcx,15F5700EC60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,15F5700EC68
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L43
       mov       rax,[rbp-138]
M03_L36:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE191579D8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L37:
       add       esi,1
       jo        near ptr M03_L47
       cmp       esi,r15d
       jl        near ptr M03_L24
M03_L38:
       mov       rax,r14
       add       rsp,188
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L39:
       jmp       near ptr M03_L62
M03_L40:
       jmp       near ptr M03_L62
M03_L41:
       mov       rcx,[rbp-0A0]
       cmp       eax,[rcx+8]
       jae       near ptr M03_L72
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L42:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L44
       jmp       near ptr M03_L25
M03_L43:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,15F5700EC48
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,15F5700EC68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L44:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L41
       jmp       short M03_L46
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,15F5700EC48
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,15F5700EC60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       mov       r8,[rbp-98]
       jmp       near ptr M03_L42
M03_L47:
       call      CORINFO_HELP_OVERFLOW
M03_L48:
       call      qword ptr [7FFE18A044C8]
       mov       ecx,7EF
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE18A042B8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE18716670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L49:
       call      qword ptr [7FFE18A044C8]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A042B8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18716670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L50:
       mov       r11,7FFE18341140
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L51:
       mov       rcx,rax
       mov       r11,7FFE18341120
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L52:
       mov       r11,7FFE18341138
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L53:
       mov       rcx,15F57001E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L54:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L55:
       call      qword ptr [7FFE18A044C8]
       mov       ecx,0F
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE18A042B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE18716670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L56:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L57:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L58:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE18675848]
       jmp       near ptr M03_L03
M03_L59:
       mov       rcx,rax
       mov       rdx,19FE8FDD5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L60:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L61:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L62:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L63:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L64:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE187651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE18765230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L65:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L33
M03_L66:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L34
M03_L67:
       call      qword ptr [7FFE18A044C8]
       mov       ecx,0B30
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18814C68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A042B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4CE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A4C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE1848F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L70:
       mov       ecx,4
       call      qword ptr [7FFE18714F30]
       int       3
M03_L71:
       mov       ecx,0E
       call      qword ptr [7FFE18714F30]
       int       3
M03_L72:
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
       lea       rbp,[rbp+1C0]
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE18484348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L73
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L73
       mov       r11,7FFE18341138
       call      qword ptr [r11]
M03_L73:
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
; Total bytes of code 3780
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbp,rax
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [rsi+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       ecx,5
       mov       [rsp+20],r14
       mov       [rsp+28],ecx
       mov       rcx,rbp
       lea       r8,[rsp+20]
       mov       rdx,19FE8FFDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 202
```
```assembly
; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-90],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L30
       test      rsi,rsi
       je        near ptr M05_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L27
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L14
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,15F57000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,15F57000418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L17
M05_L04:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,19FE8FFDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M05_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M05_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE183411A0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       mov       rax,[rbp-78]
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L23
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],4
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,15F57000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,15F57000418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
M05_L12:
       mov       rcx,offset MT_System.Object[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-80],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r12+8]
       mov       r14,[rbp-80]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       movzx     ecx,word ptr [r12+10]
       mov       [rax+8],cx
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       add       r14,10
       mov       eax,5
       mov       rcx,r15
       mov       [rbp-60],r14
       mov       [rbp-58],eax
       lea       r8,[rbp-60]
       mov       rdx,19FE8FFDF50
       call      qword ptr [7FFE18486C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L13:
       mov       rax,[rbp-78]
M05_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L18
M05_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M05_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L16:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE186EEFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE1919DF68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L21:
       mov       rcx,rax
       mov       r11,7FFE183411A0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M05_L28
       jmp       near ptr M05_L09
M05_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M05_L28
M05_L23:
       mov       rcx,rbx
       mov       rdx,7FFE1919DF68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE18694030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L12
M05_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L13
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE1919DE90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M05_L32
M05_L29:
       mov       rax,r14
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       ecx,10
       call      qword ptr [7FFE18714F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE18714F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE183411A8
       call      qword ptr [r11]
       jmp       short M05_L29
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       cmp       qword ptr [rbp-78],0
       je        short M05_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M05_L33
       mov       rcx,rax
       mov       r11,7FFE183411A8
       call      qword ptr [r11]
M05_L33:
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
; Total bytes of code 1501
```
```assembly
; System.String.StartsWith(System.String, System.StringComparison)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M06_L00:
       test      rsi,rsi
       je        near ptr M06_L08
       cmp       rbx,rsi
       jne       short M06_L02
       cmp       edi,5
       ja        near ptr M06_L09
M06_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M06_L03
       cmp       edi,5
       ja        near ptr M06_L09
       jmp       short M06_L01
M06_L03:
       cmp       edi,5
       ja        near ptr M06_L12
       mov       eax,edi
       lea       rcx,[7FFE191EAFF0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE18694180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       rsi,0C
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],rsi
       mov       [rsp+30],ebp
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6208]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE183C539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,15F570003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M06_L11
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,ebp
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       mov       r9d,edi
       and       r9d,1
       call      qword ptr [7FFE188F6208]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M06_L05
       cmp       ebp,1
       je        near ptr M06_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE18535068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE188DD6C8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M06_L07
M06_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L06:
       call      qword ptr [7FFE188DD698]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
M06_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L08:
       mov       ecx,2E5
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE187166E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE186EECB8]
       int       3
M06_L10:
       mov       rcx,7FFE183C5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE186EED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A55338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE18334000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE1848F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M07_L00:
       ret
M07_L01:
       test      r8b,4
       je        short M07_L05
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L00
M07_L02:
       cmp       r8,40
       ja        short M07_L06
M07_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L10
M07_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L00
M07_L05:
       test      r8,r8
       je        short M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M07_L00
M07_L06:
       cmp       r8,800
       ja        short M07_L09
       mov       r9,r8
       shr       r9,6
M07_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L07
       and       r8,3F
       cmp       r8,10
       ja        short M07_L03
       jmp       short M07_L04
M07_L08:
       cmp       rcx,rdx
       je        near ptr M07_L00
M07_L09:
       jmp       qword ptr [7FFE18535B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M07_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M07_L04
; Total bytes of code 259
```
```assembly
; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       sub       rsp,28
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M10_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M10_L02
       test      rbx,rbx
       je        short M10_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M10_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M10_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M10_L02:
       test      rbx,rbx
       je        short M10_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M10_L04
M10_L03:
       mov       rax,19FE8FD0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Object.GetType()
System.String.FastAllocateString(Int32)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TestingForNull02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 65
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
       call      qword ptr [7FFE189B6100]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       [rsp+30],rax
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FFE18975848]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
       mov       rcx,[rax+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 90
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rax,164BA80F648
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,164BA80F648
       xor       edx,edx
       jmp       qword ptr [7FFE189B67D8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rsp
       test      rcx,rcx
       je        near ptr M02_L10
       mov       [rbp-28],rcx
       mov       rbx,[rdx]
       test      rbx,rbx
       je        near ptr M02_L08
M02_L00:
       cmp       byte ptr [rbx+9E],0
       je        near ptr M02_L07
M02_L01:
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M02_L06
M02_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M02_L05
M02_L03:
       lea       rdx,[rbp-28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18CAEE50]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag`1[[System.Exception, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal`1[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.Exception, System.Private.CoreLib]], System.Collections.Concurrent]]
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal`1+LinkedSlot[[System.Collections.Concurrent.ConcurrentBag`1+WorkStealingQueue[[System.Exception, System.Private.CoreLib]], System.Collections.Concurrent]]
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,164BA801FB0
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFE18F47E70]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
       mov       ecx,eax
       not       ecx
       mov       [r14+18],ecx
       mov       byte ptr [r14+1C],1
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
       xor       ecx,ecx
       test      rdx,rdx
       setne     cl
       test      ecx,ecx
       je        short M02_L04
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+18],1
       mov       [rbp-38],rsi
       jmp       near ptr M02_L09
M02_L04:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,17BE
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CEC
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       call      qword ptr [7FFE184943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L06:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,1A54C6E2D10
       mov       r8d,1
       call      qword ptr [7FFE189B5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE189B6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L01
M02_L08:
       call      qword ptr [7FFE189B6100]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       jmp       near ptr M02_L00
M02_L09:
       mov       rax,[rbp-38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L10:
       call      qword ptr [7FFE18A14CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18825148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1896AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18496B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A14AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+70]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.SimpleResult.FromException[[System.String, System.Private.CoreLib]](System.Exception)
       call      qword ptr [7FFE18F47000]
       mov       [rbp-38],rax
       lea       rax,[M02_L09]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 797
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       test      rcx,rcx
       je        near ptr M00_L03
       mov       [rsp+30],rcx
       mov       rcx,1BC10C0CBA0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE189A6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9F120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 316
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE189A7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE18A0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M01_L03
       jmp       near ptr M01_L09
M01_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L03:
       call      qword ptr [7FFE189A6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE18A0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18A0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M01_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L07
M01_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M01_L08:
       cmp       dword ptr [rbp-34],0
       je        short M01_L09
       call      qword ptr [7FFE189AC978]
M01_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,1FCA2A42D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M02_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M03_L12
M03_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M03_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,1BC14C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE18C80F10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M03_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M03_L02
M03_L01:
       mov       edx,2
M03_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M03_L13
       mov       rdi,1FCA2A41C08
M03_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M03_L14
M03_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE18A0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M03_L08
       cmp       [rcx+8],r15d
       jb        short M03_L07
M03_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M03_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M03_L06:
       cmp       r15d,r12d
       ja        short M03_L07
       mov       r12d,r15d
       jmp       short M03_L10
M03_L07:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L08:
       test      r15d,r15d
       jne       short M03_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M03_L05
M03_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M03_L06
M03_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE18A0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M03_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE18D569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE189D3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1BC10C0D690
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE18C9FD20]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE18D564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE18D540D8]
       mov       r14,r13
       jmp       near ptr M03_L04
M03_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L19
M03_L18:
       mov       rax,[rcx]
       add       rax,10
M03_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M03_L20
       test      r10d,r10d
       jne       short M03_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M03_L23
M03_L20:
       cmp       [rcx+8],r10d
       jae       short M03_L22
M03_L21:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L22:
       add       rcx,10
M03_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M03_L25
       cmp       rdx,300
       ja        short M03_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE18535BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1BC14C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE18C80F18]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
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
; Total bytes of code 1178
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,[rdx]
M04_L00:
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       je        short M04_L02
       jmp       short M04_L00
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       jmp       qword ptr [7FFE184843A8]
; Total bytes of code 71
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M05_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M05_L02
       test      rbx,rbx
       je        short M05_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M05_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M05_L02:
       test      rbx,rbx
       je        short M05_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M05_L04
M05_L03:
       mov       rax,1FCA2A40008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        near ptr M00_L03
       mov       [rsp+30],rcx
       mov       rcx,157D4C0CBA0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE189A6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE189A6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE18C9EDF0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+28],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M00_L02:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE184843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE18A04CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18815148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1895AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18486B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A04AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18716670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 316
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       push      rbp
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L01:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp+10],rcx
       call      qword ptr [7FFE189A7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE18A0D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-28],rax
       cmp       qword ptr [rbp-28],0
       jne       short M01_L03
       jmp       near ptr M01_L09
M01_L02:
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+20]
       mov       rdx,[rbp-18]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L09
M01_L03:
       call      qword ptr [7FFE189A6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FFE18A0D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FFE18A0D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE18A0D920]
       mov       rcx,[rbp-60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M01_L09
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18A0D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE18484360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L07
M01_L06:
       mov       dword ptr [rbp-34],1
       jmp       short M01_L08
M01_L07:
       xor       eax,eax
       mov       [rbp-34],eax
M01_L08:
       cmp       dword ptr [rbp-34],0
       je        short M01_L09
       call      qword ptr [7FFE189AC978]
M01_L09:
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9D],1
       mov       rax,[rbp+10]
       mov       byte ptr [rax+9E],1
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rax,[rbx+18]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M02_L01:
       mov       byte ptr [rsp+30],1
       mov       byte ptr [rsp+31],1
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       movzx     r9d,word ptr [rsp+30]
       mov       rdx,19866B52D10
       mov       r8d,1
       call      qword ptr [7FFE189A5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M02_L00
; Total bytes of code 96
```
```assembly
; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       vzeroupper
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-98],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-90],xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-0A0],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,[rbx+0B0]
       lea       rdx,[rbp-48]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE189A67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L11
       mov       rax,[rcx]
       add       rax,10
       mov       r14,[rax]
       test      r14,r14
       je        near ptr M03_L12
M03_L00:
       mov       ecx,[r14+18]
       lea       edx,[rcx+1]
       mov       [r14+18],edx
       test      ecx,ecx
       jne       near ptr M03_L15
       mov       rcx,[r14+8]
       mov       [rbp-90],rcx
       mov       r14,[r14+10]
       mov       rcx,[rbp-90]
       cmp       [rcx],cl
       mov       rcx,157D8C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE18C80F10]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       rcx,[rbp-90]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-90]
       xor       edx,edx
       mov       [rcx+20],edx
       lea       rcx,[r14+8]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,[rbp-3C]
       lea       rcx,[r14+68]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-40]
       mov       [r14+70],ecx
       mov       ecx,[rbp-3C]
       mov       [r14+74],ecx
       mov       ecx,9
       mov       edx,20
       test      byte ptr [r14+74],8
       cmove     ecx,edx
       mov       [r14+3B],cl
       mov       ecx,edi
       and       ecx,7F0
       sar       ecx,4
       je        short M03_L01
       xor       edx,edx
       cmp       ecx,2
       cmovne    edx,ecx
       jmp       short M03_L02
M03_L01:
       mov       edx,2
M03_L02:
       mov       [r14+2C],edx
       test      dil,4
       jne       near ptr M03_L13
       mov       rdi,19866B51C08
M03_L03:
       mov       ecx,[rdi+8]
       mov       [r14+30],ecx
       cmp       dword ptr [r14+70],0
       je        near ptr M03_L14
M03_L04:
       mov       [rbp-88],r14
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE18A0CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rax,[rbp-90]
       mov       r15d,[rax+20]
       test      rcx,rcx
       je        short M03_L08
       cmp       [rcx+8],r15d
       jb        short M03_L07
M03_L05:
       xor       r13d,r13d
       xor       r12d,r12d
       test      rcx,rcx
       je        short M03_L10
       mov       rax,[rcx]
       test      dword ptr [rax],80000000
       je        short M03_L09
       lea       r13,[rcx+10]
       mov       r12d,[rcx+8]
M03_L06:
       cmp       r15d,r12d
       ja        short M03_L07
       mov       r12d,r15d
       jmp       short M03_L10
M03_L07:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L08:
       test      r15d,r15d
       jne       short M03_L07
       xor       ecx,ecx
       xor       r15d,r15d
       jmp       short M03_L05
M03_L09:
       lea       rdx,[rbp-58]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r13,[rbp-58]
       mov       r12d,[rbp-50]
       jmp       short M03_L06
M03_L10:
       mov       rcx,r13
       mov       [rbp-80],rcx
       mov       [rbp-78],r12d
       lea       rcx,[rbp-80]
       call      qword ptr [7FFE18A0E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-98],rax
       mov       rcx,rsp
       call      M03_L16
       nop
       mov       rax,[rbp-98]
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L11:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE18D569E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE189D3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,157D4C0D690
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE18C9F9F0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE18D564F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE18D540D8]
       mov       r14,r13
       jmp       near ptr M03_L04
M03_L16:
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0C0]
       mov       r14,[rbp-90]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L19
M03_L18:
       mov       rax,[rcx]
       add       rax,10
M03_L19:
       mov       r15,[rax]
       xor       ecx,ecx
       mov       r12,[rbp-88]
       mov       [r12+34],ecx
       mov       [r12+20],rcx
       mov       [r12+40],rcx
       mov       [r12+48],rcx
       mov       byte ptr [r12+38],0
       mov       byte ptr [r12+3A],0
       mov       byte ptr [r12+39],0
       mov       [r12+28],ecx
       mov       [r12+50],rcx
       mov       [r12+58],rcx
       mov       [r12+60],rcx
       mov       [r12+10],rcx
       mov       [r12+18],rcx
       mov       [r12+8],rcx
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+10]
       mov       rdx,[rbp-90]
       mov       r10d,[rdx+20]
       test      rcx,rcx
       jne       short M03_L20
       test      r10d,r10d
       jne       short M03_L21
       xor       ecx,ecx
       xor       r10d,r10d
       jmp       short M03_L23
M03_L20:
       cmp       [rcx+8],r10d
       jae       short M03_L22
M03_L21:
       call      qword ptr [7FFE186EE9D0]
       int       3
M03_L22:
       add       rcx,10
M03_L23:
       mov       edx,r10d
       mov       [rbp-60],rdx
       test      rdx,rdx
       je        short M03_L25
       cmp       rdx,300
       ja        short M03_L24
       xor       edx,edx
       mov       r8d,[rbp-60]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L25
M03_L24:
       mov       rdx,[rbp-60]
       call      qword ptr [7FFE18535BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,157D8C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE18C80F18]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [r15+18]
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
; Total bytes of code 1178
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M04_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       je        short M04_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L01
       test      rax,rax
       jne       short M04_L00
M04_L03:
       jmp       qword ptr [7FFE184843A8]
; Total bytes of code 69
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M05_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M05_L02
       test      rbx,rbx
       je        short M05_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M05_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M05_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18535B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L01:
       call      qword ptr [7FFE186EEF40]
       int       3
M05_L02:
       test      rbx,rbx
       je        short M05_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M05_L04
M05_L03:
       mov       rax,19866B50008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18F46700]; System.Data.DataTable..ctor()
       mov       rcx,292297053E8
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE18975890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
; Total bytes of code 62
```
```assembly
; System.Data.DataTable..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       lea       rcx,[rbx+70]
       mov       rsi,292296F0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,29229705488
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,29229705560
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,25197801FB8
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25197801FC0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25197801FC8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+188]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FFE183D5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFE18F3AB98
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFE1874C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,25197812418
       mov       rcx,[rcx]
       mov       rsi,rcx
       mov       edi,[rbx+1C0]
       cmp       byte ptr [rcx+9D],0
       je        short M01_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       mov       rdx,29229705408
       call      qword ptr [7FFE18496C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE185476D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F4EC40]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE186A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F4D008]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,25197801E58
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+28],1
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+38]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataRowCollection+DataRowTree
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+30],2
       mov       rcx,rdi
       call      qword ptr [7FFE18F4DD88]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.Index, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25197801FE0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+58]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRowBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+10],0FFFFFFFF
       lea       rcx,[rbx+178]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 928
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-18],rax
       mov       [rbp-30],rsp
       mov       [rbp+18],edx
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L05
       mov       rdx,rbx
       mov       rcx,offset MT_System.IAsyncDisposable
       call      qword ptr [7FFE18494348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE18F3C898]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L04
M02_L00:
       call      qword ptr [7FFE18F96AC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L01
       call      qword ptr [7FFE18A14C48]
       mov       rbx,rax
M02_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18726718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFE18350DD0
       call      qword ptr [r11]
       jmp       short M02_L04
M02_L03:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFE18350DD8
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE18F965E0]
       test      eax,eax
       jne       short M02_L00
M02_L04:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L05:
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
       cmp       byte ptr [rbp+18],0
       je        short M02_L06
       call      CORINFO_HELP_RETHROW
M02_L06:
       lea       rax,[M02_L04]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 279
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FastGetHashCode()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+20],1
       mov       dword ptr [rsp+24],1
       mov       ecx,0F
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFE18985D70]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       test      rax,rax
       je        short M00_L00
       mov       rcx,rax
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       rcx,[rbx+18]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       call      qword ptr [7FFE18A24CF0]
       mov       ecx,7DD
       mov       rdx,7FFE1897AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18835148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE184A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE1897AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE184A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A24AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE18736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 225
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp-60],rsp
       mov       ebx,ecx
       mov       edi,edx
       mov       esi,r8d
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],1
       xor       ecx,ecx
       xor       r8d,r8d
       cmp       ebx,7FFFFFFF
       setle     r8b
       test      ebx,ebx
       cmovg     ecx,r8d
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L20
M01_L00:
       test      eax,eax
       je        near ptr M01_L21
M01_L01:
       mov       rcx,2093C40B1D0
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        short M01_L04
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       short M01_L04
M01_L02:
       mov       r14,[rbp-48]
M01_L03:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r14,r14
       je        near ptr M01_L23
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFE187AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FFE187AC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r14
       jmp       short M01_L06
M01_L04:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C8ED00]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L24
M01_L05:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       short M01_L02
M01_L06:
       xor       r12d,r12d
       test      ebx,ebx
       jle       short M01_L10
       movzx     r15d,di
       mov       r13d,r15d
       add       r13d,1
       jo        near ptr M01_L13
M01_L07:
       movzx     edx,si
       mov       eax,r13d
       cmp       edx,eax
       jl        short M01_L11
M01_L08:
       mov       ecx,r15d
       call      qword ptr [7FFE189C5E78]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L13
       mov       edx,eax
       mov       ecx,[r14+18]
       mov       eax,ecx
       mov       r8,[r14+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L12
       mov       eax,eax
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r14+18],ecx
M01_L09:
       add       r12d,1
       jo        short M01_L13
       cmp       r12d,ebx
       jl        short M01_L07
M01_L10:
       mov       rcx,r14
       call      qword ptr [7FFE187B7A60]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       mov       esi,[r15+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L14
       jmp       short M01_L16
M01_L11:
       mov       edx,eax
       jmp       short M01_L08
M01_L12:
       mov       rcx,r14
       call      qword ptr [7FFE187AC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L09
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFE184A73F0]
       jmp       short M01_L19
M01_L15:
       call      qword ptr [7FFE18E55B18]
       test      eax,eax
       jne       short M01_L14
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L14
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FFE18E55B18]
       test      eax,eax
       jne       short M01_L14
M01_L18:
       mov       rax,r15
M01_L19:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M01_L27
       nop
       mov       rax,[rbp-58]
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE185547B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L21:
       call      qword ptr [7FFE18A24CD8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L22
       call      qword ptr [7FFE18A24AF8]
       mov       rsi,rax
M01_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,249CE1286E0
       mov       r8,rsi
       call      qword ptr [7FFE1855D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L23:
       call      qword ptr [7FFE18A24CF0]
       mov       ecx,9B8
       mov       rdx,7FFE1897AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,146C
       mov       rdx,7FFE18835148
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE184A6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE1897AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE184A6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A24AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE18736670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L24:
       cmp       qword ptr [r13+10],0
       jne       short M01_L25
       xor       edx,edx
       mov       [rbp-48],rdx
       jmp       short M01_L26
M01_L25:
       lea       rdx,[rbp-48]
       mov       rcx,r15
       call      qword ptr [7FFE18C8E820]
       test      eax,eax
       jne       near ptr M01_L05
M01_L26:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L03
M01_L27:
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
       lea       rbp,[rbp+80]
       mov       rcx,2093C40B1D0
       mov       rsi,[rcx]
       mov       r14,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r14+18],rcx
       jne       short M01_L28
       mov       r15,[rbp-50]
       mov       rcx,[r15+8]
       mov       ecx,[rcx+8]
       add       ecx,[r15+1C]
       mov       rdx,[r14+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L32
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFE187AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L29
M01_L28:
       mov       rdx,[rbp-50]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       r15,[rbp-50]
       je        short M01_L32
M01_L29:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L30
       lea       rcx,[rsi+20]
       mov       rdx,r15
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L32
M01_L30:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L31
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE18C8ED30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L32
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFE18C8E7F0]
       jmp       short M01_L32
M01_L31:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L32:
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
; Total bytes of code 1052
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M02_L02
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M02_L02
       test      rbx,rbx
       je        short M02_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        short M02_L00
       mov       r14d,edi
       lea       ecx,[r14+rbp]
       test      ecx,ecx
       jl        short M02_L01
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE18555B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE18555B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L01:
       call      qword ptr [7FFE1870EF40]
       int       3
M02_L02:
       test      rbx,rbx
       je        short M02_L03
       mov       ebp,[rbx+8]
       xor       eax,eax
       test      ebp,ebp
       sete      al
       test      eax,eax
       je        short M02_L04
M02_L03:
       mov       rax,249CE120008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L04:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 209
```
**Extern method**
System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+118]
       test      rcx,rcx
       je        short M00_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        short M00_L02
       cmp       [rcx],ecx
       call      qword ptr [7FFE18497318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE18F85A70]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+20],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L02:
       call      qword ptr [7FFE18A14D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FFE18A14AE0]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2199CC053E8
       mov       r8,rbx
       call      qword ptr [7FFE18726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 193
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M01_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M01_L00
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE18E45308]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE773C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE18E45308]
       test      eax,eax
       jne       short M01_L04
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFE184973F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rcx,rbx
       test      rcx,rcx
       je        short M02_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M02_L01
       jmp       short M02_L01
M02_L00:
       xor       edx,edx
M02_L01:
       test      edx,edx
       je        near ptr M02_L10
       cmp       [rcx],ecx
       call      qword ptr [7FFE18497318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
M02_L02:
       mov       r8,1D90AC0BA88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE18F85AD0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M02_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFE18F739D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L02
M02_L04:
       lea       rcx,[rsp+28]
       mov       rdx,2199CC05608
       call      qword ptr [7FFE186858F0]
M02_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE188E4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M02_L07
M02_L06:
       call      qword ptr [7FFE186FE9D0]
       int       3
M02_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M02_L08
       mov       rdx,2199CBF0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsp+28]
       mov       rdx,2199CBF0C48
       call      qword ptr [7FFE186858F0]
M02_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE18685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18726718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L10:
       call      qword ptr [7FFE18A14D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L11
       call      qword ptr [7FFE18A14AE0]
       mov       rsi,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2199CC053E8
       mov       r8,rsi
       call      qword ptr [7FFE18726670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE186856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M02_L06
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        near ptr M02_L04
       mov       rcx,2199CC05614
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       near ptr M02_L05
; Total bytes of code 551
```

## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.InitializeFields()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-80],rsp
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Data.DataSet
       call      CORINFO_HELP_NEWFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFE18F553E0]; System.Data.DataSet..ctor()
       mov       rcx,1B5BA812418
       mov       rcx,[rcx]
       mov       r14,rcx
       mov       r15d,[rdi+94]
       cmp       byte ptr [rcx+9D],0
       je        short M00_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],r15d
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-40],xmm0
       mov       [rbp-40],rax
       mov       r8,1F64C895410
       mov       [rbp-38],r8
       lea       r8,[rbp-40]
       mov       [rbp-70],r8
       mov       dword ptr [rbp-68],2
       lea       r8,[rbp-70]
       xor       ecx,ecx
       mov       rdx,1F64C8955A8
       call      qword ptr [7FFE18466C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFE185176D8]
M00_L00:
       mov       rcx,[rdi+38]
       test      rcx,rcx
       je        short M00_L01
       cmp       dword ptr [rcx+8],4
       jne       short M00_L01
       mov       r8,54005300450054
       cmp       [rcx+0C],r8
       je        near ptr M00_L05
M00_L01:
       mov       r14,[rdi+20]
       mov       r8,[rdi+48]
       cmp       [r14],r14b
       test      r8,r8
       je        near ptr M00_L27
       mov       rcx,r14
       mov       rdx,1F64C895410
       call      qword ptr [7FFE18F56C58]; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
       cmp       eax,0FFFFFFFE
       je        near ptr M00_L28
       test      eax,eax
       jge       near ptr M00_L29
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       jne       near ptr M00_L30
M00_L03:
       mov       rcx,offset MT_System.ComponentModel.PropertyChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1F64C895578
       mov       [rax+8],rcx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L31
M00_L04:
       mov       rcx,1F64C895410
       mov       [rdi+38],rcx
M00_L05:
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       [rbp-78],rcx
       mov       r13,rcx
       mov       rcx,r13
       call      System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        short M00_L08
       mov       r14,[rcx]
       test      r14,r14
       je        short M00_L08
M00_L06:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rsi,[r15]
       test      rsi,rsi
       jne       short M00_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,rdi
M00_L07:
       mov       rcx,rsi
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        short M00_L09
       mov       rsi,[rcx+8]
       jmp       short M00_L10
M00_L08:
       mov       rcx,rax
       call      qword ptr [7FFE183B6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M00_L06
M00_L09:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE18744E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
M00_L10:
       mov       edi,[rsi+8]
       mov       ecx,edi
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],ecx
       xor       r14d,r14d
       test      edi,edi
       jle       short M00_L13
M00_L11:
       mov       ecx,r14d
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,36
       cmp       edx,ecx
       jne       short M00_L12
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE18744BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L12:
       inc       r14d
       cmp       edi,r14d
       jg        short M00_L11
M00_L13:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r14d,[rbp-48]
       test      r14d,r14d
       je        near ptr M00_L20
       cmp       r14d,1
       je        near ptr M00_L19
       test      r14d,r14d
       jl        near ptr M00_L18
       mov       rdi,rsi
       test      rdi,rdi
       je        short M00_L17
       cmp       [rsi+8],r14d
       jne       short M00_L16
M00_L14:
       xor       edi,edi
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L15:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M00_L22
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FFE18796530]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       jmp       near ptr M00_L23
M00_L16:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rdx,[rsi+10]
       lea       r8,[rdi+10]
       mov       r9d,[rdi+8]
       cmp       r14d,r9d
       cmovg     r14d,r9d
       mov       r9d,r14d
       mov       rcx,offset MD_System.Buffer.Memmove[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Reflection.FieldInfo ByRef, System.Reflection.FieldInfo ByRef, UIntPtr)
       call      qword ptr [7FFE18745938]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       jmp       short M00_L14
M00_L17:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M00_L14
M00_L18:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE186CED48]
       int       3
M00_L19:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L14
M00_L20:
       mov       rcx,1B5BA801EE0
       mov       rsi,[rcx]
       jmp       near ptr M00_L14
M00_L21:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M00_L24
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FFE186F6028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFE187644B0]
       jmp       short M00_L24
M00_L22:
       mov       rcx,r14
       mov       rdx,r13
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
M00_L23:
       test      rax,rax
       je        short M00_L21
M00_L24:
       inc       edi
       cmp       [rsi+8],edi
       jg        near ptr M00_L15
M00_L25:
       mov       rcx,[rbp-78]
       mov       [rbp-60],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rbp-60]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields, DotNetTips.Spargine.Extensions.BenchmarkTests]](DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F5D4E8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L26
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F64070]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L26:
       call      qword ptr [7FFE1871C2E8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L27:
       mov       ecx,0C0E8
       mov       rdx,7FFE18F60250
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F5ED30]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L28:
       mov       ecx,8F
       mov       rdx,7FFE187F3398
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18F5EDF0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L29:
       mov       rcx,[r14+10]
       mov       edx,eax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      qword ptr [7FFE184643D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L30:
       cmp       byte ptr [r15+1C4],0
       jne       near ptr M00_L03
       mov       ecx,8F
       mov       rdx,7FFE187F3398
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE18FB41B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L31:
       mov       rdx,rdi
       mov       r8,rax
       mov       rcx,[r10+8]
       call      qword ptr [r10+18]
       jmp       near ptr M00_L04
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L32
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE18F64070]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L32:
       call      qword ptr [7FFE1871C2E8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1380
```
```assembly
; System.Data.DataSet..ctor()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,1F64C895430
       mov       [rbx+38],rcx
       lea       rcx,[rbx+40]
       mov       rsi,1F64C880008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+48]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+98],1
       mov       byte ptr [rbx+9F],1
       lea       rcx,[rbx+58]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+60]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE18F62374
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,rbx
       call      qword ptr [7FFE1871C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1B5BA812418
       mov       rcx,[rcx]
       mov       rsi,rcx
       mov       edi,[rbx+94]
       cmp       byte ptr [rcx+9D],0
       je        short M01_L00
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],edi
       mov       [rsp+38],rax
       lea       r8,[rsp+38]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],1
       lea       r8,[rsp+28]
       xor       ecx,ecx
       mov       rdx,1F64C895460
       call      qword ptr [7FFE18466C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE185176D8]
M01_L00:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F568F8]; System.Data.DataTableCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE18F56808]; System.Data.DataRelationCollection+DataSetRelationCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE18674180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+50]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 387
```
```assembly
; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+8],rax
       xorps     xmm4,xmm4
       movaps    [rbp+10],xmm4
       mov       [rbp+20],rax
       mov       rax,[7FFE77E13CD8]
       mov       [rbp],rax
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rsi,rsi
       je        near ptr M02_L03
       test      [rsp],esp
       sub       rsp,200
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+8],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp+20],100
       mov       [rbp+10],ecx
       mov       edx,[rsi+8]
       mov       ecx,[rbx+8]
       lea       edx,[rdx+rcx*8]
       cmp       edx,[rbp+20]
       ja        short M02_L02
M02_L00:
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [7FFE77E2AC68]
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE77E2AC80]; Precode of System.Text.ValueStringBuilder.ToString()
       lea       rcx,[7FFE77E13CD8]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M02_L01
       call      qword ptr [7FFE77E13D28]; CORINFO_HELP_FAIL_FAST
M02_L01:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L02:
       sub       edx,[rbp+10]
       lea       rcx,[rbp+8]
       call      qword ptr [7FFE77E2ACC8]
       jmp       short M02_L00
M02_L03:
       mov       rcx,[7FFE77E40A08]
       mov       rcx,[rcx]
       call      qword ptr [7FFE77E23938]
       int       3
; Total bytes of code 201
```
```assembly
; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,0FFFFFFFF
       test      rbx,rbx
       je        short M03_L00
       cmp       dword ptr [rbx+8],0
       jle       short M03_L00
       mov       rcx,[rsi+10]
       mov       rax,offset MT_System.Collections.ArrayList
       cmp       [rcx],rax
       jne       short M03_L01
       mov       r14d,[rcx+10]
       xor       r15d,r15d
       test      r14d,r14d
       jg        short M03_L02
M03_L00:
       mov       eax,ebp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14d,eax
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M03_L00
M03_L02:
       mov       rcx,[rsi+10]
       mov       edx,r15d
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      qword ptr [7FFE184643D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       r9,[rsi+8]
       mov       r9,[r9+50]
       mov       rcx,[r13+70]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE18F56448]
       mov       r12d,eax
       cmp       r12d,1
       jne       short M03_L03
       mov       rcx,r13
       call      qword ptr [7FFE18F57C00]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE184661C0]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M03_L03
       mov       eax,r15d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L03:
       cmp       r12d,0FFFFFFFF
       jne       short M03_L05
       mov       rcx,r13
       call      qword ptr [7FFE18F57C00]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE184661C0]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M03_L05
       cmp       ebp,0FFFFFFFF
       je        short M03_L04
       mov       ebp,0FFFFFFFE
       jmp       short M03_L05
M03_L04:
       mov       ebp,r15d
M03_L05:
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M03_L02
       jmp       near ptr M03_L00
; Total bytes of code 292
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       xor       edx,edx
       mov       [rbp-58],rdx
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rdx
       mov       rbx,rcx
       lea       rcx,[rbp-0C8]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0A8],rcx
       mov       rcx,rbp
       mov       [rbp-98],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M04_L07
M04_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M04_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M04_L14
M04_L01:
       test      rdi,rdi
       jne       near ptr M04_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-80],rdi
       xor       ecx,ecx
       mov       [rdi+90],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r14,rax
       mov       [rbp-88],r14
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M04_L04
       mov       [rbp-58],r14
       xor       ecx,ecx
       mov       [rbp-50],rcx
       lea       rcx,[rbp-58]
       mov       rdx,[rbp-58]
       mov       rdx,[rdx+20]
       lea       rax,[rbp-50]
       mov       [rbp-78],rcx
       mov       [rbp-70],rdx
       lea       rcx,[rbp-78]
       mov       rdx,rax
       mov       rax,offset MD_System.ModuleHandle.GetModuleType(System.Runtime.CompilerServices.QCallModule, System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp-0B8],rax
       lea       rax,[M04_L02]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFE77F23A30
       call      rax
M04_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE783340DC],0
       je        short M04_L03
       call      qword ptr [7FFE783243A8]; CORINFO_HELP_STOP_FOR_GC
M04_L03:
       mov       rcx,[rbp-0C0]
       mov       [rsi+10],rcx
       mov       rsi,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       r14,[rbp-88]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M04_L04:
       mov       rbx,[rbp+10]
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-80]
       mov       [rdi+94],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Runtime.InteropServices.GCHandle.InternalCompareExchange(IntPtr, System.Object, System.Object)
       mov       rdx,rax
       mov       rax,rdx
       test      rax,rax
       je        short M04_L05
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rax],rcx
       jne       near ptr M04_L15
M04_L05:
       test      rax,rax
       cmovne    rdi,rax
M04_L06:
       mov       rax,rdi
       jmp       near ptr M04_L12
M04_L07:
       mov       [rbp+10],rbx
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE18465440]; System.RuntimeTypeHandle.GetNativeHandle()
       mov       [rbp-48],rax
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-48]
       test      rdx,rdx
       je        near ptr M04_L11
       mov       rax,[rdx+18]
M04_L08:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       lea       rcx,[rbp-68]
       mov       edx,1
       mov       rax,offset MD_System.RuntimeTypeHandle.GetGCHandle(System.Runtime.CompilerServices.QCallTypeHandle, System.Runtime.InteropServices.GCHandleType)
       mov       [rbp-0B8],rax
       lea       rax,[M04_L09]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFE77EAA870
       call      rax
M04_L09:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE783340DC],0
       je        short M04_L10
       call      qword ptr [7FFE783243A8]; CORINFO_HELP_STOP_FOR_GC
M04_L10:
       mov       rcx,[rbp-0C0]
       mov       [rsi+10],rcx
       mov       rdx,rax
       mov       rbx,[rbp+10]
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       jne       short M04_L13
       jmp       near ptr M04_L00
M04_L11:
       xor       eax,eax
       jmp       near ptr M04_L08
M04_L12:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L13:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE18465998]
       jmp       near ptr M04_L00
M04_L14:
       call      qword ptr [7FFE184643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M04_L15:
       call      qword ptr [7FFE184643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 691
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+10],xmm4
       xor       eax,eax
       mov       [rbp+20],rax
       mov       rax,448016AB92B6
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M05_L00
       cmp       dword ptr [rbx+8],0
       jne       short M05_L03
M05_L00:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE18744EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M05_L01:
       lea       rdx,[rbp+20]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE18744EB8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+20]
       mov       rcx,448016AB92B6
       cmp       [rbp+8],rcx
       je        short M05_L02
       call      CORINFO_HELP_FAIL_FAST
M05_L02:
       nop
       lea       rsp,[rbp+28]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L03:
       cmp       r14d,1
       je        near ptr M05_L08
M05_L04:
       mov       r15d,[rbx+8]
       lea       rcx,[rbx+0C]
       mov       [rbp+18],rcx
       mov       r13,[rbp+18]
       mov       rcx,1B5BA8009F0
       mov       rcx,[rcx]
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE186B9E28]; Precode of System.Text.UTF8Encoding.GetByteCount(Char*, Int32)
       mov       r12d,eax
       cmp       r12d,400
       jg        near ptr M05_L09
       mov       ecx,r12d
       mov       r9,rcx
       test      r9,r9
       je        short M05_L06
       mov       rdx,r9
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,40
       neg       rdx
       add       rdx,rsp
       jb        short M05_L05
       xor       edx,edx
M05_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M05_L05
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,40
       lea       r9,[rsp+40]
M05_L06:
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE18744EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M05_L07:
       xor       edx,edx
       mov       [rbp+18],rdx
       jmp       near ptr M05_L01
M05_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M05_L04
       cmp       word ptr [rbx+0C],2A
       je        near ptr M05_L04
       jmp       near ptr M05_L00
M05_L09:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       dword ptr [rax+8],0
       jbe       short M05_L10
       add       rax,10
       mov       [rbp+10],rax
       mov       rdx,r13
       mov       r8d,r15d
       mov       r9,[rbp+10]
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       call      qword ptr [7FFE18744EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
       xor       eax,eax
       mov       [rbp+10],rax
       jmp       short M05_L07
M05_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 458
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       mov       edi,[rbx+10]
       test      edi,edi
       jne       short M06_L00
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M06_L04
M06_L00:
       cmp       edi,1
       jne       near ptr M06_L07
       cmp       dword ptr [rbx+14],2
       jl        short M06_L02
M06_L01:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],30
       jle       short M06_L05
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M06_L05
       mov       [rsp+20],rdx
       jmp       short M06_L06
M06_L02:
       mov       dword ptr [rbx+14],4
       jmp       short M06_L01
M06_L03:
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
M06_L04:
       inc       dword ptr [rbx+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L05:
       mov       rdx,7FFE18DDF9D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M06_L06:
       movsxd    rdx,dword ptr [rbx+14]
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx]
       mov       r8,[rbx+8]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M06_L03
M06_L07:
       cmp       [rbx+14],edi
       jne       short M06_L03
       mov       edi,[rbx+14]
       add       edi,edi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M06_L08
       mov       rcx,rax
       jmp       short M06_L09
M06_L08:
       mov       rdx,7FFE18DDF928
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M06_L09:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FFE18745908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],edi
       jmp       near ptr M06_L03
; Total bytes of code 252
```
```assembly
; System.Reflection.RtFieldInfo.GetValue(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       test      byte ptr [rbx+38],1
       je        near ptr M07_L08
       mov       eax,[rbx+38]
M07_L00:
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M07_L13
       mov       rdi,[rbx+10]
M07_L01:
       test      rdi,rdi
       je        short M07_L02
       mov       rcx,offset MT_System.RuntimeType
       xor       edx,edx
       cmp       [rdi],rcx
       cmovne    rdi,rdx
M07_L02:
       test      al,2
       jne       near ptr M07_L12
       test      byte ptr [rbx+1C],10
       jne       short M07_L03
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M07_L15
M07_L03:
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M07_L09
M07_L04:
       mov       rbp,rdx
       test      rbp,rbp
       je        short M07_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M07_L17
M07_L05:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       test      rdi,rdi
       je        near ptr M07_L18
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M07_L10
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L10
M07_L06:
       movzx     ecx,byte ptr [rax+95]
       mov       [rsp+28],ecx
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       mov       r9,rdi
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       rsi,rax
       movzx     ebx,byte ptr [rsp+28]
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M07_L11
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L11
M07_L07:
       mov       [rax+95],bl
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE187871F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE187873C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M07_L04
M07_L10:
       mov       rcx,rdi
       call      qword ptr [7FFE183B6658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L06
M07_L11:
       mov       rcx,rdi
       call      qword ptr [7FFE183B6658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L07
M07_L12:
       test      rdi,rdi
       je        short M07_L14
       mov       rcx,rbx
       call      qword ptr [7FFE1875F250]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M07_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE18A1DC08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE186F6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M07_L13:
       xor       edi,edi
       jmp       near ptr M07_L01
M07_L14:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE18907EB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L15:
       test      rsi,rsi
       jne       short M07_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE18A36028]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE1874DB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L16:
       call      qword ptr [7FFE18A1CE70]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE187964E0]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FFE18A1C780]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE1846F708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M07_L17:
       call      qword ptr [7FFE184643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M07_L18:
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rbp
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 625
```
```assembly
; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,r8
       mov       rdi,r9
       mov       rcx,7FFE18E0EF2C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       r8,[rdi*8]
       cmp       r8,4000
       ja        short M08_L00
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M08_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE18515BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 85
```
```assembly
; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       mov       esi,r8d
       test      rcx,rcx
       je        short M09_L02
       mov       r11,[7FFE77E3C048]
       cmp       r11,[rcx]
       jne       short M09_L00
       jmp       short M09_L01
M09_L00:
       lea       r11,[7FFE77E11140]
       call      qword ptr [r11]
       mov       rcx,rax
M09_L01:
       call      qword ptr [7FFE77E1EF00]
       test      rax,rax
       je        short M09_L03
       xor       edx,edx
       test      bl,bl
       sete      dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[7FFE77E22FE0]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M09_L02:
       mov       rcx,[7FFE77E409E8]
       mov       rcx,[rcx]
       call      qword ptr [7FFE77E23938]
       int       3
M09_L03:
       call      qword ptr [7FFE77E1BF98]
       mov       rbx,rax
       call      qword ptr [7FFE77E252B8]
       mov       rdx,rax
       mov       r8,[7FFE77E409E8]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFE77E238E8]
       mov       rcx,rbx
       call      qword ptr [7FFE77E13D08]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 148
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rbx
       mov       rbx,rcx
       mov       rdx,[r8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       pop       rbx
       ret
; Total bytes of code 24
```
```assembly
; System.ComponentModel.MarshalByValueComponent.Dispose()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       mov       edx,1
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE1871C2E8]; System.GC.SuppressFinalize(System.Object)
; Total bytes of code 40
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M12_L00
       add       rsp,28
       jmp       near ptr System.GC._SuppressFinalize(System.Object)
M12_L00:
       mov       ecx,12E9
       mov       rdx,7FFE18314000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE186F66E8]
       int       3
; Total bytes of code 48
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L00
       cmp       [rdx],rcx
       jne       short M13_L01
M13_L00:
       mov       rax,rdx
       ret
M13_L01:
       jmp       qword ptr [7FFE184643F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.Object.GetType()
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

