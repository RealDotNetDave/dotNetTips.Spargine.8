## .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.EnumHelperBenchmark.GetValues()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       xor       ecx,ecx
       xor       edx,edx
       call      qword ptr [7FFE5CD77F78]; DotNetTips.Spargine.Core.EnumHelper.GetValues[[System.Net.Cache.RequestCacheLevel, System.Net.Primitives]](Boolean, Boolean)
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
       mov       rcx,[7FFE5CD6F0D8]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
       mov       rax,28548B34380
       test      ecx,ecx
       je        near ptr M01_L37
       mov       rcx,28548B34380
       call      qword ptr [7FFE5C424990]; System.Enum.GetValuesAsUnderlyingTypeNoCopy(System.RuntimeType)
       mov       rdi,rax
       mov       r8d,[rdi+8]
       test      r8d,r8d
       jl        near ptr M01_L36
       mov       [rsp+70],r8d
       cmp       dword ptr [rsp+70],0
       jl        near ptr M01_L38
       mov       rcx,28548B34380
       lea       r8,[rsp+70]
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.InternalCreate(System.RuntimeType, Int32, Int32*, Int32*)
       mov       rbp,rax
       mov       r8d,[rdi+8]
       test      r8d,r8d
       jl        near ptr M01_L36
       mov       rcx,rdi
       mov       rdx,rbp
       call      qword ptr [7FFE5C427738]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbp
       test      rax,rax
       je        near ptr M01_L39
       mov       rcx,offset MT_System.Int32[]
       cmp       [rax],rcx
       je        short M01_L00
       mov       rdx,rbp
       call      qword ptr [7FFE5C4D4390]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M01_L00:
       lea       rdi,[rax+10]
       mov       ebp,[rax+8]
M01_L01:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,244B6C033E0
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,244B28211F8
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M01_L24
M01_L02:
       cmp       [r15],r15b
       lea       r13,[r15+48]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M01_L40
M01_L03:
       cmp       [rcx],cl
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L47
       mov       r12,[rcx+8]
M01_L04:
       mov       r15d,[r12+8]
       mov       ecx,r15d
       xor       r8d,r8d
       mov       [rsp+58],r8
       mov       [rsp+60],r8
       mov       [rsp+68],r8d
       mov       [rsp+6C],ecx
       xor       r13d,r13d
       test      r15d,r15d
       jle       short M01_L07
M01_L05:
       mov       ecx,r13d
       mov       r8,[r12+rcx*8+10]
       mov       ecx,[r8+18]
       mov       edx,ecx
       and       edx,1A
       cmp       edx,ecx
       jne       short M01_L06
       lea       rcx,[rsp+58]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.FieldInfo, System.Private.CoreLib]]
       call      qword ptr [7FFE5C734BD0]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
M01_L06:
       inc       r13d
       cmp       r15d,r13d
       jg        short M01_L05
M01_L07:
       mov       r15,[rsp+58]
       mov       r13,[rsp+60]
       mov       r12d,[rsp+68]
       test      r12d,r12d
       je        near ptr M01_L46
       cmp       r12d,1
       je        near ptr M01_L48
       test      r12d,r12d
       jl        near ptr M01_L49
       mov       r13,r15
       test      r13,r13
       je        near ptr M01_L50
       cmp       [r15+8],r12d
       je        short M01_L08
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
       ja        near ptr M01_L26
       call      System.Buffer.__BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M01_L08:
       test      r15,r15
       je        near ptr M01_L27
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [r15],rcx
       jne       near ptr M01_L28
       lea       r13,[r15+10]
       mov       r15d,[r15+8]
M01_L09:
       xor       r12d,r12d
       test      r15d,r15d
       jle       near ptr M01_L17
M01_L10:
       cmp       r12d,r15d
       jae       near ptr M01_L51
       mov       ecx,r12d
       mov       rax,[r13+rcx*8]
       mov       [rsp+30],rax
       test      bl,bl
       jne       near ptr M01_L29
M01_L11:
       mov       rcx,rax
       mov       rdx,28548B343D0
       mov       r8d,1
       call      qword ptr [7FFE5C734168]; System.Attribute.GetCustomAttributes(System.Reflection.MemberInfo, System.Type, Boolean)
       test      rax,rax
       je        short M01_L12
       cmp       dword ptr [rax+8],0
       jne       near ptr M01_L32
M01_L12:
       xor       edx,edx
M01_L13:
       mov       rcx,rdx
       test      rcx,rcx
       je        short M01_L14
       mov       rax,offset MT_System.ComponentModel.DescriptionAttribute
       cmp       [rcx],rax
       je        short M01_L14
       mov       rcx,rax
       call      qword ptr [7FFE5C4D43F0]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M01_L14:
       test      rcx,rcx
       jne       near ptr M01_L23
       test      sil,sil
       jne       near ptr M01_L43
       mov       rdx,offset MT_System.Reflection.MdFieldInfo
       mov       rax,[rsp+30]
       cmp       [rax],rdx
       jne       near ptr M01_L42
       mov       r10,rax
       mov       [rsp+28],r10
       mov       r8,[r10+20]
       test      r8,r8
       je        near ptr M01_L41
M01_L15:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L44
       lea       eax,[rdx+1]
       mov       [r14+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
M01_L16:
       inc       r12d
       cmp       r12d,r15d
       jl        near ptr M01_L10
M01_L17:
       mov       rdx,r14
       mov       r8d,[rdx+10]
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableExtensions.ToArray[[System.String, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, Int32)
       call      qword ptr [7FFE5CE15080]; System.Collections.Immutable.ImmutableExtensions.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       test      rax,rax
       je        near ptr M01_L45
       lea       r15,[rax+10]
       mov       r13d,[rax+8]
M01_L18:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Core.EnumValue, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       test      ebp,ebp
       je        near ptr M01_L34
       mov       edx,ebp
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[r12+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L19:
       mov       ebx,ebp
       xor       esi,esi
       test      ebp,ebp
       jle       short M01_L22
M01_L20:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.EnumValue
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       cmp       esi,ebx
       jae       near ptr M01_L51
       mov       ecx,esi
       mov       ecx,[rdi+rcx*4]
       cmp       esi,r13d
       jae       near ptr M01_L51
       mov       edx,esi
       mov       rdx,[r15+rdx*8]
       mov       [r14+10],ecx
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       near ptr M01_L35
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,r14
       call      CORINFO_HELP_ARRADDR_ST
M01_L21:
       add       esi,1
       jo        near ptr M01_L36
       cmp       esi,ebp
       jl        short M01_L20
M01_L22:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection`1[[DotNetTips.Spargine.Core.EnumValue, DotNetTips.Spargine.8.Core]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
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
M01_L23:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       mov       r8d,[rcx+8]
       cmp       r8d,edx
       jbe       short M01_L25
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L16
M01_L24:
       mov       rcx,28548B34380
       call      qword ptr [7FFE5C426658]; System.RuntimeType.InitializeCache()
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L25:
       mov       rcx,r14
       mov       rdx,rax
       call      qword ptr [7FFE5C58E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L16
M01_L26:
       call      qword ptr [7FFE5C585BD8]; System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L08
M01_L27:
       xor       r13d,r13d
       xor       r15d,r15d
       jmp       near ptr M01_L09
M01_L28:
       call      qword ptr [7FFE5C6CE988]
       int       3
M01_L29:
       mov       rcx,rax
       mov       rdx,28548B343A8
       mov       r8d,1
       call      qword ptr [7FFE5C7341F8]; System.Attribute.GetCustomAttribute(System.Reflection.MemberInfo, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlEnumAttribute
       call      qword ptr [7FFE5C4D43D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rax,rax
       je        short M01_L30
       mov       rdx,[rax+8]
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       eax,[r14+10]
       cmp       [rcx+8],eax
       jbe       short M01_L31
       lea       r8d,[rax+1]
       mov       [r14+10],r8d
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L16
M01_L30:
       mov       rax,[rsp+30]
       jmp       near ptr M01_L11
M01_L31:
       mov       rcx,r14
       call      qword ptr [7FFE5C58E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L16
M01_L32:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M01_L33
       mov       rdx,rcx
       jmp       near ptr M01_L13
M01_L33:
       call      qword ptr [7FFE5C6CF1C8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
M01_L34:
       mov       rcx,7FFE5C415120
       mov       edx,5C
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rcx,244B6C035C0
       mov       rdx,[rcx]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L19
M01_L35:
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFE5C58E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L21
M01_L36:
       call      CORINFO_HELP_OVERFLOW
M01_L37:
       call      qword ptr [7FFE5C427138]
       int       3
M01_L38:
       call      qword ptr [7FFE5C6CEAD8]
       int       3
M01_L39:
       xor       edi,edi
       xor       ebp,ebp
       jmp       near ptr M01_L01
M01_L40:
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
       jmp       near ptr M01_L03
M01_L41:
       mov       rcx,[r10+10]
       cmp       [rcx],cl
       call      System.RuntimeTypeHandle.GetModule(System.RuntimeType)
       cmp       [rax],al
       lea       rcx,[rsp+48]
       mov       rdx,rax
       call      qword ptr [7FFE5C71E4D8]; System.ModuleHandle.GetMetadataImport(System.Reflection.RuntimeModule)
       mov       rax,[rsp+28]
       mov       r8d,[rax+1C]
       lea       rdx,[rsp+38]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFE5C71F4B0]; System.Reflection.MetadataImport.GetName(Int32)
       lea       rcx,[rsp+38]
       call      qword ptr [7FFE5C735230]; System.MdUtf8String.ToString()
       mov       r8,rax
       mov       [rsp+20],r8
       mov       rcx,[rsp+28]
       lea       rcx,[rcx+20]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rsp+20]
       jmp       near ptr M01_L15
M01_L42:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       r8,rax
       jmp       near ptr M01_L15
M01_L43:
       mov       rcx,[rsp+30]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,rax
       call      qword ptr [7FFE5CD77F18]
       mov       r8,rax
       jmp       near ptr M01_L15
M01_L44:
       mov       rcx,r14
       mov       rdx,r8
       call      qword ptr [7FFE5C58E130]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L16
M01_L45:
       xor       r15d,r15d
       xor       r13d,r13d
       jmp       near ptr M01_L18
M01_L46:
       mov       rcx,244B6C03530
       mov       r15,[rcx]
       jmp       near ptr M01_L08
M01_L47:
       xor       r8d,r8d
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFE5C734E88]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r12,rax
       jmp       near ptr M01_L04
M01_L48:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       mov       rcx,r15
       mov       r8,r13
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       near ptr M01_L08
M01_L49:
       mov       ecx,47
       mov       edx,0D
       call      qword ptr [7FFE5C6CED48]
       int       3
M01_L50:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       r15,rax
       jmp       near ptr M01_L08
M01_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1829
```

