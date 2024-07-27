## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rdx,[rbx+120]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE8BC943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 227
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
       jmp       qword ptr [7FFE8BC943A8]
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEEEF10]
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
       mov       rax,26022590008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonArray()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFE8C6EDF68]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       [rsp+30],rax
       mov       rcx,2662FC0DDC0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FFE8C2768B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE8C2762F8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C44F018]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFE8BC87318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE8C6EF6A8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE8BF04F30]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFE8BB41138
       call      qword ptr [r11]
       test      rax,rax
       jne       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rdx,rax
       call      qword ptr [7FFE8BC843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       call      qword ptr [7FFE8C27EA60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFE8C27E7C0]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2A6C1AAC8E0
       mov       r8,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 558
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       r8,[rdx]
       movzx     r10d,word ptr [r8+0E]
       test      r10,r10
       je        short M01_L04
       mov       r9,[r8+38]
       cmp       r10,4
       jl        short M01_L03
M01_L00:
       cmp       [r9],rcx
       je        short M01_L01
       cmp       [r9+8],rcx
       je        short M01_L01
       cmp       [r9+10],rcx
       jne       short M01_L02
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r9+18],rcx
       je        short M01_L01
       add       r9,20
       add       r10,0FFFFFFFFFFFFFFFC
       cmp       r10,4
       jge       short M01_L00
       test      r10,r10
       je        short M01_L04
M01_L03:
       cmp       [r9],rcx
       je        short M01_L01
       add       r9,8
       dec       r10
       test      r10,r10
       jg        short M01_L03
M01_L04:
       test      dword ptr [r8],406C0000
       jne       short M01_L05
       xor       edx,edx
       jmp       short M01_L01
M01_L05:
       jmp       qword ptr [7FFE8BC84378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 110
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
       mov       rdx,7FFE8C7CA2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFE8C7CA4A8
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
       mov       rdx,7FFE8C7CA4C0
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
       mov       rdx,7FFE8C7CA5D0
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
       mov       rdx,7FFE8C7CA498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8C7AD890]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FFE8C7CA498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFE8C7AD908]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFE8C7CA498
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8C7AD998]
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
       mov       rdx,7FFE8C7CA600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FFE8C114750]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF3ECB5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M03_L03
       call      qword ptr [7FFF3ECB9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M03_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
M03_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       call      qword ptr [7FFF3ECB69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M03_L00
       call      qword ptr [7FFF3ECB5060]
       cmp       byte ptr [rax+18E],0
       je        short M03_L00
       mov       ecx,2
       call      qword ptr [7FFF3ECB6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF3ECB9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M03_L00
       cmp       [rsi+10],rbx
       je        short M03_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M03_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF3ECB9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M03_L00
M03_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF3ECB4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M03_L00
M03_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M03_L04
       call      qword ptr [7FFF3ECB6A08]
       test      rax,rax
       je        near ptr M03_L00
M03_L04:
       call      qword ptr [7FFF3ECB84A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,2A6C1A92D10
       mov       r8d,1
       call      qword ptr [7FFE8C276298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE8C44F048]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE8C315488]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M05_L04
       cmp       [rcx+8],ebx
       jb        short M05_L03
M05_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M05_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M05_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M05_L01:
       cmp       ebx,edi
       ja        short M05_L03
       mov       edi,ebx
M05_L02:
       mov       rcx,rsi
       jmp       short M05_L06
M05_L03:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M05_L04:
       test      ebx,ebx
       jne       short M05_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M05_L00
M05_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M05_L01
M05_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE8C2D4660]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M05_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        short M05_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M05_L09
M05_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M05_L10
M05_L09:
       mov       rax,[rcx]
       add       rax,10
M05_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M05_L11
       test      edi,edi
       jne       short M05_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M05_L14
M05_L11:
       cmp       [rcx+8],edi
       jae       short M05_L13
M05_L12:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M05_L13:
       add       rcx,10
M05_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M05_L16
       cmp       rdx,300
       ja        short M05_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M05_L16
M05_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE8BD35BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,2662FC01E78
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C2CBBD0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFE8C54C4E0]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFE8C54C4E0]
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
       call      qword ptr [7FFE8BC873F0]
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L00
       jmp       short M07_L01
M07_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C6F7EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M07_L01:
       mov       r8,2662FC0D218
       mov       r8,[r8]
       mov       rdx,rsi
       call      qword ptr [7FFE8C6EF708]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M07_L02
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L02:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE8BE656B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M07_L05
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        short M07_L03
       mov       rcx,2A6C1AACBE4
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       short M07_L04
M07_L03:
       lea       rcx,[rsp+28]
       mov       rdx,2A6C1AACBD8
       call      qword ptr [7FFE8BE658F0]
M07_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE8C0B4210]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M07_L06
M07_L05:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M07_L06:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M07_L07
       mov       rdx,2A6C1A90C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M07_L08
M07_L07:
       lea       rcx,[rsp+28]
       mov       rdx,2A6C1A90C48
       call      qword ptr [7FFE8BE658F0]
M07_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BE65740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BF06718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 417
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,2A6C1A90008
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
       mov       rax,[rdx]
M09_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M09_L02
M09_L01:
       mov       rax,rdx
       ret
M09_L02:
       test      rax,rax
       je        short M09_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M09_L01
       test      rax,rax
       je        short M09_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M09_L01
       test      rax,rax
       je        short M09_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M09_L01
       test      rax,rax
       jne       short M09_L00
M09_L03:
       jmp       qword ptr [7FFE8BC843A8]
; Total bytes of code 69
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonCollection()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       test      rcx,rcx
       je        near ptr M00_L05
       mov       [rsp+30],rcx
       mov       rcx,1AD6A00BDC8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C285488]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C284ED0]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C46F738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFE8BC97318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFE8C6FDEA8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE8C28D590]
       mov       ecx,78B
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE8BC943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE8C28D620]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE8C28D380]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1EDFBDDC7A0
       mov       r8,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 465
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF3ECB5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF3ECB9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF3ECB69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF3ECB5060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF3ECB6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF3ECB9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF3ECB4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF3ECB9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF3ECB4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF3ECB6A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF3ECB84A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,1EDFBDC2D10
       mov       r8d,1
       call      qword ptr [7FFE8C284E70]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE8C46F768]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE8C324930]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M03_L04
       cmp       [rcx+8],ebx
       jb        short M03_L03
M03_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M03_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M03_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M03_L01:
       cmp       ebx,edi
       ja        short M03_L03
       mov       edi,ebx
M03_L02:
       mov       rcx,rsi
       jmp       short M03_L06
M03_L03:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M03_L04:
       test      ebx,ebx
       jne       short M03_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M03_L00
M03_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M03_L01
M03_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE8C28F1B0]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L09
M03_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L10
M03_L09:
       mov       rax,[rcx]
       add       rax,10
M03_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M03_L11
       test      edi,edi
       jne       short M03_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M03_L14
M03_L11:
       cmp       [rcx+8],edi
       jae       short M03_L13
M03_L12:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M03_L13:
       add       rcx,10
M03_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M03_L16
       cmp       rdx,300
       ja        short M03_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L16
M03_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE8BD45BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,1AD6E001E78
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C2DBBD0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE8C55C0F0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE8C55C0F0]
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
       call      qword ptr [7FFE8BC973F0]
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C706918
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       r8,1AD6A00B220
       mov       r8,[r8]
       mov       rdx,rsi
       call      qword ptr [7FFE8C6FDF08]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M05_L02
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L02:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE8BE756B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M05_L05
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        short M05_L03
       mov       rcx,1EDFBDDCA7C
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       short M05_L04
M05_L03:
       lea       rcx,[rsp+28]
       mov       rdx,1EDFBDDCA70
       call      qword ptr [7FFE8BE758F0]
M05_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE8C09F9C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L06
M05_L05:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M05_L06:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L07
       mov       rdx,1EDFBDC0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L08
M05_L07:
       lea       rcx,[rsp+28]
       mov       rdx,1EDFBDC0C48
       call      qword ptr [7FFE8BE758F0]
M05_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BE75740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BF16718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 417
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEEEF10]
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
       mov       rax,1EDFBDC0008
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
       jmp       qword ptr [7FFE8BC943A8]
; Total bytes of code 69
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePerson()
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
       mov       rcx,2440840BDC8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C2668B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C2662F8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C476010]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFE8BC77318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE8C66F4F8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE8C26E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE8BC743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE8C26EA60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE8C26E7C0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2849A2DC0F0
       mov       r8,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 465
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF29105068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF29109F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF29104FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF291069F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF29105060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF29106948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF29104FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF29104FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF29109FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF29104FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF29109198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF29104820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF29106A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF291084A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,2849A2C2D10
       mov       r8d,1
       call      qword ptr [7FFE8C266298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE8C476040]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE8C305488]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M03_L04
       cmp       [rcx+8],ebx
       jb        short M03_L03
M03_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M03_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M03_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M03_L01:
       cmp       ebx,edi
       ja        short M03_L03
       mov       edi,ebx
M03_L02:
       mov       rcx,rsi
       jmp       short M03_L06
M03_L03:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L04:
       test      ebx,ebx
       jne       short M03_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M03_L00
M03_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M03_L01
M03_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE8C2C4660]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L09
M03_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L10
M03_L09:
       mov       rax,[rcx]
       add       rax,10
M03_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M03_L11
       test      edi,edi
       jne       short M03_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M03_L14
M03_L11:
       cmp       [rcx+8],edi
       jae       short M03_L13
M03_L12:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L13:
       add       rcx,10
M03_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M03_L16
       cmp       rdx,300
       ja        short M03_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L16
M03_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE8BD25BA8]
M03_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,2440C401E78
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C2BBBD0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE8C54CF90]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE8C54CF90]
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
       call      qword ptr [7FFE8BC773F0]
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L00
       jmp       short M05_L01
M05_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C64ABB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M05_L01:
       mov       r8,2440840B220
       mov       r8,[r8]
       mov       rdx,rsi
       call      qword ptr [7FFE8C66F558]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M05_L02
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L02:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE8BE556B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M05_L05
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        short M05_L03
       mov       rcx,2849A2DC394
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       short M05_L04
M05_L03:
       lea       rcx,[rsp+28]
       mov       rdx,2849A2DC388
       call      qword ptr [7FFE8BE558F0]
M05_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE8C0A4210]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L06
M05_L05:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M05_L06:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L07
       mov       rdx,2849A2C0C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L08
M05_L07:
       lea       rcx,[rsp+28]
       mov       rdx,2849A2C0C48
       call      qword ptr [7FFE8BE558F0]
M05_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BE55740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BEF6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 417
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,2849A2C0008
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
       jmp       qword ptr [7FFE8BC743A8]
; Total bytes of code 69
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+130]
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
; Total bytes of code 186
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFE8C165218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; Total bytes of code 63
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
       je        near ptr M01_L18
       mov       rax,1E7244009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,1E720403220
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE8C2868B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L19
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L20
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C45EFB8]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L22
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L21
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFE8BF6D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L24
       cmp       r9d,r15d
       jne       near ptr M01_L23
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
       call      qword ptr [7FFE8BED8A10]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r14,r14
       je        near ptr M01_L25
       lea       rsi,[r14+10]
       mov       ebx,[r14+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       lea       rdx,[r12+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L26
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
       mov       rcx,227B2179070
       xor       r9d,r9d
       call      qword ptr [7FFE8C6FD320]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       r12,10
       mov       ebx,20
       mov       rcx,1E720403228
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L15
       lea       rcx,[rsi+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L15
M01_L06:
       mov       rsi,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],rsi
       xor       edi,edi
       test      ebx,ebx
       jle       near ptr M01_L14
M01_L08:
       mov       ecx,edi
       movzx     ecx,byte ptr [r12+rcx]
       mov       r8,1E724400428
       mov       r8,[r8]
       mov       rdx,227B218C0D0
       call      qword ptr [7FFE8BEC4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [rsi],sil
       test      rax,rax
       je        short M01_L13
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r13d,[rax+r8]
       cmp       r13d,[rcx+8]
       ja        short M01_L12
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L10
M01_L09:
       mov       [rsi+18],r13d
       jmp       short M01_L13
M01_L10:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L12:
       mov       rcx,rsi
       call      qword ptr [7FFE8BF8CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       inc       edi
       cmp       edi,ebx
       jl        near ptr M01_L08
M01_L14:
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF95FA8]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       mov       rcx,rsp
       call      M01_L29
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
M01_L15:
       mov       r13,[rsi+18]
       mov       r15,[r13+18]
       lea       rdx,[rbp-68]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C26FFA8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L27
M01_L16:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L06
M01_L17:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L07
M01_L18:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r15,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L19:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,227B2172D10
       mov       r8d,1
       call      qword ptr [7FFE8C286298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L20:
       call      qword ptr [7FFE8BC943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L21:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE8BF650C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r14,rax
       jmp       near ptr M01_L05
M01_L22:
       mov       ecx,1763
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M01_L23:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFE8BC9C8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L24:
       call      qword ptr [7FFE8BC9C7E0]
       int       3
M01_L25:
       mov       ecx,6A61
       mov       rdx,7FFE8C277C50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M01_L26:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE8C675A70]
       mov       rbx,rax
       mov       ecx,4465
       mov       rdx,7FFE8C277C50
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFE8BC9F750]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L27:
       cmp       qword ptr [r15+10],0
       jne       short M01_L28
       xor       edx,edx
       mov       [rbp-68],rdx
       jmp       near ptr M01_L17
M01_L28:
       lea       rdx,[rbp-68]
       mov       rcx,r13
       call      qword ptr [7FFE8C26FAC8]
       test      eax,eax
       je        near ptr M01_L17
       jmp       near ptr M01_L16
M01_L29:
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
       mov       rcx,1E720403228
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L30
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L34
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8BF8C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L31
M01_L30:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L34
M01_L31:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L32
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L34
M01_L32:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L33
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C26FFD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L34
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C26FA98]
       jmp       short M01_L34
M01_L33:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L34:
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
; Total bytes of code 1565
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFE8C175218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
; Total bytes of code 63
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
       je        near ptr M01_L22
       mov       rax,244C14009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,244C140DDC0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFE8C2968B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L23
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L24
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C46ED48]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L27
       mov       r14d,[rdi+8]
       cmp       r14d,20
       jle       near ptr M01_L17
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r15,[rbp-48]
       mov       r13d,r14d
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FFE8BF7D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r15
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r12,r9d
       add       r12,[rbp-50]
       cmp       r12,7FFFFFFF
       ja        near ptr M01_L26
       cmp       r9d,r13d
       jne       near ptr M01_L25
M01_L04:
       xor       edx,edx
       mov       [rbp-48],rdx
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       [rsp+20],rsi
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,r14d
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFE8BEE8A10]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L28
       lea       rbx,[rax+10]
       mov       r15d,[rax+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L29
       xor       ecx,ecx
       mov       [rbp-80],rbx
       mov       [rbp-78],r15d
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
       mov       rcx,28553399070
       xor       r9d,r9d
       call      qword ptr [7FFE8C70FBD0]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       add       rsi,10
       mov       ebx,20
       mov       rcx,244C140DDC8
       mov       r13,[rcx]
       mov       rcx,[r13+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L15
       lea       rcx,[r13+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L15
M01_L06:
       mov       r15,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],r15
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M01_L14
M01_L08:
       mov       ecx,r13d
       movzx     ecx,byte ptr [rsi+rcx]
       mov       r8,244C1400428
       mov       r8,[r8]
       mov       rdx,285533AC0D0
       call      qword ptr [7FFE8BED4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [r15],r15b
       test      rax,rax
       je        short M01_L13
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,[r15+8]
       mov       eax,[r15+18]
       lea       r12d,[rax+r8]
       cmp       r12d,[rcx+8]
       ja        short M01_L12
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L11
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L10
M01_L09:
       mov       [r15+18],r12d
       jmp       short M01_L13
M01_L10:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L12:
       mov       rcx,r15
       call      qword ptr [7FFE8BF9CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       inc       r13d
       cmp       r13d,ebx
       jl        near ptr M01_L08
M01_L14:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BFA5FA8]; System.Text.StringBuilder.ToString()
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
M01_L15:
       mov       r12,[r13+18]
       mov       rdi,[r12+18]
       lea       rdx,[rbp-68]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C27FFA8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L19
M01_L16:
       add       r13,2C
       lock dec  dword ptr [r13]
       jmp       near ptr M01_L06
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFE8BF750C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L18:
       lea       rdx,[rbp-68]
       mov       rcx,r12
       call      qword ptr [7FFE8C27FAC8]
       test      eax,eax
       je        short M01_L20
       jmp       short M01_L16
M01_L19:
       cmp       qword ptr [rdi+10],0
       jne       short M01_L18
       xor       edx,edx
       mov       [rbp-68],rdx
M01_L20:
       mov       rdi,[r13+8]
       mov       rcx,7FFE8C290060
       cmp       [rdi+18],rcx
       jne       near ptr M01_L30
       mov       r13,[rdi+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edx,[r13+8]
       mov       rcx,r15
       mov       r8d,7FFFFFFF
       call      qword ptr [7FFE8BF9C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L21:
       jmp       near ptr M01_L07
M01_L22:
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,28553392D10
       mov       r8d,1
       call      qword ptr [7FFE8C296298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       r12,rax
       lea       rcx,[rsi+18]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,r12
       jmp       near ptr M01_L02
M01_L24:
       call      qword ptr [7FFE8BCA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L25:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFE8BCAC8A0]
       add       r12d,eax
       jns       near ptr M01_L04
M01_L26:
       call      qword ptr [7FFE8BCAC7E0]
       int       3
M01_L27:
       mov       ecx,1763
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF266E8]
       int       3
M01_L28:
       mov       ecx,6A61
       mov       rdx,7FFE8C287C50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF266E8]
       int       3
M01_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C686088]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFE8C287C50
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       r15,rax
       jmp       near ptr M01_L21
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
       mov       rcx,244C140DDC8
       mov       r15,[rcx]
       mov       rax,[r15+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L32
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L36
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE8BF9C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L33
M01_L32:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rbx,[rbp-0A8]
       je        short M01_L36
M01_L33:
       cmp       qword ptr [r15+20],0
       jne       short M01_L34
       lea       rcx,[r15+20]
       mov       rdx,rbx
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L36
M01_L34:
       lea       rcx,[r15+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[r15+28]
       jg        short M01_L35
       mov       r15,[r15+18]
       mov       rcx,[r15+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C27FFD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L36
       mov       rcx,r15
       mov       rdx,rbx
       call      qword ptr [7FFE8C27FA98]
       jmp       short M01_L36
M01_L35:
       add       r15,2C
       lock dec  dword ptr [r15]
M01_L36:
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
; Total bytes of code 1626
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8C6EE040]; System.Data.DataTable..ctor()
       mov       rcx,2954C2BC0D0
       mov       [rbx+70],rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rsp+28]
       xor       r8d,r8d
       mov       r9d,34
       call      qword ptr [7FFE8BBD6700]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       cmp       dword ptr [rsp+38],0
       je        near ptr M00_L13
       cmp       dword ptr [rsp+38],1
       je        near ptr M00_L10
       mov       edi,[rsp+38]
       test      edi,edi
       jl        near ptr M00_L14
       mov       rsi,[rsp+28]
       test      rsi,rsi
       je        near ptr M00_L15
       mov       ebp,[rsi+8]
       cmp       ebp,edi
       je        short M00_L01
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rsi+10]
       cmp       edi,ebp
       cmovg     edi,ebp
       mov       r8d,edi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L09
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       [rsp+28],r14
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
       jne       near ptr M00_L11
       mov       rcx,r14
       mov       rdx,[rcx+28]
       test      rdx,rdx
       je        short M00_L08
M00_L04:
       cmp       [rdx],dl
       mov       rcx,2954C2B31C8
       call      qword ptr [7FFE8BBCA7B0]; System.RuntimeType.IsAssignableFrom(System.Type)
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
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       cmp       [rax],rcx
       jne       short M00_L12
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFE8C746C40]; System.Threading.ReaderWriterLockSlim.Dispose(Boolean)
       jmp       short M00_L05
M00_L08:
       mov       rcx,r14
       call      qword ptr [7FFE8BF973C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       short M00_L04
M00_L09:
       call      qword ptr [7FFE8BD35BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+30]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L04
M00_L12:
       mov       rcx,rax
       mov       r11,7FFE8BB40E08
       call      qword ptr [r11]
       jmp       near ptr M00_L05
M00_L13:
       mov       rcx,254BA401F50
       mov       rsi,[rcx]
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE8BEDED18]
       int       3
M00_L15:
       movsxd    rdx,edi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+28],rax
       jmp       near ptr M00_L01
; Total bytes of code 566
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
       mov       rsi,2954C2A0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,2954C2BC170
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,2954C2BC248
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,254BA401F98
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,254BA401FA0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,254BA401FA8
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
       mov       rcx,7FFE8BBC5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFE8C702128
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,254BA4116F0
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
       mov       rdx,2954C2BC0F0
       call      qword ptr [7FFE8BC86C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE8BD376D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C7465E0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C7449A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,254BA401E80
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
       call      qword ptr [7FFE8C745728]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,254BA401FC0
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
       mov       rsi,rdx
       mov       rdi,r8
       mov       ebx,r9d
       xor       r14d,r14d
       xor       r15d,r15d
       test      rdi,rdi
       jne       near ptr M02_L10
M02_L00:
       xor       r13d,r13d
M02_L01:
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        near ptr M02_L09
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M02_L09
M02_L02:
       mov       rbp,rdi
       cmp       [r12],r12b
       lea       rax,[r12+48]
       mov       [rsp+30],rax
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L03
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
M02_L03:
       mov       r12,rdx
       cmp       [r12],r12b
       cmp       r13d,1
       je        near ptr M02_L14
       cmp       r13d,2
       je        near ptr M02_L16
       cmp       byte ptr [r12+18],0
       je        near ptr M02_L12
       mov       rbp,[r12+8]
M02_L04:
       xor       ebx,2
       mov       r13d,[rbp+8]
       mov       ecx,r13d
       xor       r8d,r8d
       mov       [rsp+40],r8
       mov       [rsp+48],r8
       mov       [rsp+50],r8d
       mov       [rsp+54],ecx
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M02_L08
M02_L05:
       mov       ecx,r12d
       mov       rax,[rbp+rcx*8+10]
       mov       [rsp+38],rax
       mov       ecx,[rax+18]
       mov       r8d,ebx
       and       r8d,ecx
       cmp       r8d,ecx
       jne       short M02_L07
       test      r14d,r14d
       jne       near ptr M02_L18
M02_L06:
       lea       rcx,[rsp+40]
       mov       r8,rax
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF54BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L07:
       inc       r12d
       cmp       r13d,r12d
       jg        short M02_L05
M02_L08:
       mov       rdx,[rsp+40]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,[rsp+50]
       mov       [rsi+10],eax
       mov       eax,[rsp+54]
       mov       [rsi+14],eax
       mov       rax,rsi
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
M02_L09:
       mov       rcx,rbp
       call      qword ptr [7FFE8BBD6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M02_L02
M02_L10:
       test      bl,1
       je        short M02_L13
       mov       rcx,254BA400590
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFE8BE8C1C8]
       mov       rdi,rax
       mov       r15d,1
       mov       r13d,2
M02_L11:
       cmp       byte ptr [rsp+0C0],0
       jne       near ptr M02_L19
       jmp       near ptr M02_L01
M02_L12:
       mov       rcx,r12
       mov       r8d,r13d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE8BF54E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rbp,rax
       jmp       near ptr M02_L04
M02_L13:
       mov       r13d,1
       jmp       short M02_L11
M02_L14:
       lea       rcx,[r12+20]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE8BF2CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M02_L15
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFE8BF54E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M02_L15:
       mov       rbp,rax
       jmp       near ptr M02_L04
M02_L16:
       lea       rcx,[r12+28]
       mov       r8,rbp
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeFieldInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE8BF2CEA0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M02_L17
       mov       rcx,r12
       mov       rdx,rbp
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFE8BF54E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M02_L17:
       mov       rbp,rax
       jmp       near ptr M02_L04
M02_L18:
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8d,r15d
       call      qword ptr [7FFE8BBD6538]
       test      eax,eax
       je        near ptr M02_L07
       mov       rax,[rsp+38]
       jmp       near ptr M02_L06
M02_L19:
       mov       rcx,rdi
       mov       edx,2A
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC86160]; System.String.EndsWith(Char)
       test      eax,eax
       je        near ptr M02_L01
       mov       r8d,[rdi+8]
       dec       r8d
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFE8BC87240]; System.String.Substring(Int32, Int32)
       mov       rdi,rax
       mov       r14d,1
       jmp       near ptr M02_L00
; Total bytes of code 714
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
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE8BBD4E10]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M03_L02
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8BBD6148]
M03_L02:
       cmp       [rsi],sil
       mov       rcx,rsi
       call      System.RuntimeTypeHandle.IsGenericVariable(System.RuntimeType)
       test      eax,eax
       je        short M03_L06
       mov       rcx,rsi
       call      qword ptr [7FFE8BBCA5A0]; Precode of System.RuntimeType.GetGenericParameterConstraints()
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
       jmp       qword ptr [7FFE8BC84378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 110
```
```assembly
; System.Threading.ReaderWriterLockSlim.Dispose(Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      dl,dl
       je        near ptr M05_L10
       cmp       byte ptr [rbx+4F],0
       jne       near ptr M05_L10
       cmp       dword ptr [rbx+34],0
       jg        near ptr M05_L11
       cmp       dword ptr [rbx+3C],0
       jg        near ptr M05_L11
       cmp       dword ptr [rbx+30],0
       jg        near ptr M05_L11
       mov       rax,gs:[58]
       mov       rax,[rax+38]
       cmp       dword ptr [rax+190],4
       jl        near ptr M05_L12
       mov       rax,[rax+198]
       mov       rax,[rax+20]
       test      rax,rax
       je        near ptr M05_L12
       mov       rax,[rax]
       add       rax,10
M05_L00:
       mov       rax,[rax+28]
       test      rax,rax
       je        short M05_L02
M05_L01:
       mov       rcx,[rax+10]
       cmp       rcx,[rbx+28]
       je        short M05_L03
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M05_L01
M05_L02:
       xor       eax,eax
M05_L03:
       test      rax,rax
       je        short M05_L04
       mov       eax,[rax+18]
       test      eax,eax
       jg        near ptr M05_L25
M05_L04:
       cmp       byte ptr [rbx+4C],0
       jne       near ptr M05_L13
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       eax,[rbx+40]
       je        near ptr M05_L25
M05_L05:
       cmp       byte ptr [rbx+4C],0
       jne       near ptr M05_L19
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       eax,[rbx+44]
       je        near ptr M05_L25
M05_L06:
       cmp       qword ptr [rbx+8],0
       jne       near ptr M05_L26
       cmp       qword ptr [rbx+10],0
       jne       near ptr M05_L27
M05_L07:
       cmp       qword ptr [rbx+18],0
       jne       near ptr M05_L28
M05_L08:
       cmp       qword ptr [rbx+20],0
       jne       near ptr M05_L29
M05_L09:
       mov       byte ptr [rbx+4F],1
M05_L10:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L11:
       mov       rcx,offset MT_System.Threading.SynchronizationLockException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C2579C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C74F900]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L00
M05_L13:
       xor       esi,esi
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,[rax+28]
       test      rcx,rcx
       je        short M05_L16
M05_L14:
       mov       rax,[rcx+10]
       cmp       rax,[rbx+28]
       jne       short M05_L15
       jmp       short M05_L17
M05_L15:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M05_L14
M05_L16:
       xor       ecx,ecx
M05_L17:
       test      rcx,rcx
       je        short M05_L18
       mov       esi,[rcx+20]
M05_L18:
       test      esi,esi
       jle       near ptr M05_L05
       jmp       short M05_L25
M05_L19:
       xor       esi,esi
       mov       ecx,4
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,[rax+28]
       test      rcx,rcx
       je        short M05_L22
M05_L20:
       mov       rax,[rcx+10]
       cmp       rax,[rbx+28]
       jne       short M05_L21
       jmp       short M05_L23
M05_L21:
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       short M05_L20
M05_L22:
       xor       ecx,ecx
M05_L23:
       test      rcx,rcx
       je        short M05_L24
       mov       esi,[rcx+1C]
M05_L24:
       test      esi,esi
       jle       near ptr M05_L06
M05_L25:
       mov       rcx,offset MT_System.Threading.SynchronizationLockException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C2579C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C74F900]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L26:
       mov       rsi,[rbx+8]
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       ecx,ecx
       mov       [rbx+8],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M05_L07
M05_L27:
       mov       rsi,[rbx+10]
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       ecx,ecx
       mov       [rbx+10],rcx
       cmp       qword ptr [rbx+18],0
       je        near ptr M05_L08
M05_L28:
       mov       rsi,[rbx+18]
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       ecx,ecx
       mov       [rbx+18],rcx
       cmp       qword ptr [rbx+20],0
       je        near ptr M05_L09
M05_L29:
       mov       rsi,[rbx+20]
       mov       rcx,rsi
       mov       edx,1
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rcx,rsi
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       xor       eax,eax
       mov       [rbx+20],rax
       jmp       near ptr M05_L09
; Total bytes of code 666
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
       call      qword ptr [7FFEEA8B0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       rbx,4000
       add       rsi,4000
       cmp       rdi,4000
       ja        short M07_L00
M07_L01:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFEEA8B0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFEEA8B0D08]; System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       rdi,4000
       ja        short M07_L03
       jmp       short M07_L01
; Total bytes of code 150
```
**Extern method**
System.Object.GetType()
System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       [rsp+30],rdx
       mov       rdx,2C4439EC0D0
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE8BBCA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
; Total bytes of code 95
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
       call      qword ptr [7FFE8BBD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FFE8BEDF180]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF54B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE8C1B5ED8]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FFE8BBD5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF54B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
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
       call      qword ptr [7FFE8BF54B70]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rbx
       sub       rsp,40
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       [rsp+30],rdx
       mov       rdx,2ABC747C0D0
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE8BBBA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
; Total bytes of code 95
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
       call      qword ptr [7FFE8BBC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FFE8BECF180]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF44B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE8C1A5410]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FFE8BBC5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF44B88]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BEF66E8]
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
       call      qword ptr [7FFE8BF44B70]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+120],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 21
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+130],0
       setne     al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 21
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull01()
       xor       eax,eax
       cmp       qword ptr [rcx+120],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 21
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull02()
       xor       eax,eax
       cmp       qword ptr [rcx+130],0
       sete      al
       mov       rcx,[rcx+18]
       mov       [rcx+4C],al
       ret
; Total bytes of code 21
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+130]
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
       mov       rdx,2DAFB74C0D0
       call      qword ptr [7FFE8C137948]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
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
; Total bytes of code 205
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
       mov       ebp,1
       mov       ecx,32
       xor       edx,edx
       mov       [rsp+28],rdx
       xor       edx,edx
       cmp       ebp,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        short M01_L07
M01_L01:
       test      eax,eax
       je        short M01_L08
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
       call      qword ptr [7FFE8BD25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M01_L00
M01_L06:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L07:
       cmp       byte ptr [rsp+28],0
       je        short M01_L01
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BD247B0]; System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_Value()
       mov       ecx,eax
       jmp       short M01_L02
M01_L08:
       call      qword ptr [7FFE8C26E9B8]
       mov       r14,rax
       test      r14,r14
       jne       short M01_L09
       call      qword ptr [7FFE8C26E7D8]
       mov       r14,rax
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2DAFB746420
       mov       r8,r14
       call      qword ptr [7FFE8BD2D470]
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
       mov       ecx,0A2B
       mov       rdx,7FFE8BFF2188
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFE8C265EF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BD2D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 361
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C147920]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,26A00D48D90
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
       call      qword ptr [7FFE8BBD6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,26A00D5AEF8
       xor       edx,edx
       call      qword ptr [7FFE8BBD6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFE8BC861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,26A00D45F40
       test      eax,eax
       cmovne    rdi,rcx
       mov       rcx,rbx
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFE8C6E93E0
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,26A00D40008
       call      qword ptr [7FFE8C6ED458]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC862F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFE8C78D9B0]
       int       3
M01_L03:
       mov       rax,26A00D40008
       jmp       short M01_L01
M01_L04:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L05:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,7D3
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,25082F10008
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
; Total bytes of code 79
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
       call      qword ptr [7FFE8BC8EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,20FF100B210
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC8EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BC8EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C18EFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE65740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFE8C66E2F8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF55908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,25082F10008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,20FF5001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BFFEA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FFE8BE150A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFE8BF2E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,25082F2C100
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C66E3B8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,20FF100BEE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,20FF100BED8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C66A418
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,20FF100BEE8
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C66EF10]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF2E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,20FF100BED8
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C66A430
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB40C18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FFE8BB40C10
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,25082F24C60
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
       call      qword ptr [7FFE8BF56208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF56280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L41
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BFEE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFE8BF35F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       je        near ptr M01_L37
M01_L30:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L40
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L39
       mov       r10,[rcx]
       add       r10,10
M01_L31:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L32
       mov       r9,20FF5000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L32
       mov       r9,20FF5000418
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
       mov       rdx,25082F2C128
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,20FF100BEF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L45
M01_L35:
       mov       rcx,20FF100BEF8
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
       call      qword ptr [7FFE8C66EF10]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,20FF100BED8
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C66A460
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,20FF100BEF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,20FF100BED8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C66A448
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,20FF100BEF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L46:
       call      CORINFO_HELP_OVERFLOW
M01_L47:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L48:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L49:
       mov       r11,7FFE8BB40C28
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L50:
       mov       rcx,rax
       mov       r11,7FFE8BB40C08
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L51:
       mov       r11,7FFE8BB40C20
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L52:
       mov       rcx,20FF5001E00
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
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L56:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE65848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,25082F24C60
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L62:
       call      qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF551B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF55230]
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
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FFE8BF04F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FFE8BF04F30]
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
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FFE8BB40C20
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
; Total bytes of code 3770
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,2B3BFF80008
       xor       r8d,r8d
       call      qword ptr [7FFE8C1752C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFE8BCAEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L46
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L47
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,2732E002668
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BCAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C1AEFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FFE8C68D110]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L05:
       test      r15,r15
       je        near ptr M01_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2B3BFF80008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,27332001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8C01EA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BCA43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L49
       call      qword ptr [7FFE8BE350A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFE8BF4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BEA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2B3BFF9C100
       call      qword ptr [7FFE8BCA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1752C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C68D1D0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2732E003338
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2732E003330
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689230
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       r14,2732E003340
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L16
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C68DD28]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L18
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L15:
       test      eax,eax
       jne       near ptr M01_L10
       jmp       near ptr M01_L20
M01_L16:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2732E003330
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689248
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L13
M01_L17:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB60C10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L18:
       mov       r11,7FFE8BB60C08
       call      qword ptr [r11]
       jmp       near ptr M01_L15
M01_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,2B3BFF94C60
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
       call      qword ptr [7FFE8BF76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L40
M01_L24:
       mov       rdx,[rbp-160]
M01_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8C00E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFE8BF55F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L29
       test      rax,rax
       je        near ptr M01_L36
M01_L29:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L39
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L38
       mov       r10,[rcx]
       add       r10,10
M01_L30:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L31
       mov       r9,27332000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L31
       mov       r9,27332000418
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
       mov       rdx,2B3BFF9C128
       call      qword ptr [7FFE8BCA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1752C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L69
       test      rax,rax
       je        near ptr M01_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BCA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,2732E003348
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L44
M01_L34:
       mov       rcx,2732E003350
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
       call      qword ptr [7FFE8C68DD28]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,2732E003330
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689278
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2732E003350
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L35
M01_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2732E003330
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689260
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2732E003348
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L34
M01_L45:
       call      CORINFO_HELP_OVERFLOW
M01_L46:
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L47:
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF26670]
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
       mov       r11,7FFE8BB60C20
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L50:
       mov       rcx,rax
       mov       r11,7FFE8BB60C00
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L51:
       mov       r11,7FFE8BB60C18
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L52:
       mov       rcx,27332001E00
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
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L56:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M01_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE85848]
       jmp       near ptr M01_L03
M01_L58:
       mov       rcx,rax
       mov       rdx,2B3BFF94C60
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L30
M01_L62:
       call      qword ptr [7FFE8BEA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF751B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF75230]
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
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C24E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C24DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L69:
       mov       ecx,4
       call      qword ptr [7FFE8BF24F30]
       int       3
M01_L70:
       mov       ecx,0E
       call      qword ptr [7FFE8BF24F30]
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
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L72
       mov       r11,7FFE8BB60C18
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
; Total bytes of code 3779
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,1FCE0A40008
       mov       r8d,1
       call      qword ptr [7FFE8C1752C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
; Total bytes of code 79
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
       call      qword ptr [7FFE8BCAEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1BC4EC0D208
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BCAEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BCAEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C1AEFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE85740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFE8C68D5F0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF75908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,1FCE0A40008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1BC4EC01DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8C01EA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BCA43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L52
       call      qword ptr [7FFE8BE350A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFE8BF4E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BEA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1FCE0A5C0D8
       call      qword ptr [7FFE8BCA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1752C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C68D6B0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1BC4EC0DED8
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1BC4EC0DED0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689710
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,1BC4EC0DEE0
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C68E208]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF4E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1BC4EC0DED0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689728
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB60C48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FFE8BB60C40
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,1FCE0A54C60
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
       call      qword ptr [7FFE8BF76208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF76280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L43
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8C00E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFE8BF55F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L29:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L30
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M01_L38
M01_L30:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+38]
       cmp       dword ptr [rdx+190],3
       jl        near ptr M01_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L41
       mov       r8,[rdx]
       add       r8,10
M01_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L32
       mov       r10,1BC4EC00438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,1BC4EC00418
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
       mov       rdx,1FCE0A5C100
       call      qword ptr [7FFE8BCA6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1752C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BCA4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,1BC4EC0DEE8
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L36:
       mov       rcx,1BC4EC0DEF0
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
       call      qword ptr [7FFE8C68E208]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,1BC4EC0DED0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689758
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1BC4EC0DEF0
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
       call      qword ptr [7FFE8BF751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF75230]; System.MdUtf8String.ToString()
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
       mov       rcx,1BC4EC0DED0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C689740
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1BC4EC0DEE8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF26670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L52:
       mov       r11,7FFE8BB60C58
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L53:
       mov       rcx,rax
       mov       r11,7FFE8BB60C38
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L54:
       mov       r11,7FFE8BB60C50
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L55:
       mov       rcx,1BC4EC01E00
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
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF26670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L59:
       call      qword ptr [7FFE8BEFE9A0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE85848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,1FCE0A54C60
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L65:
       call      qword ptr [7FFE8BEA4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE8C29E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C022E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C167AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCA6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C29E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF26670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C24E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BCAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C24DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCAF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FFE8BF24F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FFE8BF24F30]
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
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FFE8BB60C50
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
; Total bytes of code 3790
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,30871320008
       xor       r8d,r8d
       call      qword ptr [7FFE8C1552C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFE8BC8EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L51
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,2C7E340D208
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC8EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BC8EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C18EFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE65740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFE8C66DEA8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L55
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L56
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF55908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       test      r15,r15
       je        near ptr M01_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,30871320008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,2C7E3401DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BFFEA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L53
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L52
       call      qword ptr [7FFE8BE150A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFE8BF2E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,3087133C100
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C66DF68]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2C7E340DED8
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2C7E340DED0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C669FC8
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,2C7E340DEE0
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C66EAC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF2E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,2C7E340DED0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C669FE0
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB40C48
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FFE8BB40C40
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,30871334C60
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
       call      qword ptr [7FFE8BF56208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF56280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L43
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BFEE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFE8BF35F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       cmp       dword ptr [rdx+190],3
       jl        near ptr M01_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L41
       mov       r8,[rdx]
       add       r8,10
M01_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L32
       mov       r10,2C7E3400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,2C7E3400418
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
       mov       rdx,3087133C128
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L72
       test      rax,rax
       je        near ptr M01_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,2C7E340DEE8
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L36:
       mov       rcx,2C7E340DEF0
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
       call      qword ptr [7FFE8C66EAC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
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
       mov       rcx,2C7E340DED0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C66A010
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2C7E340DEF0
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
       call      qword ptr [7FFE8BF551B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF55230]; System.MdUtf8String.ToString()
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
       mov       rcx,2C7E340DED0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C669FF8
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2C7E340DEE8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L52:
       mov       r11,7FFE8BB40C58
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L53:
       mov       rcx,rax
       mov       r11,7FFE8BB40C38
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L54:
       mov       r11,7FFE8BB40C50
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L55:
       mov       rcx,2C7E3401E00
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
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L59:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M01_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE65848]
       jmp       near ptr M01_L03
M01_L61:
       mov       rcx,rax
       mov       rdx,30871334C60
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L65:
       call      qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L72:
       mov       ecx,4
       call      qword ptr [7FFE8BF04F30]
       int       3
M01_L73:
       mov       ecx,0E
       call      qword ptr [7FFE8BF04F30]
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
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L75
       mov       r11,7FFE8BB40C50
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
; Total bytes of code 3790
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+120]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,27C8F818D90
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
       call      qword ptr [7FFE8BC06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,27C8F82AEF8
       xor       edx,edx
       call      qword ptr [7FFE8BC06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE8BCB61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,27C8F815F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE8C1849F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,27C8F810008
       call      qword ptr [7FFE8C617438]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BCB62F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE8C7C7930]
       int       3
M00_L03:
       mov       rsi,27C8F810008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,78B
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,7D3
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 786
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
       call      qword ptr [7FFE8BC06658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF5CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FFE8BF0EC88]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE8C6429A0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BEB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C1150F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE8BBF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,23BFD8003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C1150F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE8BCB5F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C285338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BCBF750]
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
       call      qword ptr [7FFE8BCBEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L46
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L47
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,23BFD80D208
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BCBEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M03_L48
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE8BCBEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C1BE598]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE95740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M03_L22
M03_L04:
       mov       rcx,r15
       call      qword ptr [7FFE8C617858]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BC066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L52
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L53
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF85908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L05:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,27C8F810008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,23BFD801DA8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BFD9AA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L55
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L06:
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BCB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L50
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L49
       call      qword ptr [7FFE8BE450A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L08:
       mov       rcx,rax
M03_L09:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L14
M03_L10:
       cmp       r12,rdi
       jne       near ptr M03_L18
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE8BF5E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L16
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BEB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,27C8F82C110
       call      qword ptr [7FFE8BCB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1849F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C617918]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,23BFD80DED8
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,23BFD80DED0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       r14,23BFD80DEE0
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L17
M03_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C61C4F8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L19
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF5E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L15:
       test      eax,eax
       jne       near ptr M03_L10
       jmp       short M03_L20
M03_L16:
       call      CORINFO_HELP_OVERFLOW
M03_L17:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,23BFD80DED0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L13
M03_L18:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB70C50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L11
M03_L19:
       mov       r11,7FFE8BB70C48
       call      qword ptr [r11]
       jmp       near ptr M03_L15
M03_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BCB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L21
       cmp       [rcx],rdi
       jne       near ptr M03_L51
M03_L21:
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
M03_L22:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L37
M03_L23:
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
       mov       r8,27C8F824C60
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
       call      qword ptr [7FFE8BF86208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF86280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L40
M03_L24:
       mov       rdx,[rbp-160]
M03_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BFCC6A8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L26
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L36
M03_L26:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L59
M03_L27:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE8BF65F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L29
       test      rax,rax
       je        near ptr M03_L36
M03_L29:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L39
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L38
       mov       r10,[rcx]
       add       r10,10
M03_L30:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L31
       mov       r9,23BFD800438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L31
       mov       r9,23BFD800418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L62
M03_L31:
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
M03_L32:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,27C8F82C138
       call      qword ptr [7FFE8BCB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1849F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BCB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M03_L33:
       mov       rcx,23BFD80DEE8
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L44
M03_L34:
       mov       rcx,23BFD80DEF0
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L43
       mov       rax,[rbp-138]
M03_L35:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C61C4F8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L36:
       add       esi,1
       jo        near ptr M03_L45
       cmp       esi,r15d
       jl        near ptr M03_L23
M03_L37:
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
M03_L38:
       jmp       near ptr M03_L61
M03_L39:
       jmp       near ptr M03_L61
M03_L40:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L41
       mov       r8,[rbp-98]
       jmp       short M03_L42
M03_L41:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
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
       jl        short M03_L40
       jmp       near ptr M03_L24
M03_L43:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,23BFD80DED0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,23BFD80DEF0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L35
M03_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,23BFD80DED0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,23BFD80DEE8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L34
M03_L45:
       call      CORINFO_HELP_OVERFLOW
M03_L46:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,79D
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF36670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L47:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,78B
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L48:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M03_L02
M03_L49:
       mov       r11,7FFE8BB70C60
       call      qword ptr [r11]
       jmp       near ptr M03_L08
M03_L50:
       mov       rcx,rax
       mov       r11,7FFE8BB70C40
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L51:
       mov       r11,7FFE8BB70C58
       call      qword ptr [r11]
       jmp       near ptr M03_L21
M03_L52:
       mov       rcx,23BFD801E00
       mov       r15,[rcx]
       jmp       near ptr M03_L05
M03_L53:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L05
M03_L54:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,0F
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF36670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L06
M03_L56:
       call      qword ptr [7FFE8BF0E9A0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE95848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,27C8F824C60
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L25
M03_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L27
M03_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L28
M03_L61:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L30
M03_L62:
       call      qword ptr [7FFE8BEB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF851B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF85230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L32
M03_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L32
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L33
M03_L66:
       call      qword ptr [7FFE8C2AD590]
       mov       ecx,0C65
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C032F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C177AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCB6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C2AD380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF36670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C25CE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BCBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C25C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BCBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FFE8BF34F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FFE8BF34F30]
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
       call      qword ptr [7FFE8BCB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FFE8BB70C58
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
; Total bytes of code 3775
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       call      qword ptr [7FFE8BEB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,27C8F82C9E8
       call      qword ptr [7FFE8BCB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,23BFD800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,23BFD800418
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
       mov       rdx,27C8F82C9E8
       call      qword ptr [7FFE8BCB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FFE8BB70CB8
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,23BFD800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,23BFD800418
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
       mov       rdx,27C8F82C9E8
       call      qword ptr [7FFE8BCB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE8BEB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE8BF0EFB8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE8C6D1A98
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
       mov       r11,7FFE8BB70CB8
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
       mov       rdx,7FFE8C6D1A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE8BEB4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE8C6D19C0
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
       call      qword ptr [7FFE8BF34F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE8BF34F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE8BB70CC0
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
       mov       r11,7FFE8BB70CC0
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
       lea       rcx,[7FFE8C65AF30]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BEB4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C115200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE8BBF539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,23BFD8003D8
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
       call      qword ptr [7FFE8C115200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FFE8BD65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE8C486940]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FFE8C486910]
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
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF366E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BF0EC88]
       int       3
M06_L10:
       mov       rcx,7FFE8BBF5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE8BF0ECD0]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C285338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BCBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L09
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        near ptr M07_L05
       test      r8b,18
       jne       near ptr M07_L07
       test      r8b,4
       jne       near ptr M07_L06
       test      r8,r8
       je        short M07_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L04
       jmp       near ptr M07_L08
M07_L00:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M07_L00
       and       r8,3F
       cmp       r8,10
       jbe       short M07_L02
M07_L01:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M07_L02
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M07_L02:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M07_L04
M07_L03:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD65B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L04:
       pop       rbx
       pop       rsi
       ret
M07_L05:
       cmp       r8,40
       jbe       short M07_L01
       cmp       r8,800
       ja        short M07_L03
       mov       rax,r8
       shr       rax,6
       jmp       short M07_L00
M07_L06:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M07_L04
M07_L07:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M07_L04
M07_L08:
       movsx     rcx,word ptr [rbx-2]
       mov       [rsi-2],cx
       jmp       short M07_L04
M07_L09:
       cmp       rcx,rdx
       je        short M07_L04
       jmp       short M07_L03
; Total bytes of code 270
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
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BF0EF10]
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
       mov       rax,27C8F810008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+120]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2357DA68D90
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
       call      qword ptr [7FFE8BBC6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2357DA7AEF8
       xor       edx,edx
       call      qword ptr [7FFE8BBC6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE8BC761D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2357DA66960
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE8C1349F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,2357DA60008
       call      qword ptr [7FFE8C5CC168]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC762F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE8C76C468]
       int       3
M00_L03:
       mov       rsi,2357DA60008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,78B
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,7D3
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
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
       call      qword ptr [7FFE8BBC6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF440D8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FFE8BECEC88]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE8C5F29A0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0C51E8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE8BBB5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F4EFC003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C0C51E8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE8BC75F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C235338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BC7F750]
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
       call      qword ptr [7FFE8BC7EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L47
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L48
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1F4EBC02668
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC7EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M03_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M03_L49
       mov       r8,rbx
M03_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FFE8BC7EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C17E598]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE55740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r12,rax
       jmp       near ptr M03_L22
M03_L04:
       mov       rcx,r15
       call      qword ptr [7FFE8C5CC588]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L53
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L54
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF45158]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L05:
       test      r15,r15
       je        near ptr M03_L55
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2357DA60008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1F4EFC01D68
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BF20560]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L56
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L06:
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L51
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L50
       call      qword ptr [7FFE8BE050A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L08:
       mov       rcx,rax
M03_L09:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L14
M03_L10:
       cmp       r12,rdi
       jne       near ptr M03_L18
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE8BF46640]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L16
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2357DA7C110
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1349F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C5CC648]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1F4EBC03338
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1F4EBC03330
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L12:
       mov       r14,1F4EBC03340
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L17
M03_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C5CD1A0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L19
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF465C8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L15:
       test      eax,eax
       jne       near ptr M03_L10
       jmp       short M03_L20
M03_L16:
       call      CORINFO_HELP_OVERFLOW
M03_L17:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1F4EBC03330
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L13
M03_L18:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB30C50
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L11
M03_L19:
       mov       r11,7FFE8BB30C48
       call      qword ptr [r11]
       jmp       near ptr M03_L15
M03_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L21
       cmp       [rcx],rdi
       jne       near ptr M03_L52
M03_L21:
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
M03_L22:
       xor       esi,esi
       test      r15d,r15d
       jle       near ptr M03_L37
M03_L23:
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
       mov       r8,2357DA74C60
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
       call      qword ptr [7FFE8BF4DBC0]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF4DC38]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L24:
       mov       rdx,[rbp-160]
M03_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BEFEAC0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L26
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L36
M03_L26:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L61
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L60
M03_L27:
       test      rcx,rcx
       je        near ptr M03_L69
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE8BF50C60]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L29
       test      rax,rax
       je        near ptr M03_L36
M03_L29:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L39
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L38
       mov       r10,[rcx]
       add       r10,10
M03_L30:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L31
       mov       r9,1F4EFC00438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L31
       mov       r9,1F4EFC00418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L63
M03_L31:
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
M03_L32:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2357DA7C138
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1349F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L70
       test      rax,rax
       je        near ptr M03_L71
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M03_L33:
       mov       rcx,1F4EBC03348
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L44
M03_L34:
       mov       rcx,1F4EBC03350
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L42
       mov       rax,[rbp-138]
M03_L35:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C5CD1A0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L36:
       add       esi,1
       jo        near ptr M03_L46
       cmp       esi,r15d
       jl        near ptr M03_L23
M03_L37:
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
M03_L38:
       jmp       near ptr M03_L62
M03_L39:
       jmp       near ptr M03_L62
M03_L40:
       mov       rcx,[rbp-0A0]
       cmp       eax,[rcx+8]
       jae       near ptr M03_L72
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L41:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L43
       jmp       near ptr M03_L24
M03_L42:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,1F4EBC03330
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1F4EBC03350
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L35
M03_L43:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M03_L40
       jmp       short M03_L45
M03_L44:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1F4EBC03330
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1F4EBC03348
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L34
M03_L45:
       mov       r8,[rbp-98]
       jmp       near ptr M03_L41
M03_L46:
       call      CORINFO_HELP_OVERFLOW
M03_L47:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,79D
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L48:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,78B
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L49:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M03_L02
M03_L50:
       mov       r11,7FFE8BB30C60
       call      qword ptr [r11]
       jmp       near ptr M03_L08
M03_L51:
       mov       rcx,rax
       mov       r11,7FFE8BB30C40
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L52:
       mov       r11,7FFE8BB30C58
       call      qword ptr [r11]
       jmp       near ptr M03_L21
M03_L53:
       mov       rcx,1F4EFC01E00
       mov       r15,[rcx]
       jmp       near ptr M03_L05
M03_L54:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L05
M03_L55:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,0F
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L56:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L06
M03_L57:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L58:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE55848]
       jmp       near ptr M03_L03
M03_L59:
       mov       rcx,rax
       mov       rdx,2357DA74C60
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L25
M03_L60:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L27
M03_L61:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L28
M03_L62:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L30
M03_L63:
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L64:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF4CB88]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF4CC00]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L32
M03_L65:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L32
M03_L66:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L33
M03_L67:
       call      qword ptr [7FFE8C25D590]
       mov       ecx,0C65
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BF5D0F8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C128088
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C25D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C21CE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C21C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L70:
       mov       ecx,4
       call      qword ptr [7FFE8BEF4F30]
       int       3
M03_L71:
       mov       ecx,0E
       call      qword ptr [7FFE8BEF4F30]
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
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L73
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L73
       mov       r11,7FFE8BB30C58
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
; Total bytes of code 3783
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2357DA7C9E8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L16
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1F4EFC00438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1F4EFC00418
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
       mov       rdx,2357DA7C9E8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       r11,7FFE8BB30CB8
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1F4EFC00438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L12
       mov       rcx,1F4EFC00418
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
       mov       rdx,2357DA7C9E8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L17:
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L18:
       call      qword ptr [7FFE8BECEFB8]
       int       3
M05_L19:
       mov       rcx,rbx
       mov       rdx,7FFE8C6832A0
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
       mov       r11,7FFE8BB30CB8
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
       mov       rdx,7FFE8C6832A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L10
M05_L24:
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L11
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE8C6831C8
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
       call      qword ptr [7FFE8BEF4F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE8BEF4F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE8BB30CC0
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
       mov       r11,7FFE8BB30CC0
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
       lea       rcx,[7FFE8C60B110]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0C52F0]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE8BBB539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1F4EFC003D8
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
       call      qword ptr [7FFE8C0C52F0]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FFE8BD25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE8C436B38]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FFE8C436B08]
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BEF66E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BECEC88]
       int       3
M06_L10:
       mov       rcx,7FFE8BBB5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE8BECECD0]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C235338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M07_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L10
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        near ptr M07_L06
       test      r8b,18
       jne       near ptr M07_L07
       test      r8b,4
       jne       near ptr M07_L08
       test      r8,r8
       je        short M07_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L05
       jmp       near ptr M07_L09
M07_L00:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M07_L00
       and       r8,3F
       cmp       r8,10
       jbe       short M07_L02
M07_L01:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M07_L02
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M07_L03
M07_L02:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
       jmp       short M07_L05
M07_L03:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L02
M07_L04:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L05:
       pop       rbx
       pop       rsi
       ret
M07_L06:
       cmp       r8,40
       jbe       short M07_L01
       cmp       r8,800
       ja        short M07_L04
       mov       rax,r8
       shr       rax,6
       jmp       near ptr M07_L00
M07_L07:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M07_L05
M07_L08:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M07_L05
M07_L09:
       movsx     rcx,word ptr [rbx-2]
       mov       [rsi-2],cx
       jmp       short M07_L05
M07_L10:
       cmp       rcx,rdx
       je        short M07_L05
       jmp       short M07_L04
; Total bytes of code 275
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,2357DA60008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,208C5258D90
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
       call      qword ptr [7FFE8BBC6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,208C526AEF8
       xor       edx,edx
       call      qword ptr [7FFE8BBC6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE8BC761D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,208C5255F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE8C1449F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,208C5250008
       call      qword ptr [7FFE8C59D440]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC762F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE8C7A4B28]
       int       3
M00_L03:
       mov       rsi,208C5250008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE8C26D590]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE8C26D590]
       mov       ecx,7D3
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
; Total bytes of code 786
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
       call      qword ptr [7FFE8BBC6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF1CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       je        near ptr M02_L04
       test      rbx,rbx
       je        near ptr M02_L05
       test      rsi,rsi
       je        near ptr M02_L05
       cmp       edi,4
       jne       near ptr M02_L07
       mov       eax,[rbx+8]
       cmp       eax,[rsi+8]
       je        near ptr M02_L08
M02_L01:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C245338]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BC7F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L03:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       cmp       edi,5
       ja        short M02_L06
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L05:
       cmp       edi,5
       jbe       short M02_L01
M02_L06:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BECEC88]
       int       3
M02_L07:
       cmp       edi,5
       ja        short M02_L02
       mov       eax,edi
       lea       rcx,[7FFE8C65CDE8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0D50F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L03
       mov       rcx,7FFE8BBB5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C8374003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C0D50F8]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L03
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L03
       mov       ecx,[rbx+8]
       cmp       ecx,[rsi+8]
       jne       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8BC75F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
; Total bytes of code 404
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
       call      qword ptr [7FFE8BC7EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L51
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1C83340B210
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC7EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BC7EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C17E598]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE55740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       call      qword ptr [7FFE8C59D860]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBC66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L56
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L57
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF45908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L58
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,208C5250008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1C837401DA0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BF99318]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M03_L59
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M03_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M03_L61
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M03_L60
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M03_L61
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC743C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L54
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L53
       call      qword ptr [7FFE8BE050A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFE8BF1E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L21
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,208C526C138
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1449F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C59D920]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1C83340BEE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1C83340BED8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L14:
       mov       r14,1C83340BEE8
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L18
M03_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C59E478]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF1E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L17:
       test      eax,eax
       jne       near ptr M03_L12
       jmp       near ptr M03_L22
M03_L18:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1C83340BED8
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L15
M03_L19:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB30D20
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L13
M03_L20:
       mov       r11,7FFE8BB30D18
       call      qword ptr [r11]
       jmp       near ptr M03_L17
M03_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L23
       cmp       [rcx],rdi
       jne       near ptr M03_L55
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
       jne       near ptr M03_L62
       mov       r8,208C5264C60
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
       call      qword ptr [7FFE8BF46208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF46280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L43
M03_L25:
       mov       rdx,[rbp-160]
M03_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BF8C6A8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L38
M03_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L64
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L47
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
       call      qword ptr [7FFE8BF25F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       cmp       dword ptr [rdx+190],3
       jl        near ptr M03_L42
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M03_L41
       mov       r8,[rdx]
       add       r8,10
M03_L31:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M03_L32
       mov       r10,1C837400438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L32
       mov       r10,1C837400418
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
       je        near ptr M03_L48
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
       mov       rdx,208C526C160
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1449F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC74360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,1C83340BEF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L49
M03_L36:
       mov       rcx,1C83340BEF8
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
       call      qword ptr [7FFE8C59E478]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L38:
       add       esi,1
       jo        near ptr M03_L50
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
       jmp       near ptr M03_L63
M03_L42:
       jmp       near ptr M03_L63
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
       mov       rcx,1C83340BED8
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1C83340BEF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L37
M03_L47:
       xor       ecx,ecx
       jmp       near ptr M03_L28
M03_L48:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF451B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF45230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L49:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1C83340BED8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1C83340BEF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L50:
       call      CORINFO_HELP_OVERFLOW
M03_L51:
       call      qword ptr [7FFE8C26D590]
       mov       ecx,79D
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L52:
       call      qword ptr [7FFE8C26D590]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L53:
       mov       r11,7FFE8BB30D30
       call      qword ptr [r11]
       jmp       near ptr M03_L10
M03_L54:
       mov       rcx,rax
       mov       r11,7FFE8BB30D10
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L11
M03_L55:
       mov       r11,7FFE8BB30D28
       call      qword ptr [r11]
       jmp       near ptr M03_L23
M03_L56:
       mov       rcx,1C837401E00
       mov       r15,[rcx]
       jmp       near ptr M03_L07
M03_L57:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L58:
       call      qword ptr [7FFE8C26D590]
       mov       ecx,0F
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L59:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L60:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L61:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE55848]
       jmp       near ptr M03_L03
M03_L62:
       mov       rcx,rax
       mov       rdx,208C5264C60
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L26
M03_L63:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L31
M03_L64:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L29
M03_L65:
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE8C26D590]
       mov       ecx,0C65
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26D380]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C21CE58]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C21C840]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FFE8BEF4F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FFE8BEF4F30]
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
       call      qword ptr [7FFE8BC74348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FFE8BB30D28
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
; Total bytes of code 3794
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,208C526CBC8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L25
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L25
       mov       rax,[rcx]
       add       rax,10
M05_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1C837400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L04
       mov       rcx,1C837400418
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
       mov       rdx,208C526CBC8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rdx,7FFE8C5D30A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M05_L02
M05_L08:
       mov       rcx,rax
       mov       r11,7FFE8BB30F18
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
       mov       r11,7FFE8BB30F18
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
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       cmp       [rsi+18],rcx
       jne       near ptr M05_L22
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M05_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M05_L26
       mov       rax,[rcx]
       add       rax,10
M05_L14:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M05_L15
       mov       rcx,1C837400438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M05_L15
       mov       rcx,1C837400418
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
       mov       rdx,208C526CBC8
       call      qword ptr [7FFE8BC76C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
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
       mov       rdx,7FFE8C5D30A8
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
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFE8BECEFB8]
       int       3
M05_L24:
       call      qword ptr [7FFE8BE74030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M05_L04
M05_L25:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L03
M05_L26:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M05_L14
M05_L27:
       mov       rcx,rbx
       mov       rdx,7FFE8C5D2FD0
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
       call      qword ptr [7FFE8BEF4F30]
       int       3
M05_L31:
       mov       ecx,5
       call      qword ptr [7FFE8BEF4F30]
       int       3
M05_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE8BB30F20
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
       mov       r11,7FFE8BB30F20
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
       lea       rcx,[7FFE8C667D30]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M06_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE74180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0D5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M06_L07
       test      byte ptr [7FFE8BBB539F],1
       je        near ptr M06_L10
M06_L04:
       mov       rcx,1C8374003D8
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
       call      qword ptr [7FFE8C0D5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
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
       call      qword ptr [7FFE8BD25068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L07
       cmp       [rbx+8],ebp
       jl        short M06_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M06_L06
       call      qword ptr [7FFE8C446B38]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
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
       call      qword ptr [7FFE8C446B08]
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
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BEF66E8]
       int       3
M06_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BECEC88]
       int       3
M06_L10:
       mov       rcx,7FFE8BBB5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M06_L04
M06_L11:
       mov       ecx,27
       call      qword ptr [7FFE8BECECD0]
       int       3
M06_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C245338]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB24000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC7F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        short M07_L01
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M07_L01
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M07_L03
       test      r8b,18
       jne       near ptr M07_L09
       test      r8b,4
       jne       near ptr M07_L08
       test      r8,r8
       je        near ptr M07_L06
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L06
       jmp       near ptr M07_L10
M07_L00:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M07_L00
       and       r8,3F
       cmp       r8,10
       ja        short M07_L04
       jmp       short M07_L05
M07_L01:
       cmp       rcx,rdx
       je        short M07_L06
M07_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD25B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L03:
       cmp       r8,40
       ja        short M07_L07
M07_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M07_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M07_L05:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M07_L06:
       pop       rbx
       pop       rsi
       ret
M07_L07:
       cmp       r8,800
       ja        short M07_L02
       mov       rax,r8
       shr       rax,6
       jmp       near ptr M07_L00
M07_L08:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M07_L06
M07_L09:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M07_L06
M07_L10:
       movsx     rax,word ptr [rbx-2]
       mov       [rsi-2],ax
       jmp       short M07_L06
; Total bytes of code 263
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,208C5250008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+130]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1D9714D8D90
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
       call      qword ptr [7FFE8BBD6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,1D9714EAEF8
       xor       edx,edx
       call      qword ptr [7FFE8BBD6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE8BC861D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,1D9714D5F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      qword ptr [7FFE8C1552C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFE8C6C3E40
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,1D9714D0008
       call      qword ptr [7FFE8C6C7EB8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC862F8]; System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       je        near ptr M00_L06
       mov       rcx,[rdi+8]
       mov       edi,[rcx+8]
       xor       ecx,ecx
       mov       rdx,1D9714D4388
       call      qword ptr [7FFE8C114780]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       mov       ecx,edi
       mov       rdx,1D9714D4368
       call      qword ptr [7FFE8C114780]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r14
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE8C79EFA0]
       int       3
M00_L03:
       mov       rsi,1D9714D0008
       jmp       short M00_L01
M00_L04:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,7D3
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
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
       call      qword ptr [7FFE8BBD6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF2CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FFE8BEDEC88]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE8C5D58B0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0E5908]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE8BBC5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,198DF8003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C0E5908]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE8BC85F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C2569B8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BC8F750]
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
       call      qword ptr [7FFE8BC8EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L51
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,198DF80D208
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC8EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BC8EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C18EFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE65740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jle       near ptr M03_L40
       jmp       near ptr M03_L25
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE8C6CC3F0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBD66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L56
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF55908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L57
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,1D9714D0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,198DF801DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8BFFEA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L10:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC843C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L54
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L53
       call      qword ptr [7FFE8BE150A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L11:
       mov       rcx,rax
M03_L12:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L13:
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE8BF2E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1D9714EC138
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C6CC4B0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,198DF80DED8
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,198DF80DED0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6C8510
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L15:
       mov       r14,198DF80DEE0
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L20
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C6CD008]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L22
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF2E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L13
       jmp       short M03_L23
M03_L19:
       call      CORINFO_HELP_OVERFLOW
M03_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,198DF80DED0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6C8528
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L16
M03_L21:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB40C98
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L14
M03_L22:
       mov       r11,7FFE8BB40C90
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L24
       cmp       [rcx],rdi
       jne       near ptr M03_L55
M03_L24:
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
M03_L25:
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
       mov       r8,1D9714E4C60
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
       call      qword ptr [7FFE8BF56208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF56280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L44
M03_L26:
       mov       rdx,[rbp-160]
M03_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BFEE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L39
M03_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L63
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M03_L62
       mov       rcx,[rax+18]
M03_L29:
       test      rcx,rcx
       je        near ptr M03_L71
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE8BF35F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L30:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L31
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M03_L39
M03_L31:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],3
       jl        near ptr M03_L43
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M03_L42
       mov       r8,[rdx]
       add       r8,10
M03_L32:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M03_L33
       mov       r10,198DF800438
       mov       r10,[r10]
       test      r10,r10
       jne       short M03_L33
       mov       r10,198DF800418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M03_L65
M03_L33:
       mov       [rbp-130],r10
       mov       r8,[rbp-120]
       mov       r9,[rbp-110]
       cmp       [r8],r9
       jne       near ptr M03_L41
M03_L34:
       mov       [rbp-150],r8
       mov       r11,[r8+8]
       test      r11,r11
       je        near ptr M03_L48
M03_L35:
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
       mov       rdx,1D9714EC160
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1552C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L72
       test      rax,rax
       je        near ptr M03_L73
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC84360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M03_L36:
       mov       rcx,198DF80DEE8
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L49
M03_L37:
       mov       rcx,198DF80DEF0
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L47
       mov       rax,[rbp-138]
M03_L38:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C6CD008]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L39:
       add       esi,1
       jo        near ptr M03_L50
       cmp       esi,r15d
       jl        near ptr M03_L25
M03_L40:
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
M03_L41:
       jmp       near ptr M03_L66
M03_L42:
       jmp       near ptr M03_L64
M03_L43:
       jmp       near ptr M03_L64
M03_L44:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L45
       mov       r8,[rbp-98]
       jmp       short M03_L46
M03_L45:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L74
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L46:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L44
       jmp       near ptr M03_L26
M03_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,198DF80DED0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6C8558
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,198DF80DEF0
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L38
M03_L48:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF551B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF55230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M03_L35
M03_L49:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,198DF80DED0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6C8540
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,198DF80DEE8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L37
M03_L50:
       call      CORINFO_HELP_OVERFLOW
M03_L51:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L52:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L53:
       mov       r11,7FFE8BB40CA8
       call      qword ptr [r11]
       jmp       near ptr M03_L11
M03_L54:
       mov       rcx,rax
       mov       r11,7FFE8BB40C88
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L12
M03_L55:
       mov       r11,7FFE8BB40CA0
       call      qword ptr [r11]
       jmp       near ptr M03_L24
M03_L56:
       mov       rax,198DF801E00
       mov       r15,[rax]
       jmp       near ptr M03_L07
M03_L57:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF06670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L58:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L59:
       call      qword ptr [7FFE8BEDE9A0]
       int       3
M03_L60:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE65848]
       jmp       near ptr M03_L03
M03_L61:
       mov       rcx,rax
       mov       rdx,1D9714E4C60
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L27
M03_L62:
       xor       ecx,ecx
       jmp       near ptr M03_L29
M03_L63:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L30
M03_L64:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L65:
       call      qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jmp       near ptr M03_L35
M03_L67:
       mov       rax,[rbp-128]
       jmp       near ptr M03_L34
M03_L68:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L36
M03_L69:
       call      qword ptr [7FFE8C27E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C002E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C147AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC86B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C27E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L70:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L71:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C22DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L72:
       mov       ecx,4
       call      qword ptr [7FFE8BF04F30]
       int       3
M03_L73:
       mov       ecx,0E
       call      qword ptr [7FFE8BF04F30]
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
       call      qword ptr [7FFE8BC84348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L75
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L75
       mov       r11,7FFE8BB40CA0
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
; Total bytes of code 3790
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
       je        near ptr M04_L30
       test      rsi,rsi
       je        near ptr M04_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M04_L27
M04_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,7FFE8C6C3E40
       cmp       [rsi+18],rcx
       jne       near ptr M04_L14
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M04_L19
M04_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L16
       mov       rax,[rcx]
       add       rax,10
M04_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M04_L04
       mov       rcx,198DF800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M04_L04
       mov       rcx,198DF800418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M04_L17
M04_L04:
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
       mov       rdx,1D9714ECBC8
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M04_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M04_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M04_L18
M04_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M04_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M04_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M04_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L01
M04_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L08:
       mov       rcx,rax
       mov       r11,7FFE8BB40D18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M04_L01
       mov       rax,[rbp-78]
       jmp       near ptr M04_L28
M04_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M04_L23
M04_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,7FFE8C6C3E40
       cmp       [rsi+18],rcx
       jne       near ptr M04_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L26
       mov       rax,[rcx]
       add       rax,10
M04_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M04_L12
       mov       rcx,198DF800438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M04_L12
       mov       rcx,198DF800418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M04_L24
M04_L12:
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
       mov       rdx,1D9714ECBC8
       call      qword ptr [7FFE8BC86C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M04_L13:
       mov       rax,[rbp-78]
M04_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M04_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M04_L18
M04_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M04_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M04_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M04_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M04_L03
M04_L17:
       call      qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M04_L04
M04_L18:
       call      qword ptr [7FFE8BEDEFB8]
       int       3
M04_L19:
       mov       rcx,rbx
       mov       rdx,7FFE8C6ED658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L02
M04_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M04_L28
M04_L21:
       mov       rcx,rax
       mov       r11,7FFE8BB40D18
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M04_L28
       jmp       near ptr M04_L09
M04_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M04_L28
M04_L23:
       mov       rcx,rbx
       mov       rdx,7FFE8C6ED658
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L10
M04_L24:
       call      qword ptr [7FFE8BE84030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M04_L12
M04_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M04_L13
M04_L26:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M04_L11
M04_L27:
       mov       rcx,rbx
       mov       rdx,7FFE8C6ED580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L00
M04_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M04_L32
M04_L29:
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
M04_L30:
       mov       ecx,10
       call      qword ptr [7FFE8BF04F30]
       int       3
M04_L31:
       mov       ecx,5
       call      qword ptr [7FFE8BF04F30]
       int       3
M04_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE8BB40D20
       call      qword ptr [r11]
       jmp       short M04_L29
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
       je        short M04_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M04_L33
       mov       rcx,rax
       mov       r11,7FFE8BB40D20
       call      qword ptr [r11]
M04_L33:
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
M05_L00:
       test      rsi,rsi
       je        near ptr M05_L08
       cmp       rbx,rsi
       jne       short M05_L02
       cmp       edi,5
       ja        near ptr M05_L09
M05_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M05_L03
       cmp       edi,5
       ja        near ptr M05_L09
       jmp       short M05_L01
M05_L03:
       cmp       edi,5
       ja        near ptr M05_L12
       mov       eax,edi
       lea       rcx,[7FFE8C5F4D90]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M05_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
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
       call      qword ptr [7FFE8C0E5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M05_L07
       test      byte ptr [7FFE8BBC539F],1
       je        near ptr M05_L10
M05_L04:
       mov       rcx,198DF8003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
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
       call      qword ptr [7FFE8C0E5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M05_L05
       cmp       ebp,1
       je        near ptr M05_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD35068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M05_L06
       call      qword ptr [7FFE8C45E598]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M05_L07
M05_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      qword ptr [7FFE8C45E568]
M05_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L08:
       mov       ecx,2E5
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
       int       3
M05_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BEDEC88]
       int       3
M05_L10:
       mov       rcx,7FFE8BBC5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M05_L04
M05_L11:
       mov       ecx,27
       call      qword ptr [7FFE8BEDECD0]
       int       3
M05_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C2569B8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC8F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 576
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M06_L00
       add       rsp,28
       ret
M06_L00:
       call      qword ptr [7FFE8C51F3F0]
       int       3
; Total bytes of code 20
```
```assembly
; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       push      rsi
       push      rbx
       vzeroupper
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        short M07_L01
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        short M07_L01
       lea       rbx,[rdx+r8]
       lea       rsi,[rcx+r8]
       cmp       r8,10
       ja        short M07_L03
       test      r8b,18
       jne       near ptr M07_L08
       test      r8b,4
       jne       near ptr M07_L09
       test      r8,r8
       je        near ptr M07_L06
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M07_L06
       jmp       near ptr M07_L10
M07_L00:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       rax
       jne       short M07_L00
       and       r8,3F
       cmp       r8,10
       ja        short M07_L04
       jmp       short M07_L05
M07_L01:
       cmp       rcx,rdx
       je        short M07_L06
M07_L02:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFE8BD35B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M07_L03:
       cmp       r8,40
       ja        short M07_L07
M07_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M07_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M07_L05:
       vmovups   xmm0,[rbx-10]
       vmovups   [rsi-10],xmm0
M07_L06:
       pop       rbx
       pop       rsi
       ret
M07_L07:
       cmp       r8,800
       ja        short M07_L02
       mov       rax,r8
       shr       rax,6
       jmp       near ptr M07_L00
M07_L08:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rbx-8]
       mov       [rsi-8],rdx
       jmp       short M07_L06
M07_L09:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rbx-4]
       mov       [rsi-4],edx
       jmp       short M07_L06
M07_L10:
       movsx     rax,word ptr [rbx-2]
       mov       [rsi-2],ax
       jmp       short M07_L06
; Total bytes of code 263
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
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD35B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEDEF10]
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
       mov       rax,1D9714D0008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       mov       rsi,[rbx+120]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2AA68E58D90
       mov       [rdi+8],rcx
       mov       word ptr [rdi+10],3A
       mov       rdx,[rdi+8]
       test      rdx,rdx
       je        near ptr M00_L05
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFE8BBE6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbp,rax
       mov       rcx,2AA68E6AEF8
       xor       edx,edx
       call      qword ptr [7FFE8BBE6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbp
       mov       r8d,4
       call      qword ptr [7FFE8BC961D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rcx,2AA68E55F40
       test      eax,eax
       cmovne    rbp,rcx
       mov       rcx,rsi
       mov       rdx,rbp
       mov       r8d,1
       call      qword ptr [7FFE8C1652C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFE8C6F8888
       mov       [rbp+18],r9
       mov       r9,rbp
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       mov       r8,2AA68E50008
       call      qword ptr [7FFE8C6FC900]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[rdi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BC962F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    rdx,edi
       lea       rdx,[rsi+rdx*2+0C]
       mov       rcx,r14
       movsxd    r8,ebp
       call      qword ptr [7FFE8C52CAC8]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       mov       rsi,r15
M00_L01:
       mov       [rsp+20],rsi
       mov       rcx,[rbx+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C72CD38]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       ecx,1C7
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r14d
       call      qword ptr [7FFE8C79C930]
       int       3
M00_L03:
       mov       rsi,2AA68E50008
       jmp       short M00_L01
M00_L04:
       mov       rsi,2AA68E50008
       jmp       short M00_L01
M00_L05:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,7D3
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       jmp       near ptr M00_L01
M00_L07:
       jmp       near ptr M00_L01
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
       call      qword ptr [7FFE8BBE6658]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rcx,rax
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFE8BF3CFA8]; System.RuntimeType+RuntimeTypeCache.GetName(System.TypeNameKind)
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
       call      qword ptr [7FFE8BEEEC88]
       int       3
M02_L07:
       cmp       edi,5
       ja        near ptr M02_L09
       mov       eax,edi
       lea       rcx,[7FFE8C5B14B0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE94180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE8C0F5908]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
       mov       rcx,7FFE8BBD5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,269DB0003D8
       mov       rcx,[rcx]
       mov       r9d,edi
       and       r9d,1
       mov       rdx,rbx
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C0F5908]; System.Globalization.CompareInfo.Compare(System.String, System.String, System.Globalization.CompareOptions)
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       near ptr M02_L04
M02_L08:
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFE8BC95F80]; System.String.EqualsOrdinalIgnoreCaseNoLengthCheck(System.String, System.String)
M02_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE8C2669B8]
       mov       rbx,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE8BC9F750]
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
       call      qword ptr [7FFE8BC9EBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M03_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M03_L49
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,269D700B210
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE8BC9EE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFE8BC9EE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFE8C19EFB8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFE8BE75740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       jmp       near ptr M03_L25
M03_L06:
       mov       rcx,r15
       call      qword ptr [7FFE8C6FCD20]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M03_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFE8BBE66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M03_L53
       cmp       dword ptr [rbp-78],1
       je        near ptr M03_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFE8BF65908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M03_L07:
       test      r15,r15
       je        near ptr M03_L54
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
       mov       r12,2AA68E50008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M03_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,269DB001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFE8C00EA28]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M03_L03
M03_L09:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L07
M03_L10:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFE8BC943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M03_L51
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M03_L50
       call      qword ptr [7FFE8BE250A0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M03_L11:
       mov       rcx,rax
M03_L12:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M03_L17
M03_L13:
       cmp       r12,rdi
       jne       near ptr M03_L20
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FFE8BF3E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M03_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M03_L22
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8BE94180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2AA68E6C138
       call      qword ptr [7FFE8BC96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFE8C1652C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFE8C6FCDE0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,269D700BEE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M03_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,269D700BED8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6F8E40
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M03_L15:
       mov       r14,269D700BEE8
       mov       r9,[r14]
       test      r9,r9
       je        short M03_L19
M03_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C6FD938]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M03_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M03_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFE8BF3E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M03_L18:
       test      eax,eax
       jne       near ptr M03_L13
       jmp       near ptr M03_L23
M03_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,269D700BED8
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6F8E58
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M03_L16
M03_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFE8BB51060
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M03_L14
M03_L21:
       mov       r11,7FFE8BB51058
       call      qword ptr [r11]
       jmp       near ptr M03_L18
M03_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M03_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFE8BC94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L24
       cmp       [rcx],rdi
       jne       near ptr M03_L52
M03_L24:
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
M03_L25:
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
       mov       r8,2AA68E64C60
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
       call      qword ptr [7FFE8BF66208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFE8BF66280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M03_L42
M03_L26:
       mov       rdx,[rbp-160]
M03_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFE8BFFE478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M03_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M03_L38
M03_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M03_L60
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L59
M03_L29:
       test      rcx,rcx
       je        near ptr M03_L68
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFE8BF45F38]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M03_L30:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M03_L31
       test      rax,rax
       je        near ptr M03_L38
M03_L31:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M03_L41
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M03_L40
       mov       r10,[rcx]
       add       r10,10
M03_L32:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M03_L33
       mov       r9,269DB000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M03_L33
       mov       r9,269DB000418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M03_L62
M03_L33:
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
M03_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r12
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,2AA68E6C160
       call      qword ptr [7FFE8BC96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFE8C1652C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M03_L69
       test      rax,rax
       je        near ptr M03_L70
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFE8BC94360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M03_L35:
       mov       rcx,269D700BEF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M03_L46
M03_L36:
       mov       rcx,269D700BEF8
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M03_L45
       mov       rax,[rbp-138]
M03_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFE8C6FD938]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M03_L38:
       add       esi,1
       jo        near ptr M03_L47
       cmp       esi,r15d
       jl        near ptr M03_L25
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
       jmp       near ptr M03_L61
M03_L41:
       jmp       near ptr M03_L61
M03_L42:
       cmp       qword ptr [rbp-0A0],0
       jne       short M03_L43
       mov       r8,[rbp-98]
       jmp       short M03_L44
M03_L43:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M03_L71
       mov       rcx,[rbp-0A0]
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
M03_L44:
       mov       [rbp-0BC],eax
       movsxd    rdx,eax
       mov       rcx,[rbp-160]
       call      CORINFO_HELP_ARRADDR_ST
       mov       eax,[rbp-0BC]
       inc       eax
       cmp       eax,[rbp-90]
       jl        short M03_L42
       jmp       near ptr M03_L26
M03_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,269D700BED8
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6F8E88
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,269D700BEF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M03_L37
M03_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,269D700BED8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFE8C6F8E70
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,269D700BEF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M03_L36
M03_L47:
       call      CORINFO_HELP_OVERFLOW
M03_L48:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,79D
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFE8BF16670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M03_L49:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L50:
       mov       r11,7FFE8BB51070
       call      qword ptr [r11]
       jmp       near ptr M03_L11
M03_L51:
       mov       rcx,rax
       mov       r11,7FFE8BB51050
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M03_L12
M03_L52:
       mov       r11,7FFE8BB51068
       call      qword ptr [r11]
       jmp       near ptr M03_L24
M03_L53:
       mov       rax,269DB001E00
       mov       r15,[rax]
       jmp       near ptr M03_L07
M03_L54:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,0F
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFE8BF16670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M03_L55:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L56:
       call      qword ptr [7FFE8BEEE9A0]
       int       3
M03_L57:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFE8BE75848]
       jmp       near ptr M03_L03
M03_L58:
       mov       rcx,rax
       mov       rdx,2AA68E64C60
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M03_L27
M03_L59:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M03_L29
M03_L60:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M03_L30
M03_L61:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M03_L32
M03_L62:
       call      qword ptr [7FFE8BE94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M03_L33
M03_L63:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFE8BF651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFE8BF65230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L34
M03_L64:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M03_L34
M03_L65:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M03_L35
M03_L66:
       call      qword ptr [7FFE8C28E9D0]
       mov       ecx,0C65
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8C012E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C157AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC96B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C28E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BF16670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L67:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C23E208]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC9F750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L68:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C23DBF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC9F708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M03_L69:
       mov       ecx,4
       call      qword ptr [7FFE8BF14F30]
       int       3
M03_L70:
       mov       ecx,0E
       call      qword ptr [7FFE8BF14F30]
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
       call      qword ptr [7FFE8BC94348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M03_L72
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M03_L72
       mov       r11,7FFE8BB51068
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
; Total bytes of code 3774
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
       je        near ptr M04_L30
       test      rsi,rsi
       je        near ptr M04_L31
       mov       r14,r8
       mov       rcx,[rbx+10]
       mov       r11,[rcx+18]
       test      r11,r11
       je        near ptr M04_L27
M04_L00:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       [rbp-78],rax
       mov       rcx,7FFE8C6F8888
       cmp       [rsi+18],rcx
       jne       near ptr M04_L14
       jmp       near ptr M04_L05
M04_L01:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M04_L19
M04_L02:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L16
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L16
       mov       rax,[rcx]
       add       rax,10
M04_L03:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M04_L04
       mov       rcx,269DB000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M04_L04
       mov       rcx,269DB000418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M04_L17
M04_L04:
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
       mov       rdx,2AA68E6CA10
       call      qword ptr [7FFE8BC96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
       mov       rax,[rbp-78]
M04_L05:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M04_L08
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M04_L18
M04_L06:
       mov       r8d,[rdi+0C]
       mov       r15,[rdi]
       cmp       r8d,[r15+38]
       jae       near ptr M04_L20
       mov       r13,[r15+10]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       short M04_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M04_L06
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L01
M04_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L08:
       mov       rcx,rax
       mov       r11,7FFE8BB510C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M04_L01
       mov       rax,[rbp-78]
       jmp       near ptr M04_L28
M04_L09:
       mov       rcx,[rbx+10]
       mov       r11,[rcx+20]
       test      r11,r11
       je        near ptr M04_L23
M04_L10:
       lea       rdx,[rbp-50]
       mov       rcx,[rbp-78]
       call      qword ptr [r11]
       mov       rcx,7FFE8C6F8888
       cmp       [rsi+18],rcx
       jne       near ptr M04_L25
       mov       r12,[rsi+8]
       mov       r13,[rbp-50]
       mov       rdi,[rbp-48]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M04_L26
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M04_L26
       mov       rax,[rcx]
       add       rax,10
M04_L11:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M04_L12
       mov       rcx,269DB000438
       mov       r15,[rcx]
       test      r15,r15
       jne       short M04_L12
       mov       rcx,269DB000418
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M04_L24
M04_L12:
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
       mov       rdx,2AA68E6CA10
       call      qword ptr [7FFE8BC96C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       r14,rax
M04_L13:
       mov       rax,[rbp-78]
M04_L14:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       near ptr M04_L21
       lea       rdi,[rax+8]
       mov       ecx,[rdi+8]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+44]
       jne       near ptr M04_L18
M04_L15:
       mov       ecx,[rdi+0C]
       mov       rdx,[rdi]
       cmp       ecx,[rdx+38]
       jae       near ptr M04_L22
       mov       rcx,[rdi]
       mov       r13,[rcx+10]
       mov       r8d,[rdi+0C]
       lea       ecx,[r8+1]
       mov       [rdi+0C],ecx
       cmp       r8d,[r13+8]
       jae       near ptr M04_L07
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[r13+rcx*8+10]
       cmp       dword ptr [r12+14],0FFFFFFFF
       jl        short M04_L15
       mov       rdx,[r12]
       mov       r12,[r12+8]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L09
M04_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M04_L03
M04_L17:
       call      qword ptr [7FFE8BE94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M04_L04
M04_L18:
       call      qword ptr [7FFE8BEEEFB8]
       int       3
M04_L19:
       mov       rcx,rbx
       mov       rdx,7FFE8C70E588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L02
M04_L20:
       mov       rax,[rbp-78]
       mov       ecx,[r15+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       near ptr M04_L28
M04_L21:
       mov       rcx,rax
       mov       r11,7FFE8BB510C8
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-78]
       je        near ptr M04_L28
       jmp       near ptr M04_L09
M04_L22:
       mov       rax,[rbp-78]
       mov       rcx,[rdi]
       mov       ecx,[rcx+38]
       inc       ecx
       mov       [rdi+0C],ecx
       xor       ecx,ecx
       mov       [rdi+18],rcx
       mov       [rdi+20],rcx
       jmp       short M04_L28
M04_L23:
       mov       rcx,rbx
       mov       rdx,7FFE8C70E588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L10
M04_L24:
       call      qword ptr [7FFE8BE94030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r15,rax
       jmp       near ptr M04_L12
M04_L25:
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       r8,[rbp-70]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       r14,rax
       jmp       near ptr M04_L13
M04_L26:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M04_L11
M04_L27:
       mov       rcx,rbx
       mov       rdx,7FFE8C70E4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
       jmp       near ptr M04_L00
M04_L28:
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       cmp       [rax],rcx
       jne       short M04_L32
M04_L29:
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
M04_L30:
       mov       ecx,10
       call      qword ptr [7FFE8BF14F30]
       int       3
M04_L31:
       mov       ecx,5
       call      qword ptr [7FFE8BF14F30]
       int       3
M04_L32:
       mov       rax,[rbp-78]
       mov       rcx,rax
       mov       r11,7FFE8BB510D0
       call      qword ptr [r11]
       jmp       short M04_L29
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
       je        short M04_L33
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2+Enumerator[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       mov       rax,[rbp-78]
       cmp       [rax],rcx
       je        short M04_L33
       mov       rcx,rax
       mov       r11,7FFE8BB510D0
       call      qword ptr [r11]
M04_L33:
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
M05_L00:
       test      rsi,rsi
       je        near ptr M05_L08
       cmp       rbx,rsi
       jne       short M05_L02
       cmp       edi,5
       ja        near ptr M05_L09
M05_L01:
       mov       eax,1
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L02:
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jne       short M05_L03
       cmp       edi,5
       ja        near ptr M05_L09
       jmp       short M05_L01
M05_L03:
       cmp       edi,5
       ja        near ptr M05_L12
       mov       eax,edi
       lea       rcx,[7FFE8C5EAAD0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M05_L00]
       add       rcx,rdx
       jmp       rcx
       call      qword ptr [7FFE8BE94180]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
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
       call      qword ptr [7FFE8C0F5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       near ptr M05_L07
       test      byte ptr [7FFE8BBD539F],1
       je        near ptr M05_L10
M05_L04:
       mov       rcx,269DB0003D8
       mov       rcx,[rcx]
       cmp       [rcx],cl
       test      rbx,rbx
       je        near ptr M05_L11
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
       call      qword ptr [7FFE8C0F5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       movzx     r8d,word ptr [rbx+0C]
       cmp       r8w,[rsi+0C]
       jne       short M05_L05
       cmp       ebp,1
       je        near ptr M05_L01
       lea       rcx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFE8BD45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L07
       cmp       [rbx+8],ebp
       jl        short M05_L05
       lea       rcx,[rbx+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,ebp
       cmp       r8d,8
       jge       short M05_L06
       call      qword ptr [7FFE8C46C528]; System.Globalization.Ordinal.EqualsIgnoreCase_Scalar(Char ByRef, Char ByRef, Int32)
       jmp       short M05_L07
M05_L05:
       xor       eax,eax
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L06:
       call      qword ptr [7FFE8C46C4F8]
M05_L07:
       movzx     eax,al
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L08:
       mov       ecx,2E5
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF166E8]
       int       3
M05_L09:
       mov       ecx,1B
       mov       edx,29
       call      qword ptr [7FFE8BEEEC88]
       int       3
M05_L10:
       mov       rcx,7FFE8BBD5120
       mov       edx,24F
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       jmp       near ptr M05_L04
M05_L11:
       mov       ecx,27
       call      qword ptr [7FFE8BEEECD0]
       int       3
M05_L12:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C2669B8]
       mov       rsi,rax
       mov       ecx,16F3
       mov       rdx,7FFE8BB44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFE8BC9F750]
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
       jb        near ptr M06_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M06_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        near ptr M06_L03
       test      r8b,18
       je        short M06_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M06_L06
M06_L00:
       test      r8b,4
       jne       near ptr M06_L07
       test      r8,r8
       je        near ptr M06_L06
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M06_L06
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M06_L06
M06_L01:
       cmp       r8,800
       ja        near ptr M06_L10
       mov       r9,r8
       shr       r9,6
M06_L02:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M06_L02
       and       r8,3F
       cmp       r8,10
       ja        short M06_L04
       jmp       short M06_L05
M06_L03:
       cmp       r8,40
       ja        short M06_L01
M06_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M06_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M06_L08
M06_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M06_L06:
       ret
M06_L07:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M06_L06
M06_L08:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M06_L05
M06_L09:
       cmp       rcx,rdx
       je        short M06_L06
M06_L10:
       jmp       qword ptr [7FFE8BD45B90]; System.Buffer._Memmove(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 267
```
```assembly
; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       sub       rsp,28
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BEEEF10]
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
       mov       rax,2AA68E50008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       call      qword ptr [7FFE8C2663B8]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8C145320]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
       mov       rcx,[rax+10]
       mov       [rsp+20],rcx
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
; Total bytes of code 81
```
```assembly
; System.Text.Json.JsonSerializerOptions.get_Default()
       sub       rsp,28
       mov       rax,1EB5CC0E8B8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFE8C266958]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       jmp       short M01_L00
; Total bytes of code 35
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
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
       je        near ptr M02_L08
       mov       [rbp-28],rcx
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M02_L00
       mov       rcx,1EB5CC0E8B8
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M02_L06
M02_L00:
       cmp       byte ptr [rbx+8D],0
       jne       short M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFE8C2668B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFE8C44FF00]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,1EB5CC01F80
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFE8C6B5E90]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       jmp       short M02_L07
M02_L04:
       call      qword ptr [7FFE8BC743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L05:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,22BEE902D10
       mov       r8d,1
       call      qword ptr [7FFE8C266298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L06:
       call      qword ptr [7FFE8C266958]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
       mov       rbx,rax
       jmp       near ptr M02_L00
M02_L07:
       mov       rax,[rbp-38]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       call      qword ptr [7FFE8C26E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
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
       call      qword ptr [7FFE8C6B5110]
       mov       [rbp-38],rax
       lea       rax,[M02_L07]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 641
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       test      rcx,rcx
       je        near ptr M00_L03
       mov       [rsp+30],rcx
       mov       rcx,203EA80DDC0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C2668B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C2662F8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C476340]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFE8BC743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE8C26E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2E40
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 319
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF3ED15068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF3ED19F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF3ED169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF3ED15060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF3ED16948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF3ED19FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF3ED19198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF3ED14820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF3ED16A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF3ED184A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,2447C652D10
       mov       r8d,1
       call      qword ptr [7FFE8C266298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE8C476370]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE8C305488]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M03_L04
       cmp       [rcx+8],ebx
       jb        short M03_L03
M03_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M03_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M03_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M03_L01:
       cmp       ebx,edi
       ja        short M03_L03
       mov       edi,ebx
M03_L02:
       mov       rcx,rsi
       jmp       short M03_L06
M03_L03:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L04:
       test      ebx,ebx
       jne       short M03_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M03_L00
M03_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M03_L01
M03_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE8C2C4660]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L09
M03_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L10
M03_L09:
       mov       rax,[rcx]
       add       rax,10
M03_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M03_L11
       test      edi,edi
       jne       short M03_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M03_L14
M03_L11:
       cmp       [rcx+8],edi
       jae       short M03_L13
M03_L12:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L13:
       add       rcx,10
M03_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M03_L16
       cmp       rdx,300
       ja        short M03_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L16
M03_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE8BD25BA8]
M03_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,203EA801E78
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C2BBBD0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       jne       short M04_L03
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       jmp       qword ptr [7FFE8BC743A8]
M04_L03:
       test      r8,r8
       je        short M04_L02
       mov       r8,[r8+10]
       cmp       r8,rcx
       je        short M04_L01
       test      r8,r8
       jne       short M04_L00
       jmp       short M04_L02
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,2447C650008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       test      rcx,rcx
       je        near ptr M00_L03
       mov       [rsp+30],rcx
       mov       rcx,1643800DDC0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE8C2668B0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE8C2662F8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFE8C44FF00]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFE8BC743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE8C26E9D0]
       mov       ecx,78B
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,100A
       mov       rdx,7FFE8BFF2F68
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE8C137AF0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BC76B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C26E7C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE8BEF6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 319
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FFF3ED15068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M01_L03
       call      qword ptr [7FFF3ED19F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
M01_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFF3ED169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M01_L00
       call      qword ptr [7FFF3ED15060]
       cmp       byte ptr [rax+18E],0
       je        short M01_L00
       mov       ecx,2
       call      qword ptr [7FFF3ED16948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF3ED19FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFF3ED14FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L00
       cmp       [rsi+10],rbx
       je        short M01_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M01_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FFF3ED19198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M01_L00
M01_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFF3ED14820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M01_L04
       call      qword ptr [7FFF3ED16A08]
       test      rax,rax
       je        near ptr M01_L00
M01_L04:
       call      qword ptr [7FFF3ED184A0]
       int       3
; Total bytes of code 272
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
       mov       rdx,1A4CA032D10
       mov       r8d,1
       call      qword ptr [7FFE8C266298]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp-60],rsp
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,[rbx+0B0]
       lea       rdx,[rbp-20]
       call      qword ptr [7FFE8C44FF30]; System.Text.Json.Utf8JsonWriterCache.RentWriterAndBuffer(System.Text.Json.JsonSerializerOptions, System.Text.Json.PooledByteBufferWriter ByRef)
       mov       rdx,rax
       mov       [rbp-50],rdx
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFE8C305488]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
       mov       rdx,[rbp-20]
       mov       rcx,[rdx+8]
       mov       ebx,[rdx+10]
       test      rcx,rcx
       je        short M03_L04
       cmp       [rcx+8],ebx
       jb        short M03_L03
M03_L00:
       xor       esi,esi
       xor       edi,edi
       test      rcx,rcx
       je        short M03_L02
       mov       rdx,[rcx]
       test      dword ptr [rdx],80000000
       je        short M03_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M03_L01:
       cmp       ebx,edi
       ja        short M03_L03
       mov       edi,ebx
M03_L02:
       mov       rcx,rsi
       jmp       short M03_L06
M03_L03:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L04:
       test      ebx,ebx
       jne       short M03_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M03_L00
M03_L05:
       lea       rdx,[rbp-30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,[rbp-30]
       mov       edi,[rbp-28]
       jmp       short M03_L01
M03_L06:
       mov       [rbp-48],rcx
       mov       [rbp-40],edi
       lea       rcx,[rbp-48]
       call      qword ptr [7FFE8C2C4660]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
       mov       [rbp-58],rax
       mov       rcx,rsp
       call      M03_L07
       nop
       mov       rax,[rbp-58]
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L07:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-20]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        short M03_L08
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       jne       short M03_L09
M03_L08:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       short M03_L10
M03_L09:
       mov       rax,[rcx]
       add       rax,10
M03_L10:
       mov       rsi,[rax]
       xor       ecx,ecx
       mov       rdx,[rbp-50]
       mov       [rdx+2C],ecx
       mov       [rdx+20],rcx
       mov       [rdx+38],rcx
       mov       [rdx+40],rcx
       mov       byte ptr [rdx+30],0
       mov       byte ptr [rdx+32],0
       mov       byte ptr [rdx+31],0
       mov       [rdx+28],ecx
       mov       [rdx+48],rcx
       mov       [rdx+50],rcx
       mov       [rdx+58],rcx
       mov       [rdx+10],rcx
       mov       [rdx+18],rcx
       mov       [rdx+8],rcx
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       test      rcx,rcx
       jne       short M03_L11
       test      edi,edi
       jne       short M03_L12
       xor       ecx,ecx
       xor       edi,edi
       jmp       short M03_L14
M03_L11:
       cmp       [rcx+8],edi
       jae       short M03_L13
M03_L12:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M03_L13:
       add       rcx,10
M03_L14:
       mov       edx,edi
       mov       [rbp-38],rdx
       test      rdx,rdx
       je        short M03_L16
       cmp       rdx,300
       ja        short M03_L15
       xor       edx,edx
       mov       r8d,[rbp-38]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L16
M03_L15:
       mov       rdx,[rbp-38]
       call      qword ptr [7FFE8BD25BA8]
M03_L16:
       xor       ecx,ecx
       mov       [rbx+10],ecx
       mov       rdx,[rbx+8]
       mov       [rbx+8],rcx
       mov       rcx,16438001E78
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE8C2BBBD0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
       dec       dword ptr [rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 512
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
       jmp       qword ptr [7FFE8BC743A8]
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
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE8BD25B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE8BECEF10]
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
       mov       rax,1A4CA030008
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C70E040]; System.Data.DataTable..ctor()
       mov       rcx,2C31E93C0D0
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE8C175368]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,2C31E920008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,2C31E93C170
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,2C31E93C248
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,28290C01F90
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28290C01F98
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28290C01FA0
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
       mov       rcx,7FFE8BBE5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFE8C731B78
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFE8BF4C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,2828CC06B50
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
       mov       rdx,2C31E93C0F0
       call      qword ptr [7FFE8BCA6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE8BD576D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C7565E0]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE8BEA4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C7549A8]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,28290C01E80
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
       call      qword ptr [7FFE8C755728]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,28290C01FB8
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
       call      qword ptr [7FFE8BCA4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE8C733870]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L04
M02_L00:
       call      qword ptr [7FFE8C17EAD8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L01
       call      qword ptr [7FFE8C29E928]
       mov       rbx,rax
M02_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8BF26718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFE8BB60D28
       call      qword ptr [r11]
       jmp       short M02_L04
M02_L03:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFE8BB60D30
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE8C75D980]
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

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE8BC77318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.String)
       call      qword ptr [7FFE8C6DDA40]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE8C26EA60]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FFE8C26E7C0]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28DA732C0D0
       mov       r8,rbx
       call      qword ptr [7FFE8BEF6670]
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
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE8C53C4E0]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFEE9E52C20
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE8C53C4E0]
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
       call      qword ptr [7FFE8BC773F0]
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
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rbx
       mov       rdx,7FFE8C6E3268
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       r8,24D15402678
       mov       r8,[r8]
       mov       rdx,rsi
       call      qword ptr [7FFE8C6DDAA0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        short M02_L02
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M02_L02:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE8BE556B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+38]
       cmp       ecx,[rsp+48]
       ja        near ptr M02_L05
       mov       rdx,[rsp+40]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+48]
       sub       eax,ecx
       cmp       eax,29
       jb        short M02_L03
       mov       rcx,28DA732C374
       vmovdqu   ymm0,ymmword ptr [rcx]
       vmovdqu   ymm1,ymmword ptr [rcx+20]
       vmovdqu   ymm2,ymmword ptr [rcx+32]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymmword ptr [rdx+20],ymm1
       vmovdqu   ymmword ptr [rdx+32],ymm2
       mov       ecx,[rsp+38]
       add       ecx,29
       mov       [rsp+38],ecx
       jmp       short M02_L04
M02_L03:
       lea       rcx,[rsp+28]
       mov       rdx,28DA732C368
       call      qword ptr [7FFE8BE558F0]
M02_L04:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,offset MD_System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Type, System.Private.CoreLib]](System.Type)
       call      qword ptr [7FFE8C0A4210]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M02_L06
M02_L05:
       call      qword ptr [7FFE8BECE9A0]
       int       3
M02_L06:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M02_L07
       mov       rdx,28DA7310C54
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M02_L08
M02_L07:
       lea       rcx,[rsp+28]
       mov       rdx,28DA7310C48
       call      qword ptr [7FFE8BE558F0]
M02_L08:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE8BE55740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BEF6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 417
```

## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.InitializeFields()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,80
       vzeroupper
       lea       rbp,[rsp+0B0]
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
       call      qword ptr [7FFE8C6EC1C8]; System.Data.DataSet..ctor()
       mov       rcx,1EEF00116F0
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
       mov       r8,22F81E1C0D0
       mov       [rbp-38],r8
       lea       r8,[rbp-40]
       mov       [rbp-70],r8
       mov       dword ptr [rbp-68],2
       lea       r8,[rbp-70]
       xor       ecx,ecx
       mov       rdx,22F81E1C268
       call      qword ptr [7FFE8BC86C88]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFE8BD376D8]
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
       je        near ptr M00_L29
       mov       rcx,r14
       mov       rdx,22F81E1C0D0
       call      qword ptr [7FFE8C6EDA40]; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
       cmp       eax,0FFFFFFFE
       je        near ptr M00_L30
       test      eax,eax
       jge       near ptr M00_L31
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       jne       near ptr M00_L32
M00_L03:
       mov       rcx,offset MT_System.ComponentModel.PropertyChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,22F81E1C238
       mov       [rax+8],rcx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L33
M00_L04:
       mov       rcx,22F81E1C0D0
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
       cmp       qword ptr [rax+10],0
       je        near ptr M00_L25
       mov       rcx,[rax+10]
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L06:
       cmp       [r14],r14b
       lea       r15,[r14+48]
       mov       rsi,[r15]
       test      rsi,rsi
       je        near ptr M00_L24
M00_L07:
       mov       rcx,rsi
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L26
       mov       rsi,[rcx+8]
M00_L08:
       mov       edi,[rsi+8]
       mov       ecx,edi
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],ecx
       xor       r14d,r14d
       test      edi,edi
       jle       short M00_L11
M00_L09:
       mov       ecx,r14d
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,36
       cmp       edx,ecx
       jne       short M00_L10
       lea       rcx,[rbp-58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE8BF54BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L10:
       inc       r14d
       cmp       edi,r14d
       jg        short M00_L09
M00_L11:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r14d,[rbp-48]
       test      r14d,r14d
       je        near ptr M00_L19
       cmp       r14d,1
       je        near ptr M00_L21
       test      r14d,r14d
       jl        short M00_L15
       mov       r15,rsi
       test      r15,r15
       je        short M00_L16
       cmp       [rsi+8],r14d
       jne       near ptr M00_L20
M00_L12:
       mov       r15,rsi
M00_L13:
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L27
M00_L14:
       mov       ecx,edi
       mov       r14,[r15+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       short M00_L17
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FFE8BFA4770]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       jmp       near ptr M00_L22
M00_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE8BEDED18]
       int       3
M00_L16:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       short M00_L12
M00_L17:
       mov       rcx,r14
       mov       rdx,r13
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       near ptr M00_L22
M00_L18:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       near ptr M00_L23
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FFE8BF06028]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       rsi,rax
       call      qword ptr [7FFE8BBD5FC8]; System.Type.get_DefaultBinder()
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+20],rax
       mov       rdx,r13
       mov       r8,rsi
       mov       rcx,r14
       xor       r9d,r9d
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+8]
       jmp       near ptr M00_L23
M00_L19:
       mov       rcx,1EEF0001F50
       mov       r15,[rcx]
       jmp       near ptr M00_L13
M00_L20:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rdx,[rsi+10]
       lea       r8,[r15+10]
       mov       r9d,[r15+8]
       cmp       r14d,r9d
       cmovg     r14d,r9d
       mov       r9d,r14d
       mov       rcx,offset MD_System.Buffer.Memmove[[System.Reflection.FieldInfo, System.Private.CoreLib]](System.Reflection.FieldInfo ByRef, System.Reflection.FieldInfo ByRef, UIntPtr)
       call      qword ptr [7FFE8BF55938]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       jmp       near ptr M00_L12
M00_L21:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L13
M00_L22:
       test      rax,rax
       je        near ptr M00_L18
M00_L23:
       inc       edi
       cmp       [r15+8],edi
       jg        near ptr M00_L14
       jmp       short M00_L27
M00_L24:
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
       jmp       near ptr M00_L07
M00_L25:
       mov       rcx,rax
       call      qword ptr [7FFE8BBD6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L26:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE8BF54E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L27:
       mov       rcx,[rbp-78]
       mov       [rbp-60],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rbp-60]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields, DotNetTips.Spargine.Extensions.BenchmarkTests]](DotNetTips.Spargine.Extensions.BenchmarkTests.DisposableFields ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C744000]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L28
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C7046F0]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L28:
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,80
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L29:
       mov       ecx,0C0E8
       mov       rdx,7FFE8C7008D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C7458D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L30:
       mov       ecx,69
       mov       rdx,7FFE8C001288
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C745998]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L31:
       mov       rcx,[r14+10]
       mov       edx,eax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      qword ptr [7FFE8BC843D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L32:
       cmp       byte ptr [r15+1C4],0
       jne       near ptr M00_L03
       mov       ecx,69
       mov       rdx,7FFE8C001288
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8C746820]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L33:
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
       sub       rsp,40
       vzeroupper
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0B0]
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L34
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE8C7046F0]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L34:
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1462
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
       mov       rcx,22F81E1C0F0
       mov       [rbx+38],rcx
       lea       rcx,[rbx+40]
       mov       rsi,22F81E00008
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
       mov       rcx,7FFE8C7029FC
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,rbx
       call      qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1EEF00116F0
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
       mov       rdx,22F81E1C120
       call      qword ptr [7FFE8BC86C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE8BD376D8]
M01_L00:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C6ED6E0]; System.Data.DataTableCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE8C6ED5F0]; System.Data.DataRelationCollection+DataSetRelationCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE8BE84180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       je        short M02_L00
       cmp       dword ptr [rbx+8],0
       jle       short M02_L00
       mov       rcx,[rsi+10]
       mov       rax,offset MT_System.Collections.ArrayList
       cmp       [rcx],rax
       jne       short M02_L01
       mov       r14d,[rcx+10]
       xor       r15d,r15d
       test      r14d,r14d
       jg        short M02_L02
M02_L00:
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
M02_L01:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r14d,eax
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M02_L00
M02_L02:
       mov       rcx,[rsi+10]
       mov       edx,r15d
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      qword ptr [7FFE8BC843D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       r9,[rsi+8]
       mov       r9,[r9+50]
       mov       rcx,[r13+70]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE8C6ED230]
       mov       r12d,eax
       cmp       r12d,1
       jne       short M02_L03
       mov       rcx,r13
       call      qword ptr [7FFE8C6EE9E8]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE8BC861C0]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M02_L03
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
M02_L03:
       cmp       r12d,0FFFFFFFF
       jne       short M02_L05
       mov       rcx,r13
       call      qword ptr [7FFE8C6EE9E8]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE8BC861C0]; System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M02_L05
       cmp       ebp,0FFFFFFFF
       je        short M02_L04
       mov       ebp,0FFFFFFFE
       jmp       short M02_L05
M02_L04:
       mov       ebp,r15d
M02_L05:
       inc       r15d
       cmp       r15d,r14d
       jl        near ptr M02_L02
       jmp       near ptr M02_L00
; Total bytes of code 292
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
       jne       short M03_L01
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M03_L00:
       inc       dword ptr [rbx+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L01:
       cmp       edi,1
       jne       near ptr M03_L07
       cmp       dword ptr [rbx+14],2
       jl        short M03_L03
M03_L02:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],30
       jle       short M03_L04
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M03_L04
       mov       [rsp+20],rdx
       jmp       short M03_L05
M03_L03:
       mov       dword ptr [rbx+14],4
       jmp       short M03_L02
M03_L04:
       mov       rdx,7FFE8C5545E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M03_L05:
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
M03_L06:
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M03_L00
M03_L07:
       cmp       [rbx+14],edi
       jne       short M03_L06
       mov       edi,[rbx+14]
       add       edi,edi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M03_L08
       mov       rcx,rax
       jmp       short M03_L09
M03_L08:
       mov       rdx,7FFE8C554540
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M03_L09:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FFE8BF55908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],edi
       jmp       short M03_L06
; Total bytes of code 250
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
       je        near ptr M04_L08
       mov       eax,[rbx+38]
M04_L00:
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M04_L13
       mov       rdi,[rbx+10]
M04_L01:
       test      rdi,rdi
       je        short M04_L02
       mov       rcx,offset MT_System.RuntimeType
       xor       edx,edx
       cmp       [rdi],rcx
       cmovne    rdi,rdx
M04_L02:
       test      al,2
       jne       near ptr M04_L12
       test      byte ptr [rbx+1C],10
       jne       short M04_L03
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M04_L15
M04_L03:
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M04_L09
M04_L04:
       mov       rbp,rdx
       test      rbp,rbp
       je        short M04_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M04_L17
M04_L05:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       test      rdi,rdi
       je        near ptr M04_L18
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M04_L10
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L10
M04_L06:
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
       je        short M04_L11
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L11
M04_L07:
       mov       [rax+95],bl
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF971F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M04_L00
M04_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE8BF973C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M04_L04
M04_L10:
       mov       rcx,rdi
       call      qword ptr [7FFE8BBD6658]; System.RuntimeType.InitializeCache()
       jmp       short M04_L06
M04_L11:
       mov       rcx,rdi
       call      qword ptr [7FFE8BBD6658]; System.RuntimeType.InitializeCache()
       jmp       short M04_L07
M04_L12:
       test      rdi,rdi
       je        short M04_L14
       mov       rcx,rbx
       call      qword ptr [7FFE8BF6D7D0]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M04_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE8C22D500]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE8BF06718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M04_L13:
       xor       edi,edi
       jmp       near ptr M04_L01
M04_L14:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8C1168F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L15:
       test      rsi,rsi
       jne       short M04_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE8C255998]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE8BF5DB60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M04_L16:
       call      qword ptr [7FFE8C22C768]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE8BFA4720]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FFE8C22C078]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE8BC8F708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M04_L17:
       call      qword ptr [7FFE8BC843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M04_L18:
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
; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       mov       esi,r8d
       test      rcx,rcx
       je        short M05_L02
       mov       r11,[7FFEEA8CAFF0]
       cmp       r11,[rcx]
       jne       short M05_L00
       jmp       short M05_L01
M05_L00:
       lea       r11,[7FFEEA8A0140]
       call      qword ptr [r11]
       mov       rcx,rax
M05_L01:
       call      qword ptr [7FFEEA8ADEE0]
       test      rax,rax
       je        short M05_L03
       xor       edx,edx
       test      bl,bl
       sete      dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[7FFEEA8B1FB0]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M05_L02:
       mov       rcx,[7FFEEA8CF988]
       mov       rcx,[rcx]
       call      qword ptr [7FFEEA8B2908]
       int       3
M05_L03:
       call      qword ptr [7FFEEA8AAF80]
       mov       rbx,rax
       call      qword ptr [7FFEEA8B4288]
       mov       rdx,rax
       mov       r8,[7FFEEA8CF988]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFEEA8B28B8]
       mov       rcx,rbx
       call      qword ptr [7FFEEA8A2D08]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 148
```
```assembly
; System.Type.get_DefaultBinder()
       push      rbx
       sub       rsp,20
       mov       rbx,1EEF0000108
       cmp       qword ptr [rbx],0
       je        short M06_L01
M06_L00:
       mov       rcx,7FFE8C5AF944
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbx]
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       mov       rcx,7FFE8C5AF940
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.DefaultBinder
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,1EEF0000108
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       jmp       short M06_L00
; Total bytes of code 98
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
       mov       rcx,7FFE8C571E5C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       r8,[rdi*8]
       cmp       r8,4000
       ja        short M07_L00
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M07_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFE8BD35BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 85
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
       je        near ptr M08_L07
M08_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M08_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M08_L14
M08_L01:
       test      rdi,rdi
       jne       near ptr M08_L06
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
       jne       near ptr M08_L04
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
       lea       rax,[M08_L02]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEEB760B00
       call      rax
M08_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEEBB41FDC],0
       je        short M08_L03
       call      qword ptr [7FFEEBB32398]; CORINFO_HELP_STOP_FOR_GC
M08_L03:
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
M08_L04:
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
       je        short M08_L05
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rax],rcx
       jne       near ptr M08_L15
M08_L05:
       test      rax,rax
       cmovne    rdi,rax
M08_L06:
       mov       rax,rdi
       jmp       near ptr M08_L12
M08_L07:
       mov       [rbp+10],rbx
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE8BC85440]; System.RuntimeTypeHandle.GetNativeHandle()
       mov       [rbp-48],rax
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-48]
       test      rdx,rdx
       je        near ptr M08_L11
       mov       rax,[rdx+18]
M08_L08:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       lea       rcx,[rbp-68]
       mov       edx,1
       mov       rax,offset MD_System.RuntimeTypeHandle.GetGCHandle(System.Runtime.CompilerServices.QCallTypeHandle, System.Runtime.InteropServices.GCHandleType)
       mov       [rbp-0B8],rax
       lea       rax,[M08_L09]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFEEB7D74B0
       call      rax
M08_L09:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFEEBB41FDC],0
       je        short M08_L10
       call      qword ptr [7FFEEBB32398]; CORINFO_HELP_STOP_FOR_GC
M08_L10:
       mov       rcx,[rbp-0C0]
       mov       [rsi+10],rcx
       mov       rdx,rax
       mov       rbx,[rbp+10]
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       jne       short M08_L13
       jmp       near ptr M08_L00
M08_L11:
       xor       eax,eax
       jmp       near ptr M08_L08
M08_L12:
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
M08_L13:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE8BC85998]
       jmp       near ptr M08_L00
M08_L14:
       call      qword ptr [7FFE8BC843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M08_L15:
       call      qword ptr [7FFE8BC843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rax,0B6CE91E5DFF5
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M09_L00
       cmp       dword ptr [rbx+8],0
       jne       short M09_L03
M09_L00:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE8BF54EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M09_L01:
       lea       rdx,[rbp+20]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE8BF54EB8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+20]
       mov       rcx,0B6CE91E5DFF5
       cmp       [rbp+8],rcx
       je        short M09_L02
       call      CORINFO_HELP_FAIL_FAST
M09_L02:
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
M09_L03:
       cmp       r14d,1
       je        near ptr M09_L08
M09_L04:
       mov       r15d,[rbx+8]
       lea       rcx,[rbx+0C]
       mov       [rbp+18],rcx
       mov       r13,[rbp+18]
       mov       rcx,1EEF00009F0
       mov       rcx,[rcx]
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE8BEC89E0]; Precode of System.Text.UTF8Encoding.GetByteCount(Char*, Int32)
       mov       r12d,eax
       cmp       r12d,400
       jg        near ptr M09_L09
       mov       ecx,r12d
       mov       r9,rcx
       test      r9,r9
       je        short M09_L06
       mov       rdx,r9
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,40
       neg       rdx
       add       rdx,rsp
       jb        short M09_L05
       xor       edx,edx
M09_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M09_L05
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,40
       lea       r9,[rsp+40]
M09_L06:
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE8BF54EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M09_L07:
       xor       edx,edx
       mov       [rbp+18],rdx
       jmp       near ptr M09_L01
M09_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M09_L04
       cmp       word ptr [rbx+0C],2A
       je        near ptr M09_L04
       jmp       near ptr M09_L00
M09_L09:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       dword ptr [rax+8],0
       jbe       short M09_L10
       add       rax,10
       mov       [rbp+10],rax
       mov       rdx,r13
       mov       r8d,r15d
       mov       r9,[rbp+10]
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       call      qword ptr [7FFE8BF54EA0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
       xor       eax,eax
       mov       [rbp+10],rax
       jmp       short M09_L07
M09_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 458
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
       jmp       qword ptr [7FFE8BF2C2E8]; System.GC.SuppressFinalize(System.Object)
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
       mov       rdx,7FFE8BB34000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE8BF066E8]
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
       jmp       qword ptr [7FFE8BC843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.Object.GetType()
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

