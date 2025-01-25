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
       call      qword ptr [7FF95CA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FF95D004C60]
       mov       ecx,76B
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
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
       jmp       qword ptr [7FF95CA843A8]
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
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCEEF40]
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
       mov       rax,2A4C0D20008
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF95D54C288]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       [rsp+30],rax
       mov       rcx,2009500EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2AE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        short M00_L04
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       cmp       dword ptr [rax+8],0
       jne       short M00_L05
       jmp       short M00_L05
M00_L03:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M00_L09
       jmp       short M00_L02
M00_L04:
       xor       ecx,ecx
M00_L05:
       test      ecx,ecx
       je        near ptr M00_L10
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF95D54DAE8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF95CD24F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FF95C950FB0
       call      qword ptr [r11]
       test      rax,rax
       jne       near ptr M00_L00
M00_L08:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rdx,rax
       call      qword ptr [7FF95CA943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       call      qword ptr [7FF95D014D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FF95D014A50]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24126CE5A88
       mov       r8,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 559
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       push      rdi
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M01_L01
       mov       rbx,[rdx]
       movzx     esi,word ptr [rbx+0E]
       test      rsi,rsi
       je        short M01_L04
       mov       rdi,[rbx+38]
       cmp       rsi,4
       jl        short M01_L03
M01_L00:
       cmp       [rdi],rcx
       je        short M01_L01
       cmp       [rdi+8],rcx
       je        short M01_L01
       cmp       [rdi+10],rcx
       jne       short M01_L02
M01_L01:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       cmp       [rdi+18],rcx
       je        short M01_L01
       add       rdi,20
       add       rsi,0FFFFFFFFFFFFFFFC
       cmp       rsi,4
       jl        short M01_L06
       jmp       short M01_L00
M01_L03:
       cmp       [rdi],rcx
       je        short M01_L01
       add       rdi,8
       dec       rsi
       test      rsi,rsi
       jg        short M01_L03
M01_L04:
       test      dword ptr [rbx],406C0000
       jne       short M01_L05
       xor       edx,edx
       jmp       short M01_L01
M01_L05:
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF95CA94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L06:
       test      rsi,rsi
       je        short M01_L04
       jmp       short M01_L03
; Total bytes of code 121
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
       mov       rdx,7FF95D6ABF90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF95D6AC190
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
       mov       rdx,7FF95D6AC1A8
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
       mov       rdx,7FF95D6AC2B8
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
       mov       rdx,7FF95D6AC180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95D6B5260]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FF95D6AC180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FF95D6B52D8]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF95D6AC180
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95D6B5368]
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
       mov       rdx,7FF95D6AC2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FF95CF35578]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FF95CFB7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M03_L05
       call      qword ptr [7FF95D01D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFB6E68]
       test      eax,eax
       je        near ptr M03_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF95D01D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF95D01D920]
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
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CFB6730]
       jmp       short M03_L09
M03_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D7B8]
       jmp       short M03_L09
M03_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFBC978]
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
       mov       rdx,24126CD2D10
       mov       r8d,1
       call      qword ptr [7FF95CFB5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF95CFB67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,20095001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF95D26D750]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,24126CD1C08
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
       call      qword ptr [7FF95D01CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95D01E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF95D3659E0]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L13:
       mov       rcx,7FF95CFE3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2009500F660
       mov       rdi,[rcx]
       jmp       near ptr M05_L03
M05_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF95D2AED60]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF95D3654E8]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF95D2AEEE0]
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95CB45BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,20095001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF95D26D758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FF95D446400]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FF95D446400]
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
       call      qword ptr [7FF95CA973F0]
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
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M07_L01
       jmp       short M07_L01
M07_L00:
       xor       eax,eax
M07_L01:
       test      eax,eax
       je        near ptr M07_L10
       cmp       [rcx],ecx
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L03
M07_L02:
       mov       r8,2009500DA78
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF95D54DB48]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M07_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,rsi
       mov       rdx,7FF95D559028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M07_L02
M07_L04:
       lea       rcx,[rsp+28]
       mov       rdx,24126CE5C88
       call      qword ptr [7FF95CC858F0]
M07_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF95CEE4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M07_L07
M07_L06:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M07_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M07_L08
       mov       rdx,24126CD0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M07_L09
M07_L08:
       lea       rcx,[rsp+28]
       mov       rdx,24126CD0C48
       call      qword ptr [7FF95CC858F0]
M07_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CD26718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L10:
       call      qword ptr [7FF95D014D08]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M07_L11
       call      qword ptr [7FF95D014A50]
       mov       rsi,rax
M07_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,24126CE5A88
       mov       r8,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF95CC856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,24126CE5C94
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
; Total bytes of code 552
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,24126CD0008
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
       jmp       qword ptr [7FF95CA943A8]
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
       mov       rcx,1F45200EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2AE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FF95D547498]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FF95CA943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FF95D014D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FF95D014A50]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,234E3F65970
       mov       r8,rbx
       call      qword ptr [7FF95CD26670]
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
       call      qword ptr [7FF95CFB7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF95D01D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFB6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF95D01D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF95D01D920]
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
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CFB6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFBC978]
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
       mov       rdx,234E3F52D10
       mov       r8d,1
       call      qword ptr [7FF95CFB5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF95CFB67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rcx,1F452001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF95D26D750]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,234E3F51C08
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
       call      qword ptr [7FF95D01CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95D01E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF95D3659E0]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF95CFE3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F45200F660
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF95D2AED60]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF95D3654E8]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF95D2AEEE0]
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
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95CB45BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1F452001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF95D26D758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF95D446400]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF95D446400]
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
       call      qword ptr [7FF95CA973F0]
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
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,1F45200DA78
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF95D5474F8]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FF95D5557A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,234E3F65B70
       call      qword ptr [7FF95CC858F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF95CEE4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,234E3F50C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,234E3F50C48
       call      qword ptr [7FF95CC858F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CD26718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FF95D014D08]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FF95D014A50]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,234E3F65970
       mov       r8,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF95CC856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,234E3F65B7C
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,234E3F50008
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
       jmp       qword ptr [7FF95CA943A8]
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
       mov       rcx,2BD5140EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF95CFC6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF95CFC6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2BE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF95CAA7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF95D555FE0]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF95D024C60]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FF95CAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FF95D024D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FF95D024A50]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2FDE33053B8
       mov       r8,rbx
       call      qword ptr [7FF95CD36670]
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
       call      qword ptr [7FF95CFC7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF95D02D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF95CAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFC6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF95D02D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF95D02D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF95D02D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF95D02D920]
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
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CFC6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF95CAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFCC978]
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
       mov       rdx,2FDE32F2D10
       mov       r8d,1
       call      qword ptr [7FF95CFC5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF95CFC67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,2BD51401F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF95D27D750]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,2FDE32F1C08
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
       call      qword ptr [7FF95D02CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF95CD0E9D0]
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
       call      qword ptr [7FF95D02E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF95D3759E0]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF95CFF3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2BD5140F660
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF95D2BED60]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF95D3754E8]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF95D2BEEE0]
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
       call      qword ptr [7FF95CD0E9D0]
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
       call      qword ptr [7FF95CB55BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,2BD51401F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF95D27D758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF95D456400]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF95D456400]
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
       call      qword ptr [7FF95CAA73F0]
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
       call      qword ptr [7FF95CAA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,2BD5140DA78
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF95D556040]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FF95D560A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,2FDE3305558
       call      qword ptr [7FF95CC958F0]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF95CEF4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FF95CD0E9D0]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,2FDE32F0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,2FDE32F0C48
       call      qword ptr [7FF95CC958F0]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95CC95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CD36718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FF95D024D08]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FF95D024A50]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2FDE33053B8
       mov       r8,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF95CC956B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,2FDE3305564
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD0EF40]
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
       mov       rax,2FDE32F0008
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
       jmp       qword ptr [7FF95CAA43A8]
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
       call      qword ptr [7FF95CF95728]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L23
       mov       rax,158E8C009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,158E8C0EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF95CFD6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L24
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L25
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2CE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L27
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L26
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF95CD9D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L29
       cmp       r9d,r15d
       jne       near ptr M01_L28
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
       call      qword ptr [7FF95CD09E58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r14,r14
       je        near ptr M01_L30
       lea       rsi,[r14+10]
       mov       ebx,[r14+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rdx,[r12+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L31
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
       mov       rcx,19976B59070
       xor       r9d,r9d
       call      qword ptr [7FF95D57FEE8]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       r12,10
       mov       ebx,20
       mov       rcx,158E8C0EB78
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L20
       mov       rcx,[rcx+18]
M01_L06:
       mov       rdi,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       near ptr M01_L22
       mov       rcx,[rdi+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L17
       lea       rcx,[rdi+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L17
M01_L07:
       mov       rdi,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF95CDBC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],rdi
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L16
M01_L10:
       mov       ecx,r14d
       movzx     ecx,byte ptr [r12+rcx]
       mov       r8,158E8C00428
       mov       r8,[r8]
       mov       rdx,19976B653E0
       call      qword ptr [7FF95CCF4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L14:
       mov       rcx,rdi
       call      qword ptr [7FF95CDBCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       inc       r14d
       cmp       r14d,ebx
       jl        near ptr M01_L10
M01_L16:
       mov       rcx,rdi
       call      qword ptr [7FF95CDC7A60]; System.Text.StringBuilder.ToString()
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
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D29D4A0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L18
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M01_L07
M01_L18:
       mov       rsi,[rdi+8]
       mov       rcx,7FF95D299A40
       cmp       [rsi+18],rcx
       jne       short M01_L21
       mov       r14,[rsi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FF95CDBC0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L19:
       jmp       near ptr M01_L08
M01_L20:
       call      qword ptr [7FF95CF25E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L21:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdi,rax
       jmp       short M01_L19
M01_L22:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L09
M01_L23:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF95CD46670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L24:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,19976B52D10
       mov       r8d,1
       call      qword ptr [7FF95CFD5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r12,rax
       lea       rcx,[rsi+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r12
       jmp       near ptr M01_L02
M01_L25:
       call      qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L26:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF95CD950C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L27:
       mov       ecx,1763
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD466E8]
       int       3
M01_L28:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FF95CABC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L29:
       call      qword ptr [7FF95CABC7E0]
       int       3
M01_L30:
       mov       ecx,6A61
       mov       rdx,7FF95CFBE1A0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD466E8]
       int       3
M01_L31:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D50E2E0]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF95CFBE1A0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CABF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
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
       mov       rcx,158E8C0EB78
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L33
       call      qword ptr [7FF95CF25E78]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M01_L34
M01_L33:
       mov       rdi,[rcx+18]
M01_L34:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [rdi],rcx
       jne       near ptr M01_L39
       mov       rax,[rdi+10]
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
       call      qword ptr [7FF95CDBC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L36
M01_L35:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L40
M01_L36:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L37
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L40
M01_L37:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L38
       mov       r15,[rdi+18]
       mov       rcx,[r15+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95D29D9C8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L40
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FF95D29D488]
       jmp       short M01_L40
M01_L38:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       short M01_L40
M01_L39:
       mov       rcx,rdi
       mov       rdx,[rbp-0A8]
       mov       rax,[rdi]
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
; Total bytes of code 1717
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
       call      qword ptr [7FF95CF85380]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L28
       mov       rax,1D981C009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,1D97DC0CB78
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF95CFC5D58]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L29
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L30
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2BE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L20
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L19
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FF95CD8D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L32
       cmp       r9d,r15d
       jne       near ptr M01_L31
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
       call      qword ptr [7FF95CCF9E58]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L21
       lea       rbx,[rax+10]
       mov       r14d,[rax+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L22
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
       mov       rcx,21A0FB19070
       xor       r9d,r9d
       call      qword ptr [7FF95D596130]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       rsi,10
       mov       ebx,20
       mov       rcx,1D97DC0CB80
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M01_L23
       mov       rcx,[rcx+18]
M01_L06:
       mov       r14,rcx
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L27
       mov       rcx,[r14+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L17
       lea       rcx,[r14+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L17
M01_L07:
       mov       r14,[rbp-68]
M01_L08:
       xor       ecx,ecx
       mov       [rbp-68],rcx
M01_L09:
       cmp       [r14],r14b
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF95CDAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       [rbp-0A8],r14
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L16
M01_L10:
       mov       ecx,r15d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,1D981C00428
       mov       r8,[r8]
       mov       rdx,21A0FB253B8
       call      qword ptr [7FF95CCE4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       test      rax,rax
       je        short M01_L15
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L15
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
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
       mov       [r14+18],r12d
       jmp       short M01_L15
M01_L12:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L11
M01_L13:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L11
M01_L14:
       mov       rcx,r14
       call      qword ptr [7FF95CDACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L15:
       inc       r15d
       cmp       r15d,ebx
       jl        near ptr M01_L10
M01_L16:
       mov       rcx,r14
       call      qword ptr [7FF95CDB7A60]; System.Text.StringBuilder.ToString()
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
       mov       r12,[r14+18]
       mov       rdi,[r12+18]
       lea       rdx,[rbp-68]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF95D28D998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L24
M01_L18:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M01_L07
M01_L19:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF95CD850C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L20:
       mov       ecx,1763
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD366E8]
       int       3
M01_L21:
       mov       ecx,6A61
       mov       rdx,7FF95CFAE1A0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD366E8]
       int       3
M01_L22:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D4EE2E0]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF95CFAE1A0
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CAAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       call      qword ptr [7FF95CF15680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L24:
       cmp       qword ptr [rdi+10],0
       jne       short M01_L25
       xor       edx,edx
       mov       [rbp-68],rdx
       jmp       short M01_L26
M01_L25:
       lea       rdx,[rbp-68]
       mov       rcx,r12
       call      qword ptr [7FF95D28D4B8]
       test      eax,eax
       jne       near ptr M01_L18
M01_L26:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M01_L08
M01_L27:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L09
M01_L28:
       call      qword ptr [7FF95D024438]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35190
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D024228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,21A0FB12D10
       mov       r8d,1
       call      qword ptr [7FF95CFC5608]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r15,rax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r15
       jmp       near ptr M01_L02
M01_L30:
       call      qword ptr [7FF95CAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L31:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FF95CAAC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L32:
       call      qword ptr [7FF95CAAC7E0]
       int       3
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
       mov       rcx,1D97DC0CB80
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       je        short M01_L34
       call      qword ptr [7FF95CF15680]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r14,rax
       jmp       short M01_L35
M01_L34:
       mov       r14,[rcx+18]
M01_L35:
       mov       rcx,offset MT_Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.Text.StringBuilder, System.Private.CoreLib]]
       cmp       [r14],rcx
       jne       near ptr M01_L40
       mov       rax,[r14+10]
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
       call      qword ptr [7FF95CDAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L37
M01_L36:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L41
M01_L37:
       cmp       qword ptr [r14+20],0
       jne       short M01_L38
       lea       rcx,[r14+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L41
M01_L38:
       lea       rcx,[r14+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r14+28]
       jg        short M01_L39
       mov       r14,[r14+18]
       mov       rcx,[r14+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF95D28D9C8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L41
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FF95D28D488]
       jmp       short M01_L41
M01_L39:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       short M01_L41
M01_L40:
       mov       rbx,[rbp-0A8]
       mov       rcx,r14
       mov       rdx,rbx
       mov       rax,[r14]
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
       call      qword ptr [7FF95D584960]; System.Data.DataTable..ctor()
       mov       rcx,27B857053B8
       mov       [rbx+70],rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rsp+28]
       xor       r8d,r8d
       mov       r9d,34
       call      qword ptr [7FF95C9E6700]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
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
       mov       rcx,27B856FEBD8
       call      qword ptr [7FF95C9DA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L05
       xor       edx,edx
       call      qword ptr [7FF95CF75890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M00_L05
M00_L08:
       call      qword ptr [7FF95CB45BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       short M00_L04
M00_L10:
       mov       rcx,23AF3801EE0
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
       call      qword ptr [7FF95CCFED48]
       int       3
M00_L13:
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+28],rax
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FF95CDB73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
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
       mov       rsi,27B856F0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,27B85705458
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,27B85705530
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,23AF3801FD0
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,23AF3801FD8
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,23AF3801FE0
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
       mov       rcx,7FF95C9D5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF95D56D090
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF95CD4C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,23AF38123F0
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
       mov       rdx,27B857053D8
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF95CB476D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D58CF00]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D587210]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,23AF3801E58
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
       call      qword ptr [7FF95D58C048]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,23AF3801FF8
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
       mov       rcx,23AF3800590
       mov       rcx,[rcx]
       call      qword ptr [7FF95D444DC8]
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
       mov       rsi,27B856F0008
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95C9E6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       short M02_L07
M02_L10:
       lea       rcx,[r12+20]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FF95CD4CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M02_L11
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF95CD74E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M02_L11:
       mov       r13,rax
       jmp       short M02_L16
M02_L12:
       lea       rcx,[r12+28]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FF95CD4CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L13
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF95CD74E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       call      qword ptr [7FF95CD74E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       call      qword ptr [7FF95CD74BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       ecx,r12d
       call      qword ptr [7FF95CF355A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,57
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       call      qword ptr [7FF95D04F630]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rsi
       call      qword ptr [7FF95CB4D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L22:
       mov       rcx,rax
       mov       rdx,rsi
       mov       r8d,r15d
       call      qword ptr [7FF95C9E6538]
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
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95C9E4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF95C9E6148]
M03_L02:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        short M03_L06
       mov       rcx,rsi
       call      qword ptr [7FF95C9DA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
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
       je        short M04_L04
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M04_L03
M04_L00:
       cmp       [r9],rcx
       je        short M04_L01
       cmp       [r9+8],rcx
       je        short M04_L01
       cmp       [r9+10],rcx
       jne       short M04_L02
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       cmp       [r9+18],rcx
       je        short M04_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jge       short M04_L00
       test      r10,r10
       je        short M04_L04
M04_L03:
       cmp       [r9],rcx
       je        short M04_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M04_L03
M04_L04:
       test      dword ptr [r8],406C0000
       jne       short M04_L05
       xor       edx,edx
       jmp       short M04_L01
M04_L05:
       jmp       qword ptr [7FF95CA94378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 110
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M05_L00
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       cmp       [rbx],rcx
       jne       short M05_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF95D58D560]; System.Threading.ReaderWriterLockSlim.Dispose(Boolean)
       jmp       short M05_L03
M05_L00:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FF95C951050
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FF95D5D6910]
       test      eax,eax
       je        short M05_L03
       call      qword ptr [7FF95D5D6DF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L01
       call      qword ptr [7FF95D014BB8]
       mov       rbx,rax
M05_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95CD26718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M05_L02:
       mov       rcx,rbx
       mov       r11,7FF95C951048
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
       call      qword ptr [7FF9BC201D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M06_L00
M06_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF9BC201D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF9BC201D38]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,27A503353E0
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FF95C9CA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FF95C9D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FF95CCEF1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF95CD64B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF95D13CC00]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FF95C9D5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF95CD64B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FF95C934000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD166E8]
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
       call      qword ptr [7FF95CD64B70]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
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
       mov       rdx,22E88D753B8
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FF95C9EA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FF95C9F66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FF95CD0F1B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF95CD84B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF95D15CC00]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FF95C9F5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FF95CD84B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD366E8]
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
       call      qword ptr [7FF95CD84B70]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
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
       mov       rdx,2DAD25753B8
       call      qword ptr [7FF95CF8FFA8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
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
       jne       short M01_L05
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
       je        near ptr M01_L12
M01_L01:
       test      eax,eax
       je        short M01_L07
M01_L02:
       test      rbx,rbx
       je        near ptr M01_L10
       mov       edx,[rbx+8]
       cmp       edx,ebp
       jl        near ptr M01_L09
       xor       r14d,r14d
       cmp       edx,ecx
       setle     r14b
M01_L03:
       test      r14d,r14d
       je        near ptr M01_L11
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
       test      rbx,rbx
       je        short M01_L00
       mov       eax,[rdi+8]
       cmp       eax,[rbx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF95CB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95D034C48]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L08
       call      qword ptr [7FF95D034A68]
       mov       r14,rax
M01_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2DAD256F418
       mov       r8,r14
       call      qword ptr [7FF95CB6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       xor       r14d,r14d
       jmp       near ptr M01_L03
M01_L10:
       xor       r14d,r14d
       jne       near ptr M01_L04
M01_L11:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0A13
       mov       rdx,7FF95CE443D0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF95CFD5B78]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CB6D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       movzx     edx,byte ptr [rsp+28]
       test      dl,dl
       je        near ptr M01_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95CB647B0]
       mov       ecx,eax
       jmp       near ptr M01_L02
; Total bytes of code 387
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
       call      qword ptr [7FF95CF5FF80]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
       mov       rcx,23B48278D90
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
       call      qword ptr [7FF95C9D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,23B4827C8C8
       xor       edx,edx
       call      qword ptr [7FF95C9D6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FF95CA861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,23B48275F40
       test      eax,eax
       cmovne    rdi,rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF65440]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,23B48270008
       call      qword ptr [7FF95D5748D0]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CA862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M01_L06
       mov       rcx,[rsi+8]
       mov       esi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,23B48274388
       call      qword ptr [7FF95CF24F60]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,esi
       mov       rdx,23B48274368
       call      qword ptr [7FF95CF24F60]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF95C934000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FF95D88EFA0]
       int       3
M01_L03:
       mov       rax,23B48270008
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FF95D004438]
       mov       ecx,76B
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15138
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FF95D004438]
       mov       ecx,7B3
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15138
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rax,rbx
       jmp       near ptr M01_L01
M01_L07:
       mov       rax,rbx
       jmp       near ptr M01_L01
; Total bytes of code 778
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
       mov       rdx,2F1C2570008
       mov       r8d,1
       call      qword ptr [7FF95CF657E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF95CA8EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D564060]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CA8EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CA8EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D5645A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC75740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D564420]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9D66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD65908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2F1C2570008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,2B134401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE10C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CA843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FF95CC25EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD3E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CC94180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2F1C25853E8
       call      qword ptr [7FF95CA86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF657E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D5644E0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2B13840CC30
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2B13840CC28
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,2B13840CC38
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D775BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD3E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,2B13840CC28
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
       mov       r11,7FF95C9411F0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FF95C9411E8
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,2F1C257D5E8
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
       call      qword ptr [7FF95CD66208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD66280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L41
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE0E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD47910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       je        near ptr M01_L37
M01_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       mov       r9,2B134400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L32
       mov       r9,2B134400418
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
       mov       rdx,2F1C2585410
       call      qword ptr [7FF95CA86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF657E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CA84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,2B13840CC40
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L45
M01_L35:
       mov       rcx,2B13840CC48
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
       call      qword ptr [7FF95D775BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,2B13840CC28
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2B13840CC48
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2B13840CC28
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2B13840CC40
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L46:
       call      CORINFO_HELP_OVERFLOW
M01_L47:
       call      qword ptr [7FF95D004C60]
       mov       ecx,77D
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD16670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L48:
       call      qword ptr [7FF95D004C60]
       mov       ecx,76B
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L49:
       mov       r11,7FF95C941200
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L50:
       mov       rcx,rax
       mov       r11,7FF95C9411E0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L51:
       mov       r11,7FF95C9411F8
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L52:
       mov       rcx,2B134401E10
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
       call      qword ptr [7FF95D004C60]
       mov       ecx,0F
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD16670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L56:
       call      qword ptr [7FF95CCEE9D0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC75848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,2F1C257D5E8
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
       call      qword ptr [7FF95CC94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CD651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD65230]
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
       call      qword ptr [7FF95D004C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE15108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF5AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D004A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D03D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C934000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D03CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA8F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FF95CD14F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FF95CD14F30]
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
       call      qword ptr [7FF95CA84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF95C9411F8
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
; Total bytes of code 3768
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
       mov       rdx,27372DD0008
       xor       r8d,r8d
       call      qword ptr [7FF95CF757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF95CA9EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D4EF4E0]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CA9EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CA9EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D4EFA20]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D4EF8A0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,27372DD0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,232E5001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE20C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CA943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FF95CC35EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,27372DE53E8
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D4EF960]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,232E100CC30
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,232E100CC28
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,232E100CC38
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D707A20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,232E100CC28
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
       mov       r11,7FF95C950D90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FF95C950D88
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,27372DDD5E8
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
       call      qword ptr [7FF95CD76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L41
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE1E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD57910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       je        near ptr M01_L37
M01_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       mov       r9,232E5000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L32
       mov       r9,232E5000418
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
       mov       rdx,27372DE5410
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,232E100CC40
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L45
M01_L35:
       mov       rcx,232E100CC48
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
       call      qword ptr [7FF95D707A20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,232E100CC28
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,232E100CC48
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,232E100CC28
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,232E100CC40
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L46:
       call      CORINFO_HELP_OVERFLOW
M01_L47:
       call      qword ptr [7FF95D014C60]
       mov       ecx,77D
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L48:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L49:
       mov       r11,7FF95C950DA0
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L50:
       mov       rcx,rax
       mov       r11,7FF95C950D80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L51:
       mov       r11,7FF95C950D98
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L52:
       mov       rcx,232E5001E10
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0F
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L56:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC85848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,27372DDD5E8
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
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CD751B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD75230]
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FF95CD24F30]
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FF95C950D98
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
; Total bytes of code 3768
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
       mov       rdx,28BC6570008
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF95CA9EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L51
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D4CE040]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CA9EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CA9EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D4CE580]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M01_L40
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF95D4CE400]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L56
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,28BC6570008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,24B34801DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE20C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L10:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CA943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L54
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L53
       call      qword ptr [7FF95CC35EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L11:
       mov       rcx,rax
M01_L12:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L13:
       cmp       r12,rdi
       jne       near ptr M01_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FF95CD4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L22
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,28BC6585410
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D4CE4C0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,24B3480EC28
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,24B3480EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,24B3480EC30
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D6D5C20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L13
       jmp       near ptr M01_L23
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,24B3480EC20
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FF95C950E90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L21:
       mov       r11,7FF95C950E88
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L24
       cmp       [rcx],rdi
       jne       near ptr M01_L55
M01_L24:
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
M01_L25:
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
       mov       r8,28BC657D5E8
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
       call      qword ptr [7FF95CD76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L44
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE1E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L39
M01_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L62
       mov       rcx,[rax+18]
M01_L29:
       test      rcx,rcx
       je        near ptr M01_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF95CD57910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L30:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L31
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M01_L39
M01_L31:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],4
       jl        near ptr M01_L43
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        near ptr M01_L42
       mov       r8,[rdx]
       add       r8,10
M01_L32:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L33
       mov       r10,24B34800438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L33
       mov       r10,24B34800418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L65
M01_L33:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M01_L41
M01_L34:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M01_L48
M01_L35:
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
       mov       rdx,28BC6585438
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M01_L36:
       mov       rcx,24B3480EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L49
M01_L37:
       mov       rcx,24B3480EC40
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L47
       mov       rax,[rbp-138]
M01_L38:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D6D5C20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L39:
       add       esi,1
       jo        near ptr M01_L50
       cmp       esi,r15d
       jl        near ptr M01_L25
M01_L40:
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
M01_L41:
       jmp       near ptr M01_L66
M01_L42:
       jmp       near ptr M01_L64
M01_L43:
       jmp       near ptr M01_L64
M01_L44:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L45
       mov       r8,[rbp-98]
       jmp       short M01_L46
M01_L45:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M01_L46:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M01_L44
       jmp       near ptr M01_L26
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,24B3480EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,24B3480EC40
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L38
M01_L48:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CD751B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD75230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M01_L35
M01_L49:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,24B3480EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,24B3480EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L37
M01_L50:
       call      CORINFO_HELP_OVERFLOW
M01_L51:
       call      qword ptr [7FF95D014C60]
       mov       ecx,77D
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L52:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L53:
       mov       r11,7FF95C950EA0
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L54:
       mov       rcx,rax
       mov       r11,7FF95C950E80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L55:
       mov       r11,7FF95C950E98
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L56:
       mov       rax,24B34801E10
       mov       r15,[rax]
       jmp       near ptr M01_L07
M01_L57:
       call      qword ptr [7FF95D014C60]
       mov       ecx,0F
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L59:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC85848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,28BC657D5E8
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L27
M01_L62:
       xor       ecx,ecx
       jmp       near ptr M01_L29
M01_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L30
M01_L64:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L65:
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jmp       near ptr M01_L35
M01_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L36
M01_L69:
       call      qword ptr [7FF95D014C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FF95CD24F30]
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FF95C950E98
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
; Total bytes of code 3792
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
       mov       rdx,26150C40008
       xor       r8d,r8d
       call      qword ptr [7FF95CF757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF95CA9EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D545C38]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CA9EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CA9EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D546178]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D545FF8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,26150C40008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,220BEC01DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE20C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CA943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L52
       call      qword ptr [7FF95CC35EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,26150C553E8
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D5460B8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,220BEC0EC28
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,220BEC0EC20
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rcx
       mov       rcx,220BEC0EC28
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       rcx,220BEC0EC30
       mov       r9,[rcx]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D72C810]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L17:
       test      eax,eax
       jne       near ptr M01_L12
       jmp       near ptr M01_L22
M01_L18:
       call      CORINFO_HELP_OVERFLOW
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,220BEC0EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,220BEC0EC30
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r15
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FF95C950E90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FF95C950E88
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,26150C4D5E8
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
       call      qword ptr [7FF95CD76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L43
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE1E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD57910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r10,220BEC00438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,220BEC00418
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
       mov       rdx,26150C55410
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,220BEC0EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L36:
       mov       rcx,220BEC0EC40
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
       call      qword ptr [7FF95D72C810]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,220BEC0EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,220BEC0EC40
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
       call      qword ptr [7FF95CD751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD75230]; System.MdUtf8String.ToString()
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
       mov       rcx,220BEC0EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,220BEC0EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FF95D014C60]
       mov       ecx,77D
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L52:
       mov       r11,7FF95C950EA0
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L53:
       mov       rcx,rax
       mov       r11,7FF95C950E80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L54:
       mov       r11,7FF95C950E98
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L55:
       mov       rcx,220BEC01E10
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0F
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L59:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC85848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,26150C4D5E8
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
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FF95CD24F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FF95CD24F30]
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FF95C950E98
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
; Total bytes of code 3805
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
       mov       rcx,1EC20F48D90
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
       call      qword ptr [7FF95CA06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,1EC20F4C8C8
       xor       edx,edx
       call      qword ptr [7FF95CA06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF95CAB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,1EC20F45F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,1EC20F40008
       call      qword ptr [7FF95D5659F8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CAB62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,1EC20F44388
       call      qword ptr [7FF95CF555A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,edi
       mov       rdx,1EC20F44368
       call      qword ptr [7FF95CF555A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FF95D7CDE00]
       int       3
M00_L03:
       mov       rsi,1EC20F40008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FF95D034C60]
       mov       ecx,7B3
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       call      qword ptr [7FF95CA06658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF95CD6CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF95CD1ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF95D355300]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF95C9F5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AB930003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CF268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF95CB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF95CAB5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF95D0859C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF95CABF750]
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
       call      qword ptr [7FF95CABEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D565A88]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CABEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CABEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D565FC8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D565E48]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95CA066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD95908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,1EC20F40008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1AB93001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE40C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CAB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FF95CC55EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD6E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1EC20F55448
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D565F08]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1AB9300EC28
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1AB9300EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,1AB9300EC30
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D757A20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD6E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1AB9300EC20
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
       mov       r11,7FF95C970EA8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FF95C970EA0
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,1EC20F4D5E8
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
       call      qword ptr [7FF95CD96208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD96280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L41
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE3E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD77910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L30
       test      rax,rax
       je        near ptr M03_L37
M03_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       mov       r9,1AB93000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,1AB93000418
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
       mov       rdx,1EC20F55470
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,1AB9300EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,1AB9300EC40
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
       call      qword ptr [7FF95D757A20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,1AB9300EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1AB9300EC40
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1AB9300EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1AB9300EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FF95D034C60]
       mov       ecx,77D
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD46670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD46670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       r11,7FF95C970EB8
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L50:
       mov       rcx,rax
       mov       r11,7FF95C970E98
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L51:
       mov       r11,7FF95C970EB0
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L52:
       mov       rcx,1AB93001E10
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,0F
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD46670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FF95CD1E9D0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CCA5848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,1EC20F4D5E8
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
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CD951B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD95230]
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D06D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CABF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D06CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CABF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF95CD44F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF95CD44F30]
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
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF95C970EB0
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
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1EC20F6DF48
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,1AB93000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1AB93000418
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
       mov       rdx,1EC20F6DF48
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FF95C970EF8
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
       mov       rcx,1AB93000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1AB93000418
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
       mov       rdx,1EC20F6DF48
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FF95CD1EFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FF95D76DE80
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
       mov       r11,7FF95C970EF8
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
       mov       rdx,7FF95D76DE80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       rdx,7FF95D76DDA8
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
       call      qword ptr [7FF95CD44F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FF95CD44F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FF95C970F00
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
       mov       r11,7FF95C970F00
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
       lea       rcx,[7FF95D840E80]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF26A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF95C9F539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1AB930003D8
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
       call      qword ptr [7FF95CF26A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF95CB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF95CF0E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF95CF0E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD466E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF95CD1ECB8]
       int       3
M06_L10:
       mov       rcx,7FF95C9F5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF95CD1ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D0859C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CABF750]
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
       call      qword ptr [7FF95D4271E0]
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
       jmp       qword ptr [7FF95CB65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1EF40]
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
       mov       rax,1EC20F40008
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
       mov       rcx,23D7FD48D90
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
       call      qword ptr [7FF95CA16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,23D7FD4C8C8
       xor       edx,edx
       call      qword ptr [7FF95CA16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF95CAC61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,23D7FD45F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF95CFA57E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,23D7FD40008
       call      qword ptr [7FF95D57C8D0]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CAC62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,23D7FD44388
       call      qword ptr [7FF95CF655A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,edi
       mov       rdx,23D7FD44368
       call      qword ptr [7FF95CF655A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF95C974000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FF95D8AED48]
       int       3
M00_L03:
       mov       rsi,23D7FD40008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF95D044C60]
       mov       ecx,76B
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FF95D044C60]
       mov       ecx,7B3
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 816
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
       call      qword ptr [7FF95CA16658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF95CD7CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF95CD2ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF95D365B10]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF368F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF95CA05120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FCF20003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CF368F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF95CB75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF95CAC5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF95D0959C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF95C974000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF95CACF750]
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
       call      qword ptr [7FF95CACEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D57C960]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CACEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CACEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D57CEA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCB5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D57CD20]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95CA166D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CDA5908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,23D7FD40008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1FCF2001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE50C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CAC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FF95CC65EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD7E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,23D7FD55448
       call      qword ptr [7FF95CAC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CFA57E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D57CDE0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1FCEE00CC30
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1FCEE00CC28
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,1FCEE00CC38
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D76E610]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD7E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1FCEE00CC28
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
       mov       r11,7FF95C980EA8
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FF95C980EA0
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CAC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,23D7FD4D5E8
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
       call      qword ptr [7FF95CDA6208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CDA6280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L41
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE4E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD87910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r9,1FCF2000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,1FCF2000418
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
       mov       rdx,23D7FD55470
       call      qword ptr [7FF95CAC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CFA57E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CAC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,1FCEE00CC40
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,1FCEE00CC48
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
       call      qword ptr [7FF95D76E610]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,1FCEE00CC28
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1FCEE00CC48
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1FCEE00CC28
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1FCEE00CC40
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FF95D044C60]
       mov       ecx,77D
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD56670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FF95D044C60]
       mov       ecx,76B
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD56670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       r11,7FF95C980EB8
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L50:
       mov       rcx,rax
       mov       r11,7FF95C980E98
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L51:
       mov       r11,7FF95C980EB0
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L52:
       mov       rcx,1FCF2001E10
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
       call      qword ptr [7FF95D044C60]
       mov       ecx,0F
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD56670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FF95CD2E9D0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CCB5848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,23D7FD4D5E8
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
       call      qword ptr [7FF95CCD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CDA51B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CDA5230]
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
       call      qword ptr [7FF95D044C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE55108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF9AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAC6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D044A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD56670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D07D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C974000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CACF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D07CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CACF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF95CD54F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF95CD54F30]
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
       call      qword ptr [7FF95CAC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF95C980EB0
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
       call      qword ptr [7FF95CCD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,23D7FD6DF48
       call      qword ptr [7FF95CAC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,1FCF2000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1FCF2000418
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
       mov       rdx,23D7FD6DF48
       call      qword ptr [7FF95CAC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FF95C980F18
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
       mov       rcx,1FCF2000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1FCF2000418
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
       mov       rdx,23D7FD6DF48
       call      qword ptr [7FF95CAC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF95CCD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FF95CD2EFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FF95D7CC298
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
       mov       r11,7FF95C980F18
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
       mov       rdx,7FF95D7CC298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FF95CCD4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       rdx,7FF95D7CC1C0
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
       call      qword ptr [7FF95CD54F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FF95CD54F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FF95C980F20
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
       mov       r11,7FF95C980F20
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
       lea       rcx,[7FF95D831070]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCD4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF36A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF95CA0539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1FCF20003D8
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
       call      qword ptr [7FF95CF36A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF95CB75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF95CF1E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF95CF1E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF95C974000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD566E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF95CD2ECB8]
       int       3
M06_L10:
       mov       rcx,7FF95CA05120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF95CD2ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D0959C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF95C974000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CACF750]
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
       call      qword ptr [7FF95D4371E0]
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
       jmp       qword ptr [7FF95CB75B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD2EF40]
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
       mov       rax,23D7FD40008
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
       mov       rcx,2718BCF8D90
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
       call      qword ptr [7FF95CA06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2718BCFC8C8
       xor       edx,edx
       call      qword ptr [7FF95CA06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF95CAB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2718BCF5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,2718BCF0008
       call      qword ptr [7FF95D56D9F8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CAB62F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,2718BCF4388
       call      qword ptr [7FF95CF555A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,edi
       mov       rdx,2718BCF4368
       call      qword ptr [7FF95CF555A8]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FF95D7DF3C0]
       int       3
M00_L03:
       mov       rsi,2718BCF0008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FF95D034C60]
       mov       ecx,7B3
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       call      qword ptr [7FF95CA06658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF95CD6CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF95CD1ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF95D355D10]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF95C9F5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,230FA0003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CF268F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF95CB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF95CAB5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF95D0859C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF95CABF750]
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
       call      qword ptr [7FF95CABEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D56DA88]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CABEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CABEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D56DFC8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CCA5740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D56DE48]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95CA066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD95908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2718BCF0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,230FA001DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE40C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CAB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L52
       call      qword ptr [7FF95CC55EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD6E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2718BD05490
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D56DF08]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,230FA00EC28
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,230FA00EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,230FA00EC30
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D75FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD6E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,230FA00EC20
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
       mov       r11,7FF95C970EE0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L21:
       mov       r11,7FF95C970ED8
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,2718BCFD5E8
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
       call      qword ptr [7FF95CD96208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD96280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE3E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD77910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r10,230FA000438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L32
       mov       r10,230FA000418
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
       mov       rdx,2718BD054B8
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF957E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CAB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,230FA00EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L36:
       mov       rcx,230FA00EC40
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
       call      qword ptr [7FF95D75FA20]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,230FA00EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,230FA00EC40
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
       call      qword ptr [7FF95CD951B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD95230]; System.MdUtf8String.ToString()
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
       mov       rcx,230FA00EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,230FA00EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L49:
       call      CORINFO_HELP_OVERFLOW
M03_L50:
       call      qword ptr [7FF95D034C60]
       mov       ecx,77D
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD46670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L51:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD46670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L52:
       mov       r11,7FF95C970EF0
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L53:
       mov       rcx,rax
       mov       r11,7FF95C970ED0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L54:
       mov       r11,7FF95C970EE8
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L55:
       mov       rcx,230FA001E10
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,0F
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD46670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L59:
       call      qword ptr [7FF95CD1E9D0]
       int       3
M03_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CCA5848]
       jmp       near ptr M03_L03
M03_L61:
       mov       rcx,rax
       mov       rdx,2718BCFD5E8
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
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF95D034C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D06D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CABF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D06CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CABF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FF95CD44F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FF95CD44F30]
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
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FF95C970EE8
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
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2718BD1E148
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,230FA000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,230FA000418
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
       mov       rdx,2718BD1E148
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FF95C970F50
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
       mov       rcx,230FA000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,230FA000418
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
       mov       rdx,2718BD1E148
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FF95CD1EFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FF95D7BD770
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
       mov       r11,7FF95C970F50
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
       mov       rdx,7FF95D7BD770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FF95CCC4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       rdx,7FF95D7BD698
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
       call      qword ptr [7FF95CD44F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FF95CD44F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FF95C970F58
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
       mov       r11,7FF95C970F58
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
       lea       rcx,[7FF95D828440]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF26A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF95C9F539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,230FA0003D8
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
       call      qword ptr [7FF95CF26A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF95CB65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF95CF0E328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF95CF0E2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD466E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF95CD1ECB8]
       int       3
M06_L10:
       mov       rcx,7FF95C9F5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF95CD1ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D0859C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CABF750]
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
       call      qword ptr [7FF95D42C8A0]
       int       3
; Total bytes of code 20
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M08_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M08_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M08_L02
       test      r8b,18
       jne       short M08_L01
       test      r8b,4
       je        short M08_L05
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
       cmp       r8,40
       ja        short M08_L06
M08_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M08_L10
M08_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M08_L00
M08_L05:
       test      r8,r8
       je        short M08_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M08_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M08_L00
M08_L06:
       cmp       r8,800
       ja        short M08_L09
       mov       r9,r8
       shr       r9,6
M08_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M08_L07
       and       r8,3F
       cmp       r8,10
       ja        short M08_L03
       jmp       short M08_L04
M08_L08:
       cmp       rcx,rdx
       je        near ptr M08_L00
M08_L09:
       jmp       qword ptr [7FF95CB65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M08_L10:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M08_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M08_L04
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
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1EF40]
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
       mov       rax,2718BCF0008
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
       mov       rcx,19F7E378D90
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
       call      qword ptr [7FF95C9F6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,19F7E37C8C8
       xor       edx,edx
       call      qword ptr [7FF95C9F6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF95CAA61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,19F7E375F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FF95CF857E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,19F7E370008
       call      qword ptr [7FF95D56FE40]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CAA62F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FF95D8AF6C0]
       int       3
M00_L03:
       mov       rsi,19F7E370008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FF95D024C60]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FF95D024C60]
       mov       ecx,7B3
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
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
       call      qword ptr [7FF95C9F6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF95CD5CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF95CD0ECB8]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FF95D3314A0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF168F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FF95C9E5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15EEC4003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CF168F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF95CB55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF95CAA5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF95D0759C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF95CAAF750]
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
       call      qword ptr [7FF95CAAEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D594060]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CAAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CAAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D5945A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D594420]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9F66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD85908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,19F7E370008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,15EEC401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE30C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CAA43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L52
       call      qword ptr [7FF95CC45EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD5E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L21
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,19F7E385470
       call      qword ptr [7FF95CAA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF857E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D5944E0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,15EEC40EC28
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,15EEC40EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,15EEC40EC30
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L18
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D795BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD5E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L22
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,15EEC40EC20
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
       mov       r11,7FF95C961320
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L20:
       mov       r11,7FF95C961318
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CAA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,19F7E37D5E8
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
       call      qword ptr [7FF95CD86208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD86280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE2E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD67910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r10,15EEC400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L32
       mov       r10,15EEC400418
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
       mov       rdx,19F7E385498
       call      qword ptr [7FF95CAA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF857E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,15EEC40EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L48
M03_L36:
       mov       rcx,15EEC40EC40
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
       call      qword ptr [7FF95D795BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,15EEC40EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,15EEC40EC40
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
       call      qword ptr [7FF95CD851B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD85230]; System.MdUtf8String.ToString()
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
       mov       rcx,15EEC40EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,15EEC40EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L49:
       call      CORINFO_HELP_OVERFLOW
M03_L50:
       call      qword ptr [7FF95D024C60]
       mov       ecx,77D
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD36670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L51:
       call      qword ptr [7FF95D024C60]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L52:
       mov       r11,7FF95C961330
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L53:
       mov       rcx,rax
       mov       r11,7FF95C961310
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L54:
       mov       r11,7FF95C961328
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L55:
       mov       rcx,15EEC401E10
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
       call      qword ptr [7FF95D024C60]
       mov       ecx,0F
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD36670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L59:
       call      qword ptr [7FF95CD0E9D0]
       int       3
M03_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC95848]
       jmp       near ptr M03_L03
M03_L61:
       mov       rcx,rax
       mov       rdx,19F7E37D5E8
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
       call      qword ptr [7FF95CCB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF95D024C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D05D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CAAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D05CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FF95CD34F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FF95CD34F30]
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
       call      qword ptr [7FF95CAA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FF95C961328
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
; Total bytes of code 3792
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
       call      qword ptr [7FF95CCB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,19F7E39E128
       call      qword ptr [7FF95CAA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,15EEC400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,15EEC400418
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
       mov       rdx,19F7E39E128
       call      qword ptr [7FF95CAA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FF95C961390
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
       mov       rcx,15EEC400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,15EEC400418
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
       mov       rdx,19F7E39E128
       call      qword ptr [7FF95CAA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       call      qword ptr [7FF95CCB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FF95CD0EFE8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FF95D7BDEC0
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
       mov       r11,7FF95C961390
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
       mov       rdx,7FF95D7BDEC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FF95CCB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       rdx,7FF95D7BDDE8
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
       call      qword ptr [7FF95CD34F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FF95CD34F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FF95C961398
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
       mov       r11,7FF95C961398
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
       lea       rcx,[7FF95D817370]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF16A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF95C9E539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,15EEC4003D8
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
       call      qword ptr [7FF95CF16A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF95CB55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF95CEFE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF95CEFE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD366E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF95CD0ECB8]
       int       3
M06_L10:
       mov       rcx,7FF95C9E5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF95CD0ED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D0759C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF95C954000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CAAF750]
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
       ja        short M07_L03
       test      r8b,18
       jne       short M07_L01
       test      r8b,4
       je        short M07_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M07_L00:
       ret
M07_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M07_L00
M07_L02:
       test      r8,r8
       je        short M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M07_L06
       jmp       short M07_L00
M07_L03:
       cmp       r8,40
       ja        short M07_L07
M07_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L11
M07_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L00
M07_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M07_L00
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
       ja        short M07_L04
       jmp       short M07_L05
M07_L09:
       cmp       rcx,rdx
       je        near ptr M07_L00
M07_L10:
       jmp       qword ptr [7FF95CB55B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L05
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD0EF40]
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
       mov       rax,19F7E370008
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
       mov       rcx,1CAAE218D90
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
       call      qword ptr [7FF95C9E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,1CAAE21C8C8
       xor       edx,edx
       call      qword ptr [7FF95C9E6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FF95CA961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,1CAAE215F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       mov       r8,1CAAE210008
       call      qword ptr [7FF95D584090]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF95CA962F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx*2+0C]
       mov       rcx,r14
       movsxd    r8,ebp
       call      qword ptr [7FF95D407228]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       mov       rdi,r15
M00_L01:
       mov       rcx,1CAAE210008
       test      rdi,rdi
       cmove     rdi,rcx
       mov       [rsp+20],rdi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF95D7C4D08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,7B3
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
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
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FF95D89EDA8]
       int       3
M00_L07:
       mov       rdi,1CAAE210008
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
       call      qword ptr [7FF95C9E6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF95CD4CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF068F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L06
       mov       rcx,7FF95C9D5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18A204003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF95CF068F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M02_L06
M02_L04:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF95CB45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FF95CA95F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L05:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF95D0659C8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF95CA9F750]
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
       call      qword ptr [7FF95CCFECB8]
       int       3
M02_L09:
       cmp       edi,5
       ja        short M02_L05
       mov       eax,edi
       lea       rcx,[7FF95D321288]
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
       call      qword ptr [7FF95CA9EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       call      qword ptr [7FF95D584120]; DotNetTips.Spargine.Core.TypeHelper.BuiltInTypeNames()
       cmp       [rax],al
       mov       rcx,rax
       mov       rdx,r15
       call      qword ptr [7FF95CA9EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FF95CA9EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF95D584660]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FF95D5844E0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF95C9E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF95CD75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,1CAAE210008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,18A20401DE8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF95CE20C90]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF95CA943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FF95CC35EA8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF95CD4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L21
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1CAAE225448
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF95D5845A0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,18A2040EC28
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,18A2040EC20
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,18A2040EC30
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L18
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF95D785BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF95CD4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L22
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,18A2040EC20
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
       mov       r11,7FF95C951220
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L20:
       mov       r11,7FF95C951218
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,1CAAE21D5E8
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
       call      qword ptr [7FF95CD76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF95CD76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L41
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF95CE1E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FF95CD57910]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r9,18A20400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L32
       mov       r9,18A20400418
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
       mov       rdx,1CAAE225470
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF95CF757E8]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,18A2040EC38
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L45
M03_L35:
       mov       rcx,18A2040EC40
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
       call      qword ptr [7FF95D785BD8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,18A2040EC20
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,18A2040EC40
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L36
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,18A2040EC20
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__12_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,18A2040EC38
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L35
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FF95D014C60]
       mov       ecx,77D
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF95CD26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       r11,7FF95C951230
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L50:
       mov       rcx,rax
       mov       r11,7FF95C951210
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L51:
       mov       r11,7FF95C951228
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L52:
       mov       rcx,18A20401E10
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0F
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF95CD26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF95CC85848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,1CAAE21D5E8
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
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF95CD751B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF95CD75230]
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
       call      qword ptr [7FF95D014C60]
       mov       ecx,0ABE
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04D560]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D04CF48]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FF95CD24F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FF95CD24F30]
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
       call      qword ptr [7FF95CA94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FF95C951228
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
; Total bytes of code 3772
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
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1CAAE23DF48
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       jne       near ptr M05_L17
       jmp       near ptr M05_L05
M05_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L07
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
       jl        near ptr M05_L25
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M05_L25
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,18A20400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,18A20400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L24
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
       mov       rdx,1CAAE23DF48
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       jne       near ptr M05_L23
M05_L06:
       mov       r8d,[rdi+0C]
       mov       rcx,[rdi]
       mov       r15d,[rcx+38]
       cmp       r8d,r15d
       jb        short M05_L09
       mov       rax,[rbp-78]
       inc       r15d
       mov       [rdi+0C],r15d
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L07:
       mov       rcx,rbx
       mov       rdx,7FF95D7ADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L08:
       mov       rcx,rax
       mov       r11,7FF95C951290
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M05_L01
       jmp       near ptr M05_L28
M05_L09:
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M05_L10
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        near ptr M05_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L01
M05_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M05_L11:
       mov       rcx,rax
       mov       r11,7FF95C951290
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M05_L28
M05_L12:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M05_L19
M05_L13:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass13_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L22
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
M05_L14:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L15
       mov       rcx,18A20400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L15
       mov       rcx,18A20400418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M05_L21
M05_L15:
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
       mov       rdx,1CAAE23DF48
       call      qword ptr [7FF95CA96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M05_L16:
       mov       rax,[rbp-78]
M05_L17:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M05_L11
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M05_L23
M05_L18:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       mov       r15d,[rdx+38]
       cmp       ecx,r15d
       jb        short M05_L20
       mov       rax,[rbp-78]
       inc       r15d
       mov       [rdi+0C],r15d
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M05_L28
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FF95D7ADBC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L13
M05_L20:
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M05_L10
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M05_L18
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M05_L12
M05_L21:
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L15
M05_L22:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M05_L16
M05_L23:
       call      qword ptr [7FF95CCFEFE8]
       int       3
M05_L24:
       call      qword ptr [7FF95CCA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L25:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L26:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L14
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FF95D7ADAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L00
M05_L28:
       mov       rax,[rbp-78]
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
       call      qword ptr [7FF95CD24F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FF95CD24F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FF95C951298
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
       mov       r11,7FF95C951298
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
; Total bytes of code 1495
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
       lea       rcx,[7FF95D7F5610]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FF95CCA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF95CF06A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FF95C9D539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,18A204003D8
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
       call      qword ptr [7FF95CF06A00]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FF95CB45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FF95CEEE328]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FF95CEEE2F8]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector128(Char ByRef, Char ByRef, Int32)
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
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD266E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FF95CCFECB8]
       int       3
M06_L10:
       mov       rcx,7FF95C9D5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FF95CCFED00]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D0659C8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FF95C944000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF95CA9F750]
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
       ja        short M07_L03
       test      r8b,18
       jne       short M07_L01
       test      r8b,4
       je        short M07_L02
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
M07_L00:
       ret
M07_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M07_L00
M07_L02:
       test      r8,r8
       je        short M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       jne       short M07_L06
       jmp       short M07_L00
M07_L03:
       cmp       r8,40
       ja        short M07_L07
M07_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L11
M07_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M07_L00
M07_L06:
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M07_L00
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
       ja        short M07_L04
       jmp       short M07_L05
M07_L09:
       cmp       rcx,rdx
       je        near ptr M07_L00
M07_L10:
       jmp       qword ptr [7FF95CB45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L11:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L05
; Total bytes of code 254
```
```assembly
; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       sub       rsp,28
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,1CAAE210008
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
       call      qword ptr [7FF95CFD6100]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       [rsp+30],rax
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FF95CF95848]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
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
       mov       rax,1F70E00F620
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1F70E00F620
       xor       edx,edx
       jmp       qword ptr [7FF95CFD67D8]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
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
       je        near ptr M02_L09
       mov       [rbp-28],rcx
       mov       rbx,[rdx]
       test      rbx,rbx
       je        near ptr M02_L07
M02_L00:
       cmp       byte ptr [rbx+9E],0
       je        near ptr M02_L06
M02_L01:
       mov       rdx,[rbx+18]
       test      rdx,rdx
       je        near ptr M02_L05
M02_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M02_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M02_L04
M02_L03:
       lea       rdx,[rbp-28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2CE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,1F70E001FB0
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF95D566CB8]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       lea       rcx,[rsi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],rsi
       jmp       short M02_L08
M02_L04:
       call      qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L05:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,237A0052D10
       mov       r8d,1
       call      qword ptr [7FF95CFD5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L06:
       mov       rcx,rbx
       call      qword ptr [7FF95CFD6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L01
M02_L07:
       call      qword ptr [7FF95CFD6100]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rbx,rax
       jmp       near ptr M02_L00
M02_L08:
       mov       rax,[rbp-38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       call      qword ptr [7FF95D034C60]
       mov       ecx,76B
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE45108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF8AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D034A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD46670]
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
       call      qword ptr [7FF95D565E60]
       mov       [rbp-38],rax
       lea       rax,[M02_L08]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 632
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
       mov       rcx,2126200EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF95CFC6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF95CFC6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2BE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF95CAA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF95D024C60]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE35108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
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
       call      qword ptr [7FF95CFC7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF95D02D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF95CAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFC6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF95D02D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF95D02D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF95D02D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF95D02D920]
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
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CFC6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D02D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF95CAA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFCC978]
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
       mov       rdx,252F3DF2D10
       mov       r8d,1
       call      qword ptr [7FF95CFC5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF95CFC67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rcx,21262001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF95D27D750]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,252F3DF1C08
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
       call      qword ptr [7FF95D02CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF95CD0E9D0]
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
       call      qword ptr [7FF95D02E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF95D3759E0]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF95CFF3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2126200F660
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF95D2BED60]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF95D3754E8]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF95D2BEEE0]
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
       mov       rcx,[rcx+38]
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
       call      qword ptr [7FF95CD0E9D0]
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
       call      qword ptr [7FF95CB55BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,21262001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF95D27D758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FF95CAA43A8]
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD0EF40]
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
       mov       rax,252F3DF0008
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
       mov       rcx,14F6440EB70
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6730]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FF95CFB6040]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF95D2AE160]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FF95CA943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FF95D014C60]
       mov       ecx,76B
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE25108
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF6AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CA96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D014A50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD26670]
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
       call      qword ptr [7FF95CFB7468]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FF95D01D698]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFB6E68]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       xor       r8d,r8d
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,offset MD_<PrivateImplementationDetails>.InlineArrayElementRef[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r8d,1
       call      qword ptr [7FF95D01D8A8]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,offset MD_<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[<>y__InlineArray2`1[[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]], System.Text.Json],[System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver, System.Text.Json]](<>y__InlineArray2`1<System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver> ByRef, Int32)
       mov       r9d,2
       call      qword ptr [7FF95D01D8D8]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FF95D01D920]
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
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D740]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF95CFB6730]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D01D7B8]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FF95CA94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF95CFBC978]
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
       mov       rdx,18FF62F2D10
       mov       r8d,1
       call      qword ptr [7FF95CFB5FE0]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FF95CFB67A8]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
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
       mov       rcx,14F64401F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FF95D26D750]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,18FF62F1C08
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
       call      qword ptr [7FF95D01CE40]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95D01E370]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       call      qword ptr [7FF95D3659E0]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FF95CFE3420
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,14F6440F660
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FF95D2AED60]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF95D3654E8]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FF95D2AEEE0]
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
       call      qword ptr [7FF95CCFE9D0]
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
       call      qword ptr [7FF95CB45BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,14F64401F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF95D26D758]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FF95CA943A8]
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
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CCFEF40]
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
       mov       rax,18FF62F0008
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
       call      qword ptr [7FF95D5D4150]; System.Data.DataTable..ctor()
       mov       rcx,18A0DA653B8
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF95CF95890]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,18A0DA50008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,18A0DA65458
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,18A0DA65530
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,1497FC01FC8
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1497FC01FD0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1497FC01FD8
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
       mov       rcx,7FF95C9F5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF95D58D200
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF95CD6C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1497BC103F8
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
       mov       rdx,18A0DA653D8
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF95CB676D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5DC8B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D5D6A00]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1497FC01E58
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
       call      qword ptr [7FF95D5D7780]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,1497FC01FF0
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
       call      qword ptr [7FF95CAB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF95D58EF00]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L04
M02_L00:
       call      qword ptr [7FF95D5F4450]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L01
       call      qword ptr [7FF95D034BB8]
       mov       rbx,rax
M02_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95CD46718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       r11,7FF95C971118
       call      qword ptr [r11]
       jmp       short M02_L04
M02_L03:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FF95C971120
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FF95D5DFB40]
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
       call      qword ptr [7FF95CF859C8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FF95D024438]
       mov       ecx,76B
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE350F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D024228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF95CD36670]
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
       mov       rcx,1ADC4C0B1D0
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
       call      qword ptr [7FF95CDAC1F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r14
       mov       edx,ebx
       call      qword ptr [7FF95CDAC150]; System.Text.StringBuilder.set_Capacity(Int32)
       mov       [rbp-50],r14
       jmp       short M01_L06
M01_L04:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       lea       rdx,[rbp-48]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF95D28D998]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FF95CFC54A0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M01_L13
       mov       edx,eax
       mov       ecx,[r14+18]
       mov       eax,ecx
       mov       r8,[r14+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M01_L12
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
       call      qword ptr [7FF95CDB7A60]; System.Text.StringBuilder.ToString()
       mov       r15,rax
       mov       esi,[r15+8]
       test      esi,esi
       je        short M01_L18
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jae       short M01_L15
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L14
       jmp       short M01_L16
M01_L11:
       mov       edx,eax
       jmp       short M01_L08
M01_L12:
       mov       rcx,r14
       call      qword ptr [7FF95CDAC3F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L09
M01_L13:
       call      CORINFO_HELP_OVERFLOW
M01_L14:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF95CAA73F0]
       jmp       short M01_L19
M01_L15:
       call      qword ptr [7FF95D456400]
       test      eax,eax
       jne       short M01_L14
M01_L16:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L17
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L14
       jmp       short M01_L18
M01_L17:
       call      qword ptr [7FF95D456400]
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
       call      qword ptr [7FF95CB547B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L21:
       call      qword ptr [7FF95D024420]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L22
       call      qword ptr [7FF95D024240]
       mov       rsi,rax
M01_L22:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1EE56BC86E0
       mov       r8,rsi
       call      qword ptr [7FF95CB5D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L23:
       call      qword ptr [7FF95D024438]
       mov       ecx,946
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1464
       mov       rdx,7FF95CE350F0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FF95CF7AF90
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CAA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D024228]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF95CD36670]
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
       call      qword ptr [7FF95D28D4B8]
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
       mov       rcx,1ADC4C0B1D0
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
       call      qword ptr [7FF95CDAC1F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FF95D28D9C8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L32
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FF95D28D488]
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
; Total bytes of code 1050
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
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF95CB55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD0EF40]
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
       mov       rax,1EE56BC0008
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
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FF95D55FE40]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FF95D014D08]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FF95D014A50]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,29A352853E0
       mov       r8,rbx
       call      qword ptr [7FF95CD26670]
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
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF95D446400]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF9BB7A2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF95D446400]
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
       call      qword ptr [7FF95CA973F0]
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
       call      qword ptr [7FF95CA97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
M02_L02:
       mov       r8,259A340DA78
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FF95D55FEA0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M02_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FF95D575100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L02
M02_L04:
       lea       rcx,[rsp+28]
       mov       rdx,29A35285580
       call      qword ptr [7FF95CC858F0]
M02_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FF95CEE4B88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M02_L07
M02_L06:
       call      qword ptr [7FF95CCFE9D0]
       int       3
M02_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M02_L08
       mov       rdx,29A35270C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsp+28]
       mov       rdx,29A35270C48
       call      qword ptr [7FF95CC858F0]
M02_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FF95CC85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CD26718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L10:
       call      qword ptr [7FF95D014D08]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L11
       call      qword ptr [7FF95D014A50]
       mov       rsi,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,29A352853E0
       mov       r8,rsi
       call      qword ptr [7FF95CD26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FF95CC856B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,29A3528558C
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
       call      qword ptr [7FF95D4D5AE8]; System.Data.DataSet..ctor()
       mov       rcx,1A08C4103F8
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
       mov       r8,1E11E2E53B8
       mov       [rbp-38],r8
       lea       r8,[rbp-40]
       mov       [rbp-70],r8
       mov       dword ptr [rbp-68],2
       lea       r8,[rbp-70]
       xor       ecx,ecx
       mov       rdx,1E11E2E5550
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FF95CB676D8]
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
       mov       rdx,1E11E2E53B8
       call      qword ptr [7FF95D4D7360]; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
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
       mov       rcx,1E11E2E5520
       mov       [rax+8],rcx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L31
M00_L04:
       mov       rcx,1E11E2E53B8
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
       call      qword ptr [7FF95CA06658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M00_L06
M00_L09:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF95CD94E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       call      qword ptr [7FF95CD94BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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
       call      qword ptr [7FF95CDE6530]; System.Reflection.RtFieldInfo.GetValue(System.Object)
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
       call      qword ptr [7FF95CD95938]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
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
       call      qword ptr [7FF95CD1ED48]
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
       mov       rcx,1A090401EE0
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
       call      qword ptr [7FF95CD46028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FF95CDB44B0]
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
       call      qword ptr [7FF95D4DDD10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L26
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF95D5104F8]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L26:
       call      qword ptr [7FF95CD6C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FF95D4CC640
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D5CDEC0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L28:
       mov       ecx,8F
       mov       rdx,7FF95CE43398
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D5CDF80]
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
       call      qword ptr [7FF95CAB43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L30:
       cmp       byte ptr [r15+1C4],0
       jne       near ptr M00_L03
       mov       ecx,8F
       mov       rdx,7FF95CE43398
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95D5CEE08]
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
       call      qword ptr [7FF95D5104F8]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L32:
       call      qword ptr [7FF95CD6C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rcx,1E11E2E53D8
       mov       [rbx+38],rcx
       lea       rcx,[rbx+40]
       mov       rsi,1E11E2D0008
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
       mov       rcx,7FF95D4CE764
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,rbx
       call      qword ptr [7FF95CD6C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1A08C4103F8
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
       mov       rdx,1E11E2E5408
       call      qword ptr [7FF95CAB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF95CB676D8]
M01_L00:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D4D7000]; System.Data.DataTableCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF95D4D6F10]; System.Data.DataRelationCollection+DataSetRelationCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF95CCC4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rax,[7FF9BC1F3CD8]
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
       call      qword ptr [7FF9BC20AC68]
       lea       rcx,[rbp+8]
       call      qword ptr [7FF9BC20AC80]; Precode of System.Text.ValueStringBuilder.ToString()
       lea       rcx,[7FF9BC1F3CD8]
       mov       rcx,[rcx]
       cmp       [rbp],rcx
       je        short M02_L01
       call      qword ptr [7FF9BC1F3D28]; CORINFO_HELP_FAIL_FAST
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
       call      qword ptr [7FF9BC20ACC8]
       jmp       short M02_L00
M02_L03:
       mov       rcx,[7FF9BC220A08]
       mov       rcx,[rcx]
       call      qword ptr [7FF9BC203938]
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
       call      qword ptr [7FF95CAB43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       r9,[rsi+8]
       mov       r9,[r9+50]
       mov       rcx,[r13+70]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF95D4D6B50]
       mov       r12d,eax
       cmp       r12d,1
       jne       short M03_L03
       mov       rcx,r13
       call      qword ptr [7FF95D4DC708]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF95CAB61C0]; System.String.Equals(System.String, System.String)
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
       call      qword ptr [7FF95D4DC708]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF95CAB61C0]; System.String.Equals(System.String, System.String)
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
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-90],rcx
       mov       rcx,rbp
       mov       [rbp-80],rcx
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
       jne       near ptr M04_L08
M04_L01:
       test      rdi,rdi
       jne       near ptr M04_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-68],rdi
       xor       ecx,ecx
       mov       [rdi+90],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       r14,rax
       mov       [rbp-70],r14
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M04_L04
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-50]
       mov       rdx,[rbp-50]
       mov       rdx,[rdx+20]
       lea       rax,[rbp-48]
       mov       [rbp-60],rcx
       mov       [rbp-58],rdx
       lea       rcx,[rbp-60]
       mov       rdx,rax
       mov       rax,offset MD_System.ModuleHandle.GetModuleType(System.Runtime.CompilerServices.QCallModule, System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp-0A0],rax
       lea       rax,[M04_L02]
       mov       [rbp-88],rax
       lea       rax,[rbp-0B0]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FF9BC543A30
       call      rax
M04_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FF9BC9540DC],0
       je        short M04_L03
       call      qword ptr [7FF9BC9443A8]; CORINFO_HELP_STOP_FOR_GC
M04_L03:
       mov       rcx,[rbp-0A8]
       mov       [rsi+10],rcx
       mov       rsi,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-70]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M04_L04:
       mov       rbx,[rbp+10]
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-68]
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
       jne       short M04_L09
M04_L05:
       test      rax,rax
       cmovne    rdi,rax
M04_L06:
       mov       rax,rdi
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L07:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF95CAB5968]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M04_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF95CAB5998]
       jmp       near ptr M04_L00
M04_L08:
       call      qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M04_L09:
       call      qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 528
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
       mov       rax,86511813A3D3
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M05_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M05_L06
       cmp       r14d,1
       je        near ptr M05_L08
M05_L00:
       mov       r15d,[rbx+8]
       lea       rcx,[rbx+0C]
       mov       [rbp+18],rcx
       mov       r13,[rbp+18]
       mov       rcx,1A0904009F0
       mov       rcx,[rcx]
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FF95CD09E28]; Precode of System.Text.UTF8Encoding.GetByteCount(Char*, Int32)
       mov       r12d,eax
       cmp       r12d,400
       jg        near ptr M05_L07
       mov       ecx,r12d
       mov       r9,rcx
       test      r9,r9
       je        short M05_L02
       mov       rdx,r9
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,40
       neg       rdx
       add       rdx,rsp
       jb        short M05_L01
       xor       edx,edx
M05_L01:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M05_L01
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,40
       lea       r9,[rsp+40]
M05_L02:
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FF95CD94EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M05_L03:
       xor       edx,edx
       mov       [rbp+18],rdx
M05_L04:
       lea       rdx,[rbp+20]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF95CD94EB8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+20]
       mov       rcx,86511813A3D3
       cmp       [rbp+8],rcx
       je        short M05_L05
       call      CORINFO_HELP_FAIL_FAST
M05_L05:
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
M05_L06:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF95CD94EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
       jmp       short M05_L04
M05_L07:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       dword ptr [rax+8],0
       jbe       short M05_L09
       add       rax,10
       mov       [rbp+10],rax
       mov       rdx,r13
       mov       r8d,r15d
       mov       r9,[rbp+10]
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       call      qword ptr [7FF95CD94EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
       xor       eax,eax
       mov       [rbp+10],rax
       jmp       near ptr M05_L03
M05_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M05_L00
       cmp       word ptr [rbx+0C],2A
       je        near ptr M05_L00
       jmp       near ptr M05_L06
M05_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 466
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
       mov       rdx,7FF95D470408
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
       mov       rdx,7FF95D470360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M06_L09:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FF95CD95908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
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
       call      qword ptr [7FF95CDD71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M07_L00
M07_L09:
       mov       rcx,rbx
       call      qword ptr [7FF95CDD73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M07_L04
M07_L10:
       mov       rcx,rdi
       call      qword ptr [7FF95CA06658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L06
M07_L11:
       mov       rcx,rdi
       call      qword ptr [7FF95CA06658]; System.RuntimeType.InitializeCache()
       jmp       short M07_L07
M07_L12:
       test      rdi,rdi
       je        short M07_L14
       mov       rcx,rbx
       call      qword ptr [7FF95CDAF250]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M07_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF95D06DC08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF95CD46718]
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
       call      qword ptr [7FF95CF57EB8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L15:
       test      rsi,rsi
       jne       short M07_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF95D086028]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF95CD9DB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L16:
       call      qword ptr [7FF95D06CE70]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FF95CDE64E0]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FF95D06C780]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF95CABF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M07_L17:
       call      qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rcx,7FF95D45BB2C
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
       jmp       qword ptr [7FF95CB65BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r11,[7FF9BC21C048]
       cmp       r11,[rcx]
       jne       short M09_L00
       jmp       short M09_L01
M09_L00:
       lea       r11,[7FF9BC1F1140]
       call      qword ptr [r11]
       mov       rcx,rax
M09_L01:
       call      qword ptr [7FF9BC1FEF00]
       test      rax,rax
       je        short M09_L03
       xor       edx,edx
       test      bl,bl
       sete      dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[7FF9BC202FE0]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M09_L02:
       mov       rcx,[7FF9BC2209E8]
       mov       rcx,[rcx]
       call      qword ptr [7FF9BC203938]
       int       3
M09_L03:
       call      qword ptr [7FF9BC1FBF98]
       mov       rbx,rax
       call      qword ptr [7FF9BC2052B8]
       mov       rdx,rax
       mov       r8,[7FF9BC2209E8]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FF9BC2038E8]
       mov       rcx,rbx
       call      qword ptr [7FF9BC1F3D08]; CORINFO_HELP_THROW
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
       jmp       qword ptr [7FF95CD6C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FF95C964000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF95CD466E8]
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
       jmp       qword ptr [7FF95CAB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.Object.GetType()
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

