## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredFields>d__1
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,16E5CAD45A8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
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
; Total bytes of code 99
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllDeclaredMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllDeclaredMethods>d__2
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,2D2071945A8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
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
; Total bytes of code 99
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllFields()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllFields>d__3
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,2EFCDA945A8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
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
; Total bytes of code 99
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllMethods()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllMethods>d__5
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,304A78D45A8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
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
; Total bytes of code 99
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetAllProperties()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.TypeExtensions+<GetAllProperties>d__6
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+30],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+34],eax
       mov       rcx,1C25C9345A8
       mov       [rsi+18],rcx
       mov       [rsp+20],rsi
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
; Total bytes of code 99
```

## .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.TypeExtensionsBenchmark.GetTypeOfType()
       push      rbp
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rcx,1CD493A2290
       cmp       [rcx],ecx
       call      qword ptr [7FFE3F1CA5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L05
       mov       rcx,1CD493A2290
       call      System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)
       test      al,20
       jne       near ptr M00_L08
       mov       rcx,1CD493A2290
       cmp       [rcx],ecx
       call      qword ptr [7FFE3F1CA5D8]; System.RuntimeType.IsValueTypeImpl()
       test      eax,eax
       jne       near ptr M00_L08
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       dword ptr [rsp+28],3
       mov       [rsp+30],rcx
       mov       [rsp+38],rcx
       mov       rcx,1CD493A2290
       mov       rdx,1CD493B45D0
       mov       r8d,0FFFFFFFF
       mov       r9d,1C
       call      qword ptr [7FFE3F1D6838]; System.RuntimeType.GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       mov       rdx,1CD493AE128
       mov       r8d,1
       call      qword ptr [7FFE3F48E9D0]; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       test      rax,rax
       je        short M00_L00
       cmp       dword ptr [rax+8],0
       jne       short M00_L06
M00_L00:
       xor       edx,edx
M00_L01:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M00_L03
       mov       r8,offset MT_System.Runtime.CompilerServices.CompilerGeneratedAttribute
       cmp       [rcx],r8
       jne       short M00_L02
       mov       r10d,3
       jmp       short M00_L04
M00_L02:
       mov       rcx,r8
       call      qword ptr [7FFE3F2843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       int       3
M00_L03:
       mov       r10d,2
M00_L04:
       mov       [rbp-10],r10d
       mov       rcx,[rbx+18]
       cmp       [rcx],cl
       lea       rcx,[rbp-10]
       call      qword ptr [7FFE3FBAC048]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeOfType, DotNetTips.Spargine.8.Extensions]](DotNetTips.Spargine.Extensions.TypeOfType ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       ret
M00_L05:
       mov       r10d,1
       jmp       short M00_L04
M00_L06:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M00_L07
       mov       rdx,rcx
       jmp       short M00_L01
M00_L07:
       call      qword ptr [7FFE3F5F5FE0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M00_L08:
       xor       r10d,r10d
       jmp       short M00_L04
; Total bytes of code 312
```
```assembly
; System.RuntimeType.IsValueTypeImpl()
       sub       rsp,28
       mov       rax,[rcx+18]
       mov       rdx,rax
       test      al,2
       jne       short M01_L00
       mov       eax,[rdx]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       rdx,1CD493A5358
       call      qword ptr [7FFE3F1CA7A8]; System.RuntimeType.IsSubclassOf(System.Type)
       nop
       add       rsp,28
       ret
; Total bytes of code 60
```
```assembly
; System.RuntimeType.GetMethodImplCommon(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.Binder, System.Reflection.CallingConventions, System.Type[], System.Reflection.ParameterModifier[])
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vzeroupper
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rdi,rcx
       mov       ebx,r8d
       mov       esi,r9d
       mov       r14d,[rsp+0D8]
       mov       rbp,[rsp+0E0]
       mov       r15,rdx
       test      r15,r15
       je        near ptr M02_L29
       test      sil,1
       jne       near ptr M02_L13
       mov       r13d,1
M02_L00:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        near ptr M02_L12
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M02_L12
M02_L01:
       cmp       [r12],r12b
       lea       rdi,[r12+38]
       mov       rax,[rdi]
       test      rax,rax
       jne       short M02_L02
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeMethodInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       lea       rcx,[rax+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,[rsp+30]
       mov       rcx,rdi
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       cmove     rax,r12
M02_L02:
       mov       rdi,rax
       cmp       [rdi],dil
       cmp       r13d,1
       jne       near ptr M02_L30
       lea       rcx,[rdi+20]
       mov       r8,r15
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeMethodInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE3F486868]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       je        near ptr M02_L14
M02_L03:
       mov       r13,rax
M02_L04:
       mov       edi,[r13+8]
       mov       ecx,edi
       xor       eax,eax
       mov       [rsp+38],rax
       mov       [rsp+40],rax
       mov       [rsp+48],eax
       mov       [rsp+4C],ecx
       xor       r15d,r15d
       test      edi,edi
       jle       short M02_L08
M02_L05:
       mov       ecx,r15d
       mov       r12,[r13+rcx*8+10]
       cmp       ebx,0FFFFFFFF
       je        short M02_L06
       mov       rcx,[r12+50]
       call      System.RuntimeMethodHandle.GetGenericParameterCount(System.RuntimeMethodHandleInternal)
       cmp       eax,ebx
       jne       short M02_L07
M02_L06:
       mov       [rsp+20],rbp
       mov       edx,[r12+58]
       mov       rcx,r12
       mov       r8d,esi
       mov       r9d,r14d
       call      qword ptr [7FFE3F1D65B0]; System.RuntimeType.FilterApplyMethodBase(System.Reflection.MethodBase, System.Reflection.BindingFlags, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[])
       test      eax,eax
       je        short M02_L07
       lea       rcx,[rsp+38]
       mov       r8,r12
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE3F48F438]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M02_L07:
       inc       r15d
       cmp       edi,r15d
       jg        short M02_L05
M02_L08:
       vmovdqu   xmm0,xmmword ptr [rsp+38]
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       rax,[rsp+48]
       mov       [rsp+60],rax
       cmp       dword ptr [rsp+60],0
       je        near ptr M02_L19
       test      rbp,rbp
       jne       near ptr M02_L20
M02_L09:
       cmp       qword ptr [rsp+50],0
       je        short M02_L11
       mov       rax,[rsp+50]
       cmp       dword ptr [rax+8],0
       jbe       near ptr M02_L31
       mov       rax,[rsp+50]
       mov       rdi,[rax+10]
M02_L10:
       cmp       dword ptr [rsp+60],1
       jne       near ptr M02_L21
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rdi,[rsp+58]
       jmp       short M02_L10
M02_L12:
       mov       rcx,rdi
       call      qword ptr [7FFE3F1D6658]; System.RuntimeType.InitializeCache()
       mov       r12,rax
       jmp       near ptr M02_L01
M02_L13:
       mov       rcx,18CB7400590
       mov       rcx,[rcx]
       mov       rdx,r15
       call      qword ptr [7FFE3F52EFB8]
       mov       r15,rax
       mov       r13d,2
       jmp       near ptr M02_L00
M02_L14:
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FFE3F48F6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       jmp       near ptr M02_L03
M02_L15:
       lea       rcx,[rdi+28]
       mov       r8,r15
       mov       rdx,offset MT_System.Reflection.CerHashtable`2[[System.String, System.Private.CoreLib],[System.Reflection.RuntimeMethodInfo[], System.Private.CoreLib]]
       call      qword ptr [7FFE3F486868]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       mov       r13,rax
       test      r13,r13
       jne       short M02_L16
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8d,2
       xor       r9d,r9d
       call      qword ptr [7FFE3F48F6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
M02_L16:
       jmp       near ptr M02_L04
M02_L17:
       cmp       byte ptr [rdi+18],0
       je        short M02_L18
       mov       r13,[rdi+8]
       jmp       near ptr M02_L04
M02_L18:
       mov       rcx,rdi
       mov       r8d,r13d
       xor       edx,edx
       xor       r9d,r9d
       call      qword ptr [7FFE3F48F6F0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M02_L04
M02_L19:
       xor       eax,eax
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L20:
       cmp       dword ptr [rbp+8],0
       jne       near ptr M02_L27
       jmp       near ptr M02_L09
M02_L21:
       test      rbp,rbp
       jne       near ptr M02_L27
       mov       esi,1
       jmp       short M02_L26
M02_L22:
       cmp       qword ptr [rsp+50],0
       jne       short M02_L23
       mov       rcx,[rsp+58]
       jmp       short M02_L24
M02_L23:
       mov       rcx,[rsp+50]
       cmp       esi,[rcx+8]
       jae       near ptr M02_L31
       mov       rcx,[rsp+50]
       mov       edx,esi
       mov       rcx,[rcx+rdx*8+10]
M02_L24:
       mov       rdx,rdi
       call      qword ptr [7FFE3F937288]
       test      eax,eax
       jne       short M02_L25
       mov       rcx,rdi
       call      qword ptr [7FFE3F5F5FC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M02_L25:
       inc       esi
M02_L26:
       cmp       esi,[rsp+60]
       jl        short M02_L22
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE3F48F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       edx,[rsp+60]
       call      qword ptr [7FFE3F9372B8]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      qword ptr [7FFE3F284360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L27:
       mov       rbx,[rsp+0D0]
       test      rbx,rbx
       jne       short M02_L28
       call      qword ptr [7FFE3F1D5FC8]; System.Type.get_DefaultBinder()
       mov       rbx,rax
M02_L28:
       lea       rcx,[rsp+50]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.MethodInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE3F48F3F0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r8,rax
       mov       rdi,[rsp+0E8]
       mov       [rsp+20],rdi
       mov       edx,esi
       mov       rcx,rbx
       mov       r9,rbp
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      qword ptr [7FFE3F284360]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L29:
       xor       r13d,r13d
       jmp       near ptr M02_L00
M02_L30:
       cmp       r13d,2
       je        near ptr M02_L15
       jmp       near ptr M02_L17
M02_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1005
```
```assembly
; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M03_L11
       test      rbx,rbx
       je        near ptr M03_L16
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M03_L13
       mov       rbp,1CD493A20B0
       mov       rcx,rbx
       call      qword ptr [7FFE3F1D7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M03_L12
M03_L00:
       cmp       rax,rbp
       je        short M03_L01
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFE3F1D7330]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        near ptr M03_L12
       jmp       short M03_L00
M03_L01:
       mov       r14,[rsi]
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r14,rcx
       jne       near ptr M03_L15
       mov       ecx,8
M03_L02:
       cmp       ecx,2
       je        near ptr M03_L10
       cmp       ecx,10
       je        near ptr M03_L07
       mov       r8,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       r14,r8
       jne       near ptr M03_L19
       mov       r8,offset MT_System.RuntimeType
       cmp       [rbx],r8
       jne       near ptr M03_L17
       mov       rdx,rbx
M03_L03:
       test      rdx,rdx
       je        near ptr M03_L18
       mov       r8,offset MT_System.RuntimeType
       cmp       [rdx],r8
       jne       near ptr M03_L18
       movzx     r8d,dil
       mov       rcx,rsi
       call      qword ptr [7FFE3F4A4E58]; System.Reflection.CustomAttribute.GetCustomAttributes(System.Reflection.RuntimeMethodInfo, System.RuntimeType, Boolean)
M03_L04:
       mov       r8,rax
       test      r8,r8
       je        short M03_L05
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M03_L05
       mov       rdx,rax
       call      qword ptr [7FFE3F284390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M03_L05:
       mov       rax,r8
M03_L06:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L07:
       mov       rcx,rsi
       mov       rdx,offset MT_System.Reflection.PropertyInfo
       cmp       r14,rdx
       jne       short M03_L09
M03_L08:
       movzx     r8d,dil
       mov       rdx,rbx
       call      qword ptr [7FFE3F48E868]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       short M03_L06
M03_L09:
       mov       rcx,rdx
       mov       rdx,rsi
       call      qword ptr [7FFE3F2843F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
       jmp       short M03_L08
M03_L10:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FFE3F2843D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       movzx     r8d,dil
       mov       rdx,rbx
       call      qword ptr [7FFE3F48E8B0]
       jmp       short M03_L06
M03_L11:
       mov       ecx,0D9
       mov       rdx,7FFE3F134000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE3F486790]
       int       3
M03_L12:
       mov       rcx,1CD493A2008
       cmp       rbp,rcx
       jne       short M03_L14
       mov       rcx,1CD493A2008
       cmp       rbx,rcx
       jne       near ptr M03_L01
       jmp       short M03_L14
M03_L13:
       mov       rcx,rbx
       mov       rdx,1CD493A20B0
       mov       rax,[rbx]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M03_L01
M03_L14:
       mov       rcx,1CD493A20B0
       cmp       rbx,rcx
       je        near ptr M03_L01
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFE3F84D500]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFE3F28F708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M03_L15:
       mov       rcx,rsi
       mov       rax,[r14+40]
       call      qword ptr [rax+28]
       mov       ecx,eax
       jmp       near ptr M03_L02
M03_L16:
       mov       ecx,0E9
       mov       rdx,7FFE3F134000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFE3F486790]
       int       3
M03_L17:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M03_L03
M03_L18:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFE3F847E10]
       mov       rbx,rax
       mov       ecx,0E9
       mov       rdx,7FFE3F134000
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFE3F28F750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M03_L19:
       movzx     r8d,dil
       mov       rcx,rsi
       mov       rdx,rbx
       mov       rax,[r14+48]
       call      qword ptr [rax+28]
       jmp       near ptr M03_L04
; Total bytes of code 696
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
       jne       short M04_L03
M04_L01:
       mov       rax,rdx
       ret
M04_L02:
       jmp       qword ptr [7FFE3F2843A8]
M04_L03:
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
       jne       short M04_L00
       jmp       short M04_L02
; Total bytes of code 71
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[DotNetTips.Spargine.Extensions.TypeOfType, DotNetTips.Spargine.8.Extensions]](DotNetTips.Spargine.Extensions.TypeOfType ByRef)
       ret
; Total bytes of code 1
```
**Extern method**
System.RuntimeTypeHandle.GetAttributes(System.RuntimeType)

