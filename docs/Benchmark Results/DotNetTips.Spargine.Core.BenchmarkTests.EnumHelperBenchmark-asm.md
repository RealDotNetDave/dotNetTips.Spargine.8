## .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetValues()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       xor       ecx,ecx
       xor       edx,edx
       call      qword ptr [7FFF3AACEBB0]; DotNetTips.Spargine.Core.EnumHelper.GetValues[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]](Boolean, Boolean)
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
; DotNetTips.Spargine.Core.EnumHelper.GetValues[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]](Boolean, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       esi,ecx
       mov       ebx,edx
       mov       rcx,[7FFF3AAD67F8]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
       mov       rax,23378A0AAF0
       test      ecx,ecx
       je        near ptr M01_L33
       mov       rcx,23378A0AAF0
       call      qword ptr [7FFF3A274990]; System.Enum.GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType)
       mov       rdi,rax
       mov       r8d,[rdi+8]
       test      r8d,r8d
       jl        near ptr M01_L32
       mov       [rsp+70],r8d
       cmp       dword ptr [rsp+70],0
       jl        near ptr M01_L34
       mov       rcx,23378A0AAF0
       lea       r8,[rsp+70]
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.InternalCreate(System.RuntimeType, Int32, Int32*, Int32*)
       mov       rbp,rax
       mov       r8d,[rdi+8]
       test      r8d,r8d
       jl        near ptr M01_L32
       mov       rcx,rdi
       mov       rdx,rbp
       call      qword ptr [7FFF3A277738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rdi,rbp
       test      rdi,rdi
       je        short M01_L00
       mov       rcx,offset MT_System.Int32[]
       cmp       [rdi],rcx
       je        short M01_L00
       mov       rdx,rbp
       call      qword ptr [7FFF3A324390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M01_L00:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Core.EnumValue, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1F2E6C01F30
       mov       rdx,[rcx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1F2E6C01D80
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1F2E0EE11F8
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L20
M01_L01:
       cmp       [r15],r15b
       lea       r13,[r15+48]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M01_L35
M01_L02:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L40
       mov       r12,[rcx+8]
M01_L03:
       mov       r15d,[r12+8]
       mov       ecx,r15d
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8
       mov       [rsp+68],r8d
       mov       [rsp+6C],ecx
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M01_L06
M01_L04:
       mov       ecx,r13d
       mov       r8,[r12+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,1A
       cmp       edx,ecx
       jne       short M01_L05
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF3A554BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L05:
       inc       r13d
       cmp       r15d,r13d
       jg        short M01_L04
M01_L06:
       mov       r15,[rsp+58]
       mov       r13,[rsp+60]
       mov       r12d,[rsp+68]
       test      r12d,r12d
       je        near ptr M01_L39
       cmp       r12d,1
       je        near ptr M01_L41
       test      r12d,r12d
       jl        near ptr M01_L42
       mov       r13,r15
       test      r13,r13
       je        near ptr M01_L43
       cmp       [r15+8],r12d
       je        short M01_L07
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       lea       rcx,[r15+10]
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       cmp       r12d,r8d
       cmovg     r12d,r8d
       mov       r8d,r12d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L28
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L07:
       test      r15,r15
       je        near ptr M01_L44
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [r15],rcx
       jne       near ptr M01_L45
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
M01_L08:
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M01_L16
M01_L09:
       cmp       r12d,r15d
       jae       near ptr M01_L50
       mov       ecx,r12d
       mov       rax,[r13+rcx*8]
       mov       [rsp+30],rax
       test      bl,bl
       jne       near ptr M01_L46
M01_L10:
       mov       rcx,rax
       mov       rdx,23378A0ABE0
       mov       r8d,1
       call      qword ptr [7FFF3A554168]; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       test      rax,rax
       je        short M01_L11
       cmp       dword ptr [rax+8],0
       jne       near ptr M01_L49
M01_L11:
       xor       edx,edx
M01_L12:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L13
       mov       rax,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rcx],rax
       je        short M01_L13
       mov       rcx,rax
       call      qword ptr [7FFF3A3243F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M01_L13:
       test      rcx,rcx
       jne       near ptr M01_L19
       test      sil,sil
       jne       near ptr M01_L38
       mov       rdx,offset MT_System.Reflection.MdFieldInfo
       mov       rax,[rsp+30]
       cmp       [rax],rdx
       jne       near ptr M01_L37
       mov       r10,rax
       mov       [rsp+28],r10
       mov       r8,[r10+20]
       test      r8,r8
       je        near ptr M01_L36
M01_L14:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L17
       lea       eax,[rdx+1]
       mov       [r14+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L15:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M01_L09
M01_L16:
       mov       rdx,r14
       jmp       short M01_L18
M01_L17:
       mov       rcx,r14
       mov       rdx,r8
       call      qword ptr [7FFF3A3DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L15
M01_L18:
       mov       r8d,[rdx+10]
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableExtensions.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FFF3AB15920]; System.Collections.Immutable.ImmutableExtensions.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rbx,rax
       xor       esi,esi
       mov       r14d,[rdi+8]
       test      r14d,r14d
       jle       near ptr M01_L24
       jmp       short M01_L21
M01_L19:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       near ptr M01_L30
       lea       r10d,[rdx+1]
       mov       [r14+10],r10d
       cmp       edx,r8d
       jae       near ptr M01_L50
       mov       edx,edx
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L20:
       mov       rcx,23378A0AAF0
       call      qword ptr [7FFF3A276658]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       near ptr M01_L01
M01_L21:
       test      rbx,rbx
       je        near ptr M01_L26
       cmp       [rbx+8],r14d
       jl        near ptr M01_L26
M01_L22:
       mov       ecx,esi
       mov       r15d,[rdi+rcx*4+10]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       ecx,esi
       mov       rdx,[rbx+rcx*8+10]
       mov       [r13+10],r15d
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       r12d,[rbp+10]
       cmp       [rcx+8],r12d
       jbe       short M01_L25
       lea       edx,[r12+1]
       mov       [rbp+10],edx
       movsxd    rdx,r12d
       mov       r8,r13
       call      CORINFO_HELP_ARRADDR_ST
M01_L23:
       add       esi,1
       jo        near ptr M01_L32
       cmp       r14d,esi
       jg        short M01_L22
M01_L24:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Core.EnumValue, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L25:
       mov       rcx,rbp
       mov       rdx,r13
       call      qword ptr [7FFF3A3DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L23
M01_L26:
       cmp       esi,r14d
       jae       near ptr M01_L50
       mov       ecx,esi
       mov       r15d,[rdi+rcx*4+10]
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       cmp       esi,[rbx+8]
       jae       near ptr M01_L50
       mov       ecx,esi
       mov       rdx,[rbx+rcx*8+10]
       mov       [r13+10],r15d
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       r12d,[rbp+10]
       cmp       [rcx+8],r12d
       jbe       short M01_L29
       lea       edx,[r12+1]
       mov       [rbp+10],edx
       movsxd    rdx,r12d
       mov       r8,r13
       call      CORINFO_HELP_ARRADDR_ST
M01_L27:
       add       esi,1
       jo        short M01_L32
       cmp       r14d,esi
       jg        short M01_L26
       jmp       near ptr M01_L24
M01_L28:
       call      qword ptr [7FFF3A3D5BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L07
M01_L29:
       mov       rcx,rbp
       mov       rdx,r13
       call      qword ptr [7FFF3A3DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L27
M01_L30:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFF3A3DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L15
M01_L31:
       call      qword ptr [7FFF3A4DF198]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L32:
       call      CORINFO_HELP_OVERFLOW
M01_L33:
       call      qword ptr [7FFF3A277138]
       int       3
M01_L34:
       call      qword ptr [7FFF3A4DEAA8]
       int       3
M01_L35:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.Reflection.RuntimeFieldInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r12
       jmp       near ptr M01_L02
M01_L36:
       mov       rcx,[r10+10]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       cmp       [rax],al
       lea       rcx,[rsp+48]
       mov       rdx,rax
       call      qword ptr [7FFF3A53E4D8]; System.ModuleHandle.GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rax,[rsp+28]
       mov       r8d,[rax+1C]
       lea       rdx,[rsp+38]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFF3A53F4B0]; System.Reflection.MetadataImport.GetName(Int32)
       lea       rcx,[rsp+38]
       call      qword ptr [7FFF3A555230]; System.MdUtf8String.ToString()
       mov       r8,rax
       mov       [rsp+20],r8
       mov       rcx,[rsp+28]
       lea       rcx,[rcx+20]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+20]
       jmp       near ptr M01_L14
M01_L37:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r8,rax
       jmp       near ptr M01_L14
M01_L38:
       mov       rcx,[rsp+30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      qword ptr [7FFF3AACEB50]
       mov       r8,rax
       jmp       near ptr M01_L14
M01_L39:
       mov       rcx,7FFF3A265120
       mov       edx,5D
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,1F2E6C01F40
       mov       r15,[rcx]
       jmp       near ptr M01_L07
M01_L40:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFF3A554E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,r13
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L07
M01_L42:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFF3A4DED18]
       int       3
M01_L43:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       jmp       near ptr M01_L07
M01_L44:
       xor       r13d,r13d
       xor       r15d,r15d
       jmp       near ptr M01_L08
M01_L45:
       call      qword ptr [7FFF3A4DE958]
       int       3
M01_L46:
       mov       rcx,rax
       mov       rdx,23378A0ABB8
       mov       r8d,1
       call      qword ptr [7FFF3A5541F8]; System.Attribute.GetCustomAttribute(System.Reflection.MemberInfo, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlEnumAttribute
       call      qword ptr [7FFF3A3243D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L47
       mov       rdx,[rax+8]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       cmp       [rcx+8],eax
       jbe       short M01_L48
       lea       r8d,[rax+1]
       mov       [r14+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L15
M01_L47:
       mov       rax,[rsp+30]
       jmp       near ptr M01_L10
M01_L48:
       mov       rcx,r14
       call      qword ptr [7FFF3A3DE130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L15
M01_L49:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       near ptr M01_L31
       mov       rdx,rcx
       jmp       near ptr M01_L12
M01_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1890
```

