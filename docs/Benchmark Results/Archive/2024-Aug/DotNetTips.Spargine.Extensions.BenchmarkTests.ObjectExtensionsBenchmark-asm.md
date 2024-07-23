## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rdx,[rbx+120]
       test      rdx,rdx
       je        short M00_L00
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF80BEC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
M00_L00:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,2F25DAA2730
       mov       rdx,2F25DAA0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2F25DAA0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L01
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L02
M00_L01:
       mov       ecx,1
M00_L02:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L03
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 371
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
       jmp       qword ptr [7FF80BEC43A8]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0FEF10]
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
       mov       rax,2F25DAA0008
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
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M03_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M03_L00
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FF80C697AF8]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FF80C697AF8]
       test      eax,eax
       jne       short M03_L04
M03_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonArray()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rsi,[rbx+128]
       test      rsi,rsi
       je        near ptr M00_L10
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80C7F5848]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L12
M00_L00:
       call      qword ptr [7FF80C365308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L01
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L02
       jmp       short M00_L02
M00_L01:
       xor       edx,edx
M00_L02:
       test      edx,edx
       je        near ptr M00_L16
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,20D83C0B198
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L17
       cmp       byte ptr [rdi+8D],0
       je        near ptr M00_L07
M00_L03:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L08
       mov       rdx,[rbp+0B8]
       mov       r8,24E15B741C0
       cmp       rdx,r8
       jne       short M00_L08
M00_L04:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L06
M00_L05:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[]>)
       call      qword ptr [7FF80C7F7180]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C7F71F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L06:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rcx
       jne       short M00_L09
       jmp       short M00_L05
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FF80C395128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,24E15B741C0
       mov       r8d,1
       call      qword ptr [7FF80C394B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L09:
       call      qword ptr [7FF80BEB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       mov       ecx,10
       call      qword ptr [7FF80C114F30]
       int       3
M00_L11:
       mov       rcx,rax
       mov       r11,7FF80BD70C38
       call      qword ptr [r11]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L12:
       call      qword ptr [7FF80C39CED0]
       mov       rcx,24E15B62730
       mov       rdx,24E15B60210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24E15B60008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L14
M00_L13:
       mov       ecx,1
M00_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L15
       call      qword ptr [7FF80C39CFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C39D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L16:
       call      qword ptr [7FF80C39CFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FF80C344F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L17:
       mov       ecx,3174
       mov       rdx,7FF80C38A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4DCB58]
       int       3
; Total bytes of code 959
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
       jmp       qword ptr [7FF80BEB4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rdx,7FF80C925E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FF80C926030
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
       mov       rdx,7FF80C926048
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
       mov       rdx,7FF80C926158
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
       mov       rdx,7FF80C926020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF80C90DB00]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FF80C926020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FF80C90DB78]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FF80C926020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FF80C90DC08]
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
       mov       rdx,7FF80C926188
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FF80C314750]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 521
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M03_L02
       mov       [rsp+28],rcx
       mov       rcx,20D83C0BCB8
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M03_L00
       mov       rcx,rbx
       call      qword ptr [7FF80C395128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M03_L00:
       mov       rcx,rbx
       call      qword ptr [7FF80C394B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M03_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M03_L06
M03_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5E6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       call      qword ptr [7FF80C39CED0]
       mov       rcx,24E15B62730
       mov       rdx,24E15B60210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24E15B60008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M03_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M03_L04
M03_L03:
       mov       ecx,1
M03_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M03_L05
       call      qword ptr [7FF80C39CFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rdx,rax
       call      qword ptr [7FF80BEB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FF80C6CEBE0]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FF80C6CEBE0]
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
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,210
       vzeroupper
       lea       rbp,[rsp+230]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1F0],xmm4
       vmovdqa   xmmword ptr [rbp-1E0],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M05_L00:
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       add       rax,30
       jne       short M05_L00
       mov       [rbp-210],rsp
       mov       rbx,rdx
       mov       rsi,r8
       xor       ecx,ecx
       mov       [rbp-1F8],rcx
       movsxd    rcx,dword ptr [rbx+8]
       cmp       rcx,55555
       jle       near ptr M05_L08
       vmovdqu   xmm0,xmmword ptr [rbx]
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       lea       rcx,[rbp-1D0]
       call      qword ptr [7FF80C3F4F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       test      rax,rax
       je        near ptr M05_L09
M05_L01:
       lea       rdi,[rax+10]
       mov       r14d,[rax+8]
M05_L02:
       mov       [rbp-200],rdi
       mov       [rbp-1BC],r14d
       mov       rcx,rbx
       mov       rdx,[rbp-200]
       mov       [rbp-1E0],rdx
       mov       edx,[rbp-1BC]
       mov       [rbp-1D8],edx
       lea       rdx,[rbp-1E0]
       call      qword ptr [7FF80C3F4F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1BC]
       ja        short M05_L05
       mov       rdx,[rbp-200]
       mov       [rbp-200],rdx
       mov       [rbp-1BC],eax
       mov       rcx,[rsi+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M05_L04
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M05_L03
       jmp       short M05_L06
M05_L03:
       mov       ecx,318C
       mov       rdx,7FF80C38A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4DCB70]
       int       3
M05_L04:
       mov       ecx,318C
       mov       rdx,7FF80C38A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4DCBA0]
       int       3
M05_L05:
       call      qword ptr [7FF80C0EE9A0]
       int       3
M05_L06:
       xor       r10d,r10d
       mov       [rbp-58],r10
       mov       [rbp-50],r10
       mov       byte ptr [rbp-48],0
       mov       byte ptr [rbp-47],0
       mov       byte ptr [rbp-46],0
       mov       byte ptr [rbp-45],0
       mov       byte ptr [rbp-44],0
       mov       byte ptr [rbp-43],0
       mov       [rbp-40],ecx
       mov       [rbp-3C],r8b
       mov       [rbp-3B],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-38],xmm0
       vmovdqu   xmmword ptr [rbp-30],xmm0
       mov       [rbp-1F0],rdx
       mov       [rbp-1E8],eax
       lea       rdx,[rbp-1F0]
       lea       rcx,[rbp-118]
       lea       r9,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF80C556688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       lea       rcx,[rbp-1B8]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C557750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rsi+138]
       mov       r8,[rsi+0B0]
       lea       rdx,[rbp-118]
       lea       r9,[rbp-1B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C43F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rbx,rax
       cmp       qword ptr [rbp-1F8],0
       je        short M05_L07
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FF80BF65278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,20D83C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FF80C41C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M05_L07:
       mov       rax,rbx
       add       rsp,210
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       mov       edx,[rbx+8]
       lea       edx,[rdx+rdx*2]
       mov       rcx,20D83C01E48
       mov       rcx,[rcx]
       call      qword ptr [7FF80C41C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-1F8],rax
       test      rax,rax
       jne       near ptr M05_L01
M05_L09:
       xor       edi,edi
       xor       r14d,r14d
       jmp       near ptr M05_L02
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+230]
       cmp       qword ptr [rbp-1F8],0
       je        short M05_L10
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FF80BF65278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,20D83C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FF80C41C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M05_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 795
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
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF875FC5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M07_L03
       call      qword ptr [7FF875FC9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M07_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
M07_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M07_L01:
       call      qword ptr [7FF875FC69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M07_L00
       call      qword ptr [7FF875FC5060]
       cmp       byte ptr [rax+18E],0
       je        short M07_L00
       mov       ecx,2
       call      qword ptr [7FF875FC6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FF875FC9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M07_L00
       cmp       [rsi+10],rbx
       je        short M07_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M07_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF875FC9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M07_L00
M07_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FF875FC4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M07_L00
M07_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M07_L04
       call      qword ptr [7FF875FC6A08]
       test      rax,rax
       je        near ptr M07_L00
M07_L04:
       call      qword ptr [7FF875FC84A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M08_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M08_L07
M08_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C485590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M08_L12
M08_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M08_L13
       mov       rbp,[rax+8]
M08_L02:
       test      dil,dil
       je        short M08_L03
       test      rbp,rbp
       je        short M08_L06
       mov       rcx,7FF80C8A1E30
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M08_L05
M08_L03:
       test      rbp,rbp
       je        near ptr M08_L09
M08_L04:
       mov       rcx,7FF80C8A1E40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L05:
       mov       rcx,rbp
       call      qword ptr [7FF80C485470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M08_L03
M08_L06:
       mov       rcx,7FF80C8A1E34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L03
M08_L07:
       mov       rcx,rbx
       call      qword ptr [7FF80C4854A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L00
M08_L08:
       cmp       byte ptr [rsp+70],0
       je        short M08_L11
       mov       rcx,7FF80C8A1E38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80C395140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M08_L03
M08_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M08_L10
       mov       rcx,7FF80C8A1E3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF80C4DD9F8]
       int       3
M08_L10:
       mov       rcx,7FF80C8A1E44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
M08_L11:
       mov       rcx,7FF80C8A1E48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L03
M08_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M08_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF80C4855C0]
       mov       rbp,rax
       jmp       near ptr M08_L02
M08_L13:
       call      qword ptr [7FF80C877228]
       int       3
; Total bytes of code 397
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
       jmp       qword ptr [7FF80BEB43A8]
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
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0EEF10]
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
       mov       rax,24E15B60008
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
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M11_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M11_L01
       jmp       near ptr M11_L08
M11_L00:
       xor       edi,edi
       jmp       near ptr M11_L08
M11_L01:
       test      edi,edi
       je        near ptr M11_L09
M11_L02:
       test      dl,dl
       je        near ptr M11_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M11_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M11_L03
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M11_L16
       jmp       short M11_L04
M11_L03:
       call      qword ptr [7FF80C6CEBE0]
       test      eax,eax
       jne       near ptr M11_L16
M11_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M11_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M11_L16
       jmp       short M11_L06
M11_L05:
       call      qword ptr [7FF80C6CEBE0]
       test      eax,eax
       jne       near ptr M11_L16
M11_L06:
       mov       rax,rbx
M11_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L08:
       test      r8,r8
       je        near ptr M11_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M11_L01
       mov       rbx,r8
       jmp       near ptr M11_L02
M11_L09:
       call      qword ptr [7FF80C39CFF0]
       mov       rbx,rax
       test      rsi,rsi
       je        short M11_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M11_L10
       jmp       short M11_L11
M11_L10:
       mov       rsi,rbx
M11_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M11_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M11_L13
M11_L12:
       mov       eax,1
M11_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M11_L14
       call      qword ptr [7FF80C39CFF0]
       mov       rcx,rax
       mov       rdx,24E15B74C00
       call      qword ptr [7FF80C39D200]
M11_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C39D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M11_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEB73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M11_L07
; Total bytes of code 420
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePersonCollection()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+128]
       test      rcx,rcx
       je        near ptr M00_L09
       call      qword ptr [7FF80C375308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L00
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        near ptr M00_L13
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,2CAF7404630
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       byte ptr [rdi+8D],0
       je        near ptr M00_L06
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L07
       mov       rdx,[rbp+0B8]
       mov       r8,30B7D3B4210
       cmp       rdx,r8
       jne       short M00_L07
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>>)
       call      qword ptr [7FF80C8956F8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C895770]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       short M00_L08
       jmp       short M00_L04
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FF80C3A5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,30B7D3B4210
       mov       r8d,1
       call      qword ptr [7FF80C3A4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FF80BEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L09:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,30B7D3A2730
       mov       rdx,30B7D3A0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30B7D3A0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L10
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L11
M00_L10:
       mov       ecx,1
M00_L11:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L12
       call      qword ptr [7FF80C3ACFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FF80C354F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       ecx,3174
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECB58]
       int       3
; Total bytes of code 860
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,2CAF7405150
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF80C3A5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FF80C3A4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5F6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,30B7D3A2730
       mov       rdx,30B7D3A0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,30B7D3A0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FF80BEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M02_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M02_L00
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FF80C6DEBE0]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FF80C6DEBE0]
       test      eax,eax
       jne       short M02_L04
M02_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,210
       vzeroupper
       lea       rbp,[rsp+230]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1F0],xmm4
       vmovdqa   xmmword ptr [rbp-1E0],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-210],rsp
       mov       rbx,rdx
       mov       rsi,r8
       xor       ecx,ecx
       mov       [rbp-1F8],rcx
       movsxd    rcx,dword ptr [rbx+8]
       cmp       rcx,55555
       jle       near ptr M03_L08
       vmovdqu   xmm0,xmmword ptr [rbx]
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       lea       rcx,[rbp-1D0]
       call      qword ptr [7FF80C404F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       test      rax,rax
       je        near ptr M03_L09
M03_L01:
       lea       rdi,[rax+10]
       mov       r14d,[rax+8]
M03_L02:
       mov       [rbp-200],rdi
       mov       [rbp-1BC],r14d
       mov       rcx,rbx
       mov       rdx,[rbp-200]
       mov       [rbp-1E0],rdx
       mov       edx,[rbp-1BC]
       mov       [rbp-1D8],edx
       lea       rdx,[rbp-1E0]
       call      qword ptr [7FF80C404F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1BC]
       ja        short M03_L05
       mov       rdx,[rbp-200]
       mov       [rbp-200],rdx
       mov       [rbp-1BC],eax
       mov       rcx,[rsi+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L04
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L03
       jmp       short M03_L06
M03_L03:
       mov       ecx,318C
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECB70]
       int       3
M03_L04:
       mov       ecx,318C
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECBA0]
       int       3
M03_L05:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M03_L06:
       xor       r10d,r10d
       mov       [rbp-58],r10
       mov       [rbp-50],r10
       mov       byte ptr [rbp-48],0
       mov       byte ptr [rbp-47],0
       mov       byte ptr [rbp-46],0
       mov       byte ptr [rbp-45],0
       mov       byte ptr [rbp-44],0
       mov       byte ptr [rbp-43],0
       mov       [rbp-40],ecx
       mov       [rbp-3C],r8b
       mov       [rbp-3B],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-38],xmm0
       vmovdqu   xmmword ptr [rbp-30],xmm0
       mov       [rbp-1F0],rdx
       mov       [rbp-1E8],eax
       lea       rdx,[rbp-1F0]
       lea       rcx,[rbp-118]
       lea       r9,[rbp-58]
       mov       r8d,1
       call      qword ptr [7FF80C566688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       lea       rcx,[rbp-1B8]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80C567750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rsi+138]
       mov       r8,[rsi+0B0]
       lea       rdx,[rbp-118]
       lea       r9,[rbp-1B8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C44F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rbx,rax
       cmp       qword ptr [rbp-1F8],0
       je        short M03_L07
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FF80BF75278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,2CAF7401E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FF80C42C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M03_L07:
       mov       rax,rbx
       add       rsp,210
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L08:
       mov       edx,[rbx+8]
       lea       edx,[rdx+rdx*2]
       mov       rcx,2CAF7401E48
       mov       rcx,[rcx]
       call      qword ptr [7FF80C42C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-1F8],rax
       test      rax,rax
       jne       near ptr M03_L01
M03_L09:
       xor       edi,edi
       xor       r14d,r14d
       jmp       near ptr M03_L02
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+230]
       cmp       qword ptr [rbp-1F8],0
       je        short M03_L10
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FF80BF75278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,2CAF7401E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FF80C42C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
M03_L10:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 795
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
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF875FC5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M05_L03
       call      qword ptr [7FF875FC9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
M05_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       call      qword ptr [7FF875FC69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M05_L00
       call      qword ptr [7FF875FC5060]
       cmp       byte ptr [rax+18E],0
       je        short M05_L00
       mov       ecx,2
       call      qword ptr [7FF875FC6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FF875FC9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L00
       cmp       [rsi+10],rbx
       je        short M05_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M05_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF875FC9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M05_L00
M05_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FF875FC4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M05_L04
       call      qword ptr [7FF875FC6A08]
       test      rax,rax
       je        near ptr M05_L00
M05_L04:
       call      qword ptr [7FF875FC84A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M06_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M06_L07
M06_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C495590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L12
M06_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M06_L13
       mov       rbp,[rax+8]
M06_L02:
       test      dil,dil
       je        short M06_L03
       test      rbp,rbp
       je        short M06_L06
       mov       rcx,7FF80C8B0D30
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M06_L05
M06_L03:
       test      rbp,rbp
       je        near ptr M06_L09
M06_L04:
       mov       rcx,7FF80C8B0D40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L05:
       mov       rcx,rbp
       call      qword ptr [7FF80C495470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M06_L03
M06_L06:
       mov       rcx,7FF80C8B0D34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L03
M06_L07:
       mov       rcx,rbx
       call      qword ptr [7FF80C4954A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L00
M06_L08:
       cmp       byte ptr [rsp+70],0
       je        short M06_L11
       mov       rcx,7FF80C8B0D38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80C3A5140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M06_L03
M06_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M06_L10
       mov       rcx,7FF80C8B0D3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF80C4ED9F8]
       int       3
M06_L10:
       mov       rcx,7FF80C8B0D44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,7FF80C8B0D48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L03
M06_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M06_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF80C4955C0]
       mov       rbp,rax
       jmp       near ptr M06_L02
M06_L13:
       call      qword ptr [7FF80C896670]
       int       3
; Total bytes of code 397
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
       jmp       qword ptr [7FF80BEC43A8]
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
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0FEF10]
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
       mov       rax,30B7D3A0008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L04
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
M09_L03:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L06
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
M09_L04:
       jmp       short M09_L07
M09_L05:
       call      qword ptr [7FF80C6DEBE0]
       test      eax,eax
       jne       near ptr M09_L16
       jmp       short M09_L03
M09_L06:
       call      qword ptr [7FF80C6DEBE0]
       test      eax,eax
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L07:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FF80C3ACFF0]
       mov       rcx,rax
       mov       rdx,30B7D3B3C30
       call      qword ptr [7FF80C3AD200]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       jmp       near ptr M09_L07
; Total bytes of code 425
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ClonePerson()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       test      rcx,rcx
       je        near ptr M00_L09
       call      qword ptr [7FF80C345308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rax,rax
       je        short M00_L00
       mov       ecx,[rax+8]
       xor       edx,edx
       test      ecx,ecx
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      ecx,ecx
       jne       short M00_L01
       jmp       short M00_L01
M00_L00:
       xor       edx,edx
M00_L01:
       test      edx,edx
       je        near ptr M00_L13
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,14CA540B198
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       byte ptr [rdi+8D],0
       je        near ptr M00_L06
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        near ptr M00_L07
       mov       rdx,[rbp+0B8]
       mov       r8,18D37212928
       cmp       rdx,r8
       jne       short M00_L07
M00_L03:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L05
M00_L04:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80C864138]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF80C864198]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L05:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rcx
       jne       short M00_L08
       jmp       short M00_L04
M00_L06:
       mov       rcx,rdi
       call      qword ptr [7FF80C375128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,18D37212928
       mov       r8d,1
       call      qword ptr [7FF80C374B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FF80BE943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L09:
       call      qword ptr [7FF80C37CED0]
       mov       rcx,18D37202730
       mov       rdx,18D37200210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18D37200008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M00_L10
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M00_L11
M00_L10:
       mov       ecx,1
M00_L11:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M00_L12
       call      qword ptr [7FF80C37CFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C37D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FF80C37CFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FF80C3251B0
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       ecx,3174
       mov       rdx,7FF80C36A518
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4BCB58]
       int       3
; Total bytes of code 860
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,14CA540BCB8
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF80C375128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FF80C374B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5C6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FF80C37CED0]
       mov       rcx,18D37202730
       mov       rdx,18D37200210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18D37200008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FF80C37CFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C37D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FF80BE943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```
```assembly
; System.String.Trim()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M02_L03
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M02_L00
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FF80C6AEBE0]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FF80C6AEBE0]
       test      eax,eax
       jne       short M02_L04
M02_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L04:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M03_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M03_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M03_L03
       mov       rdx,14CA5401E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FF80C3FC3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M03_L01:
       test      rax,rax
       je        near ptr M03_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M03_L04
M03_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FF80C3D4F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M03_L01
M03_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FF80C3D4F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M03_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M03_L05
       jmp       short M03_L08
M03_L05:
       mov       ecx,318C
       mov       rdx,7FF80C36A518
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4BCB70]
       int       3
M03_L06:
       mov       ecx,318C
       mov       rdx,7FF80C36A518
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4BCBA0]
       int       3
M03_L07:
       call      qword ptr [7FF80C0CE9A0]
       int       3
M03_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FF80C536688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80C537750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C41F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       r13,rax
       mov       [rbp-228],r13
       mov       rcx,rsp
       call      M03_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L10:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M03_L34
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L12
       cmp       rdx,300
       ja        short M03_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L12
M03_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FF80BF45BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L12:
       mov       rcx,14CA5401E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FF80BDD5120
       mov       edx,2F
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L13
       mov       rcx,r13
       call      qword ptr [7FF80C416310]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L29
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C405AD0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FF80BE9F750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M03_L29
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FF80C416298]
M03_L15:
       mov       rsi,[rax+8]
       mov       rcx,7FF80BDD5120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF80BDD5C38],0
       je        short M03_L17
       call      qword ptr [7FF80BE9DC98]
       mov       r14d,eax
       jmp       short M03_L20
M03_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M03_L18
       call      qword ptr [7FF80C72C060]
       jmp       short M03_L19
M03_L18:
       mov       eax,r14d
       sar       eax,10
M03_L19:
       mov       r14d,eax
M03_L20:
       mov       rcx,7FF80BDD5120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FF80BDD5C2C]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       near ptr M03_L27
M03_L21:
       cmp       r14d,[rsi+8]
       jae       short M03_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M03_L23
       test      r10d,r10d
       jne       short M03_L24
       xor       edx,edx
       mov       [rax+14],edx
M03_L22:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L23:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L25
       mov       ecx,1
       jmp       short M03_L28
M03_L24:
       jmp       short M03_L22
M03_L25:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M03_L26
       xor       r14d,r14d
M03_L26:
       inc       r15d
M03_L27:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L21
       xor       ecx,ecx
M03_L28:
       mov       esi,ecx
M03_L29:
       mov       rax,14CA54005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M03_L34
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L34
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FF80BF47678]
       test      esi,ebx
       jne       short M03_L34
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L30
       mov       ecx,0FFFFFFFF
       jmp       short M03_L31
M03_L30:
       mov       ecx,r12d
M03_L31:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L32
       mov       eax,1
       jmp       short M03_L33
M03_L32:
       xor       eax,eax
M03_L33:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FF80C1E6EB0]
M03_L34:
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
; Total bytes of code 1597
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
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF875FC5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M05_L03
       call      qword ptr [7FF875FC9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
M05_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M05_L01:
       call      qword ptr [7FF875FC69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M05_L00
       call      qword ptr [7FF875FC5060]
       cmp       byte ptr [rax+18E],0
       je        short M05_L00
       mov       ecx,2
       call      qword ptr [7FF875FC6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FF875FC9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L00
       cmp       [rsi+10],rbx
       je        short M05_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M05_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF875FC9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M05_L00
M05_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FF875FC4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M05_L04
       call      qword ptr [7FF875FC6A08]
       test      rax,rax
       je        near ptr M05_L00
M05_L04:
       call      qword ptr [7FF875FC84A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M06_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M06_L07
M06_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C465590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M06_L12
M06_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M06_L13
       mov       rbp,[rax+8]
M06_L02:
       test      dil,dil
       je        short M06_L03
       test      rbp,rbp
       je        short M06_L06
       mov       rcx,7FF80C898D20
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M06_L05
M06_L03:
       test      rbp,rbp
       je        near ptr M06_L09
M06_L04:
       mov       rcx,7FF80C898D30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L05:
       mov       rcx,rbp
       call      qword ptr [7FF80C465470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M06_L03
M06_L06:
       mov       rcx,7FF80C898D24
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L03
M06_L07:
       mov       rcx,rbx
       call      qword ptr [7FF80C4654A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L00
M06_L08:
       cmp       byte ptr [rsp+70],0
       je        short M06_L11
       mov       rcx,7FF80C898D28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80C375140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M06_L03
M06_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M06_L10
       mov       rcx,7FF80C898D2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF80C4BD9F8]
       int       3
M06_L10:
       mov       rcx,7FF80C898D34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,7FF80C898D38
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L03
M06_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M06_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF80C4655C0]
       mov       rbp,rax
       jmp       near ptr M06_L02
M06_L13:
       call      qword ptr [7FF80C86E070]
       int       3
; Total bytes of code 397
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
       jmp       qword ptr [7FF80BE943A8]
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
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80C0CEF10]
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
       mov       rax,18D37200008
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
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M09_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M09_L01
       jmp       near ptr M09_L08
M09_L00:
       xor       edi,edi
       jmp       near ptr M09_L08
M09_L01:
       test      edi,edi
       je        near ptr M09_L09
M09_L02:
       test      dl,dl
       je        near ptr M09_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M09_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M09_L03
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FF80C6AEBE0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FF80C6AEBE0]
       test      eax,eax
       jne       near ptr M09_L16
M09_L06:
       mov       rax,rbx
M09_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L08:
       test      r8,r8
       je        near ptr M09_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M09_L01
       mov       rbx,r8
       jmp       near ptr M09_L02
M09_L09:
       call      qword ptr [7FF80C37CFF0]
       mov       rbx,rax
       test      rsi,rsi
       je        short M09_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M09_L10
       jmp       short M09_L11
M09_L10:
       mov       rsi,rbx
M09_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M09_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M09_L13
M09_L12:
       mov       eax,1
M09_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M09_L14
       call      qword ptr [7FF80C37CFF0]
       mov       rcx,rax
       mov       rdx,18D37213C30
       call      qword ptr [7FF80C37D200]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C37CBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C37D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BE973F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FF80C355218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L17
       mov       rax,2221BC009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,22213C09CC0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF80C385128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FF80C5D6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L24
       mov       r14d,[rdi+8]
       cmp       r14d,20
       jle       near ptr M01_L23
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r15,[rbp-48]
       mov       r13d,r14d
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FF80C15D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
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
       mov       r15,rax
       mov       [rsp+20],r15
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,r14d
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80C0C5E38]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r15,r15
       je        near ptr M01_L27
       lea       rsi,[r15+10]
       mov       ebx,[r15+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rdx,[r14+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L28
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
       mov       rcx,262A5B290D0
       xor       r9d,r9d
       call      qword ptr [7FF80C81CC60]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,22213C09CC8
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L29
       lea       rcx,[rbx+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L29
M01_L06:
       mov       rsi,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],rsi
       xor       edi,edi
M01_L08:
       cmp       edi,20
       jae       short M01_L10
       mov       ecx,edi
       lea       rcx,[r14+rcx+10]
       mov       r8,2221BC00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,262A5B341E8
       call      qword ptr [7FF80C0B4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [rsi],sil
       test      rax,rax
       je        short M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L14
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       ebx,[rax+r8]
       cmp       ebx,[rcx+8]
       ja        short M01_L13
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L11
M01_L09:
       mov       [rsi+18],ebx
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       add       edi,1
       jo        short M01_L15
       movsxd    rcx,edi
       cmp       rcx,20
       jl        near ptr M01_L08
       mov       rcx,rsi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       jmp       short M01_L16
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L16:
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
M01_L17:
       call      qword ptr [7FF80C38CED0]
       mov       rcx,262A5B22730
       mov       rdx,262A5B20210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,262A5B20008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L18
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L19
M01_L18:
       mov       ecx,1
M01_L19:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L20
       call      qword ptr [7FF80C38CFF0]
       mov       r15,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C7F8]
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C38CBE8]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FF80C38D170]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rbx
       call      qword ptr [7FF80C106670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF80C38CBE8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FF80C106670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,262A5B22D10
       mov       r8d,1
       call      qword ptr [7FF80C384B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L22:
       call      qword ptr [7FF80BEA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L23:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C1550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r15,rax
       jmp       near ptr M01_L05
M01_L24:
       mov       ecx,1763
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M01_L25:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FF80BEAC8A0]
       add       r12d,eax
       jns       near ptr M01_L04
M01_L26:
       call      qword ptr [7FF80BEAC7E0]
       int       3
M01_L27:
       mov       ecx,6A61
       mov       rdx,7FF80C377038
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M01_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C81D860]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF80C377038
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BEAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L29:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-68]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C594D98]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L30
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L06
M01_L30:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rsi,rax
       jmp       near ptr M01_L07
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
       mov       rcx,22213C09CC8
       mov       rsi,[rcx]
       mov       rax,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L32
       mov       rdi,[rbp-0A8]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        short M01_L36
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF80C17C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L33
M01_L32:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rdi,[rbp-0A8]
       je        short M01_L36
M01_L33:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L34
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L36
M01_L34:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L35
       mov       rcx,[rsi+18]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF80C594D68]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L36
M01_L35:
       add       rsi,2C
       lock dec  dword ptr [rsi]
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
; Total bytes of code 1637
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF80C354948]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L24
       mov       rax,1BED14009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,1BED140BCB8
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FF80C3848D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L01:
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        near ptr M01_L28
M01_L02:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L03
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L29
M01_L03:
       lea       rdx,[rbp-40]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5D6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L32
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
       call      qword ptr [7FF80C15D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L31
       cmp       r9d,r15d
       jne       near ptr M01_L30
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
       call      qword ptr [7FF80C0C5E38]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L33
       lea       rbx,[rax+10]
       mov       r14d,[rax+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       lea       rdx,[rsi+10]
       mov       r8d,20
       cmp       r8d,20
       jl        near ptr M01_L34
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
       mov       rcx,1FF633790D0
       xor       r9d,r9d
       call      qword ptr [7FF80C865C98]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,1BED140BCC0
       mov       r15,[rcx]
       mov       rcx,[r15+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L16
       lea       rcx,[r15+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L16
M01_L06:
       mov       rdi,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],rdi
       xor       r14d,r14d
M01_L08:
       cmp       r14d,20
       jae       short M01_L10
       mov       ecx,r14d
       lea       rcx,[rsi+rcx+10]
       mov       r8,1BED1400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,1FF633841E8
       call      qword ptr [7FF80C0B4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [rdi],dil
       test      rax,rax
       je        short M01_L14
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L14
       mov       rcx,[rdi+8]
       mov       eax,[rdi+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        short M01_L13
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        short M01_L12
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        short M01_L11
M01_L09:
       mov       [rdi+18],r15d
       jmp       short M01_L14
M01_L10:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L11:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L12:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L13:
       mov       rcx,rdi
       call      qword ptr [7FF80C17CA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L14:
       add       r14d,1
       jo        short M01_L15
       movsxd    rcx,r14d
       cmp       rcx,20
       jl        near ptr M01_L08
       mov       rcx,rdi
       call      qword ptr [7FF80C1839E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       jmp       short M01_L19
M01_L15:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L16:
       mov       r13,[r15+18]
       mov       rdi,[r13+18]
       lea       rdx,[rbp-68]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF80C595290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L21
M01_L17:
       add       r15,2C
       lock dec  dword ptr [r15]
       jmp       near ptr M01_L06
M01_L18:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C1550C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L19:
       mov       rcx,rsp
       call      M01_L36
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
       lea       rdx,[rbp-68]
       mov       rcx,r13
       call      qword ptr [7FF80C594DB0]
       test      eax,eax
       je        short M01_L22
       jmp       short M01_L17
M01_L21:
       cmp       qword ptr [rdi+10],0
       jne       short M01_L20
       xor       edx,edx
       mov       [rbp-68],rdx
M01_L22:
       mov       rbx,[r15+8]
       mov       rcx,7FF80C591338
       cmp       [rbx+18],rcx
       jne       near ptr M01_L35
       mov       r15,[rbx+8]
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[r15+8]
       mov       rcx,rdi
       mov       r8d,7FFFFFFF
       call      qword ptr [7FF80C17C0F0]; System.Text.StringBuilder..ctor(Int32, Int32)
M01_L23:
       jmp       near ptr M01_L07
M01_L24:
       call      qword ptr [7FF80C38C3C0]
       mov       rcx,1FF63372730
       mov       rdx,1FF63370210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1FF63370008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L25
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L26
M01_L25:
       mov       ecx,1
M01_L26:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L27
       call      qword ptr [7FF80C38C4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C387CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C38C0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38C660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF80C106670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L27:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FF80C38C0D8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r12
       call      qword ptr [7FF80C106670]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
M01_L28:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,1FF63372D10
       mov       r8d,1
       call      qword ptr [7FF80C3842B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L29:
       call      qword ptr [7FF80BEA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L30:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FF80BEAC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L31:
       call      qword ptr [7FF80BEAC7E0]
       int       3
M01_L32:
       mov       ecx,1763
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M01_L33:
       mov       ecx,6A61
       mov       rdx,7FF80C377038
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M01_L34:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C73C3D8]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FF80C377038
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BEAF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L35:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       mov       rdi,rax
       jmp       near ptr M01_L23
M01_L36:
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
       mov       rcx,1BED140BCC0
       mov       rdi,[rcx]
       mov       r13,[rdi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [r13+18],rcx
       jne       short M01_L37
       mov       r14,[rbp-0A8]
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       mov       rdx,[r13+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L41
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF80C17C1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L38
M01_L37:
       mov       rdx,[rbp-0A8]
       mov       rcx,[r13+8]
       call      qword ptr [r13+18]
       test      eax,eax
       mov       r14,[rbp-0A8]
       je        short M01_L41
M01_L38:
       cmp       qword ptr [rdi+20],0
       jne       short M01_L39
       lea       rcx,[rdi+20]
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L41
M01_L39:
       lea       rcx,[rdi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rdi+28]
       jg        short M01_L40
       mov       r12,[rdi+18]
       mov       rcx,[r12+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF80C5952C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L41
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FF80C594D80]
       jmp       short M01_L41
M01_L40:
       add       rdi,2C
       lock dec  dword ptr [rdi]
M01_L41:
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
; Total bytes of code 1775
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C734E40]; System.Data.DataTable..ctor()
       mov       rcx,25BAABB41C0
       mov       [rbx+70],rcx
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF80C375230]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 60
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
       mov       rsi,25BAABA0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,25BAABB4260
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,25BAABB4338
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,25BAABB4350
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,25BAABB4368
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,25BAABB4380
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FF80BE05C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF80C743D90
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF80C14C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,21B1CC0F420
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
       mov       rdx,25BAABB41E0
       call      qword ptr [7FF80BEC6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80BF776D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80C73D500]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF80C0A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80C7376F0]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,25BAABAC760
       mov       [rax+8],rcx
       lea       rcx,[rsi+10]
       mov       rdx,rax
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
       call      qword ptr [7FF80C73C648]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,25BAABB4410
       mov       [rax+8],rcx
       lea       rcx,[rbx+58]
       mov       rdx,rax
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
; Total bytes of code 876
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      r15
       push      r14
       push      r13
       push      r12
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
       test      rbx,rbx
       je        near ptr M02_L41
       mov       rcx,rbx
       call      System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        near ptr M02_L18
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L18
M02_L00:
       cmp       [rsi],sil
       lea       rdi,[rsi+48]
       mov       rbp,[rdi]
       test      rbp,rbp
       je        near ptr M02_L16
M02_L01:
       mov       rcx,rbp
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M02_L20
       mov       rsi,[rcx+8]
M02_L02:
       mov       edi,[rsi+8]
       mov       ecx,edi
       xor       r8d,r8d
       mov       [rsp+30],r8
       mov       [rsp+38],r8
       mov       [rsp+40],r8d
       mov       [rsp+44],ecx
       xor       ebp,ebp
       test      edi,edi
       jle       short M02_L05
M02_L03:
       mov       ecx,ebp
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,3E
       cmp       edx,ecx
       jne       short M02_L04
       lea       rcx,[rsp+30]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF80C174BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       inc       ebp
       cmp       edi,ebp
       jg        short M02_L03
M02_L05:
       mov       rsi,[rsp+30]
       mov       rdi,[rsp+38]
       mov       ebp,[rsp+40]
       test      ebp,ebp
       je        near ptr M02_L42
       cmp       ebp,1
       je        near ptr M02_L43
       test      ebp,ebp
       jl        near ptr M02_L44
       mov       rdi,rsi
       test      rdi,rdi
       je        near ptr M02_L45
       cmp       [rsi+8],ebp
       jne       near ptr M02_L15
M02_L06:
       mov       rcx,21B1CC0BDD8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M02_L12
M02_L07:
       test      rsi,rsi
       je        near ptr M02_L51
       test      rdi,rdi
       je        near ptr M02_L46
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF80BEC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L47
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      qword ptr [7FF80BEC4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M02_L49
       cmp       dword ptr [rbp+8],0
       je        near ptr M02_L48
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       test      r14,r14
       je        near ptr M02_L51
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L52
       mov       rcx,rax
       mov       r11,7FF80BD80AF0
       call      qword ptr [r11]
       mov       rbp,rax
M02_L09:
       test      rbp,rbp
       je        near ptr M02_L53
       cmp       dword ptr [rbp+10],0
       jle       near ptr M02_L53
       xor       r15d,r15d
M02_L10:
       mov       rcx,rbp
       mov       r11,7FF80BD80AF8
       call      qword ptr [r11]
       movsxd    rcx,eax
       movsxd    rax,r15d
       cmp       rcx,rax
       jle       short M02_L11
       cmp       r15d,[rbp+10]
       jae       near ptr M02_L35
       mov       rcx,[rbp+8]
       cmp       r15d,[rcx+8]
       jae       near ptr M02_L55
       mov       eax,r15d
       mov       r13,[rcx+rax*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r13],rcx
       jne       near ptr M02_L34
       test      byte ptr [r13+38],1
       jne       short M02_L13
       mov       rcx,r13
       call      qword ptr [7FF80C1B71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       short M02_L14
M02_L11:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L12:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,21B1CC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__7_0(System.Reflection.FieldInfo)
       mov       [rdi+18],rcx
       mov       rcx,21B1CC0BDD8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L13:
       mov       eax,[r13+38]
M02_L14:
       mov       rcx,[r13+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M02_L17
       mov       r12,[r13+10]
       jmp       near ptr M02_L19
M02_L15:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       call      qword ptr [7FF80BF75BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L06
M02_L16:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r14
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       cmove     rbp,r14
       jmp       near ptr M02_L01
M02_L17:
       xor       r12d,r12d
       jmp       short M02_L19
M02_L18:
       mov       rcx,rax
       call      qword ptr [7FF80BE16658]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L19:
       test      r12,r12
       je        short M02_L22
       jmp       short M02_L21
M02_L20:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF80C174E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M02_L02
M02_L21:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       je        short M02_L22
       xor       r12d,r12d
M02_L22:
       test      al,2
       jne       near ptr M02_L36
       test      byte ptr [r13+1C],10
       jne       short M02_L23
       mov       rcx,[r13+10]
       cmp       [rcx],cl
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M02_L38
M02_L23:
       mov       rdx,[r13+28]
       test      rdx,rdx
       jne       short M02_L24
       mov       rcx,r13
       call      qword ptr [7FF80C1B73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L24:
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L25
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M02_L39
M02_L25:
       mov       byte ptr [rsp+28],0
       test      r12,r12
       je        near ptr M02_L54
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        near ptr M02_L31
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M02_L31
M02_L26:
       movzx     ecx,byte ptr [rax+95]
       mov       [rsp+28],cl
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8,rsi
       mov       r9,r12
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r13,rax
       movzx     edi,byte ptr [rsp+28]
       mov       rcx,[r12+10]
       test      rcx,rcx
       je        short M02_L32
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L32
M02_L27:
       mov       [rax+95],dil
M02_L28:
       test      r13,r13
       je        short M02_L29
       mov       rdx,r13
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       short M02_L33
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L30
M02_L29:
       add       r15d,1
       jo        near ptr M02_L40
       jmp       near ptr M02_L10
M02_L30:
       mov       rcx,rax
       call      qword ptr [7FF80C3751D0]; DotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
       jmp       short M02_L29
M02_L31:
       mov       rcx,r12
       call      qword ptr [7FF80BE16658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M02_L26
M02_L32:
       mov       rcx,r12
       call      qword ptr [7FF80BE16658]; System.RuntimeType.InitializeCache()
       jmp       short M02_L27
M02_L33:
       xor       edx,edx
       call      qword ptr [7FF80C375368]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L29
M02_L34:
       mov       rcx,r13
       mov       rdx,rbx
       mov       rax,[r13]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       r13,rax
       jmp       near ptr M02_L28
M02_L35:
       call      qword ptr [7FF80C0FEA30]
       int       3
M02_L36:
       test      r12,r12
       je        short M02_L37
       mov       rcx,r13
       call      qword ptr [7FF80C18B2F0]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L37
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C434510]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF80C126718]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M02_L37:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C327090]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L38:
       call      qword ptr [7FF80C40F558]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r13
       call      qword ptr [7FF80C1C2178]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       rbp,rax
       mov       r14,[r13+10]
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,r14
       mov       rcx,rsi
       call      qword ptr [7FF80C40EE68]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80BECF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L39:
       call      qword ptr [7FF80BEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L40:
       call      CORINFO_HELP_OVERFLOW
M02_L41:
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L42:
       mov       rsi,25BAABB3A50
       jmp       near ptr M02_L06
M02_L43:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M02_L06
M02_L44:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF80C0FED18]
       int       3
M02_L45:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L46:
       mov       ecx,0C
       call      qword ptr [7FF80C124F30]
       int       3
M02_L47:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M02_L08
M02_L48:
       mov       rcx,7FF80C03F690
       mov       edx,5
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,21B1CC01FB0
       mov       r14,[rdx]
       jmp       near ptr M02_L08
M02_L49:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FF80BEC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M02_L50
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF80C2E7498]
       mov       r14,rsi
       jmp       near ptr M02_L08
M02_L50:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF80C8CE550]
       jmp       near ptr M02_L08
M02_L51:
       mov       ecx,10
       call      qword ptr [7FF80C124F30]
       int       3
M02_L52:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,r14
       call      qword ptr [7FF80BF7DFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L09
M02_L53:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L54:
       lea       rcx,[rsp+28]
       mov       [rsp+20],rcx
       mov       rcx,r13
       mov       rdx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r13,rax
       jmp       near ptr M02_L28
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1872
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,2B5BD424210
       call      qword ptr [7FF80C355260]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L13
       mov       rsi,[rdi+8]
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       xor       ecx,ecx
       test      ebp,ebp
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ebp,ebp
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L14
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L03
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       near ptr M01_L06
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L15
M01_L02:
       lea       ecx,[rbp-1]
       cmp       ecx,ebp
       jae       near ptr M01_L16
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       near ptr M01_L07
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L15
M01_L03:
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,3C
       call      qword ptr [7FF80BDF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       je        near ptr M01_L10
       cmp       dword ptr [rsp+48],1
       je        near ptr M01_L09
       mov       r14d,[rsp+48]
       test      r14d,r14d
       jl        near ptr M01_L11
       mov       rsi,[rsp+38]
       test      rsi,rsi
       je        near ptr M01_L12
       cmp       [rsi+8],r14d
       jne       near ptr M01_L08
M01_L04:
       mov       ecx,[rsp+48]
       mov       [rsp+4C],ecx
       mov       rsi,[rsp+38]
M01_L05:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C83BD50
       mov       [rbx+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rsi
       mov       r8,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FF80C7F4E10]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       call      qword ptr [7FF80C6BEBE0]
       test      eax,eax
       jne       near ptr M01_L15
       jmp       near ptr M01_L02
M01_L07:
       call      qword ptr [7FF80C6BEBE0]
       test      eax,eax
       jne       near ptr M01_L15
       jmp       near ptr M01_L03
M01_L08:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       r14d,r8d
       cmovg     r14d,r8d
       mov       r8d,r14d
       shl       r8,3
       call      qword ptr [7FF80BF55BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsp+38],rbp
       jmp       near ptr M01_L04
M01_L09:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,[rsp+40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L10:
       mov       rsi,2B5BD419AA0
       jmp       near ptr M01_L05
M01_L11:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF80C0DED18]
       int       3
M01_L12:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+38],rax
       jmp       near ptr M01_L04
M01_L13:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       call      qword ptr [7FF80C38CFF0]
       mov       rsi,rax
       mov       ecx,787
       mov       rdx,7FF80C334F30
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38CBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C38D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       jmp       near ptr M01_L03
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 830
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,1812D9C4210
       call      qword ptr [7FF80C355260]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       rcx,[rbx+18]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rsi,[rdi+8]
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       xor       ecx,ecx
       test      ebp,ebp
       sete      cl
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ebp,ebp
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L12
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L05
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L13
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF80C6BEBE0]
       test      eax,eax
       jne       near ptr M01_L13
M01_L03:
       lea       ecx,[rbp-1]
       cmp       ecx,ebp
       jae       near ptr M01_L17
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L13
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FF80C6BEBE0]
       test      eax,eax
       jne       near ptr M01_L13
M01_L05:
       mov       rdx,rsi
M01_L06:
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,3C
       call      qword ptr [7FF80BDF66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       je        near ptr M01_L14
       cmp       dword ptr [rsp+48],1
       je        near ptr M01_L10
       mov       r14d,[rsp+48]
       test      r14d,r14d
       jl        near ptr M01_L15
       mov       rbp,[rsp+38]
       test      rbp,rbp
       je        near ptr M01_L16
       cmp       [rbp+8],r14d
       jne       short M01_L09
M01_L07:
       mov       ecx,[rsp+48]
       mov       [rsp+4C],ecx
       mov       rbp,[rsp+38]
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C83BD50
       mov       [rbx+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FF80C7F4E70]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       setne     al
       movzx     eax,al
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[rbp+10]
       mov       r8d,[rbp+8]
       cmp       r14d,r8d
       cmovg     r14d,r8d
       mov       r8d,r14d
       shl       r8,3
       call      qword ptr [7FF80BF55BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsp+38],rsi
       jmp       near ptr M01_L07
M01_L10:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,[rsp+40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L08
M01_L11:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FF80C38CFF0]
       mov       rdi,rax
       mov       ecx,787
       mov       rdx,7FF80C334F30
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38CBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF80C38D170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF80BEA73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rbp,1812D9B9AA0
       jmp       near ptr M01_L08
M01_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FF80C0DED18]
       int       3
M01_L16:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+38],rax
       jmp       near ptr M01_L07
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 812
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       mov       rdx,205DE5141E8
       call      qword ptr [7FF80C354D88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
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
       mov       rdi,[rsi+30]
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
       lea       rcx,[rsi+30]
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
       call      qword ptr [7FF80BF75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BF747B0]
       mov       ecx,eax
       jmp       short M01_L02
M01_L08:
       call      qword ptr [7FF80C3ACEB8]
       mov       r14,rax
       mov       rcx,205DE50E780
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACC00]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rsi
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
       mov       ecx,0AD5
       mov       rdx,7FF80C21FB48
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FF80C3A45D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BF7D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 379
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C324D60]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
       sub       rsp,38
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,1D395A90008
       mov       r8d,3A
       mov       r9,1D395A98DF0
       call      qword ptr [7FF80C3452D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       nop
       add       rsp,38
       ret
; Total bytes of code 58
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,18ACEAF0008
       mov       r8d,1
       call      qword ptr [7FF80C3649F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80BEBEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,14A3CC0B188
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FF80BEBEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L04
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF80BEBEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF80C8845B8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF80C065740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r13,rax
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
       mov       r12d,[r15+8]
       test      r12,r12
       jle       near ptr M01_L39
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF80C8843C0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF80BE066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L59
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF80C165908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,18ACEAF0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,14A3CC01DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF80C209CF8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L60
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L62
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L61
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L62
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BEB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L57
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L56
       call      qword ptr [7FF80C022290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L11:
       mov       rcx,rax
M01_L12:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L13:
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FF80C13E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C094180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,18ACEB04240
       call      qword ptr [7FF80BEB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C3649F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF80C884450]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,14A3CC0BDE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,14A3CC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8804C8
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,14A3CC0BDE8
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C884CC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L22
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF80C13E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L13
       jmp       short M01_L23
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,14A3CC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8804E0
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,[rbp-118]
       mov       r11,7FF80BD70EB0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L22:
       mov       r11,7FF80BD70EA8
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L24
       cmp       [rcx],rdi
       jne       near ptr M01_L58
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
       cmp       esi,[r15+8]
       jae       near ptr M01_L79
       mov       ecx,esi
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L71
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L63
       mov       r8,18ACEAFCE28
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L75
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L75
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
       call      qword ptr [7FF80C166208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF80C166280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF80C1F7F00]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L38
M01_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L65
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L29:
       test      rcx,rcx
       je        near ptr M01_L76
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF80C143A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L30:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L31
       test      rax,rax
       je        near ptr M01_L38
M01_L31:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L41
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L40
       mov       r10,[rcx]
       add       r10,10
M01_L32:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L33
       mov       r9,14A3CC00438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L33
       mov       r9,14A3CC00418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M01_L67
M01_L33:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M01_L69
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M01_L68
M01_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,18ACEB04268
       call      qword ptr [7FF80BEB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF80C3649F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L77
       test      rax,rax
       je        near ptr M01_L78
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L70
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
       mov       rcx,14A3CC0BDF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L46
M01_L36:
       mov       rcx,14A3CC0BDF8
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L45
       mov       rax,[rbp-138]
M01_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C884CC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L47
       movsxd    rax,esi
       cmp       r12,rax
       jg        near ptr M01_L25
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
       jmp       near ptr M01_L66
M01_L42:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L43
       mov       r8,[rbp-98]
       jmp       short M01_L44
M01_L43:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L79
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
       jmp       near ptr M01_L26
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,14A3CC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C880510
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,14A3CC0BDF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,14A3CC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8804F8
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,14A3CC0BDF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L47:
       call      CORINFO_HELP_OVERFLOW
M01_L48:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,18ACEB04210
       mov       rdx,18ACEAF0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18ACEAF0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L49
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L50
M01_L49:
       mov       ecx,1
M01_L50:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L51
       call      qword ptr [7FF80C39C4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF80C116670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF80C116670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L52:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,18ACEAF2730
       mov       rdx,18ACEAF0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18ACEAF0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L53
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L54
M01_L53:
       mov       ecx,1
M01_L54:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L55
       call      qword ptr [7FF80C39C4E0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L56:
       mov       r11,7FF80BD70EC0
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L57:
       mov       rcx,rax
       mov       r11,7FF80BD70EA0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L58:
       mov       r11,7FF80BD70EB8
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L59:
       mov       r15,18ACEAF9AA0
       jmp       near ptr M01_L07
M01_L60:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L61:
       call      qword ptr [7FF80C0EE9A0]
       int       3
M01_L62:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF80C065848]
       jmp       near ptr M01_L03
M01_L63:
       mov       rcx,rax
       mov       rdx,18ACEAFCE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L27
M01_L64:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M01_L29
M01_L65:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L30
M01_L66:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L67:
       call      qword ptr [7FF80C094030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L68:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF80C1651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF80C165230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L34
M01_L69:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L34
M01_L70:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L35
M01_L71:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,18ACEB04540
       mov       rdx,18ACEAF0210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,18ACEAF0008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L72
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L73
M01_L72:
       mov       ecx,1
M01_L73:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L74
       call      qword ptr [7FF80C39C4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L75:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3FF090]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BEBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3FEA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L77:
       mov       ecx,4
       call      qword ptr [7FF80C114F30]
       int       3
M01_L78:
       mov       ecx,0E
       call      qword ptr [7FF80C114F30]
       int       3
M01_L79:
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
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L80
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L80
       mov       r11,7FF80BD70EB8
       call      qword ptr [r11]
M01_L80:
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
; Total bytes of code 4054
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,20439480008
       xor       r8d,r8d
       call      qword ptr [7FF80C3649F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80BEBEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1C3A740B188
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FF80BEBEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        near ptr M01_L06
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       short M01_L04
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF80BEBEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF80C8645B8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF80C065740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r13,rax
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
       mov       r12d,[r15+8]
       test      r12,r12
       jle       near ptr M01_L39
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FF80C8643C0]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF80BE066D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L59
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF80C165908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,20439480008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1C3A7401DB0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF80C1BB250]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L60
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L62
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L61
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L62
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF80BEB43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L57
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L56
       call      qword ptr [7FF80C022290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L11:
       mov       rcx,rax
M01_L12:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L17
M01_L13:
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FF80C13E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C094180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,20439494218
       call      qword ptr [7FF80BEB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C3649F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF80C864450]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1C3A740BDE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1C3A740BDD0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8604C8
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,1C3A740BDE8
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C864CC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L22
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF80C13E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L13
       jmp       short M01_L23
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1C3A740BDD0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8604E0
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,[rbp-118]
       mov       r11,7FF80BD70D60
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L22:
       mov       r11,7FF80BD70D58
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L24
       cmp       [rcx],rdi
       jne       near ptr M01_L58
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
       cmp       esi,[r15+8]
       jae       near ptr M01_L79
       mov       ecx,esi
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L71
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L63
       mov       r8,2043948CE28
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L75
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L75
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
       call      qword ptr [7FF80C166208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF80C166280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF80C1ACCF0]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L38
M01_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L65
       mov       rcx,rax
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L29:
       test      rcx,rcx
       je        near ptr M01_L76
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF80C143A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L30:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L31
       test      rax,rax
       je        near ptr M01_L38
M01_L31:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L41
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L40
       mov       r10,[rcx]
       add       r10,10
M01_L32:
       mov       r9,[r10+8]
       test      r9,r9
       jne       short M01_L33
       mov       r9,1C3A7400438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L33
       mov       r9,1C3A7400418
       mov       r9,[r9]
       test      r9,r9
       je        near ptr M01_L67
M01_L33:
       mov       rcx,r9
       mov       [rbp-130],rcx
       mov       r11,[rbp-120]
       mov       rdx,[rbp-110]
       cmp       [r11],rdx
       jne       near ptr M01_L69
       mov       r8,r11
       mov       [rbp-150],r8
       mov       r10,[r8+8]
       test      r10,r10
       je        near ptr M01_L68
M01_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r10
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,20439494240
       call      qword ptr [7FF80BEB6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF80C3649F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L77
       test      rax,rax
       je        near ptr M01_L78
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF80BEB4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L70
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
       mov       rcx,1C3A740BDF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L46
M01_L36:
       mov       rcx,1C3A740BDF8
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L45
       mov       rax,[rbp-138]
M01_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C864CC0]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L47
       movsxd    rax,esi
       cmp       r12,rax
       jg        near ptr M01_L25
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
       jmp       near ptr M01_L66
M01_L42:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L43
       mov       r8,[rbp-98]
       jmp       short M01_L44
M01_L43:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L79
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
       jmp       near ptr M01_L26
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,1C3A740BDD0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C860510
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1C3A740BDF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1C3A740BDD0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C8604F8
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1C3A740BDF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L47:
       call      CORINFO_HELP_OVERFLOW
M01_L48:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,204394941E8
       mov       rdx,20439480210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20439480008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L49
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L50
M01_L49:
       mov       ecx,1
M01_L50:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L51
       call      qword ptr [7FF80C39C4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF80C116670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF80C116670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L52:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,20439482730
       mov       rdx,20439480210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20439480008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L53
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L54
M01_L53:
       mov       ecx,1
M01_L54:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L55
       call      qword ptr [7FF80C39C4E0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L56:
       mov       r11,7FF80BD70D70
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L57:
       mov       rcx,rax
       mov       r11,7FF80BD70D50
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L58:
       mov       r11,7FF80BD70D68
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L59:
       mov       r15,20439489AA0
       jmp       near ptr M01_L07
M01_L60:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L61:
       call      qword ptr [7FF80C0EE9A0]
       int       3
M01_L62:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF80C065848]
       jmp       near ptr M01_L03
M01_L63:
       mov       rcx,rax
       mov       rdx,2043948CE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L27
M01_L64:
       mov       rax,[rbp-120]
       xor       ecx,ecx
       jmp       near ptr M01_L29
M01_L65:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L30
M01_L66:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r10,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L67:
       call      qword ptr [7FF80C094030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L68:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF80C1651B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF80C165230]
       mov       r10,rax
       mov       [rbp-168],r10
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r10
       call      CORINFO_HELP_ASSIGN_REF
       mov       r10,[rbp-168]
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L34
M01_L69:
       mov       rcx,r11
       mov       rdx,[r11]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r10,rax
       mov       rax,[rbp-128]
       mov       rcx,[rbp-130]
       jmp       near ptr M01_L34
M01_L70:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L35
M01_L71:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,20439494518
       mov       rdx,20439480210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20439480008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L72
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L73
M01_L72:
       mov       ecx,1
M01_L73:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L74
       call      qword ptr [7FF80C39C4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L75:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3FF090]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BEBF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3FEA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BEBF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L77:
       mov       ecx,4
       call      qword ptr [7FF80C114F30]
       int       3
M01_L78:
       mov       ecx,0E
       call      qword ptr [7FF80C114F30]
       int       3
M01_L79:
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
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L80
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L80
       mov       r11,7FF80BD70D68
       call      qword ptr [r11]
M01_L80:
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
; Total bytes of code 4054
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,298C9A90008
       mov       r8d,1
       call      qword ptr [7FF80C3749F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80BECEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L51
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L55
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,2583BC0B188
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FF80BECEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L59
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF80BECEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF80C85FED0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF80C075740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r13,rax
       jmp       near ptr M01_L23
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FF80C85FCD8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L08
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF80BE166D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L63
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L07
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF80C175908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L05:
       mov       r13,298C9A90008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L23
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,2583BC01DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF80C21C3F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L64
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L66
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L65
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L66
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L08:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF80BEC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L61
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L60
       call      qword ptr [7FF80C032290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
M01_L09:
       mov       rcx,rax
M01_L10:
       mov       [rbp-118],rcx
       mov       r12,[rcx]
       jmp       near ptr M01_L15
M01_L11:
       cmp       r12,rdi
       jne       near ptr M01_L18
       mov       rdx,r12
       mov       rcx,[rbp-118]
       add       rcx,8
       call      qword ptr [7FF80C14E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L12:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L20
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C0A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,298C9AA41F0
       call      qword ptr [7FF80BEC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C3749F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF80C85FD68]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2583BC0BDE0
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L13
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2583BC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C85BDE0
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L13:
       mov       r14,2583BC0BDE8
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L17
M01_L14:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C884678]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L15:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L19
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF80C14E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L16:
       test      eax,eax
       jne       near ptr M01_L11
       jmp       near ptr M01_L21
M01_L17:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,2583BC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C85BDF8
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L14
M01_L18:
       mov       rcx,[rbp-118]
       mov       r11,7FF80BD80E30
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L12
M01_L19:
       mov       r11,7FF80BD80E28
       call      qword ptr [r11]
       jmp       near ptr M01_L16
M01_L20:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L21:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L22
       cmp       [rcx],rdi
       jne       near ptr M01_L62
M01_L22:
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
M01_L23:
       xor       esi,esi
       mov       r12d,[r15+8]
       test      r12,r12
       jle       near ptr M01_L39
M01_L24:
       cmp       esi,[r15+8]
       jae       near ptr M01_L83
       mov       ecx,esi
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L75
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L67
       mov       r8,298C9A9CE28
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L79
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L79
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
       call      qword ptr [7FF80C176208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF80C176280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L46
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF80C20DDB8]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L38
M01_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L69
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L68
       mov       rcx,[rax+18]
M01_L28:
       test      rcx,rcx
       je        near ptr M01_L80
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF80C153A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r10,2583BC00438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,2583BC00418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L71
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
       je        near ptr M01_L49
M01_L34:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,298C9AA4218
       call      qword ptr [7FF80BEC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF80C3749F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L81
       test      rax,rax
       je        near ptr M01_L82
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF80BEC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L74
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
       mov       rcx,2583BC0BDF0
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L47
M01_L36:
       mov       rcx,2583BC0BDF8
       mov       r9,[rcx]
       mov       [rbp-138],rax
       test      r9,r9
       je        near ptr M01_L45
       mov       rax,[rbp-138]
M01_L37:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C884678]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L50
       movsxd    rax,esi
       cmp       r12,rax
       jg        near ptr M01_L24
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
       jmp       near ptr M01_L72
M01_L41:
       jmp       near ptr M01_L70
M01_L42:
       jmp       near ptr M01_L70
M01_L43:
       mov       rcx,[rbp-0A0]
       cmp       eax,[rcx+8]
       jae       near ptr M01_L83
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
       jl        short M01_L46
       jmp       near ptr M01_L25
M01_L45:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       [rbp-140],r9
       mov       rcx,2583BC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C85BE28
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2583BC0BDF8
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L46:
       cmp       qword ptr [rbp-0A0],0
       jne       near ptr M01_L43
       jmp       short M01_L48
M01_L47:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2583BC0BDD0
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF80C85BE10
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2583BC0BDF0
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L48:
       mov       r8,[rbp-98]
       jmp       near ptr M01_L44
M01_L49:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF80C1751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF80C175230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L50:
       call      CORINFO_HELP_OVERFLOW
M01_L51:
       call      qword ptr [7FF80C3AC3C0]
       mov       rcx,298C9AA41C0
       mov       rdx,298C9A90210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,298C9A90008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L52
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L53
M01_L52:
       mov       ecx,1
M01_L53:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L54
       call      qword ptr [7FF80C3AC4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7CD8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC660]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF80C126670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF80C126670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L55:
       call      qword ptr [7FF80C3AC3C0]
       mov       rcx,298C9A92730
       mov       rdx,298C9A90210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,298C9A90008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L56
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L57
M01_L56:
       mov       ecx,1
M01_L57:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L58
       call      qword ptr [7FF80C3AC4E0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7CD8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF80C3AC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L58:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L59:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M01_L02
M01_L60:
       mov       r11,7FF80BD80E40
       call      qword ptr [r11]
       jmp       near ptr M01_L09
M01_L61:
       mov       rcx,rax
       mov       r11,7FF80BD80E20
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L10
M01_L62:
       mov       r11,7FF80BD80E38
       call      qword ptr [r11]
       jmp       near ptr M01_L22
M01_L63:
       mov       r15,298C9A99AA0
       jmp       near ptr M01_L05
M01_L64:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L65:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M01_L66:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF80C075848]
       jmp       near ptr M01_L03
M01_L67:
       mov       rcx,rax
       mov       rdx,298C9A9CE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L26
M01_L68:
       xor       ecx,ecx
       jmp       near ptr M01_L28
M01_L69:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L29
M01_L70:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L71:
       call      qword ptr [7FF80C0A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M01_L73
M01_L72:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L73:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L74:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L35
M01_L75:
       call      qword ptr [7FF80C3AC3C0]
       mov       rcx,298C9AA4590
       mov       rdx,298C9A90210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,298C9A90008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L76
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L77
M01_L76:
       mov       ecx,1
M01_L77:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L78
       call      qword ptr [7FF80C3AC4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AC660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L78:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C40F090]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BECF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L80:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C40EA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BECF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L81:
       mov       ecx,4
       call      qword ptr [7FF80C124F30]
       int       3
M01_L82:
       mov       ecx,0E
       call      qword ptr [7FF80C124F30]
       int       3
M01_L83:
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
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L84
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L84
       mov       r11,7FF80BD80E38
       call      qword ptr [r11]
M01_L84:
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
; Total bytes of code 4087
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,226F6DA0008
       xor       r8d,r8d
       call      qword ptr [7FF80C3752C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FF80BECEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L54
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1E665009190
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FF80BECEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L04
       mov       rcx,offset MT_System.String
       cmp       [rbx],rcx
       jne       near ptr M01_L58
       mov       r8,rbx
M01_L02:
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      qword ptr [7FF80BECEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FF80C7743C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FF80C075740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       r13,rax
       jmp       near ptr M01_L22
M01_L04:
       mov       rcx,r15
       call      qword ptr [7FF80C7741C8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L07
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FF80BE166D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L62
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L63
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FF80C175908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L05:
       mov       r13,226F6DA0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L22
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1E669001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FF80C21C3F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L64
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L06:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L66
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L65
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L66
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L07:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FF80BEC43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L60
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L59
       call      qword ptr [7FF80C032290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FF80C14E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L11:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L16
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C0A4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,226F6DB4218
       call      qword ptr [7FF80BEC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF80C3752C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FF80C774258]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1E665009DE8
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1E665009DD8
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L12:
       mov       r14,1E665009DF0
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L17
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FF80C774AC8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L14:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L19
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FF80C14E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1E665009DD8
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L13
M01_L18:
       mov       rcx,[rbp-118]
       mov       r11,7FF80BD80C10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L19:
       mov       r11,7FF80BD80C08
       call      qword ptr [r11]
       jmp       near ptr M01_L15
M01_L20:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L21
       cmp       [rcx],rdi
       jne       near ptr M01_L61
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
       mov       r12d,[r15+8]
       test      r12,r12
       jle       near ptr M01_L38
M01_L23:
       cmp       esi,[r15+8]
       jae       near ptr M01_L82
       mov       ecx,esi
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L74
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L67
       mov       r8,226F6DACE28
       mov       [rbp-158],r8
       test      r8,r8
       je        near ptr M01_L78
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L78
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
       call      qword ptr [7FF80C176208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FF80C176280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L24:
       mov       rdx,[rbp-160]
M01_L25:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FF80C20E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L26
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L37
M01_L26:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L69
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L46
       mov       rcx,[rax+18]
M01_L27:
       test      rcx,rcx
       je        near ptr M01_L79
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FF80C153A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
M01_L28:
       mov       [rbp-128],rax
       test      dil,dil
       je        short M01_L29
       test      rax,rax
       mov       rax,[rbp-128]
       je        near ptr M01_L37
M01_L29:
       mov       rdx,gs:[58]
       mov       rdx,[rdx+30]
       cmp       dword ptr [rdx+190],3
       jl        near ptr M01_L41
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L40
       mov       r8,[rdx]
       add       r8,10
M01_L30:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L31
       mov       r10,1E669000438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L31
       mov       r10,1E669000418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L70
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
       je        near ptr M01_L47
M01_L33:
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0F8],xmm0
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,226F6DB4240
       call      qword ptr [7FF80BEC6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FF80C3752C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L80
       test      rax,rax
       je        near ptr M01_L81
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FF80BEC4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L73
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
       mov       rcx,1E665009DF8
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L35:
       mov       rcx,1E665009E00
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
       call      qword ptr [7FF80C774AC8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L37:
       add       esi,1
       jo        near ptr M01_L49
       movsxd    rax,esi
       cmp       r12,rax
       jg        near ptr M01_L23
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
       jmp       near ptr M01_L71
M01_L40:
       jmp       near ptr M01_L68
M01_L41:
       jmp       near ptr M01_L68
M01_L42:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L43
       mov       r8,[rbp-98]
       jmp       short M01_L44
M01_L43:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L82
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
       mov       rcx,1E665009DD8
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1E665009E00
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L36
M01_L46:
       xor       ecx,ecx
       jmp       near ptr M01_L27
M01_L47:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FF80C1751B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FF80C175230]; System.MdUtf8String.ToString()
       mov       r11,rax
       mov       [rbp-168],r11
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,r11
       call      CORINFO_HELP_ASSIGN_REF
       mov       r11,[rbp-168]
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L48:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1E665009DD8
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__13_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1E665009DF8
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L35
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,226F6DB41E8
       mov       rdx,226F6DA0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,226F6DA0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L51
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L52
M01_L51:
       mov       ecx,1
M01_L52:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L53
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FF80C126670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FF80C126670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L54:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,226F6DA2730
       mov       rdx,226F6DA0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,226F6DA0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L55
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L56
M01_L55:
       mov       ecx,1
M01_L56:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L57
       call      qword ptr [7FF80C3ACFF0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L57:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L58:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       jmp       near ptr M01_L02
M01_L59:
       mov       r11,7FF80BD80C20
       call      qword ptr [r11]
       jmp       near ptr M01_L08
M01_L60:
       mov       rcx,rax
       mov       r11,7FF80BD80C00
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L61:
       mov       r11,7FF80BD80C18
       call      qword ptr [r11]
       jmp       near ptr M01_L21
M01_L62:
       mov       r15,226F6DA9AA0
       jmp       near ptr M01_L05
M01_L63:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L05
M01_L64:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L06
M01_L65:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M01_L66:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FF80C075848]
       jmp       near ptr M01_L03
M01_L67:
       mov       rcx,rax
       mov       rdx,226F6DACE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L25
M01_L68:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L30
M01_L69:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L28
M01_L70:
       call      qword ptr [7FF80C0A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       mov       [rbp-130],rcx
       mov       rdx,[rbp-120]
       mov       rcx,[rbp-110]
       cmp       [rdx],rcx
       mov       r8,rdx
       je        short M01_L72
M01_L71:
       mov       rcx,r8
       mov       rdx,[r8]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+30]
       mov       r11,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L72:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L73:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L34
M01_L74:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,226F6DB45B8
       mov       rdx,226F6DA0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,226F6DA0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L75
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L76
M01_L75:
       mov       ecx,1
M01_L76:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L77
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L77:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L78:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C40FC48]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF80BECF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C40F630]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80BECF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L80:
       mov       ecx,4
       call      qword ptr [7FF80C124F30]
       int       3
M01_L81:
       mov       ecx,0E
       call      qword ptr [7FF80C124F30]
       int       3
M01_L82:
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
       call      qword ptr [7FF80BEC4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L83
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L83
       mov       r11,7FF80BD80C18
       call      qword ptr [r11]
M01_L83:
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
; Total bytes of code 4075
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+120]
       mov       rdx,290533B0008
       mov       r8d,3A
       mov       r9,290533B8DF0
       call      qword ptr [7FF80C374A08]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,[r14+8]
       test      rdx,rdx
       je        near ptr M01_L12
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BE16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,290533C3018
       xor       edx,edx
       call      qword ptr [7FF80BE16DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L18
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       jne       near ptr M01_L02
M01_L00:
       mov       rdx,290533B0008
       cmp       byte ptr [rsp+0B8],0
       cmove     rdi,rdx
M01_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C3749F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF80C74F438]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r14+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       rbx,rdi
       je        near ptr M01_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L17
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,24FC1400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,24FC1400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rsp+40],rdx
       mov       [rsp+48],r8d
       mov       [rsp+30],r9
       mov       [rsp+38],eax
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       xor       r9d,r9d
       call      qword ptr [7FF80C2F5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L21
M01_L06:
       mov       rcx,[r14+8]
       mov       esi,[rcx+8]
       mov       ebp,[rbx+8]
       mov       r15d,esi
       cmp       r15d,ebp
       jl        short M01_L07
       cmp       esi,ebp
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L22
       sub       ebp,esi
       je        short M01_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF75B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
M01_L08:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r15d
       call      qword ptr [7FF80C90FAF8]
       int       3
M01_L10:
       mov       rax,290533B0008
       jmp       short M01_L08
M01_L11:
       mov       rax,290533B0008
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C3AC3C0]
       mov       rcx,290533C41C0
       mov       rdx,290533B0210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,290533B0008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FF80C3AC4E0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3A7CD8]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3AC660]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80C126670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C3AC0D8]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rbx
       call      qword ptr [7FF80C126670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1266E8]
       int       3
M01_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF75068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L18:
       mov       rdi,290533B5FA0
       jmp       near ptr M01_L01
M01_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L20:
       call      qword ptr [7FF80C0A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1121
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+120]
       mov       rdx,1B904B30008
       mov       r8d,3A
       mov       r9,1B904B38DF0
       call      qword ptr [7FF80C3552D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       ebp,r8d
       mov       rdi,r9
       mov       r14d,[rsp+0B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],bp
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,[r15+8]
       test      rdx,rdx
       je        near ptr M01_L12
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BDF6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,1B904B43018
       xor       edx,edx
       call      qword ptr [7FF80BDF6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L18
       test      rdi,rdi
       jne       near ptr M01_L02
M01_L00:
       mov       rdx,1B904B30008
       test      r14b,r14b
       cmove     rdi,rdx
M01_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C3552C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C83BAF8
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF80C83FB70]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r15+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       rbx,rdi
       je        near ptr M01_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       test      rdx,rdx
       je        near ptr M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L17
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,17876C00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,17876C00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FF80C2C5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L21
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       ebp,[rbx+8]
       mov       r13d,esi
       cmp       r13d,ebp
       jl        short M01_L07
       cmp       esi,ebp
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L22
       sub       ebp,esi
       je        short M01_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rcx,[r12+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF55B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r13d
       call      qword ptr [7FF80C8FFAF8]
       int       3
M01_L10:
       mov       rax,1B904B30008
       jmp       short M01_L08
M01_L11:
       mov       rax,1B904B30008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C38CED0]
       mov       rcx,1B904B441E8
       mov       rdx,1B904B30210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1B904B30008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FF80C38CFF0]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C7F8]
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38CBE8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80C38D170]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C38CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r13
       call      qword ptr [7FF80C106670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD54000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1066E8]
       int       3
M01_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF55068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L18:
       mov       rdi,1B904B35FA0
       jmp       near ptr M01_L01
M01_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L20:
       call      qword ptr [7FF80C084030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1144
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+130]
       mov       rdx,28325760008
       mov       r8d,3A
       mov       r9,28325768DF0
       call      qword ptr [7FF80C3452D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 105
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       ebp,r8d
       mov       rdi,r9
       mov       r14d,[rsp+0B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],bp
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,[r15+8]
       test      rdx,rdx
       je        near ptr M01_L12
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BDE6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,28325773018
       xor       edx,edx
       call      qword ptr [7FF80BDE6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L18
       test      rdi,rdi
       jne       near ptr M01_L02
M01_L00:
       mov       rdx,28325760008
       test      r14b,r14b
       cmove     rdi,rdx
M01_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C3452C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C82BD68
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF80C82FDE0]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r15+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       rbx,rdi
       je        near ptr M01_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       test      rdx,rdx
       je        near ptr M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L17
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,24293800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,24293800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r14,rdx
       mov       edx,[rbx+8]
       lea       r8,[rdi+0C]
       mov       r9d,[rdi+8]
       mov       [rsp+38],r14
       mov       [rsp+40],edx
       mov       [rsp+28],r8
       mov       [rsp+30],r9d
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FF80C2B5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L21
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       ebp,[rbx+8]
       mov       r13d,esi
       cmp       r13d,ebp
       jl        short M01_L07
       cmp       esi,ebp
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L22
       sub       ebp,esi
       je        short M01_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rcx,[r12+0C]
       add       rbx,0C
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF45B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r13d
       call      qword ptr [7FF80C88E658]
       int       3
M01_L10:
       mov       rax,28325760008
       jmp       short M01_L08
M01_L11:
       mov       rax,28325760008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C37CED0]
       mov       rcx,28325774210
       mov       rdx,28325760210
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,28325760008
       call      qword ptr [7FF80BE96B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FF80C37CFF0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FF80C200928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C37C7F8]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C37CBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C37D170]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BE97318]; System.String.Trim()
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF80C37CBE8]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,rbx
       call      qword ptr [7FF80C0F6670]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD44000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C0F66E8]
       int       3
M01_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF45068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L18:
       mov       rdi,28325765FA0
       jmp       near ptr M01_L01
M01_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L20:
       call      qword ptr [7FF80C074030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1149
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       dword ptr [rsp+28],1
       mov       rcx,[rbx+130]
       mov       rdx,24914110008
       mov       r8d,3A
       mov       r9,24914118DF0
       call      qword ptr [7FF80C364A08]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
; Total bytes of code 103
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
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
       mov       ebp,r8d
       mov       rdi,r9
       mov       r14d,[rsp+0B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],bp
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,[r15+8]
       test      rdx,rdx
       je        near ptr M01_L12
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,24914123018
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L18
       test      rdi,rdi
       jne       near ptr M01_L02
M01_L00:
       mov       rdx,24914110008
       test      r14b,r14b
       cmove     rdi,rdx
M01_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C3649F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C84B930
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF80C84F9A8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdi,[r15+8]
       cmp       [rbx],bl
       test      rdi,rdi
       je        near ptr M01_L16
       cmp       rbx,rdi
       je        near ptr M01_L06
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       test      rdx,rdx
       je        near ptr M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L17
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,20882000438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,20882000418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rdi+0C]
       mov       eax,[rdi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FF80C2E5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L21
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       ebp,[rbx+8]
       mov       r13d,esi
       cmp       r13d,ebp
       jl        short M01_L07
       cmp       esi,ebp
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L22
       sub       ebp,esi
       je        short M01_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rcx,[r12+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r13d
       call      qword ptr [7FF80C90F9C0]
       int       3
M01_L10:
       mov       rax,24914110008
       jmp       short M01_L08
M01_L11:
       mov       rax,24914110008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,249141241C0
       mov       rdx,24914110210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24914110008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FF80C39C4E0]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r13
       call      qword ptr [7FF80C116670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
       int       3
M01_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L18:
       mov       rdi,24914115FA0
       jmp       near ptr M01_L01
M01_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L20:
       call      qword ptr [7FF80C094030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L21:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1144
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       test      rcx,rcx
       je        short M00_L01
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       rdx,2FD78630008
       mov       r8d,3A
       mov       r9,2FD78638DF0
       call      qword ptr [7FF80C364A08]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
M00_L00:
       mov       [rsp+38],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,40
       pop       rbx
       ret
M00_L01:
       mov       rax,2FD78630008
       jmp       short M00_L00
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ebp,r8d
       mov       rdi,r9
       mov       r14d,[rsp+0B8]
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+10],bp
       test      rbx,rbx
       je        near ptr M01_L11
       mov       rdx,[r15+8]
       test      rdx,rdx
       je        near ptr M01_L12
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,2FD78643018
       xor       edx,edx
       call      qword ptr [7FF80BE06DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L18
       test      rdi,rdi
       jne       near ptr M01_L03
M01_L00:
       mov       rdx,2FD78630008
       test      r14b,r14b
       cmove     rdi,rdx
M01_L01:
       movzx     r8d,byte ptr [rsp+0B0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80C3649F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FF80C84BAF8
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FF80C84FB70]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rbx,[r15+8]
       cmp       [rsi],sil
       test      rbx,rbx
       je        near ptr M01_L16
       cmp       rsi,rbx
       jne       short M01_L04
M01_L02:
       mov       rcx,[r15+8]
       mov       edi,[rcx+8]
       mov       ebp,[rsi+8]
       mov       r13d,edi
       cmp       r13d,ebp
       jl        near ptr M01_L07
       cmp       edi,ebp
       jg        near ptr M01_L09
       jmp       near ptr M01_L07
M01_L03:
       test      rdx,rdx
       je        near ptr M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       je        near ptr M01_L17
       jmp       near ptr M01_L00
M01_L04:
       cmp       dword ptr [rbx+8],0
       je        short M01_L02
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L19
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L19
       mov       rax,[rcx]
       add       rax,10
M01_L05:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L06
       mov       rcx,2BCEA800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L06
       mov       rcx,2BCEA800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L20
M01_L06:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       r14,[rsi+0C]
       mov       edx,[rsi+8]
       lea       r8,[rbx+0C]
       mov       r9d,[rbx+8]
       mov       [rsp+40],r14
       mov       [rsp+48],edx
       mov       [rsp+30],r8
       mov       [rsp+38],r9d
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       xor       r9d,r9d
       call      qword ptr [7FF80C2E5200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L21
       jmp       near ptr M01_L02
M01_L07:
       test      edi,edi
       je        near ptr M01_L22
       sub       ebp,edi
       je        short M01_L10
       mov       ecx,ebp
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       add       rsi,0C
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,edi
       lea       rdx,[rsi+r8*2]
       movsxd    r8,ebp
       add       r8,r8
       call      qword ptr [7FF80BF65B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,ebp
       mov       ecx,r13d
       call      qword ptr [7FF80C90FAF8]
       int       3
M01_L10:
       mov       rax,2FD78630008
       jmp       short M01_L08
M01_L11:
       mov       rax,2FD78630008
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FF80C39C3C0]
       mov       rcx,2FD786441E8
       mov       rdx,2FD78630210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2FD78630008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L13
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L14
M01_L13:
       mov       ecx,1
M01_L14:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L15
       call      qword ptr [7FF80C39C4E0]
       mov       r14,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C397CD8]
       mov       r15,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39C0D8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80C39C660]
       mov       r8,rax
       mov       rdx,r15
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C39C0D8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r13
       call      qword ptr [7FF80C116670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FF80BD64000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C1166E8]
       int       3
M01_L17:
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FF80BF65068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        near ptr M01_L00
M01_L18:
       mov       rdi,2FD78635FA0
       jmp       near ptr M01_L01
M01_L19:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L05
M01_L20:
       call      qword ptr [7FF80C094030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L06
M01_L21:
       mov       rax,rsi
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L22:
       mov       rax,rsi
       jmp       near ptr M01_L08
; Total bytes of code 1138
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       call      qword ptr [7FF80C384C30]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C355320]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
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
       mov       rax,1F60E40A7C8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FF80C3851D0]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
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
       mov       rcx,1F60E40A7C8
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M02_L06
M02_L00:
       cmp       byte ptr [rbx+8D],0
       jne       short M02_L01
       mov       rcx,rbx
       call      qword ptr [7FF80C385128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FF80C5D6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,1F612401F48
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF80C754D38]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       call      qword ptr [7FF80BEA43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L05:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,236A0452D10
       mov       r8d,1
       call      qword ptr [7FF80C384B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L06:
       call      qword ptr [7FF80C3851D0]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
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
       call      qword ptr [7FF80C38CED0]
       mov       rcx,236A0452730
       mov       rdx,236A0450210
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,236A0450008
       call      qword ptr [7FF80BEA6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M02_L09
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M02_L10
M02_L09:
       mov       ecx,1
M02_L10:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M02_L11
       call      qword ptr [7FF80C38CFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C210928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C38C7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C38CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C38D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C106670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L11:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEA7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C38CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C106670]
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
       call      qword ptr [7FF80C72FEA0]
       mov       [rbp-38],rax
       lea       rax,[M02_L07]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 783
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FF80C365308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,187E5C09CC0
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF80C395128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FF80C394B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5E6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FF80C39CED0]
       mov       rcx,1C877C62730
       mov       rdx,1C877C60210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1C877C60008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FF80C39CFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C220928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C39C7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39D170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C116670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39CBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FF80BEB43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FF80C375308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       je        short M01_L02
       mov       [rsp+28],rcx
       mov       rcx,1B63C40BCB8
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FF80C3A5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FF80C3A4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FF80C5F6460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FF80C3ACED0]
       mov       rcx,1F6CE272730
       mov       rdx,1F6CE270210
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F6CE270008
       call      qword ptr [7FF80BEC6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L03
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L04
M01_L03:
       mov       ecx,1
M01_L04:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L05
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C126670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FF80BEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C874990]; System.Data.DataTable..ctor()
       mov       rcx,2362F324210
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF80C365368]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,2362F310008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,2362F3242B0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,2362F324388
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,2362F3243A0
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2362F3243B8
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2362F3243D0
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FF80BDF5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FF80C883058
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FF80C13C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1F59D40F420
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
       mov       rdx,2362F324230
       call      qword ptr [7FF80BEB6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80BF676D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80C87CF00]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF80C094180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80C877240]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,2362F31C760
       mov       [rax+8],rcx
       lea       rcx,[rsi+10]
       mov       rdx,rax
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
       call      qword ptr [7FF80C87C048]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,2362F324460
       mov       [rax+8],rcx
       lea       rcx,[rbx+58]
       mov       rdx,rax
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
; Total bytes of code 876
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
       je        near ptr M02_L04
       mov       rdx,rbx
       mov       rcx,offset MT_System.IAsyncDisposable
       call      qword ptr [7FF80BEB4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L02
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF80C885520]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L03
M02_L00:
       call      qword ptr [7FF80C8D49A8]
       mov       rbx,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C39CDE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C39D170]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C116718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L01:
       mov       rcx,rbx
       mov       r11,7FF80BD70DE0
       call      qword ptr [r11]
       jmp       short M02_L03
M02_L02:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FF80BD70DE8
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FF80C8D4210]
       test      eax,eax
       jne       short M02_L00
M02_L03:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L04:
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
       je        short M02_L05
       call      CORINFO_HELP_RETHROW
M02_L05:
       lea       rax,[M02_L03]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 283
```

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.FromJson()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
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
       je        near ptr M00_L08
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,2DCEF8091A0
       mov       rdi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L09
       cmp       byte ptr [rdi+8D],0
       je        short M00_L03
M00_L02:
       mov       rbp,[rdi+10]
       test      rbp,rbp
       je        short M00_L04
       mov       rcx,[rbp+0B8]
       mov       r9,31D81762928
       cmp       rcx,r9
       je        short M00_L05
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF80C3A5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       short M00_L02
M00_L04:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,31D81762928
       mov       r8d,1
       call      qword ptr [7FF80C3A4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L05:
       mov       rdx,rbp
       mov       r8,rdx
       test      r8,r8
       jne       short M00_L07
M00_L06:
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],ecx
       lea       rdx,[rsp+38]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FF80C894B88]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]]
       cmp       [r8],rcx
       je        short M00_L06
       call      qword ptr [7FF80BEC43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L08:
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FF80C354F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FF80C230928
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF80C3AC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       ecx,3174
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECB58]
       int       3
; Total bytes of code 534
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
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FF80C6DF630]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FF80C6DF630]
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
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       call      qword ptr [7FF875FC5068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M02_L03
       call      qword ptr [7FF875FC9F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M02_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
M02_L00:
       mov       byte ptr [rbx+8C],1
       mov       byte ptr [rbx+8D],1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       call      qword ptr [7FF875FC69F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       call      qword ptr [7FF875FC5060]
       cmp       byte ptr [rax+18E],0
       je        short M02_L00
       mov       ecx,2
       call      qword ptr [7FF875FC6948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FF875FC9FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FF875FC4FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L00
       cmp       [rsi+10],rbx
       je        short M02_L02
       mov       rcx,[rsi+10]
       cmp       byte ptr [rcx+8D],0
       jne       short M02_L02
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF875FC9198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L00
M02_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FF875FC4820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L04
       call      qword ptr [7FF875FC6A08]
       test      rax,rax
       je        near ptr M02_L00
M02_L04:
       call      qword ptr [7FF875FC84A0]
       int       3
; Total bytes of code 272
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       [rsp+68],r9
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       xor       ebp,ebp
       cmp       byte ptr [rbx+8C],0
       je        near ptr M03_L08
       mov       r14,[rbx+8]
       test      r14,r14
       je        near ptr M03_L07
M03_L00:
       cmp       [r14],r14b
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80C495590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
       cmp       byte ptr [rsp+78],0
       jne       near ptr M03_L12
M03_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       near ptr M03_L13
       mov       rbp,[rax+8]
M03_L02:
       test      dil,dil
       je        short M03_L03
       test      rbp,rbp
       je        short M03_L06
       mov       rcx,7FF80C8B65C0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M03_L05
M03_L03:
       test      rbp,rbp
       je        near ptr M03_L09
M03_L04:
       mov       rcx,7FF80C8B65D0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L05:
       mov       rcx,rbp
       call      qword ptr [7FF80C495470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L03
M03_L06:
       mov       rcx,7FF80C8B65C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L03
M03_L07:
       mov       rcx,rbx
       call      qword ptr [7FF80C4954A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L08:
       cmp       byte ptr [rsp+70],0
       je        short M03_L11
       mov       rcx,7FF80C8B65C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80C3A5140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
       mov       rbp,rax
       jmp       near ptr M03_L03
M03_L09:
       movzx     ecx,byte ptr [rsp+68]
       movzx     eax,byte ptr [rsp+69]
       cmp       al,1
       sete      al
       movzx     eax,al
       test      ecx,eax
       je        short M03_L10
       mov       rcx,7FF80C8B65CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF80C4ED9F8]
       int       3
M03_L10:
       mov       rcx,7FF80C8B65D4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L04
M03_L11:
       mov       rcx,7FF80C8B65D8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L03
M03_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M03_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FF80C4955C0]
       mov       rbp,rax
       jmp       near ptr M03_L02
M03_L13:
       call      qword ptr [7FF80C89DFC8]
       int       3
; Total bytes of code 397
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,238
       vzeroupper
       lea       rbp,[rsp+270]
       xor       eax,eax
       mov       [rbp-228],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M04_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M04_L00
       mov       [rbp-40],rax
       mov       [rbp-240],rsp
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp-220],rcx
       cmp       edi,55555
       ja        short M04_L03
       mov       rdx,2DCF3801E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FF80C42C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
M04_L01:
       test      rax,rax
       je        near ptr M04_L09
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M04_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       jmp       short M04_L04
M04_L03:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FF80C404F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       jmp       short M04_L01
M04_L04:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FF80C404F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M04_L07
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
       movzx     r9d,byte ptr [rcx+85]
       movzx     r8d,byte ptr [rcx+84]
       cmp       r8d,2
       jg        short M04_L06
       mov       ecx,[rcx+7C]
       test      ecx,ecx
       jl        short M04_L05
       jmp       short M04_L08
M04_L05:
       mov       ecx,318C
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECB70]
       int       3
M04_L06:
       mov       ecx,318C
       mov       rdx,7FF80C39A168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF80C4ECBA0]
       int       3
M04_L07:
       call      qword ptr [7FF80C0FE9A0]
       int       3
M04_L08:
       xor       r10d,r10d
       mov       [rbp-70],r10
       mov       [rbp-68],r10
       mov       byte ptr [rbp-60],0
       mov       byte ptr [rbp-5F],0
       mov       byte ptr [rbp-5E],0
       mov       byte ptr [rbp-5D],0
       mov       byte ptr [rbp-5C],0
       mov       byte ptr [rbp-5B],0
       mov       [rbp-58],ecx
       mov       [rbp-54],r8b
       mov       [rbp-53],r9b
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-50],xmm0
       vmovdqu   xmmword ptr [rbp-48],xmm0
       mov       [rbp-218],rdx
       mov       [rbp-210],eax
       lea       rdx,[rbp-218]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-70]
       mov       r8d,1
       call      qword ptr [7FF80C566688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80C567750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FF80C44F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       r13,rax
       mov       [rbp-228],r13
       mov       rcx,rsp
       call      M04_L10
       nop
       mov       rax,[rbp-228]
       add       rsp,238
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L09:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M04_L02
M04_L10:
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
       lea       rbp,[rbp+270]
       cmp       qword ptr [rbp-220],0
       je        near ptr M04_L34
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M04_L12
       cmp       rdx,300
       ja        short M04_L11
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M04_L12
M04_L11:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FF80BF75BA8]
M04_L12:
       mov       rcx,2DCF3801E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FF80BE05120
       mov       edx,2F
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L13
       mov       rcx,r13
       call      qword ptr [7FF80C446310]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M04_L13:
       xor       ebx,ebx
       mov       esi,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M04_L29
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M04_L14
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FF80C435AD0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FF80BD74000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FF80BECF750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M04_L14:
       mov       edx,r12d
       shl       rdx,4
       lea       r14,[rcx+rdx+10]
       mov       rdi,[r14]
       mov       rdx,[rbp-220]
       mov       rcx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [r14+8],eax
       test      rdi,rdi
       je        near ptr M04_L29
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M04_L16
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L15
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FF80C446298]
M04_L15:
       mov       rsi,[rax+8]
       mov       rcx,7FF80BE05120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FF80BE05C38],0
       je        short M04_L17
       call      qword ptr [7FF80BECDC98]
       mov       r14d,eax
       jmp       short M04_L20
M04_L16:
       call      CORINFO_HELP_RNGCHKFAIL
M04_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14d,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[r14-1]
       mov       [rax+0A3C],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M04_L18
       call      qword ptr [7FF80C75C9A8]
       jmp       short M04_L19
M04_L18:
       mov       eax,r14d
       sar       eax,10
M04_L19:
       mov       r14d,eax
M04_L20:
       mov       rcx,7FF80BE05120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FF80BE05C2C]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       near ptr M04_L27
M04_L21:
       cmp       r14d,[rsi+8]
       jae       short M04_L16
       mov       ecx,r14d
       mov       rax,[rsi+rcx*8+10]
       mov       [rbp-230],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-1DC],edx
       mov       rcx,rax
       call      System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp-230]
       mov       rcx,[rax+8]
       mov       r10d,[rax+10]
       mov       [rbp-1E0],r10d
       cmp       [rcx+8],r10d
       jbe       short M04_L23
       test      r10d,r10d
       jne       short M04_L24
       xor       edx,edx
       mov       [rax+14],edx
M04_L22:
       movsxd    rdx,r10d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M04_L23:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M04_L25
       mov       ecx,1
       jmp       short M04_L28
M04_L24:
       jmp       short M04_L22
M04_L25:
       inc       r14d
       cmp       [rsi+8],r14d
       jne       short M04_L26
       xor       r14d,r14d
M04_L26:
       inc       r15d
M04_L27:
       cmp       [rsi+8],r15d
       jg        near ptr M04_L21
       xor       ecx,ecx
M04_L28:
       mov       esi,ecx
M04_L29:
       mov       rax,2DCF38005D0
       mov       r14,[rax]
       cmp       byte ptr [r14+9D],0
       je        near ptr M04_L34
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M04_L34
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r15d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,edi
       mov       r9d,r15d
       mov       edx,3
       call      qword ptr [7FF80BF77678]
       test      esi,ebx
       jne       short M04_L34
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       esi,eax
       mov       rcx,[rbp-220]
       mov       edi,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M04_L30
       mov       ecx,0FFFFFFFF
       jmp       short M04_L31
M04_L30:
       mov       ecx,r12d
M04_L31:
       mov       edx,esi
       mov       r8d,edi
       mov       r9d,eax
       test      ebx,ebx
       jne       short M04_L32
       mov       eax,1
       jmp       short M04_L33
M04_L32:
       xor       eax,eax
M04_L33:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,r14
       call      qword ptr [7FF80C20F360]
M04_L34:
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
; Total bytes of code 1597
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rax,[rdx]
M05_L00:
       mov       rax,[rax+10]
       cmp       rax,rcx
       jne       short M05_L02
M05_L01:
       mov       rax,rdx
       ret
M05_L02:
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       je        short M05_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M05_L01
       test      rax,rax
       jne       short M05_L00
M05_L03:
       jmp       qword ptr [7FF80BEC43A8]
; Total bytes of code 69
```
```assembly
; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,r9
       test      rbx,rbx
       je        short M06_L00
       mov       ecx,[rbx+8]
       xor       eax,eax
       test      ecx,ecx
       sete      al
       xor       edi,edi
       test      eax,eax
       sete      dil
       test      ecx,ecx
       jne       short M06_L01
       jmp       near ptr M06_L08
M06_L00:
       xor       edi,edi
       jmp       near ptr M06_L08
M06_L01:
       test      edi,edi
       je        near ptr M06_L09
M06_L02:
       test      dl,dl
       je        near ptr M06_L15
       mov       esi,[rbx+8]
       test      esi,esi
       je        short M06_L06
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jae       short M06_L03
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M06_L16
       jmp       short M06_L04
M06_L03:
       call      qword ptr [7FF80C6DF630]
       test      eax,eax
       jne       near ptr M06_L16
M06_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L05
       mov       rax,7FF855822C00
       test      byte ptr [rcx+rax],80
       jne       near ptr M06_L16
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FF80C6DF630]
       test      eax,eax
       jne       near ptr M06_L16
M06_L06:
       mov       rax,rbx
M06_L07:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L08:
       test      r8,r8
       je        near ptr M06_L01
       xor       eax,eax
       cmp       dword ptr [r8+8],0
       sete      al
       test      eax,eax
       jne       near ptr M06_L01
       mov       rbx,r8
       jmp       near ptr M06_L02
M06_L09:
       call      qword ptr [7FF80C3ACFF0]
       mov       rbx,rax
       test      rsi,rsi
       je        short M06_L10
       xor       eax,eax
       cmp       dword ptr [rsi+8],0
       sete      al
       test      eax,eax
       jne       short M06_L10
       jmp       short M06_L11
M06_L10:
       mov       rsi,rbx
M06_L11:
       mov       rbx,[rsp+60]
       test      rbx,rbx
       je        short M06_L12
       xor       eax,eax
       cmp       dword ptr [rbx+8],0
       sete      al
       jmp       short M06_L13
M06_L12:
       mov       eax,1
M06_L13:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M06_L14
       call      qword ptr [7FF80C3ACFF0]
       mov       rcx,rax
       mov       rdx,31D81763C30
       call      qword ptr [7FF80C3AD200]
M06_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEC7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF80C3ACBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80C3AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF80C126670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L16:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF80BEC73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M06_L07
; Total bytes of code 420
```

