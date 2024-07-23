## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF824F43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FFF829DCED0]
       mov       rcx,21B15A82730
       mov       rdx,21B15A80210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21B15A80008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829DCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L03:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
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
       jmp       qword ptr [7FFF824F43A8]
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,21B15A80008
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L01
M03_L00:
       call      qword ptr [7FFF82CD7C18]
       test      eax,eax
       jne       short M03_L04
M03_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M03_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M03_L04
       jmp       short M03_L03
M03_L02:
       call      qword ptr [7FFF82CD7C18]
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
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF824F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L11
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>)
       call      qword ptr [7FFF82EC48B8]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M00_L12
M00_L00:
       call      qword ptr [7FFF829A5308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,1D08B009110
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
       mov       r8,2111D044210
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
       call      qword ptr [7FFF82EC61D8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]][], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>[] ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82EC6250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF829D5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L03
M00_L08:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,2111D044210
       mov       r8d,1
       call      qword ptr [7FFF829D4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L04
M00_L09:
       call      qword ptr [7FFF824F43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M00_L11:
       mov       rcx,rax
       mov       r11,7FFF823B0F10
       call      qword ptr [r11]
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L00
M00_L12:
       call      qword ptr [7FFF829DCED0]
       mov       rcx,2111D032730
       mov       rdx,2111D030210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2111D030008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829DCFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829DD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L16:
       call      qword ptr [7FFF829DCFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFF82984F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L17:
       mov       ecx,3174
       mov       rdx,7FFF829CA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B1CB58]
       int       3
; Total bytes of code 959
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
       jmp       qword ptr [7FFF824F4378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       mov       rdx,7FFF82F4A788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFF824F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFF82F4A988
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
       mov       rdx,7FFF82F4A9A0
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
       mov       rdx,7FFF82F4AAB0
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
       mov       rdx,7FFF82F4A978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF82F6DB00]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FFF82F4A978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFF82F6DB78]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFF82F4A978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFF82F6DC08]
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
       mov       rdx,7FFF82F4AAE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FFF82954750]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       mov       rcx,1D08B009C30
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M03_L00
       mov       rcx,rbx
       call      qword ptr [7FFF829D5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M03_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF829D4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M03_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M03_L06
M03_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF82C26460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L02:
       call      qword ptr [7FFF829DCED0]
       mov       rcx,2111D032730
       mov       rdx,2111D030210
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2111D030008
       call      qword ptr [7FFF824F6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829DCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828608A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829DC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829DD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82756670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L06:
       mov       rdx,rax
       call      qword ptr [7FFF824F43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFF82D3D278]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFF82D3D278]
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
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF82A34F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFF82A34F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       mov       rdx,7FFF829CA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B1CB70]
       int       3
M05_L04:
       mov       ecx,318C
       mov       rdx,7FFF829CA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B1CBA0]
       int       3
M05_L05:
       call      qword ptr [7FFF8272E9A0]
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
       call      qword ptr [7FFF82B96688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       lea       rcx,[rbp-1B8]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82B97750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rsi+138]
       mov       r8,[rsi+0B0]
       lea       rdx,[rbp-118]
       lea       r9,[rbp-1B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82A7F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rbx,rax
       cmp       qword ptr [rbp-1F8],0
       je        short M05_L07
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FFF825A5278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1D08F001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FFF82A5C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rcx,1D08F001E48
       mov       rcx,[rcx]
       call      qword ptr [7FFF82A5C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFF825A5278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1D08F001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FFF82A5C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFFE6815068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M07_L03
       call      qword ptr [7FFFE6819F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M07_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE68169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M07_L00
       call      qword ptr [7FFFE6815060]
       cmp       byte ptr [rax+18E],0
       je        short M07_L00
       mov       ecx,2
       call      qword ptr [7FFFE6816948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFFE6819FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE6819198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M07_L00
M07_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFFE6814820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M07_L00
M07_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M07_L04
       call      qword ptr [7FFFE6816A08]
       test      rax,rax
       je        near ptr M07_L00
M07_L04:
       call      qword ptr [7FFFE68184A0]
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
       call      qword ptr [7FFF82AC5590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFF82EE3810
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M08_L05
M08_L03:
       test      rbp,rbp
       je        near ptr M08_L09
M08_L04:
       mov       rcx,7FFF82EE3820
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
       call      qword ptr [7FFF82AC5470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M08_L03
M08_L06:
       mov       rcx,7FFF82EE3814
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L03
M08_L07:
       mov       rcx,rbx
       call      qword ptr [7FFF82AC54A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M08_L00
M08_L08:
       cmp       byte ptr [rsp+70],0
       je        short M08_L11
       mov       rcx,7FFF82EE3818
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF829D5140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
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
       mov       rcx,7FFF82EE381C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFF82B1D9F8]
       int       3
M08_L10:
       mov       rcx,7FFF82EE3824
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L04
M08_L11:
       mov       rcx,7FFF82EE3828
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L03
M08_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M08_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFF82AC55C0]
       mov       rbp,rax
       jmp       near ptr M08_L02
M08_L13:
       call      qword ptr [7FFF82EC71E0]
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
       jmp       qword ptr [7FFF824F43A8]
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
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF825A5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8272EF10]
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
       mov       rax,2111D030008
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M11_L16
       jmp       short M11_L04
M11_L03:
       call      qword ptr [7FFF82D3D278]
       test      eax,eax
       jne       near ptr M11_L16
M11_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M11_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M11_L16
       jmp       short M11_L06
M11_L05:
       call      qword ptr [7FFF82D3D278]
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
       call      qword ptr [7FFF829DCFF0]
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
       call      qword ptr [7FFF829DCFF0]
       mov       rcx,rax
       mov       rdx,2111D043C30
       call      qword ptr [7FFF829DD200]
M11_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824F7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829DCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829DD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82756670]
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
       call      qword ptr [7FFF824F73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M11_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF82985308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,1F98980B108
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
       mov       r8,23A1B9741C0
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
       call      qword ptr [7FFF82E954E8]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address>> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82E95560]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF829B5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,23A1B9741C0
       mov       r8d,1
       call      qword ptr [7FFF829B4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FFF824D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L09:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,23A1B962730
       mov       rdx,23A1B960210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23A1B960008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFF82964F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       ecx,3174
       mov       rdx,7FFF829AA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82AFCB58]
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
       mov       rcx,1F98980BC28
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFF829B5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF829B4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF82C06460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,23A1B962730
       mov       rdx,23A1B960210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,23A1B960008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFF824D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FFF82D1D278]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       ecx,ecx
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFF82D1D278]
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
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 137
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
       call      qword ptr [7FFF82A14F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFF82A14F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       mov       rdx,7FFF829AA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82AFCB70]
       int       3
M03_L04:
       mov       ecx,318C
       mov       rdx,7FFF829AA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82AFCBA0]
       int       3
M03_L05:
       call      qword ptr [7FFF8270E9A0]
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
       call      qword ptr [7FFF82B76688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       lea       rcx,[rbp-1B8]
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFF82B77750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rsi+138]
       mov       r8,[rsi+0B0]
       lea       rdx,[rbp-118]
       lea       r9,[rbp-1B8]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82A5F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rbx,rax
       cmp       qword ptr [rbp-1F8],0
       je        short M03_L07
       mov       edx,[rbp-1BC]
       mov       rcx,[rbp-200]
       call      qword ptr [7FFF82585278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1F989801E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FFF82A3C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rcx,1F989801E48
       mov       rcx,[rcx]
       call      qword ptr [7FFF82A3C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFF82585278]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,1F989801E48
       mov       rcx,[rcx]
       mov       rdx,[rbp-1F8]
       xor       r8d,r8d
       call      qword ptr [7FFF82A3C3F0]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       call      qword ptr [7FFFE6815068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M05_L03
       call      qword ptr [7FFFE6819F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE68169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M05_L00
       call      qword ptr [7FFFE6815060]
       cmp       byte ptr [rax+18E],0
       je        short M05_L00
       mov       ecx,2
       call      qword ptr [7FFFE6816948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFFE6819FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE6819198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M05_L00
M05_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFFE6814820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M05_L04
       call      qword ptr [7FFFE6816A08]
       test      rax,rax
       je        near ptr M05_L00
M05_L04:
       call      qword ptr [7FFFE68184A0]
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
       call      qword ptr [7FFF82AA5590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFF82EC1E30
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M06_L05
M06_L03:
       test      rbp,rbp
       je        near ptr M06_L09
M06_L04:
       mov       rcx,7FFF82EC1E40
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
       call      qword ptr [7FFF82AA5470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M06_L03
M06_L06:
       mov       rcx,7FFF82EC1E34
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L03
M06_L07:
       mov       rcx,rbx
       call      qword ptr [7FFF82AA54A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L00
M06_L08:
       cmp       byte ptr [rsp+70],0
       je        short M06_L11
       mov       rcx,7FFF82EC1E38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF829B5140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
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
       mov       rcx,7FFF82EC1E3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFF82AFD9F8]
       int       3
M06_L10:
       mov       rcx,7FFF82EC1E44
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,7FFF82EC1E48
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L03
M06_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M06_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFF82AA55C0]
       mov       rbp,rax
       jmp       near ptr M06_L02
M06_L13:
       call      qword ptr [7FFF82E96EE0]
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
       jmp       qword ptr [7FFF824D43A8]
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
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8270EF10]
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
       mov       rax,23A1B960008
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L04
M09_L03:
       call      qword ptr [7FFF82D1D278]
       test      eax,eax
       jne       near ptr M09_L16
M09_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M09_L16
       jmp       short M09_L06
M09_L05:
       call      qword ptr [7FFF82D1D278]
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
       call      qword ptr [7FFF829BCFF0]
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
       call      qword ptr [7FFF829BCFF0]
       mov       rcx,rax
       mov       rdx,23A1B974918
       call      qword ptr [7FFF829BD200]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
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
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M09_L07
; Total bytes of code 420
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF82995308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,280358025A8
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
       mov       r8,2C0C7972928
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
       call      qword ptr [7FFF82EA4B88]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       [rsp+50],rax
       mov       rcx,[rbx+18]
       lea       r8,[rsp+50]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.Person`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]], DotNetTips.Spargine.8.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.Person`1<DotNetTips.Spargine.Tester.Models.RefTypes.Address> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF82EA4BE8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF829C5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M00_L02
M00_L07:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,2C0C7972928
       mov       r8d,1
       call      qword ptr [7FFF829C4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rbp,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L08:
       call      qword ptr [7FFF824E43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L09:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,2C0C7962730
       mov       rdx,2C0C7960210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C0C7960008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbp,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbp
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L12:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L13:
       call      qword ptr [7FFF829CCFF0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFF82974F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L14:
       mov       ecx,3174
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0CB58]
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
       mov       rcx,280358030C8
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFF829C5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF829C4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF82C16A60]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,2C0C7962730
       mov       rdx,2C0C7960210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2C0C7960008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFF824E43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L01
M02_L00:
       call      qword ptr [7FFF82D2DA58]
       test      eax,eax
       jne       short M02_L04
M02_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M02_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       call      qword ptr [7FFF82D2DA58]
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
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       xor       edx,edx
       mov       [rbp-220],rdx
       cmp       edi,55555
       ja        near ptr M03_L07
       mov       rdx,28039801E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFF82A4C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-220],rax
       test      rax,rax
       je        near ptr M03_L08
M03_L01:
       lea       r14,[rax+10]
       mov       r15d,[rax+8]
M03_L02:
       mov       [rbp-238],r14
       mov       [rbp-1E4],r15d
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       mov       rcx,[rbp-238]
       mov       [rbp-208],rcx
       mov       ecx,[rbp-1E4]
       mov       [rbp-200],ecx
       lea       rcx,[rbp-1F8]
       lea       rdx,[rbp-208]
       call      qword ptr [7FFF82A24F30]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,[rbp-1E4]
       ja        short M03_L05
       mov       rdx,[rbp-238]
       mov       [rbp-238],rdx
       mov       [rbp-1E4],eax
       mov       rcx,[rbx+0B0]
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
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0CB70]
       int       3
M03_L04:
       mov       ecx,318C
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0CBA0]
       int       3
M03_L05:
       call      qword ptr [7FFF8271E9A0]
       int       3
M03_L06:
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
       call      qword ptr [7FFF82B86688]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF82B87750]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82A6F438]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       r13,rax
       mov       [rbp-228],r13
       mov       rcx,rsp
       call      M03_L09
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
M03_L07:
       mov       [rbp-1F8],rsi
       mov       [rbp-1F0],edi
       lea       rcx,[rbp-1F8]
       call      qword ptr [7FFF82A24F18]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       test      rax,rax
       jne       near ptr M03_L01
M03_L08:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M03_L02
M03_L09:
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
       je        near ptr M03_L33
       mov       rcx,[rbp-238]
       mov       edx,[rbp-1E4]
       mov       [rbp-1D8],rdx
       test      rdx,rdx
       je        short M03_L11
       cmp       rdx,300
       ja        short M03_L10
       xor       edx,edx
       mov       r8d,[rbp-1D8]
       call      CORINFO_HELP_MEMSET
       jmp       short M03_L11
M03_L10:
       mov       rdx,[rbp-1D8]
       call      qword ptr [7FFF82595BA8]
M03_L11:
       mov       rcx,28039801E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFF82425120
       mov       edx,2F
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M03_L12
       mov       rcx,r13
       call      qword ptr [7FFF82A66310]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       rcx,rax
M03_L12:
       xor       ebx,ebx
       mov       r15d,1
       mov       edx,[rcx+8]
       cmp       edx,r12d
       jbe       near ptr M03_L28
       mov       ebx,1
       mov       rdx,[rbp-220]
       mov       eax,10
       shlx      eax,eax,r12d
       cmp       [rdx+8],eax
       je        short M03_L13
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFF82A55AD0]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFF824EF750]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M03_L13:
       mov       edx,r12d
       shl       rdx,4
       lea       rsi,[rcx+rdx+10]
       mov       r14,[rsi]
       mov       rdx,[rbp-220]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],eax
       test      r14,r14
       je        near ptr M03_L28
       mov       rcx,[r13+10]
       cmp       r12d,[rcx+8]
       jae       short M03_L15
       mov       edx,r12d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L14
       mov       rcx,r13
       mov       edx,r12d
       call      qword ptr [7FFF82A66298]
M03_L14:
       mov       rsi,[rax+8]
       mov       rcx,7FFF82425120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFF82425C38],0
       je        short M03_L16
       call      qword ptr [7FFF824EDC98]
       mov       edi,eax
       jmp       short M03_L19
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L16:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       edi,[rax+0A3C]
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_NONGCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       lea       ecx,[rdi-1]
       mov       [rax+0A3C],ecx
       movzx     eax,di
       test      eax,eax
       jne       short M03_L17
       call      qword ptr [7FFF82D8CC78]
       jmp       short M03_L18
M03_L17:
       mov       eax,edi
       sar       eax,10
M03_L18:
       mov       edi,eax
M03_L19:
       mov       rcx,7FFF82425120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,edi
       xor       edx,edx
       div       dword ptr [7FFF82425C2C]
       mov       edi,edx
       xor       r15d,r15d
       jmp       near ptr M03_L26
M03_L20:
       cmp       edi,[rsi+8]
       jae       short M03_L15
       mov       ecx,edi
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
       jbe       short M03_L22
       test      r10d,r10d
       jne       short M03_L23
       xor       edx,edx
       mov       [rax+14],edx
M03_L21:
       movsxd    rdx,r10d
       mov       r8,r14
       call      CORINFO_HELP_ARRADDR_ST
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       rax,[rbp-230]
       mov       [rax+10],ecx
       mov       dword ptr [rbp-1DC],1
M03_L22:
       mov       rcx,rax
       call      System.Threading.Monitor.Exit(System.Object)
       mov       ecx,[rbp-1DC]
       test      ecx,ecx
       je        short M03_L24
       mov       ecx,1
       jmp       short M03_L27
M03_L23:
       jmp       short M03_L21
M03_L24:
       inc       edi
       cmp       [rsi+8],edi
       jne       short M03_L25
       xor       edi,edi
M03_L25:
       inc       r15d
M03_L26:
       cmp       [rsi+8],r15d
       jg        near ptr M03_L20
       xor       ecx,ecx
M03_L27:
       mov       r15d,ecx
M03_L28:
       mov       rax,280398005D0
       mov       rsi,[rax]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L33
       mov       rcx,[rbp-220]
       cmp       dword ptr [rcx+8],0
       je        near ptr M03_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r14d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,edi
       mov       r9d,r14d
       mov       edx,3
       call      qword ptr [7FFF82597678]
       test      r15d,ebx
       jne       short M03_L33
       mov       rcx,[rbp-220]
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       edi,eax
       mov       rcx,[rbp-220]
       mov       r14d,[rcx+8]
       mov       rcx,r13
       call      System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       test      ebx,ebx
       jne       short M03_L29
       mov       ecx,0FFFFFFFF
       jmp       short M03_L30
M03_L29:
       mov       ecx,r12d
M03_L30:
       mov       edx,edi
       mov       r8d,r14d
       mov       r9d,eax
       test      ebx,ebx
       jne       short M03_L31
       mov       eax,1
       jmp       short M03_L32
M03_L31:
       xor       eax,eax
M03_L32:
       mov       [rsp+20],ecx
       mov       [rsp+28],eax
       mov       rcx,rsi
       call      qword ptr [7FFF8282F360]
M03_L33:
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
; Total bytes of code 1595
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
       call      qword ptr [7FFFE6815068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M05_L03
       call      qword ptr [7FFFE6819F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE68169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M05_L00
       call      qword ptr [7FFFE6815060]
       cmp       byte ptr [rax+18E],0
       je        short M05_L00
       mov       ecx,2
       call      qword ptr [7FFFE6816948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFFE6819FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE6819198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M05_L00
M05_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFFE6814820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M05_L00
M05_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M05_L04
       call      qword ptr [7FFFE6816A08]
       test      rax,rax
       je        near ptr M05_L00
M05_L04:
       call      qword ptr [7FFFE68184A0]
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
       call      qword ptr [7FFF82AB5590]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFF82ED8888
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M06_L05
M06_L03:
       test      rbp,rbp
       je        near ptr M06_L09
M06_L04:
       mov       rcx,7FFF82ED8898
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
       call      qword ptr [7FFF82AB5470]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M06_L03
M06_L06:
       mov       rcx,7FFF82ED888C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M06_L03
M06_L07:
       mov       rcx,rbx
       call      qword ptr [7FFF82AB54A0]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M06_L00
M06_L08:
       cmp       byte ptr [rsp+70],0
       je        short M06_L11
       mov       rcx,7FFF82ED8890
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF829C5140]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
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
       mov       rcx,7FFF82ED8894
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFF82B0D9F8]
       int       3
M06_L10:
       mov       rcx,7FFF82ED889C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L04
M06_L11:
       mov       rcx,7FFF82ED88A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M06_L03
M06_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M06_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFF82AB55C0]
       mov       rbp,rax
       jmp       near ptr M06_L02
M06_L13:
       call      qword ptr [7FFF82EAF018]
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
       jmp       qword ptr [7FFF824E43A8]
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF8271EF10]
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
       mov       rax,2C0C7960008
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M09_L07
M09_L03:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M09_L06
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M09_L07
M09_L04:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L05:
       call      qword ptr [7FFF82D2DA58]
       test      eax,eax
       jne       short M09_L07
       jmp       short M09_L03
M09_L06:
       call      qword ptr [7FFF82D2DA58]
       test      eax,eax
       je        short M09_L04
M09_L07:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rbx,rax
       jmp       short M09_L04
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
       call      qword ptr [7FFF829CCFF0]
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
       call      qword ptr [7FFF829CCFF0]
       mov       rcx,rax
       mov       rdx,2C0C7974220
       call      qword ptr [7FFF829CD200]
M09_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M09_L15:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 402
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFF82985218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       mov       rax,2A8C04009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,2A8C040BC28
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFF829B5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFF82C06460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L25
       mov       r14d,[rdi+8]
       cmp       r14d,20
       jle       near ptr M01_L24
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r15,[rbp-48]
       mov       r13d,r14d
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r15
       mov       edx,r13d
       call      qword ptr [7FFF8278D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r15
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r12,r9d
       add       r12,[rbp-50]
       cmp       r12,7FFFFFFF
       ja        near ptr M01_L27
       cmp       r9d,r13d
       jne       near ptr M01_L26
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
       call      qword ptr [7FFF826F5E38]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
M01_L05:
       test      r15,r15
       je        near ptr M01_L28
       lea       rsi,[r15+10]
       mov       ebx,[r15+8]
       mov       rcx,offset MT_System.Byte[]
       mov       edx,20
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       lea       rdx,[r14+10]
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
       mov       rcx,2E9523690D0
       xor       r9d,r9d
       call      qword ptr [7FFF82E94C60]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,2A8C040BC30
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L15
       lea       rcx,[rbx+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L15
M01_L06:
       mov       rbx,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],rbx
       xor       edi,edi
M01_L08:
       mov       ecx,edi
       lea       rcx,[r14+rcx+10]
       mov       r8,2A8C0400428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,2E952374210
       call      qword ptr [7FFF826E4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [rbx],bl
       test      rax,rax
       je        short M01_L13
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
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
       mov       [rbx+18],esi
       jmp       short M01_L13
M01_L10:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L12:
       mov       rcx,rbx
       call      qword ptr [7FFF827ACA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       add       edi,1
       jo        short M01_L14
       cmp       edi,20
       jl        near ptr M01_L08
       mov       rcx,rbx
       call      qword ptr [7FFF827B39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       jmp       short M01_L17
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L15:
       mov       rsi,[rbx+18]
       mov       r12,[rsi+18]
       lea       rdx,[rbp-68]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L30
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L06
M01_L17:
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
M01_L18:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,2E952362730
       mov       rdx,2E952360210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2E952360008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L19
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L20
M01_L19:
       mov       ecx,1
M01_L20:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L21
       call      qword ptr [7FFF829BCFF0]
       mov       r15,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       r13,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r13
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,r15
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,r14
       call      qword ptr [7FFF82736670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,2E952362D10
       mov       r8d,1
       call      qword ptr [7FFF829B4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L23:
       call      qword ptr [7FFF824D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L24:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF827850C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       mov       r15,rax
       jmp       near ptr M01_L05
M01_L25:
       mov       ecx,1763
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M01_L26:
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8d,r13d
       call      qword ptr [7FFF824DC8A0]
       add       r12d,eax
       jns       near ptr M01_L04
M01_L27:
       call      qword ptr [7FFF824DC7E0]
       int       3
M01_L28:
       mov       ecx,6A61
       mov       rdx,7FFF829A7038
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M01_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82D7C6A8]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFF829A7038
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       qword ptr [r12+10],0
       jne       short M01_L31
       xor       edx,edx
       mov       [rbp-68],rdx
       jmp       short M01_L32
M01_L31:
       lea       rdx,[rbp-68]
       mov       rcx,rsi
       call      qword ptr [7FFF82BC4DB0]
       test      eax,eax
       jne       near ptr M01_L16
M01_L32:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L07
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
       mov       rcx,2A8C040BC30
       mov       rbx,[rcx]
       mov       rax,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L34
       mov       rdi,[rbp-0A8]
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L38
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFF827AC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L35
M01_L34:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rdi,[rbp-0A8]
       je        short M01_L38
M01_L35:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L36
       lea       rcx,[rbx+20]
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L38
M01_L36:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L37
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BC52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L38
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF82BC4D80]
       jmp       short M01_L38
M01_L37:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L38:
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
; Total bytes of code 1694
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFF82995218]; DotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
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
       je        near ptr M01_L19
       mov       rax,25373C009F0
       mov       rbx,[rax]
       mov       [rbp-40],rcx
       mov       rcx,25373C0BC28
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+8D],0
       jne       short M01_L01
       mov       rcx,rsi
       call      qword ptr [7FFF829C5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFF82C16460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L27
       cmp       dword ptr [rdi+8],20
       jle       near ptr M01_L17
       lea       r8,[rdi+0C]
       mov       [rbp-48],r8
       mov       r14,[rbp-48]
       mov       r15d,[rdi+8]
       lea       r8,[rbp-50]
       lea       r9,[rbp-58]
       mov       rcx,r14
       mov       edx,r15d
       call      qword ptr [7FFF8279D140]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r14
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    r13,r9d
       add       r13,[rbp-50]
       cmp       r13,7FFFFFFF
       ja        near ptr M01_L26
       cmp       r9d,r15d
       jne       near ptr M01_L25
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
       call      qword ptr [7FFF82705E38]; System.Text.UTF8Encoding.GetBytes(System.String, Int32, Int32, Byte[], Int32)
       mov       rax,rsi
M01_L05:
       test      rax,rax
       je        near ptr M01_L28
       lea       rbx,[rax+10]
       mov       r14d,[rax+8]
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
       mov       rcx,29405C590D0
       xor       r9d,r9d
       call      qword ptr [7FFF82EB6A00]; System.Security.Cryptography.HashProviderDispenser+OneShotHashProvider.HashDataUsingPseudoHandle(System.String, System.ReadOnlySpan`1<Byte>, System.ReadOnlySpan`1<Byte>, Boolean, System.Span`1<Byte>, Int32 ByRef)
       mov       rcx,25373C0BC30
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-68],rcx
       cmp       qword ptr [rbp-68],0
       je        near ptr M01_L15
       lea       rcx,[rbx+20]
       mov       r8,[rbp-68]
       xor       edx,edx
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       cmp       rax,[rbp-68]
       jne       near ptr M01_L15
M01_L06:
       mov       rbx,[rbp-68]
M01_L07:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-0A8],rbx
       xor       r15d,r15d
M01_L08:
       mov       ecx,r15d
       lea       rcx,[rsi+rcx+10]
       mov       r8,25373C00428
       mov       r8,[r8]
       movzx     ecx,byte ptr [rcx]
       mov       rdx,29405C64210
       call      qword ptr [7FFF826F4810]; System.Number.<FormatUInt32>g__FormatUInt32Slow|43_0(UInt32, System.String, System.IFormatProvider)
       cmp       [rbx],bl
       test      rax,rax
       je        short M01_L13
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M01_L13
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
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
       mov       [rbx+18],r14d
       jmp       short M01_L13
M01_L10:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       short M01_L09
M01_L11:
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L09
M01_L12:
       mov       rcx,rbx
       call      qword ptr [7FFF827BCA98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
M01_L13:
       add       r15d,1
       jo        short M01_L14
       cmp       r15d,20
       jl        near ptr M01_L08
       mov       rcx,rbx
       call      qword ptr [7FFF827C39E8]; System.Text.StringBuilder.ToString()
       mov       [rbp-0B0],rax
       jmp       short M01_L18
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L15:
       mov       r14,[rbx+18]
       mov       r12,[r14+18]
       lea       rdx,[rbp-68]
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD5290]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        near ptr M01_L30
M01_L16:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L06
M01_L17:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF827950C8]; System.Text.UTF8Encoding+UTF8EncodingSealed.GetBytesForSmallInput(System.String)
       jmp       near ptr M01_L05
M01_L18:
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
M01_L19:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,29405C52730
       mov       rdx,29405C50210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,29405C50008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L20
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L21
M01_L20:
       mov       ecx,1
M01_L21:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L22
       call      qword ptr [7FFF829CCFF0]
       mov       r13,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       r12,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r14
       call      qword ptr [7FFF82746670]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r15
       call      qword ptr [7FFF82746670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,rsi
       mov       byte ptr [rbp-70],1
       mov       byte ptr [rbp-6F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-70]
       mov       rdx,29405C52D10
       mov       r8d,1
       call      qword ptr [7FFF829C4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M01_L02
M01_L24:
       call      qword ptr [7FFF824E43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M01_L25:
       mov       rcx,rbx
       mov       rdx,r14
       mov       r8d,r15d
       call      qword ptr [7FFF824EC8A0]
       add       r13d,eax
       jns       near ptr M01_L04
M01_L26:
       call      qword ptr [7FFF824EC7E0]
       int       3
M01_L27:
       mov       ecx,1763
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L28:
       mov       ecx,6A61
       mov       rdx,7FFF829B7038
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L29:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82D8C6A8]
       mov       rsi,rax
       mov       ecx,4465
       mov       rdx,7FFF829B7038
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824EF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L30:
       cmp       qword ptr [r12+10],0
       jne       short M01_L31
       xor       edx,edx
       mov       [rbp-68],rdx
       jmp       short M01_L32
M01_L31:
       lea       rdx,[rbp-68]
       mov       rcx,r14
       call      qword ptr [7FFF82BD4DB0]
       test      eax,eax
       jne       near ptr M01_L16
M01_L32:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L07
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
       mov       rcx,25373C0BC30
       mov       rbx,[rcx]
       mov       rax,[rbx+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rax+18],rcx
       jne       short M01_L34
       mov       rsi,[rbp-0A8]
       mov       rcx,[rsi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rsi+1C]
       mov       rdx,[rax+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M01_L38
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFF827BC1F8]; System.Text.StringBuilder.set_Length(Int32)
       jmp       short M01_L35
M01_L34:
       mov       rdx,[rbp-0A8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       mov       rsi,[rbp-0A8]
       je        short M01_L38
M01_L35:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L36
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       je        short M01_L38
M01_L36:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L37
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFF82BD52C0]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M01_L38
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF82BD4D80]
       jmp       short M01_L38
M01_L37:
       add       rbx,2C
       lock dec  dword ptr [rbx]
M01_L38:
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
; Total bytes of code 1699
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82EE4000]; System.Data.DataTable..ctor()
       mov       rcx,262F24441E8
       mov       [rbx+70],rcx
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFF829A4960]; DotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
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
       mov       rsi,262F2430008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,262F2444288
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,262F2444360
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,262F2444378
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,262F2444390
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,262F24443A8
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FFF82435C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFF82EA2448
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFF8277C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,2226040F390
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
       mov       rdx,262F2444208
       call      qword ptr [7FFF824F6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFF825A76D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF82EEC8B8]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFF826D4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF82EE68B0]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,262F243C760
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
       call      qword ptr [7FFF82EE7630]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,262F2444438
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
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M02_L59
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M02_L25
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M02_L25
M02_L00:
       cmp       [rsi],sil
       lea       rdi,[rsi+48]
       mov       rbp,[rdi]
       test      rbp,rbp
       je        near ptr M02_L22
M02_L01:
       mov       rcx,rbp
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M02_L27
       mov       rsi,[rcx+8]
M02_L02:
       mov       ecx,[rsi+8]
       xor       r8d,r8d
       mov       [rsp+40],r8
       mov       [rsp+48],r8
       mov       [rsp+50],r8d
       mov       [rsp+54],ecx
       xor       edi,edi
       cmp       dword ptr [rsi+8],0
       jle       short M02_L05
M02_L03:
       mov       ecx,edi
       mov       r8,[rsi+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,3E
       cmp       edx,ecx
       jne       short M02_L04
       lea       rcx,[rsp+40]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF827A4BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L04:
       inc       edi
       cmp       [rsi+8],edi
       jg        short M02_L03
M02_L05:
       mov       rsi,[rsp+40]
       mov       rdi,[rsp+48]
       mov       ebp,[rsp+50]
       test      ebp,ebp
       je        near ptr M02_L61
       cmp       ebp,1
       je        near ptr M02_L18
       test      ebp,ebp
       jl        near ptr M02_L60
       mov       r14,rsi
       test      r14,r14
       je        near ptr M02_L62
       cmp       [rsi+8],ebp
       jne       near ptr M02_L17
M02_L06:
       mov       r14,rsi
M02_L07:
       mov       rcx,2226040BD48
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M02_L14
M02_L08:
       test      r14,r14
       je        near ptr M02_L68
       test      rdi,rdi
       je        near ptr M02_L63
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L64
       mov       rdx,r14
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      qword ptr [7FFF824F4330]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M02_L66
       cmp       dword ptr [rsi+8],0
       je        near ptr M02_L65
       mov       rcx,offset MT_System.Linq.Enumerable+WhereArrayIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbp+10],eax
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L09:
       test      rbp,rbp
       je        near ptr M02_L68
       mov       rdx,rbp
       mov       rcx,offset MT_System.Linq.IIListProvider`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF824F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L69
       mov       rcx,rax
       mov       r11,7FFF823B0E58
       call      qword ptr [r11]
       mov       rsi,rax
M02_L10:
       test      rsi,rsi
       je        near ptr M02_L70
       xor       edi,edi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M02_L42
       mov       rcx,rsi
       cmp       dword ptr [rcx+10],0
       je        near ptr M02_L40
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       r14d,[rsi+14]
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp+10],rcx
       mov       [rbp+18],ecx
       mov       [rbp+1C],r14d
M02_L11:
       cmp       [rbp],ebp
M02_L12:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       cmp       [rbp],rcx
       jne       near ptr M02_L43
       lea       r14,[rbp+8]
       mov       r15,[r14]
       mov       rcx,r15
       mov       [rsp+30],rcx
       mov       edx,[r14+14]
       cmp       edx,[rcx+14]
       jne       near ptr M02_L57
       mov       edx,[r14+10]
       cmp       edx,[rcx+10]
       jae       near ptr M02_L41
       lea       rcx,[r14+8]
       mov       rax,[rsp+30]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M02_L73
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r14+10]
M02_L13:
       add       edi,1
       jo        near ptr M02_L58
       jmp       short M02_L12
M02_L14:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2226040BD40
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EEBA50
       mov       [rdi+18],rcx
       mov       rcx,2226040BD48
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L15:
       mov       ecx,[r12+10]
       inc       ecx
       mov       [r13+10],ecx
       xor       ecx,ecx
       mov       [r13+8],rcx
M02_L16:
       mov       ecx,ebp
       movsxd    rax,edi
       movsxd    rcx,ecx
       cmp       rax,rcx
       jl        near ptr M02_L45
       jmp       near ptr M02_L51
M02_L17:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       call      qword ptr [7FFF825A5BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L06
M02_L18:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M02_L07
M02_L19:
       add       ebp,1
       jo        near ptr M02_L58
M02_L20:
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       cmp       r15,rcx
       jne       short M02_L21
       lea       r13,[r14+8]
       mov       r12,[r13]
       mov       rcx,r12
       mov       [rsp+28],rcx
       mov       edx,[r13+14]
       cmp       edx,[rcx+14]
       jne       near ptr M02_L57
       mov       edx,[r13+10]
       cmp       edx,[rcx+10]
       jae       near ptr M02_L15
       lea       rcx,[r13+8]
       mov       rax,[rsp+28]
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M02_L73
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       dword ptr [r13+10]
       jmp       short M02_L19
M02_L21:
       mov       rcx,r14
       mov       r11,7FFF823B0E80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L19
       jmp       near ptr M02_L16
M02_L22:
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
M02_L23:
       mov       eax,[r14+38]
M02_L24:
       mov       rcx,[r14+8]
       cmp       byte ptr [rcx+94],0
       jne       short M02_L26
       mov       r15,[r14+10]
       jmp       short M02_L28
M02_L25:
       mov       rcx,rax
       call      qword ptr [7FFF82446658]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L26:
       xor       r15d,r15d
       jmp       short M02_L28
M02_L27:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFF827A4E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M02_L02
M02_L28:
       test      r15,r15
       je        short M02_L29
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r15],rcx
       je        short M02_L29
       xor       r15d,r15d
M02_L29:
       test      al,2
       jne       near ptr M02_L53
       test      byte ptr [r14+1C],10
       jne       short M02_L30
       mov       rcx,[r14+10]
       cmp       [rcx],cl
       mov       rdx,rbx
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M02_L55
M02_L30:
       mov       rdx,[r14+28]
       test      rdx,rdx
       jne       short M02_L31
       mov       rcx,r14
       call      qword ptr [7FFF827E73C0]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
M02_L31:
       mov       r13,rdx
       test      r13,r13
       je        short M02_L32
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M02_L56
M02_L32:
       mov       byte ptr [rsp+38],0
       test      r15,r15
       je        near ptr M02_L71
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        near ptr M02_L49
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M02_L49
M02_L33:
       movzx     ecx,byte ptr [rax+95]
       mov       [rsp+38],cl
       lea       rcx,[rsp+38]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,r13
       mov       r9,r15
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r12,rax
       movzx     ebp,byte ptr [rsp+38]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        near ptr M02_L50
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M02_L50
M02_L34:
       mov       [rax+95],bpl
M02_L35:
       test      r12,r12
       je        short M02_L37
       mov       rdx,r12
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF824F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       jne       short M02_L36
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF824F4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M02_L37
       jmp       near ptr M02_L47
M02_L36:
       xor       edx,edx
       call      qword ptr [7FFF829A4A98]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
M02_L37:
       add       edi,1
       jo        near ptr M02_L58
M02_L38:
       xor       ebp,ebp
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       cmp       [rsi],rcx
       jne       near ptr M02_L46
       cmp       dword ptr [rsi+10],0
       je        near ptr M02_L48
       mov       rcx,offset MT_System.Collections.Generic.List`1+Enumerator[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       r15d,[rsi+14]
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       mov       [r14+18],ecx
       mov       [r14+1C],r15d
M02_L39:
       mov       r15,[r14]
       jmp       near ptr M02_L20
M02_L40:
       mov       rcx,7FFF82435120
       mov       edx,69
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22260401FB0
       mov       rbp,[rcx]
       jmp       near ptr M02_L11
M02_L41:
       mov       ecx,[r15+10]
       inc       ecx
       mov       [r14+10],ecx
       xor       ecx,ecx
       mov       [r14+8],rcx
       jmp       short M02_L44
M02_L42:
       mov       rcx,rsi
       mov       r11,7FFF823B0E60
       call      qword ptr [r11]
       mov       rbp,rax
       jmp       near ptr M02_L11
M02_L43:
       mov       rcx,rbp
       mov       r11,7FFF823B0E68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M02_L13
M02_L44:
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M02_L70
       xor       edi,edi
       jmp       near ptr M02_L38
M02_L45:
       cmp       edi,[rsi+10]
       jae       near ptr M02_L52
       mov       rcx,[rsi+8]
       cmp       edi,[rcx+8]
       jae       near ptr M02_L73
       mov       eax,edi
       mov       r14,[rcx+rax*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M02_L72
       test      byte ptr [r14+38],1
       jne       near ptr M02_L23
       mov       rcx,r14
       call      qword ptr [7FFF827E71F8]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M02_L24
M02_L46:
       mov       rcx,rsi
       mov       r11,7FFF823B0E78
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M02_L39
M02_L47:
       mov       rcx,rax
       call      qword ptr [7FFF829A4900]; DotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
       jmp       near ptr M02_L37
M02_L48:
       mov       rcx,7FFF82435120
       mov       edx,69
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,22260401FB0
       mov       r14,[rcx]
       jmp       near ptr M02_L39
M02_L49:
       mov       rcx,r15
       call      qword ptr [7FFF82446658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M02_L33
M02_L50:
       mov       rcx,r15
       call      qword ptr [7FFF82446658]; System.RuntimeType.InitializeCache()
       jmp       near ptr M02_L34
M02_L51:
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
M02_L52:
       call      qword ptr [7FFF8272EA30]
       int       3
M02_L53:
       test      r15,r15
       je        short M02_L54
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF827BB2F0]; Precode of System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M02_L54
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FFF82A3F738]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFF82756718]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
M02_L54:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829668F8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L55:
       call      qword ptr [7FFF82A3E9A0]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFF827F2178]; Precode of System.Reflection.RtFieldInfo.get_Name()
       mov       rbp,rax
       mov       r14,[r14+10]
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,rbp
       mov       r8,r14
       mov       rcx,rsi
       call      qword ptr [7FFF82A3E2B0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF824FF708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L56:
       call      qword ptr [7FFF824F43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L57:
       call      qword ptr [7FFF8272EFB8]
       int       3
M02_L58:
       call      CORINFO_HELP_OVERFLOW
M02_L59:
       nop
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
M02_L60:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF8272ED18]
       int       3
M02_L61:
       mov       r14,262F2443A50
       jmp       near ptr M02_L07
M02_L62:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L63:
       mov       ecx,0C
       call      qword ptr [7FFF82754F30]
       int       3
M02_L64:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rbp,rax
       jmp       near ptr M02_L09
M02_L65:
       mov       rcx,7FFF8266F690
       mov       edx,8
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,22260401FD8
       mov       rbp,[rdx]
       jmp       near ptr M02_L09
M02_L66:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF824F4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L67
       mov       rcx,offset MT_System.Linq.Enumerable+WhereListIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbp
       mov       r8,rdi
       call      qword ptr [7FFF82926C88]
       mov       rbp,r14
       jmp       near ptr M02_L09
M02_L67:
       mov       rcx,offset MT_System.Linq.Enumerable+WhereEnumerableIterator`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFF82F0DB18]
       jmp       near ptr M02_L09
M02_L68:
       mov       ecx,10
       call      qword ptr [7FFF82754F30]
       int       3
M02_L69:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFF825ADFC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M02_L10
M02_L70:
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
M02_L71:
       lea       rcx,[rsp+38]
       mov       [rsp+20],rcx
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,r13
       xor       r9d,r9d
       call      System.RuntimeFieldHandle.GetValue(System.Reflection.RtFieldInfo, System.Object, System.RuntimeType, System.RuntimeType, Boolean ByRef)
       mov       r12,rax
       jmp       near ptr M02_L35
M02_L72:
       mov       rcx,r14
       mov       rdx,rbx
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       r12,rax
       jmp       near ptr M02_L35
M02_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2480
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty01()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,237207141C0
       call      qword ptr [7FFF82994990]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
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
       je        near ptr M01_L09
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
       je        near ptr M01_L10
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L05
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L11
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFF82D8F138]
       test      eax,eax
       jne       near ptr M01_L11
M01_L03:
       lea       ecx,[rbp-1]
       cmp       ecx,ebp
       jae       near ptr M01_L17
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L11
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFF82D8F138]
       test      eax,eax
       jne       near ptr M01_L11
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
       call      qword ptr [7FFF824366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rsp+48],0
       je        near ptr M01_L12
       cmp       dword ptr [rsp+48],1
       je        near ptr M01_L13
       mov       ebp,[rsp+48]
       test      ebp,ebp
       jl        near ptr M01_L14
       mov       r14,[rsp+38]
       test      r14,r14
       je        near ptr M01_L15
       cmp       [r14+8],ebp
       jne       near ptr M01_L16
M01_L07:
       mov       ecx,[rsp+48]
       mov       [rsp+4C],ecx
       mov       rbp,[rsp+38]
M01_L08:
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass9_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rsi+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF82D2E838]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      qword ptr [7FFF829CC4E0]
       mov       rbx,rax
       mov       ecx,787
       mov       rdx,7FFF82974F30
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       r14,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,r14
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829C7CD8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L11:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       jmp       near ptr M01_L06
M01_L12:
       mov       rbp,23720709AA0
       jmp       near ptr M01_L08
M01_L13:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,[rsp+40]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L08
M01_L14:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF8271ED18]
       int       3
M01_L15:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       [rsp+38],rax
       jmp       near ptr M01_L07
M01_L16:
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       lea       rcx,[rbx+10]
       lea       rdx,[r14+10]
       mov       r8d,[r14+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       call      qword ptr [7FFF82595BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rsp+38],rbx
       jmp       near ptr M01_L07
M01_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 814
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty02()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,23AEB7A4210
       call      qword ptr [7FFF82985260]; DotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L13
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFF82D1D278]
       test      eax,eax
       jne       near ptr M01_L13
M01_L03:
       lea       ecx,[rbp-1]
       cmp       ecx,ebp
       jae       near ptr M01_L17
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L04
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M01_L13
       jmp       short M01_L05
M01_L04:
       call      qword ptr [7FFF82D1D278]
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
       call      qword ptr [7FFF824266D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       mov       r9,7FFF82EA0870
       mov       [rbx+18],r9
       lea       r9,[rsp+30]
       mov       rdx,rbp
       mov       r8,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.PropertyInfo>, System.Func`2<System.Reflection.PropertyInfo,Boolean>, Boolean ByRef)
       call      qword ptr [7FFF82E25248]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
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
       call      qword ptr [7FFF82585BC0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rdi,rax
       mov       ecx,787
       mov       rdx,7FFF82964F30
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFF824D73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       jmp       near ptr M01_L06
M01_L14:
       mov       rbp,23AEB799AA0
       jmp       near ptr M01_L08
M01_L15:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF8270ED18]
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,24E31BA41E8
       call      qword ptr [7FFF82974D88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Id(System.String)
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       r8,[rsi+30]
       cmp       r8,rbx
       je        near ptr M01_L10
       test      r8,r8
       je        short M01_L00
       test      rbx,rbx
       je        short M01_L00
       mov       edx,[r8+8]
       cmp       edx,[rbx+8]
       jne       short M01_L00
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFF82595068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L10
M01_L00:
       mov       edi,1
       mov       ecx,32
       xor       edx,edx
       mov       [rsp+20],rdx
       xor       edx,edx
       cmp       edi,32
       setle     dl
       mov       eax,edx
       test      edx,edx
       je        short M01_L05
M01_L01:
       test      eax,eax
       je        short M01_L06
M01_L02:
       test      rbx,rbx
       je        near ptr M01_L08
       mov       edx,[rbx+8]
       cmp       edx,edi
       jl        near ptr M01_L07
       xor       ebp,ebp
       cmp       edx,ecx
       setle     bpl
M01_L03:
       test      ebp,ebp
       je        near ptr M01_L09
M01_L04:
       mov       rdx,rbx
       lea       rcx,[rsi+30]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L05:
       cmp       byte ptr [rsp+20],0
       je        short M01_L01
       lea       rcx,[rsp+20]
       call      qword ptr [7FFF825947B0]
       mov       ecx,eax
       jmp       short M01_L02
M01_L06:
       call      qword ptr [7FFF829CC3A8]
       mov       rbp,rax
       mov       rcx,24E31B9E780
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC0F0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF8259D470]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       xor       ebp,ebp
       jmp       near ptr M01_L03
M01_L08:
       xor       ebp,ebp
       jne       near ptr M01_L04
M01_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,0AD5
       mov       rdx,7FFF8282FBE8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       call      qword ptr [7FFF8299FD38]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF8259D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L10:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 374
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82984D60]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
       mov       rdx,215D2590008
       mov       r8d,3A
       mov       r9,215D2598DF0
       call      qword ptr [7FFF829A52D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       nop
       add       rsp,38
       ret
; Total bytes of code 58
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,21DF2E80008
       mov       r8d,1
       call      qword ptr [7FFF829952C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFF824EEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1DD6100B0F8
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF824EEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFF824EEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFF82EB4C60]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF82695740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       test      r12d,r12d
       jle       near ptr M01_L39
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFF82EB4A68]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF824366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L59
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF82795908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,21DF2E80008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1DD61001DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8283C3F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF824E43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L57
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L56
       call      qword ptr [7FFF82652290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFF8276E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L22
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF826C4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,21DF2E94218
       call      qword ptr [7FFF824E6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF829952C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFF82EB4AF8]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1DD6100BD50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1DD6100BD40
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EB0B70
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,1DD6100BD58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF82EB5368]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFF8276E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
M01_L18:
       test      eax,eax
       jne       near ptr M01_L13
       jmp       near ptr M01_L23
M01_L19:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,1DD6100BD40
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EB0B88
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFF823A0EB0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L21:
       mov       r11,7FFF823A0EA8
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF824E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,21DF2E8CE28
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
       call      qword ptr [7FFF82796208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFF82796280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFF8282E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFF82773A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r9,1DD61000438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L33
       mov       r9,1DD61000418
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
       mov       rdx,21DF2E94240
       call      qword ptr [7FFF824E6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFF829952C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L77
       test      rax,rax
       je        near ptr M01_L78
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,1DD6100BD60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L46
M01_L36:
       mov       rcx,1DD6100BD68
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
       call      qword ptr [7FFF82EB5368]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L47
       cmp       r12d,esi
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
       mov       rcx,1DD6100BD40
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EB0BB8
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1DD6100BD68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,1DD6100BD40
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EB0BA0
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1DD6100BD60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L47:
       call      CORINFO_HELP_OVERFLOW
M01_L48:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,21DF2E941E8
       mov       rdx,21DF2E80210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21DF2E80008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFF82746670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FFF82746670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L52:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,21DF2E82730
       mov       rdx,21DF2E80210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21DF2E80008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L56:
       mov       r11,7FFF823A0EC0
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L57:
       mov       rcx,rax
       mov       r11,7FFF823A0EA0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L58:
       mov       r11,7FFF823A0EB8
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L59:
       mov       r15,21DF2E89AA0
       jmp       near ptr M01_L07
M01_L60:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L61:
       call      qword ptr [7FFF8271E9A0]
       int       3
M01_L62:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF82695848]
       jmp       near ptr M01_L03
M01_L63:
       mov       rcx,rax
       mov       rdx,21DF2E8CE28
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
       call      qword ptr [7FFF826C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L68:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFF827951B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFF82795230]
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
       call      qword ptr [7FFF829CCED0]
       mov       rcx,21DF2E94518
       mov       rdx,21DF2E80210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,21DF2E80008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L75:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A2FC48]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824EF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A2F630]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF824EF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L77:
       mov       ecx,4
       call      qword ptr [7FFF82744F30]
       int       3
M01_L78:
       mov       ecx,0E
       call      qword ptr [7FFF82744F30]
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
       call      qword ptr [7FFF824E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L80
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L80
       mov       r11,7FFF823A0EB8
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
; Total bytes of code 4045
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       mov       rdx,2A124710008
       xor       r8d,r8d
       call      qword ptr [7FFF829949F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFF824EEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L48
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L52
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,2609280B0F8
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF824EEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFF824EEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFF82EA43C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF82695740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       test      r12d,r12d
       jle       near ptr M01_L39
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFF82EA41C8]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF824366D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L59
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF82795908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,2A124710008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,26092801DD0
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF828391C8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF824E43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L57
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L56
       call      qword ptr [7FFF82652290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFF8276E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF826C4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,2A124724218
       call      qword ptr [7FFF824E6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF829949F0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFF82EA4258]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,2609280BD50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,2609280BD40
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EA02D0
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,2609280BD58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF82EA4AC8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L22
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFF8276E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,2609280BD40
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EA02E8
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,[rbp-118]
       mov       r11,7FFF823A0D90
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L22:
       mov       r11,7FFF823A0D88
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF824E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       r8,2A12471CE28
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
       call      qword ptr [7FFF82796208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFF82796280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L42
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFF82827810]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
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
       call      qword ptr [7FFF82773A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r9,26092800438
       mov       r9,[r9]
       test      r9,r9
       jne       short M01_L33
       mov       r9,26092800418
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
       mov       rdx,2A124724240
       call      qword ptr [7FFF824E6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFF829949F0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L77
       test      rax,rax
       je        near ptr M01_L78
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF824E4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       mov       rcx,2609280BD60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L46
M01_L36:
       mov       rcx,2609280BD68
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
       call      qword ptr [7FFF82EA4AC8]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L47
       cmp       r12d,esi
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
       mov       rcx,2609280BD40
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EA0318
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,2609280BD68
       mov       rdx,r9
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,[rbp-140]
       mov       rax,[rbp-138]
       jmp       near ptr M01_L37
M01_L46:
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-148],rax
       mov       rcx,2609280BD40
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82EA0300
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,2609280BD60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L47:
       call      CORINFO_HELP_OVERFLOW
M01_L48:
       call      qword ptr [7FFF829CC3C0]
       mov       rcx,2A1247241E8
       mov       rdx,2A124710210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A124710008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CC4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829C7CD8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFF82746670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L51:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFF829CC0D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FFF82746670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L52:
       call      qword ptr [7FFF829CC3C0]
       mov       rcx,2A124712730
       mov       rdx,2A124710210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A124710008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CC4E0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829C7CD8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L55:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L56:
       mov       r11,7FFF823A0DA0
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L57:
       mov       rcx,rax
       mov       r11,7FFF823A0D80
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L58:
       mov       r11,7FFF823A0D98
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L59:
       mov       r15,2A124719AA0
       jmp       near ptr M01_L07
M01_L60:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L61:
       call      qword ptr [7FFF8271E9A0]
       int       3
M01_L62:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF82695848]
       jmp       near ptr M01_L03
M01_L63:
       mov       rcx,rax
       mov       rdx,2A12471CE28
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
       call      qword ptr [7FFF826C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdx,rax
       mov       r9,rdx
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L68:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-0D8],xmm0
       mov       rdx,[r8+48]
       lea       rcx,[rbp-0D8]
       call      qword ptr [7FFF827951B8]
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFF82795230]
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
       call      qword ptr [7FFF829CC3C0]
       mov       rcx,2A124724518
       mov       rdx,2A124710210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A124710008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CC4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829C7CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L74:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L75:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A2F090]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824EF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L76:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A2EA78]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF824EF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L77:
       mov       ecx,4
       call      qword ptr [7FFF82744F30]
       int       3
M01_L78:
       mov       ecx,0E
       call      qword ptr [7FFF82744F30]
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
       call      qword ptr [7FFF824E4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L80
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.Address, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L80
       mov       r11,7FFF823A0D98
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
; Total bytes of code 4041
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,1F1085F0008
       mov       r8d,1
       call      qword ptr [7FFF829852C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFF824DEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L51
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L55
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1B07680B0F8
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF824DEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFF824DEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFF82E94E28]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF82685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       test      r12d,r12d
       jle       near ptr M01_L40
       jmp       near ptr M01_L25
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFF82E94C30]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L10
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF824266D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L62
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L09
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF82785908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,1F1085F0008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1B076801DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8282C3F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L63
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L65
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L64
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L65
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFF824D43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L60
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L59
       call      qword ptr [7FFF82642290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFF8275E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L14:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L19
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF826B4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,1F108604218
       call      qword ptr [7FFF824D6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF829852C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFF82E94CC0]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1B07680BD50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L15
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1B07680BD40
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E90D38
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L15:
       mov       r14,1B07680BD58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L20
M01_L16:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF82E95530]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L17:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L22
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFF8275E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1B07680BD40
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E90D50
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L16
M01_L21:
       mov       rcx,[rbp-118]
       mov       r11,7FFF82390F18
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L22:
       mov       r11,7FFF82390F10
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L23:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L24
       cmp       [rcx],rdi
       jne       near ptr M01_L61
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
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L74
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L66
       mov       r8,1F1085FCE28
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
       call      qword ptr [7FFF82786208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFF82786280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L44
M01_L26:
       mov       rdx,[rbp-160]
M01_L27:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFF8281E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L28
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L39
M01_L28:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L68
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L67
       mov       rcx,[rax+18]
M01_L29:
       test      rcx,rcx
       je        near ptr M01_L79
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFF82763A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       cmp       dword ptr [rdx+190],3
       jl        near ptr M01_L43
       mov       rdx,[rdx+198]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M01_L42
       mov       r8,[rdx]
       add       r8,10
M01_L32:
       mov       r10,[r8+8]
       test      r10,r10
       jne       short M01_L33
       mov       r10,1B076800438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L33
       mov       r10,1B076800418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L70
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
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,1F108604240
       call      qword ptr [7FFF824D6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFF829852C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L80
       test      rax,rax
       je        near ptr M01_L81
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M01_L36:
       mov       rcx,1B07680BD60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L49
M01_L37:
       mov       rcx,1B07680BD68
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
       call      qword ptr [7FFF82E95530]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L39:
       add       esi,1
       jo        near ptr M01_L50
       cmp       r12d,esi
       jg        near ptr M01_L25
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
       jmp       near ptr M01_L71
M01_L42:
       jmp       near ptr M01_L69
M01_L43:
       jmp       near ptr M01_L69
M01_L44:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L45
       mov       r8,[rbp-98]
       jmp       short M01_L46
M01_L45:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L82
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
       mov       rcx,1B07680BD40
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E90D80
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1B07680BD68
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
       call      qword ptr [7FFF827851B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFF82785230]; System.MdUtf8String.ToString()
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
       mov       rcx,1B07680BD40
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E90D68
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1B07680BD60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L37
M01_L50:
       call      CORINFO_HELP_OVERFLOW
M01_L51:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,1F1086041E8
       mov       rdx,1F1085F0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F1085F0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFF82736670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L54:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FFF82736670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L55:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,1F1085F2730
       mov       rdx,1F1085F0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F1085F0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L58:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L59:
       mov       r11,7FFF82390F28
       call      qword ptr [r11]
       jmp       near ptr M01_L11
M01_L60:
       mov       rcx,rax
       mov       r11,7FFF82390F08
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L12
M01_L61:
       mov       r11,7FFF82390F20
       call      qword ptr [r11]
       jmp       near ptr M01_L24
M01_L62:
       mov       r15,1F1085F9AA0
       jmp       near ptr M01_L07
M01_L63:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L64:
       call      qword ptr [7FFF8270E9A0]
       int       3
M01_L65:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF82685848]
       jmp       near ptr M01_L03
M01_L66:
       mov       rcx,rax
       mov       rdx,1F1085FCE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L27
M01_L67:
       xor       ecx,ecx
       jmp       near ptr M01_L29
M01_L68:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L30
M01_L69:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L32
M01_L70:
       call      qword ptr [7FFF826B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jmp       near ptr M01_L35
M01_L72:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L34
M01_L73:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L36
M01_L74:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,1F1086045B8
       mov       rdx,1F1085F0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1F1085F0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L77:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L78:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A1FC48]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A1F630]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF824DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L80:
       mov       ecx,4
       call      qword ptr [7FFF82734F30]
       int       3
M01_L81:
       mov       ecx,0E
       call      qword ptr [7FFF82734F30]
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
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L83
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L83
       mov       r11,7FFF82390F20
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
; Total bytes of code 4061
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       mov       rdx,16223630008
       xor       r8d,r8d
       call      qword ptr [7FFF829852C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
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
       call      qword ptr [7FFF824DEBC8]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rsi,rsi
       je        near ptr M01_L50
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L54
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       r15,rax
       mov       rcx,1219180B0F8
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFF824DEE68]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
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
       call      qword ptr [7FFF824DEE98]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
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
       call      qword ptr [7FFF82E34090]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rbp-60]
       call      qword ptr [7FFF82685740]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
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
       test      r12d,r12d
       jle       near ptr M01_L39
       jmp       near ptr M01_L24
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFF82E0FE88]; DotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       jne       near ptr M01_L09
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-88]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      qword ptr [7FFF824266D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-78],0
       je        near ptr M01_L61
       cmp       dword ptr [rbp-78],1
       je        near ptr M01_L62
       lea       rdx,[rbp-88]
       mov       r8d,[rbp-78]
       mov       rcx,offset MD_System.Array.Resize[[System.Reflection.PropertyInfo, System.Private.CoreLib]](System.Reflection.PropertyInfo[] ByRef, Int32)
       call      qword ptr [7FFF82785908]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-78]
       mov       [rbp-74],ecx
       mov       r15,[rbp-88]
M01_L07:
       mov       r13,16223630008
       cmp       dword ptr [rsi+8],0
       jle       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,12191801DD8
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFF8282C3F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp-58],rax
       test      rax,rax
       je        near ptr M01_L63
       lea       r10,[rax+10]
       mov       eax,[rax+8]
M01_L08:
       mov       [rbp-48],r10
       mov       [rbp-40],eax
       xor       r8d,r8d
       mov       [rbp-50],r8d
       mov       byte ptr [rbp-4C],0
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M01_L65
       mov       r8d,[rbp-50]
       cmp       r8d,[rbp-40]
       ja        near ptr M01_L64
       mov       rcx,[rbp-48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rbp-40]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M01_L65
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
       jmp       near ptr M01_L03
M01_L09:
       xor       r13d,r13d
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      qword ptr [7FFF824D43C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rax],rcx
       jne       near ptr M01_L59
       mov       rcx,[rax+8]
       mov       rax,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rax
       jne       near ptr M01_L58
       call      qword ptr [7FFF82642290]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].System.Collections.Generic.IEnumerable<T>.GetEnumerator()
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
       call      qword ptr [7FFF8275E6E8]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].System.Collections.IEnumerator.get_Current()
       mov       rdi,rax
M01_L13:
       mov       ecx,r13d
       add       ecx,1
       jo        near ptr M01_L18
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF826B4180]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       mov       rdx,16223644218
       call      qword ptr [7FFF824D6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFF829852C0]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>)
       call      qword ptr [7FFF82E0FF18]; System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       r14,1219180BD50
       mov       r15,[r14]
       test      r15,r15
       jne       short M01_L14
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1219180BD40
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E0BF90
       mov       [r15+18],rcx
       mov       rcx,r14
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M01_L14:
       mov       r14,1219180BD58
       mov       r9,[r14]
       test      r9,r9
       je        short M01_L19
M01_L15:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r15
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>, System.Collections.Generic.IEqualityComparer`1<System.String>)
       call      qword ptr [7FFF82E34798]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       r13d,ebx
       mov       rcx,[rbp-118]
M01_L16:
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       r12,rdi
       jne       near ptr M01_L21
       mov       rdx,r12
       add       rcx,8
       call      qword ptr [7FFF8275E670]; System.Collections.Generic.List`1+Enumerator[[System.__Canon, System.Private.CoreLib]].MoveNext()
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
       mov       rcx,1219180BD40
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E0BFA8
       mov       [r13+18],rcx
       mov       rcx,r14
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,r13
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,[rbp-118]
       mov       r11,7FFF82390C10
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M01_L13
M01_L21:
       mov       r11,7FFF82390C08
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L22:
       mov       rdx,[rbp-118]
       mov       rcx,offset MT_System.IDisposable
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L23
       cmp       [rcx],rdi
       jne       near ptr M01_L60
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
       mov       rax,[r15+rcx*8+10]
       mov       [rbp-120],rax
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L74
       mov       rcx,rax
       mov       rdx,offset MT_System.Reflection.RuntimePropertyInfo
       mov       [rbp-110],rdx
       cmp       [rcx],rdx
       jne       near ptr M01_L66
       mov       r8,1622363CE28
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
       call      qword ptr [7FFF82786208]; System.Reflection.CustomAttribute.AddCustomAttributes(ListBuilder`1<System.Object> ByRef, System.Reflection.RuntimeModule, Int32, System.RuntimeType, Boolean, ListBuilder`1<System.Object>)
       mov       rcx,[rbp-158]
       mov       edx,[rbp-90]
       call      qword ptr [7FFF82786280]; System.Reflection.CustomAttribute.CreateAttributeArrayHelper(System.RuntimeType, Int32)
       mov       [rbp-160],rax
       xor       eax,eax
       cmp       dword ptr [rbp-90],0
       jg        near ptr M01_L43
M01_L25:
       mov       rdx,[rbp-160]
M01_L26:
       lea       r8,[rbp-0C8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Object, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Object>, Boolean ByRef)
       call      qword ptr [7FFF8281E478]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       test      rax,rax
       je        short M01_L27
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonIgnoreAttribute
       cmp       [rax],rcx
       je        near ptr M01_L38
M01_L27:
       mov       rax,[rbp-120]
       mov       r10,[rbp-110]
       cmp       [rax],r10
       jne       near ptr M01_L68
       mov       rcx,rax
       cmp       qword ptr [rcx+18],0
       je        near ptr M01_L67
       mov       rcx,[rax+18]
M01_L28:
       test      rcx,rcx
       je        near ptr M01_L79
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],rdx
       mov       rdx,rbx
       mov       r8d,3C
       xor       r9d,r9d
       call      qword ptr [7FFF82763A40]; System.Reflection.RuntimeMethodInfo.Invoke(System.Object, System.Reflection.BindingFlags, System.Reflection.Binder, System.Object[], System.Globalization.CultureInfo)
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
       mov       r10,12191800438
       mov       r10,[r10]
       test      r10,r10
       jne       short M01_L32
       mov       r10,12191800418
       mov       r10,[r10]
       test      r10,r10
       je        near ptr M01_L70
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
       mov       [rbp-0F8],r13
       mov       [rbp-0F0],r11
       lea       r8,[rbp-0F8]
       mov       [rbp-180],rax
       mov       rcx,[rbp-130]
       mov       [rbp-108],r8
       mov       dword ptr [rbp-100],2
       lea       r8,[rbp-108]
       mov       rdx,16223644240
       call      qword ptr [7FFF824D6C88]; System.String.FormatHelper(System.IFormatProvider, System.String, System.ReadOnlySpan`1<System.Object>)
       mov       rdx,rax
       mov       rcx,[rbp-180]
       mov       r8d,1
       call      qword ptr [7FFF829852C0]
       mov       [rbp-170],rax
       test      r14,r14
       je        near ptr M01_L80
       test      rax,rax
       je        near ptr M01_L81
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+ConcatIterator`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib]]
       call      qword ptr [7FFF824D4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
M01_L35:
       mov       rcx,1219180BD60
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M01_L48
M01_L36:
       mov       rcx,1219180BD68
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
       call      qword ptr [7FFF82E34798]; System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L38:
       add       esi,1
       jo        near ptr M01_L49
       cmp       r12d,esi
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
       jmp       near ptr M01_L71
M01_L41:
       jmp       near ptr M01_L69
M01_L42:
       jmp       near ptr M01_L69
M01_L43:
       cmp       qword ptr [rbp-0A0],0
       jne       short M01_L44
       mov       r8,[rbp-98]
       jmp       short M01_L45
M01_L44:
       mov       r8,[rbp-0A0]
       cmp       eax,[r8+8]
       jae       near ptr M01_L82
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
       mov       rcx,1219180BD40
       mov       rdx,[rcx]
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E0BFD8
       mov       r9,[rbp-140]
       mov       [r9+18],rcx
       mov       rcx,1219180BD68
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
       call      qword ptr [7FFF827851B8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rbp-0D8]
       vmovups   [rbp-0E8],xmm0
       lea       rcx,[rbp-0E8]
       call      qword ptr [7FFF82785230]; System.MdUtf8String.ToString()
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
       mov       rcx,1219180BD40
       mov       rdx,[rcx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF82E0BFC0
       mov       rax,[rbp-148]
       mov       [rax+18],rcx
       mov       rcx,1219180BD60
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-148]
       jmp       near ptr M01_L36
M01_L49:
       call      CORINFO_HELP_OVERFLOW
M01_L50:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,162236441E8
       mov       rdx,16223630210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16223630008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       r14,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [7FFF82736670]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
M01_L53:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,r13
       call      qword ptr [7FFF82736670]
       mov       rcx,r13
       call      CORINFO_HELP_THROW
M01_L54:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,16223632730
       mov       rdx,16223630210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16223630008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       r12,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L57:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L58:
       mov       r11,7FFF82390C20
       call      qword ptr [r11]
       jmp       near ptr M01_L10
M01_L59:
       mov       rcx,rax
       mov       r11,7FFF82390C00
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L11
M01_L60:
       mov       r11,7FFF82390C18
       call      qword ptr [r11]
       jmp       near ptr M01_L23
M01_L61:
       mov       r15,16223639AA0
       jmp       near ptr M01_L07
M01_L62:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-80]
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L63:
       xor       r10d,r10d
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L64:
       call      qword ptr [7FFF8270E9A0]
       int       3
M01_L65:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFF82685848]
       jmp       near ptr M01_L03
M01_L66:
       mov       rcx,rax
       mov       rdx,1622363CE28
       xor       r8d,r8d
       mov       r10,[rax]
       mov       r10,[r10+48]
       call      qword ptr [r10+28]
       mov       rdx,rax
       jmp       near ptr M01_L26
M01_L67:
       xor       ecx,ecx
       jmp       near ptr M01_L28
M01_L68:
       mov       rcx,rax
       mov       rdx,rbx
       xor       r8d,r8d
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+38]
       mov       rcx,rax
       mov       rax,rcx
       jmp       near ptr M01_L29
M01_L69:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r8,rax
       mov       rax,[rbp-128]
       jmp       near ptr M01_L31
M01_L70:
       call      qword ptr [7FFF826B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       jmp       near ptr M01_L34
M01_L72:
       mov       rax,[rbp-128]
       jmp       near ptr M01_L33
M01_L73:
       mov       rcx,rax
       mov       rdx,[rbp-170]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+10]
       mov       r14,rax
       jmp       near ptr M01_L35
M01_L74:
       call      qword ptr [7FFF829BCED0]
       mov       rcx,162236445B8
       mov       rdx,16223630210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,16223630008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L77:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L78:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A1FC48]
       mov       rsi,rax
       mov       ecx,0E9
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF824DF750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L79:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A1F630]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF824DF708]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L80:
       mov       ecx,4
       call      qword ptr [7FFF82734F30]
       int       3
M01_L81:
       mov       ecx,0E
       call      qword ptr [7FFF82734F30]
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
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L83
       mov       rdi,offset MT_System.Collections.Generic.List`1+Enumerator[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.8.Tester]]
       cmp       [rcx],rdi
       je        short M01_L83
       mov       r11,7FFF82390C18
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
; Total bytes of code 4061
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,20DF7B40008
       mov       r8d,3A
       mov       r9,20DF7B48DF0
       call      qword ptr [7FFF82984A08]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       mov       r14d,[rsp+0A8]
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
       call      qword ptr [7FFF82426DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,20DF7B53018
       xor       edx,edx
       call      qword ptr [7FFF82426DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L02
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82585068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L02
M01_L00:
       mov       r8,20DF7B40008
       test      r14b,r14b
       cmove     rdi,r8
M01_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF829849F0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF82E90B88
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82E94C00]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rsi,[r15+8]
       cmp       [rbx],bl
       test      rsi,rsi
       je        near ptr M01_L16
       cmp       rbx,rsi
       je        near ptr M01_L06
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       rdi,20DF7B45FA0
       jmp       near ptr M01_L01
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,1CD65C00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,1CD65C00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF82905200]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L19
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L07
       cmp       esi,edi
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L20
       sub       edi,esi
       je        short M01_L10
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF82585B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82ECF630]
       int       3
M01_L10:
       mov       rax,20DF7B40008
       jmp       short M01_L08
M01_L11:
       mov       rax,20DF7B40008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FFF829BC3C0]
       mov       rcx,20DF7B541E8
       mov       rdx,20DF7B40210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20DF7B40008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BC4E0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829B7CD8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829BC0D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829BC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFF82736670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FFF82384000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827366E8]
       int       3
M01_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L18:
       call      qword ptr [7FFF826B4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1105
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,326B32C0008
       mov       r8d,3A
       mov       r9,326B32C8DF0
       call      qword ptr [7FFF829952D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       mov       r14d,[rsp+0A8]
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
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,326B32D3018
       xor       edx,edx
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L02
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82595068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L02
M01_L00:
       mov       r8,326B32C0008
       test      r14b,r14b
       cmove     rdi,r8
M01_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF829952C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF82EB0D50
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82EB4DC8]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rsi,[r15+8]
       cmp       [rbx],bl
       test      rsi,rsi
       je        near ptr M01_L16
       cmp       rbx,rsi
       je        near ptr M01_L06
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       rdi,326B32C5FA0
       jmp       near ptr M01_L01
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2E621400438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2E621400418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF82905A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L19
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L07
       cmp       esi,edi
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L20
       sub       edi,esi
       je        short M01_L10
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82F54468]
       int       3
M01_L10:
       mov       rax,326B32C0008
       jmp       short M01_L08
M01_L11:
       mov       rax,326B32C0008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,326B32D4210
       mov       rdx,326B32C0210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,326B32C0008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFF82746670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L18:
       call      qword ptr [7FFF826C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1105
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,20333520008
       mov       r8d,3A
       mov       r9,20333528DF0
       call      qword ptr [7FFF829B52D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       mov       r14d,[rsp+0A8]
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
       call      qword ptr [7FFF82456DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,20333533018
       xor       edx,edx
       call      qword ptr [7FFF82456DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L02
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF825B5068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L02
M01_L00:
       mov       r8,20333520008
       test      r14b,r14b
       cmove     rdi,r8
M01_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF829B52C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF82EC0888
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82EC4900]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rsi,[r15+8]
       cmp       [rbx],bl
       test      rsi,rsi
       je        near ptr M01_L16
       cmp       rbx,rsi
       je        near ptr M01_L06
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       rdi,20333525FA0
       jmp       near ptr M01_L01
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,1C2A1800438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,1C2A1800418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF82925A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L19
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L07
       cmp       esi,edi
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L20
       sub       edi,esi
       je        short M01_L10
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF825B5B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82F84D80]
       int       3
M01_L10:
       mov       rax,20333520008
       jmp       short M01_L08
M01_L11:
       mov       rax,20333520008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FFF829ECED0]
       mov       rcx,203335341E8
       mov       rdx,20333520210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,20333520008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829ECFF0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829ECBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829ED170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFF82766670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829ECBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FFF823B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827666E8]
       int       3
M01_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L18:
       call      qword ptr [7FFF826E4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1105
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,2FF3FAC0008
       mov       r8d,3A
       mov       r9,2FF3FAC8DF0
       call      qword ptr [7FFF829752D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       mov       r14d,[rsp+0A8]
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
       call      qword ptr [7FFF82416DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,2FF3FAD3018
       xor       edx,edx
       call      qword ptr [7FFF82416DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L02
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82575068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L02
M01_L00:
       mov       r8,2FF3FAC0008
       test      r14b,r14b
       cmove     rdi,r8
M01_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF829752C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF82DFBE10
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82DFFE88]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rsi,[r15+8]
       cmp       [rbx],bl
       test      rsi,rsi
       je        near ptr M01_L16
       cmp       rbx,rsi
       je        near ptr M01_L06
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       rdi,2FF3FAC5FA0
       jmp       near ptr M01_L01
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2BEADC00438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2BEADC00418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF828E5A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L19
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L07
       cmp       esi,edi
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L20
       sub       edi,esi
       je        short M01_L10
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF82575B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82F349D8]
       int       3
M01_L10:
       mov       rax,2FF3FAC0008
       jmp       short M01_L08
M01_L11:
       mov       rax,2FF3FAC0008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FFF829ACED0]
       mov       rcx,2FF3FAD41E8
       mov       rdx,2FF3FAC0210
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2FF3FAC0008
       call      qword ptr [7FFF824C6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829ACFF0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FFF828308A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829AC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829ACBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829AD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFF82726670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824C7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829ACBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82726670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FFF82374000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827266E8]
       int       3
M01_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L18:
       call      qword ptr [7FFF826A4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1105
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       mov       rdx,2F50F070008
       mov       r8d,3A
       mov       r9,2F50F078DF0
       call      qword ptr [7FFF829952D8]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
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
       mov       rax,2F50F070008
       jmp       short M00_L00
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r15
       push      r14
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
       mov       r14d,[rsp+0A8]
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
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,2F50F083018
       xor       edx,edx
       call      qword ptr [7FFF82436DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       cmp       rdi,rdx
       je        near ptr M01_L02
       test      rdi,rdi
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       mov       r8d,[rdi+8]
       cmp       r8d,[rdx+8]
       jne       short M01_L00
       lea       rcx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFF82595068]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       jne       near ptr M01_L02
M01_L00:
       mov       r8,2F50F070008
       test      r14b,r14b
       cmove     rdi,r8
M01_L01:
       movzx     r8d,byte ptr [rsp+0A0]
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFF829952C0]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,7FFF82EB0B88
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       r8,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,System.String>>, System.String, System.Func`3<System.String,System.Collections.Generic.KeyValuePair`2<System.String,System.String>,System.String>)
       call      qword ptr [7FFF82EB4C00]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rsi,[r15+8]
       cmp       [rbx],bl
       test      rsi,rsi
       je        near ptr M01_L16
       cmp       rbx,rsi
       je        near ptr M01_L06
       cmp       dword ptr [rsi+8],0
       je        near ptr M01_L06
       jmp       short M01_L03
M01_L02:
       mov       rdi,2F50F075FA0
       jmp       near ptr M01_L01
M01_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],3
       jl        near ptr M01_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M01_L17
       mov       rax,[rcx]
       add       rax,10
M01_L04:
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2B47D000438
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M01_L05
       mov       rcx,2B47D000418
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L18
M01_L05:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       cmp       [rcx],cl
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       mov       [rsp+28],r9
       mov       [rsp+30],eax
       lea       rdx,[rsp+38]
       lea       r8,[rsp+28]
       xor       r9d,r9d
       call      qword ptr [7FFF82905A10]; System.Globalization.CompareInfo.IsPrefix(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.Globalization.CompareOptions)
       test      eax,eax
       je        near ptr M01_L19
M01_L06:
       mov       rcx,[r15+8]
       mov       esi,[rcx+8]
       mov       edi,[rbx+8]
       mov       ebp,esi
       cmp       ebp,edi
       jl        short M01_L07
       cmp       esi,edi
       jg        short M01_L09
M01_L07:
       test      esi,esi
       je        near ptr M01_L20
       sub       edi,esi
       je        short M01_L10
       mov       ecx,edi
       call      System.String.FastAllocateString(Int32)
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       lea       rdx,[rbx+0C]
       xor       r8d,r8d
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+0C]
       movsxd    r8,esi
       lea       rdx,[rbx+r8*2+0C]
       movsxd    r8,edi
       add       r8,r8
       call      qword ptr [7FFF82595B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
M01_L08:
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       ecx,1C7
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       edx,edi
       mov       ecx,ebp
       call      qword ptr [7FFF82F54918]
       int       3
M01_L10:
       mov       rax,2F50F070008
       jmp       short M01_L08
M01_L11:
       mov       rax,2F50F070008
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L12:
       call      qword ptr [7FFF829CCED0]
       mov       rcx,2F50F0841E8
       mov       rdx,2F50F070210
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2F50F070008
       call      qword ptr [7FFF824E6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829CCFF0]
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       r15,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,r15
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829CC7F8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFF829CCBE8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CD170]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFF82746670]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829CCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82746670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L16:
       mov       ecx,2E5
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF827466E8]
       int       3
M01_L17:
       mov       ecx,3
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       jmp       near ptr M01_L04
M01_L18:
       call      qword ptr [7FFF826C4030]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L19:
       mov       rax,rbx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       mov       rax,rbx
       jmp       near ptr M01_L08
; Total bytes of code 1105
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson03()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+120]
       call      qword ptr [7FFF829B4C30]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF82985320]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions)
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
       mov       rax,20C42403BD0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFF829B51D0]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
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
       mov       rcx,20C42403BD0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M02_L06
M02_L00:
       cmp       byte ptr [rbx+8D],0
       jne       short M02_L01
       mov       rcx,rbx
       call      qword ptr [7FFF829B5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
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
       call      qword ptr [7FFF82C06460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,20C46401F58
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFF82E94FD8]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       call      qword ptr [7FFF824D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L05:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,24CD42F2D10
       mov       r8d,1
       call      qword ptr [7FFF829B4B10]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L06:
       call      qword ptr [7FFF829B51D0]; System.Text.Json.JsonSerializerOptions.GetOrCreateDefaultOptionsInstance()
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
       call      qword ptr [7FFF829BCED0]
       mov       rcx,24CD42F2730
       mov       rdx,24CD42F0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,24CD42F0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BCFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829BC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L11:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
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
       call      qword ptr [7FFF82E94258]
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+120]
       call      qword ptr [7FFF82984A38]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
       mov       rcx,260A000BC28
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFF829B48D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF829B4318]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF82C06A60]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFF829BC3C0]
       mov       rcx,2A132092730
       mov       rdx,2A132090210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A132090008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829BC4E0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828408A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829B7CD8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829BC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BC660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82736670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFF824D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+130]
       call      qword ptr [7FFF829B5308]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
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
       mov       rcx,1FF040050C0
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+8D],0
       jne       short M01_L00
       mov       rcx,rbx
       call      qword ptr [7FFF829E5128]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFF829E4B70]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       je        short M01_L01
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       jne       near ptr M01_L06
M01_L01:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF82C36460]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L02:
       call      qword ptr [7FFF829ECED0]
       mov       rcx,1FE833C2730
       mov       rdx,1FE833C0210
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,1FE833C0008
       call      qword ptr [7FFF82506B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FFF829ECFF0]
       mov       rbx,rax
       mov       ecx,770
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828708A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829EC7F8]
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829ECBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829ED170]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82766670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L05:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF82507318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829ECBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82766670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rdx,rax
       call      qword ptr [7FFF825043F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
; Total bytes of code 419
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF82EA4990]; System.Data.DataTable..ctor()
       mov       rcx,21C0DF54210
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFF82985368]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,21C0DF40008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,21C0DF542B0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,21C0DF54388
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,21C0DF543A0
       mov       [rbx+110],rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataView, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21C0DF543B8
       mov       [rax+8],rcx
       lea       rcx,[rbx+180]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Data.DataViewListener, System.Data.Common]]
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21C0DF543D0
       mov       [rax+8],rcx
       lea       rcx,[rbx+188]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Threading.ReaderWriterLockSlim
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+40],0FFFFFFFF
       mov       dword ptr [rax+44],0FFFFFFFF
       mov       byte ptr [rax+4D],1
       mov       rcx,7FFF82415C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFF82E94160
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFF8275C2E8]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1DB7C00F390
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
       mov       rdx,21C0DF54230
       call      qword ptr [7FFF824D6C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFF825876D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF82EACF00]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFF826B4180]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFF82EA7240]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,21C0DF4C760
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
       call      qword ptr [7FFF82EAC048]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
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
       mov       rcx,21C0DF54460
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
       call      qword ptr [7FFF824D4348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L02
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L01
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFF82E96628]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L03
M02_L00:
       call      qword ptr [7FFF82EF49A8]
       mov       rbx,rax
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829BCDE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829BD170]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF82736718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L01:
       mov       rcx,rbx
       mov       r11,7FFF82390D70
       call      qword ptr [r11]
       jmp       short M02_L03
M02_L02:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFF82390D78
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FFF82EF4210]
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

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rsi,rax
       mov       rcx,27799409110
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
       mov       r9,2B82B492928
       cmp       rcx,r9
       je        short M00_L05
       jmp       short M00_L04
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FFF829C48D0]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       short M00_L02
M00_L04:
       mov       rcx,rdi
       mov       byte ptr [rsp+48],1
       mov       byte ptr [rsp+49],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rsp+48]
       mov       rdx,2B82B492928
       mov       r8d,1
       call      qword ptr [7FFF829C42B8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFF82E94A38]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFF824E43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L08:
       call      qword ptr [7FFF829CC4E0]
       mov       rbx,rax
       mov       ecx,77D
       mov       rdx,7FFF82974F30
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,770
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0B54
       mov       rdx,7FFF828508A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rsi
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF829C7CD8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       ecx,3174
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0C300]
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFF82D2DA58]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFF82D2DA58]
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
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFFE6815068]
       cmp       byte ptr [rax+18F],0
       je        near ptr M02_L03
       call      qword ptr [7FFFE6819F80]; Precode of System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.RootDefaultInstance()
       mov       rsi,rax
       mov       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M02_L01
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE68169F0]
       mov       rdi,rax
       test      rdi,rdi
       je        short M02_L00
       call      qword ptr [7FFFE6815060]
       cmp       byte ptr [rax+18E],0
       je        short M02_L00
       mov       ecx,2
       call      qword ptr [7FFFE6816948]
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rsi
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFFE6819FA0]
       lea       rcx,[rbx+58]
       mov       rdx,rax
       call      qword ptr [7FFFE6814FC8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFFE6819198]; Precode of System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L00
M02_L02:
       mov       rcx,[rsi+8]
       lea       r11,[7FFFE6814820]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L04
       call      qword ptr [7FFFE6816A08]
       test      rax,rax
       je        near ptr M02_L00
M02_L04:
       call      qword ptr [7FFFE68184A0]
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
       call      qword ptr [7FFF82AB4C00]; System.Text.Json.JsonSerializerOptions+CachingContext.GetOrAddCacheEntry(System.Type)
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
       mov       rcx,7FFF82ED31D8
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       byte ptr [rbp+105],2
       jne       short M03_L05
M03_L03:
       test      rbp,rbp
       je        near ptr M03_L09
M03_L04:
       mov       rcx,7FFF82ED31E8
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
       call      qword ptr [7FFF82AB4AE0]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|172_0()
       jmp       short M03_L03
M03_L06:
       mov       rcx,7FFF82ED31DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L03
M03_L07:
       mov       rcx,rbx
       call      qword ptr [7FFF82AB4B10]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       r14,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L08:
       cmp       byte ptr [rsp+70],0
       je        short M03_L11
       mov       rcx,7FFF82ED31E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FFF829C48E8]; System.Text.Json.JsonSerializerOptions.GetTypeInfoNoCaching(System.Type)
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
       mov       rcx,7FFF82ED31E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFF82B0D1A0]
       int       3
M03_L10:
       mov       rcx,7FFF82ED31EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L04
M03_L11:
       mov       rcx,7FFF82ED31F0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L03
M03_L12:
       cmp       byte ptr [rax+20],0
       jne       near ptr M03_L01
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rax
       call      qword ptr [7FFF82AB4C30]
       mov       rbp,rax
       jmp       near ptr M03_L02
M03_L13:
       call      qword ptr [7FFF82E9E4A8]
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
       mov       rdx,2779D401E48
       mov       rcx,[rdx]
       lea       edx,[rdi+rdi*2]
       call      qword ptr [7FFF82A4C3E8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFF82A244B0]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
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
       call      qword ptr [7FFF82A244C8]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
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
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0C318]
       int       3
M04_L06:
       mov       ecx,318C
       mov       rdx,7FFF829BA168
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF82B0C348]
       int       3
M04_L07:
       call      qword ptr [7FFF8271E9A0]
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
       call      qword ptr [7FFF82B86328]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D0],ymm0
       vmovdqu   ymmword ptr [rbp-1B0],ymm0
       vmovdqu   ymmword ptr [rbp-190],ymm0
       vmovdqu   ymmword ptr [rbp-170],ymm0
       vmovdqu   ymmword ptr [rbp-150],ymm0
       lea       rcx,[rbp-1D0]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF82B873F0]; System.Text.Json.ReadStack.Initialize(System.Text.Json.Serialization.Metadata.JsonTypeInfo, Boolean)
       mov       rcx,[rbx+138]
       mov       r8,[rbx+0B0]
       lea       rdx,[rbp-130]
       lea       r9,[rbp-1D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFF82A6E838]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
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
       call      qword ptr [7FFF82595BA8]
M04_L12:
       mov       rcx,2779D401E48
       mov       r13,[rcx]
       mov       rcx,[rbp-220]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       r12d,r12d
       lzcnt     r12d,ecx
       xor       r12d,1F
       add       r12d,0FFFFFFFD
       mov       rcx,7FFF82425120
       mov       edx,2F
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_DYNAMICCLASS
       mov       rcx,[rax]
       test      rcx,rcx
       jne       short M04_L13
       mov       rcx,r13
       call      qword ptr [7FFF82A65980]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
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
       call      qword ptr [7FFF82A552D8]
       mov       r12,rax
       mov       ecx,1D3
       mov       rdx,7FFF82394000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,r12
       mov       rcx,r13
       call      qword ptr [7FFF824EF750]
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
       call      qword ptr [7FFF82A65908]
M04_L15:
       mov       rsi,[rax+8]
       mov       rcx,7FFF82425120
       mov       edx,308
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       cmp       byte ptr [7FFF82425C38],0
       je        short M04_L17
       call      qword ptr [7FFF824EDC98]
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
       call      qword ptr [7FFF82D8CCC0]
       jmp       short M04_L19
M04_L18:
       mov       eax,r14d
       sar       eax,10
M04_L19:
       mov       r14d,eax
M04_L20:
       mov       rcx,7FFF82425120
       mov       edx,2CF
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFF82425C2C]
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
       mov       rax,2779D4005D0
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
       call      qword ptr [7FFF82597678]
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
       call      qword ptr [7FFF827DF258]
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
       jmp       qword ptr [7FFF824E43A8]
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
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M06_L16
       jmp       short M06_L04
M06_L03:
       call      qword ptr [7FFF82D2DA58]
       test      eax,eax
       jne       near ptr M06_L16
M06_L04:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L05
       mov       rax,7FFFE1422BD0
       test      byte ptr [rcx+rax],80
       jne       near ptr M06_L16
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFF82D2DA58]
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
       call      qword ptr [7FFF829CC4E0]
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
       call      qword ptr [7FFF829CC4E0]
       mov       rcx,rax
       mov       rdx,2B82B494220
       call      qword ptr [7FFF829CC6F0]
M06_L14:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFF824E7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF829CC0D8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF829CC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFF82746670]
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
       call      qword ptr [7FFF824E73F0]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       jmp       near ptr M06_L07
; Total bytes of code 420
```

