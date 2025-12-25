## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.IPerson<DotNetTips.Spargine.Tester.Models.RefTypes.Address>
       call      qword ptr [7FFE007943C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastInterface(Void*, System.Object)
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
       call      qword ptr [7FFE00CC69D0]
       mov       ecx,807
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CC67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
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
       jmp       qword ptr [7FFE007943A8]
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
       call      00007FFE00791E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00B05D58]
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
       mov       rax,2BCF2330008
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Linq.IIListProvider<DotNetTips.Spargine.Tester.Models.RefTypes.Person<DotNetTips.Spargine.Tester.Models.RefTypes.Address>>
       call      qword ptr [7FFE00774348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L07
       mov       rdx,rsi
       mov       rcx,7FFE0123A8E8
       call      qword ptr [7FFE0122CB88]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       [rsp+30],rax
       mov       rcx,1FE80803EF0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L01
       mov       rcx,rsi
       call      qword ptr [7FFE00CAD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FFE00CACBB8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L03
M00_L02:
       lea       rdx,[rsp+30]
       mov       rcx,7FFE01048FB8
       call      qword ptr [7FFE00FADA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,7FFE01246650
       call      qword ptr [7FFE0122E3E8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE00AE7A38]
       int       3
M00_L07:
       mov       rcx,rax
       mov       r11,7FFE00630FF0
       call      qword ptr [r11]
       test      rax,rax
       jne       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFE00CA69D0]
       mov       ecx,807
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CA67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L09:
       mov       rdx,rax
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L10:
       call      qword ptr [7FFE00CA6A78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L11
       call      qword ptr [7FFE00CA67C0]
       mov       rbx,rax
M00_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23F0A545EC8
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
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
       je        short M01_L04
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
       jge       short M01_L00
       test      r10,r10
       je        short M01_L04
M01_L01:
       cmp       [r9],rcx
       je        short M01_L02
       add       r9,8
       dec       r10
       test      r10,r10
       jle       short M01_L04
       jmp       short M01_L01
M01_L02:
       mov       rax,rdx
       ret
M01_L03:
       jmp       qword ptr [7FFE00774378]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       test      dword ptr [r8],406C0000
       jne       short M01_L03
       xor       edx,edx
       jmp       short M01_L02
; Total bytes of code 112
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
       mov       rdx,7FFE013BAFA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rsi
       call      qword ptr [7FFE00774348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       mov       rdx,7FFE013BB1A0
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
       mov       rdx,7FFE013BB1B8
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
       mov       rdx,7FFE013BB2C8
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
       mov       rdx,7FFE013BB190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L10:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE013A7E40]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L11
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L11
       jmp       short M02_L12
M02_L11:
       mov       rcx,rbx
       mov       rdx,7FFE013BB190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L12:
       lea       rcx,[rsp+28]
       mov       r8,rsi
       call      qword ptr [7FFE013A7EB8]
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L13
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rbx
       mov       rdx,7FFE013BB190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M02_L14:
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE013A7F48]
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
       mov       rdx,7FFE013BB2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L17:
       call      qword ptr [7FFE00C24750]; System.Array.Empty[[System.__Canon, System.Private.CoreLib]]()
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
       call      qword ptr [7FFE00CADFE0]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M03_L05
       call      qword ptr [7FFE00D1F660]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAD9E0]
       test      eax,eax
       je        near ptr M03_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       xor       r8d,r8d
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       mov       r8d,1
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FFE00D22150
       mov       r9d,2
       call      qword ptr [7FFE00D1F8A0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE00D1F8E8]
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
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M03_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CAD2A8]
       jmp       short M03_L09
M03_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F780]
       jmp       short M03_L09
M03_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M03_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAF348]
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
       mov       rdx,23F0A532008
       mov       r8d,1
       call      qword ptr [7FFE00CACB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE00CAD320]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M05_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
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
       mov       rcx,1FE7C801F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE00F79568]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,23F0A531B28
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
       call      qword ptr [7FFE00D1EE08]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00D44540]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M05_L00
M05_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE010551E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M05_L00
M05_L13:
       mov       rcx,7FFE00CDC6E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE808049D0
       mov       rdi,[rcx]
       jmp       near ptr M05_L03
M05_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE00FAE658]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M05_L04
M05_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE01054CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE00FAE7D8]
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
       cmp       dword ptr [rcx+190],2
       jl        short M05_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M05_L18
M05_L17:
       mov       ecx,2
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00825BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M05_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1FE7C801F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00F79570]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L01
M06_L00:
       call      qword ptr [7FFE01135740]
       test      eax,eax
       jne       short M06_L04
M06_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M06_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M06_L04
       jmp       short M06_L03
M06_L02:
       call      qword ptr [7FFE01135740]
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
       call      qword ptr [7FFE007773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M07_L03
M07_L02:
       mov       r8,1FE80802C08
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE0122E448]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M07_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,rsi
       mov       rdx,7FFE012508E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M07_L02
M07_L04:
       lea       rcx,[rsp+28]
       mov       rdx,23F0A5460C8
       call      qword ptr [7FFE00A35F38]
M07_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FFE01246818
       call      qword ptr [7FFE00BC4138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M07_L07
M07_L06:
       call      qword ptr [7FFE00AE57E8]
       int       3
M07_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M07_L08
       mov       rdx,23F0A53076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M07_L09
M07_L08:
       lea       rcx,[rsp+28]
       mov       rdx,23F0A530760
       call      qword ptr [7FFE00A35F38]
M07_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE00A35D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00995F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L10:
       call      qword ptr [7FFE00CA6A78]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M07_L11
       call      qword ptr [7FFE00CA67C0]
       mov       rsi,rax
M07_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23F0A545EC8
       mov       r8,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M07_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE00A35CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,23F0A5460D4
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
       call      00007FFE00771E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00AE5D58]
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
       mov       rax,23F0A530008
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
       jmp       qword ptr [7FFE007743A8]
; Total bytes of code 71
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,1E01DC03EF0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE00CAD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE00CACBB8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FFE01048FB8
       call      qword ptr [7FFE00FADA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,7FFE01292FA0
       call      qword ptr [7FFE01287420]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE00CA69D0]
       mov       ecx,807
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CA67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE00CA6A78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE00CA67C0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,220AD8B5DB0
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
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
       call      qword ptr [7FFE00CADFE0]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE00D1F660]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAD9E0]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       xor       r8d,r8d
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       mov       r8d,1
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FFE00D22150
       mov       r9d,2
       call      qword ptr [7FFE00D1F8A0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE00D1F8E8]
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
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CAD2A8]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F780]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAF348]
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
       mov       rdx,220AD8A2008
       mov       r8d,1
       call      qword ptr [7FFE00CACB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE00CAD320]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
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
       mov       rcx,1E01BC01F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE00F79568]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,220AD8A1B28
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
       call      qword ptr [7FFE00D1EE08]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00D44540]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE010551E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE00CDC6E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E01DC049D0
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE00FAE658]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE01054CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE00FAE7D8]
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
       cmp       dword ptr [rcx+190],2
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,2
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00825BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1E01BC01F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00F79570]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE01135740]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE01135740]
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
       call      qword ptr [7FFE007773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,1E01DC02C08
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE01287480]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE01269FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,220AD8B5FB0
       call      qword ptr [7FFE00A35F38]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FFE01293168
       call      qword ptr [7FFE00BC4138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FFE00AE57E8]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,220AD8A076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,220AD8A0760
       call      qword ptr [7FFE00A35F38]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE00A35D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00995F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FFE00CA6A78]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FFE00CA67C0]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,220AD8B5DB0
       mov       r8,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE00A35CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,220AD8B5FBC
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
       call      00007FFE00771E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00AE5D58]
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
       mov       rax,220AD8A0008
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
       jmp       qword ptr [7FFE007743A8]
; Total bytes of code 71
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,1FE3B011498
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE00CDD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE00CDCBB8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FFE010790F8
       call      qword ptr [7FFE00FDDA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
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
       call      qword ptr [7FFE007A7318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,7FFE012A99F0
       call      qword ptr [7FFE012B60E8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE00CD69D0]
       mov       ecx,807
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B37000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CD67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L06:
       mov       rdx,rax
       call      qword ptr [7FFE007A43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L07:
       call      qword ptr [7FFE00CD6A78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L08
       call      qword ptr [7FFE00CD67C0]
       mov       rbx,rax
M00_L08:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,23EC8F157F8
       mov       r8,rbx
       call      qword ptr [7FFE009A6718]
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
       call      qword ptr [7FFE00CDDFE0]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE00D4F660]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CDD9E0]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D52048
       xor       r8d,r8d
       call      qword ptr [7FFE00D4F870]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D52048
       mov       r8d,1
       call      qword ptr [7FFE00D4F870]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FFE00D52150
       mov       r9d,2
       call      qword ptr [7FFE00D4F8A0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE00D4F8E8]
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
       call      qword ptr [7FFE00D4F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D4F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D4F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CDD2A8]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D4F780]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE007A4360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CDF348]
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
       mov       rdx,23EC8F02008
       mov       r8d,1
       call      qword ptr [7FFE00CDCB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE00CDD320]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
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
       mov       rcx,1FE3B001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE00FA9568]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,23EC8F01B28
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
       call      qword ptr [7FFE00D4EE08]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE00B157E8]
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
       call      qword ptr [7FFE00D74540]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE010851E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE00D0C6E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FE3B011F78
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE00FDE658]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE01084CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE00FDE7D8]
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
       cmp       dword ptr [rcx+190],2
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,2
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
       call      qword ptr [7FFE00B157E8]
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
       call      qword ptr [7FFE00855BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1FE3B001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00FA9570]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L01
M04_L00:
       call      qword ptr [7FFE01165740]
       test      eax,eax
       jne       short M04_L04
M04_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M04_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M04_L04
       jmp       short M04_L03
M04_L02:
       call      qword ptr [7FFE01165740]
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
       call      qword ptr [7FFE007A73F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FFE007A7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M05_L03
M05_L02:
       mov       r8,1FE3B0101B0
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE012B6148]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M05_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rsi
       mov       rdx,7FFE01295258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M05_L02
M05_L04:
       lea       rcx,[rsp+28]
       mov       rdx,23EC8F159F8
       call      qword ptr [7FFE00A65F38]
M05_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FFE012A9BB8
       call      qword ptr [7FFE00BF4138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M05_L07
M05_L06:
       call      qword ptr [7FFE00B157E8]
       int       3
M05_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M05_L08
       mov       rdx,23EC8F0076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M05_L09
M05_L08:
       lea       rcx,[rsp+28]
       mov       rdx,23EC8F00760
       call      qword ptr [7FFE00A65F38]
M05_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE00A65D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE009C5F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L10:
       call      qword ptr [7FFE00CD6A78]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M05_L11
       call      qword ptr [7FFE00CD67C0]
       mov       rsi,rax
M05_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,23EC8F157F8
       mov       r8,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M05_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE00A65CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,23EC8F15A04
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
       call      00007FFE007A1E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00855B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00B15D58]
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
       mov       rax,23EC8F00008
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
       jmp       qword ptr [7FFE007A43A8]
; Total bytes of code 69
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rdx,1F6728D3E10
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE006BA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FFE006C66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FFE00AE5FC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L03:
       test      ebx,10000
       je        short M01_L04
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFE0097F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE00E3DE00]
       jmp       short M01_L06
M01_L04:
       test      rsi,rsi
       jne       short M01_L05
       call      qword ptr [7FFE006C5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L05:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFE0097F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       rdx,7FFE00624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE00976790]
       int       3
M01_L08:
       test      rdi,rdi
       je        short M01_L09
       cmp       dword ptr [rdi+8],0
       jne       short M01_L10
M01_L09:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       xor       r8d,r8d
       call      qword ptr [7FFE0097F3D8]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].get_Item(Int32)
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rdx,2497B5F3E10
       mov       r8d,34
       xor       r9d,r9d
       call      qword ptr [7FFE006DA6C0]; System.RuntimeType.GetPropertyImpl(System.String, System.Reflection.BindingFlags, System.Reflection.Binder, System.Type, System.Type[], System.Reflection.ParameterModifier[])
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
       call      qword ptr [7FFE006E66D0]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
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
       call      qword ptr [7FFE009BC8A0]; System.Reflection.RuntimePropertyInfo.get_Signature()
       mov       rdx,[rax+18]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       short M01_L11
       mov       rcx,r14
       call      qword ptr [7FFE006DA720]; Precode of System.RuntimeType.IsEquivalentTo(System.Type)
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
       mov       rdx,7FFE00644000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE00996790]
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
       call      qword ptr [7FFE00B05FC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L13:
       test      ebx,10000
       je        short M01_L14
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFE0099F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFE00E5DE00]
       jmp       near ptr M01_L08
M01_L14:
       test      rsi,rsi
       jne       short M01_L15
       call      qword ptr [7FFE006E5FC8]; System.Type.get_DefaultBinder()
       mov       rsi,rax
M01_L15:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.PropertyInfo>
       call      qword ptr [7FFE0099F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
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
       mov       rsi,2D6D0C65820
       mov       rcx,rsi
       call      qword ptr [7FFE00786688]; System.String.IsNullOrWhiteSpace(System.String)
       test      eax,eax
       jne       near ptr M00_L04
       xor       eax,eax
       mov       [rsp+28],rax
       mov       ebp,1
       mov       [rsp+28],rax
       mov       eax,32
       xor       ecx,ecx
       cmp       ebp,32
       setle     cl
       mov       edx,ecx
       test      ecx,ecx
       je        near ptr M00_L05
M00_L00:
       test      edx,edx
       je        near ptr M00_L06
M00_L01:
       cmp       ebp,8
       jg        short M00_L02
       cmp       eax,8
       jl        short M00_L02
       lea       rcx,[rdi+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rdi
       mov       rbx,[rbx+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       call      qword ptr [7FFE00CBC918]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L03
       call      qword ptr [7FFE00CB67D8]
       mov       r14,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2D6D0C597B0
       mov       r8,r14
       call      qword ptr [7FFE0083D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0A6B
       mov       rdx,7FFE00B163D0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      qword ptr [7FFE00CB67C0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFE00986718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M00_L05:
       movzx     ecx,byte ptr [rsp+28]
       test      cl,cl
       je        near ptr M00_L00
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE008347B0]
       jmp       near ptr M00_L01
M00_L06:
       call      qword ptr [7FFE00CB69B8]
       mov       r14,rax
       test      r14,r14
       jne       short M00_L07
       call      qword ptr [7FFE00CB67D8]
       mov       r14,rax
M00_L07:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2D6D0C5FD70
       mov       r8,r14
       call      qword ptr [7FFE0083D470]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 533
```
```assembly
; System.String.IsNullOrWhiteSpace(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M01_L05
       xor       esi,esi
       mov       edi,[rbx+8]
       test      edi,edi
       jle       short M01_L04
M01_L00:
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L01
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFE01145740]
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       inc       esi
       cmp       edi,esi
       jg        short M01_L00
M01_L04:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,[rbx+40]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CB2080]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.ToString()
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
; 	public override string ToString() => this.PropertiesToString(includeMemberName: false);
; 	                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass15_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,220BF4D8E78
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
       call      qword ptr [7FFE006F6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdi,rax
       mov       rcx,220BF4DCAC8
       xor       edx,edx
       call      qword ptr [7FFE006F6DA8]; System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,4
       call      qword ptr [7FFE007A61D8]; System.String.Equals(System.String, System.String, System.StringComparison)
       mov       rdx,220BF4D0008
       mov       rcx,220BF4D5338
       test      eax,eax
       cmovne    rdx,rcx
       mov       rcx,rbx
       mov       r8d,1
       call      qword ptr [7FFE00C94D68]; DotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rbx,rax
       mov       rcx,offset MT_System.Func<System.String, System.Collections.Generic.KeyValuePair<System.String, System.String>, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset DotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass15_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rdi+18],r9
       mov       r9,rdi
       mov       rdx,rbx
       mov       rcx,7FFE01258A70
       mov       r8,220BF4D0008
       call      qword ptr [7FFE0124D2C0]; System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rbx,rax
       mov       rdx,[rsi+8]
       mov       rcx,rbx
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE007A62F8]; System.String.StartsWith(System.String, System.StringComparison)
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
       jmp       qword ptr [7FFE007A7240]; System.String.Substring(Int32, Int32)
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       call      qword ptr [7FFE00CD69D0]
       mov       ecx,807
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B37000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CD67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       call      qword ptr [7FFE00CD69D0]
       mov       ecx,855
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B37000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C8C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE007A6B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CD67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE009A6718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rax,rbx
       jmp       near ptr M01_L00
; Total bytes of code 628
```

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00CBCC78]; System.Text.Json.JsonSerializerOptions.get_Default()
       mov       [rsp+30],rax
       lea       rdx,[rsp+30]
       mov       rcx,rsi
       call      qword ptr [7FFE00C74DC8]; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
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
       mov       rax,1A96D404990
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L00
       ret
M01_L00:
       mov       rcx,1A96D404990
       xor       edx,edx
       jmp       qword ptr [7FFE00CBD350]; System.Text.Json.JsonSerializerOptions.GetOrCreateSingleton(System.Text.Json.JsonSerializerOptions ByRef, System.Text.Json.JsonSerializerDefaults)
; Total bytes of code 37
```
```assembly
; DotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object, System.Text.Json.JsonSerializerOptions ByRef)
; 		obj = obj.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return SimpleResult.FromValue(JsonSerializer.Serialize(obj, options));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 		catch (NotSupportedException ex)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return SimpleResult.FromException<string>(ex);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       jne       near ptr M02_L05
M02_L03:
       lea       rdx,[rbp-28]
       mov       rcx,7FFE01058DF8
       call      qword ptr [7FFE00FBDA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.SimpleResult<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.Concurrent.ConcurrentBag<System.Exception>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>
       call      CORINFO_HELP_NEWFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Threading.ThreadLocal<System.Collections.Concurrent.ConcurrentBag<System.Exception>+WorkStealingQueue>+LinkedSlot
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+18],rcx
       lea       rcx,[r14+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       byte ptr [r14+1D],0
       mov       rcx,1A969401FC0
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FFE0122E568]; System.Threading.ThreadLocal`1+IdManager[[System.__Canon, System.Private.CoreLib]].GetId(Boolean)
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
       call      qword ptr [7FFE00CB69D0]
       mov       ecx,1F59
       mov       rdx,7FFE00B17000
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B17000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0DE3
       mov       rdx,7FFE00B17000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CB67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00986718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L05:
       call      qword ptr [7FFE007843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M02_L06:
       mov       rcx,rbx
       mov       byte ptr [rbp-30],1
       mov       byte ptr [rbp-2F],1
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       [rsp+28],r9d
       movzx     r9d,word ptr [rbp-30]
       mov       rdx,1E9F7342008
       mov       r8d,1
       call      qword ptr [7FFE00CBCB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       mov       rsi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       near ptr M02_L02
M02_L07:
       mov       rcx,rbx
       call      qword ptr [7FFE00CBD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
       jmp       near ptr M02_L01
M02_L08:
       call      qword ptr [7FFE00CBCC78]; System.Text.Json.JsonSerializerOptions.get_Default()
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
       call      qword ptr [7FFE00CB69D0]
       mov       ecx,807
       mov       rdx,7FFE00C6C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B17000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C6C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00786B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CB67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00986718]
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
       mov       rcx,7FFE0123ACD0
       call      qword ptr [7FFE0122D6F8]
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,1DFA0003EF0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE00CAD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE00CACBB8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FFE01048FF8
       call      qword ptr [7FFE00FADA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE00CA69D0]
       mov       ecx,807
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B07000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C5C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00776B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CA67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00976718]
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
       call      qword ptr [7FFE00CADFE0]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE00D1F660]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAD9E0]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       xor       r8d,r8d
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D22048
       mov       r8d,1
       call      qword ptr [7FFE00D1F870]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FFE00D22150
       mov       r9d,2
       call      qword ptr [7FFE00D1F8A0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE00D1F8E8]
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
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CAD2A8]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D1F780]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE00774360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CAF348]
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
       mov       rdx,22029DE2008
       mov       r8d,1
       call      qword ptr [7FFE00CACB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE00CAD320]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
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
       mov       rcx,1DF9C001F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE00F79658]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,22029DE1B28
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
       call      qword ptr [7FFE00D1EE08]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00D44540]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE010551E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE00CDC6E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DFA00049D0
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE00FAE658]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE01054CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE00FAE7D8]
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
       cmp       dword ptr [rcx+190],2
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,2
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
       call      qword ptr [7FFE00AE57E8]
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
       call      qword ptr [7FFE00825BA8]
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1DF9C001F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00F79660]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FFE007743A8]
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
       call      00007FFE00771E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00825B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00AE5D58]
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
       mov       rax,22029DE0008
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       mov       rcx,1C2AC80F4A0
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9E],0
       jne       short M00_L00
       mov       rcx,rsi
       call      qword ptr [7FFE00CCD2A8]; System.Text.Json.JsonSerializerOptions.ConfigureForJsonSerializer()
M00_L00:
       mov       rcx,rsi
       call      qword ptr [7FFE00CCCBB8]; System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       r8,rax
       test      r8,r8
       jne       short M00_L02
M00_L01:
       lea       rdx,[rsp+30]
       mov       rcx,7FFE01068FF8
       call      qword ptr [7FFE00FCDA58]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<System.Object>
       cmp       [r8],rcx
       je        short M00_L01
       mov       rdx,rax
       call      qword ptr [7FFE007943F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       call      qword ptr [7FFE00CC69D0]
       mov       ecx,807
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CC67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
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
       call      qword ptr [7FFE00CCDFE0]; System.Text.Json.JsonSerializer.get_IsReflectionEnabledByDefault()
       test      eax,eax
       je        near ptr M01_L05
       call      qword ptr [7FFE00D3F660]; System.Text.Json.Serialization.Metadata.DefaultJsonTypeInfoResolver.get_DefaultInstance()
       mov       [rbp-18],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L02
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CCD9E0]
       test      eax,eax
       je        near ptr M01_L09
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-10],xmm0
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D42048
       xor       r8d,r8d
       call      qword ptr [7FFE00D3F870]
       mov       rdx,[rbp-28]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rdx,[rbp-10]
       mov       rcx,7FFE00D42048
       mov       r8d,1
       call      qword ptr [7FFE00D3F870]
       mov       rdx,[rbp-18]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbp-48]
       lea       r8,[rbp-10]
       mov       rdx,7FFE00D42150
       mov       r9d,2
       call      qword ptr [7FFE00D3F8A0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+60]
       mov       [rbp-60],rcx
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-58],xmm0
       lea       rcx,[rbp-58]
       call      qword ptr [7FFE00D3F8E8]
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
       call      qword ptr [7FFE00D3F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       cmp       rax,[rbp+10]
       je        short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D3F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       movzx     ecx,byte ptr [rax+9E]
       test      ecx,ecx
       jne       short M01_L04
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D3F708]; System.Text.Json.JsonSerializerOptions+CachingContext.get_Options()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE00CCD2A8]
       jmp       short M01_L09
M01_L04:
       mov       rcx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00D3F780]
       jmp       short M01_L09
M01_L05:
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       mov       [rbp-30],rdx
       cmp       qword ptr [rbp-30],0
       je        short M01_L06
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.EmptyJsonTypeInfoResolver
       call      qword ptr [7FFE00794360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FFE00CCF348]
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
       mov       rdx,2033E702008
       mov       r8d,1
       call      qword ptr [7FFE00CCCB58]; System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
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
       call      qword ptr [7FFE00CCD320]; System.Text.Json.JsonSerializerOptions.GetWriterOptions()
       mov       edi,[rdi+7C]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+190],2
       jl        near ptr M03_L11
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
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
       mov       rcx,1C2B0801F20
       mov       rcx,[rcx]
       mov       edx,edi
       call      qword ptr [7FFE00F99568]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Rent(Int32)
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
       mov       rdi,2033E701B28
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
       call      qword ptr [7FFE00D3EE08]; System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.__Canon, System.Private.CoreLib]].Serialize(System.Text.Json.Utf8JsonWriter, System.__Canon ByRef, System.Object)
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
       call      qword ptr [7FFE00B057E8]
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
       call      qword ptr [7FFE00D64540]; System.Text.Json.JsonReaderHelper.TranscodeHelper(System.ReadOnlySpan`1<Byte>)
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
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       r14,[rax]
       test      r14,r14
       jne       near ptr M03_L00
M03_L12:
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriterCache+ThreadLocalState
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFE010751E8]; System.Text.Json.Utf8JsonWriterCache+ThreadLocalState..ctor()
       mov       ecx,2
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE_NOCTOR_OPTIMIZED
       mov       rcx,rax
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M03_L00
M03_L13:
       mov       rcx,7FFE00CFC6E8
       mov       edx,69
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C2AC80FF80
       mov       rdi,[rcx]
       jmp       near ptr M03_L03
M03_L14:
       lea       rcx,[r14+68]
       mov       edx,3E8
       call      qword ptr [7FFE00FCE658]; System.Text.Json.JsonWriterOptions.set_MaxDepth(Int32)
       jmp       near ptr M03_L04
M03_L15:
       mov       rcx,offset MT_System.Text.Json.PooledByteBufferWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFE01074CF0]
       mov       [rbp-90],r14
       mov       rcx,offset MT_System.Text.Json.Utf8JsonWriter
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdx,r14
       vmovdqu   xmm0,xmmword ptr [rbp-48]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       rcx,r13
       lea       r8,[rbp-70]
       call      qword ptr [7FFE00FCE7D8]
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
       cmp       dword ptr [rcx+190],2
       jl        short M03_L17
       mov       rcx,[rcx+198]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M03_L18
M03_L17:
       mov       ecx,2
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
       call      qword ptr [7FFE00B057E8]
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
       call      qword ptr [7FFE00845BA8]; System.Buffer._ZeroMemory(Byte ByRef, UIntPtr)
M03_L25:
       xor       ecx,ecx
       mov       [r14+20],ecx
       mov       rdx,[r14+10]
       mov       [r14+10],rcx
       mov       rcx,1C2B0801F20
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFE00F99570]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].Return(Byte[], Boolean)
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
       jmp       qword ptr [7FFE007943A8]
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
       call      00007FFE00791E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00B05D58]
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
       mov       rax,2033E700008
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE012A6550]; System.Data.DataTable..ctor()
       mov       rcx,2BD2D7C57F8
       mov       [rbx+70],rcx
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFE00C84E10]; DotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
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
       mov       rsi,2BD2D7B0008
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+80]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+1C4],1
       mov       dword ptr [rbx+1B0],19
       mov       rcx,2BD2D7C5898
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1D8],xmm0
       vmovups   xmm0,[rcx]
       vmovups   [rbx+1E8],xmm0
       mov       rcx,2BD2D7C5970
       mov       [rbx+0D8],rcx
       mov       byte ptr [rbx+1CC],1
       mov       rcx,27C9F801FD8
       mov       rdx,[rcx]
       lea       rcx,[rbx+110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Data.DataView>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,27C9F801FE0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+180]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Data.DataViewListener>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,27C9F801FE8
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
       mov       rcx,7FFE006D5C48
       mov       edx,1
       lock xadd [rcx],rdx
       inc       rdx
       mov       [rax+28],rdx
       lea       rcx,[rbx+198]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+1B8],0FFFFFFFF
       mov       rcx,7FFE0129B9D8
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+1C0],eax
       mov       rcx,rbx
       call      qword ptr [7FFE00995920]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,27C9F814D08
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
       mov       rdx,2BD2D7C5818
       call      qword ptr [7FFE00796C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE008476D8]
M01_L00:
       mov       qword ptr [rbx+1A0],1
       mov       rcx,offset MT_System.Data.RecordManager
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE012AEC40]; System.Data.RecordManager..ctor(System.Data.DataTable)
       lea       rcx,[rbx+50]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE0096E1C0]; System.Globalization.CultureInfo.get_CurrentCulture()
       lea       rcx,[rbx+90]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataColumnCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE012AD008]; System.Data.DataColumnCollection..ctor(System.Data.DataTable)
       lea       rcx,[rbx+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.ConstraintCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Collections.ArrayList
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,27C9F801E58
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
       call      qword ptr [7FFE012ADD88]; System.Data.RBTree`1[[System.__Canon, System.Private.CoreLib]].InitTree()
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Data.Index>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,27C9F802000
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
; 		if (obj is null)
; 		^^^^^^^^^^^^^^^^
; 			if (obj is IAsyncDisposable asyncDisposable)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				var result = asyncDisposable.DisposeAsync();
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				if (result.IsFaulted)
; 				^^^^^^^^^^^^^^^^^^^^^
; 					ExceptionThrower.ThrowInvalidOperationException(Resources.ThereIsAnIssueDisposingOfTheObjectUsingAsyncDispose);
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				obj.Dispose();
; 				^^^^^^^^^^^^^^
; 		catch
; 		^^^^^
; 			if (throwException)
; 			^^^^^^^^^^^^^^^^^^^
; 				throw;
; 				^^^^^^
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
       call      qword ptr [7FFE00794348]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Data.DataTable
       cmp       [rbx],rcx
       jne       short M02_L02
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFE0129D6D8]; System.ComponentModel.MarshalByValueComponent.Dispose(Boolean)
       mov       rcx,rbx
       call      System.GC._SuppressFinalize(System.Object)
       jmp       short M02_L04
M02_L00:
       call      qword ptr [7FFE012F6AF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L01
       call      qword ptr [7FFE00CC6928]
       mov       rbx,rax
M02_L01:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE009B5F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L02:
       mov       rcx,rbx
       mov       r11,7FFE00651188
       call      qword ptr [r11]
       jmp       short M02_L04
M02_L03:
       lea       rdx,[rbp-20]
       mov       rcx,rax
       mov       r11,7FFE00651190
       call      qword ptr [r11]
       lea       rcx,[rbp-20]
       call      qword ptr [7FFE012F65E0]
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00C852D8]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      qword ptr [7FFE00CC69D0]
       mov       ecx,807
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00CC67C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE00996718]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 225
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(lower: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().ClearSetCapacity(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
; 				_ = sb.Append(GenerateCharacter(minCharacter, maxCharacter));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString().Trim();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       mov       rcx,2C87F402348
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
       call      qword ptr [7FFE009DD0F8]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,r15
       mov       edx,ebx
       call      qword ptr [7FFE009DD050]; System.Text.StringBuilder.set_Capacity(Int32)
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
       call      qword ptr [7FFE00CC5110]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFE009E32D8]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       mov       esi,[r14+8]
       test      esi,esi
       je        short M01_L15
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jae       short M01_L12
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L13
M01_L08:
       mov       edx,eax
       jmp       short M01_L05
M01_L09:
       mov       rcx,r15
       call      qword ptr [7FFE009DD2F0]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L06
M01_L10:
       call      CORINFO_HELP_OVERFLOW
M01_L11:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFE007973F0]
       jmp       short M01_L16
M01_L12:
       call      qword ptr [7FFE01155740]
       test      eax,eax
       jne       short M01_L11
M01_L13:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L14
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L11
       jmp       short M01_L15
M01_L14:
       call      qword ptr [7FFE01155740]
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
       call      qword ptr [7FFE008447B0]
       mov       ebx,eax
       jmp       near ptr M01_L01
M01_L18:
       call      qword ptr [7FFE00CC69B8]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M01_L19
       call      qword ptr [7FFE00CC67D8]
       mov       rsi,rax
M01_L19:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,30909388868
       mov       r8,rsi
       call      qword ptr [7FFE0084D470]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FFE00F8F1C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       call      qword ptr [7FFE00CC69D0]
       mov       ecx,9E8
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,1C09
       mov       rdx,7FFE00B27000
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,1
       mov       rdx,7FFE00C7C970
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE00796B08]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      qword ptr [7FFE00CC67C0]
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r12
       call      qword ptr [7FFE00996718]
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
       mov       rcx,2C87F402348
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
       call      qword ptr [7FFE009DD0F8]; System.Text.StringBuilder.set_Length(Int32)
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
       call      qword ptr [7FFE00F8F198]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
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
       call      00007FFE00791E60
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       movsxd    r8,r14d
       lea       rcx,[r15+r8*2+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,ebp
       add       r8,r8
       call      qword ptr [7FFE00845B78]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFE00B05D58]
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
       mov       rax,30909380008
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rdx,rax
       mov       rcx,7FFE01225C08
       call      qword ptr [7FFE0121C5E8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       call      qword ptr [7FFE00CA6A78]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L03
       call      qword ptr [7FFE00CA67C0]
       mov       rbx,rax
M00_L03:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21BAE3D57F8
       mov       r8,rbx
       call      qword ptr [7FFE00976718]
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
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L01
M01_L00:
       call      qword ptr [7FFE01135740]
       test      eax,eax
       jne       short M01_L04
M01_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jae       short M01_L02
       mov       rax,7FFE5F0C2E50
       test      byte ptr [rcx+rax],80
       jne       short M01_L04
       jmp       short M01_L03
M01_L02:
       call      qword ptr [7FFE01135740]
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
       call      qword ptr [7FFE007773F0]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
; 		json = json.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return JsonSerializer.Deserialize<TResult>(json, _options) ??
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				throw new InvalidOperationException($"Failed to deserialize the JSON string to {typeof(TResult)}.");
; 				                                                                                                    
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
       call      qword ptr [7FFE00777318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
M02_L02:
       mov       r8,1DB24402C08
       mov       r8,[r8]
       mov       rdx,rbx
       call      qword ptr [7FFE0121C648]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       test      rax,rax
       je        near ptr M02_L12
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFE012091B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
       jmp       short M02_L02
M02_L04:
       lea       rcx,[rsp+28]
       mov       rdx,21BAE3D5A20
       call      qword ptr [7FFE00A35F38]
M02_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       r8,rax
       lea       rcx,[rsp+28]
       mov       rdx,7FFE01225DD0
       call      qword ptr [7FFE00BC4138]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ebx,[rsp+38]
       cmp       ebx,[rsp+48]
       jbe       short M02_L07
M02_L06:
       call      qword ptr [7FFE00AE57E8]
       int       3
M02_L07:
       mov       rcx,[rsp+40]
       mov       edx,ebx
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+48]
       sub       edx,ebx
       cmp       edx,1
       jb        short M02_L08
       mov       rdx,21BAE3C076C
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       mov       ecx,[rsp+38]
       inc       ecx
       mov       [rsp+38],ecx
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsp+28]
       mov       rdx,21BAE3C0760
       call      qword ptr [7FFE00A35F38]
M02_L09:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+28]
       call      qword ptr [7FFE00A35D88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00995F68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L10:
       call      qword ptr [7FFE00CA6A78]
       mov       rsi,rax
       test      rsi,rsi
       jne       short M02_L11
       call      qword ptr [7FFE00CA67C0]
       mov       rsi,rax
M02_L11:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,21BAE3D57F8
       mov       r8,rsi
       call      qword ptr [7FFE00976718]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L12:
       lea       rcx,[rsp+28]
       mov       edx,2A
       mov       r8d,1
       call      qword ptr [7FFE00A35CF8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
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
       mov       rcx,21BAE3D5A2C
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

## .NET 8.0.22 (8.0.2225.52707), X64 RyuJIT AVX2
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
       call      qword ptr [7FFE0121CC78]; System.Data.DataSet..ctor()
       mov       rcx,1A0BC007760
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
       mov       r8,1E145D157F8
       mov       [rbp-38],r8
       lea       r8,[rbp-40]
       mov       [rbp-70],r8
       mov       dword ptr [rbp-68],2
       lea       r8,[rbp-70]
       xor       ecx,ecx
       mov       rdx,1E145D15990
       call      qword ptr [7FFE00776C88]
       mov       r8,rax
       mov       rcx,r14
       mov       edx,1
       call      qword ptr [7FFE008276D8]
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
       je        near ptr M00_L28
       mov       rcx,r14
       mov       rdx,1E145D157F8
       call      qword ptr [7FFE0121E4F0]; System.Data.DataTableCollection.InternalIndexOf(System.String, System.String)
       cmp       eax,0FFFFFFFE
       je        near ptr M00_L29
       test      eax,eax
       jge       near ptr M00_L30
       xor       r15d,r15d
M00_L02:
       test      r15,r15
       jne       near ptr M00_L31
M00_L03:
       mov       rcx,offset MT_System.ComponentModel.PropertyChangedEventArgs
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,1E145D15960
       mov       [rax+8],rcx
       mov       r10,[rdi+68]
       test      r10,r10
       jne       near ptr M00_L32
M00_L04:
       mov       rcx,1E145D157F8
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
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
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
       call      qword ptr [7FFE006C6658]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       short M00_L06
M00_L09:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE0097F6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
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
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.FieldInfo>
       call      qword ptr [7FFE0097F438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M00_L12:
       inc       r14d
       cmp       edi,r14d
       jg        short M00_L11
M00_L13:
       mov       rsi,[rbp-58]
       mov       rdi,[rbp-50]
       mov       r14d,[rbp-48]
       test      r14d,r14d
       je        near ptr M00_L21
       cmp       r14d,1
       je        near ptr M00_L20
       test      r14d,r14d
       jl        near ptr M00_L25
       mov       r15,rsi
       test      r15,r15
       je        near ptr M00_L24
       cmp       [rsi+8],r14d
       jne       short M00_L17
M00_L14:
       mov       r15,rsi
M00_L15:
       xor       edi,edi
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L26
M00_L16:
       mov       ecx,edi
       mov       r14,[r15+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [r14],rcx
       jne       near ptr M00_L22
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FFE009F2290]; System.Reflection.RtFieldInfo.GetValue(System.Object)
       jmp       short M00_L18
M00_L17:
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
       mov       rcx,7FFE009FE258
       call      qword ptr [7FFE00994690]; System.Buffer.Memmove[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon ByRef, UIntPtr)
       jmp       short M00_L14
M00_L18:
       test      rax,rax
       je        short M00_L23
M00_L19:
       inc       edi
       cmp       [r15+8],edi
       jg        short M00_L16
       jmp       near ptr M00_L26
M00_L20:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,rdi
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M00_L15
M00_L21:
       mov       rcx,1A0B4001EE0
       mov       r15,[rcx]
       jmp       near ptr M00_L15
M00_L22:
       mov       rcx,r14
       mov       rdx,r13
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       jmp       short M00_L18
M00_L23:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+78]
       call      qword ptr [rax+8]
       test      eax,eax
       jne       short M00_L19
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rcx,rax
       mov       edx,1
       mov       r8d,1
       call      qword ptr [7FFE009760D0]; System.Activator.CreateInstance(System.Type, Boolean, Boolean)
       mov       r8,rax
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [7FFE009B5110]
       jmp       near ptr M00_L19
M00_L24:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rsi,rax
       jmp       near ptr M00_L14
M00_L25:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE00AE5B60]
       int       3
M00_L26:
       mov       rcx,[rbp-78]
       mov       [rbp-60],rcx
       mov       rcx,[rbx+18]
       lea       r8,[rbp-60]
       mov       rdx,7FFE01261B30
       cmp       [rcx],ecx
       call      qword ptr [7FFE01274CD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       mov       rcx,[rbp-78]
       cmp       byte ptr [rcx+10],0
       jne       short M00_L27
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0122B030]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L27:
       call      qword ptr [7FFE00975920]; System.GC.SuppressFinalize(System.Object)
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
M00_L28:
       mov       ecx,0C0E8
       mov       rdx,7FFE01227210
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE012C48B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L29:
       mov       ecx,179
       mov       rdx,7FFE00B052C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE012C4978]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L30:
       mov       rcx,[r14+10]
       mov       edx,eax
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rcx,offset MT_System.Data.DataTable
       call      qword ptr [7FFE007743D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M00_L02
M00_L31:
       cmp       byte ptr [r15+1C4],0
       jne       near ptr M00_L03
       mov       ecx,179
       mov       rdx,7FFE00B052C0
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE012C5800]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L32:
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
       jne       short M00_L33
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFE0122B030]; System.ComponentModel.MarshalByValueComponent.Dispose()
       mov       rcx,[rbp-78]
       mov       byte ptr [rcx+10],1
M00_L33:
       call      qword ptr [7FFE00975920]; System.GC.SuppressFinalize(System.Object)
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
; Total bytes of code 1392
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
       mov       rcx,1E145D15818
       mov       [rbx+38],rcx
       lea       rcx,[rbx+40]
       mov       rsi,1E145D00008
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
       mov       rcx,7FFE01229334
       mov       eax,1
       lock xadd [rcx],eax
       inc       eax
       mov       [rbx+94],eax
       mov       rcx,rbx
       call      qword ptr [7FFE00975920]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,1A0BC007760
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
       mov       rdx,1E145D15848
       call      qword ptr [7FFE00776C88]
       mov       r8,rax
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FFE008276D8]
M01_L00:
       mov       rcx,offset MT_System.Data.DataTableCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE0121E190]; System.Data.DataTableCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Data.DataRelationCollection+DataSetRelationCollection
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE0121E0A0]; System.Data.DataRelationCollection+DataSetRelationCollection..ctor(System.Data.DataSet)
       lea       rcx,[rbx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE0094E1C0]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FFE007743D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r13,rax
       mov       r9,[rsi+8]
       mov       r9,[r9+50]
       mov       rcx,[r13+70]
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE0121DCE0]
       mov       r12d,eax
       cmp       r12d,1
       jne       short M02_L03
       mov       rcx,r13
       call      qword ptr [7FFE0121F498]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE007761C0]; System.String.Equals(System.String, System.String)
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
       call      qword ptr [7FFE0121F498]
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFE007761C0]; System.String.Equals(System.String, System.String)
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
       je        near ptr M03_L07
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L14
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L06
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
       jne       near ptr M03_L04
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
       mov       rax,7FFE0096C1E8
       mov       [rbp-0B8],rax
       lea       rax,[M03_L02]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFE601BC690
       call      rax
M03_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE6063917C],0
       je        short M03_L03
       call      qword ptr [7FFE606293B8]; CORINFO_HELP_STOP_FOR_GC
M03_L03:
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
M03_L04:
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
       je        short M03_L05
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rax],rcx
       jne       near ptr M03_L15
M03_L05:
       test      rax,rax
       cmovne    rdi,rax
M03_L06:
       mov       rax,rdi
       jmp       near ptr M03_L12
M03_L07:
       mov       [rbp+10],rbx
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE00775440]; System.RuntimeTypeHandle.GetNativeHandle()
       mov       [rbp-48],rax
       lea       rcx,[rbp-48]
       mov       rdx,[rbp-48]
       test      rdx,rdx
       je        near ptr M03_L11
       mov       rax,[rdx+18]
M03_L08:
       mov       [rbp-68],rcx
       mov       [rbp-60],rax
       lea       rcx,[rbp-68]
       mov       edx,1
       mov       rax,7FFE0076BF28
       mov       [rbp-0B8],rax
       lea       rax,[M03_L09]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C8]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       mov       rax,7FFE601D8930
       call      rax
M03_L09:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFE6063917C],0
       je        short M03_L10
       call      qword ptr [7FFE606293B8]; CORINFO_HELP_STOP_FOR_GC
M03_L10:
       mov       rcx,[rbp-0C0]
       mov       [rsi+10],rcx
       mov       rdx,rax
       mov       rbx,[rbp+10]
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       jne       short M03_L13
       jmp       near ptr M03_L00
M03_L11:
       xor       eax,eax
       jmp       near ptr M03_L08
M03_L12:
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
M03_L13:
       lea       rcx,[rbp-40]
       call      qword ptr [7FFE00775998]
       jmp       near ptr M03_L00
M03_L14:
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M03_L15:
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
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
       mov       rax,4861E258EE47
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M04_L00
       cmp       dword ptr [rbx+8],0
       jne       short M04_L03
M04_L00:
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFE0097F708]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M04_L01:
       lea       rdx,[rbp+20]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFE0097F720]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+20]
       mov       rcx,4861E258EE47
       cmp       [rbp+8],rcx
       je        short M04_L02
       call      CORINFO_HELP_FAIL_FAST
M04_L02:
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
M04_L03:
       cmp       r14d,1
       je        near ptr M04_L08
M04_L04:
       mov       r15d,[rbx+8]
       lea       rcx,[rbx+0C]
       mov       [rbp+18],rcx
       mov       r13,[rbp+18]
       mov       rcx,1A0B40009F0
       mov       rcx,[rcx]
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE009827C8]; Precode of System.Text.UTF8Encoding.GetByteCount(Char*, Int32)
       mov       r12d,eax
       cmp       r12d,400
       jg        near ptr M04_L09
       mov       ecx,r12d
       mov       r9,rcx
       test      r9,r9
       je        short M04_L06
       mov       rdx,r9
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,40
       neg       rdx
       add       rdx,rsp
       jb        short M04_L05
       xor       edx,edx
M04_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M04_L05
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,40
       lea       r9,[rsp+40]
M04_L06:
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       mov       rdx,r13
       mov       r8d,r15d
       call      qword ptr [7FFE0097F708]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
M04_L07:
       xor       edx,edx
       mov       [rbp+18],rdx
       jmp       near ptr M04_L01
M04_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M04_L04
       cmp       word ptr [rbx+0C],2A
       je        near ptr M04_L04
       jmp       near ptr M04_L00
M04_L09:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       cmp       dword ptr [rax+8],0
       jbe       short M04_L10
       add       rax,10
       mov       [rbp+10],rax
       mov       rdx,r13
       mov       r8d,r15d
       mov       r9,[rbp+10]
       mov       [rsp+20],r12d
       mov       [rsp+28],edi
       mov       [rsp+30],r14d
       mov       rcx,rsi
       call      qword ptr [7FFE0097F708]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(Char*, Int32, Byte*, Int32, MemberListType, CacheType)
       mov       [rbp+20],rax
       xor       eax,eax
       mov       [rbp+10],rax
       jmp       short M04_L07
M04_L10:
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
       jne       short M05_L00
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L04
M05_L00:
       cmp       edi,1
       jne       near ptr M05_L07
       cmp       dword ptr [rbx+14],2
       jl        short M05_L02
M05_L01:
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       cmp       qword ptr [rdx+8],30
       jle       short M05_L05
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M05_L05
       mov       [rsp+20],rdx
       jmp       short M05_L06
M05_L02:
       mov       dword ptr [rbx+14],4
       jmp       short M05_L01
M05_L03:
       movsxd    rdx,dword ptr [rbx+10]
       mov       rcx,[rbx]
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
M05_L04:
       inc       dword ptr [rbx+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L05:
       mov       rdx,7FFE01140CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M05_L06:
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
       jmp       short M05_L03
M05_L07:
       cmp       [rbx+14],edi
       jne       short M05_L03
       mov       edi,[rbx+14]
       add       edi,edi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M05_L08
       mov       rcx,rax
       jmp       short M05_L09
M05_L08:
       mov       rdx,7FFE01140C50
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M05_L09:
       mov       rdx,rbx
       mov       r8d,edi
       call      qword ptr [7FFE00994660]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbx+14],edi
       jmp       near ptr M05_L03
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
       je        near ptr M06_L08
       mov       eax,[rbx+38]
M06_L00:
       mov       rcx,[rbx+8]
       cmp       byte ptr [rcx+94],0
       jne       near ptr M06_L13
       mov       rdi,[rbx+10]
M06_L01:
       test      rdi,rdi
       je        short M06_L02
       mov       rcx,offset MT_System.RuntimeType
       xor       edx,edx
       cmp       [rdi],rcx
       cmovne    rdi,rdx
M06_L02:
       test      al,2
       jne       near ptr M06_L12
       test      byte ptr [rbx+1C],10
       jne       short M06_L03
       mov       rcx,[rbx+10]
       cmp       [rcx],cl
       mov       rdx,rsi
       call      System.RuntimeTypeHandle.IsInstanceOfType(System.RuntimeType, System.Object)
       test      eax,eax
       je        near ptr M06_L15
M06_L03:
       mov       rdx,[rbx+28]
       test      rdx,rdx
       je        near ptr M06_L09
M06_L04:
       mov       rbp,rdx
       test      rbp,rbp
       je        short M06_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M06_L17
M06_L05:
       xor       ecx,ecx
       mov       [rsp+28],ecx
       test      rdi,rdi
       je        near ptr M06_L18
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M06_L10
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L10
M06_L06:
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
       je        short M06_L11
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L11
M06_L07:
       mov       [rax+95],bl
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L08:
       mov       rcx,rbx
       call      qword ptr [7FFE009EC8D0]; System.Reflection.RtFieldInfo.InitializeInvocationFlags()
       jmp       near ptr M06_L00
M06_L09:
       mov       rcx,rbx
       call      qword ptr [7FFE009ECA98]; System.Reflection.RtFieldInfo.InitializeFieldType()
       mov       rdx,rax
       jmp       near ptr M06_L04
M06_L10:
       mov       rcx,rdi
       call      qword ptr [7FFE006C6658]; System.RuntimeType.InitializeCache()
       jmp       short M06_L06
M06_L11:
       mov       rcx,rdi
       call      qword ptr [7FFE006C6658]; System.RuntimeType.InitializeCache()
       jmp       short M06_L07
M06_L12:
       test      rdi,rdi
       je        short M06_L14
       mov       rcx,rbx
       call      qword ptr [7FFE009AAA98]; System.Reflection.RuntimeFieldInfo.get_DeclaringType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       test      eax,eax
       je        short M06_L14
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE00D4FC48]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE00995F68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M06_L13:
       xor       edi,edi
       jmp       near ptr M06_L01
M06_L14:
       mov       rcx,offset MT_System.FieldAccessException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFE00C27090]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L15:
       test      rsi,rsi
       jne       short M06_L16
       mov       rcx,offset MT_System.Reflection.TargetException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFE00D6C1B0]
       mov       rdx,rax
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFE0099E508]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M06_L16:
       call      qword ptr [7FFE00D4EEB0]
       mov       rbp,rax
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFE009F2240]
       mov       r14,rax
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       r9,rax
       mov       rdx,r14
       mov       r8,rbx
       mov       rcx,rbp
       call      qword ptr [7FFE00D4E7C0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFE0077F708]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M06_L17:
       call      qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M06_L18:
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
       mov       rcx,7FFE01153EF4
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
       jmp       qword ptr [7FFE00825BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
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
       je        short M08_L02
       mov       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       r11,[rcx]
       jne       short M08_L00
       jmp       short M08_L01
M08_L00:
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rcx,rax
M08_L01:
       call      qword ptr [7FFE5FB1EF00]
       test      rax,rax
       je        short M08_L03
       xor       edx,edx
       test      bl,bl
       sete      dl
       movzx     r8d,sil
       mov       rcx,rax
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M08_L02:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE5FB23938]
       int       3
M08_L03:
       call      qword ptr [7FFE5FB1BF98]
       mov       rbx,rax
       call      qword ptr [7FFE5FB252B8]
       mov       rdx,rax
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       rcx,rbx
       call      qword ptr [7FFE5FB238E8]
       mov       rcx,rbx
       call      qword ptr [7FFE5FB13D08]; CORINFO_HELP_THROW
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
       jmp       qword ptr [7FFE00975920]; System.GC.SuppressFinalize(System.Object)
; Total bytes of code 40
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       sub       rsp,28
       test      rcx,rcx
       je        short M11_L00
       add       rsp,28
       jmp       near ptr System.GC._SuppressFinalize(System.Object)
M11_L00:
       mov       ecx,12E9
       mov       rdx,7FFE00624000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE00976790]
       int       3
; Total bytes of code 48
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M12_L00
       cmp       [rdx],rcx
       jne       short M12_L01
M12_L00:
       mov       rax,rdx
       ret
M12_L01:
       jmp       qword ptr [7FFE007743F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
**Extern method**
System.Object.GetType()
System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)

