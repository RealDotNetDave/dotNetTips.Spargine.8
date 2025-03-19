## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF9F5DC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       jmp       qword ptr [7FF9F5DC43A8]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F602EF40]
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
       mov       rax,1EE30D00008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonArray()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+130]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF9F6867B88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       [rsp+30],rax
       mov       rcx,1FB7E80EE78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FF9F62D6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF9F62D6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65CF2B8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF9F686D428]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF9F6044F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF9F5C710A8
       call      qword ptr [r11]
       test      rax,rax
       jne       near ptr M00_L00
M00_L08:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rdx,rax
       call      qword ptr [7FF9F5DB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23C109B5CE0
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
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
       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rdx,7FF9F69EC668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF9F69EC868
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
       mov       rdx,7FF9F69EC880
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
       mov       rdx,7FF9F69EC990
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
       mov       rdx,7FF9F69EC858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F69D78D0]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FF9F69EC858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FF9F69D7948]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF9F69EC858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F69D79D8]
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
       mov       rdx,7FF9F69EC9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FF9F6255578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FF9F62D7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M03_L05
       call      qword ptr [7FF9F633D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62D6E68]
       test      eax,eax
       je        near ptr M03_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF9F633D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF9F633D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF9F633D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F633D920]
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
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62D6730]
       jmp       short M03_L09
M03_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D7B8]
       jmp       short M03_L09
M03_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62DC978]
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
       mov       rdx,23C109A2D10
       mov       r8d,1
       call      qword ptr [7FF9F62D5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9F62D67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
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
       mov       rcx,1FB7E801F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9F65B37A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,23C109A1C08
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
       call      qword ptr [7FF9F633CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF9F601E9D0]
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
       call      qword ptr [7FF9F633E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9F66869E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L13:
       mov       rcx,7FF9F6304690
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FB7E80F958
       mov       rdi,[rcx]
       jmp       near ptr M05_L03
M05_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9F65CFEB8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F66864F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9F66840D8]
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
       mov       rcx,[rcx+40]
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
       call      qword ptr [7FF9F601E9D0]
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
       call      qword ptr [7FF9F5E65BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1FB7E801F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F65B37A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FF9F6765B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FF9F6765B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5DB73F0]
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L03
M07_L02:
       mov       r8,1FB7E80DD88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9F686D488]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M07_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,rsi
       mov       rdx,7FF9F6874540
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M07_L02
M07_L04:
       lea       rcx,[rsp+28]
       mov       rdx,23C109B5F00
       call      qword ptr [7FF9F5FA58F0]
M07_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF9F6204B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M07_L07
M07_L06:
       call      qword ptr [7FF9F601E9D0]
       int       3
M07_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M07_L08
       mov       rdx,23C109A0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M07_L09
M07_L08:
       lea       rcx,[rsp+28]
       mov       rdx,23C109A0C48
       call      qword ptr [7FF9F5FA58F0]
M07_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5FA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F6046718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L10:
       call      qword ptr [7FF9F6334D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M07_L11
       call      qword ptr [7FF9F6334AE0]
       mov       rsi,rax
M07_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23C109B5CE0
       mov       r8,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9F5FA56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,23C109B5F0C
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F601EF40]
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
       mov       rax,23C109A0008
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
       jmp       qword ptr [7FF9F5DB43A8]
; Total bytes of code 71
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonCollection()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       [rsp+30],rcx
       mov       rcx,1AAEB80CE80
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9F63060A0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9F63059B0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65FF2B8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF9F5DE7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FF9F68D4750]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF9F63644C8]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F63642B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FF9F5DE43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FF9F6364570]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FF9F63642B8]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EB7D6F5BC8
       mov       r8,rbx
       call      qword ptr [7FF9F6076670]
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
       call      qword ptr [7FF9F6306DD8]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF9F636CBA0]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F63067D8]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF9F636CDB0]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF9F636CDB0]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF9F636CDE0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F636CE28]
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
       call      qword ptr [7FF9F636CC48]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F636CC48]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F636CC48]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F63060A0]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F636CCC0]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F630C180]
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
       mov       rdx,1EB7D6E2D10
       mov       r8d,1
       call      qword ptr [7FF9F6305950]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9F6306118]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,1AAEF801F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9F65E37A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,1EB7D6E1C08
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
       call      qword ptr [7FF9F636C348]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF9F604E9D0]
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
       call      qword ptr [7FF9F636D878]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9F66B69E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF9F6334690
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AAEB80D960
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9F65FFEB8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F66B64F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9F66B40D8]
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
       call      qword ptr [7FF9F604E9D0]
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
       call      qword ptr [7FF9F5E95BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1AAEF801F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F65E37A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF9F6795B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF9F6795B18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
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
       call      qword ptr [7FF9F5DE73F0]
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
       call      qword ptr [7FF9F5DE7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,1AAEB80BD90
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9F68D47B0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FF9F68AA8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,1EB7D6F5DE8
       call      qword ptr [7FF9F5FD58F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF9F6234210]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FF9F604E9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,1EB7D6E0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,1EB7D6E0C48
       call      qword ptr [7FF9F5FD58F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5FD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F6076718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FF9F6364570]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FF9F63642B8]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1EB7D6F5BC8
       mov       r8,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9F5FD56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,1EB7D6F5DF4
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604EF40]
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
       mov       rax,1EB7D6E0008
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
       jmp       qword ptr [7FF9F5DE43A8]
; Total bytes of code 71
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePerson()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       [rsp+30],rcx
       mov       rcx,2219100EE78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9F62D6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9F62D6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65CF480]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF9F686C9A8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FF9F5DB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FF9F6334D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FF9F6334AE0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26222DE5610
       mov       r8,rbx
       call      qword ptr [7FF9F6046670]
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
       call      qword ptr [7FF9F62D7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF9F633D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62D6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF9F633D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF9F633D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF9F633D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F633D920]
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
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62D6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F633D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62DC978]
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
       mov       rdx,26222DD2D10
       mov       r8d,1
       call      qword ptr [7FF9F62D5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9F62D67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,22191001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9F65B37A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,26222DD1C08
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
       call      qword ptr [7FF9F633CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF9F601E9D0]
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
       call      qword ptr [7FF9F633E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9F6686B80]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF9F6304690
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2219100F958
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9F66840F0]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F6686688]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9F6684270]
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
       call      qword ptr [7FF9F601E9D0]
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
       call      qword ptr [7FF9F5E65BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,22191001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F65B37A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF9F6766190]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF9F6766190]
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
       call      qword ptr [7FF9F5DB73F0]
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
       call      qword ptr [7FF9F5DB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,2219100DD88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9F686CA08]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FF9F6880E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,26222DE5830
       call      qword ptr [7FF9F5FA58F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF9F6204B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FF9F601E9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,26222DD0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,26222DD0C48
       call      qword ptr [7FF9F5FA58F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5FA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F6046718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FF9F6334D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FF9F6334AE0]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,26222DE5610
       mov       r8,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9F5FA56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,26222DE583C
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F601EF40]
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
       mov       rax,26222DD0008
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
       jmp       qword ptr [7FF9F5DB43A8]
; Total bytes of code 69
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+40]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       call      qword ptr [7FF9F62A5728]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L17
       mov       rax,14CB90009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,14CB500CE80
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF9F62E6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L18
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L19
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65DF2B8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L21
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L20
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF9F60AD140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L23
       cmp       r9d,r15d
       jne       near ptr M01_L22
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
       call      qword ptr [7FF9F601A478]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r14,r14
       je        near ptr M01_L24
       lea       rsi,[r14+10]
       mov       ebx,[r14+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rdx,[r12+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L25
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
       mov       rcx,18D47069070
       xor       r9d,r9d
       call      qword ptr [7FF9F67EF558]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       r12,10
       mov       ebx,20
       mov       rcx,14CB500CE88
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L26
       mov       rcx,[rcx+18]
M01_L06:
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M01_L29
       mov       rcx,[rsi+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L27
       lea       rcx,[rsi+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L27
M01_L07:
       mov       rdi,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L16
M01_L10:
       mov       ecx,r14d
       movzx     ecx,byte ptr [r12+rcx]
       mov       r8,14CB9000428
       mov       r8,[r8]
       mov       rdx,18D47075610
       call      qword ptr [7FF9F6004810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L15
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
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
       mov       [rdi+18],esi
       jmp       short M01_L15
M01_L12:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L13:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rdi
       call      qword ptr [7FF9F60CCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       inc       r14d
       cmp       r14d,ebx
       jl        near ptr M01_L10
M01_L16:
       mov       rcx,rdi
       call      qword ptr [7FF9F60D8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,rsp
       call      M01_L30
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
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       ecx,1
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F6056670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L18:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,18D47062D10
       mov       r8d,1
       call      qword ptr [7FF9F62E5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r14,rax
       lea       rcx,[rsi+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       jmp       near ptr M01_L02
M01_L19:
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L20:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F60A50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       ecx,1763
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M01_L22:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FF9F5DCC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L23:
       call      qword ptr [7FF9F5DCC7E0]
       int       3
M01_L24:
       mov       ecx,6A61
       mov       rdx,7FF9F62CEC98
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
       int       3
M01_L25:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF9F68A4168]
       mov       rbx,rax
       mov       ecx,4465
       mov       rdx,7FF9F62CEC98
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FF9F5DCF750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L26:
       call      qword ptr [7FF9F6235E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L27:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEF10]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L28
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L07
M01_L28:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M01_L08
M01_L29:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L09
M01_L30:
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
       mov       rcx,14CB500CE88
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L31
       call      qword ptr [7FF9F6235E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M01_L32
M01_L31:
       mov       rdi,[rcx+18]
M01_L32:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       near ptr M01_L37
       mov       rax,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L33
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L38
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F60CC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L34
M01_L33:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L38
M01_L34:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L35
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L38
M01_L35:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L36
       mov       rcx,[rdi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65AEEE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L38
M01_L36:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       short M01_L38
M01_L37:
       mov       rbx,[rbp-0A8]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L38:
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
; Total bytes of code 1640
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       call      qword ptr [7FF9F62C5728]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L29
       mov       rax,1EC100009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,1EC1000EE78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF9F6306730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L30
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L31
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65FF480]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L24
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L18
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF9F60CD140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L23
       cmp       r9d,r15d
       jne       near ptr M01_L22
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
       call      qword ptr [7FF9F603A478]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L25
       lea       rbx,[rax+10]
       mov       r14d,[rax+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L26
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
       mov       rcx,22C9DF39070
       xor       r9d,r9d
       call      qword ptr [7FF9F68CCA80]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       rsi,10
       mov       ebx,20
       mov       rcx,1EC1000EE80
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L21
       mov       rcx,[rcx+18]
M01_L06:
       mov       r15,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r15],rcx
       jne       near ptr M01_L28
       mov       rcx,[r15+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L17
       lea       rcx,[r15+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L17
M01_L07:
       mov       r15,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [r15],r15b
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9F60EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L16
M01_L10:
       mov       ecx,r13d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,1EC10000428
       mov       r8,[r8]
       mov       rdx,22C9DF45610
       call      qword ptr [7FF9F6024810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L15
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
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
       mov       [r15+18],r12d
       jmp       short M01_L15
M01_L12:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L13:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L14:
       mov       rcx,r15
       call      qword ptr [7FF9F60ECA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L10
M01_L16:
       mov       rcx,r15
       call      qword ptr [7FF9F60F8140]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,rsp
       call      M01_L32
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
       mov       rcx,[r15+18]
       lea       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65CEF58]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L07
M01_L18:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F60C50C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L19:
       mov       r14,[r15+8]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Create()
       cmp       [r14+18],rcx
       jne       near ptr M01_L27
       mov       r13,[r14+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edx,[r13+8]
       mov       rcx,r15
       mov       r8d,7FFFFFFF
       call      qword ptr [7FF9F60EC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L20:
       jmp       near ptr M01_L08
M01_L21:
       call      qword ptr [7FF9F6255E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L22:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FF9F5DEC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L23:
       call      qword ptr [7FF9F5DEC7E0]
       int       3
M01_L24:
       mov       ecx,1763
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60766E8]
       int       3
M01_L25:
       mov       ecx,6A61
       mov       rdx,7FF9F62EEC98
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60766E8]
       int       3
M01_L26:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F680F930]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF9F62EEC98
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       mov       r15,rax
       jmp       near ptr M01_L20
M01_L28:
       mov       rcx,r15
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r15,rax
       jmp       near ptr M01_L09
M01_L29:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,22C9DF32D10
       mov       r8d,1
       call      qword ptr [7FF9F6305FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r13,rax
       lea       rcx,[rsi+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r13
       jmp       near ptr M01_L02
M01_L31:
       call      qword ptr [7FF9F5DE43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L32:
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
       mov       rcx,1EC1000EE80
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L33
       call      qword ptr [7FF9F6255E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M01_L34
M01_L33:
       mov       r15,[rcx+18]
M01_L34:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r15],rcx
       jne       near ptr M01_L39
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L35
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L40
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F60EC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L36
M01_L35:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L40
M01_L36:
       cmp       qword ptr [r15+20],0
       jne       short M01_L37
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L40
M01_L37:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L38
       mov       rcx,[r15+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65CEF28]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L40
M01_L38:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       short M01_L40
M01_L39:
       mov       rcx,r15
       mov       rdx,[rbp-0A8]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
M01_L40:
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
; Total bytes of code 1709
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F68B5F98]; System.Data.DataTable..ctor()
       mov       rcx,29E6CF95638
       mov       [rbx+70],rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rsp+28]
       xor       r8d,r8d
       mov       r9d,34
       call      qword ptr [7FF9F5D06700]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       cmp       dword ptr [rsp+38],0
       je        near ptr M00_L11
       cmp       dword ptr [rsp+38],1
       je        near ptr M00_L12
       mov       esi,[rsp+38]
       test      esi,esi
       jl        near ptr M00_L13
       mov       rdi,[rsp+28]
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       [rdi+8],esi
       je        short M00_L01
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       esi,r8d
       cmovg     esi,r8d
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+28],rbp
M00_L01:
       mov       ecx,[rsp+38]
       mov       [rsp+3C],ecx
       mov       rsi,[rsp+28]
M00_L02:
       xor       edi,edi
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M00_L06
M00_L03:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M00_L10
       mov       rcx,r14
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        short M00_L08
M00_L04:
       cmp       [rdx],dl
       mov       rcx,29E6CF8F3D0
       call      qword ptr [7FF9F5CFA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
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
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L05
       xor       edx,edx
       call      qword ptr [7FF9F6295890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M00_L05
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FF9F60D73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       short M00_L04
M00_L09:
       call      qword ptr [7FF9F5E65BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L11:
       mov       rcx,25DDB001EE0
       mov       rsi,[rcx]
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+30]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L02
M00_L13:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF9F601ED48]
       int       3
M00_L14:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+28],rax
       jmp       near ptr M00_L01
; Total bytes of code 531
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
       mov       rsi,29E6CF80008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,29E6CF956D8
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,29E6CF957B0
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,25DDB001FD0
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25DDB001FD8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,25DDB001FE0
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
       mov       rcx,7FF9F5CF5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF9F68A7298
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F606C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,25DDB0126E8
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
       mov       rdx,29E6CF95658
       call      qword ptr [7FF9F5DB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF9F5E676D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68BE5E0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68BC9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,25DDB001E58
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
       call      qword ptr [7FF9F68BD728]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,25DDB001FF8
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
       je        near ptr M02_L03
       test      bl,1
       je        short M02_L00
       mov       rdx,rsi
       mov       rcx,25DDB000590
       mov       rcx,[rcx]
       call      qword ptr [7FF9F6765920]
       mov       rsi,rax
       mov       r15d,1
       mov       r13d,2
       jmp       short M02_L01
M02_L00:
       mov       r13d,1
M02_L01:
       cmp       byte ptr [rsp+0C0],0
       je        short M02_L04
       mov       ecx,[rsi+8]
       mov       eax,ecx
       cmp       word ptr [rsi+rax*2+0A],2A
       jne       short M02_L04
       lea       r12d,[rcx-1]
       cmp       ecx,r12d
       jb        near ptr M02_L19
       test      r12d,r12d
       je        near ptr M02_L20
       cmp       ecx,r12d
       je        near ptr M02_L21
       mov       ecx,r12d
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       mov       r8d,r12d
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       lea       rdx,[rsi+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rsi,r13
M02_L02:
       mov       r14d,1
M02_L03:
       xor       r13d,r13d
M02_L04:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L07
       mov       r12,[rcx]
       test      r12,r12
       je        short M02_L07
M02_L05:
       mov       rbp,rsi
       cmp       [r12],r12b
       lea       rax,[r12+48]
       mov       [rsp+30],rax
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L06
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
M02_L06:
       mov       r12,rdx
       cmp       [r12],r12b
       cmp       r13d,1
       je        short M02_L08
       cmp       r13d,2
       je        short M02_L10
       jmp       near ptr M02_L12
M02_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9F5D06658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       short M02_L05
M02_L08:
       lea       rcx,[r12+20]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FF9F606CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M02_L09
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF9F6094E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M02_L09:
       mov       r13,rax
       jmp       short M02_L14
M02_L10:
       lea       rcx,[r12+28]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FF9F606CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L11
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF9F6094E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L11:
       jmp       short M02_L14
M02_L12:
       cmp       byte ptr [r12+18],0
       je        short M02_L13
       mov       r13,[r12+8]
       jmp       short M02_L14
M02_L13:
       mov       rcx,r12
       mov       r8d,r13d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF9F6094E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L14:
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
       jle       short M02_L18
M02_L15:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       mov       [rsp+38],rax
       mov       ecx,[rax+18]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M02_L17
       test      r14d,r14d
       jne       near ptr M02_L22
M02_L16:
       lea       rcx,[rsp+40]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF9F6094BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L17:
       inc       r12d
       cmp       ebp,r12d
       jg        short M02_L15
M02_L18:
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
M02_L19:
       mov       rcx,rsi
       mov       r8d,r12d
       xor       edx,edx
       call      qword ptr [7FF9F5DB7258]
       int       3
M02_L20:
       mov       rsi,29E6CF80008
       jmp       near ptr M02_L02
M02_L21:
       jmp       near ptr M02_L02
M02_L22:
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FF9F5D06538]
       test      eax,eax
       je        short M02_L17
       mov       rax,[rsp+38]
       jmp       near ptr M02_L16
; Total bytes of code 742
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
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F5D04E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F5D06148]
M03_L02:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        short M03_L06
       mov       rcx,rsi
       call      qword ptr [7FF9F5CFA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
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
       test      rdx,rdx
       je        short M04_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M04_L05
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M04_L04
M04_L00:
       cmp       [r9],rcx
       je        short M04_L01
       cmp       [r9+8],rcx
       je        short M04_L01
       cmp       [r9+10],rcx
       je        short M04_L01
       cmp       [r9+18],rcx
       je        short M04_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jl        short M04_L03
       jmp       short M04_L00
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       jmp       qword ptr [7FF9F5DB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M04_L03:
       test      r10,r10
       je        short M04_L05
M04_L04:
       cmp       [r9],rcx
       je        short M04_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M04_L04
M04_L05:
       test      dword ptr [r8],406C0000
       jne       short M04_L02
       xor       edx,edx
       jmp       short M04_L01
; Total bytes of code 112
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
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M05_L00
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       cmp       [rbx],rcx
       jne       short M05_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF9F68BEC40]; System.Threading.ReaderWriterLockSlim.Dispose(Boolean)
       jmp       short M05_L03
M05_L00:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FF9F5C71278
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FF9F690C210]
       test      eax,eax
       je        short M05_L03
       call      qword ptr [7FF9F690C6F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L01
       call      qword ptr [7FF9F6334C48]
       mov       rbx,rax
M05_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F6046718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L02:
       mov       rcx,rbx
       mov       r11,7FF9F5C71270
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
       je        short M07_L02
       mov       rcx,rbx
       sub       rcx,rsi
       cmp       rcx,rdi
       jb        short M07_L03
M07_L00:
       add       rdi,0FFFFFFFFFFFFC000
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,4000
       call      qword ptr [7FFA534A1D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M07_L00
M07_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA534A1D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L02:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L03:
       add       rdi,0FFFFFFFFFFFFC000
       lea       rcx,[rbx+rdi]
       lea       rdx,[rsi+rdi]
       mov       r8d,4000
       call      qword ptr [7FFA534A1D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M07_L03
       jmp       short M07_L01
; Total bytes of code 150
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       [rsp+30],rdx
       mov       rdx,2CE99B03CD8
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FF9F5CFA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FF9F5D066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FF9F609CC60]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rdx,[rax+18]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       short M01_L11
       mov       rcx,r14
       call      qword ptr [7FF9F5CFA720]; Precode of System.RuntimeType.IsEquivalentTo(System.Type)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60466E8]
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
       call      qword ptr [7FF9F601F1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L13:
       test      ebx,10000
       je        short M01_L14
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF9F6094B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF9F646CC00]
       jmp       near ptr M01_L08
M01_L14:
       test      rsi,rsi
       jne       short M01_L15
       call      qword ptr [7FF9F5D05FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L15:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF9F6094B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
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
       mov       rdx,19B29193CD8
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FF9F5D2A6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FF9F5D366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FF9F60CCC60]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rdx,[rax+18]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       short M01_L11
       mov       rcx,r14
       call      qword ptr [7FF9F5D2A720]; Precode of System.RuntimeType.IsEquivalentTo(System.Type)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60766E8]
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
       call      qword ptr [7FF9F604F1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L13:
       test      ebx,10000
       je        short M01_L14
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF9F60C4B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF9F649CC00]
       jmp       near ptr M01_L08
M01_L14:
       test      rsi,rsi
       jne       short M01_L15
       call      qword ptr [7FF9F5D35FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L15:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF9F60C4B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+50],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+40],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+50],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+40],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 18
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+40]
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
       mov       rbp,[rsi+28]
       lea       rcx,[rdi+28]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+30]
       lea       rcx,[rdi+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+38]
       lea       rcx,[rdi+38]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       je        short M00_L00
       cmp       dword ptr [rbp+8],8
       jne       short M00_L00
       vmovups   xmm0,[rbp+0C]
       vpxor     xmm0,xmm0,[7FF9F6920F60]
       vptest    xmm0,xmm0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L03
M00_L00:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       esi,1
       mov       [rsp+30],rcx
       mov       ecx,32
       xor       edx,edx
       cmp       esi,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        near ptr M00_L08
M00_L01:
       test      eax,eax
       je        short M00_L04
M00_L02:
       cmp       esi,8
       jg        near ptr M00_L06
       cmp       ecx,8
       jl        short M00_L06
       mov       rcx,1C0F6BA5610
       mov       [rdi+28],rcx
M00_L03:
       mov       [rsp+28],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FF9F6354CD8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FF9F6354AF8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C0F6B9FC38
       mov       r8,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       call      qword ptr [7FF9F62F5B78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L07
       call      qword ptr [7FF9F6354AF8]
       mov       rbx,rax
M00_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1C0F6B996C8
       mov       r8,rbx
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L08:
       movzx     edx,byte ptr [rsp+30]
       test      dl,dl
       je        near ptr M00_L01
       lea       rcx,[rsp+30]
       call      qword ptr [7FF9F5E847B0]
       mov       ecx,eax
       jmp       near ptr M00_L02
; Total bytes of code 477
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62B0AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2D573958D90
       mov       [rsi+8],rcx
       mov       word ptr [rsi+10],3A
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L01
       mov       rdx,[rsi+8]
       test      rdx,rdx
       je        near ptr M01_L02
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,2D57395C8C8
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FF9F5DB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,2D573950008
       mov       rcx,2D573955F40
       test      eax,eax
       cmovne    rdx,rcx
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,2D573950008
       call      qword ptr [7FF9F6867B70]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DB62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M01_L03
       mov       r8,[rsi+8]
       mov       edx,[r8+8]
       mov       r8d,[rbx+8]
       sub       r8d,edx
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F5DB7240]; System.String.Substring(Int32, Int32)
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,827
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,rbx
       jmp       near ptr M01_L00
; Total bytes of code 628
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       mov       rdx,21B3FB00008
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DEEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L49
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L50
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68D59C8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DEEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DEEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68D6280]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M01_L41
       jmp       near ptr M01_L29
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F68D5D88]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M01_L54
       cmp       dword ptr [rbp-68],1
       je        near ptr M01_L55
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F60C5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L07:
       test      r15,r15
       je        near ptr M01_L56
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,21B3FB00008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DAB1C01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61714A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L57
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L59
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L58
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DE43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L52
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L51
       call      qword ptr [7FF9F5F764F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L10:
       mov       rcx,rax
M01_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L12:
       cmp       r12,rdi
       jne       near ptr M01_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F609E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M01_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FFFDF8]; System.Number.UInt32ToDecStr(UInt32)
M01_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,21B3FB15668
       call      qword ptr [7FF9F68D6118]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68D61C0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,1DAADC0CF28
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M01_L21
M01_L15:
       mov       rbx,1DAADC0CF30
       mov       r9,[rbx]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6ABC828]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F609E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       near ptr M01_L27
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1DAADC0CF20
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1DAADC0CF20
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L22:
       test      rax,rax
       je        short M01_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5FDF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L25
M01_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5CA0FE8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L24:
       call      qword ptr [7FF9F5FDF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FFFCA8]
       jmp       near ptr M01_L14
M01_L26:
       mov       r11,7FF9F5CA0FE0
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L28
       cmp       [rcx],rdi
       jne       near ptr M01_L53
M01_L28:
       mov       rax,r14
       add       rsp,148
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
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L60
       mov       r8,21B3FB0D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M01_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F60C6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F60C6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M01_L43
M01_L30:
       mov       rdx,[rbp-130]
M01_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F616E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L40
M01_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M01_L62
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L61
M01_L33:
       test      rcx,rcx
       je        near ptr M01_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F60A8128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M01_L42
       test      r8,r8
       je        near ptr M01_L40
M01_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M01_L64
       mov       r10,rax
       mov       [rbp-120],r10
       mov       rdx,[r10+8]
       test      rdx,rdx
       je        near ptr M01_L63
M01_L36:
       mov       r9,[rbp-100]
       lea       rcx,[r9+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,21B3FB15690
       call      qword ptr [7FF9F68D6118]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M01_L37:
       mov       rcx,1DAADC0CF38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L47
M01_L38:
       mov       rcx,1DAADC0CF40
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M01_L46
       mov       rax,[rbp-108]
M01_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6ABC828]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L40:
       add       esi,1
       jo        near ptr M01_L48
       cmp       esi,r15d
       jl        near ptr M01_L29
M01_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L42:
       jmp       near ptr M01_L35
M01_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M01_L44
       mov       r8,[rbp-88]
       jmp       short M01_L45
M01_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M01_L43
       jmp       near ptr M01_L30
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,1DAADC0CF20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,1DAADC0CF40
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M01_L39
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,1DAADC0CF20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,1DAADC0CF38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M01_L38
M01_L48:
       call      CORINFO_HELP_OVERFLOW
M01_L49:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6076670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L50:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L51:
       mov       r11,7FF9F5CA0FF8
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L52:
       mov       rcx,rax
       mov       r11,7FF9F5CA0FD8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L53:
       mov       r11,7FF9F5CA0FF0
       call      qword ptr [r11]
       jmp       near ptr M01_L28
M01_L54:
       mov       rcx,1DAB1C01E10
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L55:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L56:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0F
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6076670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L57:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L58:
       call      qword ptr [7FF9F604E9D0]
       int       3
M01_L59:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FD5848]
       jmp       near ptr M01_L03
M01_L60:
       mov       rcx,rax
       mov       rdx,21B3FB0D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L31
M01_L61:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M01_L33
M01_L62:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M01_L34
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60C51B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F60C5230]
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M01_L36
M01_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L36
M01_L65:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L37
M01_L66:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FF9F6074F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FF9F6074F30]
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF9F5CA0FF0
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
; Total bytes of code 3614
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       mov       rdx,21FDF390008
       xor       r8d,r8d
       call      qword ptr [7FF9F62857E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DAEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L49
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L50
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68A6058]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68A6910]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5F95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M01_L41
       jmp       near ptr M01_L29
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F68A6418]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5CF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M01_L54
       cmp       dword ptr [rbp-68],1
       je        near ptr M01_L55
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F6085908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L07:
       test      r15,r15
       je        near ptr M01_L56
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,21FDF390008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DF51401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61314A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L57
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L59
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L58
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DA43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L52
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L51
       call      qword ptr [7FF9F5F364F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L10:
       mov       rcx,rax
M01_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L12:
       cmp       r12,rdi
       jne       near ptr M01_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F605E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M01_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FBFDF8]; System.Number.UInt32ToDecStr(UInt32)
M01_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,21FDF3A5640
       call      qword ptr [7FF9F68A67A8]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62857E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68A6850]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,1DF5140EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M01_L21
M01_L15:
       mov       rbx,1DF5140EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A779F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F605E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       near ptr M01_L27
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1DF5140EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1DF5140EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L22:
       test      rax,rax
       je        short M01_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5F9F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L25
M01_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C613F8
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L24:
       call      qword ptr [7FF9F5F9F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FBFCA8]
       jmp       near ptr M01_L14
M01_L26:
       mov       r11,7FF9F5C613F0
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L28
       cmp       [rcx],rdi
       jne       near ptr M01_L53
M01_L28:
       mov       rax,r14
       add       rsp,148
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
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L60
       mov       r8,21FDF39D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M01_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F6086208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F6086280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M01_L43
M01_L30:
       mov       rdx,[rbp-130]
M01_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F612E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L40
M01_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M01_L62
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L61
M01_L33:
       test      rcx,rcx
       je        near ptr M01_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6068128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M01_L42
       test      r8,r8
       je        near ptr M01_L40
M01_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M01_L64
       mov       r10,rax
       mov       [rbp-120],r10
       mov       rdx,[r10+8]
       test      rdx,rdx
       je        near ptr M01_L63
M01_L36:
       mov       r9,[rbp-100]
       lea       rcx,[r9+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,21FDF3A5668
       call      qword ptr [7FF9F68A67A8]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62857E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M01_L37:
       mov       rcx,1DF5140EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L47
M01_L38:
       mov       rcx,1DF5140EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M01_L46
       mov       rax,[rbp-108]
M01_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A779F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L40:
       add       esi,1
       jo        near ptr M01_L48
       cmp       esi,r15d
       jl        near ptr M01_L29
M01_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L42:
       jmp       near ptr M01_L35
M01_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M01_L44
       mov       r8,[rbp-88]
       jmp       short M01_L45
M01_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M01_L43
       jmp       near ptr M01_L30
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,1DF5140EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,1DF5140EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M01_L39
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,1DF5140EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,1DF5140EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M01_L38
M01_L48:
       call      CORINFO_HELP_OVERFLOW
M01_L49:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6036670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L50:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6036670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L51:
       mov       r11,7FF9F5C61408
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L52:
       mov       rcx,rax
       mov       r11,7FF9F5C613E8
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L53:
       mov       r11,7FF9F5C61400
       call      qword ptr [r11]
       jmp       near ptr M01_L28
M01_L54:
       mov       rcx,1DF51401E10
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L55:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L56:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,0F
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6036670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L57:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L58:
       call      qword ptr [7FF9F600E9D0]
       int       3
M01_L59:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5F95848]
       jmp       near ptr M01_L03
M01_L60:
       mov       rcx,rax
       mov       rdx,21FDF39D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L31
M01_L61:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M01_L33
M01_L62:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M01_L34
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60851B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F6085230]
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M01_L36
M01_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L36
M01_L65:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L37
M01_L66:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F635D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F635CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FF9F6034F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FF9F6034F30]
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF9F5C61400
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
; Total bytes of code 3614
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       mov       rdx,23BE7C00008
       mov       r8d,1
       call      qword ptr [7FF9F62B57E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DDEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L59
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L60
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F6887B40]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DDEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DDEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F688C498]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FC5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M01_L41
       jmp       near ptr M01_L29
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F6887F00]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D266D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M01_L64
       cmp       dword ptr [rbp-68],1
       je        near ptr M01_L65
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F60B5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L07:
       test      r15,r15
       je        near ptr M01_L66
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,23BE7C00008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1FB55C01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61614A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L67
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L69
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L68
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L69
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DD43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L62
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L61
       call      qword ptr [7FF9F5F664F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L10:
       mov       rcx,rax
M01_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L12:
       cmp       r12,rdi
       jne       near ptr M01_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F608E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FE4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M01_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FEFDF8]; System.Number.UInt32ToDecStr(UInt32)
M01_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,23BE7C15668
       call      qword ptr [7FF9F688C330]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62B57E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F688C3D8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,1FB55C0EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M01_L21
M01_L15:
       mov       rbx,1FB55C0EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A7DC38]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F608E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       near ptr M01_L27
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1FB55C0EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1FB55C0EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L22:
       test      rax,rax
       je        short M01_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5FCF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L25
M01_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C90FC0
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L13
M01_L24:
       call      qword ptr [7FF9F5FCF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FEFCA8]
       jmp       near ptr M01_L14
M01_L26:
       mov       r11,7FF9F5C90FB8
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L28
       cmp       [rcx],rdi
       jne       near ptr M01_L63
M01_L28:
       mov       rax,r14
       add       rsp,148
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
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L53
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L70
       mov       r8,23BE7C0D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M01_L54
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L54
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F60B6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F60B6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M01_L43
M01_L30:
       mov       rdx,[rbp-130]
M01_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F615E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L40
M01_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M01_L50
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L49
M01_L33:
       test      rcx,rcx
       je        near ptr M01_L55
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6098128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M01_L42
       test      r8,r8
       je        near ptr M01_L40
M01_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M01_L51
       mov       [rbp-120],rax
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M01_L47
M01_L36:
       mov       rax,[rbp-100]
       lea       rcx,[rax+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,23BE7C15690
       call      qword ptr [7FF9F688C330]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62B57E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M01_L56
       test      rax,rax
       je        near ptr M01_L57
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L52
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M01_L37:
       mov       rcx,1FB55C0EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L38:
       mov       rcx,1FB55C0EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M01_L46
       mov       rax,[rbp-108]
M01_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A7DC38]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L40:
       add       esi,1
       jo        near ptr M01_L58
       cmp       esi,r15d
       jl        near ptr M01_L29
M01_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L42:
       jmp       near ptr M01_L35
M01_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M01_L44
       mov       r8,[rbp-88]
       jmp       short M01_L45
M01_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M01_L43
       jmp       near ptr M01_L30
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,1FB55C0EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,1FB55C0EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M01_L39
M01_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[rax+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60B51B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F60B5230]; System.MdUtf8String.ToString()
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M01_L36
M01_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,1FB55C0EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,1FB55C0EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M01_L38
M01_L49:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M01_L33
M01_L50:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L34
M01_L51:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L36
M01_L52:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L37
M01_L53:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F638D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DDF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F638CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DDF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L56:
       mov       ecx,4
       call      qword ptr [7FF9F6064F30]
       int       3
M01_L57:
       mov       ecx,0E
       call      qword ptr [7FF9F6064F30]
       int       3
M01_L58:
       call      CORINFO_HELP_OVERFLOW
M01_L59:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6066670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L60:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L61:
       mov       r11,7FF9F5C90FD0
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L62:
       mov       rcx,rax
       mov       r11,7FF9F5C90FB0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L63:
       mov       r11,7FF9F5C90FC8
       call      qword ptr [r11]
       jmp       near ptr M01_L28
M01_L64:
       mov       rcx,1FB55C01E10
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L65:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L66:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,0F
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6066670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L67:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L68:
       call      qword ptr [7FF9F603E9D0]
       int       3
M01_L69:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FC5848]
       jmp       near ptr M01_L03
M01_L70:
       mov       rcx,rax
       mov       rdx,23BE7C0D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L31
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF9F5C90FC8
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
; Total bytes of code 3611
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       mov       rdx,2DC6AD40008
       xor       r8d,r8d
       call      qword ptr [7FF9F62C57E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M01_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DEEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L58
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L59
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68E5ED8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DEEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L60
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF9F5DEEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68E6790]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M01_L27
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FF9F68E6298]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M01_L64
       cmp       dword ptr [rbp-68],1
       je        near ptr M01_L65
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F60C5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M01_L05:
       test      r15,r15
       je        near ptr M01_L66
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2DC6AD40008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L27
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,29BDD001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61714A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L67
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L69
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L68
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L69
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DE43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L62
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L61
       call      qword ptr [7FF9F5F764F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L08:
       mov       rcx,rax
M01_L09:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L15
M01_L10:
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F609E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M01_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L17
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M01_L20
       mov       ecx,r13d
       call      qword ptr [7FF9F5FFFDF8]; System.Number.UInt32ToDecStr(UInt32)
M01_L12:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,2DC6AD55668
       call      qword ptr [7FF9F68E6628]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68E66D0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,29BD900CF28
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M01_L19
M01_L13:
       mov       rbx,29BD900CF30
       mov       r9,[rbx]
       test      r9,r9
       je        short M01_L18
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6AB79F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M01_L15:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L24
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F609E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L16:
       test      eax,eax
       jne       near ptr M01_L10
       jmp       near ptr M01_L25
M01_L17:
       call      CORINFO_HELP_OVERFLOW
M01_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,29BD900CF20
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M01_L14
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,29BD900CF20
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L13
M01_L20:
       test      rax,rax
       je        short M01_L22
       mov       rcx,rax
       call      qword ptr [7FF9F5FDF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M01_L23
M01_L21:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5CA1430
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M01_L11
M01_L22:
       call      qword ptr [7FF9F5FDF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M01_L23:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FFFCA8]
       jmp       near ptr M01_L12
M01_L24:
       mov       r11,7FF9F5CA1428
       call      qword ptr [r11]
       jmp       near ptr M01_L16
M01_L25:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L26
       cmp       [rcx],rdi
       jne       near ptr M01_L63
M01_L26:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L27:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M01_L40
M01_L28:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M01_L70
       mov       r8,2DC6AD4D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M01_L53
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F60C6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F60C6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M01_L42
M01_L29:
       mov       rdx,[rbp-130]
M01_L30:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F616E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L31
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L39
M01_L31:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M01_L49
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L48
M01_L32:
       test      rcx,rcx
       je        near ptr M01_L54
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F60A8128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L33:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M01_L41
       test      r8,r8
       je        near ptr M01_L39
M01_L34:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M01_L50
       mov       [rbp-120],rax
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M01_L46
M01_L35:
       mov       rax,[rbp-100]
       lea       rcx,[rax+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,2DC6AD55690
       call      qword ptr [7FF9F68E6628]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M01_L55
       test      rax,rax
       je        near ptr M01_L56
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L51
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M01_L36:
       mov       rcx,29BD900CF38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L47
M01_L37:
       mov       rcx,29BD900CF40
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M01_L45
       mov       rax,[rbp-108]
M01_L38:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6AB79F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L39:
       add       esi,1
       jo        near ptr M01_L57
       cmp       esi,r15d
       jl        near ptr M01_L28
M01_L40:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L41:
       jmp       near ptr M01_L34
M01_L42:
       cmp       qword ptr [rbp-90],0
       jne       short M01_L43
       mov       r8,[rbp-88]
       jmp       short M01_L44
M01_L43:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M01_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L44:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M01_L42
       jmp       near ptr M01_L29
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,29BD900CF20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,29BD900CF40
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M01_L38
M01_L46:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[rax+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60C51B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F60C5230]; System.MdUtf8String.ToString()
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M01_L35
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,29BD900CF20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,29BD900CF38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M01_L37
M01_L48:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M01_L32
M01_L49:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L33
M01_L50:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M01_L35
M01_L51:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L36
M01_L52:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L55:
       mov       ecx,4
       call      qword ptr [7FF9F6074F30]
       int       3
M01_L56:
       mov       ecx,0E
       call      qword ptr [7FF9F6074F30]
       int       3
M01_L57:
       call      CORINFO_HELP_OVERFLOW
M01_L58:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6076670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L59:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L60:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M01_L02
M01_L61:
       mov       r11,7FF9F5CA1440
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L62:
       mov       rcx,rax
       mov       r11,7FF9F5CA1420
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L63:
       mov       r11,7FF9F5CA1438
       call      qword ptr [r11]
       jmp       near ptr M01_L26
M01_L64:
       mov       rcx,29BDD001E10
       mov       r15,[rcx]
       jmp       near ptr M01_L05
M01_L65:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L66:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0F
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6076670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L67:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L68:
       call      qword ptr [7FF9F604E9D0]
       int       3
M01_L69:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FD5848]
       jmp       near ptr M01_L03
M01_L70:
       mov       rcx,rax
       mov       rdx,2DC6AD4D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L30
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF9F5CA1438
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
; Total bytes of code 3616
```

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+50]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,21E21178D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L01
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5D26DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,21E2117C8C8
       xor       edx,edx
       call      qword ptr [7FF9F5D26DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF9F5DD61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,21E21175F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FF9F62B5440]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,21E21170008
       call      qword ptr [7FF9F67FEF88]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DD62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L03
       mov       r8,[rdi+8]
       mov       edx,[r8+8]
       mov       r8d,[rsi+8]
       sub       r8d,edx
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD7240]; System.String.Substring(Int32, Int32)
M00_L00:
       mov       [rsp+20],rax
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
       ret
M00_L01:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,7D9
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,827
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rax,rsi
       jmp       near ptr M00_L00
; Total bytes of code 653
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
       call      qword ptr [7FF9F5D26658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F608CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jne       short M02_L02
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F5E85068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F603ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L08
       mov       eax,edi
       lea       rcx,[7FF9F66762A8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FE4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6246100]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF9F5D15120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DD930003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F6246100]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
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
       jmp       qword ptr [7FF9F5DD5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F63A5338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DDF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DDEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L49
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L50
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F67FF018]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DDEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DDEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F67FF8D0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FC5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M03_L41
       jmp       near ptr M03_L29
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F67FF3D8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D266D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M03_L54
       cmp       dword ptr [rbp-68],1
       je        near ptr M03_L55
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F60B5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M03_L07:
       test      r15,r15
       je        near ptr M03_L56
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,21E21170008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DD93001DC8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F6142540]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L57
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L59
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L58
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DD43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L52
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L51
       call      qword ptr [7FF9F5F664F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F608E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FE4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M03_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FEFDF8]; System.Number.UInt32ToDecStr(UInt32)
M03_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,21E21185650
       call      qword ptr [7FF9F67FF768]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62B5440]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F67FF810]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,1DD9300EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L21
M03_L15:
       mov       rbx,1DD9300EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M03_L20
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A1C3F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F608E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L27
M03_L19:
       call      CORINFO_HELP_OVERFLOW
M03_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1DD9300EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M03_L16
M03_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1DD9300EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L22:
       test      rax,rax
       je        short M03_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5FCF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L25
M03_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C90FC0
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L13
M03_L24:
       call      qword ptr [7FF9F5FCF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FEFCA8]
       jmp       near ptr M03_L14
M03_L26:
       mov       r11,7FF9F5C90FB8
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L28
       cmp       [rcx],rdi
       jne       near ptr M03_L53
M03_L28:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L29:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L60
       mov       r8,21E2117D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M03_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F60B6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F60B6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M03_L43
M03_L30:
       mov       rdx,[rbp-130]
M03_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F60FE1C0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L40
M03_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M03_L62
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L61
M03_L33:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6098128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M03_L42
       test      r8,r8
       je        near ptr M03_L40
M03_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M03_L64
       mov       r10,rax
       mov       [rbp-120],r10
       mov       rdx,[r10+8]
       test      rdx,rdx
       je        near ptr M03_L63
M03_L36:
       mov       r9,[rbp-100]
       lea       rcx,[r9+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,21E21185678
       call      qword ptr [7FF9F67FF768]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62B5440]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DD4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M03_L37:
       mov       rcx,1DD9300EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L47
M03_L38:
       mov       rcx,1DD9300EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-108]
M03_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A1C3F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L40:
       add       esi,1
       jo        near ptr M03_L48
       cmp       esi,r15d
       jl        near ptr M03_L29
M03_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L42:
       jmp       near ptr M03_L35
M03_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L44
       mov       r8,[rbp-88]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M03_L43
       jmp       near ptr M03_L30
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,1DD9300EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,1DD9300EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M03_L39
M03_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,1DD9300EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,1DD9300EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M03_L38
M03_L48:
       call      CORINFO_HELP_OVERFLOW
M03_L49:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,7F1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6066670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L50:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,7D9
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6066670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L51:
       mov       r11,7FF9F5C90FD0
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L52:
       mov       rcx,rax
       mov       r11,7FF9F5C90FB0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L53:
       mov       r11,7FF9F5C90FC8
       call      qword ptr [r11]
       jmp       near ptr M03_L28
M03_L54:
       mov       rcx,1DD93001E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L55:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L56:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,0F
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6066670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L57:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L58:
       call      qword ptr [7FF9F603E9D0]
       int       3
M03_L59:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FC5848]
       jmp       near ptr M03_L03
M03_L60:
       mov       rcx,rax
       mov       rdx,21E2117D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L31
M03_L61:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M03_L33
M03_L62:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M03_L34
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60B51B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F60B5230]
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M03_L36
M03_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M03_L36
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L37
M03_L66:
       call      qword ptr [7FF9F63544C8]
       mov       ecx,0B32
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165450
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AAF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F63542B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639CE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DDF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DDF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF9F6064F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF9F6064F30]
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DD4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF9F5C90FC8
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
; Total bytes of code 3614
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,word ptr [rsi+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],si
       lea       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,21E2119E198
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F67FF768]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; Total bytes of code 147
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L21
       test      rsi,rsi
       je        near ptr M05_L22
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L18
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-68],rdi
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L11
       jmp       near ptr M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L08
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,21E2119E198
       call      qword ptr [7FF9F67FF768]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L06
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L04:
       mov       eax,[r15+0C]
       mov       r13,[r15]
       cmp       eax,[r13+38]
       jae       short M05_L07
       mov       r12,[r13+10]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       short M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L04
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L06:
       mov       rcx,rdi
       mov       r11,7FF9F5C91030
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L19
M05_L07:
       mov       ecx,[r13+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       near ptr M05_L19
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FF9F6A0FD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L15
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L16
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,21E2119E198
       call      qword ptr [7FF9F67FF768]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L11:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L13
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L12:
       mov       ecx,[r15+0C]
       mov       rdx,[r15]
       cmp       ecx,[rdx+38]
       jae       short M05_L14
       mov       rcx,[r15]
       mov       r12,[rcx+10]
       mov       eax,[r15+0C]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L12
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L13:
       mov       rcx,rdi
       mov       r11,7FF9F5C91030
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
       jmp       near ptr M05_L09
M05_L14:
       mov       rcx,[r15]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       short M05_L19
M05_L15:
       mov       rcx,rbx
       mov       rdx,7FF9F6A0FD70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L16:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r8,[rbp-60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L11
M05_L17:
       call      qword ptr [7FF9F603EFE8]
       int       3
M05_L18:
       mov       rcx,rbx
       mov       rdx,7FF9F6A0FC98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L19:
       mov       rax,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rax
       jne       short M05_L23
M05_L20:
       mov       rax,r14
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       ecx,10
       call      qword ptr [7FF9F6064F30]
       int       3
M05_L22:
       mov       ecx,5
       call      qword ptr [7FF9F6064F30]
       int       3
M05_L23:
       mov       rcx,rdi
       mov       r11,7FF9F5C91038
       call      qword ptr [r11]
       jmp       short M05_L20
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M05_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       je        short M05_L24
       mov       rcx,rdi
       mov       r11,7FF9F5C91038
       call      qword ptr [r11]
M05_L24:
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
; Total bytes of code 1141
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
       lea       rcx,[7FF9F6B6E250]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FE4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6246208]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF9F5D1539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1DD930003D8
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
       call      qword ptr [7FF9F6246208]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF9F5E85068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF9F622D6C8]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F622D698]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60666E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF9F603ECB8]
       int       3
M06_L10:
       mov       rcx,7FF9F5D15120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF9F603ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63A5338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C84000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DDF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M07_L00
       test      ebx,ebx
       je        short M07_L01
       cmp       eax,ebx
       je        short M07_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9F5DD7258]
       int       3
M07_L01:
       mov       rax,21E21170008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F603EF40]
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
       mov       rax,21E21170008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+50]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,234E1CF8D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L01
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5D36DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,234E1CFC8C8
       xor       edx,edx
       call      qword ptr [7FF9F5D36DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF9F5DE61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,234E1CF5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9F62C57E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,234E1CF0008
       call      qword ptr [7FF9F68D5C68]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DE62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L03
       mov       r8,[rdi+8]
       mov       edx,[r8+8]
       mov       r8d,[rsi+8]
       sub       r8d,edx
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE7240]; System.String.Substring(Int32, Int32)
M00_L00:
       mov       [rsp+20],rax
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
       ret
M00_L01:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,827
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rax,rsi
       jmp       near ptr M00_L00
; Total bytes of code 650
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
       call      qword ptr [7FF9F5D36658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F609CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF9F604ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF9F6673580]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F62568F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF9F5D25120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F44FC003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62568F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F5E95068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9F5DE5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F63C59C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DEF750]
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DEEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L49
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68D5CF8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DEEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M03_L50
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF9F5DEEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68D65B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FD5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M03_L27
M03_L04:
       mov       rcx,r15
       call      qword ptr [7FF9F68D60B8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M03_L54
       cmp       dword ptr [rbp-68],1
       je        near ptr M03_L55
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F60C5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M03_L05:
       test      r15,r15
       je        near ptr M03_L56
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,234E1CF0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L27
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1F44FC01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61714A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L57
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L59
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L58
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DE43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L52
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L51
       call      qword ptr [7FF9F5F764F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L08:
       mov       rcx,rax
M03_L09:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L15
M03_L10:
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F609E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M03_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L17
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M03_L20
       mov       ecx,r13d
       call      qword ptr [7FF9F5FFFDF8]; System.Number.UInt32ToDecStr(UInt32)
M03_L12:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,234E1D056A0
       call      qword ptr [7FF9F68D6448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68D64F0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,1F44FC0EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L19
M03_L13:
       mov       rbx,1F44FC0EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M03_L18
M03_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6AB79F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M03_L15:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L24
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F609E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L16:
       test      eax,eax
       jne       near ptr M03_L10
       jmp       near ptr M03_L25
M03_L17:
       call      CORINFO_HELP_OVERFLOW
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1F44FC0EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M03_L14
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1F44FC0EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L13
M03_L20:
       test      rax,rax
       je        short M03_L22
       mov       rcx,rax
       call      qword ptr [7FF9F5FDF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L23
M03_L21:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5CA1460
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L11
M03_L22:
       call      qword ptr [7FF9F5FDF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L23:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FFFCA8]
       jmp       near ptr M03_L12
M03_L24:
       mov       r11,7FF9F5CA1458
       call      qword ptr [r11]
       jmp       near ptr M03_L16
M03_L25:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L26
       cmp       [rcx],rdi
       jne       near ptr M03_L53
M03_L26:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L27:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L40
M03_L28:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L60
       mov       r8,234E1CFD5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M03_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F60C6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F60C6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M03_L42
M03_L29:
       mov       rdx,[rbp-130]
M03_L30:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F616E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L31
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L39
M03_L31:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M03_L62
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L61
M03_L32:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F60A8128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L33:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M03_L41
       test      r8,r8
       je        near ptr M03_L39
M03_L34:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M03_L64
       mov       r10,rax
       mov       [rbp-120],r10
       mov       rdx,[r10+8]
       test      rdx,rdx
       je        near ptr M03_L63
M03_L35:
       mov       r9,[rbp-100]
       lea       rcx,[r9+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,234E1D056C8
       call      qword ptr [7FF9F68D6448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62C57E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DE4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M03_L36:
       mov       rcx,1F44FC0EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L46
M03_L37:
       mov       rcx,1F44FC0EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M03_L45
       mov       rax,[rbp-108]
M03_L38:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6AB79F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L39:
       add       esi,1
       jo        near ptr M03_L47
       cmp       esi,r15d
       jl        near ptr M03_L28
M03_L40:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L41:
       jmp       near ptr M03_L34
M03_L42:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L43
       mov       r8,[rbp-88]
       jmp       short M03_L44
M03_L43:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L44:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M03_L42
       jmp       near ptr M03_L29
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,1F44FC0EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,1F44FC0EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M03_L38
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,1F44FC0EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,1F44FC0EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M03_L37
M03_L47:
       call      CORINFO_HELP_OVERFLOW
M03_L48:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6076670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L49:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6076670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L50:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M03_L02
M03_L51:
       mov       r11,7FF9F5CA1470
       call      qword ptr [r11]
       jmp       near ptr M03_L08
M03_L52:
       mov       rcx,rax
       mov       r11,7FF9F5CA1450
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L53:
       mov       r11,7FF9F5CA1468
       call      qword ptr [r11]
       jmp       near ptr M03_L26
M03_L54:
       mov       rcx,1F44FC01E10
       mov       r15,[rcx]
       jmp       near ptr M03_L05
M03_L55:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L05
M03_L56:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0F
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6076670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L57:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L06
M03_L58:
       call      qword ptr [7FF9F604E9D0]
       int       3
M03_L59:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FD5848]
       jmp       near ptr M03_L03
M03_L60:
       mov       rcx,rax
       mov       rdx,234E1CFD5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L30
M03_L61:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M03_L32
M03_L62:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M03_L33
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60C51B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F60C5230]
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M03_L35
M03_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M03_L35
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L36
M03_L66:
       call      qword ptr [7FF9F6364CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6175A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62BB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DE6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6364AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6076670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F639CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF9F6074F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF9F6074F30]
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DE4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF9F5CA1468
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
; Total bytes of code 3619
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,word ptr [rsi+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],si
       lea       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,234E1D1E1C0
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F68D6448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; Total bytes of code 147
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L21
       test      rsi,rsi
       je        near ptr M05_L22
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L18
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-68],rdi
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L11
       jmp       near ptr M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L08
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,234E1D1E1C0
       call      qword ptr [7FF9F68D6448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L06
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L04:
       mov       eax,[r15+0C]
       mov       r13,[r15]
       cmp       eax,[r13+38]
       jae       short M05_L07
       mov       r12,[r13+10]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       short M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L04
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L06:
       mov       rcx,rdi
       mov       r11,7FF9F5CA14D0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L19
M05_L07:
       mov       ecx,[r13+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       near ptr M05_L19
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FF9F6B0E848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L15
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L16
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,234E1D1E1C0
       call      qword ptr [7FF9F68D6448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L11:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L13
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L12:
       mov       ecx,[r15+0C]
       mov       rdx,[r15]
       cmp       ecx,[rdx+38]
       jae       short M05_L14
       mov       rcx,[r15]
       mov       r12,[rcx+10]
       mov       eax,[r15+0C]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L12
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L13:
       mov       rcx,rdi
       mov       r11,7FF9F5CA14D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
       jmp       near ptr M05_L09
M05_L14:
       mov       rcx,[r15]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       short M05_L19
M05_L15:
       mov       rcx,rbx
       mov       rdx,7FF9F6B0E848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L16:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r8,[rbp-60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L11
M05_L17:
       call      qword ptr [7FF9F604EFE8]
       int       3
M05_L18:
       mov       rcx,rbx
       mov       rdx,7FF9F6B0E770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L19:
       mov       rax,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rax
       jne       short M05_L23
M05_L20:
       mov       rax,r14
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       ecx,10
       call      qword ptr [7FF9F6074F30]
       int       3
M05_L22:
       mov       ecx,5
       call      qword ptr [7FF9F6074F30]
       int       3
M05_L23:
       mov       rcx,rdi
       mov       r11,7FF9F5CA14D8
       call      qword ptr [r11]
       jmp       short M05_L20
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M05_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       je        short M05_L24
       mov       rcx,rdi
       mov       r11,7FF9F5CA14D8
       call      qword ptr [r11]
M05_L24:
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
; Total bytes of code 1141
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
       lea       rcx,[7FF9F6B57F00]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FF4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6256A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF9F5D2539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1F44FC003D8
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
       call      qword ptr [7FF9F6256A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF9F5E95068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF9F623E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F623E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60766E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF9F604ECB8]
       int       3
M06_L10:
       mov       rcx,7FF9F5D25120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF9F604ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63C59C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C94000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DEF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M07_L00
       test      ebx,ebx
       je        short M07_L01
       cmp       eax,ebx
       je        short M07_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9F5DE7258]
       int       3
M07_L01:
       mov       rax,234E1CF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E95B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F604EF40]
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
       mov       rax,234E1CF0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
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
       mov       rcx,2CE46598D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L01
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5CF6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2CE4659C8C8
       xor       edx,edx
       call      qword ptr [7FF9F5CF6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF9F5DA61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2CE46595F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FF9F62857E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,2CE46590008
       call      qword ptr [7FF9F6895C68]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DA62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L03
       mov       r8,[rdi+8]
       mov       edx,[r8+8]
       mov       r8d,[rsi+8]
       sub       r8d,edx
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA7240]; System.String.Substring(Int32, Int32)
M00_L00:
       mov       [rsp+20],rax
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
       ret
M00_L01:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,827
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rax,rsi
       jmp       near ptr M00_L00
; Total bytes of code 653
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
       call      qword ptr [7FF9F5CF6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F605CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       mov       r8d,[rbx+8]
       cmp       r8d,[rsi+8]
       jne       short M02_L02
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F5E55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F600ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L08
       mov       eax,edi
       lea       rcx,[7FF9F6646B48]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F62168F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF9F5CE5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,28DB48003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62168F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
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
       jmp       qword ptr [7FF9F5DA5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L08:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F63859C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DAF750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 386
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DAEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L59
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L60
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F6895CF8]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68965B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5F95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M03_L41
       jmp       near ptr M03_L29
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F68960B8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5CF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M03_L64
       cmp       dword ptr [rbp-68],1
       je        near ptr M03_L65
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F6085908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M03_L07:
       test      r15,r15
       je        near ptr M03_L66
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2CE46590008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,28DB4801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61314A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L67
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L69
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L68
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L69
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DA43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L62
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L61
       call      qword ptr [7FF9F5F364F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F605E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M03_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FBFDF8]; System.Number.UInt32ToDecStr(UInt32)
M03_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,2CE465A56A0
       call      qword ptr [7FF9F6896448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62857E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68964F0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,28DB480EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L21
M03_L15:
       mov       rbx,28DB480EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M03_L20
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A779F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F605E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L27
M03_L19:
       call      CORINFO_HELP_OVERFLOW
M03_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,28DB480EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M03_L16
M03_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,28DB480EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L22:
       test      rax,rax
       je        short M03_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5F9F8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L25
M03_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C61560
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L13
M03_L24:
       call      qword ptr [7FF9F5F9F360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FBFCA8]
       jmp       near ptr M03_L14
M03_L26:
       mov       r11,7FF9F5C61558
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L28
       cmp       [rcx],rdi
       jne       near ptr M03_L63
M03_L28:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L29:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L53
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L70
       mov       r8,2CE4659D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M03_L54
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L54
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F6086208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F6086280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M03_L43
M03_L30:
       mov       rdx,[rbp-130]
M03_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F612E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L40
M03_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M03_L50
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L49
M03_L33:
       test      rcx,rcx
       je        near ptr M03_L55
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6068128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M03_L42
       test      r8,r8
       je        near ptr M03_L40
M03_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M03_L51
       mov       [rbp-120],rax
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M03_L47
M03_L36:
       mov       rax,[rbp-100]
       lea       rcx,[rax+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,2CE465A56C8
       call      qword ptr [7FF9F6896448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62857E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M03_L56
       test      rax,rax
       je        near ptr M03_L57
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L52
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M03_L37:
       mov       rcx,28DB480EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L38:
       mov       rcx,28DB480EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-108]
M03_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A779F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L40:
       add       esi,1
       jo        near ptr M03_L58
       cmp       esi,r15d
       jl        near ptr M03_L29
M03_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L42:
       jmp       near ptr M03_L35
M03_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L44
       mov       r8,[rbp-88]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M03_L43
       jmp       near ptr M03_L30
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,28DB480EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,28DB480EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M03_L39
M03_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[rax+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60851B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F6085230]; System.MdUtf8String.ToString()
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M03_L36
M03_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,28DB480EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,28DB480EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M03_L38
M03_L49:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M03_L33
M03_L50:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L34
M03_L51:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M03_L36
M03_L52:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L37
M03_L53:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6036670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L54:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F635D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L55:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F635CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L56:
       mov       ecx,4
       call      qword ptr [7FF9F6034F30]
       int       3
M03_L57:
       mov       ecx,0E
       call      qword ptr [7FF9F6034F30]
       int       3
M03_L58:
       call      CORINFO_HELP_OVERFLOW
M03_L59:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6036670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L60:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6036670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L61:
       mov       r11,7FF9F5C61570
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L62:
       mov       rcx,rax
       mov       r11,7FF9F5C61550
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L63:
       mov       r11,7FF9F5C61568
       call      qword ptr [r11]
       jmp       near ptr M03_L28
M03_L64:
       mov       rcx,28DB4801E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L65:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L66:
       call      qword ptr [7FF9F6324CF0]
       mov       ecx,0F
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6135A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F627B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6324AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6036670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L67:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L68:
       call      qword ptr [7FF9F600E9D0]
       int       3
M03_L69:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5F95848]
       jmp       near ptr M03_L03
M03_L70:
       mov       rcx,rax
       mov       rdx,2CE4659D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L31
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF9F5C61568
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
; Total bytes of code 3611
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,word ptr [rsi+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],si
       lea       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,2CE465BE378
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F6896448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; Total bytes of code 147
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L21
       test      rsi,rsi
       je        near ptr M05_L22
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L18
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-68],rdi
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L11
       jmp       near ptr M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L08
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,2CE465BE378
       call      qword ptr [7FF9F6896448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L06
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L04:
       mov       eax,[r15+0C]
       mov       r13,[r15]
       cmp       eax,[r13+38]
       jae       short M05_L07
       mov       r12,[r13+10]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       short M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L04
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L06:
       mov       rcx,rdi
       mov       r11,7FF9F5C615D8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L19
M05_L07:
       mov       ecx,[r13+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       near ptr M05_L19
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FF9F6ACEA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L15
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L16
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,2CE465BE378
       call      qword ptr [7FF9F6896448]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L11:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L13
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L12:
       mov       ecx,[r15+0C]
       mov       rdx,[r15]
       cmp       ecx,[rdx+38]
       jae       short M05_L14
       mov       rcx,[r15]
       mov       r12,[rcx+10]
       mov       eax,[r15+0C]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L12
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L13:
       mov       rcx,rdi
       mov       r11,7FF9F5C615D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
       jmp       near ptr M05_L09
M05_L14:
       mov       rcx,[r15]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       short M05_L19
M05_L15:
       mov       rcx,rbx
       mov       rdx,7FF9F6ACEA28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L16:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r8,[rbp-60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L11
M05_L17:
       call      qword ptr [7FF9F600EFE8]
       int       3
M05_L18:
       mov       rcx,rbx
       mov       rdx,7FF9F6ACE950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L19:
       mov       rax,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rax
       jne       short M05_L23
M05_L20:
       mov       rax,r14
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       ecx,10
       call      qword ptr [7FF9F6034F30]
       int       3
M05_L22:
       mov       ecx,5
       call      qword ptr [7FF9F6034F30]
       int       3
M05_L23:
       mov       rcx,rdi
       mov       r11,7FF9F5C615E0
       call      qword ptr [r11]
       jmp       short M05_L20
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M05_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       je        short M05_L24
       mov       rcx,rdi
       mov       r11,7FF9F5C615E0
       call      qword ptr [r11]
M05_L24:
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
; Total bytes of code 1141
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
       lea       rcx,[7FF9F6B28C30]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6216A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF9F5CE539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,28DB48003D8
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
       call      qword ptr [7FF9F6216A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF9F5E55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF9F61FE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F61FE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60366E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF9F600ECB8]
       int       3
M06_L10:
       mov       rcx,7FF9F5CE5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF9F600ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63859C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M07_L00
       test      ebx,ebx
       je        short M07_L01
       cmp       eax,ebx
       je        short M07_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9F5DA7258]
       int       3
M07_L01:
       mov       rax,2CE46590008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F600EF40]
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
       mov       rax,2CE46590008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
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
       mov       rcx,2AB22458D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       test      rsi,rsi
       je        near ptr M00_L01
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2AB2245C8C8
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF9F5DB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2AB22455F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF9F62957E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,2AB22450008
       call      qword ptr [7FF9F68B6088]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DB62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L03
       mov       r8,[rdi+8]
       mov       edx,[r8+8]
       mov       r8d,[rsi+8]
       sub       r8d,edx
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB7240]; System.String.Substring(Int32, Int32)
M00_L00:
       mov       [rsp+20],rax
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
       ret
M00_L01:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,827
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rax,rsi
       jmp       near ptr M00_L00
; Total bytes of code 650
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
       call      qword ptr [7FF9F5D06658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F606CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF9F601ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF9F6642130]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F62268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF9F5CF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26A904003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F5E65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9F5DB5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F63959C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DBF750]
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DBEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L59
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L60
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68B6118]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DBEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DBEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68B69D0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M03_L41
       jmp       near ptr M03_L29
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F68B64D8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M03_L64
       cmp       dword ptr [rbp-68],1
       je        near ptr M03_L65
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F6095908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M03_L07:
       test      r15,r15
       je        near ptr M03_L66
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2AB22450008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,26A90401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61414A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L67
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L69
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L68
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L69
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L62
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L61
       call      qword ptr [7FF9F5F464F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L23
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F606E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L19
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M03_L22
       mov       ecx,r13d
       call      qword ptr [7FF9F5FCFDF8]; System.Number.UInt32ToDecStr(UInt32)
M03_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,2AB224656A0
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68B6910]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,26A9040EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L21
M03_L15:
       mov       rbx,26A9040EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M03_L20
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A879F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L26
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F606E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L27
M03_L19:
       call      CORINFO_HELP_OVERFLOW
M03_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,26A9040EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M03_L16
M03_L21:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,26A9040EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L22:
       test      rax,rax
       je        short M03_L24
       mov       rcx,rax
       call      qword ptr [7FF9F5FAF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L25
M03_L23:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C71568
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L13
M03_L24:
       call      qword ptr [7FF9F5FAF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L25:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FCFCA8]
       jmp       near ptr M03_L14
M03_L26:
       mov       r11,7FF9F5C71560
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L28
       cmp       [rcx],rdi
       jne       near ptr M03_L63
M03_L28:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L29:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L53
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L70
       mov       r8,2AB2245D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M03_L54
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L54
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F6096208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F6096280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M03_L43
M03_L30:
       mov       rdx,[rbp-130]
M03_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F613E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L40
M03_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M03_L50
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L49
M03_L33:
       test      rcx,rcx
       je        near ptr M03_L55
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6078128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M03_L42
       test      r8,r8
       je        near ptr M03_L40
M03_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M03_L51
       mov       [rbp-120],rax
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M03_L47
M03_L36:
       mov       rax,[rbp-100]
       lea       rcx,[rax+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,2AB224656C8
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M03_L56
       test      rax,rax
       je        near ptr M03_L57
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L52
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M03_L37:
       mov       rcx,26A9040EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L38:
       mov       rcx,26A9040EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-108]
M03_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A879F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L40:
       add       esi,1
       jo        near ptr M03_L58
       cmp       esi,r15d
       jl        near ptr M03_L29
M03_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L42:
       jmp       near ptr M03_L35
M03_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L44
       mov       r8,[rbp-88]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M03_L43
       jmp       near ptr M03_L30
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,26A9040EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,26A9040EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M03_L39
M03_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[rax+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60951B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F6095230]; System.MdUtf8String.ToString()
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M03_L36
M03_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,26A9040EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,26A9040EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M03_L38
M03_L49:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M03_L33
M03_L50:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L34
M03_L51:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M03_L36
M03_L52:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L37
M03_L53:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L54:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F636D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L55:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F636CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L56:
       mov       ecx,4
       call      qword ptr [7FF9F6044F30]
       int       3
M03_L57:
       mov       ecx,0E
       call      qword ptr [7FF9F6044F30]
       int       3
M03_L58:
       call      CORINFO_HELP_OVERFLOW
M03_L59:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6046670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L60:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L61:
       mov       r11,7FF9F5C71578
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L62:
       mov       rcx,rax
       mov       r11,7FF9F5C71558
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L63:
       mov       r11,7FF9F5C71570
       call      qword ptr [r11]
       jmp       near ptr M03_L28
M03_L64:
       mov       rcx,26A90401E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L65:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L66:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,0F
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6046670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L67:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L68:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L69:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FA5848]
       jmp       near ptr M03_L03
M03_L70:
       mov       rcx,rax
       mov       rdx,2AB2245D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L31
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF9F5C71570
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
; Total bytes of code 3611
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,word ptr [rsi+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],si
       lea       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,2AB2247E378
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; Total bytes of code 147
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L21
       test      rsi,rsi
       je        near ptr M05_L22
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L18
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-68],rdi
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L11
       jmp       near ptr M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L08
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,2AB2247E378
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L06
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L04:
       mov       eax,[r15+0C]
       mov       r13,[r15]
       cmp       eax,[r13+38]
       jae       short M05_L07
       mov       r12,[r13+10]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       short M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L04
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L06:
       mov       rcx,rdi
       mov       r11,7FF9F5C715D8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L19
M05_L07:
       mov       ecx,[r13+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       near ptr M05_L19
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADEB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L15
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L16
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,2AB2247E378
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L11:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L13
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L12:
       mov       ecx,[r15+0C]
       mov       rdx,[r15]
       cmp       ecx,[rdx+38]
       jae       short M05_L14
       mov       rcx,[r15]
       mov       r12,[rcx+10]
       mov       eax,[r15+0C]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L12
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L13:
       mov       rcx,rdi
       mov       r11,7FF9F5C715D8
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
       jmp       near ptr M05_L09
M05_L14:
       mov       rcx,[r15]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       short M05_L19
M05_L15:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADEB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L16:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r8,[rbp-60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L11
M05_L17:
       call      qword ptr [7FF9F601EFE8]
       int       3
M05_L18:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADEA70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L19:
       mov       rax,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rax
       jne       short M05_L23
M05_L20:
       mov       rax,r14
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       ecx,10
       call      qword ptr [7FF9F6044F30]
       int       3
M05_L22:
       mov       ecx,5
       call      qword ptr [7FF9F6044F30]
       int       3
M05_L23:
       mov       rcx,rdi
       mov       r11,7FF9F5C715E0
       call      qword ptr [r11]
       jmp       short M05_L20
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M05_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       je        short M05_L24
       mov       rcx,rdi
       mov       r11,7FF9F5C715E0
       call      qword ptr [r11]
M05_L24:
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
; Total bytes of code 1141
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
       lea       rcx,[7FF9F6B38AD0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6226A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF9F5CF539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,26A904003D8
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
       call      qword ptr [7FF9F6226A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF9F5E65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF9F620E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F620E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60466E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF9F601ECB8]
       int       3
M06_L10:
       mov       rcx,7FF9F5CF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF9F601ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63959C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M07_L00
       test      ebx,ebx
       je        short M07_L01
       cmp       eax,ebx
       je        short M07_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9F5DB7258]
       int       3
M07_L01:
       mov       rax,2AB22450008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F601EF40]
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
       mov       rax,2AB22450008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+50]
       test      rsi,rsi
       je        near ptr M00_L01
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,28E08908D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L02
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,28E0890C8C8
       xor       edx,edx
       call      qword ptr [7FF9F5D06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF9F5DB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,28E08900008
       mov       rcx,28E08905F40
       test      eax,eax
       cmovne    rdx,rcx
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,28E08900008
       call      qword ptr [7FF9F68B6088]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F5DB62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L03
       mov       r8,[rdi+8]
       mov       edx,[r8+8]
       mov       r8d,[rsi+8]
       sub       r8d,edx
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB7240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
M00_L00:
       mov       rcx,28E08900008
       test      rdi,rdi
       cmove     rdi,rcx
       mov       [rsp+20],rdi
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
       ret
M00_L01:
       xor       edi,edi
       jmp       short M00_L00
M00_L02:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,827
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rdi,rsi
       jmp       near ptr M00_L00
; Total bytes of code 538
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
       call      qword ptr [7FF9F5D06658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F606CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF9F601ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF9F6642110]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F62268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF9F5CF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24D7A8003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F5E65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF9F5DB5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9F63959C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9F5DBF750]
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
       sub       rsp,148
       vzeroupper
       lea       rbp,[rsp+180]
       xor       eax,eax
       mov       [rbp-0D8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF70
M03_L01:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L01
       mov       [rbp-40],rax
       mov       [rbp-150],rsp
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF9F5DBEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L49
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L50
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF9F68B6118]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF9F5DBEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF9F5DBEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       add       rsp,148
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
       call      qword ptr [7FF9F68B69D0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF9F5FA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M03_L41
       jmp       near ptr M03_L29
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FF9F68B64D8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-78]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF9F5D066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-68],0
       je        near ptr M03_L54
       cmp       dword ptr [rbp-68],1
       je        near ptr M03_L55
       lea       rdx,[rbp-78]
       mov       r8d,[rbp-68]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF9F6095908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-68]
       mov       [rbp-64],ecx
       mov       r15,[rbp-78]
M03_L07:
       test      r15,r15
       je        near ptr M03_L56
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,28E08900008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,24D7A801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF9F61414A8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L57
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L59
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L58
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L59
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF9F5DB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L52
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L51
       call      qword ptr [7FF9F5F464F0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L10:
       mov       rcx,rax
M03_L11:
       mov       [rbp-0E8],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L12:
       cmp       r12,rdi
       jne       near ptr M03_L22
       mov       rdx,r12
       mov       rcx,[rbp-0E8]
       add       rcx,8
       call      qword ptr [7FF9F606E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rbx,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L26
       mov       r15d,ecx
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       test      r13d,r13d
       jl        near ptr M03_L21
       mov       ecx,r13d
       call      qword ptr [7FF9F5FCFDF8]; System.Number.UInt32ToDecStr(UInt32)
M03_L14:
       lea       rcx,[rdi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       mov       rcx,28E08915678
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF9F68B6910]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r13,rax
       mov       rbx,24D7A80EF20
       mov       rdi,[rbx]
       test      rdi,rdi
       je        near ptr M03_L20
M03_L15:
       mov       rbx,24D7A80EF28
       mov       r9,[rbx]
       test      r9,r9
       je        short M03_L19
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r13
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A879F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,r15d
       mov       rcx,[rbp-0E8]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L25
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF9F606E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L27
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,24D7A80EF18
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,rbx
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r14
       jmp       near ptr M03_L16
M03_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,24D7A80EF18
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],rcx
       mov       rcx,rbx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L15
M03_L21:
       test      rax,rax
       je        short M03_L23
       mov       rcx,rax
       call      qword ptr [7FF9F5FAF8B8]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M03_L24
M03_L22:
       mov       rcx,[rbp-0E8]
       mov       r11,7FF9F5C71530
       call      qword ptr [r11]
       mov       rbx,rax
       jmp       near ptr M03_L13
M03_L23:
       call      qword ptr [7FF9F5FAF360]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M03_L24:
       mov       r8,[rax+28]
       mov       ecx,r13d
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF9F5FCFCA8]
       jmp       near ptr M03_L14
M03_L25:
       mov       r11,7FF9F5C71528
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L27:
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L28
       cmp       [rcx],rdi
       jne       near ptr M03_L53
M03_L28:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L29:
       mov       ecx,esi
       mov       rax,[r13+rcx*8]
       mov       [rbp-0F0],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M03_L66
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-0E0],rdx
       cmp       [rax],rdx
       jne       near ptr M03_L60
       mov       r8,28E0890D5E8
       mov       [rbp-128],r8
       test      r8,r8
       je        near ptr M03_L67
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M03_L67
       mov       rcx,[rax+30]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rdx,rax
       mov       rax,[rbp-0F0]
       mov       r8d,[rax+50]
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-90],xmm0
       vmovdqu   xmmword ptr [rbp-88],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0A8],xmm0
       vmovdqu   xmmword ptr [rbp-0A0],xmm0
       xor       ecx,ecx
       mov       [rsp+20],ecx
       lea       rcx,[rbp-0A8]
       mov       [rsp+28],rcx
       lea       rcx,[rbp-90]
       mov       r9,[rbp-128]
       call      qword ptr [7FF9F6096208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-128]
       mov       edx,[rbp-80]
       call      qword ptr [7FF9F6096280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-130],rax
       xor       eax,eax
       cmp       dword ptr [rbp-80],0
       jg        near ptr M03_L43
M03_L30:
       mov       rdx,[rbp-130]
M03_L31:
       lea       r8,[rbp-0B8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF9F613E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L32
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L40
M03_L32:
       mov       rax,[rbp-0F0]
       mov       r10,[rbp-0E0]
       cmp       [rax],r10
       jne       near ptr M03_L62
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L61
M03_L33:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF9F6078128]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L34:
       mov       r8,rax
       mov       [rbp-0F8],r8
       test      dil,dil
       je        near ptr M03_L42
       test      r8,r8
       je        near ptr M03_L40
M03_L35:
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-100],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       r8,[rbp-0E0]
       cmp       [rax],r8
       jne       near ptr M03_L64
       mov       r10,rax
       mov       [rbp-120],r10
       mov       rdx,[r10+8]
       test      rdx,rdx
       je        near ptr M03_L63
M03_L36:
       mov       r9,[rbp-100]
       lea       rcx,[r9+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       rcx,28E089156A0
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       rdx,rax
       mov       rcx,[rbp-0F8]
       mov       r8d,1
       call      qword ptr [7FF9F62957E8]
       mov       [rbp-140],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF9F5DB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M03_L65
       mov       rcx,offset MT_System.Linq.Enumerable+Concat2Iterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       r8,[rbp-148]
       mov       [r8+8],eax
       lea       rcx,[r8+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-148]
       lea       rcx,[r14+30]
       mov       rdx,[rbp-140]
       call      CORINFO_HELP_ASSIGN_REF
M03_L37:
       mov       rcx,24D7A80EF30
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L47
M03_L38:
       mov       rcx,24D7A80EF38
       mov       r9,[rcx]
       mov       [rbp-108],rax
       test      r9,r9
       je        near ptr M03_L46
       mov       rax,[rbp-108]
M03_L39:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF9F6A879F0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L40:
       add       esi,1
       jo        near ptr M03_L48
       cmp       esi,r15d
       jl        near ptr M03_L29
M03_L41:
       mov       rax,r14
       add       rsp,148
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L42:
       jmp       near ptr M03_L35
M03_L43:
       cmp       qword ptr [rbp-90],0
       jne       short M03_L44
       mov       r8,[rbp-88]
       jmp       short M03_L45
M03_L44:
       mov       r8,[rbp-90]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-90]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L45:
       mov       [rbp-0AC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-130]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0AC]
       inc       eax
       cmp       eax,[rbp-80]
       jl        short M03_L43
       jmp       near ptr M03_L30
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-110],r9
       mov       rcx,24D7A80EF18
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-110]
       mov       [r9+18],rcx
       mov       rcx,24D7A80EF38
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-110]
       mov       rax,[rbp-108]
       jmp       near ptr M03_L39
M03_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-118],rax
       mov       rcx,24D7A80EF18
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-118]
       mov       [rax+18],rcx
       mov       rcx,24D7A80EF30
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-118]
       jmp       near ptr M03_L38
M03_L48:
       call      CORINFO_HELP_OVERFLOW
M03_L49:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7F1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF9F6046670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L50:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF9F6046670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L51:
       mov       r11,7FF9F5C71540
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L52:
       mov       rcx,rax
       mov       r11,7FF9F5C71520
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L53:
       mov       r11,7FF9F5C71538
       call      qword ptr [r11]
       jmp       near ptr M03_L28
M03_L54:
       mov       rcx,24D7A801E10
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L55:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-70]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L56:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,0F
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF9F6046670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L57:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L58:
       call      qword ptr [7FF9F601E9D0]
       int       3
M03_L59:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF9F5FA5848]
       jmp       near ptr M03_L03
M03_L60:
       mov       rcx,rax
       mov       rdx,28E0890D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L31
M03_L61:
       mov       rax,[rbp-0F0]
       xor       ecx,ecx
       jmp       near ptr M03_L33
M03_L62:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rdx,rax
       mov       rax,rdx
       jmp       near ptr M03_L34
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0C8],xmm0
       mov       rdx,[r10+48]
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF9F60951B8]
       vmovups   xmm0,[rbp-0C8]
       vmovups   [rbp-0D8],xmm0
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF9F6095230]
       mov       rdx,rax
       mov       [rbp-138],rdx
       mov       rcx,[rbp-120]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-138]
       jmp       near ptr M03_L36
M03_L64:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M03_L36
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-140]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L37
M03_L66:
       call      qword ptr [7FF9F6334CF0]
       mov       ecx,0B32
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6145A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F628B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6334AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6046670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F636D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F636CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF9F6044F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF9F6044F30]
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
       lea       rbp,[rbp+180]
       mov       rdx,[rbp-0E8]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF9F5C71538
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
; Total bytes of code 3615
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+8]
       lea       rcx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,[rbx]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     esi,word ptr [rsi+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],si
       lea       rcx,[rbp+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+30]
       mov       rdx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       mov       rcx,28E0892E198
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
; Total bytes of code 147
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-80],rsp
       mov       [rbp-40],rcx
       mov       rbx,rcx
       mov       rdi,rdx
       mov       rsi,r9
       test      rdi,rdi
       je        near ptr M05_L21
       test      rsi,rsi
       je        near ptr M05_L22
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M05_L18
M05_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-68],rdi
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L11
       jmp       near ptr M05_L03
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L08
M05_L02:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,28E0892E198
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L03:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L06
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L04:
       mov       eax,[r15+0C]
       mov       r13,[r15]
       cmp       eax,[r13+38]
       jae       short M05_L07
       mov       r12,[r13+10]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       short M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L04
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L05:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L06:
       mov       rcx,rdi
       mov       r11,7FF9F5C715A0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L19
M05_L07:
       mov       ecx,[r13+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       near ptr M05_L19
M05_L08:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADE848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L15
M05_L10:
       lea       rdx,[rbp-50]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L16
       mov       r12,[rsi+8]
       mov       r15,[rbp-50]
       mov       r13,[rbp-48]
       mov       rcx,offset MT_System.String[]
       mov       edx,5
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rbp-70],rax
       mov       rcx,rax
       mov       r8,r14
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rdx,[r12+8]
       mov       r14,[rbp-70]
       lea       rcx,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       movzx     r15d,word ptr [r12+10]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],r15w
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+30]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r14
       mov       rcx,28E0892E198
       call      qword ptr [7FF9F68B6868]; DotNetTips.Spargine.Core.FastStringBuilder.Format(System.String, System.String[])
       mov       r14,rax
M05_L11:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       short M05_L13
       lea       r15,[rdi+8]
       mov       ecx,[r15+8]
       mov       rdx,[r15]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L17
M05_L12:
       mov       ecx,[r15+0C]
       mov       rdx,[r15]
       cmp       ecx,[rdx+38]
       jae       short M05_L14
       mov       rcx,[r15]
       mov       r12,[rcx+10]
       mov       eax,[r15+0C]
       lea       ecx,[rax+1]
       mov       [r15+0C],ecx
       cmp       eax,[r12+8]
       jae       near ptr M05_L05
       mov       ecx,eax
       lea       rcx,[rcx+rcx*2]
       lea       r8,[r12+rcx*8+10]
       cmp       dword ptr [r8+14],0FFFFFFFF
       jl        short M05_L12
       mov       rdx,[r8]
       mov       r12,[r8+8]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L09
M05_L13:
       mov       rcx,rdi
       mov       r11,7FF9F5C715A0
       call      qword ptr [r11]
       test      eax,eax
       je        short M05_L19
       jmp       near ptr M05_L09
M05_L14:
       mov       rcx,[r15]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [r15+0C],ecx
       xor       ecx,ecx
       mov       [r15+18],rcx
       mov       [r15+20],rcx
       jmp       short M05_L19
M05_L15:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADE848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L16:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-60],xmm0
       lea       r8,[rbp-60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L11
M05_L17:
       call      qword ptr [7FF9F601EFE8]
       int       3
M05_L18:
       mov       rcx,rbx
       mov       rdx,7FF9F6ADE770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L19:
       mov       rax,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rdi],rax
       jne       short M05_L23
M05_L20:
       mov       rax,r14
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L21:
       mov       ecx,10
       call      qword ptr [7FF9F6044F30]
       int       3
M05_L22:
       mov       ecx,5
       call      qword ptr [7FF9F6044F30]
       int       3
M05_L23:
       mov       rcx,rdi
       mov       r11,7FF9F5C715A8
       call      qword ptr [r11]
       jmp       short M05_L20
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
       lea       rbp,[rbp+0A0]
       cmp       qword ptr [rbp-68],0
       je        short M05_L24
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rdi,[rbp-68]
       cmp       [rdi],rcx
       je        short M05_L24
       mov       rcx,rdi
       mov       r11,7FF9F5C715A8
       call      qword ptr [r11]
M05_L24:
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
; Total bytes of code 1141
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
       lea       rcx,[7FF9F6B31A30]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F6226A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF9F5CF539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,24D7A8003D8
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
       call      qword ptr [7FF9F6226A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF9F5E65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF9F620E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF9F620E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60466E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF9F601ECB8]
       int       3
M06_L10:
       mov       rcx,7FF9F5CF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF9F601ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63959C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF9F5C64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F5DBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.String.Substring(Int32, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       mov       ecx,edi
       mov       eax,ebx
       add       rcx,rax
       mov       eax,[rsi+8]
       mov       edx,eax
       cmp       rcx,rdx
       ja        short M07_L00
       test      ebx,ebx
       je        short M07_L01
       cmp       eax,ebx
       je        short M07_L02
       mov       ecx,ebx
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,ebx
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       edx,edi
       lea       rdx,[rsi+rdx*2+0C]
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L00:
       mov       rcx,rsi
       mov       edx,edi
       mov       r8d,ebx
       call      qword ptr [7FF9F5DB7258]
       int       3
M07_L01:
       mov       rax,28E08900008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F601EF40]
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
       mov       rax,28E08900008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+50]
       call      qword ptr [7FF9F62F6100]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       [rsp+30],rax
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF9F62B5848]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
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
       mov       rax,1561000F918
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1561000F918
       xor       edx,edx
       jmp       qword ptr [7FF9F62F67D8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       call      qword ptr [7FF9F65EF390]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,15610001FC0
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF9F68B6F10]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,17A8
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0CCA
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       call      qword ptr [7FF9F5DD43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L06:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,196A1E82D10
       mov       r8d,1
       call      qword ptr [7FF9F62F5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L07:
       mov       rcx,rbx
       call      qword ptr [7FF9F62F6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L01
M02_L08:
       call      qword ptr [7FF9F62F6100]; System.Text.Json.JsonSerializerOptions.get_Default()
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       call      qword ptr [7FF9F68B60A0]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+50]
       test      rcx,rcx
       je        near ptr M00_L03
       mov       [rsp+30],rcx
       mov       rcx,15540C0EE78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9F62E6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9F62E6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65DF2B8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       call      qword ptr [7FF9F62E7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF9F634D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9F5DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62E6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF9F634D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF9F634D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF9F634D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F634D920]
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
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62E6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9F5DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62EC978]
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
       mov       rdx,195D2A22D10
       mov       r8d,1
       call      qword ptr [7FF9F62E5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9F62E67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,15540C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9F65C3918]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,195D2A21C08
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
       call      qword ptr [7FF9F634CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       mov       ecx,r15d
       mov       eax,r12d
       cmp       rcx,rax
       ja        short M03_L07
       mov       r12d,r15d
       jmp       short M03_L10
M03_L07:
       call      qword ptr [7FF9F602E9D0]
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
       call      qword ptr [7FF9F634E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9F66969E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF9F6314690
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15540C0F958
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9F65DFEB8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F66964F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9F66940D8]
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
       call      qword ptr [7FF9F602E9D0]
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
       call      qword ptr [7FF9F5E75BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,15540C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F65C3920]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
; Total bytes of code 1184
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
       jmp       qword ptr [7FF9F5DC43A8]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F602EF40]
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
       mov       rax,195D2A20008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
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
       mov       rcx,14BF6C0EE78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF9F62E6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF9F62E6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF9F65DF2B8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF9F6344CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6155A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F629B5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6344AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6056670]
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
       call      qword ptr [7FF9F62E7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF9F634D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF9F5DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62E6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF9F634D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF9F634D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF9F634D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF9F634D920]
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
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF9F62E6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F634D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF9F5DC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9F62EC978]
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
       mov       rdx,18C88C12D10
       mov       r8d,1
       call      qword ptr [7FF9F62E5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF9F62E67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,14BF6C01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF9F65C37A0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,18C88C11C08
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
       call      qword ptr [7FF9F634CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF9F602E9D0]
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
       call      qword ptr [7FF9F634E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF9F66969E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF9F6314690
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14BF6C0F958
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF9F65DFEB8]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F66964F0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF9F66940D8]
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
       call      qword ptr [7FF9F602E9D0]
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
       call      qword ptr [7FF9F5E75BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,14BF6C01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F65C37A8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FF9F5DC43A8]
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
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F602EF40]
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
       mov       rax,18C88C10008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F68A5CF8]; System.Data.DataTable..ctor()
       mov       rcx,1DFF73B5610
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F6295890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,1DFF73A0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,1DFF73B56B0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,1DFF73B5788
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,19F65401FC8
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,19F65401FD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,19F65401FD8
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
       mov       rcx,7FF9F5CF5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF9F6896CC0
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F606C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,19F654126E8
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
       mov       rdx,1DFF73B5630
       call      qword ptr [7FF9F5DB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF9F5E676D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68AE5E0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68AC9A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,19F65401E58
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
       call      qword ptr [7FF9F68AD728]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,19F65401FF0
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
       call      qword ptr [7FF9F5DB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF9F68989C0]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L04
M02_L00:
       call      qword ptr [7FF9F6905E60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L01
       call      qword ptr [7FF9F6334C48]
       mov       rbx,rax
M02_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F6046718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       r11,7FF9F5C71338
       call      qword ptr [r11]
       jmp       short M02_L04
M02_L03:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FF9F5C71340
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FF9F6905980]
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F62B5D70]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,7D9
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F6066670]
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
       test      ebx,ebx
       setg      cl
       mov       eax,ecx
       test      ecx,ecx
       je        near ptr M01_L17
M01_L00:
       test      eax,eax
       je        near ptr M01_L18
M01_L01:
       mov       rcx,2BF2F40D4E0
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M01_L20
       lea       rcx,[r14+20]
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-48]
       jne       near ptr M01_L20
M01_L02:
       mov       r15,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      r15,r15
       je        near ptr M01_L22
M01_L03:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FF9F60DC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M01_L07
       movzx     r12d,di
       mov       r14d,r12d
       add       r14d,1
       jo        near ptr M01_L10
M01_L04:
       movzx     edx,si
       mov       eax,r14d
       cmp       edx,eax
       jl        short M01_L08
M01_L05:
       mov       ecx,r12d
       call      qword ptr [7FF9F62F5E78]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L10
       mov       edx,eax
       mov       ecx,[r15+18]
       mov       eax,ecx
       mov       r8,[r15+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L09
       mov       [r8+rax*2+10],dx
       inc       ecx
       mov       [r15+18],ecx
M01_L06:
       add       r13d,1
       jo        short M01_L10
       cmp       r13d,ebx
       jl        short M01_L04
M01_L07:
       mov       rcx,r15
       call      qword ptr [7FF9F60E8140]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M01_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L13
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FF9F60DC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F5DD73F0]
       jmp       short M01_L16
M01_L12:
       call      qword ptr [7FF9F67865C8]
       test      eax,eax
       jne       short M01_L11
M01_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FF9F67865C8]
       test      eax,eax
       jne       short M01_L11
M01_L15:
       mov       rax,r14
M01_L16:
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M01_L23
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
M01_L17:
       movzx     ecx,byte ptr [rbp-40]
       test      cl,cl
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF9F5E847B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FF9F6354CD8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FF9F6354AF8]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,2FFBD4A86E0
       mov       r8,rsi
       call      qword ptr [7FF9F5E8D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BF2B8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L02
M01_L21:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r15,rax
       xor       eax,eax
       mov       [rbp-48],rax
       test      r15,r15
       jne       near ptr M01_L03
M01_L22:
       call      qword ptr [7FF9F6354CF0]
       mov       ecx,9BA
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1446
       mov       rdx,7FF9F6165A18
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF9F62AB5B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F5DD6B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF9F6354AE0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FF9F6066670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M01_L23:
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
       mov       rcx,2BF2F40D4E0
       mov       rsi,[rcx]
       mov       r15,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r15+18],rcx
       jne       short M01_L24
       mov       r14,[rbp-50]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r15+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L28
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF9F60DC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L25
M01_L24:
       mov       rdx,[rbp-50]
       mov       rcx,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       mov       r14,[rbp-50]
       je        short M01_L28
M01_L25:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L26
       lea       rcx,[rsi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L28
M01_L26:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L27
       mov       rcx,[rsi+18]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF9F65BF288]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L28
M01_L27:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L28:
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
; Total bytes of code 985
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
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF9F5E85B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9F603EF40]
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
       mov       rax,2FFBD4A0008
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
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
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF9F68B7018]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF9F6344D98]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FF9F6344AE0]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2DE222D5658
       mov       r8,rbx
       call      qword ptr [7FF9F6056670]
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
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF9F6776CA0]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFA52A42E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF9F6776CA0]
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
       call      qword ptr [7FF9F5DC73F0]
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
       call      qword ptr [7FF9F5DC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
M02_L02:
       mov       r8,29D9440DD88
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF9F68B7078]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M02_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF9F68A6770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L02
M02_L04:
       lea       rcx,[rsp+28]
       mov       rdx,2DE222D5878
       call      qword ptr [7FF9F5FB58F0]
M02_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF9F6214B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M02_L07
M02_L06:
       call      qword ptr [7FF9F602E9D0]
       int       3
M02_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M02_L08
       mov       rdx,2DE222C0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsp+28]
       mov       rdx,2DE222C0C48
       call      qword ptr [7FF9F5FB58F0]
M02_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F5FB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F6056718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L10:
       call      qword ptr [7FF9F6344D98]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L11
       call      qword ptr [7FF9F6344AE0]
       mov       rsi,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2DE222D5658
       mov       r8,rsi
       call      qword ptr [7FF9F6056670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF9F5FB56B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,2DE222D5884
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

## .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9F68B5B00]; System.Data.DataSet..ctor()
       mov       rcx,291640126E8
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
       mov       r8,2D1F5EA5610
       mov       [rbp-38],r8
       lea       r8,[rbp-40]
       mov       [rbp-70],r8
       mov       dword ptr [rbp-68],2
       lea       r8,[rbp-70]
       xor       ecx,ecx
       mov       rdx,2D1F5EA57A8
       call      qword ptr [7FF9F5DC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF9F5E776D8]
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
       mov       rdx,2D1F5EA5610
       call      qword ptr [7FF9F68B7378]; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
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
       mov       rcx,2D1F5EA5778
       mov       [rax+8],rcx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L31
M00_L04:
       mov       rcx,2D1F5EA5610
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
       call      qword ptr [7FF9F5D16658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M00_L06
M00_L09:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF9F60A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       call      qword ptr [7FF9F60A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       call      qword ptr [7FF9F60F6B58]; System.Reflection.RtFieldInfo.GetValue(System.Object)
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
       call      qword ptr [7FF9F60A5938]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
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
       call      qword ptr [7FF9F602ED48]
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
       mov       rcx,29164001EE0
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
       call      qword ptr [7FF9F6056028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FF9F60C44B0]
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
       call      qword ptr [7FF9F68BDD10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L26
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F68A8030]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L26:
       call      qword ptr [7FF9F607C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FF9F68A4210
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F6904240]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L28:
       mov       ecx,179
       mov       rdx,7FF9F6153BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F6904300]
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
       call      qword ptr [7FF9F5DC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L30:
       cmp       byte ptr [r15+1C4],0
       jne       near ptr M00_L03
       mov       ecx,179
       mov       rdx,7FF9F6153BB0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F6905188]
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
       call      qword ptr [7FF9F68A8030]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L32:
       call      qword ptr [7FF9F607C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rcx,2D1F5EA5630
       mov       [rbx+38],rcx
       lea       rcx,[rbx+40]
       mov       rsi,2D1F5E90008
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
       mov       rcx,7FF9F68A6334
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,rbx
       call      qword ptr [7FF9F607C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,291640126E8
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
       mov       rdx,2D1F5EA5660
       call      qword ptr [7FF9F5DC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF9F5E776D8]
M01_L00:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68B7018]; System.Data.DataTableCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF9F68B6F28]; System.Data.DataRelationCollection+DataSetRelationCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F5FD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rax,[7FFA53493CD8]
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
       call      qword ptr [7FFA534AAC68]
       lea       rcx,[rbp+8]
       call      qword ptr [7FFA534AAC80]; Precode of System.Text.ValueStringBuilder.ToString()
       lea       rcx,[7FFA53493CD8]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M02_L01
       call      qword ptr [7FFA53493D28]; CORINFO_HELP_FAIL_FAST
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
       call      qword ptr [7FFA534AACC8]
       jmp       short M02_L00
M02_L03:
       mov       rcx,[7FFA534C0A08]
       mov       rcx,[rcx]
       call      qword ptr [7FFA534A3938]
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
       call      qword ptr [7FF9F5DC43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       r9,[rsi+8]
       mov       r9,[r9+50]
       mov       rcx,[r13+70]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F68B6B68]
       mov       r12d,eax
       cmp       r12d,1
       jne       short M03_L03
       mov       rcx,r13
       call      qword ptr [7FF9F68BC708]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF9F5DC61C0]; System.String.Equals(System.String, System.String)
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
       call      qword ptr [7FF9F68BC708]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF9F5DC61C0]; System.String.Equals(System.String, System.String)
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
       mov       rax,7FFA558927C0
       call      rax
M04_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFA55C7A0DC],0
       je        short M04_L03
       call      qword ptr [7FFA55C6A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9F5DC5440]; System.RuntimeTypeHandle.GetNativeHandle()
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
       mov       rax,7FFA5580B840
       call      rax
M04_L09:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFA55C7A0DC],0
       je        short M04_L10
       call      qword ptr [7FFA55C6A3A8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9F5DC5998]
       jmp       near ptr M04_L00
M04_L14:
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M04_L15:
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rax,7A60D6FAB6AF
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
       call      qword ptr [7FF9F60A4EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M05_L01:
       lea       rdx,[rbp+20]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF9F60A4EB8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+20]
       mov       rcx,7A60D6FAB6AF
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
       mov       rcx,291640009F0
       mov       rcx,[rcx]
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FF9F601A448]; Precode of System.Text.UTF8Encoding.GetByteCount(Char*, Int32)
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
       call      qword ptr [7FF9F60A4EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
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
       call      qword ptr [7FF9F60A4EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
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
       mov       rdx,7FF9F674F118
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
       mov       rdx,7FF9F674F070
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M06_L09:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF9F60A5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
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
       call      qword ptr [7FF9F60E71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,rbx
       call      qword ptr [7FF9F60E73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M07_L04
M07_L10:
       mov       rcx,rdi
       call      qword ptr [7FF9F5D16658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L06
M07_L11:
       mov       rcx,rdi
       call      qword ptr [7FF9F5D16658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L07
M07_L12:
       test      rdi,rdi
       je        short M07_L14
       mov       rcx,rbx
       call      qword ptr [7FF9F60BFA60]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M07_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F637DC08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F6056718]
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
       call      qword ptr [7FF9F6267EB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L15:
       test      rsi,rsi
       jne       short M07_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F63A6028]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF9F60ADB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L16:
       call      qword ptr [7FF9F637CE70]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F60F6B08]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FF9F637C780]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9F5DCF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M07_L17:
       call      qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,7FF9F6782A34
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
       jmp       qword ptr [7FF9F5E75BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,[7FFA534BC048]
       cmp       r11,[rcx]
       jne       short M09_L00
       jmp       short M09_L01
M09_L00:
       lea       r11,[7FFA53491140]
       call      qword ptr [r11]
       mov       rcx,rax
M09_L01:
       call      qword ptr [7FFA5349EF00]
       test      rax,rax
       je        short M09_L03
       xor       edx,edx
       test      bl,bl
       sete      dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[7FFA534A2FE0]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M09_L02:
       mov       rcx,[7FFA534C09E8]
       mov       rcx,[rcx]
       call      qword ptr [7FFA534A3938]
       int       3
M09_L03:
       call      qword ptr [7FFA5349BF98]
       mov       rbx,rax
       call      qword ptr [7FFA534A52B8]
       mov       rdx,rax
       mov       r8,[7FFA534C09E8]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFA534A38E8]
       mov       rcx,rbx
       call      qword ptr [7FFA53493D08]; CORINFO_HELP_THROW
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
       jmp       qword ptr [7FF9F607C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FF9F5C74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9F60566E8]
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
       jmp       qword ptr [7FF9F5DC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.Object.GetType()
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

