## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetDescription01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+118]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFF82C6F6A8]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
       mov       rcx,rbx
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rsi,rax
       mov       rcx,offset MT_System.StringComparison
       cmp       [rbx],rcx
       jne       near ptr M01_L10
       mov       rcx,rbx
       call      qword ptr [7FFF824173B8]; System.Enum.ToString()
M01_L00:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1C
       call      qword ptr [7FFF8241A630]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       mov       r8,offset MT_System.Reflection.MdFieldInfo
       cmp       [rsi],r8
       jne       near ptr M01_L13
       mov       rdi,2923E3F2EE0
       test      rdi,rdi
       je        near ptr M01_L11
       mov       r8,offset MT_System.RuntimeType
       cmp       [rdi],r8
       jne       near ptr M01_L11
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+28],xmm0
       vmovdqu   xmmword ptr [rsp+30],xmm0
       lea       r8,[rsp+28]
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFF827863E8]; System.Reflection.PseudoCustomAttribute.GetCustomAttributes(System.Reflection.RuntimeFieldInfo, System.RuntimeType, ListBuilder`1<System.Attribute> ByRef)
       mov       rcx,[rsi+10]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       mov       edx,[rsi+1C]
       mov       r8d,[rsp+38]
       mov       r9,rdi
       call      qword ptr [7FFF827861F0]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
       mov       rsi,rax
       cmp       dword ptr [rsp+38],0
       jg        near ptr M01_L12
M01_L01:
       mov       rdx,rsi
M01_L02:
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L03
       mov       rcx,offset MT_System.Runtime.Serialization.EnumMemberAttribute[]
       cmp       [rdi],rcx
       je        short M01_L03
       call      qword ptr [7FFF824D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M01_L03:
       cmp       dword ptr [rdi+8],0
       jne       short M01_L05
       mov       rcx,offset MT_System.StringComparison
       cmp       [rbx],rcx
       jne       near ptr M01_L14
       mov       rcx,rbx
       call      qword ptr [7FFF824173B8]; System.Enum.ToString()
M01_L04:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L06:
       call      qword ptr [7FFF829EC348]
       mov       rcx,2923E3E81E0
       mov       rdx,2923E3E0210
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2923E3E0008
       call      qword ptr [7FFF824D6B08]; System.String.Concat(System.String, System.String)
       test      rax,rax
       je        short M01_L07
       xor       ecx,ecx
       cmp       dword ptr [rax+8],0
       sete      cl
       jmp       short M01_L08
M01_L07:
       mov       ecx,1
M01_L08:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       near ptr M01_L09
       call      qword ptr [7FFF829EC468]
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
       call      qword ptr [7FFF829E7A68]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF829EC5E8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFF824D7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFF829EC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFF82736670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L00
M01_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF82A54E58]
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
M01_L12:
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+38]
       lea       rcx,[rsp+28]
       mov       r8,rsi
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Attribute, System.Private.CoreLib]]
       call      qword ptr [7FFF82784BA0]
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,rsi
       mov       rdx,2923E3F2EE0
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       jmp       near ptr M01_L02
M01_L14:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       jmp       near ptr M01_L04
; Total bytes of code 797
```

## .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumExtensionsBenchmark.GetItems01()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.StringComparison
       call      CORINFO_HELP_NEWSFAST
       mov       ecx,[rbx+118]
       mov       [rax+8],ecx
       mov       rcx,rax
       call      qword ptr [7FFF82C86388]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2F7B99E2EB8
       mov       [rsi+8],rcx
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rbx,rax
       mov       rcx,rbx
       mov       rax,[rcx+18]
       mov       rdx,rax
       test      al,2
       jne       short M01_L00
       mov       rax,[rdx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L14
       call      qword ptr [7FFF82434918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       test      rax,rax
       jne       short M01_L02
       xor       edi,edi
       xor       ebp,ebp
       jmp       short M01_L03
M01_L02:
       lea       rdi,[rax+10]
       mov       ebp,[rax+8]
M01_L03:
       test      ebp,ebp
       je        near ptr M01_L11
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,rdi
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L12
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L04:
       xor       edi,edi
       mov       ebp,[r14+8]
       test      ebp,ebp
       jle       near ptr M01_L08
M01_L05:
       mov       ecx,edi
       mov       r15,[r14+rcx*8+10]
       mov       rcx,rbx
       test      r15,r15
       je        near ptr M01_L13
       lea       rdx,[r15+0C]
       mov       r8d,[r15+8]
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       lea       rdx,[rsp+48]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFF82434A98]; System.Enum.TryParse(System.Type, System.ReadOnlySpan`1<Char>, Boolean, Boolean, System.Object ByRef)
       mov       r13,[rsp+48]
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r13],rdx
       jne       short M01_L09
M01_L06:
       mov       r13d,[r13+8]
       mov       rdx,r15
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [rcx+8],eax
       jbe       short M01_L10
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       shl       rax,4
       lea       r15,[rcx+rax+10]
       mov       rcx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [r15+8],r13d
M01_L07:
       inc       edi
       cmp       ebp,edi
       jg        near ptr M01_L05
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
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
M01_L09:
       mov       rdx,r13
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FFF824E4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       jmp       near ptr M01_L06
M01_L10:
       mov       [rsp+28],rdx
       mov       [rsp+30],r13d
       mov       rcx,rsi
       lea       rdx,[rsp+28]
       call      qword ptr [7FFF82C86580]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
       jmp       short M01_L07
M01_L11:
       mov       rcx,7FFF82425120
       mov       edx,53
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2B727C01F00
       mov       r14,[rdx]
       jmp       near ptr M01_L04
M01_L12:
       call      qword ptr [7FFF82595BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L04
M01_L13:
       mov       ecx,7
       call      qword ptr [7FFF8271ECD0]
       int       3
M01_L14:
       call      qword ptr [7FFF82437138]
       int       3
; Total bytes of code 558
```

