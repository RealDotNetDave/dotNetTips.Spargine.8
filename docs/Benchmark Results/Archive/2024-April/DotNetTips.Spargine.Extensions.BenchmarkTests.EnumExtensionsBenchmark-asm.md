## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C64F378]; DotNetTips.Spargine.Extensions.EnumExtensions.GetDescription(System.Enum)
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
       call      qword ptr [7FF80BDF73B8]; System.Enum.ToString()
M01_L00:
       mov       rcx,rsi
       mov       rdx,rax
       mov       r8d,1C
       call      qword ptr [7FF80BDFA630]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       mov       r8,offset MT_System.Reflection.MdFieldInfo
       cmp       [rsi],r8
       jne       near ptr M01_L13
       mov       rdi,26FA4942EE0
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
       call      qword ptr [7FF80C1663E8]; System.Reflection.PseudoCustomAttribute.GetCustomAttributes(System.Reflection.RuntimeFieldInfo, System.RuntimeType, ListBuilder`1<System.Attribute> ByRef)
       mov       rcx,[rsi+10]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       mov       rcx,rax
       mov       edx,[rsi+1C]
       mov       r8d,[rsp+38]
       mov       r9,rdi
       call      qword ptr [7FF80C1661F0]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeModule, Int32, Int32, System.RuntimeType)
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
       call      qword ptr [7FF80BEB4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M01_L03:
       cmp       dword ptr [rdi+8],0
       jne       short M01_L05
       mov       rcx,offset MT_System.StringComparison
       cmp       [rbx],rcx
       jne       near ptr M01_L14
       mov       rcx,rbx
       call      qword ptr [7FF80BDF73B8]; System.Enum.ToString()
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
       call      qword ptr [7FF80C3CC348]
       mov       rcx,26FA49381E0
       mov       rdx,26FA4930210
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,26FA4930008
       call      qword ptr [7FF80BEB6B08]; System.String.Concat(System.String, System.String)
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
       call      qword ptr [7FF80C3CC468]
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
       call      qword ptr [7FF80C3C7A68]
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3CC060]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80C3CC5E8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L09:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80BEB7318]; System.String.Trim()
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF80C3CC060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF80C116670]
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
       call      qword ptr [7FF80C434E58]
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
M01_L12:
       mov       r9d,[rsi+8]
       sub       r9d,[rsp+38]
       lea       rcx,[rsp+28]
       mov       r8,rsi
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Attribute, System.Private.CoreLib]]
       call      qword ptr [7FF80C164BA0]
       jmp       near ptr M01_L01
M01_L13:
       mov       rcx,rsi
       mov       rdx,26FA4942EE0
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

## .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
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
       call      qword ptr [7FF80C666388]; DotNetTips.Spargine.Extensions.EnumExtensions.GetItems(System.Enum)
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2F466DC2EB8
       mov       [rsi+8],rcx
       xor       edi,edi
       mov       rcx,rbx
       call      System.Object.GetType()
       mov       rbx,rax
       jmp       near ptr M01_L08
M01_L00:
       mov       rcx,rbx
       mov       rax,[rcx+18]
       mov       rdx,rax
       test      al,2
       jne       short M01_L01
       mov       rax,[rdx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L24
       call      qword ptr [7FF80BE14918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       test      rax,rax
       jne       short M01_L03
       xor       r15d,r15d
       xor       ebp,ebp
       jmp       short M01_L04
M01_L03:
       lea       r15,[rax+10]
       mov       ebp,[rax+8]
M01_L04:
       test      ebp,ebp
       je        near ptr M01_L13
       movsxd    rdx,ebp
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r14,rax
       lea       rcx,[r14+10]
       mov       rdx,r15
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L11
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L05:
       cmp       edi,[r14+8]
       jae       near ptr M01_L25
       mov       ecx,edi
       mov       rbp,[r14+rcx*8+10]
       mov       rcx,rbx
       test      rbp,rbp
       je        near ptr M01_L23
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       mov       [rsp+40],rdx
       mov       [rsp+48],r8d
       lea       rdx,[rsp+50]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+40]
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FF80BE14A98]; System.Enum.TryParse(System.Type, System.ReadOnlySpan`1<Char>, Boolean, Boolean, System.Object ByRef)
       mov       r14,[rsp+50]
       xor       edx,edx
       mov       [rsp+50],rdx
       mov       rdx,offset MT_System.Int32
       cmp       [r14],rdx
       jne       short M01_L09
M01_L06:
       mov       r14d,[r14+8]
       mov       rdx,rbp
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       eax,[rsi+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L16
       lea       r8d,[rax+1]
       mov       [rsi+10],r8d
       mov       eax,eax
       shl       rax,4
       lea       rbp,[rcx+rax+10]
       mov       rcx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       [rbp+8],r14d
M01_L07:
       add       edi,1
       jo        near ptr M01_L22
M01_L08:
       mov       rcx,rbx
       mov       rax,[rcx+18]
       mov       rdx,rax
       test      al,2
       jne       short M01_L10
       mov       rax,[rdx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
       jmp       short M01_L12
M01_L09:
       mov       rdx,r14
       mov       rcx,offset MT_System.Int32
       call      qword ptr [7FF80BEC4408]; System.Runtime.CompilerServices.CastHelpers.Unbox(Void*, System.Object)
       jmp       short M01_L06
M01_L10:
       xor       eax,eax
       jmp       short M01_L12
M01_L11:
       call      qword ptr [7FF80BF75BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L05
M01_L12:
       movzx     eax,al
       test      eax,eax
       je        near ptr M01_L24
       call      qword ptr [7FF80BE14918]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       test      rax,rax
       jne       short M01_L14
       jmp       near ptr M01_L20
M01_L13:
       mov       rcx,7FF80BE05120
       mov       edx,53
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2B3D5001F00
       mov       r14,[rdx]
       jmp       near ptr M01_L05
M01_L14:
       lea       rbp,[rax+10]
       mov       r14d,[rax+8]
M01_L15:
       test      r14d,r14d
       jne       short M01_L18
       jmp       near ptr M01_L21
M01_L16:
       mov       [rsp+30],rdx
       mov       [rsp+38],r14d
       mov       rcx,rsi
       lea       rdx,[rsp+30]
       call      qword ptr [7FF80C666580]; System.Collections.Generic.List`1[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]].AddWithResize(System.ValueTuple`2<System.__Canon,Int32>)
       jmp       near ptr M01_L07
M01_L17:
       call      qword ptr [7FF80BF75BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L19
M01_L18:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbp
       mov       r8d,r14d
       shl       r8,3
       cmp       r8,4000
       ja        short M01_L17
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L19:
       cmp       [r15+8],edi
       jg        near ptr M01_L00
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[System.ValueTuple`2[[System.String, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L20:
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       near ptr M01_L15
M01_L21:
       mov       rcx,7FF80BE05120
       mov       edx,53
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,2B3D5001F00
       mov       r15,[rcx]
       jmp       short M01_L19
M01_L22:
       call      CORINFO_HELP_OVERFLOW
M01_L23:
       mov       ecx,7
       call      qword ptr [7FF80C0FECD0]
       int       3
M01_L24:
       call      qword ptr [7FF80BE17138]
       int       3
M01_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 771
```

